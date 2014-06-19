using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using LumiSoft.Net.IMAP;
using LumiSoft.Net.IMAP.Client;
using PovonMail.XMLHandle;
using PovonMail.SecurityHandle;
using PovonMail.CommonStaticVar;
using System.Threading;
using System.IO;

namespace PovonMail
{
    public partial class MainFrm : Form
    {
        public MainFrm()
        {
            InitializeComponent();
        }

        private void MainFrm_Load(object sender, EventArgs e)
        {
            if (!Directory.Exists(CommonStaticVariables.receivedMailsDirectoryPath))
            {
                Directory.CreateDirectory(CommonStaticVariables.receivedMailsDirectoryPath);
            }
            if (!File.Exists(CommonStaticVariables.settingsFilePath))
            {
                StreamWriter sw = new StreamWriter(CommonStaticVariables.settingsFilePath);
                sw.Write("<settings>\n</settings>");
                sw.Close();
            }
            updateUI();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void accountsSettingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AccountSettingsFrm insAccountSettingsFrm = new AccountSettingsFrm(this);
            insAccountSettingsFrm.ShowDialog();
        }

        public void updateUI()
        {
            tvAccounts.Nodes.Clear();

            SettingsXMLHandler insSettingsXMLHandler = new SettingsXMLHandler();
            List<string> allEmailAddrList = insSettingsXMLHandler.getAllEmailAddr();
            if (allEmailAddrList.Count == 0)
            {
                return;
            }
            foreach (string emailAddr in allEmailAddrList)
            {
                tvAccounts.Nodes.Add(emailAddr);
            }
            tvAccounts.SelectedNode = tvAccounts.Nodes[0];
            refreshUI(tvAccounts.SelectedNode.Text);
        }

        public void refreshUI(string emailAddr)
        {
            lvMails.Items.Clear();
            string xmlFilePath = CommonStaticVariables.receivedMailsDirectoryPath + @"\" + emailAddr + ".xml";
            if (!File.Exists(xmlFilePath))
            {
                StreamWriter sw = new StreamWriter(xmlFilePath);
                sw.Write("<mails>\n</mails>");
                sw.Close();
            }
            ReceivedMailXMLHandler insReceivedMailXMLHandler = new ReceivedMailXMLHandler(xmlFilePath);

            // 在主界面的 lvMails 里面显示
            List<MailCs> mailList = insReceivedMailXMLHandler.getAllEmail();
            foreach (MailCs mail in mailList)
            {
                ListViewItem item = new ListViewItem () ;
                item.SubItems.Clear();
                item.SubItems[0].Text = mail.FromName;
                item.SubItems.Add(mail.Subject);
                item.SubItems.Add(mail.From);
                item.SubItems.Add(mail.Date.ToString());
                lvMails.Items.Add(item);
            }
        }

        private string getMessageBody(IMAP_FetchItem fetchItem)
        {
            byte[] messageData = fetchItem.MessageData;
            byte[] headerData = fetchItem.HeaderData;
            string headerStr = Encoding.UTF8.GetString(headerData);
            int messageLength = messageData.Length;
            int headerLength = headerData.Length;
            int bodyLength = messageLength - headerLength;
            byte[] bodyData = new byte[bodyLength];
            Array.Copy(messageData, headerLength, bodyData, 0, bodyLength);
            string bodyStr = Encoding.UTF8.GetString(bodyData).Trim();
            // if (Base64Handler.isBase64Encoding(bodyStr))
            if (headerStr.Contains("base64"))
            {
                // 有些邮箱的邮件内容是 base64 编码的
                return Base64Handler.DecodeBase64(bodyStr);
            }
            else
            {
                return bodyStr;
            }
        }

        private void handleMail(MailCs insMail)
        {
            // 收到的邮件先存到 Received Mails 目录下
            string xmlFilePath = CommonStaticVariables.receivedMailsDirectoryPath + @"\" + insMail.To + ".xml";
            if (!File.Exists(xmlFilePath))
            {
                StreamWriter sw = new StreamWriter(xmlFilePath);
                sw.Write("<mails>\n</mails>");
                sw.Close();
            }
            ReceivedMailXMLHandler insReceivedMailXMLHandler = new ReceivedMailXMLHandler(xmlFilePath);
            if (insReceivedMailXMLHandler.search(insMail.FromName, insMail.From, insMail.Subject, insMail.Date.ToString()) == null)
            {
                insReceivedMailXMLHandler.add(insMail);
            }

            refreshUI(insMail.To);
        }

        private void getMail(object emailAddr)
        {
            try
            {
                string emailAddrStr = emailAddr.ToString();
                SettingsXMLHandler insSettingsXMLHandler = new SettingsXMLHandler();
                SettingsCs curSettings = insSettingsXMLHandler.search(emailAddrStr);

                IMAP_Client clnt = new IMAP_Client();
                clnt.Connect(curSettings.ReceiveServer, Convert.ToInt32(curSettings.ReceivePort), true);
                clnt.Authenticate(curSettings.EmailAddr, curSettings.Password);
                string[] folders = clnt.GetFolders();
                string folder = "Inbox";
                clnt.SelectFolder(folder);

                IMAP_SequenceSet sequence_set = new IMAP_SequenceSet();
                // All messages
                sequence_set.Parse(string.Format("{0}:{1}", 1, clnt.MessagesCount));
                // sequence_set.Parse("1:*");
                IMAP_FetchItem[] fetchItems = clnt.FetchMessages(
                        sequence_set,
                        IMAP_FetchItem_Flags.Envelope | IMAP_FetchItem_Flags.Header | IMAP_FetchItem_Flags.Message | IMAP_FetchItem_Flags.MessageFlags | IMAP_FetchItem_Flags.UID,
                        true, false
                        );
                foreach (IMAP_FetchItem fetchItem in fetchItems)
                {
                    IMAP_Envelope envelope = fetchItem.Envelope;
                    if (fetchItem.MessageData == null) continue;
                    string body = getMessageBody(fetchItem);

                    MailCs insMail = new MailCs();
                    insMail.From = envelope.From[0].EmailAddress;
                    insMail.FromName = envelope.From[0].DisplayName;
                    insMail.To = envelope.To[0].EmailAddress;
                    insMail.ToName = envelope.To[0].DisplayName;
                    insMail.Subject = envelope.Subject;
                    insMail.Body = body;
                    insMail.Date = envelope.Date;
                    handleMail(insMail);
                }
                //delete it after hanlde
                // clnt.DeleteMessages(sequence_set, false);
                //disconnect
                clnt.Disconnect();
                //MessageBox.Show(count.ToString() + " of " + fetchItems .Length+ " Success");
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message, "Error!");
            }
        }

        private void tsbWrite_Click(object sender, EventArgs e)
        {
            string from = null;
            if (tvAccounts.SelectedNode != null)
            {
                from = tvAccounts.SelectedNode.Text;
            }
            WriteFrm insWriteFrm = new WriteFrm(from, CommonStaticVariables.TYPE.WRITE);
            insWriteFrm.ShowDialog();
        }

        private void aboutPovonMailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("A C# Practice Production");
        }

        private void tsbGetMail_Click(object sender, EventArgs e)
        {
            SettingsXMLHandler insSettingsXMLHandler = new SettingsXMLHandler();
            List<string> allEmailAddrList = insSettingsXMLHandler.getAllEmailAddr();
            foreach (string emailAddr in allEmailAddrList)
            {
                Thread getMailThread = new Thread(getMail);
                getMailThread.IsBackground = true;
                Control.CheckForIllegalCrossThreadCalls = false;
                getMailThread.Start(emailAddr);
            }
        }

        private void tvAccounts_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string emailAddr = tvAccounts.SelectedNode.Text;
            refreshUI(emailAddr);
        }

        private void lvMails_DoubleClick(object sender, EventArgs e)
        {
            string to = tvAccounts.SelectedNode.Text;
            string fromName = lvMails.SelectedItems[0].SubItems[0].Text;
            string subject = lvMails.SelectedItems[0].SubItems[1].Text;
            string from = lvMails.SelectedItems[0].SubItems[2].Text;
            string date = lvMails.SelectedItems[0].SubItems[3].Text;

            string xmlFilePath = CommonStaticVariables.receivedMailsDirectoryPath + @"\" + to + ".xml";
            ReceivedMailXMLHandler insReceivedMailXMLHandler = new ReceivedMailXMLHandler(xmlFilePath);
            MailCs curMail = insReceivedMailXMLHandler.search(fromName, from, subject, date);

            ViewMailFrm insViewMailFrm = new ViewMailFrm(curMail, this);
            insViewMailFrm.Show();
        }

        private void deleteMessageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lvMails.SelectedItems.Count == 0)
            {
                return;
            }
            string to = tvAccounts.SelectedNode.Text;
            string fromName = lvMails.SelectedItems[0].SubItems[0].Text;
            string subject = lvMails.SelectedItems[0].SubItems[1].Text;
            string from = lvMails.SelectedItems[0].SubItems[2].Text;
            string date = lvMails.SelectedItems[0].SubItems[3].Text;

            string xmlFilePath = CommonStaticVariables.receivedMailsDirectoryPath + @"\" + to + ".xml";
            ReceivedMailXMLHandler insReceivedMailXMLHandler = new ReceivedMailXMLHandler(xmlFilePath);
            insReceivedMailXMLHandler.delete(fromName, from, subject, date);
            refreshUI(to);
        }

        private void replyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lvMails.SelectedItems.Count == 0)
            {
                return;
            }
            string to = tvAccounts.SelectedNode.Text;
            string fromName = lvMails.SelectedItems[0].SubItems[0].Text;
            string subject = lvMails.SelectedItems[0].SubItems[1].Text;
            string from = lvMails.SelectedItems[0].SubItems[2].Text;
            string date = lvMails.SelectedItems[0].SubItems[3].Text;

            string xmlFilePath = CommonStaticVariables.receivedMailsDirectoryPath + @"\" + to + ".xml";
            ReceivedMailXMLHandler insReceivedMailXMLHandler = new ReceivedMailXMLHandler(xmlFilePath);
            MailCs insMail = insReceivedMailXMLHandler.search(fromName, from, subject, date);
            WriteFrm insWriteFrm = new WriteFrm(insMail, CommonStaticVariables.TYPE.REPLY);
            insWriteFrm.Show();
        }

        private void forwardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lvMails.SelectedItems.Count == 0)
            {
                return;
            }
            string to = tvAccounts.SelectedNode.Text;
            string fromName = lvMails.SelectedItems[0].SubItems[0].Text;
            string subject = lvMails.SelectedItems[0].SubItems[1].Text;
            string from = lvMails.SelectedItems[0].SubItems[2].Text;
            string date = lvMails.SelectedItems[0].SubItems[3].Text;

            string xmlFilePath = CommonStaticVariables.receivedMailsDirectoryPath + @"\" + to + ".xml";
            ReceivedMailXMLHandler insReceivedMailXMLHandler = new ReceivedMailXMLHandler(xmlFilePath);
            MailCs insMail = insReceivedMailXMLHandler.search(fromName, from, subject, date);
            WriteFrm insWriteFrm = new WriteFrm(insMail, CommonStaticVariables.TYPE.FORWARD);
            insWriteFrm.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            lvMails.SelectedItems.Clear();
            string subject = tstbSearch.Text.Trim();

            foreach (ListViewItem item in lvMails.Items)
            {
                if (item.SubItems[1].Text.Contains(subject))
                {
                    item.Selected = true;
                    lvMails.Focus();
                }
            }
        }

    }
}

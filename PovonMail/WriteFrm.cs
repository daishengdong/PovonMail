using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Net;  
using System.Net.Mail;
using PovonMail.XMLHandle;
using PovonMail.CommonStaticVar;

namespace PovonMail
{
    public partial class WriteFrm : Form
    {
        SettingsXMLHandler insSettingsXMLHandler = null;
        ComboBox[] cbList;
        TextBox[] tbList;
        string[] files = null;
        MailCs insMail = null;
        string from = null;
        CommonStaticVariables.TYPE type;

        public WriteFrm(string from, CommonStaticVariables.TYPE type)
        {
            InitializeComponent();
            this.from = from;
            this.type = type;
        }

        public WriteFrm(MailCs insMail, CommonStaticVariables.TYPE type)
        {
            InitializeComponent();
            this.insMail = insMail;
            this.from = insMail.From;
            this.type = type;
        }

        private void WriteFrm_Load(object sender, EventArgs e)
        {
            insSettingsXMLHandler = new SettingsXMLHandler();
            List<string> emailAddrList = insSettingsXMLHandler.getAllEmailAddr();
            foreach (string emailAddr in emailAddrList)
            {
                cbFrom.Items.Add(emailAddr);
            }
            // cbFrom.SelectedIndex = 0;
            cbFrom.SelectedText = from;

            cbList = new ComboBox[4];
            cbList[0] = cbTo0;
            cbList[0].SelectedIndex = 0;
            cbList[1] = cbTo1;
            cbList[1].SelectedIndex = 0;
            cbList[1].Visible = false;
            cbList[2] = cbTo2;
            cbList[2].SelectedIndex = 0;
            cbList[2].Visible = false;
            cbList[3] = cbTo3;
            cbList[3].SelectedIndex = 0;
            cbList[3].Visible = false;

            tbList = new TextBox[4];
            tbList[0] = tbTo0;
            tbList[1] = tbTo1;
            tbList[1].Enabled = false;
            tbList[2] = tbTo2;
            tbList[2].Enabled = false;
            tbList[3] = tbTo3;
            tbList[3].Enabled = false;

            if (this.type == CommonStaticVariables.TYPE.REPLY)
            {
                tbTo0.Text = insMail.From;
                tbSubject.Text = "Re: " + insMail.Subject;
                string header = "On " + insMail.Date + ", " + insMail.FromName + " wrote:\n";
                rtbBody.Text = header + insMail.Body + "\n\n\n";
                rtbBody.Focus();
            }
            if (this.type == CommonStaticVariables.TYPE.FORWARD)
            {
                tbSubject.Text = "Fwd: " + insMail.Subject;
                string header = "\n\n\n" + "-------- Original Message --------\n";
                header += "Subject: " + insMail.Subject + "\n";
                header += "Date: " + insMail.Date + "\n";
                header += "From: " + insMail.FromName + " <" + insMail.From + ">\n";
                header += "To: " + insMail.ToName + " <" + insMail.ToName + ">\n\n\n";
                rtbBody.Text = header + insMail.Body + "\n";
                tbTo0.Focus();
            }
        }

        private void tsbSend_Click(object sender, EventArgs e)
        {
            bool ok = false;
            foreach (TextBox tb in tbList)
            {
                if (tb.Text.Trim() != string.Empty)
                {
                    ok = true;
                }
            }
            if (!ok)
            {
                MessageBox.Show("Plz fill the recipient blank");
                return;
            }
            if (tbSubject.Text.Trim() == string.Empty)
            {
                DialogResult dr = MessageBox.Show("Are you sure to write a mail without subject?", "Warning", MessageBoxButtons.YesNo);
                if (dr == DialogResult.No)
                {
                    return;
                }
            }

            string emailAddr = cbFrom.Text.Trim();
            SettingsCs curSettings = insSettingsXMLHandler.search(emailAddr);

            string name = curSettings.Name;
            string password = curSettings.Password;
            string sendServer = curSettings.SendServer;
            int sendPort = Convert.ToInt32(curSettings.SendPort);

            string subject = tbSubject.Text.Trim();
            string body = rtbBody.Text.Trim();

            MailAddress from = new MailAddress(emailAddr, name);
            MailMessage mail = new MailMessage();
            mail.From = from;

            for (int i = 0; i < 4; ++i)
            {
                string to = tbList[i].Text.Trim();
                if (to != string.Empty)
                {
                    if (cbList[i].SelectedIndex == 0)
                    {
                        mail.To.Add(to);
                    }
                    else if (cbList[i].SelectedIndex == 1)
                    {
                        mail.CC.Add(to);
                    }
                    else if (cbList[i].SelectedIndex == 2)
                    {
                        mail.Bcc.Add(to);
                    }
                }
            }

            mail.Subject = subject;   
            mail.SubjectEncoding = Encoding.UTF8;
            mail.Body = body;
            mail.BodyEncoding = Encoding.UTF8;

            if (files != null)
            {
                foreach (string file in files)
                {
                    mail.Attachments.Add(new Attachment(file));
                }
                files = null;
            }

            mail.IsBodyHtml = false;   
            mail.Priority = MailPriority.Normal;  
            mail.DeliveryNotificationOptions = DeliveryNotificationOptions.OnSuccess;

            SmtpClient smtpSender = new SmtpClient();
            smtpSender.Host = sendServer;
            smtpSender.Port = sendPort;
            smtpSender.UseDefaultCredentials = false;  
            smtpSender.Credentials = new NetworkCredential(emailAddr, password);
            smtpSender.DeliveryMethod = SmtpDeliveryMethod.Network;     
            smtpSender.EnableSsl = false;
            try
            {
                smtpSender.Send(mail);
                this.Close();
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tbTo_Leave(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text != string.Empty)
            {
                for(int i = 0; i < 4; ++i)
                {
                    if (tbList[i] == (TextBox)sender && i != 3)
                    {
                        tbList[i + 1].Enabled = true;
                        cbList[i + 1].Visible = true;
                        return;
                    }
                }
            }
        }

        private void tbSubject_TextChanged(object sender, EventArgs e)
        {
            string defaultText = "Write: (no subject)";
            if (((TextBox)sender).Text != string.Empty)
            {
                this.Text = "Write: " + ((TextBox)sender).Text;
            }
            else
            {
                this.Text = defaultText;
            }
        }

        private void tsbAttach_ButtonClick(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();                  // 打开文件对话框

            ofd.AddExtension = true;
            ofd.CheckFileExists = true;
            ofd.Filter = "all files(*.*)|*.*";
            ofd.Multiselect = true;
            ofd.RestoreDirectory = true;
            ofd.ShowReadOnly = true;
            ofd.Title = "Attach File(s)";

            ofd.ShowDialog();
            files = ofd.FileNames;

            foreach (string name in ofd.SafeFileNames)
            {
                tsbAttach.DropDownItems.Add(name);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using PovonMail.XMLHandle;

namespace PovonMail
{
    public partial class MailAccountSetupFrm : Form
    {
        AccountSettingsFrm insAccountSettingsFrm = null;
        public MailAccountSetupFrm(AccountSettingsFrm insAccountSettingsFrm)
        {
            InitializeComponent();

            this.insAccountSettingsFrm = insAccountSettingsFrm;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string name = tbName.Text.Trim();
            string emailAddr = tbEmailAddr.Text.Trim();
            string password = tbPassword.Text.Trim();
            string sendServer = tbSendServer.Text.Trim();
            string sendPort = tbSendPort.Text.Trim();
            string receiveServer = tbReceiveServer.Text.Trim();
            string receivePort = tbReceivePort.Text.Trim();

            if (name == string.Empty || emailAddr == string.Empty || password == string.Empty || sendServer == string.Empty || sendPort == string.Empty || receiveServer == string.Empty || receivePort == string.Empty)
            {
                MessageBox.Show("Plz Fill all The Blank!");
            }
            else
            {
                SettingsXMLHandler insSettingsXMLHandler = new SettingsXMLHandler();

                SettingsCs newSettings = new SettingsCs();
                newSettings.Name = name;
                newSettings.EmailAddr = emailAddr;
                if (cbRememberPwd.Checked == true)
                {
                    newSettings.Password = password;
                }
                else
                {
                    newSettings.Password = string.Empty;
                }
                newSettings.SendServer = sendServer;
                newSettings.SendPort = sendPort;
                newSettings.ReceiveServer = receiveServer;
                newSettings.ReceivePort = receivePort;

                insSettingsXMLHandler.add(newSettings);
                insAccountSettingsFrm.updateUI();
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbEmailAddr_Leave(object sender, EventArgs e)
        {
            string emailAddr = tbEmailAddr.Text.Trim();
            if (!emailAddr.Contains('@') || !emailAddr.Contains('.'))
            {
                MessageBox.Show("email address format incorrect");
                tbEmailAddr.Focus();
            }
            else
            {
                string prefix = emailAddr.Substring(emailAddr.IndexOf('@') + 1);
                tbSendServer.Text = "smtp." + prefix;
                tbReceiveServer.Text = "imap." + prefix;
            }
        }
    }
}

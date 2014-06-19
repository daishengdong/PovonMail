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
    public partial class AccountSettingsFrm : Form
    {
        MainFrm insMainFrm = null;
        
        public AccountSettingsFrm( MainFrm insMainFrm )
        {
            InitializeComponent();

            this.insMainFrm = insMainFrm;
        }

        private void addMailAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MailAccountSetupFrm insMainAccountSetupFrm = new MailAccountSetupFrm(this);
            insMainAccountSetupFrm.ShowDialog();

            insMainFrm.updateUI();
        }

        private void AccountSettingsFrm_Load(object sender, EventArgs e)
        {
            updateUI();
            refreshUI();
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
        }

        private void refreshUI()
        {
            if (tvAccounts.Nodes.Count == 0)
            {
                return;
            }
            string emailAddr = tvAccounts.SelectedNode.Text;
            SettingsXMLHandler insSettingsXMLHandler = new SettingsXMLHandler();
            SettingsCs curSettings = insSettingsXMLHandler.search(emailAddr);
            tbName.Text = curSettings.Name;
            tbEmailAddr.Text = curSettings.EmailAddr;
            tbPassword.Text = curSettings.Password;
            tbSendServer.Text = curSettings.SendServer;
            tbSendPort.Text = curSettings.SendPort;
            tbReceiveServer.Text = curSettings.ReceiveServer;
            tbReceivePort.Text = curSettings.ReceivePort;
            btnSave.Enabled = false;
        }

        private void tvAccounts_AfterSelect(object sender, TreeViewEventArgs e)
        {
            refreshUI();
        }

        private void removeAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string emailAddr = tvAccounts.SelectedNode.Text;
            SettingsXMLHandler insSettingsXMLHandler = new SettingsXMLHandler();
            insSettingsXMLHandler.remove(emailAddr);

            updateUI();
            refreshUI();
            insMainFrm.updateUI();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SettingsCs newSettings = new SettingsCs();
            newSettings.Name = tbName.Text.Trim();
            newSettings.EmailAddr = tbEmailAddr.Text.Trim();
            newSettings.Password = tbPassword.Text.Trim();
            newSettings.SendServer = tbSendServer.Text.Trim();
            newSettings.SendPort = tbSendPort.Text.Trim();
            newSettings.ReceiveServer = tbReceiveServer.Text.Trim();
            newSettings.ReceivePort = tbReceivePort.Text.Trim();

            SettingsXMLHandler insSettingsXMLHandler = new SettingsXMLHandler();
            insSettingsXMLHandler.update(newSettings);
            refreshUI();
        }

        private void tb_TextChanged(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
        }

    }
}

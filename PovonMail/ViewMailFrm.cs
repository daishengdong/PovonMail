using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using PovonMail.CommonStaticVar;
using PovonMail.XMLHandle;

namespace PovonMail
{
    public partial class ViewMailFrm : Form
    {
        MailCs insMail = null;
        MainFrm insMainFrm = null;
        
        public ViewMailFrm(MailCs insMail, MainFrm insMainFrm)
        {
            InitializeComponent();
            this.insMail = insMail;
            this.insMainFrm = insMainFrm;
        }

        private void tsbReply_Click(object sender, EventArgs e)
        {
            WriteFrm insWriteFrm = new WriteFrm(insMail, CommonStaticVariables.TYPE.REPLY);
            insWriteFrm.Show();
        }

        private void ViewMailFrm_Load(object sender, EventArgs e)
        {
            lbFrom.Text = insMail.From;
            lbSubject.Text = insMail.Subject;
            lbTo.Text = insMail.To;
            rtbBody.Text = insMail.Body;
        }

        private void tsbForward_Click(object sender, EventArgs e)
        {
            WriteFrm insWriteFrm = new WriteFrm(insMail, CommonStaticVariables.TYPE.FORWARD);
            insWriteFrm.Show();
        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            string xmlFilePath = CommonStaticVariables.receivedMailsDirectoryPath + @"\" + insMail.To + ".xml";
            ReceivedMailXMLHandler insReceivedMailXMLHandler = new ReceivedMailXMLHandler(xmlFilePath);
            insReceivedMailXMLHandler.delete(insMail.FromName, insMail.From, insMail.Subject, insMail.Date.ToString());
            insMainFrm.refreshUI(insMail.To);
            this.Close();
        }
    }
}

namespace PovonMail
{
    partial class MailAccountSetupFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnOK = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbSendPort = new System.Windows.Forms.TextBox();
            this.tbEmailAddr = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbSendServer = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.cbRememberPwd = new System.Windows.Forms.CheckBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbReceivePort = new System.Windows.Forms.TextBox();
            this.tbReceiveServer = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(82, 301);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 8;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Email address:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Send Port:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Send Server:";
            // 
            // tbSendPort
            // 
            this.tbSendPort.Location = new System.Drawing.Point(134, 156);
            this.tbSendPort.Name = "tbSendPort";
            this.tbSendPort.Size = new System.Drawing.Size(186, 20);
            this.tbSendPort.TabIndex = 4;
            this.tbSendPort.Text = "25";
            // 
            // tbEmailAddr
            // 
            this.tbEmailAddr.Location = new System.Drawing.Point(134, 57);
            this.tbEmailAddr.Name = "tbEmailAddr";
            this.tbEmailAddr.Size = new System.Drawing.Size(186, 20);
            this.tbEmailAddr.TabIndex = 1;
            this.tbEmailAddr.Leave += new System.EventHandler(this.tbEmailAddr_Leave);
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(134, 90);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(186, 20);
            this.tbPassword.TabIndex = 2;
            // 
            // tbSendServer
            // 
            this.tbSendServer.Location = new System.Drawing.Point(134, 123);
            this.tbSendServer.Name = "tbSendServer";
            this.tbSendServer.Size = new System.Drawing.Size(186, 20);
            this.tbSendServer.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Your name:";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(134, 24);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(186, 20);
            this.tbName.TabIndex = 0;
            // 
            // cbRememberPwd
            // 
            this.cbRememberPwd.AutoSize = true;
            this.cbRememberPwd.Checked = true;
            this.cbRememberPwd.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbRememberPwd.Location = new System.Drawing.Point(134, 261);
            this.cbRememberPwd.Name = "cbRememberPwd";
            this.cbRememberPwd.Size = new System.Drawing.Size(125, 17);
            this.cbRememberPwd.TabIndex = 7;
            this.cbRememberPwd.Text = "Remember password";
            this.cbRememberPwd.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(184, 301);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 222);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Receive Port:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 189);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Receive Server:";
            // 
            // tbReceivePort
            // 
            this.tbReceivePort.Location = new System.Drawing.Point(134, 222);
            this.tbReceivePort.Name = "tbReceivePort";
            this.tbReceivePort.Size = new System.Drawing.Size(186, 20);
            this.tbReceivePort.TabIndex = 6;
            this.tbReceivePort.Text = "993";
            // 
            // tbReceiveServer
            // 
            this.tbReceiveServer.Location = new System.Drawing.Point(134, 189);
            this.tbReceiveServer.Name = "tbReceiveServer";
            this.tbReceiveServer.Size = new System.Drawing.Size(186, 20);
            this.tbReceiveServer.TabIndex = 5;
            // 
            // MailAccountSetupFrm
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(374, 359);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbReceivePort);
            this.Controls.Add(this.tbReceiveServer);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.cbRememberPwd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbSendPort);
            this.Controls.Add(this.tbEmailAddr);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbSendServer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MailAccountSetupFrm";
            this.Text = "Mail Account Setup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbSendPort;
        private System.Windows.Forms.TextBox tbEmailAddr;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbSendServer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.CheckBox cbRememberPwd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbReceivePort;
        private System.Windows.Forms.TextBox tbReceiveServer;
    }
}
namespace PovonMail
{
    partial class AccountSettingsFrm
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
            this.components = new System.ComponentModel.Container();
            this.tvAccounts = new System.Windows.Forms.TreeView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addMailAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.removeAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbReceivePort = new System.Windows.Forms.TextBox();
            this.tbReceiveServer = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbSendPort = new System.Windows.Forms.TextBox();
            this.tbEmailAddr = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbSendServer = new System.Windows.Forms.TextBox();
            this.sBtnAccountActions = new PovonMail.SplitButton();
            this.contextMenuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tvAccounts
            // 
            this.tvAccounts.Dock = System.Windows.Forms.DockStyle.Top;
            this.tvAccounts.Location = new System.Drawing.Point(0, 0);
            this.tvAccounts.Name = "tvAccounts";
            this.tvAccounts.Size = new System.Drawing.Size(200, 288);
            this.tvAccounts.TabIndex = 0;
            this.tvAccounts.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvAccounts_AfterSelect);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addMailAccountToolStripMenuItem,
            this.toolStripSeparator1,
            this.removeAccountToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(171, 54);
            // 
            // addMailAccountToolStripMenuItem
            // 
            this.addMailAccountToolStripMenuItem.Name = "addMailAccountToolStripMenuItem";
            this.addMailAccountToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.addMailAccountToolStripMenuItem.Text = "Add Mail Account";
            this.addMailAccountToolStripMenuItem.Click += new System.EventHandler(this.addMailAccountToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(167, 6);
            // 
            // removeAccountToolStripMenuItem
            // 
            this.removeAccountToolStripMenuItem.Name = "removeAccountToolStripMenuItem";
            this.removeAccountToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.removeAccountToolStripMenuItem.Text = "Remove Account";
            this.removeAccountToolStripMenuItem.Click += new System.EventHandler(this.removeAccountToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tvAccounts);
            this.panel1.Controls.Add(this.sBtnAccountActions);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 345);
            this.panel1.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.tbReceivePort);
            this.panel2.Controls.Add(this.tbReceiveServer);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.tbName);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.tbSendPort);
            this.panel2.Controls.Add(this.tbEmailAddr);
            this.panel2.Controls.Add(this.tbPassword);
            this.panel2.Controls.Add(this.tbSendServer);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(200, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(372, 345);
            this.panel2.TabIndex = 14;
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(185, 294);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(66, 23);
            this.btnSave.TabIndex = 41;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(51, 236);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 40;
            this.label6.Text = "Receive Port:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(39, 203);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 13);
            this.label7.TabIndex = 39;
            this.label7.Text = "Receive Server:";
            // 
            // tbReceivePort
            // 
            this.tbReceivePort.Location = new System.Drawing.Point(140, 236);
            this.tbReceivePort.Name = "tbReceivePort";
            this.tbReceivePort.Size = new System.Drawing.Size(186, 20);
            this.tbReceivePort.TabIndex = 33;
            this.tbReceivePort.TextChanged += new System.EventHandler(this.tb_TextChanged);
            // 
            // tbReceiveServer
            // 
            this.tbReceiveServer.Location = new System.Drawing.Point(140, 203);
            this.tbReceiveServer.Name = "tbReceiveServer";
            this.tbReceiveServer.Size = new System.Drawing.Size(186, 20);
            this.tbReceiveServer.TabIndex = 32;
            this.tbReceiveServer.TextChanged += new System.EventHandler(this.tb_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(62, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 38;
            this.label5.Text = "Your name:";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(140, 38);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(186, 20);
            this.tbName.TabIndex = 27;
            this.tbName.TextChanged += new System.EventHandler(this.tb_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 37;
            this.label4.Text = "Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "Email address:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "Send Port:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "Send Server:";
            // 
            // tbSendPort
            // 
            this.tbSendPort.Location = new System.Drawing.Point(140, 170);
            this.tbSendPort.Name = "tbSendPort";
            this.tbSendPort.Size = new System.Drawing.Size(186, 20);
            this.tbSendPort.TabIndex = 31;
            this.tbSendPort.TextChanged += new System.EventHandler(this.tb_TextChanged);
            // 
            // tbEmailAddr
            // 
            this.tbEmailAddr.Location = new System.Drawing.Point(140, 71);
            this.tbEmailAddr.Name = "tbEmailAddr";
            this.tbEmailAddr.ReadOnly = true;
            this.tbEmailAddr.Size = new System.Drawing.Size(186, 20);
            this.tbEmailAddr.TabIndex = 28;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(140, 104);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(186, 20);
            this.tbPassword.TabIndex = 29;
            this.tbPassword.TextChanged += new System.EventHandler(this.tb_TextChanged);
            // 
            // tbSendServer
            // 
            this.tbSendServer.Location = new System.Drawing.Point(140, 137);
            this.tbSendServer.Name = "tbSendServer";
            this.tbSendServer.Size = new System.Drawing.Size(186, 20);
            this.tbSendServer.TabIndex = 30;
            this.tbSendServer.TextChanged += new System.EventHandler(this.tb_TextChanged);
            // 
            // sBtnAccountActions
            // 
            this.sBtnAccountActions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.sBtnAccountActions.ClickedImage = "Clicked";
            this.sBtnAccountActions.ContextMenuStrip = this.contextMenuStrip1;
            this.sBtnAccountActions.DisabledImage = "Disabled";
            this.sBtnAccountActions.FocusedImage = "Focused";
            this.sBtnAccountActions.HoverImage = "Hover";
            this.sBtnAccountActions.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.sBtnAccountActions.ImageKey = "Normal";
            this.sBtnAccountActions.Location = new System.Drawing.Point(12, 294);
            this.sBtnAccountActions.Name = "sBtnAccountActions";
            this.sBtnAccountActions.NormalImage = "Normal";
            this.sBtnAccountActions.Size = new System.Drawing.Size(171, 27);
            this.sBtnAccountActions.TabIndex = 12;
            this.sBtnAccountActions.Text = "Account Actions";
            this.sBtnAccountActions.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.sBtnAccountActions.UseVisualStyleBackColor = true;
            // 
            // AccountSettingsFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 345);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AccountSettingsFrm";
            this.Text = "Account Settings";
            this.Load += new System.EventHandler(this.AccountSettingsFrm_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView tvAccounts;
        private SplitButton sBtnAccountActions;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addMailAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem removeAccountToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbReceivePort;
        private System.Windows.Forms.TextBox tbReceiveServer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbSendPort;
        private System.Windows.Forms.TextBox tbEmailAddr;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbSendServer;
        private System.Windows.Forms.Button btnSave;

    }
}
namespace PovonMail
{
    partial class MainFrm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountsSettingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutPovonMailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbGetMail = new System.Windows.Forms.ToolStripButton();
            this.tsbWrite = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tstbSearch = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.tvAccounts = new System.Windows.Forms.TreeView();
            this.lvMails = new System.Windows.Forms.ListView();
            this.DisplayName = new System.Windows.Forms.ColumnHeader();
            this.Subject = new System.Windows.Forms.ColumnHeader();
            this.From = new System.Windows.Forms.ColumnHeader();
            this.Date = new System.Windows.Forms.ColumnHeader();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.replyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.forwardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.deleteMessageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(828, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accountsSettingToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.toolsToolStripMenuItem.Text = "&Tools";
            // 
            // accountsSettingToolStripMenuItem
            // 
            this.accountsSettingToolStripMenuItem.Name = "accountsSettingToolStripMenuItem";
            this.accountsSettingToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.accountsSettingToolStripMenuItem.Text = "Account &Settings";
            this.accountsSettingToolStripMenuItem.Click += new System.EventHandler(this.accountsSettingToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutPovonMailToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutPovonMailToolStripMenuItem
            // 
            this.aboutPovonMailToolStripMenuItem.Name = "aboutPovonMailToolStripMenuItem";
            this.aboutPovonMailToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.aboutPovonMailToolStripMenuItem.Text = "&About PovonMail";
            this.aboutPovonMailToolStripMenuItem.Click += new System.EventHandler(this.aboutPovonMailToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbGetMail,
            this.tsbWrite,
            this.toolStripSeparator1,
            this.tstbSearch,
            this.toolStripButton1,
            this.toolStripSeparator3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(828, 25);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbGetMail
            // 
            this.tsbGetMail.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbGetMail.Image = ((System.Drawing.Image)(resources.GetObject("tsbGetMail.Image")));
            this.tsbGetMail.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbGetMail.Name = "tsbGetMail";
            this.tsbGetMail.Size = new System.Drawing.Size(55, 22);
            this.tsbGetMail.Text = "Get Mail";
            this.tsbGetMail.Click += new System.EventHandler(this.tsbGetMail_Click);
            // 
            // tsbWrite
            // 
            this.tsbWrite.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbWrite.Image = ((System.Drawing.Image)(resources.GetObject("tsbWrite.Image")));
            this.tsbWrite.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbWrite.Name = "tsbWrite";
            this.tsbWrite.Size = new System.Drawing.Size(39, 22);
            this.tsbWrite.Text = "Write";
            this.tsbWrite.Click += new System.EventHandler(this.tsbWrite_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tstbSearch
            // 
            this.tstbSearch.AutoSize = false;
            this.tstbSearch.Name = "tstbSearch";
            this.tstbSearch.Size = new System.Drawing.Size(400, 25);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(46, 22);
            this.toolStripButton1.Text = "Search";
            this.toolStripButton1.ToolTipText = "Search in Subject";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // tvAccounts
            // 
            this.tvAccounts.Dock = System.Windows.Forms.DockStyle.Left;
            this.tvAccounts.Location = new System.Drawing.Point(0, 49);
            this.tvAccounts.Name = "tvAccounts";
            this.tvAccounts.Size = new System.Drawing.Size(225, 458);
            this.tvAccounts.TabIndex = 11;
            this.tvAccounts.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvAccounts_AfterSelect);
            // 
            // lvMails
            // 
            this.lvMails.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.DisplayName,
            this.Subject,
            this.From,
            this.Date});
            this.lvMails.ContextMenuStrip = this.contextMenuStrip1;
            this.lvMails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvMails.FullRowSelect = true;
            this.lvMails.GridLines = true;
            this.lvMails.Location = new System.Drawing.Point(225, 49);
            this.lvMails.Name = "lvMails";
            this.lvMails.Size = new System.Drawing.Size(603, 458);
            this.lvMails.TabIndex = 12;
            this.lvMails.UseCompatibleStateImageBehavior = false;
            this.lvMails.View = System.Windows.Forms.View.Details;
            this.lvMails.DoubleClick += new System.EventHandler(this.lvMails_DoubleClick);
            // 
            // DisplayName
            // 
            this.DisplayName.Text = "Name";
            // 
            // Subject
            // 
            this.Subject.Text = "Subject";
            // 
            // From
            // 
            this.From.Text = "From";
            // 
            // Date
            // 
            this.Date.Text = "Date";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.replyToolStripMenuItem,
            this.forwardToolStripMenuItem,
            this.toolStripSeparator2,
            this.deleteMessageToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(157, 76);
            // 
            // replyToolStripMenuItem
            // 
            this.replyToolStripMenuItem.Name = "replyToolStripMenuItem";
            this.replyToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.replyToolStripMenuItem.Text = "Reply";
            this.replyToolStripMenuItem.Click += new System.EventHandler(this.replyToolStripMenuItem_Click);
            // 
            // forwardToolStripMenuItem
            // 
            this.forwardToolStripMenuItem.Name = "forwardToolStripMenuItem";
            this.forwardToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.forwardToolStripMenuItem.Text = "Forward";
            this.forwardToolStripMenuItem.Click += new System.EventHandler(this.forwardToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(153, 6);
            // 
            // deleteMessageToolStripMenuItem
            // 
            this.deleteMessageToolStripMenuItem.Name = "deleteMessageToolStripMenuItem";
            this.deleteMessageToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.deleteMessageToolStripMenuItem.Text = "Delete Message";
            this.deleteMessageToolStripMenuItem.Click += new System.EventHandler(this.deleteMessageToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 507);
            this.Controls.Add(this.lvMails);
            this.Controls.Add(this.tvAccounts);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainFrm";
            this.Text = "PovonMail";
            this.Load += new System.EventHandler(this.MainFrm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton tsbWrite;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox tstbSearch;
        private System.Windows.Forms.ToolStripMenuItem accountsSettingToolStripMenuItem;
        private System.Windows.Forms.TreeView tvAccounts;
        private System.Windows.Forms.ListView lvMails;
        private System.Windows.Forms.ToolStripMenuItem aboutPovonMailToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton tsbGetMail;
        private System.Windows.Forms.ColumnHeader DisplayName;
        private System.Windows.Forms.ColumnHeader Subject;
        private System.Windows.Forms.ColumnHeader From;
        private System.Windows.Forms.ColumnHeader Date;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deleteMessageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem replyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem forwardToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
    }
}


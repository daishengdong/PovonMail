namespace PovonMail
{
    partial class WriteFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WriteFrm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbSend = new System.Windows.Forms.ToolStripButton();
            this.tsbAttach = new System.Windows.Forms.ToolStripSplitButton();
            this.label1 = new System.Windows.Forms.Label();
            this.cbTo0 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbSubject = new System.Windows.Forms.TextBox();
            this.cbFrom = new System.Windows.Forms.ComboBox();
            this.tbTo2 = new System.Windows.Forms.TextBox();
            this.tbTo1 = new System.Windows.Forms.TextBox();
            this.tbTo0 = new System.Windows.Forms.TextBox();
            this.tbTo3 = new System.Windows.Forms.TextBox();
            this.rtbBody = new System.Windows.Forms.RichTextBox();
            this.cbTo1 = new System.Windows.Forms.ComboBox();
            this.cbTo2 = new System.Windows.Forms.ComboBox();
            this.cbTo3 = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbSend,
            this.tsbAttach});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(821, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbSend
            // 
            this.tsbSend.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbSend.Image = ((System.Drawing.Image)(resources.GetObject("tsbSend.Image")));
            this.tsbSend.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSend.Name = "tsbSend";
            this.tsbSend.Size = new System.Drawing.Size(37, 22);
            this.tsbSend.Text = "Send";
            this.tsbSend.Click += new System.EventHandler(this.tsbSend_Click);
            // 
            // tsbAttach
            // 
            this.tsbAttach.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbAttach.Image = ((System.Drawing.Image)(resources.GetObject("tsbAttach.Image")));
            this.tsbAttach.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAttach.Name = "tsbAttach";
            this.tsbAttach.Size = new System.Drawing.Size(58, 22);
            this.tsbAttach.Text = "Attach";
            this.tsbAttach.ButtonClick += new System.EventHandler(this.tsbAttach_ButtonClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "From:";
            // 
            // cbTo0
            // 
            this.cbTo0.FormattingEnabled = true;
            this.cbTo0.Items.AddRange(new object[] {
            "To:",
            "Cc:",
            "Bcc:"});
            this.cbTo0.Location = new System.Drawing.Point(6, 40);
            this.cbTo0.Name = "cbTo0";
            this.cbTo0.Size = new System.Drawing.Size(65, 21);
            this.cbTo0.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Subject:";
            // 
            // tbSubject
            // 
            this.tbSubject.Location = new System.Drawing.Point(80, 124);
            this.tbSubject.Name = "tbSubject";
            this.tbSubject.Size = new System.Drawing.Size(723, 20);
            this.tbSubject.TabIndex = 9;
            this.tbSubject.TextChanged += new System.EventHandler(this.tbSubject_TextChanged);
            // 
            // cbFrom
            // 
            this.cbFrom.FormattingEnabled = true;
            this.cbFrom.Location = new System.Drawing.Point(80, 12);
            this.cbFrom.Name = "cbFrom";
            this.cbFrom.Size = new System.Drawing.Size(723, 21);
            this.cbFrom.TabIndex = 0;
            // 
            // tbTo2
            // 
            this.tbTo2.Location = new System.Drawing.Point(80, 76);
            this.tbTo2.Name = "tbTo2";
            this.tbTo2.Size = new System.Drawing.Size(723, 20);
            this.tbTo2.TabIndex = 5;
            this.tbTo2.Leave += new System.EventHandler(this.tbTo_Leave);
            // 
            // tbTo1
            // 
            this.tbTo1.Location = new System.Drawing.Point(80, 57);
            this.tbTo1.Name = "tbTo1";
            this.tbTo1.Size = new System.Drawing.Size(723, 20);
            this.tbTo1.TabIndex = 3;
            this.tbTo1.Leave += new System.EventHandler(this.tbTo_Leave);
            // 
            // tbTo0
            // 
            this.tbTo0.Location = new System.Drawing.Point(80, 40);
            this.tbTo0.Name = "tbTo0";
            this.tbTo0.Size = new System.Drawing.Size(723, 20);
            this.tbTo0.TabIndex = 1;
            this.tbTo0.Leave += new System.EventHandler(this.tbTo_Leave);
            // 
            // tbTo3
            // 
            this.tbTo3.Location = new System.Drawing.Point(80, 95);
            this.tbTo3.Name = "tbTo3";
            this.tbTo3.Size = new System.Drawing.Size(723, 20);
            this.tbTo3.TabIndex = 7;
            // 
            // rtbBody
            // 
            this.rtbBody.AcceptsTab = true;
            this.rtbBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbBody.Location = new System.Drawing.Point(0, 0);
            this.rtbBody.Name = "rtbBody";
            this.rtbBody.Size = new System.Drawing.Size(821, 352);
            this.rtbBody.TabIndex = 10;
            this.rtbBody.Text = "";
            // 
            // cbTo1
            // 
            this.cbTo1.FormattingEnabled = true;
            this.cbTo1.Items.AddRange(new object[] {
            "To:",
            "Cc:",
            "Bcc:"});
            this.cbTo1.Location = new System.Drawing.Point(6, 58);
            this.cbTo1.Name = "cbTo1";
            this.cbTo1.Size = new System.Drawing.Size(65, 21);
            this.cbTo1.TabIndex = 4;
            // 
            // cbTo2
            // 
            this.cbTo2.FormattingEnabled = true;
            this.cbTo2.Items.AddRange(new object[] {
            "To:",
            "Cc:",
            "Bcc:"});
            this.cbTo2.Location = new System.Drawing.Point(6, 77);
            this.cbTo2.Name = "cbTo2";
            this.cbTo2.Size = new System.Drawing.Size(65, 21);
            this.cbTo2.TabIndex = 6;
            // 
            // cbTo3
            // 
            this.cbTo3.FormattingEnabled = true;
            this.cbTo3.Items.AddRange(new object[] {
            "To:",
            "Cc:",
            "Bcc:"});
            this.cbTo3.Location = new System.Drawing.Point(6, 96);
            this.cbTo3.Name = "cbTo3";
            this.cbTo3.Size = new System.Drawing.Size(65, 21);
            this.cbTo3.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbTo3);
            this.panel1.Controls.Add(this.cbTo0);
            this.panel1.Controls.Add(this.cbTo2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cbTo1);
            this.panel1.Controls.Add(this.tbSubject);
            this.panel1.Controls.Add(this.cbFrom);
            this.panel1.Controls.Add(this.tbTo3);
            this.panel1.Controls.Add(this.tbTo2);
            this.panel1.Controls.Add(this.tbTo0);
            this.panel1.Controls.Add(this.tbTo1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(821, 151);
            this.panel1.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rtbBody);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 176);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(821, 352);
            this.panel2.TabIndex = 12;
            // 
            // WriteFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 528);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "WriteFrm";
            this.Text = "Write: (no subject)";
            this.Load += new System.EventHandler(this.WriteFrm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbSend;
        private System.Windows.Forms.ToolStripSplitButton tsbAttach;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbTo0;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbSubject;
        private System.Windows.Forms.ComboBox cbFrom;
        private System.Windows.Forms.TextBox tbTo2;
        private System.Windows.Forms.TextBox tbTo1;
        private System.Windows.Forms.TextBox tbTo0;
        private System.Windows.Forms.TextBox tbTo3;
        private System.Windows.Forms.RichTextBox rtbBody;
        private System.Windows.Forms.ComboBox cbTo1;
        private System.Windows.Forms.ComboBox cbTo2;
        private System.Windows.Forms.ComboBox cbTo3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}
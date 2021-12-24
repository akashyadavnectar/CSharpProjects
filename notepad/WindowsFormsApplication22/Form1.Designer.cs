namespace WindowsFormsApplication22
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fILEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nEWToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oPENToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sAVEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eXITToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eDITToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rEDUToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cUTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cUTToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.CopyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pASTEToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sELECTALLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fORMATToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fONTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cOLORToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fILEToolStripMenuItem,
            this.eDITToolStripMenuItem,
            this.fORMATToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(550, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fILEToolStripMenuItem
            // 
            this.fILEToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nEWToolStripMenuItem,
            this.oPENToolStripMenuItem,
            this.sAVEToolStripMenuItem,
            this.eXITToolStripMenuItem});
            this.fILEToolStripMenuItem.Name = "fILEToolStripMenuItem";
            this.fILEToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.fILEToolStripMenuItem.Text = "FILE";
            // 
            // nEWToolStripMenuItem
            // 
            this.nEWToolStripMenuItem.Name = "nEWToolStripMenuItem";
            this.nEWToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.nEWToolStripMenuItem.Text = "NEW";
            this.nEWToolStripMenuItem.Click += new System.EventHandler(this.nEWToolStripMenuItem_Click);
            // 
            // oPENToolStripMenuItem
            // 
            this.oPENToolStripMenuItem.Name = "oPENToolStripMenuItem";
            this.oPENToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.oPENToolStripMenuItem.Text = "OPEN";
            this.oPENToolStripMenuItem.Click += new System.EventHandler(this.oPENToolStripMenuItem_Click);
            // 
            // sAVEToolStripMenuItem
            // 
            this.sAVEToolStripMenuItem.Name = "sAVEToolStripMenuItem";
            this.sAVEToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.sAVEToolStripMenuItem.Text = "SAVE";
            this.sAVEToolStripMenuItem.Click += new System.EventHandler(this.sAVEToolStripMenuItem_Click);
            // 
            // eXITToolStripMenuItem
            // 
            this.eXITToolStripMenuItem.Name = "eXITToolStripMenuItem";
            this.eXITToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.eXITToolStripMenuItem.Text = "EXIT";
            this.eXITToolStripMenuItem.Click += new System.EventHandler(this.eXITToolStripMenuItem_Click);
            // 
            // eDITToolStripMenuItem
            // 
            this.eDITToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rEDUToolStripMenuItem,
            this.cUTToolStripMenuItem,
            this.cUTToolStripMenuItem1,
            this.CopyToolStripMenuItem,
            this.pASTEToolStripMenuItem1,
            this.sELECTALLToolStripMenuItem});
            this.eDITToolStripMenuItem.Name = "eDITToolStripMenuItem";
            this.eDITToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.eDITToolStripMenuItem.Text = "EDIT";
            // 
            // rEDUToolStripMenuItem
            // 
            this.rEDUToolStripMenuItem.Name = "rEDUToolStripMenuItem";
            this.rEDUToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.rEDUToolStripMenuItem.Text = "UNDU";
            this.rEDUToolStripMenuItem.Click += new System.EventHandler(this.rEDUToolStripMenuItem_Click);
            // 
            // cUTToolStripMenuItem
            // 
            this.cUTToolStripMenuItem.Name = "cUTToolStripMenuItem";
            this.cUTToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cUTToolStripMenuItem.Text = "REDU";
            this.cUTToolStripMenuItem.Click += new System.EventHandler(this.cUTToolStripMenuItem_Click);
            // 
            // cUTToolStripMenuItem1
            // 
            this.cUTToolStripMenuItem1.Name = "cUTToolStripMenuItem1";
            this.cUTToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.cUTToolStripMenuItem1.Text = "CUT";
            this.cUTToolStripMenuItem1.Click += new System.EventHandler(this.cUTToolStripMenuItem1_Click);
            // 
            // CopyToolStripMenuItem
            // 
            this.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem";
            this.CopyToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.CopyToolStripMenuItem.Text = "COPY";
            this.CopyToolStripMenuItem.Click += new System.EventHandler(this.pASTEToolStripMenuItem_Click);
            // 
            // pASTEToolStripMenuItem1
            // 
            this.pASTEToolStripMenuItem1.Name = "pASTEToolStripMenuItem1";
            this.pASTEToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.pASTEToolStripMenuItem1.Text = "PASTE";
            this.pASTEToolStripMenuItem1.Click += new System.EventHandler(this.pASTEToolStripMenuItem1_Click);
            // 
            // sELECTALLToolStripMenuItem
            // 
            this.sELECTALLToolStripMenuItem.Name = "sELECTALLToolStripMenuItem";
            this.sELECTALLToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.sELECTALLToolStripMenuItem.Text = "SELECT_ALL";
            this.sELECTALLToolStripMenuItem.Click += new System.EventHandler(this.sELECTALLToolStripMenuItem_Click);
            // 
            // fORMATToolStripMenuItem
            // 
            this.fORMATToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fONTToolStripMenuItem,
            this.cOLORToolStripMenuItem});
            this.fORMATToolStripMenuItem.Name = "fORMATToolStripMenuItem";
            this.fORMATToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.fORMATToolStripMenuItem.Text = "FORMAT";
            // 
            // fONTToolStripMenuItem
            // 
            this.fONTToolStripMenuItem.Name = "fONTToolStripMenuItem";
            this.fONTToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.fONTToolStripMenuItem.Text = "FONT";
            this.fONTToolStripMenuItem.Click += new System.EventHandler(this.fONTToolStripMenuItem_Click);
            // 
            // cOLORToolStripMenuItem
            // 
            this.cOLORToolStripMenuItem.Name = "cOLORToolStripMenuItem";
            this.cOLORToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cOLORToolStripMenuItem.Text = "COLOR";
            this.cOLORToolStripMenuItem.Click += new System.EventHandler(this.cOLORToolStripMenuItem_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(0, 24);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(550, 377);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(550, 401);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "notepad";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fILEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nEWToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oPENToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sAVEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eXITToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eDITToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rEDUToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cUTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cUTToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem CopyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pASTEToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sELECTALLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fORMATToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fONTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cOLORToolStripMenuItem;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}


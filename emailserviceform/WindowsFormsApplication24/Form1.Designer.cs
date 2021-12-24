namespace WindowsFormsApplication24
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.attach = new System.Windows.Forms.Button();
            this.send = new System.Windows.Forms.Button();
            this.textattach = new System.Windows.Forms.TextBox();
            this.TextBody = new System.Windows.Forms.RichTextBox();
            this.textsubject = new System.Windows.Forms.TextBox();
            this.textto = new System.Windows.Forms.TextBox();
            this.textfrom = new System.Windows.Forms.TextBox();
            this.textpassword = new System.Windows.Forms.TextBox();
            this.textusername = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "From";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "To";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Subject";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Body";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(236, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "UserName";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(236, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Password";
            // 
            // attach
            // 
            this.attach.Location = new System.Drawing.Point(411, 121);
            this.attach.Name = "attach";
            this.attach.Size = new System.Drawing.Size(54, 23);
            this.attach.TabIndex = 7;
            this.attach.Text = "Attach";
            this.attach.UseVisualStyleBackColor = true;
            // 
            // send
            // 
            this.send.Location = new System.Drawing.Point(312, 169);
            this.send.Name = "send";
            this.send.Size = new System.Drawing.Size(153, 73);
            this.send.TabIndex = 8;
            this.send.Text = "SEND";
            this.send.UseVisualStyleBackColor = true;
            this.send.Click += new System.EventHandler(this.button2_Click);
            // 
            // textattach
            // 
            this.textattach.Location = new System.Drawing.Point(307, 102);
            this.textattach.Name = "textattach";
            this.textattach.Size = new System.Drawing.Size(158, 20);
            this.textattach.TabIndex = 9;
            // 
            // TextBody
            // 
            this.TextBody.Location = new System.Drawing.Point(13, 102);
            this.TextBody.Name = "TextBody";
            this.TextBody.Size = new System.Drawing.Size(280, 148);
            this.TextBody.TabIndex = 10;
            this.TextBody.Text = "";
            // 
            // textsubject
            // 
            this.textsubject.Location = new System.Drawing.Point(59, 60);
            this.textsubject.Name = "textsubject";
            this.textsubject.Size = new System.Drawing.Size(144, 20);
            this.textsubject.TabIndex = 11;
            // 
            // textto
            // 
            this.textto.Location = new System.Drawing.Point(59, 34);
            this.textto.Name = "textto";
            this.textto.Size = new System.Drawing.Size(144, 20);
            this.textto.TabIndex = 12;
            // 
            // textfrom
            // 
            this.textfrom.Location = new System.Drawing.Point(59, 10);
            this.textfrom.Name = "textfrom";
            this.textfrom.Size = new System.Drawing.Size(144, 20);
            this.textfrom.TabIndex = 13;
            // 
            // textpassword
            // 
            this.textpassword.Location = new System.Drawing.Point(307, 37);
            this.textpassword.Name = "textpassword";
            this.textpassword.Size = new System.Drawing.Size(158, 20);
            this.textpassword.TabIndex = 14;
            this.textpassword.UseSystemPasswordChar = true;
            // 
            // textusername
            // 
            this.textusername.Location = new System.Drawing.Point(307, 11);
            this.textusername.Name = "textusername";
            this.textusername.Size = new System.Drawing.Size(158, 20);
            this.textusername.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(491, 262);
            this.Controls.Add(this.textusername);
            this.Controls.Add(this.textpassword);
            this.Controls.Add(this.textfrom);
            this.Controls.Add(this.textto);
            this.Controls.Add(this.textsubject);
            this.Controls.Add(this.TextBody);
            this.Controls.Add(this.textattach);
            this.Controls.Add(this.send);
            this.Controls.Add(this.attach);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "EmailService";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button attach;
        private System.Windows.Forms.Button send;
        private System.Windows.Forms.TextBox textattach;
        private System.Windows.Forms.RichTextBox TextBody;
        private System.Windows.Forms.TextBox textsubject;
        private System.Windows.Forms.TextBox textto;
        private System.Windows.Forms.TextBox textfrom;
        private System.Windows.Forms.TextBox textpassword;
        private System.Windows.Forms.TextBox textusername;
    }
}


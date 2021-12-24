namespace Doodle
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Bpipe = new System.Windows.Forms.PictureBox();
            this.Tpipe = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.scoreText = new System.Windows.Forms.Label();
            this.ground = new System.Windows.Forms.PictureBox();
            this.doodle = new System.Windows.Forms.PictureBox();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Bpipe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tpipe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doodle)).BeginInit();
            this.SuspendLayout();
            // 
            // Bpipe
            // 
            this.Bpipe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Bpipe.Location = new System.Drawing.Point(35, 258);
            this.Bpipe.Name = "Bpipe";
            this.Bpipe.Size = new System.Drawing.Size(94, 161);
            this.Bpipe.TabIndex = 1;
            this.Bpipe.TabStop = false;
            // 
            // Tpipe
            // 
            this.Tpipe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Tpipe.Location = new System.Drawing.Point(538, -2);
            this.Tpipe.Name = "Tpipe";
            this.Tpipe.Size = new System.Drawing.Size(108, 156);
            this.Tpipe.TabIndex = 2;
            this.Tpipe.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Olive;
            this.pictureBox4.Location = new System.Drawing.Point(-1, 447);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(747, 20);
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "SCORE";
            // 
            // scoreText
            // 
            this.scoreText.AutoSize = true;
            this.scoreText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreText.Location = new System.Drawing.Point(84, 16);
            this.scoreText.Name = "scoreText";
            this.scoreText.Size = new System.Drawing.Size(21, 24);
            this.scoreText.TabIndex = 5;
            this.scoreText.Text = "0";
            // 
            // ground
            // 
            this.ground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ground.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ground.BackgroundImage")));
            this.ground.Location = new System.Drawing.Point(-1, 416);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(747, 37);
            this.ground.TabIndex = 6;
            this.ground.TabStop = false;
            // 
            // doodle
            // 
            this.doodle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.doodle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("doodle.BackgroundImage")));
            this.doodle.Location = new System.Drawing.Point(179, 205);
            this.doodle.Name = "doodle";
            this.doodle.Size = new System.Drawing.Size(79, 61);
            this.doodle.TabIndex = 0;
            this.doodle.TabStop = false;
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Interval = 20;
            this.Timer.Tick += new System.EventHandler(this.TimerEvent);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(743, 465);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.scoreText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.Tpipe);
            this.Controls.Add(this.Bpipe);
            this.Controls.Add(this.doodle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyisup);
            ((System.ComponentModel.ISupportInitialize)(this.Bpipe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tpipe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doodle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Bpipe;
        private System.Windows.Forms.PictureBox Tpipe;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label scoreText;
        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.PictureBox doodle;
        private System.Windows.Forms.Timer Timer;
    }
}


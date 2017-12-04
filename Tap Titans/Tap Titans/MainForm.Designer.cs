namespace Tap_Titans
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.pbxPhai = new System.Windows.Forms.PictureBox();
            this.pbxBoss = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPhai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBoss)).BeginInit();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Enabled = false;
            this.progressBar1.Location = new System.Drawing.Point(59, 12);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.progressBar1.Size = new System.Drawing.Size(266, 23);
            this.progressBar1.TabIndex = 1;
            // 
            // pbxPhai
            // 
            this.pbxPhai.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbxPhai.Location = new System.Drawing.Point(153, 239);
            this.pbxPhai.Name = "pbxPhai";
            this.pbxPhai.Size = new System.Drawing.Size(61, 80);
            this.pbxPhai.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxPhai.TabIndex = 3;
            this.pbxPhai.TabStop = false;
            // 
            // pbxBoss
            // 
            this.pbxBoss.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbxBoss.BackgroundImage")));
            this.pbxBoss.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxBoss.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbxBoss.Location = new System.Drawing.Point(59, 52);
            this.pbxBoss.Name = "pbxBoss";
            this.pbxBoss.Size = new System.Drawing.Size(267, 267);
            this.pbxBoss.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxBoss.TabIndex = 0;
            this.pbxBoss.TabStop = false;
            this.pbxBoss.Click += new System.EventHandler(this.pbxBoss_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(341, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Bắt đầu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 341);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pbxPhai);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.pbxBoss);
            this.Name = "MainForm";
            this.Text = "Tap Titans";
            ((System.ComponentModel.ISupportInitialize)(this.pbxPhai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBoss)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxBoss;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.PictureBox pbxPhai;
        private System.Windows.Forms.Button button1;
    }
}


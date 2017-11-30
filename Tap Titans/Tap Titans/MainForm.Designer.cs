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
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.pbxLen = new System.Windows.Forms.PictureBox();
            this.pbxPhai = new System.Windows.Forms.PictureBox();
            this.pbxTrai = new System.Windows.Forms.PictureBox();
            this.pbxBoss = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPhai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxTrai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBoss)).BeginInit();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(59, 12);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(266, 23);
            this.progressBar1.TabIndex = 1;
            // 
            // pbxLen
            // 
            this.pbxLen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbxLen.Image = global::Tap_Titans.Properties.Resources._24204752_882053258612189_110757496_n;
            this.pbxLen.Location = new System.Drawing.Point(266, 249);
            this.pbxLen.Name = "pbxLen";
            this.pbxLen.Size = new System.Drawing.Size(59, 80);
            this.pbxLen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxLen.TabIndex = 4;
            this.pbxLen.TabStop = false;
            // 
            // pbxPhai
            // 
            this.pbxPhai.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbxPhai.Image = global::Tap_Titans.Properties.Resources._24273264_882051815279000_225976857_n;
            this.pbxPhai.Location = new System.Drawing.Point(165, 249);
            this.pbxPhai.Name = "pbxPhai";
            this.pbxPhai.Size = new System.Drawing.Size(61, 80);
            this.pbxPhai.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxPhai.TabIndex = 3;
            this.pbxPhai.TabStop = false;
            // 
            // pbxTrai
            // 
            this.pbxTrai.BackColor = System.Drawing.SystemColors.Control;
            this.pbxTrai.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbxTrai.Image = global::Tap_Titans.Properties.Resources._24321790_882050081945840_1330418632_o1;
            this.pbxTrai.Location = new System.Drawing.Point(59, 249);
            this.pbxTrai.Name = "pbxTrai";
            this.pbxTrai.Size = new System.Drawing.Size(61, 80);
            this.pbxTrai.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxTrai.TabIndex = 2;
            this.pbxTrai.TabStop = false;
            this.pbxTrai.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pbxBoss
            // 
            this.pbxBoss.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbxBoss.Image = global::Tap_Titans.Properties.Resources.DIGNUmBXkAACFQa;
            this.pbxBoss.Location = new System.Drawing.Point(59, 52);
            this.pbxBoss.Name = "pbxBoss";
            this.pbxBoss.Size = new System.Drawing.Size(267, 267);
            this.pbxBoss.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxBoss.TabIndex = 0;
            this.pbxBoss.TabStop = false;
            this.pbxBoss.Click += new System.EventHandler(this.pbxBoss_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 341);
            this.Controls.Add(this.pbxLen);
            this.Controls.Add(this.pbxPhai);
            this.Controls.Add(this.pbxTrai);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.pbxBoss);
            this.Name = "MainForm";
            this.Text = "TapTitans";
            ((System.ComponentModel.ISupportInitialize)(this.pbxLen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPhai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxTrai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBoss)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxBoss;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.PictureBox pbxTrai;
        private System.Windows.Forms.PictureBox pbxPhai;
        private System.Windows.Forms.PictureBox pbxLen;
    }
}


namespace Proje_Hastane
{
    partial class frmGirisler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGirisler));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSekreterGiriş = new System.Windows.Forms.Button();
            this.BtnDoktorGiriş = new System.Windows.Forms.Button();
            this.btnHastaGiriş = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(138, 391);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Hasta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(494, 391);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Doktor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(859, 391);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sekreter";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Script", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(73, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(368, 55);
            this.label4.TabIndex = 7;
            this.label4.Text = "Black Side Hospital";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Proje_Hastane.Properties.Resources.images;
            this.pictureBox1.Location = new System.Drawing.Point(627, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(267, 138);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // btnSekreterGiriş
            // 
            this.btnSekreterGiriş.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSekreterGiriş.BackgroundImage")));
            this.btnSekreterGiriş.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSekreterGiriş.Location = new System.Drawing.Point(744, 185);
            this.btnSekreterGiriş.Name = "btnSekreterGiriş";
            this.btnSekreterGiriş.Size = new System.Drawing.Size(314, 172);
            this.btnSekreterGiriş.TabIndex = 2;
            this.btnSekreterGiriş.UseVisualStyleBackColor = true;
            this.btnSekreterGiriş.Click += new System.EventHandler(this.btnSekreterGiriş_Click);
            // 
            // BtnDoktorGiriş
            // 
            this.BtnDoktorGiriş.BackgroundImage = global::Proje_Hastane.Properties.Resources.png_transparent_doctor_icon_vista_white_coat;
            this.BtnDoktorGiriş.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnDoktorGiriş.Location = new System.Drawing.Point(380, 185);
            this.BtnDoktorGiriş.Name = "BtnDoktorGiriş";
            this.BtnDoktorGiriş.Size = new System.Drawing.Size(314, 172);
            this.BtnDoktorGiriş.TabIndex = 1;
            this.BtnDoktorGiriş.UseVisualStyleBackColor = true;
            this.BtnDoktorGiriş.Click += new System.EventHandler(this.BtnDoktorGiriş_Click);
            // 
            // btnHastaGiriş
            // 
            this.btnHastaGiriş.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHastaGiriş.BackgroundImage")));
            this.btnHastaGiriş.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHastaGiriş.Location = new System.Drawing.Point(16, 185);
            this.btnHastaGiriş.Name = "btnHastaGiriş";
            this.btnHastaGiriş.Size = new System.Drawing.Size(314, 172);
            this.btnHastaGiriş.TabIndex = 0;
            this.btnHastaGiriş.UseVisualStyleBackColor = true;
            this.btnHastaGiriş.Click += new System.EventHandler(this.btnHastaGiriş_Click);
            // 
            // frmGirisler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1154, 517);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSekreterGiriş);
            this.Controls.Add(this.BtnDoktorGiriş);
            this.Controls.Add(this.btnHastaGiriş);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmGirisler";
            this.Text = "Black Side Hospital Giriş";
            this.Load += new System.EventHandler(this.frmGirisler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHastaGiriş;
        private System.Windows.Forms.Button BtnDoktorGiriş;
        private System.Windows.Forms.Button btnSekreterGiriş;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
    }
}


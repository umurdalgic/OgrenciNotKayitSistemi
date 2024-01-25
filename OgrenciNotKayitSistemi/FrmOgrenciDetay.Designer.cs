namespace OgrenciNotKayitSistemi
{
    partial class FrmOgrenciDetay
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            lblDurum = new Label();
            lblOrtalama = new Label();
            lblSinav3 = new Label();
            lblSinav2 = new Label();
            lblSinav1 = new Label();
            lblNumara = new Label();
            lblAdSoyad = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Location = new Point(20, 30);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(317, 43);
            label1.TabIndex = 0;
            label1.Text = "Ad Soyad:";
            // 
            // label2
            // 
            label2.Location = new Point(20, 96);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(317, 43);
            label2.TabIndex = 1;
            label2.Text = "Numara:";
            // 
            // label3
            // 
            label3.Location = new Point(20, 162);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(317, 43);
            label3.TabIndex = 2;
            label3.Text = "Sınav 1:";
            // 
            // label4
            // 
            label4.Location = new Point(20, 229);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(317, 43);
            label4.TabIndex = 3;
            label4.Text = "Sınav 2:";
            // 
            // label5
            // 
            label5.Location = new Point(20, 295);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(317, 43);
            label5.TabIndex = 4;
            label5.Text = "Sınav 3:";
            // 
            // label6
            // 
            label6.Location = new Point(20, 361);
            label6.Margin = new Padding(5, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new Size(317, 43);
            label6.TabIndex = 5;
            label6.Text = "Ortalama:";
            // 
            // label7
            // 
            label7.Location = new Point(20, 428);
            label7.Margin = new Padding(5, 0, 5, 0);
            label7.Name = "label7";
            label7.Size = new Size(317, 43);
            label7.TabIndex = 6;
            label7.Text = "Durum:";
            // 
            // lblDurum
            // 
            lblDurum.Location = new Point(160, 428);
            lblDurum.Margin = new Padding(5, 0, 5, 0);
            lblDurum.Name = "lblDurum";
            lblDurum.Size = new Size(177, 43);
            lblDurum.TabIndex = 13;
            lblDurum.Text = "NULL";
            // 
            // lblOrtalama
            // 
            lblOrtalama.Location = new Point(160, 361);
            lblOrtalama.Margin = new Padding(5, 0, 5, 0);
            lblOrtalama.Name = "lblOrtalama";
            lblOrtalama.Size = new Size(177, 43);
            lblOrtalama.TabIndex = 12;
            lblOrtalama.Text = "00";
            // 
            // lblSinav3
            // 
            lblSinav3.Location = new Point(160, 295);
            lblSinav3.Margin = new Padding(5, 0, 5, 0);
            lblSinav3.Name = "lblSinav3";
            lblSinav3.Size = new Size(177, 43);
            lblSinav3.TabIndex = 11;
            lblSinav3.Text = "00";
            // 
            // lblSinav2
            // 
            lblSinav2.Location = new Point(160, 229);
            lblSinav2.Margin = new Padding(5, 0, 5, 0);
            lblSinav2.Name = "lblSinav2";
            lblSinav2.Size = new Size(177, 43);
            lblSinav2.TabIndex = 10;
            lblSinav2.Text = "00";
            // 
            // lblSinav1
            // 
            lblSinav1.Location = new Point(160, 162);
            lblSinav1.Margin = new Padding(5, 0, 5, 0);
            lblSinav1.Name = "lblSinav1";
            lblSinav1.Size = new Size(177, 43);
            lblSinav1.TabIndex = 9;
            lblSinav1.Text = "00";
            // 
            // lblNumara
            // 
            lblNumara.Location = new Point(160, 96);
            lblNumara.Margin = new Padding(5, 0, 5, 0);
            lblNumara.Name = "lblNumara";
            lblNumara.Size = new Size(177, 43);
            lblNumara.TabIndex = 8;
            lblNumara.Text = "000";
            // 
            // lblAdSoyad
            // 
            lblAdSoyad.Location = new Point(160, 30);
            lblAdSoyad.Margin = new Padding(5, 0, 5, 0);
            lblAdSoyad.Name = "lblAdSoyad";
            lblAdSoyad.Size = new Size(177, 43);
            lblAdSoyad.TabIndex = 7;
            lblAdSoyad.Text = "NULL";
            // 
            // FrmOgrenciDetay
            // 
            AutoScaleDimensions = new SizeF(13F, 26F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGreen;
            ClientSize = new Size(343, 484);
            Controls.Add(lblDurum);
            Controls.Add(lblOrtalama);
            Controls.Add(lblSinav3);
            Controls.Add(lblSinav2);
            Controls.Add(lblSinav1);
            Controls.Add(lblNumara);
            Controls.Add(lblAdSoyad);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5, 4, 5, 4);
            Name = "FrmOgrenciDetay";
            Text = "Öğrenci Notları";
            Load += FrmOgrenciDetay_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label lblDurum;
        private Label lblOrtalama;
        private Label lblSinav3;
        private Label lblSinav2;
        private Label lblSinav1;
        private Label lblNumara;
        private Label lblAdSoyad;
    }
}
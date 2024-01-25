namespace OgrenciNotKayitSistemi
{
    partial class FrmOgretmenDetay
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
            groupBox1 = new GroupBox();
            btnOgrenciKaydet = new Button();
            txtSoyad = new TextBox();
            mtxtNumara = new MaskedTextBox();
            txtAd = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            txtSinav3 = new TextBox();
            txtSinav2 = new TextBox();
            txtSinav1 = new TextBox();
            btnGuncelle = new Button();
            label11 = new Label();
            label6 = new Label();
            label4 = new Label();
            groupBox3 = new GroupBox();
            lblKalan = new Label();
            lblGecen = new Label();
            lblSinifOrt = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            groupBox4 = new GroupBox();
            dataGridView1 = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnOgrenciKaydet);
            groupBox1.Controls.Add(txtSoyad);
            groupBox1.Controls.Add(mtxtNumara);
            groupBox1.Controls.Add(txtAd);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(18, 14);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(299, 240);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Öğrenci Ekle";
            // 
            // btnOgrenciKaydet
            // 
            btnOgrenciKaydet.Location = new Point(26, 172);
            btnOgrenciKaydet.Name = "btnOgrenciKaydet";
            btnOgrenciKaydet.Size = new Size(241, 45);
            btnOgrenciKaydet.TabIndex = 6;
            btnOgrenciKaydet.Text = "Öğrenci Kaydet";
            btnOgrenciKaydet.UseVisualStyleBackColor = true;
            btnOgrenciKaydet.Click += btnOgrenciKaydet_Click;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(120, 136);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(147, 30);
            txtSoyad.TabIndex = 5;
            // 
            // mtxtNumara
            // 
            mtxtNumara.Location = new Point(120, 58);
            mtxtNumara.Mask = "000";
            mtxtNumara.Name = "mtxtNumara";
            mtxtNumara.Size = new Size(147, 30);
            mtxtNumara.TabIndex = 4;
            mtxtNumara.ValidatingType = typeof(int);
            // 
            // txtAd
            // 
            txtAd.Location = new Point(120, 97);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(147, 30);
            txtAd.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(45, 136);
            label3.Name = "label3";
            label3.Size = new Size(69, 24);
            label3.TabIndex = 2;
            label3.Text = "Soyad:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(74, 100);
            label2.Name = "label2";
            label2.Size = new Size(40, 24);
            label2.TabIndex = 1;
            label2.Text = "Ad:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 61);
            label1.Name = "label1";
            label1.Size = new Size(89, 24);
            label1.TabIndex = 0;
            label1.Text = "Numara:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtSinav3);
            groupBox2.Controls.Add(txtSinav2);
            groupBox2.Controls.Add(txtSinav1);
            groupBox2.Controls.Add(btnGuncelle);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(325, 14);
            groupBox2.Margin = new Padding(4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4);
            groupBox2.Size = new Size(291, 240);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Not Girişi";
            // 
            // txtSinav3
            // 
            txtSinav3.Location = new Point(112, 136);
            txtSinav3.Name = "txtSinav3";
            txtSinav3.Size = new Size(125, 30);
            txtSinav3.TabIndex = 9;
            // 
            // txtSinav2
            // 
            txtSinav2.Location = new Point(112, 97);
            txtSinav2.Name = "txtSinav2";
            txtSinav2.Size = new Size(125, 30);
            txtSinav2.TabIndex = 8;
            // 
            // txtSinav1
            // 
            txtSinav1.Location = new Point(112, 58);
            txtSinav1.Name = "txtSinav1";
            txtSinav1.Size = new Size(125, 30);
            txtSinav1.TabIndex = 7;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(27, 172);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(210, 32);
            btnGuncelle.TabIndex = 6;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(27, 61);
            label11.Name = "label11";
            label11.Size = new Size(79, 24);
            label11.TabIndex = 4;
            label11.Text = "Sınav 1:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(27, 100);
            label6.Name = "label6";
            label6.Size = new Size(81, 24);
            label6.TabIndex = 2;
            label6.Text = "Sınav 2:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 136);
            label4.Name = "label4";
            label4.Size = new Size(81, 24);
            label4.TabIndex = 0;
            label4.Text = "Sınav 3:";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(lblKalan);
            groupBox3.Controls.Add(lblGecen);
            groupBox3.Controls.Add(lblSinifOrt);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(label9);
            groupBox3.Location = new Point(624, 14);
            groupBox3.Margin = new Padding(4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(4);
            groupBox3.Size = new Size(305, 240);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Sınav Detay";
            // 
            // lblKalan
            // 
            lblKalan.AutoSize = true;
            lblKalan.Location = new Point(179, 145);
            lblKalan.Name = "lblKalan";
            lblKalan.Size = new Size(34, 24);
            lblKalan.TabIndex = 12;
            lblKalan.Text = "00";
            // 
            // lblGecen
            // 
            lblGecen.AutoSize = true;
            lblGecen.Location = new Point(179, 106);
            lblGecen.Name = "lblGecen";
            lblGecen.Size = new Size(34, 24);
            lblGecen.TabIndex = 11;
            lblGecen.Text = "00";
            // 
            // lblSinifOrt
            // 
            lblSinifOrt.AutoSize = true;
            lblSinifOrt.Location = new Point(179, 67);
            lblSinifOrt.Name = "lblSinifOrt";
            lblSinifOrt.Size = new Size(63, 24);
            lblSinifOrt.TabIndex = 10;
            lblSinifOrt.Text = "00,00";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(48, 145);
            label7.Name = "label7";
            label7.Size = new Size(125, 24);
            label7.TabIndex = 9;
            label7.Text = "Kalan Sayısı:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(44, 105);
            label8.Name = "label8";
            label8.Size = new Size(129, 24);
            label8.TabIndex = 8;
            label8.Text = "Geçen Sayısı:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(73, 67);
            label9.Name = "label9";
            label9.Size = new Size(100, 24);
            label9.TabIndex = 7;
            label9.Text = "Ortalama:";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(dataGridView1);
            groupBox4.Location = new Point(18, 261);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(911, 275);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "Sınav Notları";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 26);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(905, 246);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // FrmOgretmenDetay
            // 
            AutoScaleDimensions = new SizeF(12F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(958, 548);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "FrmOgretmenDetay";
            Text = "Öğrenci ve Not Ekleme";
            Load += FrmOgretmenDetay_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button btnOgrenciKaydet;
        private TextBox txtSoyad;
        private MaskedTextBox mtxtNumara;
        private TextBox txtAd;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnGuncelle;
        private TextBox txtSinav3;
        private MaskedTextBox txt;
        private GroupBox groupBox3;
        private Label lblKalan;
        private Label lblGecen;
        private Label lblSinifOrt;
        private Label label7;
        private Label label8;
        private Label label9;
        private GroupBox groupBox4;
        private DataGridView dataGridView1;
        private Label label11;
        private Label label6;
        private Label label4;
        private TextBox txtSinav2;
        private TextBox txtSinav1;
    }
}
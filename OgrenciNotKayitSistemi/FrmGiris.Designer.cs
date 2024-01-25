namespace OgrenciNotKayitSistemi
{
    partial class FrmGiris
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
            btnGiris = new Button();
            mtxtOgrenciNo = new MaskedTextBox();
            lblOgrenciNo = new Label();
            SuspendLayout();
            // 
            // btnGiris
            // 
            btnGiris.Location = new Point(14, 68);
            btnGiris.Name = "btnGiris";
            btnGiris.Size = new Size(339, 36);
            btnGiris.TabIndex = 5;
            btnGiris.Text = "Giriş Yap";
            btnGiris.UseVisualStyleBackColor = true;
            btnGiris.Click += btnGiris_Click;
            // 
            // mtxtOgrenciNo
            // 
            mtxtOgrenciNo.Location = new Point(196, 21);
            mtxtOgrenciNo.Mask = "000";
            mtxtOgrenciNo.Name = "mtxtOgrenciNo";
            mtxtOgrenciNo.Size = new Size(157, 27);
            mtxtOgrenciNo.TabIndex = 4;
            mtxtOgrenciNo.ValidatingType = typeof(int);
            // 
            // lblOgrenciNo
            // 
            lblOgrenciNo.Location = new Point(14, 9);
            lblOgrenciNo.Margin = new Padding(5, 0, 5, 0);
            lblOgrenciNo.Name = "lblOgrenciNo";
            lblOgrenciNo.Size = new Size(174, 56);
            lblOgrenciNo.TabIndex = 3;
            lblOgrenciNo.Text = "Öğrenci Numara:";
            lblOgrenciNo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FrmGiris
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 128, 0);
            ClientSize = new Size(386, 130);
            Controls.Add(btnGiris);
            Controls.Add(mtxtOgrenciNo);
            Controls.Add(lblOgrenciNo);
            Name = "FrmGiris";
            Text = "FrmGiris";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGiris;
        private MaskedTextBox mtxtOgrenciNo;
        private Label lblOgrenciNo;
    }
}
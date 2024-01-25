using OgrenciNotKayitSistemi.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OgrenciNotKayitSistemi
{
    public partial class FrmOgretmenDetay : Form
    {
        private DbNotKayitSistemiContext context = new DbNotKayitSistemiContext();
        public FrmOgretmenDetay()
        {
            InitializeComponent();
        }

        private void btnOgrenciKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                TblDer yeniOgrenci = new TblDer()
                {
                    OgrenciAd = txtAd.Text,
                    OgrenciSoyad = txtSoyad.Text,
                    OgrenciNo = mtxtNumara.Text
                };
                context.TblDers.Add(yeniOgrenci);
                context.SaveChanges();
                MessageBox.Show("Öğrenci başarıyla eklendi");
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = context.TblDers.ToList();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata meydana geldi. Hata:{ex}");
            }


        }

        private void FrmOgretmenDetay_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = context.TblDers.ToList();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtSinav1.Text=string.Empty;
            txtSinav2.Text=string.Empty;
            txtSinav3.Text=string.Empty;
            int secilenRow = dataGridView1.SelectedCells[0].RowIndex;
            string id = dataGridView1.Rows[secilenRow].Cells[0].Value.ToString();
            var ogrenci = context.TblDers.FirstOrDefault(x => x.OgrenciId == Convert.ToInt16(id));
            if (ogrenci != null)
            {
                if(ogrenci.OgrenciSinav1!=null)
                txtSinav1.Text = ogrenci.OgrenciSinav1.ToString();
                if (ogrenci.OgrenciSinav2 != null)
                    txtSinav2.Text = ogrenci.OgrenciSinav2.ToString();
                if (ogrenci.OgrenciSinav3 != null)
                    txtSinav3.Text = ogrenci.OgrenciSinav3.ToString();
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int secilenRow = dataGridView1.SelectedCells[0].RowIndex;
            string id = dataGridView1.Rows[secilenRow].Cells[0].Value.ToString();
            var ogrenci = context.TblDers.FirstOrDefault(x => x.OgrenciId == Convert.ToInt16(id));
            ogrenci.OgrenciSinav1 = Convert.ToByte(txtSinav1.Text);
            ogrenci.OgrenciSinav2 = Convert.ToByte(txtSinav2.Text);
            ogrenci.OgrenciSinav3 = Convert.ToByte(txtSinav3.Text);

            ogrenci.Ortalama = (ogrenci.OgrenciSinav1 + ogrenci.OgrenciSinav2 + ogrenci.OgrenciSinav3) / 3;
            if (ogrenci.Ortalama < 50)
            {
                ogrenci.Durum = false;
            }
            else { ogrenci.Durum = true; }
            lblSinifOrt.Text = ogrenci.Ortalama.ToString();
            context.SaveChanges();
        }
    }
}

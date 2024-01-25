using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using OgrenciNotKayitSistemi.Models;

namespace OgrenciNotKayitSistemi
{
    //Data Source=UMUR;Initial Catalog=DbNotKayitSistemi;Integrated Security=True
    public partial class FrmOgrenciDetay : Form
    {
        public DbNotKayitSistemiContext _db=new DbNotKayitSistemiContext();
        public FrmOgrenciDetay()
        {
            InitializeComponent();
        }
        public string numara;

        private void FrmOgrenciDetay_Load(object sender, EventArgs e)
        {
            var ogrenci = _db.TblDers.FirstOrDefault(x => x.OgrenciNo == numara);
            lblAdSoyad.Text = ogrenci.OgrenciAd + " " + ogrenci.OgrenciSoyad;
            lblNumara.Text = numara;
            lblSinav1.Text = ogrenci.OgrenciSinav1.ToString();
            lblSinav2.Text = ogrenci.OgrenciSinav2.ToString();
            lblSinav3.Text = ogrenci.OgrenciSinav3.ToString();
            lblOrtalama.Text = ogrenci.Ortalama.ToString();
            lblDurum.Text = ogrenci.Durum.ToString();
        }
    }
}

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
    public partial class FrmGiris : Form
    {
        public FrmGiris()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if(mtxtOgrenciNo.Text=="111")
            {
                FrmOgretmenDetay frmo=new FrmOgretmenDetay();
                frmo.Show();
            }
            else
            {
                FrmOgrenciDetay frm = new FrmOgrenciDetay();
                frm.numara = mtxtOgrenciNo.Text;
                frm.Show();
            }

        }
    }
}

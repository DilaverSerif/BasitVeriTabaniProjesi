using System;
using System.Windows.Forms;

namespace ProjeOdevi
{
    public partial class Recete : Form
    {
        public Recete()
        {
            InitializeComponent();
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            Ozellikler.TusKontrol(e);
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            Ozellikler.TusKontrol(e);
        }

        private void ekle_Click(object sender, EventArgs e)
        {
            string ekle =
                "insert into recete (anaurunkodu,aciklama,miktar) values('" + anaurun.Text + "','" + aciklama.Text + "','" + miktar.Text + "')";

            Baglanti.VeriEkle(ekle);
            VeriYenile();
        }

        public void VeriYenile()
        {
            Baglanti.VeriCek(recetetablo, "SELECT * from recete");
        }

        private void duzelt_Click(object sender, EventArgs e)
        {

            if (idbox.Text == null)
            {
                MessageBox.Show("ID YERI BOŞ BIRAKILDI. DÜZENLEME YAPMAK İÇİN ID YAZINIZ.");
            }
            else
            {
                string duzenle =
                    "UPDATE recete SET anaurunkodu = '" + anaurun.Text + "', aciklama = '" + aciklama.Text + "', miktar='" + miktar.Text + "' WHERE id = '" + idbox.Text + "' ";

                Baglanti.VeriEkle(duzenle);
                VeriYenile();
            }
        }

        private void sil_Click(object sender, EventArgs e)
        {

            if (idbox.Text == null)
            {
                MessageBox.Show("ID YERI BOŞ BIRAKILDI. DÜZENLEME YAPMAK İÇİN ID YAZINIZ.");
            }
            else
            {
                string sil = "DELETE from recete where id = " + idbox.Text + "";
                Baglanti.VeriEkle(sil);
                VeriYenile();
            }

        }
    }
}

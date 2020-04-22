using System;
using System.Windows.Forms;

namespace ProjeOdevi
{
    public partial class Istasyon : Form
    {
        public Istasyon()
        {
            InitializeComponent();
        }


        public void VeriYenile()
        {
            Baglanti.VeriCek(istasyontablo, "SELECT * from isistasyonu");
        }


        private void ekle_Click(object sender, EventArgs e)
        {
            string ekle =
                "insert into isistasyonu (istasyonkodu,aciklama,hammaddeambari,istasyonmaliyet) values('" + kodbox.Text + "','" + aciklamabox.Text + "','" + hammadde.Text + "','" + maliyet.Text + "')";

            Baglanti.VeriEkle(ekle);
            VeriYenile();
        }

        private void sil_Click(object sender, EventArgs e)
        {

            if (idbox.Text == null)
            {
                MessageBox.Show("ID YERI BOŞ BIRAKILDI. DÜZENLEME YAPMAK İÇİN ID YAZINIZ.");
            }
            else
            {
                string sil = "DELETE from isistasyonu where id = " + idbox.Text + "";
                Baglanti.VeriEkle(sil);
                VeriYenile();
            }

        }

        private void duzenle_Click(object sender, EventArgs e)
        {
            if (idbox.Text == null)
            {
                MessageBox.Show("ID YERI BOŞ BIRAKILDI. DÜZENLEME YAPMAK İÇİN ID YAZINIZ.");
            }
            else
            {
                string duzenle =
                    "UPDATE isistasyonu SET istasyonkodu = '" + kodbox.Text + "', aciklama = '" + aciklamabox.Text + "', hammaddeambari='" + hammadde.Text + "', istasyonmaliyet='" + maliyet.Text + "' WHERE id = '" + idbox.Text + "' ";

                Baglanti.VeriEkle(duzenle);
                VeriYenile();
            }
        }

        private void maliyet_KeyPress(object sender, KeyPressEventArgs e)
        {
            Ozellikler.TusKontrol(e);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Ozellikler.TusKontrol(e);
        }
    }
}

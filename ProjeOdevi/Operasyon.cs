using System;
using System.Windows.Forms;

namespace ProjeOdevi
{
    public partial class Operasyon : Form
    {
        public Operasyon()
        {
            InitializeComponent();
        }

        public void VeriYenile()
        {
            Baglanti.VeriCek(operasyontablo, "SELECT * from operasyon");
        }


        private void beklemesuresibox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Ozellikler.TusKontrol(e);
        }

        private void tasimasuresibox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Ozellikler.TusKontrol(e);
        }

        private void islembox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Ozellikler.TusKontrol(e);
        }

        private void toplamsurebox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Ozellikler.TusKontrol(e);
        }

        private void ekle_Click(object sender, EventArgs e)
        {
            string ekle =
                "insert into operasyon (operasyonkodu,operasyonsuresi,islemsuresi,beklemesuresi,tasimasuresi,operasyonaciklama,isistasyonu) values('" + 
                kodbox.Text + "','" + toplamsurebox.Text + "','" + islembox.Text +"','" + beklemesuresibox.Text + "','" + tasimasuresibox.Text + "','" + aciklamabox.Text + "','" + istasyonbox.Text+ "')";

            Baglanti.VeriEkle(ekle);
            VeriYenile();
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
                    "UPDATE operasyon SET operasyonkodu = '" + kodbox.Text + "', operasyonsuresi = '" + toplamsurebox.Text + "', islemsuresi='" + islembox.Text +
                        "beklemesuresi = '" + beklemesuresibox.Text + "', tasimasuresi = '" + tasimasuresibox.Text + "', operasyonaciklama = '" + aciklamabox.Text +
                    "isistasyonu = '" + istasyonbox.Text +
                    "' WHERE id = '" + idbox.Text + "' ";

                Baglanti.VeriEkle(duzenle);
                VeriYenile();
            }
        }

        private void sil_Click(object sender, EventArgs e)
        {
            if (idbox.Text == null)
            {
                MessageBox.Show("ID YERI BOŞ BIRAKILDI. SİLMEK İÇİN ID YAZINIZ.");
            }
            else
            {
                string sil = "DELETE from operasyon where id = " + idbox.Text + "";
                Baglanti.VeriEkle(sil);
                VeriYenile();
            }

        }

    }
}

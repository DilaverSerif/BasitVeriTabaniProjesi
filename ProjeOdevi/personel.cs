using System;
using System.Windows.Forms;

namespace ProjeOdevi
{
    public partial class Personel : Form
    {
        public Personel()
        {
            InitializeComponent();
        }


        public void VeriYenile()
        {
            Baglanti.VeriCek(tablopersonel, "SELECT * from calisan");
        }


        private void ekle_Click(object sender, EventArgs e)
        {
            string ekle =
                "insert into calisan (tc,adisoyadi,gorev,birimsaat,aylik) values('" + tc.Text + "','"+ adisoyadi.Text+"','" + gorev.Text + "','" + Int32.Parse(birim.Text) + "','" + Int32.Parse(aylik.Text) + "')";

            Baglanti.VeriEkle(ekle);
            VeriYenile();
        }

        private void tc_KeyPress(object sender, KeyPressEventArgs e)
        {
            Ozellikler.TusKontrol(e);
        }

        private void birim_KeyPress(object sender, KeyPressEventArgs e)
        {
            Ozellikler.TusKontrol(e);
        }

        private void aylik_KeyPress(object sender, KeyPressEventArgs e)
        {
            Ozellikler.TusKontrol(e); 
        }

        private void duzenle_Click_1(object sender, EventArgs e)
        {

            if (idgir.Text == null)
            {
                MessageBox.Show("ID YERI BOŞ BIRAKILDI. DÜZENLEME YAPMAK İÇİN ID YAZINIZ.");
            }
            else
            {
                string duzenle =
                    "UPDATE calisan SET tc = '" + tc.Text + "', adisoyadi = '" + adisoyadi.Text + "', gorev='" + gorev.Text + "', birimsaat = '" + birim.Text + "', aylik = '" + aylik.Text + "' WHERE id = '" + idgir.Text + "' ";

                Baglanti.VeriEkle(duzenle);
                VeriYenile();
            }

        }

        private void sil_Click(object sender, EventArgs e)
        {


            if (idgir.Text == null)
            {
                MessageBox.Show("ID YERI BOŞ BIRAKILDI. DÜZENLEME YAPMAK İÇİN ID YAZINIZ.");
            }
            else
            {
                string sil = "DELETE from calisan where id = " + idgir.Text + "";
                Baglanti.VeriEkle(sil);
                VeriYenile();
            }


        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjeOdevi
{
    public partial class Giris : Form
    {

        Menu ikinci = new Menu();
        
        public Giris()
        {
            InitializeComponent();
            baglanti.Text = Baglanti.Baglan();
        }


        private void button1_Click(object sender, EventArgs e)
        {

            if (id.Text == "admin" & sifre.Text == "admin")
            {
                ikinci.Show();
                this.Hide();
            }
            else
            {
                uyari.Text = "HATA TEKRAR DENE";
            }


        }
    }
}

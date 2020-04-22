using System;
using System.Windows.Forms;

namespace ProjeOdevi
{
    public partial class Menu : Form
    {
        private Personel personForm = new Personel();
        private Istasyon istasyonForm = new Istasyon();
        private Recete receteForm = new Recete();
        private Operasyon operasyonForm = new Operasyon();

        public Menu()
        {
            InitializeComponent();
        }

        private void recetebuton_Click(object sender, EventArgs e)
        {
            receteForm.Show();
            receteForm.VeriYenile();
        }

        private void calisanbuton_Click(object sender, EventArgs e)
        {
            personForm.Show();
            personForm.VeriYenile();
        }

        private void operasyonbuton_Click(object sender, EventArgs e)
        {
            istasyonForm.Show();
            istasyonForm.VeriYenile();
        }

        private void istasyonbuton_Click(object sender, EventArgs e)
        {
            operasyonForm.Show();
            operasyonForm.VeriYenile();
        }

    }
}

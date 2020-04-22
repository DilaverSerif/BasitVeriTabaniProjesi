using System;
using System.Windows.Forms;

namespace ProjeOdevi
{
    class Ozellikler
    {

        public static void TusKontrol(KeyPressEventArgs e)
        {
            Char rakam = e.KeyChar;

            if (!Char.IsDigit(rakam) & rakam != 8)
            {
                e.Handled = true;
                MessageBox.Show("SADECE RAKAM GIREBILIR");
            }
        }


    }
}

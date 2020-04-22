using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProjeOdevi
{
    class Baglanti
    {
        public static SqlConnection baglanti;

        public static string Baglan()
        {
            try
            {
                var db = new SqlConnectionStringBuilder();
                db.DataSource = "DESKTOP-049H6S9\\SQLEXPRESS";
                db.IntegratedSecurity = true;
                db.InitialCatalog = "proje";
                

                using (baglanti = new SqlConnection(db.ConnectionString))
                {
                    baglanti = new SqlConnection(db.ConnectionString);
                    baglanti.Open();
                    return "BAĞLANTI BAŞARILI";
                }

            }

            catch (SqlException e)
            {
                return "BAĞLANTI BAŞARISIZ" + e.ToString();
            }

           
        }

        public static void VeriEkle(string kayit)
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                }

                SqlCommand komut = new SqlCommand(kayit, baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                throw;
            }

        }


        public static void VeriCek(DataGridView tablo,string kayit)
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }


            SqlDataAdapter da = new SqlDataAdapter(kayit,baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            tablo.DataSource = dt;
            baglanti.Close();
        }



    }


}

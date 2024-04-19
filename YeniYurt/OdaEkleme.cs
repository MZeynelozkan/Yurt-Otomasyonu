using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YeniYurt
{
    public partial class OdaEkleme : Form
    {
        Connection connection = new Connection();

        
        public OdaEkleme()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void OdaNumarasiBOX_TextChanged(object sender, EventArgs e)
        {

        }

        private void OdaKatiBOX_TextChanged(object sender, EventArgs e)
        {

        }

        private void OdaKapasiteBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void OdayiEklemeBTN_Click(object sender, EventArgs e)
        {

            
            try
            {
                string odaNumarasi = OdaNumarasiBOX.Text;
                string odaKati = OdaKatiBOX.Text;
                int odaKapasitesi = int.Parse(OdaKapasiteBox.Text);

                string connectionString = connection.connectionString; // Veritabanı bağlantı dizesi

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO Odalar (OdaNumarasi, Kat, Kapasite) VALUES (@OdaNumarasi, @Kat, @Kapasite)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@OdaNumarasi", odaNumarasi);
                        command.Parameters.AddWithValue("@Kat", odaKati);
                        command.Parameters.AddWithValue("@Kapasite", odaKapasitesi);

                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Oda başarıyla eklendi.");
            }
            catch (FormatException)
            {
                MessageBox.Show("Lütfen geçerli sayısal değerler girin.");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Veritabanı hatası: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message);
            }
        }

        private void BackBTN_Click(object sender, EventArgs e)
        {
            this.Hide();
            YoneticiEkran yoneticiEkran = new YoneticiEkran();  
            yoneticiEkran.Show();   
        }
    }
}

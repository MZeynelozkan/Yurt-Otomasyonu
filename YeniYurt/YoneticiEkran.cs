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
    public partial class YoneticiEkran : Form
    {
        Connection connection = new Connection();
        public YoneticiEkran()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            KayitForm KayitEkrani = new KayitForm();
            KayitEkrani.Show(); // Öğrenci ekranını göster
            this.Hide(); // Mevcut Giriş ekranını gizle
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            OgrenciAnaEkran ogrenciAnaEkran = new OgrenciAnaEkran();
            ogrenciAnaEkran.Show();
            this.Hide();
        }

        private void ListeleBTN_Click(object sender, EventArgs e)
        {
            string connectionString = connection.connectionString;
            string query = @"
        SELECT 
            Ogrenciler.OgrenciID, 
            Ogrenciler.Ad, 
            Ogrenciler.Soyad, 
            Ogrenciler.DogumTarihi, 
            Ogrenciler.TasinmaTarihi, 
            Ogrenciler.TasinmaPlaniTarihi, 
            Ogrenciler.OdaNumarasi  
        FROM 
            Ogrenciler";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);

                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                dataGridView1.DataSource = dataTable;
            }
        }





        private void OdaEkleBTN_Click(object sender, EventArgs e)
        {
            this.Hide();
            OdaEkleme odaEkleme = new OdaEkleme();
            odaEkleme.Show();
        }

        private void OdaListeleBTN_Click(object sender, EventArgs e)
        {
            string connectionString = connection.connectionString; // Veritabanı bağlantı dizesi

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Odalar"; // Tüm oda bilgilerini çeker

                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                // DataGridView'e verileri bağla
                dataGridView2.DataSource = dataTable;
            }
        }

        private void SilmeButonu_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                int seciliSatirIndex = dataGridView2.SelectedRows[0].Index;
                string seciliOdaNumarasi = dataGridView2.Rows[seciliSatirIndex].Cells["OdaNumarasi"].Value.ToString();

                string connectionString = connection.connectionString; // Veritabanı bağlantı dizesi

                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        string query = "DELETE FROM Odalar WHERE OdaNumarasi = @OdaNumarasi";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@OdaNumarasi", seciliOdaNumarasi);

                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        connection.Close();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Oda başarıyla silindi.");

                        }
                        else
                        {
                            MessageBox.Show("Silme işlemi başarısız.");
                        }
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Odayi Silmeden Once Odada ki Ogrencileri Baska Odaya Tasiyiniz");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Genel hata: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Lütfen silmek istediğiniz satırı seçin.");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
 
        }

        private void Guncelleme_Click(object sender, EventArgs e)
        {
            this.Hide();
            OgrenciGuncelleme ogrenciGuncelleme = new OgrenciGuncelleme();
            ogrenciGuncelleme.Show();   
        }

        private void BackBTN_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void OgrenciSilBTN_Click(object sender, EventArgs e)
        {
            this.Hide();
            OgrenciSilmeForm  ogrenciSilmeForm = new OgrenciSilmeForm();
            ogrenciSilmeForm.Show();
        }

        private void GiderBTN_Click(object sender, EventArgs e)
        {
            this.Hide();
            GiderEkleme giderEkleme = new GiderEkleme();    
            giderEkleme.Show();
        }

        private void GelirGiderBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            GelirGider gelirGider = new GelirGider();
            gelirGider.Show();
        }
    }
}




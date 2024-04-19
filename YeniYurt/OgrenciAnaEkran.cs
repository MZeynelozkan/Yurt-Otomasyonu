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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace YeniYurt
{
    public partial class OgrenciAnaEkran : Form
    {
        public OgrenciAnaEkran()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        Connection connection = new Connection();

        private void button1_Click(object sender, EventArgs e)
        {
            int odenenTutar;
            int odaFiyati;
            int ogrenciID;

            if (!int.TryParse(tutarBox.Text, out odenenTutar))
            {
                MessageBox.Show("Lütfen geçerli bir ödenecek tutar giriniz.");
                return;
            }

            if (!int.TryParse(OdaFiyatBOX.Text, out odaFiyati))
            {
                MessageBox.Show("Lütfen geçerli bir oda fiyatı giriniz.");
                return;
            }

            if (!int.TryParse(OgrenciID.Text, out ogrenciID))
            {
                MessageBox.Show("Lütfen geçerli bir öğrenci ID giriniz.");
                return;
            }

            if (odenenTutar % odaFiyati != 0)
            {
                MessageBox.Show("Ödenen tutar oda fiyatının katları olmalıdır.");
                return;
            }

            int odenenAySayisi = odenenTutar / odaFiyati;
            DateTime yeniTasinmaPlaniTarihi = dateTimePicker2.Value.AddMonths(odenenAySayisi);

            string connectionString = connection.connectionString;
            string updateQuery = @"
        UPDATE Ogrenciler
        SET TasinmaPlaniTarihi = @YeniTasinmaPlaniTarihi
        WHERE OgrenciID = @OgrenciID";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(updateQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@YeniTasinmaPlaniTarihi", yeniTasinmaPlaniTarihi);
                    cmd.Parameters.AddWithValue("@OgrenciID", ogrenciID);

                    try
                    {
                        conn.Open();
                        int result = cmd.ExecuteNonQuery();

                        if (result > 0)
                        {
                            // Ödeme işlemi başarılı ise Gelir tablosunu güncelle
                            OdemeYap(ogrenciID, odenenTutar);
                            MessageBox.Show("Ödeme alındı ve taşınma planı tarihi güncellendi.");
                            dateTimePicker2.Value = yeniTasinmaPlaniTarihi; // Kullanıcı arayüzünü güncelle
                        }
                        else
                        {
                            MessageBox.Show("Öğrenci bulunamadı veya başka bir hata oluştu.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hata: " + ex.Message);
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }
        }

        private void OdemeYap(int ogrenciID, int odenenTutar)
        {
            string connectionString = connection.connectionString;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                // Önce öğrenci için var olan kaydı kontrol et
                string checkQuery = @"
            SELECT OdenenTutar FROM Gelir WHERE OgrenciID = @OgrenciID";
                SqlCommand checkCmd = new SqlCommand(checkQuery, conn);
                checkCmd.Parameters.AddWithValue("@OgrenciID", ogrenciID);

                try
                {
                    conn.Open();
                    object currentTutar = checkCmd.ExecuteScalar();

                    if (currentTutar != null)
                    {
                        // Eğer kayıt varsa, tutarı güncelle
                        int yeniToplamTutar = odenenTutar + Convert.ToInt32(currentTutar);
                        string updateQuery = @"
                    UPDATE Gelir SET OdenenTutar = @YeniToplamTutar
                    WHERE OgrenciID = @OgrenciID";
                        SqlCommand updateCmd = new SqlCommand(updateQuery, conn);
                        updateCmd.Parameters.AddWithValue("@YeniToplamTutar", yeniToplamTutar);
                        updateCmd.Parameters.AddWithValue("@OgrenciID", ogrenciID);
                        updateCmd.ExecuteNonQuery();
                    }
                    else
                    {
                        // Eğer kayıt yoksa, yeni kayıt oluştur
                        string insertQuery = @"
                    INSERT INTO Gelir (OgrenciID, OdemeTarihi, OdenenTutar)
                    VALUES (@OgrenciID, @OdemeTarihi, @OdenenTutar)";
                        SqlCommand insertCmd = new SqlCommand(insertQuery, conn);
                        insertCmd.Parameters.AddWithValue("@OgrenciID", ogrenciID);
                        insertCmd.Parameters.AddWithValue("@OdemeTarihi", DateTime.Now);
                        insertCmd.Parameters.AddWithValue("@OdenenTutar", odenenTutar);
                        insertCmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
        }











        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void OgrencID_TextChanged(object sender, EventArgs e)
        {
            // TextBox'tan öğrenci numarasını al
            if (int.TryParse(OgrenciID.Text, out int ogrenciNumarasi))
            {
                OgrenciDetaylariVeOda(ogrenciNumarasi);
            }
            else
            {
                // Eğer öğrenci numarası geçerli bir sayı değilse, ilgili alanları temizle
                AdSoyadBox.Text = "";
                OdaBox.Text = ""; // Oda numarasını gösteren TextBox'ın temizlenmesi
                dateTimePicker1.Value = DateTime.Today;
                dateTimePicker2.Value = DateTime.Today;
            }
        }

        private void OgrenciDetaylariVeOda(int ogrenciNumarasi)
        {
            string connectionString = connection.connectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Öğrencinin adını, soyadını, oda numarasını ve taşınma planı tarihini almak için sorgu
                string query = @"
            SELECT Ad, Soyad, OdaNumarasi, TasinmaPlaniTarihi
            FROM Ogrenciler
            WHERE OgrenciID = @OgrenciID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@OgrenciID", ogrenciNumarasi);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            AdSoyadBox.Text = $"{reader["Ad"]} {reader["Soyad"]}";
                            OdaBox.Text = reader["OdaNumarasi"].ToString();

                            // Taşınma planı tarihini güncelle
                            if (reader["TasinmaPlaniTarihi"] != DBNull.Value)
                            {
                                dateTimePicker2.Value = (DateTime)reader["TasinmaPlaniTarihi"];
                            }
                            else
                            {
                                dateTimePicker2.Value = DateTime.Today; // Varsayılan tarih
                            }
                        }
                        else
                        {
                            // Öğrenci bulunamazsa temizleme işlemleri
                            AdSoyadBox.Text = "Öğrenci bulunamadı";
                            OdaBox.Text = "";
                            dateTimePicker1.Value = DateTime.Today;
                            dateTimePicker2.Value = DateTime.Today;
                        }
                    }
                }
                connection.Close();
            }
        }







        private void OgrenciAnaEkran_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void OdaBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void BackBTN_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            YoneticiEkran yoneticiEkran = new YoneticiEkran();
            yoneticiEkran.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}

using System.Data.SqlClient;
using System.Windows.Forms;
using System;

namespace YeniYurt
{
    internal class OgrenciKaydetVeAta
    {
        Connection connection = new Connection();

        public void OgrenciKaydetVeOdaAta(string ad, string soyad, DateTime dogumTarihi, string cinsiyet, int ogrenciId)
        {
            string connectionString = connection.connectionString;

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Rastgele bir oda numarası seç
                    string rastgeleOdaNumarasiSorgusu = "SELECT OdaNumarasi FROM Odalar WHERE Kapasite > MevcutDoluluk ORDER BY NEWID()";
                    SqlCommand odaNumarasiCommand = new SqlCommand(rastgeleOdaNumarasiSorgusu, conn);

                    object odaNumarasiResult = odaNumarasiCommand.ExecuteScalar();
                    string odaNumarasi = odaNumarasiResult != null ? odaNumarasiResult.ToString() : null;

                    if (odaNumarasi == null)
                    {
                        MessageBox.Show("Uygun oda bulunamadı.");
                        return;
                    }

                    // Öğrenci kaydını ve oda numarasını ekle
                    string ogrenciEkleSorgusu = @"
                        INSERT INTO Ogrenciler (OgrenciID, Ad, Soyad, DogumTarihi, OdaNumarasi, TasinmaTarihi, TasinmaPlaniTarihi)
                        VALUES (@OgrenciID, @Ad, @Soyad, @DogumTarihi, @OdaNumarasi, @TasinmaTarihi, @TasinmaPlaniTarihi)";

                    using (SqlCommand command = new SqlCommand(ogrenciEkleSorgusu, conn))
                    {
                        command.Parameters.AddWithValue("@OgrenciID", ogrenciId);
                        command.Parameters.AddWithValue("@Ad", ad);
                        command.Parameters.AddWithValue("@Soyad", soyad);
                        command.Parameters.AddWithValue("@DogumTarihi", dogumTarihi);
                        command.Parameters.AddWithValue("@OdaNumarasi", odaNumarasi);
                        command.Parameters.AddWithValue("@TasinmaTarihi", DateTime.Now); // Kayıt tarihi olarak şu anki zaman
                        command.Parameters.AddWithValue("@TasinmaPlaniTarihi", DBNull.Value); // Taşınma planı tarihi olarak NULL

                        command.ExecuteNonQuery();
                    }

                    // Seçilen odanın MevcutDoluluk değerini 1 artır
                    string odaDolulukGuncelleSorgusu = @"
                        UPDATE Odalar
                        SET MevcutDoluluk = MevcutDoluluk + 1
                        WHERE OdaNumarasi = @OdaNumarasi";

                    using (SqlCommand command = new SqlCommand(odaDolulukGuncelleSorgusu, conn))
                    {
                        command.Parameters.AddWithValue("@OdaNumarasi", odaNumarasi);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627) // Sql Server Hata Kodu
                {
                    MessageBox.Show("Bu öğrenci ID numarası zaten kullanılıyor, lütfen başka bir ID giriniz.");
                }
                else
                {
                    MessageBox.Show("Veritabanı işlemi sırasında bir hata oluştu: " + ex.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message);
            }
        }
    }
}

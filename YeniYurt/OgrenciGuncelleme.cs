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
    public partial class OgrenciGuncelleme : Form
    {
        Connection connection = new Connection();
        public OgrenciGuncelleme()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }



        private void OdaNumarasiBOX_TextChanged(object sender, EventArgs e)
        {

        }

        private void OgrenciIDBOX_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Kullanıcının girdiği değerleri al ve integer'a dönüştür
            bool ogrenciIDSuccess = int.TryParse(OgrenciIDBOX.Text, out int ogrenciID);
            bool odaNumarasiSuccess = int.TryParse(OdaNumarasiBOX.Text, out int odaNumarasi);

            if (ogrenciIDSuccess && odaNumarasiSuccess)
            {
                // Güncelleme işlemini yapacak metodu çağır
                OgrenciOdaNumarasiniGuncelle(ogrenciID, odaNumarasi);
            }
            else
            {
                MessageBox.Show("Lütfen geçerli bir öğrenci ID ve oda numarası giriniz.");
            }
        }

        private void OgrenciOdaNumarasiniGuncelle(int ogrenciID, int yeniOdaNumarasi)
        {
            string connectionString = connection.connectionString;

            using (SqlConnection baglanti = new SqlConnection(connectionString))
            {
                baglanti.Open();
                SqlTransaction transaction = baglanti.BeginTransaction();

                try
                {
                    // Öğrencinin eski oda numarasını al
                    string eskiOdaNumarasiSorgu = @"
                SELECT OdaNumarasi 
                FROM Ogrenciler 
                WHERE OgrenciID = @OgrenciID";
                    SqlCommand eskiOdaNumarasiKomut = new SqlCommand(eskiOdaNumarasiSorgu, baglanti, transaction);
                    eskiOdaNumarasiKomut.Parameters.AddWithValue("@OgrenciID", ogrenciID);
                    var eskiOdaNumarasi = eskiOdaNumarasiKomut.ExecuteScalar();

                    if (eskiOdaNumarasi == null)
                    {
                        throw new Exception("Öğrenci için eski oda numarası bulunamadı.");
                    }

                    // Eski odanın MevcutDoluluk değerini azalt
                    string eskiOdaDolulukAzaltSorgu = @"
                UPDATE Odalar 
                SET MevcutDoluluk = MevcutDoluluk - 1 
                WHERE OdaNumarasi = @EskiOdaNumarasi";
                    SqlCommand eskiOdaDolulukAzaltKomut = new SqlCommand(eskiOdaDolulukAzaltSorgu, baglanti, transaction);
                    eskiOdaDolulukAzaltKomut.Parameters.AddWithValue("@EskiOdaNumarasi", eskiOdaNumarasi);
                    eskiOdaDolulukAzaltKomut.ExecuteNonQuery();

                    // Yeni odanın MevcutDoluluk değerini artır
                    string yeniOdaDolulukArtirSorgu = @"
                UPDATE Odalar 
                SET MevcutDoluluk = MevcutDoluluk + 1 
                WHERE OdaNumarasi = @YeniOdaNumarasi";
                    SqlCommand yeniOdaDolulukArtirKomut = new SqlCommand(yeniOdaDolulukArtirSorgu, baglanti, transaction);
                    yeniOdaDolulukArtirKomut.Parameters.AddWithValue("@YeniOdaNumarasi", yeniOdaNumarasi);
                    yeniOdaDolulukArtirKomut.ExecuteNonQuery();

                    // Öğrencinin oda numarasını güncelle
                    string ogrenciOdaGuncelleSorgu = @"
                UPDATE Ogrenciler 
                SET OdaNumarasi = @YeniOdaNumarasi 
                WHERE OgrenciID = @OgrenciID";
                    SqlCommand ogrenciOdaGuncelleKomut = new SqlCommand(ogrenciOdaGuncelleSorgu, baglanti, transaction);
                    ogrenciOdaGuncelleKomut.Parameters.AddWithValue("@OgrenciID", ogrenciID);
                    ogrenciOdaGuncelleKomut.Parameters.AddWithValue("@YeniOdaNumarasi", yeniOdaNumarasi);
                    ogrenciOdaGuncelleKomut.ExecuteNonQuery();

                    // İşlemi onayla
                    transaction.Commit();
                    MessageBox.Show("Öğrencinin oda numarası başarıyla güncellendi ve oda dolulukları ayarlandı.");
                }
                catch (Exception hata)
                {
                    // İşlemi geri almaya çalış
                    transaction.Rollback();
                    MessageBox.Show("Bir hata oluştu: " + hata.Message);
                }
                finally
                {
                    baglanti.Close();
                }
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





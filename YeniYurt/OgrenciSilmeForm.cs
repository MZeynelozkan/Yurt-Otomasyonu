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
    public partial class OgrenciSilmeForm : Form
    {
        Connection connection = new Connection();
        public OgrenciSilmeForm()
        {
            InitializeComponent();
        }

        private void SilBTN_Click(object sender, EventArgs e)
        {
            int ogrenciID;
            if (!int.TryParse(OgrenciID.Text, out ogrenciID))
            {
                MessageBox.Show("Lütfen geçerli bir öğrenci ID giriniz.");
                return;
            }

            string connectionString = connection.connectionString;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    // İlk olarak öğrenciye ait Gelir kayıtlarını sil
                    string gelirKayitlariSilSorgu = "DELETE FROM Gelir WHERE OgrenciID = @OgrenciID";
                    SqlCommand gelirKayitlariSilKomut = new SqlCommand(gelirKayitlariSilSorgu, conn, transaction);
                    gelirKayitlariSilKomut.Parameters.AddWithValue("@OgrenciID", ogrenciID);
                    gelirKayitlariSilKomut.ExecuteNonQuery();

                    // Daha sonra öğrenciyi sil
                    string ogrenciSilSorgu = "DELETE FROM Ogrenciler WHERE OgrenciID = @OgrenciID";
                    SqlCommand ogrenciSilKomut = new SqlCommand(ogrenciSilSorgu, conn, transaction);
                    ogrenciSilKomut.Parameters.AddWithValue("@OgrenciID", ogrenciID);
                    int silinenSatirSayisi = ogrenciSilKomut.ExecuteNonQuery();

                    // İşlemi onayla
                    transaction.Commit();

                    if (silinenSatirSayisi > 0)
                    {
                        MessageBox.Show("Öğrenci ve ilişkili gelir kayıtları başarıyla silindi.");
                    }
                    else
                    {
                        MessageBox.Show("Öğrenci bulunamadı veya zaten silinmiş.");
                    }
                }
                catch (Exception hata)
                {
                    // İşlemi geri al
                    transaction.Rollback();
                    MessageBox.Show("Bir hata oluştu: " + hata.Message);
                }
                finally
                {
                    conn.Close();
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

    

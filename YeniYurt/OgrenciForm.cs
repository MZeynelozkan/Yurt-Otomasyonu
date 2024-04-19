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
    public partial class OgrenciForm : Form
    {
        public OgrenciForm()
        {
            InitializeComponent();
        }

        private void KayitLabel_Click(object sender, EventArgs e)
        {
            KayitForm KayitEkrani = new KayitForm();
            KayitEkrani.Show(); // Öğrenci ekranını göster
            this.Hide(); // Mevcut Giriş ekranını gizle
        }

        private void GirisBTN_Click(object sender, EventArgs e)
        {
            // Öğrenci numarası ve şifre kutularının boş olup olmadığını kontrol et
            if (string.IsNullOrWhiteSpace(IDBox.Text) || string.IsNullOrWhiteSpace(PassBOX.Text))
            {
                MessageBox.Show("Öğrenci numarası ve şifre alanları boş bırakılamaz.");
                return;
            }

            string connectionString = "Data Source=DESKTOP-KVIRVD3\\BENIMSERVER; Initial Catalog=YurtOtomasyonDB; Integrated Security=True";
            string query = "SELECT Ad, Soyad FROM Ogrenciler WHERE OgrenciID = @ID AND Password = @Password";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Parametreleri güvenli bir şekilde ekleyin
                    command.Parameters.AddWithValue("@ID", IDBox.Text.Trim());
                    command.Parameters.AddWithValue("@Password", PassBOX.Text); // Gerçek uygulamada şifre hash'lenmeli

                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read()) // Eğer bir kayıt dönüyorsa, giriş başarılıdır.
                        {
                            string ad = reader["Ad"].ToString();
                            string soyad = reader["Soyad"].ToString();
                            MessageBox.Show($"Hoşgeldiniz, {ad} {soyad}!");
                            this.Hide();
                            OgrenciAnaEkran OgrenciAEkran = new OgrenciAnaEkran();
                            OgrenciAEkran.Show();

                            // Burada giriş yapan kullanıcı için ana formu veya başka bir formu gösterebilirsiniz.
                            // Örneğin: AnaForm anaForm = new AnaForm(); anaForm.Show(); this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Öğrenci numarası veya şifre hatalı.");
                        }
                    }
                }
            }
        }


        private void PassBOX_TextChanged(object sender, EventArgs e)
        {

        }

        private void IDBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

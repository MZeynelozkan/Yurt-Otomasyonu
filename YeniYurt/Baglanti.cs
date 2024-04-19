using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YeniYurt
{
    internal class Baglanti
    {
        public string connectionString;

        public Baglanti()
        {
            try
            {
                connectionString = System.IO.File.ReadAllText(@"C:\test.txt");
            }
            catch (System.Exception ex)
            {
                // Hata mesajını logla veya kullanıcıya göster
                string hataDetayi = ex.ToString();
                System.Diagnostics.Debug.WriteLine("Connection string yüklenirken hata oluştu: " + hataDetayi);
                MessageBox.Show("Bir hata oluştu: " + hataDetayi);
                // Uygulama burada devam edemez, gerekiyorsa uygulamayı kapat
                Environment.Exit(1);
            }

        }
    }
}


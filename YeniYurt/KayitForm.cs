using System;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;

namespace YeniYurt
{
    public partial class KayitForm : Form
    {
        public KayitForm()
        {
            InitializeComponent();
        }




        // BackgroundWorker'ı başlatma ve olayları ayarlama
        private void InitializeBackgroundWorker()
        {
            backgroundWorker1.DoWork += new DoWorkEventHandler(backgroundWorker1_DoWork);
            backgroundWorker1.ProgressChanged += new ProgressChangedEventHandler(backgroundWorker1_ProgressChanged);
            backgroundWorker1.RunWorkerCompleted += new RunWorkerCompletedEventHandler(backgroundWorker1_RunWorkerCompleted);
            backgroundWorker1.WorkerReportsProgress = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0; // ProgressBar'ı sıfırla
            backgroundWorker1.RunWorkerAsync(); // BackgroundWorker'ı çalıştır
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            string ad = IsimBox.Text;
            string soyad = SoyIsimBox.Text;
            DateTime dogumTarihi = DogumTarihiPick.Value;
            string cinsiyet = "B"; 

            if (!int.TryParse(IDBox.Text, out int ogrenciId))
            {
                MessageBox.Show("Lütfen geçerli bir öğrenci ID'si giriniz.");
                return;
            }

            OgrenciKaydetVeAta a1 = new OgrenciKaydetVeAta();
            a1.OgrenciKaydetVeOdaAta(ad, soyad, dogumTarihi, cinsiyet, ogrenciId);

            for (int i = 0; i <= 100; i++) // ProgressBar ilerlemesini simüle et
            {
                System.Threading.Thread.Sleep(50); 
                backgroundWorker1.ReportProgress(i);
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage; // ProgressBar'ı güncelle
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show("Kayıt olundu!");
            this.Hide();
            YoneticiEkran yoneticiEkran = new YoneticiEkran();
            yoneticiEkran.Show();
        }

        private void BackBTN_Click(object sender, EventArgs e)
        {
            this.Hide();
            YoneticiEkran yoneticiEkran = new YoneticiEkran();
            yoneticiEkran.Show();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void KayitForm_Load(object sender, EventArgs e)
        {
            InitializeBackgroundWorker(); // BackgroundWorker'ı başlat
        }


        private void PasswordBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void IDBox_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void DogumTarihiPick_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void SoyIsimBox_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void IsimBox_TextChanged(object sender, EventArgs e)
        {
            
        }

    }

}


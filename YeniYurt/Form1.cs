using System;
using System.Windows.Forms;

namespace YeniYurt
{
    public partial class GirisEkrani : Form
    {
        public GirisEkrani()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void OgrenciBTN_Click(object sender, EventArgs e)
        {
            OgrenciForm ogrenciEkranı = new OgrenciForm();
            ogrenciEkranı.Show(); // Öğrenci ekranını göster
            this.Hide(); // Mevcut Giriş ekranını gizle
        }

        private void YoneticiBTN_Click(object sender, EventArgs e)
        {
            YoneticiEkran yoneticiEkran = new YoneticiEkran();
            yoneticiEkran.Show();
            this.Hide();
        }
    }
}

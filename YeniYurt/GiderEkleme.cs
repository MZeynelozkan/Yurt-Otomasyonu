using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace YeniYurt
{
    public partial class GiderEkleme : Form
    {
        Connection connection = new Connection();
        public GiderEkleme()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = connection.connectionString;
            
                int gider;
                string giderSebebi = GiderSebepText.Text;

                if (!int.TryParse(GiderTutar.Text,out gider))
                {
                    MessageBox.Show("Lutfen gecerli bir gider tutari giriniz");
                    return;
                }

                string insertQuery = @"
            INSERT INTO Gider (GiderNedeni, GiderTutari)
            VALUES (@GiderNedeni, @GiderTutari)";


                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand insertCmd = new SqlCommand(insertQuery, conn))
                    {
                    insertCmd.Parameters.AddWithValue("@GiderNedeni", giderSebebi);
                    insertCmd.Parameters.AddWithValue("@GiderTutari", gider);

                    try
                    {
                        conn.Open();
                        insertCmd.ExecuteNonQuery();
                        MessageBox.Show("Gider Basariyla Kaydedildi");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally { conn.Close(); }
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

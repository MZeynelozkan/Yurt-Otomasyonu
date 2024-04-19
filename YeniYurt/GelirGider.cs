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
    public partial class GelirGider : Form
    {
        Connection connection = new Connection();
        public GelirGider()
        {
            InitializeComponent();
        }

        private void GelirBtn_Click(object sender, EventArgs e)
        {
            string connectionString = connection.connectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"SELECT * FROM Gelir";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                dataGridView1.DataSource = dataTable;

            }
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = connection.connectionString;

            using(SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"SELECT * FROM Gider";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query,connection);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                dataGridView1.DataSource = dataTable;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ToplamNetGelirGiderBTN_Click(object sender, EventArgs e)
        {
            string connectionString = connection.connectionString;

            using(SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string GelirToplamSorgu = @"SELECT SUM(OdenenTutar) AS ToplamGelir FROM Gelir";
                SqlCommand GelirToplamCmd = new SqlCommand(GelirToplamSorgu, connection);
                string GiderToplamSorgu = @"SELECT SUM(GiderTutari) AS ToplamGider FROM Gider";
                SqlCommand GiderToplamCmd = new SqlCommand(GiderToplamSorgu, connection);

                try
                {
                    var toplamGelir = GelirToplamCmd.ExecuteScalar();
                    var toplamGider = GiderToplamCmd.ExecuteScalar();


                    decimal toplamGelirr = (toplamGelir != DBNull.Value) ? Convert.ToDecimal(toplamGelir) : 0;
                    decimal toplamGiderr = (toplamGider != DBNull.Value) ? Convert.ToDecimal(toplamGider) : 0;


                    decimal netHasilat = toplamGelirr - toplamGiderr;

                    MessageBox.Show("Net Hasılat: " + netHasilat);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void BackBTN_Click(object sender, EventArgs e)
        {
            this.Hide();
            YoneticiEkran yoneticiEkran = new YoneticiEkran();
            yoneticiEkran.Show();
        }

        private void GiderSil_Click(object sender, EventArgs e)
        {
            GiderSil giderSil = new GiderSil();
            giderSil.Show();
        }
    }
}

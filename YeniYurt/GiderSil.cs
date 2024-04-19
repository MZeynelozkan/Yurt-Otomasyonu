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

    public partial class GiderSil : Form
    {
        Connection connection = new Connection();
        public GiderSil()
        {
            InitializeComponent();
        }

        private void BackBTN_Click(object sender, EventArgs e)
        {
            this.Hide();

        }

        private void GiderID_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(GiderID.Text, out int giderID))
            {
                GiderDetaylari(giderID);
            }
        }

        private void GiderDetaylari(int giderId)
        {
            string connectionString = connection.connectionString;
            SqlConnection conn = null;

            try
            {
                conn = new SqlConnection(connectionString);
                conn.Open();

                string query = @"SELECT GiderTutari FROM Gider WHERE GiderID = @GiderID";
                using (SqlCommand Command = new SqlCommand(query, conn))
                {
                    Command.Parameters.AddWithValue("@GiderID", giderId);
                    using (SqlDataReader reader = Command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            GiderTutar.Text = reader["GiderTutari"].ToString();
                        }
                        else
                        {
                            GiderTutar.Text = "";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                
                MessageBox.Show("Bir hata oluştu: " + ex.Message);
            }
            finally
            {
               
                if (conn != null)
                {
                    conn.Close(); // Bağlantıyı burada kapatıyoruz.
                }
            }
        }

        private void SilBTN_Click(object sender, EventArgs e)
        {
            if(!int.TryParse(GiderID.Text, out int giderID))
            {
                MessageBox.Show(("Lütfen geçerli bir Gider ID giriniz."));
                return;
            }
            
            string connectionString = connection.connectionString;
            string query = @"DELETE FROM Gider WHERE GiderID = @GiderID";
            
            using(SqlConnection conn = new SqlConnection(connectionString))
            {
                using(SqlCommand Command = new SqlCommand(query, conn))
                {
                    Command.Parameters.AddWithValue("@GiderID", giderID);
                    try
                    {
                        conn.Open();
                        int result = Command.ExecuteNonQuery();

                        if(result > 0)
                        {
                            MessageBox.Show("Gider Basariyla Silindi");
                        }
                        else
                        {
                            MessageBox.Show("Silinecek gider bulunamadı.");

                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Bir hata oluştu: " + ex.Message);

                       
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
               
            }
            

        }
    }
}

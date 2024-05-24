using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace OtelOtomasyon
{
    public partial class RoomCheckoutForm : Form
    {
        public RoomCheckoutForm()
        {
            InitializeComponent();
        }

        private void buttonOdaBosalt_Click(object sender, EventArgs e)
        {
            // SQL bağlantısı kodunu buraya ekleyin
            string connectionString = "CONNECTION_STRING";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string selectQuery = "SELECT ToplamTutar FROM OdaKayit WHERE MusteriTC = @MusteriTC";
                using (SqlCommand cmd = new SqlCommand(selectQuery, con))
                {
                    cmd.Parameters.AddWithValue("@MusteriTC", textBoxMusteriTC.Text);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        textBoxToplamTutar.Text = reader["ToplamTutar"].ToString();
                    }
                    reader.Close();
                }

                string deleteQuery = "DELETE FROM OdaKayit WHERE MusteriTC = @MusteriTC";
                using (SqlCommand cmd = new SqlCommand(deleteQuery, con))
                {
                    cmd.Parameters.AddWithValue("@MusteriTC", textBoxMusteriTC.Text);
                    cmd.ExecuteNonQuery();
                }
                con.Close();
            }
            MessageBox.Show("Oda boşaltma işlemi tamamlandı.");
        }
    }
}

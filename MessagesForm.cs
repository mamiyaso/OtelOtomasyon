using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace OtelOtomasyon
{
    public partial class MessagesForm : Form
    {
        public MessagesForm()
        {
            InitializeComponent();
        }

        private void buttonMesajGonder_Click(object sender, EventArgs e)
        {
            string connectionString = "CONNECTION_STRING";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string insertQuery = "INSERT INTO Mesajlar (MusteriTC, Mesaj) VALUES (@MusteriTC, @Mesaj)";
                using (SqlCommand cmd = new SqlCommand(insertQuery, con))
                {
                    cmd.Parameters.AddWithValue("@MusteriTC", textBoxMusteriTC.Text);
                    cmd.Parameters.AddWithValue("@Mesaj", textBoxMesaj.Text);
                    cmd.ExecuteNonQuery();
                }
                con.Close();
            }
            MessageBox.Show("Mesaj başarıyla gönderildi.");
        }
    }
}

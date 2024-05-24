using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace OtelOtomasyon
{
    public partial class CustomerForm : Form
    {
        public CustomerForm()
        {
            InitializeComponent();
        }

        private void buttonEkle_Click(object sender, EventArgs e)
        {
            string connectionString = "CONNECTION_STRING";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = "INSERT INTO Musteri (MusteriTC, MusteriAd, MusteriSoyad, MusteriCinsiyet, MusteriYas, MusteriTel, MusteriAdres) " +
                               "VALUES (@MusteriTC, @MusteriAd, @MusteriSoyad, @MusteriCinsiyet, @MusteriYas, @MusteriTel, @MusteriAdres)";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@MusteriTC", textBoxMusteriTC.Text);
                    cmd.Parameters.AddWithValue("@MusteriAd", textBoxMusteriAd.Text);
                    cmd.Parameters.AddWithValue("@MusteriSoyad", textBoxMusteriSoyad.Text);
                    cmd.Parameters.AddWithValue("@MusteriCinsiyet", textBoxMusteriCinsiyet.Text);
                    cmd.Parameters.AddWithValue("@MusteriYas", textBoxMusteriYas.Text);
                    cmd.Parameters.AddWithValue("@MusteriTel", textBoxMusteriTel.Text);
                    cmd.Parameters.AddWithValue("@MusteriAdres", textBoxMusteriAdres.Text);
                    cmd.ExecuteNonQuery();
                }
                con.Close();
            }
        }

        private void buttonGuncelle_Click(object sender, EventArgs e)
        {
            string connectionString = "CONNECTION_STRING";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = "UPDATE Musteri SET MusteriAd = @MusteriAd, MusteriSoyad = @MusteriSoyad, MusteriCinsiyet = @MusteriCinsiyet, " +
                               "MusteriYas = @MusteriYas, MusteriTel = @MusteriTel, MusteriAdres = @MusteriAdres WHERE MusteriTC = @MusteriTC";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@MusteriTC", textBoxMusteriTC.Text);
                    cmd.Parameters.AddWithValue("@MusteriAd", textBoxMusteriAd.Text);
                    cmd.Parameters.AddWithValue("@MusteriSoyad", textBoxMusteriSoyad.Text);
                    cmd.Parameters.AddWithValue("@MusteriCinsiyet", textBoxMusteriCinsiyet.Text);
                    cmd.Parameters.AddWithValue("@MusteriYas", textBoxMusteriYas.Text);
                    cmd.Parameters.AddWithValue("@MusteriTel", textBoxMusteriTel.Text);
                    cmd.Parameters.AddWithValue("@MusteriAdres", textBoxMusteriAdres.Text);
                    cmd.ExecuteNonQuery();
                }
                con.Close();
            }
        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
            string connectionString = "CONNECTION_STRING";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = "DELETE FROM Musteri WHERE MusteriTC = @MusteriTC";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@MusteriTC", textBoxMusteriTC.Text);
                    cmd.ExecuteNonQuery();
                }
                con.Close();
            }
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {

        }
    }
}

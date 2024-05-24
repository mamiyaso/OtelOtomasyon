using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace OtelOtomasyon
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void buttonGiris_Click(object sender, EventArgs e)
        {
            string connectionString = "CONNECTION_STRING";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = "SELECT COUNT(*) FROM Kullanicilar WHERE KullaniciAdi = @KullaniciAdi AND Parola = @Parola";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@KullaniciAdi", textBoxKullaniciAdi.Text);
                    cmd.Parameters.AddWithValue("@Parola", textBoxParola.Text);
                    int userCount = (int)cmd.ExecuteScalar();
                    if (userCount > 0)
                    {
                        MainForm mainForm = new MainForm();
                        mainForm.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Geçersiz kullanıcı adı veya parola.");
                    }
                }
                con.Close();
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}

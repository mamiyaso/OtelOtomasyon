using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace OtelOtomasyon
{
    public partial class RoomStatusForm : Form
    {
        public RoomStatusForm()
        {
            InitializeComponent();
        }

        private void RoomStatusForm_Load(object sender, EventArgs e)
        {
            string connectionString = "CONNECTION_STRING";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = "SELECT MusteriTC, GirisTarihi, CikisTarihi, YemekDahil, ToplamTutar FROM OdaKayit";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridViewOdaDurum.DataSource = dt;
                }
                con.Close();
            }
        }
    }
}

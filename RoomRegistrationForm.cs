using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace OtelOtomasyon
{
    public partial class RoomRegistrationForm : Form
    {
        public RoomRegistrationForm()
        {
            InitializeComponent();
        }

        private void buttonKaydet_Click(object sender, EventArgs e)
        {
            string connectionString = "CONNECTION_STRING";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = "INSERT INTO OdaKayit (MusteriTC, GirisTarihi, CikisTarihi, YemekDahil, ToplamTutar) " +
                               "VALUES (@MusteriTC, @GirisTarihi, @CikisTarihi, @YemekDahil, @ToplamTutar)";

                // Gün sayısını hesapla
                TimeSpan fark = dateTimePickerCikis.Value - dateTimePickerGiris.Value;
                int gunSayisi = fark.Days;
                int gunlukUcret = 1000;
                int yemekUcreti = checkBoxYemekDahil.Checked ? 250 : 0;
                int toplamUcret = (gunSayisi * gunlukUcret) + (gunSayisi * yemekUcreti);

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@MusteriTC", textBoxMusteriTC.Text);
                    cmd.Parameters.AddWithValue("@GirisTarihi", dateTimePickerGiris.Value);
                    cmd.Parameters.AddWithValue("@CikisTarihi", dateTimePickerCikis.Value);
                    cmd.Parameters.AddWithValue("@YemekDahil", checkBoxYemekDahil.Checked);
                    cmd.Parameters.AddWithValue("@ToplamTutar", toplamUcret);
                    cmd.ExecuteNonQuery();
                }
                con.Close();
            }
        }
    }
}

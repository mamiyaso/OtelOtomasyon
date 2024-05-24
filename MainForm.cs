using System;
using System.Windows.Forms;

namespace OtelOtomasyon
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonMusteriKayit_Click(object sender, EventArgs e)
        {
            CustomerForm customerForm = new CustomerForm();
            customerForm.Show();
        }

        private void buttonOdaKayit_Click(object sender, EventArgs e)
        {
            RoomRegistrationForm roomRegistrationForm = new RoomRegistrationForm();
            roomRegistrationForm.Show();
        }

        private void buttonOdaDurum_Click(object sender, EventArgs e)
        {
            RoomStatusForm roomStatusForm = new RoomStatusForm();
            roomStatusForm.Show();
        }

        private void buttonOdaBosalt_Click(object sender, EventArgs e)
        {
            RoomCheckoutForm roomCheckoutForm = new RoomCheckoutForm();
            roomCheckoutForm.Show();
        }

        private void buttonMusteriHareket_Click(object sender, EventArgs e)
        {
            CustomerActivityForm customerActivityForm = new CustomerActivityForm();
            customerActivityForm.Show();
        }

        private void buttonMesajlar_Click(object sender, EventArgs e)
        {
            MessagesForm messagesForm = new MessagesForm();
            messagesForm.Show();
        }
    }
}

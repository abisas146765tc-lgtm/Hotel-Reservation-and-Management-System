using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Reservation_and_Management_System
{
    public partial class Manager_Dashboard : Form
    {
        public Manager_Dashboard()
        {
            InitializeComponent();
        }

        private void btnRateManagement_Click(object sender, EventArgs e)
        {
            var rateForm = new RateManagement();
            rateForm.ShowDialog();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            var reportsForm = new Reports();
            reportsForm.ShowDialog();
        }

        private void btnNewReservation_Click(object sender, EventArgs e)
        {
            var newResForm = new NewReservation();
            newResForm.ShowDialog();
        }

        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            var checkInForm = new CheckIn();
            checkInForm.ShowDialog();
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            var checkOutForm = new CheckOut();
            checkOutForm.ShowDialog();
        }

        private void btnSearchReservation_Click(object sender, EventArgs e)
        {
            var searchResForm = new SearchReservation();
            searchResForm.ShowDialog();
        }

        private void btnGuestRecords_Click(object sender, EventArgs e)
        {
            var guestRecordsForm = new GuestRecords();
            guestRecordsForm.ShowDialog();
        }

        private void btnBilling_Click(object sender, EventArgs e)
        {
            var billingForm = new Billing();
            billingForm.ShowDialog();
        }

        private void Manager_Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void btnRoomManagement_Click(object sender, EventArgs e)
        {
            var roomForm = new RoomManagement();
            roomForm.ShowDialog();
        }

        private void btnUserManagement_Click(object sender, EventArgs e)
        {
            var userForm = new UserManagement();
            userForm.ShowDialog();
        }
    }
}

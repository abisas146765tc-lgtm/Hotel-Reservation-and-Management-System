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
    public partial class Receptionist_Dashboard : Form
    {
        public Receptionist_Dashboard()
        {
            InitializeComponent();
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

        private void btnManageReservation_Click(object sender, EventArgs e)
        {
            var searchResForm = new SearchReservation();
            searchResForm.ShowDialog();
        }

        private void btnGuestRecord_Click(object sender, EventArgs e)
        {
            var guestRecordsForm = new GuestRecords();
            guestRecordsForm.ShowDialog();
        }
    }
}

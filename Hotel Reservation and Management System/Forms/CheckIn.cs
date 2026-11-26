using System;
using System.Drawing;
using System.Windows.Forms;

namespace Hotel_Reservation_and_Management_System
{
    public partial class CheckIn : Form
    {
        public CheckIn()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MinimumSize = new Size(1050, 650);
        }

        private void CheckIn_Load(object sender, EventArgs e)
        {

        }

        private void btnCheckIn_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvArrivals_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

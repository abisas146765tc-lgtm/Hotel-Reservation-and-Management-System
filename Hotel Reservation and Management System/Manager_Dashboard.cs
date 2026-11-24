using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
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

            // Frosted glass + rounded corners on the main card
            pnlDashboardCard.BackColor = Color.FromArgb(45, 255, 255, 255);
            RoundControl(pnlDashboardCard, 30);

            // Round all 6 current buttons
            RoundControl(btnNewReservation, 16);
            RoundControl(btnCheckin, 16);
            RoundControl(btnCheckout, 16);
            RoundControl(btnSearchReservation, 16);
            RoundControl(btnGuestRecords, 16);
            RoundControl(btnBilling, 16);

            RoundControl(btnRoomManagement, 16);
            RoundControl(btnUserManagement, 16);
            RoundControl(btnRateManagement, 16);
            RoundControl(btnReports, 16);


            // Center immediately on startup
            Manager_Dashboard_Resize(null, null);
        }
        private void RoundControl(Control control, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(control.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(control.Width - radius, control.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, control.Height - radius, radius, radius, 90, 90);
            path.CloseAllFigures();
            control.Region = new Region(path);
        }

        private void Manager_Dashboard_Resize(object sender, EventArgs e)
        {
            pnlDashboardCard.Left = (this.ClientSize.Width - pnlDashboardCard.Width) / 2;
            int centerY = (this.ClientSize.Height - pnlDashboardCard.Height) / 2 + 30;
            pnlDashboardCard.Top = Math.Max(120, centerY);
        }
    }
}
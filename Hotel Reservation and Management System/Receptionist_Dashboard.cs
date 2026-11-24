using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Hotel_Reservation_and_Management_System
{
    public partial class Receptionist_Dashboard : Form
    {
        public Receptionist_Dashboard()
        {
            InitializeComponent();

            // Frosted glass card + rounded corners
            pnlDashboardCardReceptionist.BackColor = Color.FromArgb(45, 255, 255, 255);
            RoundControl(pnlDashboardCardReceptionist, 30);

            // Round the 5 Receptionist buttons
            Button[] dashButtons = {
            btnNewReservationReceptionist, btnCheckinReceptionist, btnCheckoutReceptionist, btnSearchReservationManageReceptionist, btnGuestRecordsReceptionist
    };

            foreach (Button btn in dashButtons)
            {
                RoundControl(btn, 16);
            }

            this.Resize += Receptionist_Dashboard_Resize;
            Receptionist_Dashboard_Resize(null, null);
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

        private void Receptionist_Dashboard_Resize(object sender, EventArgs e)
        {
            pnlDashboardCardReceptionist.Left = (this.ClientSize.Width - pnlDashboardCardReceptionist.Width) / 2;
            int centerY = (this.ClientSize.Height - pnlDashboardCardReceptionist.Height) / 2 + 30;
            pnlDashboardCardReceptionist.Top = Math.Max(120, centerY);
        }

        private void Receptionist_Dashboard_Load(object sender, EventArgs e)
        {

        }
    }
}

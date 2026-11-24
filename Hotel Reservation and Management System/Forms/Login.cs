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
using Hotel_Reservation_and_Management_System.Data;

namespace Hotel_Reservation_and_Management_System
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            pnlTitle.BackColor = Color.FromArgb(40, 255, 255, 255);
            RoundControl(pnlTitle, 30);
            frmLogin_Resize(null, null);

            this.ActiveControl = null;
            RoundControl(btnLogin, 18);
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


        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void lblHome_MouseEnter(object sender, EventArgs e)
        {
            if (sender is Label lbl)
            {
                lbl.ForeColor = Color.FromArgb(166, 191, 212);
            }
        }

        private void lblHome_MouseLeave(object sender, EventArgs e)
        {
            if (sender is Label lbl)
            {
                lbl.ForeColor = Color.White;
            }
        }


        private void frmLogin_Resize(object sender, EventArgs e)
        {
            pnlTitle.Left = (this.ClientSize.Width - pnlTitle.Width) / 2;
            int centerY = (this.ClientSize.Height - pnlTitle.Height) / 2 + 30;
            pnlTitle.Top = Math.Max(120, centerY); // Never overlaps the STAYSYNC header
        }

        private void frmLogin_Shown(object sender, EventArgs e)
        {

        }

        private void txtUsername_Enter(object sender, EventArgs e)
        {

        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {

        }

        bool isPasswordVisible = false;
        private void lblEye_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Enter Password") return;

            isPasswordVisible = !isPasswordVisible;

            if (isPasswordVisible)
            {
                txtPassword.UseSystemPasswordChar = false;
                lblEye.ForeColor = Color.FromArgb(78, 84, 224);
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
                lblEye.ForeColor = Color.Gray;
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {

        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {

        }

        private void lblLogin_Click(object sender, EventArgs e)
        {

        }

        private void cmbRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.BeginInvoke(new Action(() => { this.ActiveControl = null; }));
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void lblTagline_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            if (username == "" || password == "")
            {
                MessageBox.Show("Please enter both username and password.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                var user = UserRepository.Authenticate(username, password);

                if (user == null)
                {
                    MessageBox.Show("Invalid username or password.");
                    txtPassword.Clear();
                    txtPassword.Focus();
                    return;
                }
                Form next = user.Role == "Manager" ? new Manager_Dashboard() : new Receptionist_Dashboard();
                next.FormClosed += (s, args) => Application.Exit();
                next.Show();
                this.Hide();
            }
            catch (Microsoft.Data.SqlClient.SqlException)
            {
                MessageBox.Show("Cannot connect to the database.");
            }
        }
    }
}
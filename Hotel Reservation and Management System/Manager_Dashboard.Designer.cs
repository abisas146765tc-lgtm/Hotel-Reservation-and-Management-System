namespace Hotel_Reservation_and_Management_System
{
    partial class Manager_Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            btnUserManagement = new Button();
            btnRoomManagement = new Button();
            btnReports = new Button();
            btnRateManagement = new Button();
            panel1 = new Panel();
            btnLogout = new Button();
            label2 = new Label();
            label3 = new Label();
            btnNewReservation = new Button();
            btnCheckIn = new Button();
            btnCheckOut = new Button();
            btnSearchReservation = new Button();
            btnGuestRecords = new Button();
            btnBilling = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(36, 27);
            label1.Name = "label1";
            label1.Size = new Size(157, 37);
            label1.TabIndex = 0;
            label1.Text = "Dashboard";
            // 
            // btnUserManagement
            // 
            btnUserManagement.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnUserManagement.BackColor = Color.FromArgb(31, 58, 95);
            btnUserManagement.Cursor = Cursors.Hand;
            btnUserManagement.FlatAppearance.BorderSize = 0;
            btnUserManagement.FlatStyle = FlatStyle.Flat;
            btnUserManagement.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUserManagement.ForeColor = Color.White;
            btnUserManagement.Image = Properties.Resources.user_management;
            btnUserManagement.Location = new Point(469, 405);
            btnUserManagement.Name = "btnUserManagement";
            btnUserManagement.Size = new Size(181, 109);
            btnUserManagement.TabIndex = 1;
            btnUserManagement.Text = "User Management";
            btnUserManagement.TextImageRelation = TextImageRelation.ImageAboveText;
            btnUserManagement.UseVisualStyleBackColor = false;
            // 
            // btnRoomManagement
            // 
            btnRoomManagement.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnRoomManagement.BackColor = Color.FromArgb(31, 58, 95);
            btnRoomManagement.Cursor = Cursors.Hand;
            btnRoomManagement.FlatAppearance.BorderSize = 0;
            btnRoomManagement.FlatStyle = FlatStyle.Flat;
            btnRoomManagement.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRoomManagement.ForeColor = Color.White;
            btnRoomManagement.Image = Properties.Resources.room_management;
            btnRoomManagement.Location = new Point(12, 405);
            btnRoomManagement.Name = "btnRoomManagement";
            btnRoomManagement.Size = new Size(181, 109);
            btnRoomManagement.TabIndex = 2;
            btnRoomManagement.Text = "Room Management";
            btnRoomManagement.TextImageRelation = TextImageRelation.ImageAboveText;
            btnRoomManagement.UseVisualStyleBackColor = false;
            // 
            // btnReports
            // 
            btnReports.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnReports.BackColor = Color.FromArgb(31, 58, 95);
            btnReports.Cursor = Cursors.Hand;
            btnReports.FlatAppearance.BorderSize = 0;
            btnReports.FlatStyle = FlatStyle.Flat;
            btnReports.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReports.ForeColor = Color.White;
            btnReports.Image = Properties.Resources.reports;
            btnReports.Location = new Point(697, 405);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(181, 109);
            btnReports.TabIndex = 3;
            btnReports.Text = "Reports";
            btnReports.TextImageRelation = TextImageRelation.ImageAboveText;
            btnReports.UseVisualStyleBackColor = false;
            // 
            // btnRateManagement
            // 
            btnRateManagement.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnRateManagement.BackColor = Color.FromArgb(31, 58, 95);
            btnRateManagement.BackgroundImageLayout = ImageLayout.None;
            btnRateManagement.Cursor = Cursors.Hand;
            btnRateManagement.FlatAppearance.BorderSize = 0;
            btnRateManagement.FlatStyle = FlatStyle.Flat;
            btnRateManagement.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRateManagement.ForeColor = Color.White;
            btnRateManagement.Image = Properties.Resources.rate_management;
            btnRateManagement.Location = new Point(242, 405);
            btnRateManagement.Name = "btnRateManagement";
            btnRateManagement.Size = new Size(181, 109);
            btnRateManagement.TabIndex = 4;
            btnRateManagement.Text = "Rate Management";
            btnRateManagement.TextImageRelation = TextImageRelation.ImageAboveText;
            btnRateManagement.UseVisualStyleBackColor = false;
            btnRateManagement.Click += btnRateManagement_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(31, 58, 95);
            panel1.Controls.Add(btnLogout);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1134, 99);
            panel1.TabIndex = 5;
            // 
            // btnLogout
            // 
            btnLogout.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnLogout.BackColor = Color.FromArgb(31, 58, 95);
            btnLogout.Cursor = Cursors.Hand;
            btnLogout.FlatAppearance.BorderColor = Color.White;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = SystemColors.Control;
            btnLogout.Image = Properties.Resources.check_out;
            btnLogout.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogout.Location = new Point(759, 26);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(92, 38);
            btnLogout.TabIndex = 1;
            btnLogout.Text = "Logout";
            btnLogout.TextAlign = ContentAlignment.MiddleRight;
            btnLogout.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(64, 64, 64);
            label2.Location = new Point(12, 367);
            label2.Name = "label2";
            label2.Size = new Size(113, 21);
            label2.TabIndex = 6;
            label2.Text = "Administration";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(64, 64, 64);
            label3.Location = new Point(12, 104);
            label3.Name = "label3";
            label3.Size = new Size(159, 21);
            label3.TabIndex = 7;
            label3.Text = "Front Desk Operation";
            // 
            // btnNewReservation
            // 
            btnNewReservation.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnNewReservation.BackColor = Color.FromArgb(42, 157, 143);
            btnNewReservation.Cursor = Cursors.Hand;
            btnNewReservation.FlatAppearance.BorderSize = 0;
            btnNewReservation.FlatStyle = FlatStyle.Flat;
            btnNewReservation.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNewReservation.ForeColor = Color.White;
            btnNewReservation.Image = Properties.Resources.new_reservation;
            btnNewReservation.Location = new Point(12, 128);
            btnNewReservation.Name = "btnNewReservation";
            btnNewReservation.Size = new Size(254, 109);
            btnNewReservation.TabIndex = 8;
            btnNewReservation.Text = "New Reservation";
            btnNewReservation.TextImageRelation = TextImageRelation.ImageAboveText;
            btnNewReservation.UseVisualStyleBackColor = false;
            // 
            // btnCheckIn
            // 
            btnCheckIn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCheckIn.BackColor = Color.FromArgb(42, 157, 143);
            btnCheckIn.Cursor = Cursors.Hand;
            btnCheckIn.FlatAppearance.BorderSize = 0;
            btnCheckIn.FlatStyle = FlatStyle.Flat;
            btnCheckIn.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCheckIn.ForeColor = Color.White;
            btnCheckIn.Image = Properties.Resources.check_in;
            btnCheckIn.Location = new Point(318, 128);
            btnCheckIn.Name = "btnCheckIn";
            btnCheckIn.Size = new Size(254, 109);
            btnCheckIn.TabIndex = 9;
            btnCheckIn.Text = "Check-In";
            btnCheckIn.TextImageRelation = TextImageRelation.ImageAboveText;
            btnCheckIn.UseVisualStyleBackColor = false;
            // 
            // btnCheckOut
            // 
            btnCheckOut.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCheckOut.BackColor = Color.FromArgb(42, 157, 143);
            btnCheckOut.Cursor = Cursors.Hand;
            btnCheckOut.FlatAppearance.BorderSize = 0;
            btnCheckOut.FlatStyle = FlatStyle.Flat;
            btnCheckOut.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCheckOut.ForeColor = Color.White;
            btnCheckOut.Image = Properties.Resources.check_out1;
            btnCheckOut.Location = new Point(624, 128);
            btnCheckOut.Name = "btnCheckOut";
            btnCheckOut.Size = new Size(254, 109);
            btnCheckOut.TabIndex = 10;
            btnCheckOut.Text = "Check-Out";
            btnCheckOut.TextImageRelation = TextImageRelation.ImageAboveText;
            btnCheckOut.UseVisualStyleBackColor = false;
            // 
            // btnSearchReservation
            // 
            btnSearchReservation.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSearchReservation.BackColor = Color.FromArgb(42, 157, 143);
            btnSearchReservation.Cursor = Cursors.Hand;
            btnSearchReservation.FlatAppearance.BorderSize = 0;
            btnSearchReservation.FlatStyle = FlatStyle.Flat;
            btnSearchReservation.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearchReservation.ForeColor = Color.White;
            btnSearchReservation.Image = Properties.Resources.search_reservations;
            btnSearchReservation.Location = new Point(12, 255);
            btnSearchReservation.Name = "btnSearchReservation";
            btnSearchReservation.Size = new Size(254, 109);
            btnSearchReservation.TabIndex = 11;
            btnSearchReservation.Text = "Search Reservation";
            btnSearchReservation.TextImageRelation = TextImageRelation.ImageAboveText;
            btnSearchReservation.UseVisualStyleBackColor = false;
            // 
            // btnGuestRecords
            // 
            btnGuestRecords.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGuestRecords.BackColor = Color.FromArgb(42, 157, 143);
            btnGuestRecords.Cursor = Cursors.Hand;
            btnGuestRecords.FlatAppearance.BorderSize = 0;
            btnGuestRecords.FlatStyle = FlatStyle.Flat;
            btnGuestRecords.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuestRecords.ForeColor = Color.White;
            btnGuestRecords.Image = Properties.Resources.guest_records;
            btnGuestRecords.Location = new Point(318, 255);
            btnGuestRecords.Name = "btnGuestRecords";
            btnGuestRecords.Size = new Size(254, 109);
            btnGuestRecords.TabIndex = 12;
            btnGuestRecords.Text = "Guest Records";
            btnGuestRecords.TextImageRelation = TextImageRelation.ImageAboveText;
            btnGuestRecords.UseVisualStyleBackColor = false;
            // 
            // btnBilling
            // 
            btnBilling.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnBilling.BackColor = Color.FromArgb(42, 157, 143);
            btnBilling.Cursor = Cursors.Hand;
            btnBilling.FlatAppearance.BorderSize = 0;
            btnBilling.FlatStyle = FlatStyle.Flat;
            btnBilling.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBilling.ForeColor = Color.White;
            btnBilling.Image = Properties.Resources.billing;
            btnBilling.Location = new Point(624, 255);
            btnBilling.Name = "btnBilling";
            btnBilling.Size = new Size(254, 109);
            btnBilling.TabIndex = 13;
            btnBilling.Text = "Billing";
            btnBilling.TextImageRelation = TextImageRelation.ImageAboveText;
            btnBilling.UseVisualStyleBackColor = false;
            // 
            // Manager_Dashboard
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(890, 526);
            Controls.Add(btnBilling);
            Controls.Add(btnGuestRecords);
            Controls.Add(btnSearchReservation);
            Controls.Add(btnCheckOut);
            Controls.Add(btnCheckIn);
            Controls.Add(btnNewReservation);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(btnRateManagement);
            Controls.Add(btnReports);
            Controls.Add(btnRoomManagement);
            Controls.Add(btnUserManagement);
            Name = "Manager_Dashboard";
            Text = "Manager Dashboard";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnUserManagement;
        private Button btnRoomManagement;
        private Button btnReports;
        private Button btnRateManagement;
        private Panel panel1;
        private Button btnLogout;
        private Label label2;
        private Label label3;
        private Button btnNewReservation;
        private Button btnCheckIn;
        private Button btnCheckOut;
        private Button btnSearchReservation;
        private Button btnGuestRecords;
        private Button btnBilling;
    }
}
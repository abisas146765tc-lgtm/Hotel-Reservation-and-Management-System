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
            btnRateManagement = new Button();
            Header = new Panel();
            btnLogout = new Button();
            label3 = new Label();
            Receptionist = new Panel();
            tlpFront = new TableLayoutPanel();
            btnSearchReservation = new Button();
            btnCheckOut = new Button();
            btnCheckIn = new Button();
            btnNewReservation = new Button();
            btnGuestRecords = new Button();
            btnBilling = new Button();
            Administration = new Panel();
            tblAdmin = new TableLayoutPanel();
            btnReports = new Button();
            btnUserManagement = new Button();
            btnRoomManagement = new Button();
            label2 = new Label();
            pnlAdminControl = new Panel();
            pnlFrontDeskOperation = new Panel();
            Header.SuspendLayout();
            Receptionist.SuspendLayout();
            tlpFront.SuspendLayout();
            Administration.SuspendLayout();
            tblAdmin.SuspendLayout();
            pnlAdminControl.SuspendLayout();
            pnlFrontDeskOperation.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(24, 31);
            label1.Name = "label1";
            label1.Size = new Size(157, 37);
            label1.TabIndex = 0;
            label1.Text = "Dashboard";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // btnRateManagement
            // 
            btnRateManagement.BackColor = Color.FromArgb(31, 58, 95);
            btnRateManagement.BackgroundImageLayout = ImageLayout.None;
            btnRateManagement.Cursor = Cursors.Hand;
            btnRateManagement.Dock = DockStyle.Fill;
            btnRateManagement.FlatAppearance.BorderSize = 0;
            btnRateManagement.FlatStyle = FlatStyle.Flat;
            btnRateManagement.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRateManagement.ForeColor = Color.White;
            btnRateManagement.Image = Properties.Resources.rate_management;
            btnRateManagement.Location = new Point(466, 30);
            btnRateManagement.Margin = new Padding(22, 30, 22, 30);
            btnRateManagement.Name = "btnRateManagement";
            btnRateManagement.Size = new Size(178, 100);
            btnRateManagement.TabIndex = 4;
            btnRateManagement.Text = "Rate Management";
            btnRateManagement.TextImageRelation = TextImageRelation.ImageAboveText;
            btnRateManagement.UseVisualStyleBackColor = false;
            btnRateManagement.Click += btnRateManagement_Click;
            // 
            // Header
            // 
            Header.BackColor = Color.FromArgb(31, 58, 95);
            Header.Controls.Add(label1);
            Header.Controls.Add(btnLogout);
            Header.Dock = DockStyle.Top;
            Header.Location = new Point(0, 0);
            Header.Name = "Header";
            Header.Size = new Size(890, 99);
            Header.TabIndex = 5;
            // 
            // btnLogout
            // 
            btnLogout.Anchor = AnchorStyles.Right;
            btnLogout.BackColor = Color.FromArgb(31, 58, 95);
            btnLogout.Cursor = Cursors.Hand;
            btnLogout.FlatAppearance.BorderColor = Color.White;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = SystemColors.Control;
            btnLogout.Image = Properties.Resources.check_out;
            btnLogout.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogout.Location = new Point(766, 30);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(100, 38);
            btnLogout.TabIndex = 1;
            btnLogout.Text = "Logout";
            btnLogout.TextAlign = ContentAlignment.MiddleRight;
            btnLogout.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(64, 64, 64);
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(159, 21);
            label3.TabIndex = 7;
            label3.Text = "Front Desk Operation";
            // 
            // Receptionist
            // 
            Receptionist.Controls.Add(tlpFront);
            Receptionist.Dock = DockStyle.Fill;
            Receptionist.Location = new Point(0, 126);
            Receptionist.Name = "Receptionist";
            Receptionist.Size = new Size(890, 272);
            Receptionist.TabIndex = 14;
            // 
            // tlpFront
            // 
            tlpFront.ColumnCount = 3;
            tlpFront.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tlpFront.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tlpFront.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tlpFront.Controls.Add(btnSearchReservation, 0, 1);
            tlpFront.Controls.Add(btnCheckOut, 2, 0);
            tlpFront.Controls.Add(btnCheckIn, 1, 0);
            tlpFront.Controls.Add(btnNewReservation, 0, 0);
            tlpFront.Controls.Add(btnGuestRecords, 1, 1);
            tlpFront.Controls.Add(btnBilling, 2, 1);
            tlpFront.Dock = DockStyle.Fill;
            tlpFront.Location = new Point(0, 0);
            tlpFront.Name = "tlpFront";
            tlpFront.RowCount = 2;
            tlpFront.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpFront.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpFront.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpFront.Size = new Size(890, 272);
            tlpFront.TabIndex = 14;
            // 
            // btnSearchReservation
            // 
            btnSearchReservation.BackColor = Color.FromArgb(42, 157, 143);
            btnSearchReservation.Cursor = Cursors.Hand;
            btnSearchReservation.Dock = DockStyle.Fill;
            btnSearchReservation.FlatAppearance.BorderSize = 0;
            btnSearchReservation.FlatStyle = FlatStyle.Flat;
            btnSearchReservation.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearchReservation.ForeColor = Color.White;
            btnSearchReservation.Image = Properties.Resources.search_reservations;
            btnSearchReservation.Location = new Point(25, 161);
            btnSearchReservation.Margin = new Padding(25);
            btnSearchReservation.Name = "btnSearchReservation";
            btnSearchReservation.Size = new Size(246, 86);
            btnSearchReservation.TabIndex = 18;
            btnSearchReservation.Text = "Search Reservation";
            btnSearchReservation.TextImageRelation = TextImageRelation.ImageAboveText;
            btnSearchReservation.UseVisualStyleBackColor = false;
            // 
            // btnCheckOut
            // 
            btnCheckOut.BackColor = Color.FromArgb(42, 157, 143);
            btnCheckOut.Cursor = Cursors.Hand;
            btnCheckOut.Dock = DockStyle.Fill;
            btnCheckOut.FlatAppearance.BorderSize = 0;
            btnCheckOut.FlatStyle = FlatStyle.Flat;
            btnCheckOut.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCheckOut.ForeColor = Color.White;
            btnCheckOut.Image = Properties.Resources.check_out1;
            btnCheckOut.Location = new Point(617, 25);
            btnCheckOut.Margin = new Padding(25);
            btnCheckOut.Name = "btnCheckOut";
            btnCheckOut.Size = new Size(248, 86);
            btnCheckOut.TabIndex = 17;
            btnCheckOut.Text = "Check-Out";
            btnCheckOut.TextImageRelation = TextImageRelation.ImageAboveText;
            btnCheckOut.UseVisualStyleBackColor = false;
            // 
            // btnCheckIn
            // 
            btnCheckIn.BackColor = Color.FromArgb(42, 157, 143);
            btnCheckIn.Cursor = Cursors.Hand;
            btnCheckIn.Dock = DockStyle.Fill;
            btnCheckIn.FlatAppearance.BorderSize = 0;
            btnCheckIn.FlatStyle = FlatStyle.Flat;
            btnCheckIn.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCheckIn.ForeColor = Color.White;
            btnCheckIn.Image = Properties.Resources.check_in;
            btnCheckIn.Location = new Point(321, 25);
            btnCheckIn.Margin = new Padding(25);
            btnCheckIn.Name = "btnCheckIn";
            btnCheckIn.Size = new Size(246, 86);
            btnCheckIn.TabIndex = 16;
            btnCheckIn.Text = "Check-In";
            btnCheckIn.TextImageRelation = TextImageRelation.ImageAboveText;
            btnCheckIn.UseVisualStyleBackColor = false;
            // 
            // btnNewReservation
            // 
            btnNewReservation.BackColor = Color.FromArgb(42, 157, 143);
            btnNewReservation.Cursor = Cursors.Hand;
            btnNewReservation.Dock = DockStyle.Fill;
            btnNewReservation.FlatAppearance.BorderSize = 0;
            btnNewReservation.FlatStyle = FlatStyle.Flat;
            btnNewReservation.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNewReservation.ForeColor = Color.White;
            btnNewReservation.Image = Properties.Resources.new_reservation;
            btnNewReservation.Location = new Point(25, 25);
            btnNewReservation.Margin = new Padding(25);
            btnNewReservation.Name = "btnNewReservation";
            btnNewReservation.Size = new Size(246, 86);
            btnNewReservation.TabIndex = 15;
            btnNewReservation.Text = "New Reservation";
            btnNewReservation.TextImageRelation = TextImageRelation.ImageAboveText;
            btnNewReservation.UseVisualStyleBackColor = false;
            // 
            // btnGuestRecords
            // 
            btnGuestRecords.BackColor = Color.FromArgb(42, 157, 143);
            btnGuestRecords.Cursor = Cursors.Hand;
            btnGuestRecords.Dock = DockStyle.Fill;
            btnGuestRecords.FlatAppearance.BorderSize = 0;
            btnGuestRecords.FlatStyle = FlatStyle.Flat;
            btnGuestRecords.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuestRecords.ForeColor = Color.White;
            btnGuestRecords.Image = Properties.Resources.guest_records;
            btnGuestRecords.Location = new Point(321, 161);
            btnGuestRecords.Margin = new Padding(25);
            btnGuestRecords.Name = "btnGuestRecords";
            btnGuestRecords.Size = new Size(246, 86);
            btnGuestRecords.TabIndex = 12;
            btnGuestRecords.Text = "Guest Records";
            btnGuestRecords.TextImageRelation = TextImageRelation.ImageAboveText;
            btnGuestRecords.UseVisualStyleBackColor = false;
            // 
            // btnBilling
            // 
            btnBilling.BackColor = Color.FromArgb(42, 157, 143);
            btnBilling.Cursor = Cursors.Hand;
            btnBilling.Dock = DockStyle.Fill;
            btnBilling.FlatAppearance.BorderSize = 0;
            btnBilling.FlatStyle = FlatStyle.Flat;
            btnBilling.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBilling.ForeColor = Color.White;
            btnBilling.Image = Properties.Resources.billing;
            btnBilling.Location = new Point(617, 161);
            btnBilling.Margin = new Padding(25);
            btnBilling.Name = "btnBilling";
            btnBilling.Size = new Size(248, 86);
            btnBilling.TabIndex = 14;
            btnBilling.Text = "Billing";
            btnBilling.TextImageRelation = TextImageRelation.ImageAboveText;
            btnBilling.UseVisualStyleBackColor = false;
            // 
            // Administration
            // 
            Administration.Controls.Add(tblAdmin);
            Administration.Dock = DockStyle.Bottom;
            Administration.Location = new Point(0, 426);
            Administration.Name = "Administration";
            Administration.Size = new Size(890, 160);
            Administration.TabIndex = 15;
            // 
            // tblAdmin
            // 
            tblAdmin.ColumnCount = 4;
            tblAdmin.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblAdmin.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblAdmin.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblAdmin.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblAdmin.Controls.Add(btnRateManagement, 1, 0);
            tblAdmin.Controls.Add(btnReports, 3, 0);
            tblAdmin.Controls.Add(btnUserManagement, 1, 0);
            tblAdmin.Controls.Add(btnRoomManagement, 0, 0);
            tblAdmin.Dock = DockStyle.Fill;
            tblAdmin.Location = new Point(0, 0);
            tblAdmin.Name = "tblAdmin";
            tblAdmin.RowCount = 1;
            tblAdmin.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblAdmin.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblAdmin.Size = new Size(890, 160);
            tblAdmin.TabIndex = 7;
            // 
            // btnReports
            // 
            btnReports.BackColor = Color.FromArgb(31, 58, 95);
            btnReports.Cursor = Cursors.Hand;
            btnReports.Dock = DockStyle.Fill;
            btnReports.FlatAppearance.BorderSize = 0;
            btnReports.FlatStyle = FlatStyle.Flat;
            btnReports.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReports.ForeColor = Color.White;
            btnReports.Image = Properties.Resources.reports;
            btnReports.Location = new Point(688, 30);
            btnReports.Margin = new Padding(22, 30, 22, 30);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(180, 100);
            btnReports.TabIndex = 3;
            btnReports.Text = "Reports";
            btnReports.TextImageRelation = TextImageRelation.ImageAboveText;
            btnReports.UseVisualStyleBackColor = false;
            // 
            // btnUserManagement
            // 
            btnUserManagement.BackColor = Color.FromArgb(31, 58, 95);
            btnUserManagement.Cursor = Cursors.Hand;
            btnUserManagement.Dock = DockStyle.Fill;
            btnUserManagement.FlatAppearance.BorderSize = 0;
            btnUserManagement.FlatStyle = FlatStyle.Flat;
            btnUserManagement.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUserManagement.ForeColor = Color.White;
            btnUserManagement.Image = Properties.Resources.user_management;
            btnUserManagement.Location = new Point(244, 30);
            btnUserManagement.Margin = new Padding(22, 30, 22, 30);
            btnUserManagement.Name = "btnUserManagement";
            btnUserManagement.Size = new Size(178, 100);
            btnUserManagement.TabIndex = 1;
            btnUserManagement.Text = "User Management";
            btnUserManagement.TextImageRelation = TextImageRelation.ImageAboveText;
            btnUserManagement.UseVisualStyleBackColor = false;
            btnUserManagement.Click += btnUserManagement_Click;
            // 
            // btnRoomManagement
            // 
            btnRoomManagement.BackColor = Color.FromArgb(31, 58, 95);
            btnRoomManagement.Cursor = Cursors.Hand;
            btnRoomManagement.Dock = DockStyle.Fill;
            btnRoomManagement.FlatAppearance.BorderSize = 0;
            btnRoomManagement.FlatStyle = FlatStyle.Flat;
            btnRoomManagement.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRoomManagement.ForeColor = Color.White;
            btnRoomManagement.Image = Properties.Resources.room_management;
            btnRoomManagement.Location = new Point(22, 30);
            btnRoomManagement.Margin = new Padding(22, 30, 22, 30);
            btnRoomManagement.Name = "btnRoomManagement";
            btnRoomManagement.Size = new Size(178, 100);
            btnRoomManagement.TabIndex = 2;
            btnRoomManagement.Text = "Room Management";
            btnRoomManagement.TextImageRelation = TextImageRelation.ImageAboveText;
            btnRoomManagement.UseVisualStyleBackColor = false;
            btnRoomManagement.Click += btnRoomManagement_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(64, 64, 64);
            label2.Location = new Point(4, 4);
            label2.Name = "label2";
            label2.Size = new Size(113, 21);
            label2.TabIndex = 14;
            label2.Text = "Administration";
            label2.Click += label2_Click_1;
            // 
            // pnlAdminControl
            // 
            pnlAdminControl.Controls.Add(label2);
            pnlAdminControl.Dock = DockStyle.Bottom;
            pnlAdminControl.Location = new Point(0, 398);
            pnlAdminControl.Name = "pnlAdminControl";
            pnlAdminControl.Size = new Size(890, 28);
            pnlAdminControl.TabIndex = 16;
            // 
            // pnlFrontDeskOperation
            // 
            pnlFrontDeskOperation.Controls.Add(label3);
            pnlFrontDeskOperation.Dock = DockStyle.Top;
            pnlFrontDeskOperation.Location = new Point(0, 99);
            pnlFrontDeskOperation.Name = "pnlFrontDeskOperation";
            pnlFrontDeskOperation.Size = new Size(890, 27);
            pnlFrontDeskOperation.TabIndex = 17;
            // 
            // Manager_Dashboard
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(890, 586);
            Controls.Add(Receptionist);
            Controls.Add(pnlAdminControl);
            Controls.Add(Administration);
            Controls.Add(pnlFrontDeskOperation);
            Controls.Add(Header);
            Name = "Manager_Dashboard";
            Text = "Manager Dashboard";
            Load += Manager_Dashboard_Load;
            Header.ResumeLayout(false);
            Header.PerformLayout();
            Receptionist.ResumeLayout(false);
            tlpFront.ResumeLayout(false);
            Administration.ResumeLayout(false);
            tblAdmin.ResumeLayout(false);
            pnlAdminControl.ResumeLayout(false);
            pnlAdminControl.PerformLayout();
            pnlFrontDeskOperation.ResumeLayout(false);
            pnlFrontDeskOperation.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button btnRateManagement;
        private Panel Header;
        private Button btnLogout;
        private Label label3;
        private Panel Receptionist;
        private Panel Administration;
        private TableLayoutPanel tblAdmin;
        private Button btnReports;
        private Button btnRoomManagement;
        private Button btnUserManagement;
        private TableLayoutPanel tlpAdmin;
        private Label label2;
        private Panel pnlAdminControl;
        private Panel pnlFrontDeskOperation;
        private Button btnGuestRecords;
        private TableLayoutPanel tlpFront;
        private Button btnSearchReservation;
        private Button btnCheckOut;
        private Button btnCheckIn;
        private Button btnNewReservation;
        private Button btnBilling;
    }
}
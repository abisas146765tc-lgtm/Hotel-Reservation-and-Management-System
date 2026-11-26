namespace Hotel_Reservation_and_Management_System
{
    partial class CheckOut
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            DataGridViewCellStyle headerStyle = new DataGridViewCellStyle();
            DataGridViewCellStyle rowStyle = new DataGridViewCellStyle();
            DataGridViewCellStyle altRowStyle = new DataGridViewCellStyle();

            pnlHeader = new Panel();
            lblTitle = new Label();
            btnBack = new Button();
            pnlBody = new Panel();
            tlpMain = new TableLayoutPanel();

            pnlFormContainer = new Panel();
            lblFormTitle = new Label();
            pnlFormScroll = new Panel();
            pnlFormFields = new TableLayoutPanel();
            lblReservationId = new Label();
            txtReservationId = new TextBox();
            lblGuestName = new Label();
            txtGuestName = new TextBox();
            lblRoomNumber = new Label();
            txtRoomNumber = new TextBox();
            lblCheckInDate = new Label();
            txtCheckInDate = new TextBox();
            lblCheckOutDate = new Label();
            dtpCheckOutDate = new DateTimePicker();
            lblRoomCharges = new Label();
            txtRoomCharges = new TextBox();
            lblExtraCharges = new Label();
            txtExtraCharges = new TextBox();
            lblTotalDue = new Label();
            txtTotalDue = new TextBox();
            lblRoomCondition = new Label();
            cmbRoomCondition = new ComboBox();
            tlpButtons = new TableLayoutPanel();
            btnCheckOut = new Button();
            btnBilling = new Button();
            btnClear = new Button();

            pnlGridContainer = new Panel();
            lblGridTitle = new Label();
            pnlSearchBar = new Panel();
            lblSearchIcon = new Label();
            txtSearch = new TextBox();
            dgvCheckedIn = new DataGridView();
            colResId = new DataGridViewTextBoxColumn();
            colGuestName = new DataGridViewTextBoxColumn();
            colRoomNumber = new DataGridViewTextBoxColumn();
            colRoomType = new DataGridViewTextBoxColumn();
            colCheckInDate = new DataGridViewTextBoxColumn();
            colExpectedCheckOut = new DataGridViewTextBoxColumn();
            colBalance = new DataGridViewTextBoxColumn();
            colStatus = new DataGridViewTextBoxColumn();

            pnlHeader.SuspendLayout();
            pnlBody.SuspendLayout();
            tlpMain.SuspendLayout();
            pnlFormContainer.SuspendLayout();
            pnlFormScroll.SuspendLayout();
            pnlFormFields.SuspendLayout();
            tlpButtons.SuspendLayout();
            pnlGridContainer.SuspendLayout();
            pnlSearchBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCheckedIn).BeginInit();
            SuspendLayout();

            // ──────────── HEADER ────────────
            pnlHeader.BackColor = System.Drawing.Color.FromArgb(31, 58, 95);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Height = 70;
            pnlHeader.Padding = new Padding(24, 15, 24, 15);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Controls.Add(btnBack);

            lblTitle.Text = "Guest Check-Out";
            lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            lblTitle.ForeColor = System.Drawing.Color.White;
            lblTitle.Dock = DockStyle.Left;
            lblTitle.AutoSize = true;
            lblTitle.UseMnemonic = false;
            lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            btnBack.Text = "← Back";
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.FlatAppearance.BorderColor = System.Drawing.Color.White;
            btnBack.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            btnBack.ForeColor = System.Drawing.Color.White;
            btnBack.BackColor = System.Drawing.Color.FromArgb(31, 58, 95);
            btnBack.Cursor = Cursors.Hand;
            btnBack.Dock = DockStyle.Right;
            btnBack.Width = 105;
            btnBack.Click += btnBack_Click;

            // ──────────── BODY (50 / 50 CENTERED CARDS) ────────────
            pnlBody.Dock = DockStyle.Fill;
            pnlBody.BackColor = System.Drawing.Color.FromArgb(240, 243, 247);
            pnlBody.Padding = new Padding(24, 20, 24, 20);
            pnlBody.Controls.Add(tlpMain);

            tlpMain.Dock = DockStyle.Fill;
            tlpMain.ColumnCount = 2;
            tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tlpMain.RowCount = 1;
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpMain.Controls.Add(pnlFormContainer, 0, 0);
            tlpMain.Controls.Add(pnlGridContainer, 1, 0);

            // ═══════════ LEFT CARD — FORM (50%) ═══════════
            pnlFormContainer.Dock = DockStyle.Fill;
            pnlFormContainer.BackColor = System.Drawing.Color.White;
            pnlFormContainer.Margin = new Padding(0, 0, 10, 0);
            pnlFormContainer.Padding = new Padding(24, 18, 24, 18);

            lblFormTitle.Text = "Check-Out Summary";
            lblFormTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            lblFormTitle.ForeColor = System.Drawing.Color.FromArgb(31, 58, 95);
            lblFormTitle.Dock = DockStyle.Top;
            lblFormTitle.Height = 42;
            lblFormTitle.UseMnemonic = false;
            lblFormTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // Pinned bottom button bar
            tlpButtons.Dock = DockStyle.Bottom;
            tlpButtons.Height = 56;
            tlpButtons.Padding = new Padding(0, 12, 0, 0);
            tlpButtons.ColumnCount = 3;
            tlpButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 38F));
            tlpButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 32F));
            tlpButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tlpButtons.RowCount = 1;
            tlpButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));

            btnCheckOut.Text = "✔  Check-Out";
            btnCheckOut.Dock = DockStyle.Fill;
            btnCheckOut.Margin = new Padding(0, 0, 8, 0);
            btnCheckOut.FlatStyle = FlatStyle.Flat;
            btnCheckOut.FlatAppearance.BorderSize = 0;
            btnCheckOut.BackColor = System.Drawing.Color.FromArgb(42, 157, 143);
            btnCheckOut.ForeColor = System.Drawing.Color.White;
            btnCheckOut.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            btnCheckOut.Cursor = Cursors.Hand;
            btnCheckOut.Click += btnCheckOut_Click;

            btnBilling.Text = "🧾  Billing";
            btnBilling.Dock = DockStyle.Fill;
            btnBilling.Margin = new Padding(0, 0, 8, 0);
            btnBilling.FlatStyle = FlatStyle.Flat;
            btnBilling.FlatAppearance.BorderSize = 0;
            btnBilling.BackColor = System.Drawing.Color.FromArgb(31, 58, 95);
            btnBilling.ForeColor = System.Drawing.Color.White;
            btnBilling.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            btnBilling.Cursor = Cursors.Hand;
            btnBilling.Click += btnBilling_Click;

            btnClear.Text = "✖  Clear";
            btnClear.Dock = DockStyle.Fill;
            btnClear.Margin = new Padding(0);
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(31, 58, 95);
            btnClear.BackColor = System.Drawing.Color.White;
            btnClear.ForeColor = System.Drawing.Color.FromArgb(31, 58, 95);
            btnClear.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            btnClear.Cursor = Cursors.Hand;
            btnClear.Click += btnClear_Click;

            tlpButtons.Controls.Add(btnCheckOut, 0, 0);
            tlpButtons.Controls.Add(btnBilling, 1, 0);
            tlpButtons.Controls.Add(btnClear, 2, 0);

            pnlFormScroll.Dock = DockStyle.Fill;
            pnlFormScroll.AutoScroll = true;
            pnlFormScroll.Padding = new Padding(0, 4, 4, 4);

            pnlFormFields.Dock = DockStyle.Top;
            pnlFormFields.AutoSize = true;
            pnlFormFields.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            pnlFormFields.ColumnCount = 1;
            pnlFormFields.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            pnlFormFields.RowCount = 18;
            pnlFormFields.RowStyles.Add(new RowStyle(SizeType.Absolute, 24F));
            pnlFormFields.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            pnlFormFields.RowStyles.Add(new RowStyle(SizeType.Absolute, 24F));
            pnlFormFields.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            pnlFormFields.RowStyles.Add(new RowStyle(SizeType.Absolute, 24F));
            pnlFormFields.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            pnlFormFields.RowStyles.Add(new RowStyle(SizeType.Absolute, 24F));
            pnlFormFields.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            pnlFormFields.RowStyles.Add(new RowStyle(SizeType.Absolute, 24F));
            pnlFormFields.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            pnlFormFields.RowStyles.Add(new RowStyle(SizeType.Absolute, 24F));
            pnlFormFields.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            pnlFormFields.RowStyles.Add(new RowStyle(SizeType.Absolute, 24F));
            pnlFormFields.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            pnlFormFields.RowStyles.Add(new RowStyle(SizeType.Absolute, 24F));
            pnlFormFields.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            pnlFormFields.RowStyles.Add(new RowStyle(SizeType.Absolute, 24F));
            pnlFormFields.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));

            System.Drawing.Font lblFont = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            System.Drawing.Color lblColor = System.Drawing.Color.FromArgb(80, 80, 80);
            System.Drawing.Font inputFont = new System.Drawing.Font("Segoe UI", 10.5F);

            lblReservationId.Text = "Reservation ID";
            lblReservationId.Font = lblFont;
            lblReservationId.ForeColor = lblColor;
            lblReservationId.Dock = DockStyle.Fill;
            lblReservationId.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            pnlFormFields.Controls.Add(lblReservationId, 0, 0);

            txtReservationId.Dock = DockStyle.Fill;
            txtReservationId.Font = inputFont;
            txtReservationId.ReadOnly = true;
            txtReservationId.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);
            txtReservationId.PlaceholderText = "Select a checked-in guest";
            pnlFormFields.Controls.Add(txtReservationId, 0, 1);

            lblGuestName.Text = "Guest Name";
            lblGuestName.Font = lblFont;
            lblGuestName.ForeColor = lblColor;
            lblGuestName.Dock = DockStyle.Fill;
            lblGuestName.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            pnlFormFields.Controls.Add(lblGuestName, 0, 2);

            txtGuestName.Dock = DockStyle.Fill;
            txtGuestName.Font = inputFont;
            txtGuestName.ReadOnly = true;
            txtGuestName.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);
            pnlFormFields.Controls.Add(txtGuestName, 0, 3);

            lblRoomNumber.Text = "Room Number";
            lblRoomNumber.Font = lblFont;
            lblRoomNumber.ForeColor = lblColor;
            lblRoomNumber.Dock = DockStyle.Fill;
            lblRoomNumber.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            pnlFormFields.Controls.Add(lblRoomNumber, 0, 4);

            txtRoomNumber.Dock = DockStyle.Fill;
            txtRoomNumber.Font = inputFont;
            txtRoomNumber.ReadOnly = true;
            txtRoomNumber.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);
            pnlFormFields.Controls.Add(txtRoomNumber, 0, 5);

            lblCheckInDate.Text = "Check-In Date";
            lblCheckInDate.Font = lblFont;
            lblCheckInDate.ForeColor = lblColor;
            lblCheckInDate.Dock = DockStyle.Fill;
            lblCheckInDate.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            pnlFormFields.Controls.Add(lblCheckInDate, 0, 6);

            txtCheckInDate.Dock = DockStyle.Fill;
            txtCheckInDate.Font = inputFont;
            txtCheckInDate.ReadOnly = true;
            txtCheckInDate.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);
            pnlFormFields.Controls.Add(txtCheckInDate, 0, 7);

            lblCheckOutDate.Text = "Actual Check-Out Date & Time";
            lblCheckOutDate.Font = lblFont;
            lblCheckOutDate.ForeColor = lblColor;
            lblCheckOutDate.Dock = DockStyle.Fill;
            lblCheckOutDate.UseMnemonic = false;
            lblCheckOutDate.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            pnlFormFields.Controls.Add(lblCheckOutDate, 0, 8);

            dtpCheckOutDate.Dock = DockStyle.Fill;
            dtpCheckOutDate.Font = inputFont;
            dtpCheckOutDate.Format = DateTimePickerFormat.Custom;
            dtpCheckOutDate.CustomFormat = "MM/dd/yyyy hh:mm tt";
            pnlFormFields.Controls.Add(dtpCheckOutDate, 0, 9);

            lblRoomCharges.Text = "Room Charges ($)";
            lblRoomCharges.Font = lblFont;
            lblRoomCharges.ForeColor = lblColor;
            lblRoomCharges.Dock = DockStyle.Fill;
            lblRoomCharges.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            pnlFormFields.Controls.Add(lblRoomCharges, 0, 10);

            txtRoomCharges.Dock = DockStyle.Fill;
            txtRoomCharges.Font = inputFont;
            txtRoomCharges.ReadOnly = true;
            txtRoomCharges.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);
            pnlFormFields.Controls.Add(txtRoomCharges, 0, 11);

            lblExtraCharges.Text = "Extra Charges / Damages ($)";
            lblExtraCharges.Font = lblFont;
            lblExtraCharges.ForeColor = lblColor;
            lblExtraCharges.Dock = DockStyle.Fill;
            lblExtraCharges.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            pnlFormFields.Controls.Add(lblExtraCharges, 0, 12);

            txtExtraCharges.Dock = DockStyle.Fill;
            txtExtraCharges.Font = inputFont;
            txtExtraCharges.PlaceholderText = "e.g. 0.00";
            pnlFormFields.Controls.Add(txtExtraCharges, 0, 13);

            lblTotalDue.Text = "Total Amount Due ($)";
            lblTotalDue.Font = lblFont;
            lblTotalDue.ForeColor = System.Drawing.Color.FromArgb(31, 58, 95);
            lblTotalDue.Dock = DockStyle.Fill;
            lblTotalDue.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            pnlFormFields.Controls.Add(lblTotalDue, 0, 14);

            txtTotalDue.Dock = DockStyle.Fill;
            txtTotalDue.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            txtTotalDue.ForeColor = System.Drawing.Color.FromArgb(31, 58, 95);
            txtTotalDue.ReadOnly = true;
            txtTotalDue.BackColor = System.Drawing.Color.FromArgb(238, 245, 244);
            pnlFormFields.Controls.Add(txtTotalDue, 0, 15);

            lblRoomCondition.Text = "Room Inspection Status";
            lblRoomCondition.Font = lblFont;
            lblRoomCondition.ForeColor = lblColor;
            lblRoomCondition.Dock = DockStyle.Fill;
            lblRoomCondition.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            pnlFormFields.Controls.Add(lblRoomCondition, 0, 16);

            cmbRoomCondition.Dock = DockStyle.Fill;
            cmbRoomCondition.Font = inputFont;
            cmbRoomCondition.FormattingEnabled = true;
            cmbRoomCondition.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRoomCondition.Items.AddRange(new object[] { "Good / Clean", "Needs Housekeeping", "Maintenance Required" });
            pnlFormFields.Controls.Add(cmbRoomCondition, 0, 17);

            pnlFormScroll.Controls.Add(pnlFormFields);
            pnlFormContainer.Controls.Add(pnlFormScroll);
            pnlFormContainer.Controls.Add(tlpButtons);
            pnlFormContainer.Controls.Add(lblFormTitle);

            // ═══════════ RIGHT CARD — GRID (50%) ═══════════
            pnlGridContainer.Dock = DockStyle.Fill;
            pnlGridContainer.BackColor = System.Drawing.Color.White;
            pnlGridContainer.Margin = new Padding(10, 0, 0, 0);
            pnlGridContainer.Padding = new Padding(24, 18, 24, 18);

            lblGridTitle.Text = "Currently Checked-In Guests";
            lblGridTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            lblGridTitle.ForeColor = System.Drawing.Color.FromArgb(31, 58, 95);
            lblGridTitle.Dock = DockStyle.Top;
            lblGridTitle.Height = 42;
            lblGridTitle.UseMnemonic = false;
            lblGridTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            pnlSearchBar.Dock = DockStyle.Top;
            pnlSearchBar.Height = 44;
            pnlSearchBar.Padding = new Padding(0, 4, 0, 10);

            lblSearchIcon.Text = "🔍";
            lblSearchIcon.Font = new System.Drawing.Font("Segoe UI", 12F);
            lblSearchIcon.Dock = DockStyle.Left;
            lblSearchIcon.Width = 32;
            lblSearchIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            txtSearch.Dock = DockStyle.Fill;
            txtSearch.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            txtSearch.PlaceholderText = "Search checked-in guests by reservation #, name, or room #...";
            txtSearch.TextChanged += txtSearch_TextChanged;

            pnlSearchBar.Controls.Add(txtSearch);
            pnlSearchBar.Controls.Add(lblSearchIcon);

            dgvCheckedIn.Dock = DockStyle.Fill;
            dgvCheckedIn.BackgroundColor = System.Drawing.Color.White;
            dgvCheckedIn.BorderStyle = BorderStyle.None;
            dgvCheckedIn.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvCheckedIn.RowHeadersVisible = false;
            dgvCheckedIn.AllowUserToAddRows = false;
            dgvCheckedIn.AllowUserToDeleteRows = false;
            dgvCheckedIn.AllowUserToResizeRows = false;
            dgvCheckedIn.ReadOnly = true;
            dgvCheckedIn.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCheckedIn.MultiSelect = false;
            dgvCheckedIn.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCheckedIn.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvCheckedIn.ColumnHeadersHeight = 42;
            dgvCheckedIn.RowTemplate.Height = 36;
            dgvCheckedIn.EnableHeadersVisualStyles = false;
            dgvCheckedIn.GridColor = System.Drawing.Color.FromArgb(230, 230, 230);

            rowStyle.Font = new System.Drawing.Font("Segoe UI", 10F);
            rowStyle.ForeColor = System.Drawing.Color.FromArgb(50, 50, 50);
            rowStyle.SelectionBackColor = System.Drawing.Color.FromArgb(200, 230, 226);
            rowStyle.SelectionForeColor = System.Drawing.Color.Black;
            rowStyle.Padding = new Padding(6, 0, 6, 0);
            dgvCheckedIn.DefaultCellStyle = rowStyle;

            altRowStyle.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            dgvCheckedIn.AlternatingRowsDefaultCellStyle = altRowStyle;

            headerStyle.BackColor = System.Drawing.Color.FromArgb(31, 58, 95);
            headerStyle.ForeColor = System.Drawing.Color.White;
            headerStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            headerStyle.Padding = new Padding(6, 0, 6, 0);
            headerStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvCheckedIn.ColumnHeadersDefaultCellStyle = headerStyle;

            dgvCheckedIn.CellClick += dgvCheckedIn_CellClick;

            colResId.HeaderText = "Res #";
            colResId.Name = "colResId";
            colResId.FillWeight = 60;

            colGuestName.HeaderText = "Guest Name";
            colGuestName.Name = "colGuestName";
            colGuestName.FillWeight = 110;

            colRoomNumber.HeaderText = "Room #";
            colRoomNumber.Name = "colRoomNumber";
            colRoomNumber.FillWeight = 60;

            colRoomType.HeaderText = "Type";
            colRoomType.Name = "colRoomType";
            colRoomType.FillWeight = 75;

            colCheckInDate.HeaderText = "Checked-In";
            colCheckInDate.Name = "colCheckInDate";
            colCheckInDate.FillWeight = 85;

            colExpectedCheckOut.HeaderText = "Check-Out";
            colExpectedCheckOut.Name = "colExpectedCheckOut";
            colExpectedCheckOut.FillWeight = 85;

            colBalance.HeaderText = "Balance";
            colBalance.Name = "colBalance";
            colBalance.FillWeight = 75;

            colStatus.HeaderText = "Status";
            colStatus.Name = "colStatus";
            colStatus.FillWeight = 75;

            dgvCheckedIn.Columns.AddRange(new DataGridViewColumn[] {
                colResId, colGuestName, colRoomNumber, colRoomType, colCheckInDate, colExpectedCheckOut, colBalance, colStatus
            });

            pnlGridContainer.Controls.Add(dgvCheckedIn);
            pnlGridContainer.Controls.Add(pnlSearchBar);
            pnlGridContainer.Controls.Add(lblGridTitle);

            // ──────────── FORM ────────────
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new System.Drawing.Size(1200, 720);
            Controls.Add(pnlBody);
            Controls.Add(pnlHeader);
            Name = "CheckOut";
            Text = "Guest Check-Out — StaySync";
            Load += CheckOut_Load;

            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlBody.ResumeLayout(false);
            tlpMain.ResumeLayout(false);
            pnlFormContainer.ResumeLayout(false);
            pnlFormScroll.ResumeLayout(false);
            pnlFormScroll.PerformLayout();
            pnlFormFields.ResumeLayout(false);
            pnlFormFields.PerformLayout();
            tlpButtons.ResumeLayout(false);
            pnlGridContainer.ResumeLayout(false);
            pnlGridContainer.PerformLayout();
            pnlSearchBar.ResumeLayout(false);
            pnlSearchBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCheckedIn).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private Label lblTitle;
        private Button btnBack;
        private Panel pnlBody;
        private TableLayoutPanel tlpMain;

        private Panel pnlFormContainer;
        private Label lblFormTitle;
        private Panel pnlFormScroll;
        private TableLayoutPanel pnlFormFields;
        private Label lblReservationId;
        private TextBox txtReservationId;
        private Label lblGuestName;
        private TextBox txtGuestName;
        private Label lblRoomNumber;
        private TextBox txtRoomNumber;
        private Label lblCheckInDate;
        private TextBox txtCheckInDate;
        private Label lblCheckOutDate;
        private DateTimePicker dtpCheckOutDate;
        private Label lblRoomCharges;
        private TextBox txtRoomCharges;
        private Label lblExtraCharges;
        private TextBox txtExtraCharges;
        private Label lblTotalDue;
        private TextBox txtTotalDue;
        private Label lblRoomCondition;
        private ComboBox cmbRoomCondition;
        private TableLayoutPanel tlpButtons;
        private Button btnCheckOut;
        private Button btnBilling;
        private Button btnClear;

        private Panel pnlGridContainer;
        private Label lblGridTitle;
        private Panel pnlSearchBar;
        private Label lblSearchIcon;
        private TextBox txtSearch;
        private DataGridView dgvCheckedIn;
        private DataGridViewTextBoxColumn colResId;
        private DataGridViewTextBoxColumn colGuestName;
        private DataGridViewTextBoxColumn colRoomNumber;
        private DataGridViewTextBoxColumn colRoomType;
        private DataGridViewTextBoxColumn colCheckInDate;
        private DataGridViewTextBoxColumn colExpectedCheckOut;
        private DataGridViewTextBoxColumn colBalance;
        private DataGridViewTextBoxColumn colStatus;
    }
}

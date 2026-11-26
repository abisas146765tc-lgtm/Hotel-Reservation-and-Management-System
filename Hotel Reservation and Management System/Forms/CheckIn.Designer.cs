namespace Hotel_Reservation_and_Management_System
{
    partial class CheckIn
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
            cmbRoomNumber = new ComboBox();
            lblIdType = new Label();
            cmbIdType = new ComboBox();
            lblIdNumber = new Label();
            txtIdNumber = new TextBox();
            lblCheckInDate = new Label();
            dtpCheckInDate = new DateTimePicker();
            lblDeposit = new Label();
            txtDeposit = new TextBox();
            lblNotes = new Label();
            txtNotes = new TextBox();
            tlpButtons = new TableLayoutPanel();
            btnCheckIn = new Button();
            btnClear = new Button();

            pnlGridContainer = new Panel();
            lblGridTitle = new Label();
            pnlSearchBar = new Panel();
            lblSearchIcon = new Label();
            txtSearch = new TextBox();
            dgvArrivals = new DataGridView();
            colResId = new DataGridViewTextBoxColumn();
            colGuestName = new DataGridViewTextBoxColumn();
            colContact = new DataGridViewTextBoxColumn();
            colRoomNumber = new DataGridViewTextBoxColumn();
            colRoomType = new DataGridViewTextBoxColumn();
            colExpectedCheckIn = new DataGridViewTextBoxColumn();
            colNights = new DataGridViewTextBoxColumn();
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
            ((System.ComponentModel.ISupportInitialize)dgvArrivals).BeginInit();
            SuspendLayout();

            // ──────────── HEADER ────────────
            pnlHeader.BackColor = System.Drawing.Color.FromArgb(31, 58, 95);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Height = 70;
            pnlHeader.Padding = new Padding(24, 15, 24, 15);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Controls.Add(btnBack);

            lblTitle.Text = "Guest Check-In";
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

            lblFormTitle.Text = "Check-In Details";
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
            tlpButtons.ColumnCount = 2;
            tlpButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65F));
            tlpButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            tlpButtons.RowCount = 1;
            tlpButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));

            btnCheckIn.Text = "✔  Confirm Check-In";
            btnCheckIn.Dock = DockStyle.Fill;
            btnCheckIn.Margin = new Padding(0, 0, 10, 0);
            btnCheckIn.FlatStyle = FlatStyle.Flat;
            btnCheckIn.FlatAppearance.BorderSize = 0;
            btnCheckIn.BackColor = System.Drawing.Color.FromArgb(42, 157, 143);
            btnCheckIn.ForeColor = System.Drawing.Color.White;
            btnCheckIn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            btnCheckIn.Cursor = Cursors.Hand;
            btnCheckIn.Click += btnCheckIn_Click;

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

            tlpButtons.Controls.Add(btnCheckIn, 0, 0);
            tlpButtons.Controls.Add(btnClear, 1, 0);

            pnlFormScroll.Dock = DockStyle.Fill;
            pnlFormScroll.AutoScroll = true;
            pnlFormScroll.Padding = new Padding(0, 4, 4, 4);

            pnlFormFields.Dock = DockStyle.Top;
            pnlFormFields.AutoSize = true;
            pnlFormFields.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            pnlFormFields.ColumnCount = 1;
            pnlFormFields.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            pnlFormFields.RowCount = 16;
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
            pnlFormFields.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));

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
            txtReservationId.PlaceholderText = "Select an arrival from the list";
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

            lblRoomNumber.Text = "Assigned Room #";
            lblRoomNumber.Font = lblFont;
            lblRoomNumber.ForeColor = lblColor;
            lblRoomNumber.Dock = DockStyle.Fill;
            lblRoomNumber.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            pnlFormFields.Controls.Add(lblRoomNumber, 0, 4);

            cmbRoomNumber.Dock = DockStyle.Fill;
            cmbRoomNumber.Font = inputFont;
            cmbRoomNumber.FormattingEnabled = true;
            cmbRoomNumber.DropDownStyle = ComboBoxStyle.DropDownList;
            pnlFormFields.Controls.Add(cmbRoomNumber, 0, 5);

            lblIdType.Text = "Valid ID Type";
            lblIdType.Font = lblFont;
            lblIdType.ForeColor = lblColor;
            lblIdType.Dock = DockStyle.Fill;
            lblIdType.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            pnlFormFields.Controls.Add(lblIdType, 0, 6);

            cmbIdType.Dock = DockStyle.Fill;
            cmbIdType.Font = inputFont;
            cmbIdType.FormattingEnabled = true;
            cmbIdType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbIdType.Items.AddRange(new object[] { "National ID", "Passport", "Driver's License", "Company ID" });
            pnlFormFields.Controls.Add(cmbIdType, 0, 7);

            lblIdNumber.Text = "ID / Passport Number";
            lblIdNumber.Font = lblFont;
            lblIdNumber.ForeColor = lblColor;
            lblIdNumber.Dock = DockStyle.Fill;
            lblIdNumber.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            pnlFormFields.Controls.Add(lblIdNumber, 0, 8);

            txtIdNumber.Dock = DockStyle.Fill;
            txtIdNumber.Font = inputFont;
            txtIdNumber.PlaceholderText = "Enter ID number";
            pnlFormFields.Controls.Add(txtIdNumber, 0, 9);

            lblCheckInDate.Text = "Actual Check-In Date & Time";
            lblCheckInDate.Font = lblFont;
            lblCheckInDate.ForeColor = lblColor;
            lblCheckInDate.Dock = DockStyle.Fill;
            lblCheckInDate.UseMnemonic = false;
            lblCheckInDate.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            pnlFormFields.Controls.Add(lblCheckInDate, 0, 10);

            dtpCheckInDate.Dock = DockStyle.Fill;
            dtpCheckInDate.Font = inputFont;
            dtpCheckInDate.Format = DateTimePickerFormat.Custom;
            dtpCheckInDate.CustomFormat = "MM/dd/yyyy hh:mm tt";
            pnlFormFields.Controls.Add(dtpCheckInDate, 0, 11);

            lblDeposit.Text = "Security Deposit ($)";
            lblDeposit.Font = lblFont;
            lblDeposit.ForeColor = lblColor;
            lblDeposit.Dock = DockStyle.Fill;
            lblDeposit.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            pnlFormFields.Controls.Add(lblDeposit, 0, 12);

            txtDeposit.Dock = DockStyle.Fill;
            txtDeposit.Font = inputFont;
            txtDeposit.PlaceholderText = "e.g. 50.00";
            pnlFormFields.Controls.Add(txtDeposit, 0, 13);

            lblNotes.Text = "Check-In Notes";
            lblNotes.Font = lblFont;
            lblNotes.ForeColor = lblColor;
            lblNotes.Dock = DockStyle.Fill;
            lblNotes.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            pnlFormFields.Controls.Add(lblNotes, 0, 14);

            txtNotes.Dock = DockStyle.Fill;
            txtNotes.Font = inputFont;
            txtNotes.Multiline = true;
            txtNotes.ScrollBars = ScrollBars.Vertical;
            txtNotes.PlaceholderText = "Keycard issued, vehicle plate, luggage count...";
            pnlFormFields.Controls.Add(txtNotes, 0, 15);

            pnlFormScroll.Controls.Add(pnlFormFields);
            pnlFormContainer.Controls.Add(pnlFormScroll);
            pnlFormContainer.Controls.Add(tlpButtons);
            pnlFormContainer.Controls.Add(lblFormTitle);

            // ═══════════ RIGHT CARD — GRID (50%) ═══════════
            pnlGridContainer.Dock = DockStyle.Fill;
            pnlGridContainer.BackColor = System.Drawing.Color.White;
            pnlGridContainer.Margin = new Padding(10, 0, 0, 0);
            pnlGridContainer.Padding = new Padding(24, 18, 24, 18);

            lblGridTitle.Text = "Pending Arrivals (Confirmed Reservations)";
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
            txtSearch.PlaceholderText = "Search pending arrivals by reservation #, guest name, or room...";
            txtSearch.TextChanged += txtSearch_TextChanged;

            pnlSearchBar.Controls.Add(txtSearch);
            pnlSearchBar.Controls.Add(lblSearchIcon);

            dgvArrivals.Dock = DockStyle.Fill;
            dgvArrivals.BackgroundColor = System.Drawing.Color.White;
            dgvArrivals.BorderStyle = BorderStyle.None;
            dgvArrivals.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvArrivals.RowHeadersVisible = false;
            dgvArrivals.AllowUserToAddRows = false;
            dgvArrivals.AllowUserToDeleteRows = false;
            dgvArrivals.AllowUserToResizeRows = false;
            dgvArrivals.ReadOnly = true;
            dgvArrivals.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvArrivals.MultiSelect = false;
            dgvArrivals.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvArrivals.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvArrivals.ColumnHeadersHeight = 42;
            dgvArrivals.RowTemplate.Height = 36;
            dgvArrivals.EnableHeadersVisualStyles = false;
            dgvArrivals.GridColor = System.Drawing.Color.FromArgb(230, 230, 230);

            rowStyle.Font = new System.Drawing.Font("Segoe UI", 10F);
            rowStyle.ForeColor = System.Drawing.Color.FromArgb(50, 50, 50);
            rowStyle.SelectionBackColor = System.Drawing.Color.FromArgb(200, 230, 226);
            rowStyle.SelectionForeColor = System.Drawing.Color.Black;
            rowStyle.Padding = new Padding(6, 0, 6, 0);
            dgvArrivals.DefaultCellStyle = rowStyle;

            altRowStyle.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            dgvArrivals.AlternatingRowsDefaultCellStyle = altRowStyle;

            headerStyle.BackColor = System.Drawing.Color.FromArgb(31, 58, 95);
            headerStyle.ForeColor = System.Drawing.Color.White;
            headerStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            headerStyle.Padding = new Padding(6, 0, 6, 0);
            headerStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvArrivals.ColumnHeadersDefaultCellStyle = headerStyle;

            dgvArrivals.CellClick += dgvArrivals_CellClick;

            colResId.HeaderText = "Res #";
            colResId.Name = "colResId";
            colResId.FillWeight = 60;

            colGuestName.HeaderText = "Guest Name";
            colGuestName.Name = "colGuestName";
            colGuestName.FillWeight = 110;

            colContact.HeaderText = "Contact";
            colContact.Name = "colContact";
            colContact.FillWeight = 90;

            colRoomNumber.HeaderText = "Room #";
            colRoomNumber.Name = "colRoomNumber";
            colRoomNumber.FillWeight = 60;

            colRoomType.HeaderText = "Type";
            colRoomType.Name = "colRoomType";
            colRoomType.FillWeight = 75;

            colExpectedCheckIn.HeaderText = "Check-In";
            colExpectedCheckIn.Name = "colExpectedCheckIn";
            colExpectedCheckIn.FillWeight = 85;

            colNights.HeaderText = "Nights";
            colNights.Name = "colNights";
            colNights.FillWeight = 55;

            colStatus.HeaderText = "Status";
            colStatus.Name = "colStatus";
            colStatus.FillWeight = 75;

            dgvArrivals.Columns.AddRange(new DataGridViewColumn[] {
                colResId, colGuestName, colContact, colRoomNumber, colRoomType, colExpectedCheckIn, colNights, colStatus
            });

            pnlGridContainer.Controls.Add(dgvArrivals);
            pnlGridContainer.Controls.Add(pnlSearchBar);
            pnlGridContainer.Controls.Add(lblGridTitle);

            // ──────────── FORM ────────────
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new System.Drawing.Size(1200, 720);
            Controls.Add(pnlBody);
            Controls.Add(pnlHeader);
            Name = "CheckIn";
            Text = "Guest Check-In — StaySync";
            Load += CheckIn_Load;

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
            ((System.ComponentModel.ISupportInitialize)dgvArrivals).EndInit();
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
        private ComboBox cmbRoomNumber;
        private Label lblIdType;
        private ComboBox cmbIdType;
        private Label lblIdNumber;
        private TextBox txtIdNumber;
        private Label lblCheckInDate;
        private DateTimePicker dtpCheckInDate;
        private Label lblDeposit;
        private TextBox txtDeposit;
        private Label lblNotes;
        private TextBox txtNotes;
        private TableLayoutPanel tlpButtons;
        private Button btnCheckIn;
        private Button btnClear;

        private Panel pnlGridContainer;
        private Label lblGridTitle;
        private Panel pnlSearchBar;
        private Label lblSearchIcon;
        private TextBox txtSearch;
        private DataGridView dgvArrivals;
        private DataGridViewTextBoxColumn colResId;
        private DataGridViewTextBoxColumn colGuestName;
        private DataGridViewTextBoxColumn colContact;
        private DataGridViewTextBoxColumn colRoomNumber;
        private DataGridViewTextBoxColumn colRoomType;
        private DataGridViewTextBoxColumn colExpectedCheckIn;
        private DataGridViewTextBoxColumn colNights;
        private DataGridViewTextBoxColumn colStatus;
    }
}

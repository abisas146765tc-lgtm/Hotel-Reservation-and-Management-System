namespace Hotel_Reservation_and_Management_System
{
    partial class NewReservation
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
            lblGuestName = new Label();
            txtGuestName = new TextBox();
            lblContact = new Label();
            txtContact = new TextBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblRoomType = new Label();
            cmbRoomType = new ComboBox();
            lblRoomNumber = new Label();
            cmbRoomNumber = new ComboBox();
            lblCheckIn = new Label();
            dtpCheckIn = new DateTimePicker();
            lblCheckOut = new Label();
            dtpCheckOut = new DateTimePicker();
            lblGuests = new Label();
            nudGuests = new NumericUpDown();
            lblNotes = new Label();
            txtNotes = new TextBox();
            tlpButtons = new TableLayoutPanel();
            btnCreate = new Button();
            btnClear = new Button();

            pnlGridContainer = new Panel();
            lblGridTitle = new Label();
            pnlSearchBar = new Panel();
            lblSearchIcon = new Label();
            txtSearch = new TextBox();
            pnlFilterSpacer = new Panel();
            cmbFilterRoomType = new ComboBox();
            dgvRooms = new DataGridView();
            colRoomNumber = new DataGridViewTextBoxColumn();
            colRoomType = new DataGridViewTextBoxColumn();
            colCapacity = new DataGridViewTextBoxColumn();
            colRate = new DataGridViewTextBoxColumn();
            colStatus = new DataGridViewTextBoxColumn();
            colNotes = new DataGridViewTextBoxColumn();

            pnlHeader.SuspendLayout();
            pnlBody.SuspendLayout();
            tlpMain.SuspendLayout();
            pnlFormContainer.SuspendLayout();
            pnlFormScroll.SuspendLayout();
            pnlFormFields.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudGuests).BeginInit();
            tlpButtons.SuspendLayout();
            pnlGridContainer.SuspendLayout();
            pnlSearchBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRooms).BeginInit();
            SuspendLayout();

            // ──────────── HEADER ────────────
            pnlHeader.BackColor = System.Drawing.Color.FromArgb(31, 58, 95);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Height = 70;
            pnlHeader.Padding = new Padding(24, 15, 24, 15);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Controls.Add(btnBack);

            lblTitle.Text = "New Reservation";
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

            lblFormTitle.Text = "Reservation Details";
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

            btnCreate.Text = "➕  Book Reservation";
            btnCreate.Dock = DockStyle.Fill;
            btnCreate.Margin = new Padding(0, 0, 10, 0);
            btnCreate.FlatStyle = FlatStyle.Flat;
            btnCreate.FlatAppearance.BorderSize = 0;
            btnCreate.BackColor = System.Drawing.Color.FromArgb(42, 157, 143);
            btnCreate.ForeColor = System.Drawing.Color.White;
            btnCreate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            btnCreate.Cursor = Cursors.Hand;
            btnCreate.Click += btnCreate_Click;

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

            tlpButtons.Controls.Add(btnCreate, 0, 0);
            tlpButtons.Controls.Add(btnClear, 1, 0);

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
            pnlFormFields.RowStyles.Add(new RowStyle(SizeType.Absolute, 76F));

            System.Drawing.Font lblFont = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            System.Drawing.Color lblColor = System.Drawing.Color.FromArgb(80, 80, 80);
            System.Drawing.Font inputFont = new System.Drawing.Font("Segoe UI", 10.5F);

            lblGuestName.Text = "Guest Full Name";
            lblGuestName.Font = lblFont;
            lblGuestName.ForeColor = lblColor;
            lblGuestName.Dock = DockStyle.Fill;
            lblGuestName.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            pnlFormFields.Controls.Add(lblGuestName, 0, 0);

            txtGuestName.Dock = DockStyle.Fill;
            txtGuestName.Font = inputFont;
            txtGuestName.PlaceholderText = "e.g. John Doe";
            pnlFormFields.Controls.Add(txtGuestName, 0, 1);

            lblContact.Text = "Contact Number";
            lblContact.Font = lblFont;
            lblContact.ForeColor = lblColor;
            lblContact.Dock = DockStyle.Fill;
            lblContact.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            pnlFormFields.Controls.Add(lblContact, 0, 2);

            txtContact.Dock = DockStyle.Fill;
            txtContact.Font = inputFont;
            txtContact.PlaceholderText = "e.g. +63 912 345 6789";
            pnlFormFields.Controls.Add(txtContact, 0, 3);

            lblEmail.Text = "Email Address";
            lblEmail.Font = lblFont;
            lblEmail.ForeColor = lblColor;
            lblEmail.Dock = DockStyle.Fill;
            lblEmail.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            pnlFormFields.Controls.Add(lblEmail, 0, 4);

            txtEmail.Dock = DockStyle.Fill;
            txtEmail.Font = inputFont;
            txtEmail.PlaceholderText = "e.g. guest@email.com";
            pnlFormFields.Controls.Add(txtEmail, 0, 5);

            lblRoomType.Text = "Room Type";
            lblRoomType.Font = lblFont;
            lblRoomType.ForeColor = lblColor;
            lblRoomType.Dock = DockStyle.Fill;
            lblRoomType.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            pnlFormFields.Controls.Add(lblRoomType, 0, 6);

            cmbRoomType.Dock = DockStyle.Fill;
            cmbRoomType.Font = inputFont;
            cmbRoomType.FormattingEnabled = true;
            cmbRoomType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRoomType.Items.AddRange(new object[] { "Single", "Double", "Suite", "Deluxe", "Family", "Penthouse" });
            pnlFormFields.Controls.Add(cmbRoomType, 0, 7);

            lblRoomNumber.Text = "Room Number";
            lblRoomNumber.Font = lblFont;
            lblRoomNumber.ForeColor = lblColor;
            lblRoomNumber.Dock = DockStyle.Fill;
            lblRoomNumber.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            pnlFormFields.Controls.Add(lblRoomNumber, 0, 8);

            cmbRoomNumber.Dock = DockStyle.Fill;
            cmbRoomNumber.Font = inputFont;
            cmbRoomNumber.FormattingEnabled = true;
            cmbRoomNumber.DropDownStyle = ComboBoxStyle.DropDownList;
            pnlFormFields.Controls.Add(cmbRoomNumber, 0, 9);

            lblCheckIn.Text = "Check-In Date";
            lblCheckIn.Font = lblFont;
            lblCheckIn.ForeColor = lblColor;
            lblCheckIn.Dock = DockStyle.Fill;
            lblCheckIn.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            pnlFormFields.Controls.Add(lblCheckIn, 0, 10);

            dtpCheckIn.Dock = DockStyle.Fill;
            dtpCheckIn.Font = inputFont;
            dtpCheckIn.Format = DateTimePickerFormat.Short;
            pnlFormFields.Controls.Add(dtpCheckIn, 0, 11);

            lblCheckOut.Text = "Check-Out Date";
            lblCheckOut.Font = lblFont;
            lblCheckOut.ForeColor = lblColor;
            lblCheckOut.Dock = DockStyle.Fill;
            lblCheckOut.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            pnlFormFields.Controls.Add(lblCheckOut, 0, 12);

            dtpCheckOut.Dock = DockStyle.Fill;
            dtpCheckOut.Font = inputFont;
            dtpCheckOut.Format = DateTimePickerFormat.Short;
            pnlFormFields.Controls.Add(dtpCheckOut, 0, 13);

            lblGuests.Text = "Number of Guests";
            lblGuests.Font = lblFont;
            lblGuests.ForeColor = lblColor;
            lblGuests.Dock = DockStyle.Fill;
            lblGuests.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            pnlFormFields.Controls.Add(lblGuests, 0, 14);

            nudGuests.Dock = DockStyle.Fill;
            nudGuests.Font = inputFont;
            nudGuests.Minimum = 1;
            nudGuests.Maximum = 20;
            nudGuests.Value = 1;
            pnlFormFields.Controls.Add(nudGuests, 0, 15);

            lblNotes.Text = "Special Requests / Notes";
            lblNotes.Font = lblFont;
            lblNotes.ForeColor = lblColor;
            lblNotes.Dock = DockStyle.Fill;
            lblNotes.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            pnlFormFields.Controls.Add(lblNotes, 0, 16);

            txtNotes.Dock = DockStyle.Fill;
            txtNotes.Font = inputFont;
            txtNotes.Multiline = true;
            txtNotes.ScrollBars = ScrollBars.Vertical;
            txtNotes.PlaceholderText = "Early check-in, extra pillows, airport pickup...";
            pnlFormFields.Controls.Add(txtNotes, 0, 17);

            pnlFormScroll.Controls.Add(pnlFormFields);
            pnlFormContainer.Controls.Add(pnlFormScroll);
            pnlFormContainer.Controls.Add(tlpButtons);
            pnlFormContainer.Controls.Add(lblFormTitle);

            // ═══════════ RIGHT CARD — GRID (50%) ═══════════
            pnlGridContainer.Dock = DockStyle.Fill;
            pnlGridContainer.BackColor = System.Drawing.Color.White;
            pnlGridContainer.Margin = new Padding(10, 0, 0, 0);
            pnlGridContainer.Padding = new Padding(24, 18, 24, 18);

            lblGridTitle.Text = "Available Rooms";
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

            pnlFilterSpacer.Dock = DockStyle.Right;
            pnlFilterSpacer.Width = 10;

            cmbFilterRoomType.Dock = DockStyle.Right;
            cmbFilterRoomType.Width = 150;
            cmbFilterRoomType.Font = new System.Drawing.Font("Segoe UI", 10F);
            cmbFilterRoomType.FormattingEnabled = true;
            cmbFilterRoomType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFilterRoomType.Items.AddRange(new object[] { "All Types", "Single", "Double", "Suite", "Deluxe", "Family", "Penthouse" });

            txtSearch.Dock = DockStyle.Fill;
            txtSearch.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            txtSearch.PlaceholderText = "Search available rooms by room # or type...";
            txtSearch.TextChanged += txtSearch_TextChanged;

            pnlSearchBar.Controls.Add(txtSearch);
            pnlSearchBar.Controls.Add(pnlFilterSpacer);
            pnlSearchBar.Controls.Add(cmbFilterRoomType);
            pnlSearchBar.Controls.Add(lblSearchIcon);

            dgvRooms.Dock = DockStyle.Fill;
            dgvRooms.BackgroundColor = System.Drawing.Color.White;
            dgvRooms.BorderStyle = BorderStyle.None;
            dgvRooms.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvRooms.RowHeadersVisible = false;
            dgvRooms.AllowUserToAddRows = false;
            dgvRooms.AllowUserToDeleteRows = false;
            dgvRooms.AllowUserToResizeRows = false;
            dgvRooms.ReadOnly = true;
            dgvRooms.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRooms.MultiSelect = false;
            dgvRooms.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRooms.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvRooms.ColumnHeadersHeight = 42;
            dgvRooms.RowTemplate.Height = 36;
            dgvRooms.EnableHeadersVisualStyles = false;
            dgvRooms.GridColor = System.Drawing.Color.FromArgb(230, 230, 230);

            rowStyle.Font = new System.Drawing.Font("Segoe UI", 10F);
            rowStyle.ForeColor = System.Drawing.Color.FromArgb(50, 50, 50);
            rowStyle.SelectionBackColor = System.Drawing.Color.FromArgb(200, 230, 226);
            rowStyle.SelectionForeColor = System.Drawing.Color.Black;
            rowStyle.Padding = new Padding(6, 0, 6, 0);
            dgvRooms.DefaultCellStyle = rowStyle;

            altRowStyle.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            dgvRooms.AlternatingRowsDefaultCellStyle = altRowStyle;

            headerStyle.BackColor = System.Drawing.Color.FromArgb(31, 58, 95);
            headerStyle.ForeColor = System.Drawing.Color.White;
            headerStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            headerStyle.Padding = new Padding(6, 0, 6, 0);
            headerStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvRooms.ColumnHeadersDefaultCellStyle = headerStyle;

            dgvRooms.CellClick += dgvRooms_CellClick;

            colRoomNumber.HeaderText = "Room #";
            colRoomNumber.Name = "colRoomNumber";
            colRoomNumber.FillWeight = 70;

            colRoomType.HeaderText = "Room Type";
            colRoomType.Name = "colRoomType";
            colRoomType.FillWeight = 90;

            colCapacity.HeaderText = "Capacity";
            colCapacity.Name = "colCapacity";
            colCapacity.FillWeight = 70;

            colRate.HeaderText = "Rate/Night";
            colRate.Name = "colRate";
            colRate.FillWeight = 85;

            colStatus.HeaderText = "Status";
            colStatus.Name = "colStatus";
            colStatus.FillWeight = 80;

            colNotes.HeaderText = "Notes";
            colNotes.Name = "colNotes";
            colNotes.FillWeight = 130;

            dgvRooms.Columns.AddRange(new DataGridViewColumn[] {
                colRoomNumber, colRoomType, colCapacity, colRate, colStatus, colNotes
            });

            pnlGridContainer.Controls.Add(dgvRooms);
            pnlGridContainer.Controls.Add(pnlSearchBar);
            pnlGridContainer.Controls.Add(lblGridTitle);

            // ──────────── FORM ────────────
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new System.Drawing.Size(1200, 720);
            Controls.Add(pnlBody);
            Controls.Add(pnlHeader);
            Name = "NewReservation";
            Text = "New Reservation — StaySync";
            Load += NewReservation_Load;

            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlBody.ResumeLayout(false);
            tlpMain.ResumeLayout(false);
            pnlFormContainer.ResumeLayout(false);
            pnlFormScroll.ResumeLayout(false);
            pnlFormScroll.PerformLayout();
            pnlFormFields.ResumeLayout(false);
            pnlFormFields.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudGuests).EndInit();
            tlpButtons.ResumeLayout(false);
            pnlGridContainer.ResumeLayout(false);
            pnlGridContainer.PerformLayout();
            pnlSearchBar.ResumeLayout(false);
            pnlSearchBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRooms).EndInit();
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
        private Label lblGuestName;
        private TextBox txtGuestName;
        private Label lblContact;
        private TextBox txtContact;
        private Label lblEmail;
        private TextBox txtEmail;
        private Label lblRoomType;
        private ComboBox cmbRoomType;
        private Label lblRoomNumber;
        private ComboBox cmbRoomNumber;
        private Label lblCheckIn;
        private DateTimePicker dtpCheckIn;
        private Label lblCheckOut;
        private DateTimePicker dtpCheckOut;
        private Label lblGuests;
        private NumericUpDown nudGuests;
        private Label lblNotes;
        private TextBox txtNotes;
        private TableLayoutPanel tlpButtons;
        private Button btnCreate;
        private Button btnClear;

        private Panel pnlGridContainer;
        private Label lblGridTitle;
        private Panel pnlSearchBar;
        private Label lblSearchIcon;
        private TextBox txtSearch;
        private Panel pnlFilterSpacer;
        private ComboBox cmbFilterRoomType;
        private DataGridView dgvRooms;
        private DataGridViewTextBoxColumn colRoomNumber;
        private DataGridViewTextBoxColumn colRoomType;
        private DataGridViewTextBoxColumn colCapacity;
        private DataGridViewTextBoxColumn colRate;
        private DataGridViewTextBoxColumn colStatus;
        private DataGridViewTextBoxColumn colNotes;
    }
}

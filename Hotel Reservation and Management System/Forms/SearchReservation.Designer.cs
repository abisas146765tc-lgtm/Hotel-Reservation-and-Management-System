namespace Hotel_Reservation_and_Management_System
{
    partial class SearchReservation
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
            lblCheckIn = new Label();
            dtpCheckIn = new DateTimePicker();
            lblCheckOut = new Label();
            dtpCheckOut = new DateTimePicker();
            lblGuests = new Label();
            nudGuests = new NumericUpDown();
            lblStatus = new Label();
            cmbStatus = new ComboBox();
            lblNotes = new Label();
            txtNotes = new TextBox();
            tlpButtons = new TableLayoutPanel();
            btnUpdate = new Button();
            btnCancelBooking = new Button();
            btnClear = new Button();

            pnlGridContainer = new Panel();
            lblGridTitle = new Label();
            pnlSearchBar = new Panel();
            lblSearchIcon = new Label();
            txtSearch = new TextBox();
            pnlFilterSpacer = new Panel();
            cmbFilterStatus = new ComboBox();
            dgvReservations = new DataGridView();
            colResId = new DataGridViewTextBoxColumn();
            colGuestName = new DataGridViewTextBoxColumn();
            colRoomNumber = new DataGridViewTextBoxColumn();
            colRoomType = new DataGridViewTextBoxColumn();
            colCheckIn = new DataGridViewTextBoxColumn();
            colCheckOut = new DataGridViewTextBoxColumn();
            colGuests = new DataGridViewTextBoxColumn();
            colStatus = new DataGridViewTextBoxColumn();

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
            ((System.ComponentModel.ISupportInitialize)dgvReservations).BeginInit();
            SuspendLayout();

            // ──────────── HEADER ────────────
            pnlHeader.BackColor = System.Drawing.Color.FromArgb(31, 58, 95);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Height = 70;
            pnlHeader.Padding = new Padding(24, 15, 24, 15);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Controls.Add(btnBack);

            lblTitle.Text = "Search & Manage Reservations";
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
            tlpButtons.ColumnCount = 3;
            tlpButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            tlpButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            tlpButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tlpButtons.RowCount = 1;
            tlpButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));

            btnUpdate.Text = "💾  Update";
            btnUpdate.Dock = DockStyle.Fill;
            btnUpdate.Margin = new Padding(0, 0, 8, 0);
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.BackColor = System.Drawing.Color.FromArgb(42, 157, 143);
            btnUpdate.ForeColor = System.Drawing.Color.White;
            btnUpdate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            btnUpdate.Cursor = Cursors.Hand;
            btnUpdate.Click += btnUpdate_Click;

            btnCancelBooking.Text = "🚫  Cancel";
            btnCancelBooking.Dock = DockStyle.Fill;
            btnCancelBooking.Margin = new Padding(0, 0, 8, 0);
            btnCancelBooking.FlatStyle = FlatStyle.Flat;
            btnCancelBooking.FlatAppearance.BorderSize = 0;
            btnCancelBooking.BackColor = System.Drawing.Color.FromArgb(200, 60, 60);
            btnCancelBooking.ForeColor = System.Drawing.Color.White;
            btnCancelBooking.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            btnCancelBooking.Cursor = Cursors.Hand;
            btnCancelBooking.Click += btnCancelBooking_Click;

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

            tlpButtons.Controls.Add(btnUpdate, 0, 0);
            tlpButtons.Controls.Add(btnCancelBooking, 1, 0);
            tlpButtons.Controls.Add(btnClear, 2, 0);

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
            pnlFormFields.RowStyles.Add(new RowStyle(SizeType.Absolute, 76F));

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
            txtReservationId.PlaceholderText = "Select a reservation from the list";
            pnlFormFields.Controls.Add(txtReservationId, 0, 1);

            lblGuestName.Text = "Guest Name";
            lblGuestName.Font = lblFont;
            lblGuestName.ForeColor = lblColor;
            lblGuestName.Dock = DockStyle.Fill;
            lblGuestName.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            pnlFormFields.Controls.Add(lblGuestName, 0, 2);

            txtGuestName.Dock = DockStyle.Fill;
            txtGuestName.Font = inputFont;
            txtGuestName.PlaceholderText = "Guest full name";
            pnlFormFields.Controls.Add(txtGuestName, 0, 3);

            lblRoomNumber.Text = "Room Number";
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

            lblCheckIn.Text = "Check-In Date";
            lblCheckIn.Font = lblFont;
            lblCheckIn.ForeColor = lblColor;
            lblCheckIn.Dock = DockStyle.Fill;
            lblCheckIn.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            pnlFormFields.Controls.Add(lblCheckIn, 0, 6);

            dtpCheckIn.Dock = DockStyle.Fill;
            dtpCheckIn.Font = inputFont;
            dtpCheckIn.Format = DateTimePickerFormat.Short;
            pnlFormFields.Controls.Add(dtpCheckIn, 0, 7);

            lblCheckOut.Text = "Check-Out Date";
            lblCheckOut.Font = lblFont;
            lblCheckOut.ForeColor = lblColor;
            lblCheckOut.Dock = DockStyle.Fill;
            lblCheckOut.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            pnlFormFields.Controls.Add(lblCheckOut, 0, 8);

            dtpCheckOut.Dock = DockStyle.Fill;
            dtpCheckOut.Font = inputFont;
            dtpCheckOut.Format = DateTimePickerFormat.Short;
            pnlFormFields.Controls.Add(dtpCheckOut, 0, 9);

            lblGuests.Text = "Number of Guests";
            lblGuests.Font = lblFont;
            lblGuests.ForeColor = lblColor;
            lblGuests.Dock = DockStyle.Fill;
            lblGuests.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            pnlFormFields.Controls.Add(lblGuests, 0, 10);

            nudGuests.Dock = DockStyle.Fill;
            nudGuests.Font = inputFont;
            nudGuests.Minimum = 1;
            nudGuests.Maximum = 20;
            nudGuests.Value = 1;
            pnlFormFields.Controls.Add(nudGuests, 0, 11);

            lblStatus.Text = "Reservation Status";
            lblStatus.Font = lblFont;
            lblStatus.ForeColor = lblColor;
            lblStatus.Dock = DockStyle.Fill;
            lblStatus.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            pnlFormFields.Controls.Add(lblStatus, 0, 12);

            cmbStatus.Dock = DockStyle.Fill;
            cmbStatus.Font = inputFont;
            cmbStatus.FormattingEnabled = true;
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.Items.AddRange(new object[] { "Confirmed", "Checked-In", "Checked-Out", "Cancelled" });
            pnlFormFields.Controls.Add(cmbStatus, 0, 13);

            lblNotes.Text = "Notes";
            lblNotes.Font = lblFont;
            lblNotes.ForeColor = lblColor;
            lblNotes.Dock = DockStyle.Fill;
            lblNotes.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            pnlFormFields.Controls.Add(lblNotes, 0, 14);

            txtNotes.Dock = DockStyle.Fill;
            txtNotes.Font = inputFont;
            txtNotes.Multiline = true;
            txtNotes.ScrollBars = ScrollBars.Vertical;
            txtNotes.PlaceholderText = "Special requests or remarks...";
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

            lblGridTitle.Text = "All Reservations";
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

            cmbFilterStatus.Dock = DockStyle.Right;
            cmbFilterStatus.Width = 150;
            cmbFilterStatus.Font = new System.Drawing.Font("Segoe UI", 10F);
            cmbFilterStatus.FormattingEnabled = true;
            cmbFilterStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFilterStatus.Items.AddRange(new object[] { "All Statuses", "Confirmed", "Checked-In", "Checked-Out", "Cancelled" });

            txtSearch.Dock = DockStyle.Fill;
            txtSearch.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            txtSearch.PlaceholderText = "Search reservations by ID, guest name, or room #...";
            txtSearch.TextChanged += txtSearch_TextChanged;

            pnlSearchBar.Controls.Add(txtSearch);
            pnlSearchBar.Controls.Add(pnlFilterSpacer);
            pnlSearchBar.Controls.Add(cmbFilterStatus);
            pnlSearchBar.Controls.Add(lblSearchIcon);

            dgvReservations.Dock = DockStyle.Fill;
            dgvReservations.BackgroundColor = System.Drawing.Color.White;
            dgvReservations.BorderStyle = BorderStyle.None;
            dgvReservations.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvReservations.RowHeadersVisible = false;
            dgvReservations.AllowUserToAddRows = false;
            dgvReservations.AllowUserToDeleteRows = false;
            dgvReservations.AllowUserToResizeRows = false;
            dgvReservations.ReadOnly = true;
            dgvReservations.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvReservations.MultiSelect = false;
            dgvReservations.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvReservations.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvReservations.ColumnHeadersHeight = 42;
            dgvReservations.RowTemplate.Height = 36;
            dgvReservations.EnableHeadersVisualStyles = false;
            dgvReservations.GridColor = System.Drawing.Color.FromArgb(230, 230, 230);

            rowStyle.Font = new System.Drawing.Font("Segoe UI", 10F);
            rowStyle.ForeColor = System.Drawing.Color.FromArgb(50, 50, 50);
            rowStyle.SelectionBackColor = System.Drawing.Color.FromArgb(200, 230, 226);
            rowStyle.SelectionForeColor = System.Drawing.Color.Black;
            rowStyle.Padding = new Padding(6, 0, 6, 0);
            dgvReservations.DefaultCellStyle = rowStyle;

            altRowStyle.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            dgvReservations.AlternatingRowsDefaultCellStyle = altRowStyle;

            headerStyle.BackColor = System.Drawing.Color.FromArgb(31, 58, 95);
            headerStyle.ForeColor = System.Drawing.Color.White;
            headerStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            headerStyle.Padding = new Padding(6, 0, 6, 0);
            headerStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvReservations.ColumnHeadersDefaultCellStyle = headerStyle;

            dgvReservations.CellClick += dgvReservations_CellClick;

            colResId.HeaderText = "Res #";
            colResId.Name = "colResId";
            colResId.FillWeight = 60;

            colGuestName.HeaderText = "Guest Name";
            colGuestName.Name = "colGuestName";
            colGuestName.FillWeight = 115;

            colRoomNumber.HeaderText = "Room #";
            colRoomNumber.Name = "colRoomNumber";
            colRoomNumber.FillWeight = 65;

            colRoomType.HeaderText = "Room Type";
            colRoomType.Name = "colRoomType";
            colRoomType.FillWeight = 80;

            colCheckIn.HeaderText = "Check-In";
            colCheckIn.Name = "colCheckIn";
            colCheckIn.FillWeight = 85;

            colCheckOut.HeaderText = "Check-Out";
            colCheckOut.Name = "colCheckOut";
            colCheckOut.FillWeight = 85;

            colGuests.HeaderText = "Guests";
            colGuests.Name = "colGuests";
            colGuests.FillWeight = 55;

            colStatus.HeaderText = "Status";
            colStatus.Name = "colStatus";
            colStatus.FillWeight = 80;

            dgvReservations.Columns.AddRange(new DataGridViewColumn[] {
                colResId, colGuestName, colRoomNumber, colRoomType, colCheckIn, colCheckOut, colGuests, colStatus
            });

            pnlGridContainer.Controls.Add(dgvReservations);
            pnlGridContainer.Controls.Add(pnlSearchBar);
            pnlGridContainer.Controls.Add(lblGridTitle);

            // ──────────── FORM ────────────
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new System.Drawing.Size(1200, 720);
            Controls.Add(pnlBody);
            Controls.Add(pnlHeader);
            Name = "SearchReservation";
            Text = "Search & Manage Reservations — StaySync";
            Load += SearchReservation_Load;

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
            ((System.ComponentModel.ISupportInitialize)dgvReservations).EndInit();
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
        private Label lblCheckIn;
        private DateTimePicker dtpCheckIn;
        private Label lblCheckOut;
        private DateTimePicker dtpCheckOut;
        private Label lblGuests;
        private NumericUpDown nudGuests;
        private Label lblStatus;
        private ComboBox cmbStatus;
        private Label lblNotes;
        private TextBox txtNotes;
        private TableLayoutPanel tlpButtons;
        private Button btnUpdate;
        private Button btnCancelBooking;
        private Button btnClear;

        private Panel pnlGridContainer;
        private Label lblGridTitle;
        private Panel pnlSearchBar;
        private Label lblSearchIcon;
        private TextBox txtSearch;
        private Panel pnlFilterSpacer;
        private ComboBox cmbFilterStatus;
        private DataGridView dgvReservations;
        private DataGridViewTextBoxColumn colResId;
        private DataGridViewTextBoxColumn colGuestName;
        private DataGridViewTextBoxColumn colRoomNumber;
        private DataGridViewTextBoxColumn colRoomType;
        private DataGridViewTextBoxColumn colCheckIn;
        private DataGridViewTextBoxColumn colCheckOut;
        private DataGridViewTextBoxColumn colGuests;
        private DataGridViewTextBoxColumn colStatus;
    }
}

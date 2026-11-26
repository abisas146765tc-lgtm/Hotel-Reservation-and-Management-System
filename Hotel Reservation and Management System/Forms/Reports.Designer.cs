namespace Hotel_Reservation_and_Management_System
{
    partial class Reports
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

            tlpKpiCards = new TableLayoutPanel();
            pnlCardRevenue = new Panel();
            pnlCardRevenueAccent = new Panel();
            lblCardRevenueTitle = new Label();
            lblCardRevenueValue = new Label();
            pnlCardBookings = new Panel();
            pnlCardBookingsAccent = new Panel();
            lblCardBookingsTitle = new Label();
            lblCardBookingsValue = new Label();
            pnlCardOccupancy = new Panel();
            pnlCardOccupancyAccent = new Panel();
            lblCardOccupancyTitle = new Label();
            lblCardOccupancyValue = new Label();
            pnlCardAvailable = new Panel();
            pnlCardAvailableAccent = new Panel();
            lblCardAvailableTitle = new Label();
            lblCardAvailableValue = new Label();

            tlpMain = new TableLayoutPanel();
            pnlFilterContainer = new Panel();
            lblFilterTitle = new Label();
            pnlFilterScroll = new Panel();
            pnlFilterFields = new TableLayoutPanel();
            lblReportType = new Label();
            cmbReportType = new ComboBox();
            lblDateFrom = new Label();
            dtpFrom = new DateTimePicker();
            lblDateTo = new Label();
            dtpTo = new DateTimePicker();
            lblRoomType = new Label();
            cmbRoomType = new ComboBox();
            lblStatus = new Label();
            cmbStatus = new ComboBox();
            tlpButtons = new TableLayoutPanel();
            btnGenerate = new Button();
            btnExport = new Button();
            btnPrint = new Button();

            pnlGridContainer = new Panel();
            lblGridTitle = new Label();
            pnlSearchBar = new Panel();
            lblSearchIcon = new Label();
            txtSearch = new TextBox();
            dgvReport = new DataGridView();
            colDate = new DataGridViewTextBoxColumn();
            colRefNo = new DataGridViewTextBoxColumn();
            colCategory = new DataGridViewTextBoxColumn();
            colGuestOrRoom = new DataGridViewTextBoxColumn();
            colDetails = new DataGridViewTextBoxColumn();
            colAmount = new DataGridViewTextBoxColumn();
            colStatus = new DataGridViewTextBoxColumn();

            pnlHeader.SuspendLayout();
            pnlBody.SuspendLayout();
            tlpKpiCards.SuspendLayout();
            pnlCardRevenue.SuspendLayout();
            pnlCardBookings.SuspendLayout();
            pnlCardOccupancy.SuspendLayout();
            pnlCardAvailable.SuspendLayout();
            tlpMain.SuspendLayout();
            pnlFilterContainer.SuspendLayout();
            pnlFilterScroll.SuspendLayout();
            pnlFilterFields.SuspendLayout();
            tlpButtons.SuspendLayout();
            pnlGridContainer.SuspendLayout();
            pnlSearchBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReport).BeginInit();
            SuspendLayout();

            // ──────────── HEADER ────────────
            pnlHeader.BackColor = System.Drawing.Color.FromArgb(31, 58, 95);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Height = 70;
            pnlHeader.Padding = new Padding(24, 15, 24, 15);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Controls.Add(btnBack);

            lblTitle.Text = "Reports & Analytics";
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

            // ──────────── BODY (KPI CARDS + 50 / 50 CENTERED CARDS) ────────────
            pnlBody.Dock = DockStyle.Fill;
            pnlBody.BackColor = System.Drawing.Color.FromArgb(240, 243, 247);
            pnlBody.Padding = new Padding(24, 20, 24, 20);
            pnlBody.Controls.Add(tlpMain);
            pnlBody.Controls.Add(tlpKpiCards);

            // ──────────── TOP KPI CARDS ────────────
            tlpKpiCards.Dock = DockStyle.Top;
            tlpKpiCards.Height = 112;
            tlpKpiCards.Padding = new Padding(0, 0, 0, 18);
            tlpKpiCards.ColumnCount = 4;
            tlpKpiCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpKpiCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpKpiCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpKpiCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpKpiCards.RowCount = 1;
            tlpKpiCards.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));

            pnlCardRevenue.Dock = DockStyle.Fill;
            pnlCardRevenue.BackColor = System.Drawing.Color.White;
            pnlCardRevenue.Margin = new Padding(0, 0, 8, 0);
            pnlCardRevenueAccent.Dock = DockStyle.Left;
            pnlCardRevenueAccent.Width = 6;
            pnlCardRevenueAccent.BackColor = System.Drawing.Color.FromArgb(42, 157, 143);
            lblCardRevenueTitle.Text = "TOTAL REVENUE";
            lblCardRevenueTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            lblCardRevenueTitle.ForeColor = System.Drawing.Color.Gray;
            lblCardRevenueTitle.Location = new System.Drawing.Point(20, 16);
            lblCardRevenueTitle.AutoSize = true;
            lblCardRevenueValue.Text = "$0.00";
            lblCardRevenueValue.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            lblCardRevenueValue.ForeColor = System.Drawing.Color.FromArgb(31, 58, 95);
            lblCardRevenueValue.Location = new System.Drawing.Point(18, 40);
            lblCardRevenueValue.AutoSize = true;
            pnlCardRevenue.Controls.Add(lblCardRevenueValue);
            pnlCardRevenue.Controls.Add(lblCardRevenueTitle);
            pnlCardRevenue.Controls.Add(pnlCardRevenueAccent);

            pnlCardBookings.Dock = DockStyle.Fill;
            pnlCardBookings.BackColor = System.Drawing.Color.White;
            pnlCardBookings.Margin = new Padding(6, 0, 6, 0);
            pnlCardBookingsAccent.Dock = DockStyle.Left;
            pnlCardBookingsAccent.Width = 6;
            pnlCardBookingsAccent.BackColor = System.Drawing.Color.FromArgb(31, 58, 95);
            lblCardBookingsTitle.Text = "TOTAL BOOKINGS";
            lblCardBookingsTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            lblCardBookingsTitle.ForeColor = System.Drawing.Color.Gray;
            lblCardBookingsTitle.Location = new System.Drawing.Point(20, 16);
            lblCardBookingsTitle.AutoSize = true;
            lblCardBookingsValue.Text = "0";
            lblCardBookingsValue.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            lblCardBookingsValue.ForeColor = System.Drawing.Color.FromArgb(31, 58, 95);
            lblCardBookingsValue.Location = new System.Drawing.Point(18, 40);
            lblCardBookingsValue.AutoSize = true;
            pnlCardBookings.Controls.Add(lblCardBookingsValue);
            pnlCardBookings.Controls.Add(lblCardBookingsTitle);
            pnlCardBookings.Controls.Add(pnlCardBookingsAccent);

            pnlCardOccupancy.Dock = DockStyle.Fill;
            pnlCardOccupancy.BackColor = System.Drawing.Color.White;
            pnlCardOccupancy.Margin = new Padding(6, 0, 6, 0);
            pnlCardOccupancyAccent.Dock = DockStyle.Left;
            pnlCardOccupancyAccent.Width = 6;
            pnlCardOccupancyAccent.BackColor = System.Drawing.Color.FromArgb(233, 196, 106);
            lblCardOccupancyTitle.Text = "OCCUPANCY RATE";
            lblCardOccupancyTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            lblCardOccupancyTitle.ForeColor = System.Drawing.Color.Gray;
            lblCardOccupancyTitle.Location = new System.Drawing.Point(20, 16);
            lblCardOccupancyTitle.AutoSize = true;
            lblCardOccupancyValue.Text = "0%";
            lblCardOccupancyValue.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            lblCardOccupancyValue.ForeColor = System.Drawing.Color.FromArgb(31, 58, 95);
            lblCardOccupancyValue.Location = new System.Drawing.Point(18, 40);
            lblCardOccupancyValue.AutoSize = true;
            pnlCardOccupancy.Controls.Add(lblCardOccupancyValue);
            pnlCardOccupancy.Controls.Add(lblCardOccupancyTitle);
            pnlCardOccupancy.Controls.Add(pnlCardOccupancyAccent);

            pnlCardAvailable.Dock = DockStyle.Fill;
            pnlCardAvailable.BackColor = System.Drawing.Color.White;
            pnlCardAvailable.Margin = new Padding(8, 0, 0, 0);
            pnlCardAvailableAccent.Dock = DockStyle.Left;
            pnlCardAvailableAccent.Width = 6;
            pnlCardAvailableAccent.BackColor = System.Drawing.Color.FromArgb(42, 157, 143);
            lblCardAvailableTitle.Text = "AVAILABLE ROOMS";
            lblCardAvailableTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            lblCardAvailableTitle.ForeColor = System.Drawing.Color.Gray;
            lblCardAvailableTitle.Location = new System.Drawing.Point(20, 16);
            lblCardAvailableTitle.AutoSize = true;
            lblCardAvailableValue.Text = "0";
            lblCardAvailableValue.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            lblCardAvailableValue.ForeColor = System.Drawing.Color.FromArgb(31, 58, 95);
            lblCardAvailableValue.Location = new System.Drawing.Point(18, 40);
            lblCardAvailableValue.AutoSize = true;
            pnlCardAvailable.Controls.Add(lblCardAvailableValue);
            pnlCardAvailable.Controls.Add(lblCardAvailableTitle);
            pnlCardAvailable.Controls.Add(pnlCardAvailableAccent);

            tlpKpiCards.Controls.Add(pnlCardRevenue, 0, 0);
            tlpKpiCards.Controls.Add(pnlCardBookings, 1, 0);
            tlpKpiCards.Controls.Add(pnlCardOccupancy, 2, 0);
            tlpKpiCards.Controls.Add(pnlCardAvailable, 3, 0);

            // ──────────── MAIN 50 / 50 TABLE ────────────
            tlpMain.Dock = DockStyle.Fill;
            tlpMain.ColumnCount = 2;
            tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tlpMain.RowCount = 1;
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpMain.Controls.Add(pnlFilterContainer, 0, 0);
            tlpMain.Controls.Add(pnlGridContainer, 1, 0);

            // ═══════════ LEFT CARD — FILTERS (50%) ═══════════
            pnlFilterContainer.Dock = DockStyle.Fill;
            pnlFilterContainer.BackColor = System.Drawing.Color.White;
            pnlFilterContainer.Margin = new Padding(0, 0, 10, 0);
            pnlFilterContainer.Padding = new Padding(24, 18, 24, 18);

            lblFilterTitle.Text = "Report Parameters";
            lblFilterTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            lblFilterTitle.ForeColor = System.Drawing.Color.FromArgb(31, 58, 95);
            lblFilterTitle.Dock = DockStyle.Top;
            lblFilterTitle.Height = 42;
            lblFilterTitle.UseMnemonic = false;
            lblFilterTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // Pinned bottom button bar
            tlpButtons.Dock = DockStyle.Bottom;
            tlpButtons.Height = 56;
            tlpButtons.Padding = new Padding(0, 12, 0, 0);
            tlpButtons.ColumnCount = 3;
            tlpButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 36F));
            tlpButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 32F));
            tlpButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 32F));
            tlpButtons.RowCount = 1;
            tlpButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));

            btnGenerate.Text = "📊  Generate";
            btnGenerate.Dock = DockStyle.Fill;
            btnGenerate.Margin = new Padding(0, 0, 8, 0);
            btnGenerate.FlatStyle = FlatStyle.Flat;
            btnGenerate.FlatAppearance.BorderSize = 0;
            btnGenerate.BackColor = System.Drawing.Color.FromArgb(42, 157, 143);
            btnGenerate.ForeColor = System.Drawing.Color.White;
            btnGenerate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            btnGenerate.Cursor = Cursors.Hand;
            btnGenerate.Click += btnGenerate_Click;

            btnExport.Text = "📤  Export";
            btnExport.Dock = DockStyle.Fill;
            btnExport.Margin = new Padding(0, 0, 8, 0);
            btnExport.FlatStyle = FlatStyle.Flat;
            btnExport.FlatAppearance.BorderSize = 0;
            btnExport.BackColor = System.Drawing.Color.FromArgb(31, 58, 95);
            btnExport.ForeColor = System.Drawing.Color.White;
            btnExport.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            btnExport.Cursor = Cursors.Hand;
            btnExport.Click += btnExport_Click;

            btnPrint.Text = "🖨  Print";
            btnPrint.Dock = DockStyle.Fill;
            btnPrint.Margin = new Padding(0);
            btnPrint.FlatStyle = FlatStyle.Flat;
            btnPrint.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(31, 58, 95);
            btnPrint.BackColor = System.Drawing.Color.White;
            btnPrint.ForeColor = System.Drawing.Color.FromArgb(31, 58, 95);
            btnPrint.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            btnPrint.Cursor = Cursors.Hand;
            btnPrint.Click += btnPrint_Click;

            tlpButtons.Controls.Add(btnGenerate, 0, 0);
            tlpButtons.Controls.Add(btnExport, 1, 0);
            tlpButtons.Controls.Add(btnPrint, 2, 0);

            pnlFilterScroll.Dock = DockStyle.Fill;
            pnlFilterScroll.AutoScroll = true;
            pnlFilterScroll.Padding = new Padding(0, 4, 4, 4);

            pnlFilterFields.Dock = DockStyle.Top;
            pnlFilterFields.AutoSize = true;
            pnlFilterFields.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            pnlFilterFields.ColumnCount = 1;
            pnlFilterFields.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            pnlFilterFields.RowCount = 10;
            pnlFilterFields.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            pnlFilterFields.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
            pnlFilterFields.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            pnlFilterFields.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
            pnlFilterFields.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            pnlFilterFields.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
            pnlFilterFields.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            pnlFilterFields.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
            pnlFilterFields.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            pnlFilterFields.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));

            System.Drawing.Font lblFont = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            System.Drawing.Color lblColor = System.Drawing.Color.FromArgb(80, 80, 80);
            System.Drawing.Font inputFont = new System.Drawing.Font("Segoe UI", 10.5F);

            lblReportType.Text = "Report Type";
            lblReportType.Font = lblFont;
            lblReportType.ForeColor = lblColor;
            lblReportType.Dock = DockStyle.Fill;
            lblReportType.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            pnlFilterFields.Controls.Add(lblReportType, 0, 0);

            cmbReportType.Dock = DockStyle.Fill;
            cmbReportType.Font = inputFont;
            cmbReportType.FormattingEnabled = true;
            cmbReportType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbReportType.Items.AddRange(new object[] { "Revenue Summary", "Occupancy Report", "Check-In / Check-Out Log", "Room Utilization", "Guest Activity" });
            pnlFilterFields.Controls.Add(cmbReportType, 0, 1);

            lblDateFrom.Text = "Date From";
            lblDateFrom.Font = lblFont;
            lblDateFrom.ForeColor = lblColor;
            lblDateFrom.Dock = DockStyle.Fill;
            lblDateFrom.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            pnlFilterFields.Controls.Add(lblDateFrom, 0, 2);

            dtpFrom.Dock = DockStyle.Fill;
            dtpFrom.Font = inputFont;
            dtpFrom.Format = DateTimePickerFormat.Short;
            pnlFilterFields.Controls.Add(dtpFrom, 0, 3);

            lblDateTo.Text = "Date To";
            lblDateTo.Font = lblFont;
            lblDateTo.ForeColor = lblColor;
            lblDateTo.Dock = DockStyle.Fill;
            lblDateTo.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            pnlFilterFields.Controls.Add(lblDateTo, 0, 4);

            dtpTo.Dock = DockStyle.Fill;
            dtpTo.Font = inputFont;
            dtpTo.Format = DateTimePickerFormat.Short;
            pnlFilterFields.Controls.Add(dtpTo, 0, 5);

            lblRoomType.Text = "Room Type";
            lblRoomType.Font = lblFont;
            lblRoomType.ForeColor = lblColor;
            lblRoomType.Dock = DockStyle.Fill;
            lblRoomType.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            pnlFilterFields.Controls.Add(lblRoomType, 0, 6);

            cmbRoomType.Dock = DockStyle.Fill;
            cmbRoomType.Font = inputFont;
            cmbRoomType.FormattingEnabled = true;
            cmbRoomType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRoomType.Items.AddRange(new object[] { "All Room Types", "Single", "Double", "Suite", "Deluxe", "Family", "Penthouse" });
            pnlFilterFields.Controls.Add(cmbRoomType, 0, 7);

            lblStatus.Text = "Status Filter";
            lblStatus.Font = lblFont;
            lblStatus.ForeColor = lblColor;
            lblStatus.Dock = DockStyle.Fill;
            lblStatus.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            pnlFilterFields.Controls.Add(lblStatus, 0, 8);

            cmbStatus.Dock = DockStyle.Fill;
            cmbStatus.Font = inputFont;
            cmbStatus.FormattingEnabled = true;
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.Items.AddRange(new object[] { "All Statuses", "Confirmed", "Checked-In", "Checked-Out", "Paid", "Cancelled" });
            pnlFilterFields.Controls.Add(cmbStatus, 0, 9);

            pnlFilterScroll.Controls.Add(pnlFilterFields);
            pnlFilterContainer.Controls.Add(pnlFilterScroll);
            pnlFilterContainer.Controls.Add(tlpButtons);
            pnlFilterContainer.Controls.Add(lblFilterTitle);

            // ═══════════ RIGHT CARD — GRID (50%) ═══════════
            pnlGridContainer.Dock = DockStyle.Fill;
            pnlGridContainer.BackColor = System.Drawing.Color.White;
            pnlGridContainer.Margin = new Padding(10, 0, 0, 0);
            pnlGridContainer.Padding = new Padding(24, 18, 24, 18);

            lblGridTitle.Text = "Report Data";
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
            txtSearch.PlaceholderText = "Filter report records...";
            txtSearch.TextChanged += txtSearch_TextChanged;

            pnlSearchBar.Controls.Add(txtSearch);
            pnlSearchBar.Controls.Add(lblSearchIcon);

            dgvReport.Dock = DockStyle.Fill;
            dgvReport.BackgroundColor = System.Drawing.Color.White;
            dgvReport.BorderStyle = BorderStyle.None;
            dgvReport.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvReport.RowHeadersVisible = false;
            dgvReport.AllowUserToAddRows = false;
            dgvReport.AllowUserToDeleteRows = false;
            dgvReport.AllowUserToResizeRows = false;
            dgvReport.ReadOnly = true;
            dgvReport.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvReport.MultiSelect = false;
            dgvReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvReport.ColumnHeadersHeight = 42;
            dgvReport.RowTemplate.Height = 36;
            dgvReport.EnableHeadersVisualStyles = false;
            dgvReport.GridColor = System.Drawing.Color.FromArgb(230, 230, 230);

            rowStyle.Font = new System.Drawing.Font("Segoe UI", 10F);
            rowStyle.ForeColor = System.Drawing.Color.FromArgb(50, 50, 50);
            rowStyle.SelectionBackColor = System.Drawing.Color.FromArgb(200, 230, 226);
            rowStyle.SelectionForeColor = System.Drawing.Color.Black;
            rowStyle.Padding = new Padding(6, 0, 6, 0);
            dgvReport.DefaultCellStyle = rowStyle;

            altRowStyle.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            dgvReport.AlternatingRowsDefaultCellStyle = altRowStyle;

            headerStyle.BackColor = System.Drawing.Color.FromArgb(31, 58, 95);
            headerStyle.ForeColor = System.Drawing.Color.White;
            headerStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            headerStyle.Padding = new Padding(6, 0, 6, 0);
            headerStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvReport.ColumnHeadersDefaultCellStyle = headerStyle;

            colDate.HeaderText = "Date";
            colDate.Name = "colDate";
            colDate.FillWeight = 75;

            colRefNo.HeaderText = "Ref #";
            colRefNo.Name = "colRefNo";
            colRefNo.FillWeight = 65;

            colCategory.HeaderText = "Category";
            colCategory.Name = "colCategory";
            colCategory.FillWeight = 85;

            colGuestOrRoom.HeaderText = "Guest / Room";
            colGuestOrRoom.Name = "colGuestOrRoom";
            colGuestOrRoom.FillWeight = 110;

            colDetails.HeaderText = "Details";
            colDetails.Name = "colDetails";
            colDetails.FillWeight = 140;

            colAmount.HeaderText = "Amount";
            colAmount.Name = "colAmount";
            colAmount.FillWeight = 75;

            colStatus.HeaderText = "Status";
            colStatus.Name = "colStatus";
            colStatus.FillWeight = 75;

            dgvReport.Columns.AddRange(new DataGridViewColumn[] {
                colDate, colRefNo, colCategory, colGuestOrRoom, colDetails, colAmount, colStatus
            });

            pnlGridContainer.Controls.Add(dgvReport);
            pnlGridContainer.Controls.Add(pnlSearchBar);
            pnlGridContainer.Controls.Add(lblGridTitle);

            // ──────────── FORM ────────────
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new System.Drawing.Size(1200, 720);
            Controls.Add(pnlBody);
            Controls.Add(pnlHeader);
            Name = "Reports";
            Text = "Reports & Analytics — StaySync";
            Load += Reports_Load;

            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlBody.ResumeLayout(false);
            tlpKpiCards.ResumeLayout(false);
            pnlCardRevenue.ResumeLayout(false);
            pnlCardRevenue.PerformLayout();
            pnlCardBookings.ResumeLayout(false);
            pnlCardBookings.PerformLayout();
            pnlCardOccupancy.ResumeLayout(false);
            pnlCardOccupancy.PerformLayout();
            pnlCardAvailable.ResumeLayout(false);
            pnlCardAvailable.PerformLayout();
            tlpMain.ResumeLayout(false);
            pnlFilterContainer.ResumeLayout(false);
            pnlFilterScroll.ResumeLayout(false);
            pnlFilterScroll.PerformLayout();
            pnlFilterFields.ResumeLayout(false);
            pnlFilterFields.PerformLayout();
            tlpButtons.ResumeLayout(false);
            pnlGridContainer.ResumeLayout(false);
            pnlGridContainer.PerformLayout();
            pnlSearchBar.ResumeLayout(false);
            pnlSearchBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReport).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private Label lblTitle;
        private Button btnBack;
        private Panel pnlBody;

        private TableLayoutPanel tlpKpiCards;
        private Panel pnlCardRevenue;
        private Panel pnlCardRevenueAccent;
        private Label lblCardRevenueTitle;
        private Label lblCardRevenueValue;
        private Panel pnlCardBookings;
        private Panel pnlCardBookingsAccent;
        private Label lblCardBookingsTitle;
        private Label lblCardBookingsValue;
        private Panel pnlCardOccupancy;
        private Panel pnlCardOccupancyAccent;
        private Label lblCardOccupancyTitle;
        private Label lblCardOccupancyValue;
        private Panel pnlCardAvailable;
        private Panel pnlCardAvailableAccent;
        private Label lblCardAvailableTitle;
        private Label lblCardAvailableValue;

        private TableLayoutPanel tlpMain;
        private Panel pnlFilterContainer;
        private Label lblFilterTitle;
        private Panel pnlFilterScroll;
        private TableLayoutPanel pnlFilterFields;
        private Label lblReportType;
        private ComboBox cmbReportType;
        private Label lblDateFrom;
        private DateTimePicker dtpFrom;
        private Label lblDateTo;
        private DateTimePicker dtpTo;
        private Label lblRoomType;
        private ComboBox cmbRoomType;
        private Label lblStatus;
        private ComboBox cmbStatus;
        private TableLayoutPanel tlpButtons;
        private Button btnGenerate;
        private Button btnExport;
        private Button btnPrint;

        private Panel pnlGridContainer;
        private Label lblGridTitle;
        private Panel pnlSearchBar;
        private Label lblSearchIcon;
        private TextBox txtSearch;
        private DataGridView dgvReport;
        private DataGridViewTextBoxColumn colDate;
        private DataGridViewTextBoxColumn colRefNo;
        private DataGridViewTextBoxColumn colCategory;
        private DataGridViewTextBoxColumn colGuestOrRoom;
        private DataGridViewTextBoxColumn colDetails;
        private DataGridViewTextBoxColumn colAmount;
        private DataGridViewTextBoxColumn colStatus;
    }
}

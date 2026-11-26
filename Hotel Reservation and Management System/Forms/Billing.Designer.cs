namespace Hotel_Reservation_and_Management_System
{
    partial class Billing
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
            lblInvoiceNo = new Label();
            txtInvoiceNo = new TextBox();
            lblReservationId = new Label();
            txtReservationId = new TextBox();
            lblGuestName = new Label();
            txtGuestName = new TextBox();
            lblRoomCharges = new Label();
            txtRoomCharges = new TextBox();
            lblServiceCharges = new Label();
            txtServiceCharges = new TextBox();
            lblDiscount = new Label();
            txtDiscount = new TextBox();
            lblTax = new Label();
            txtTax = new TextBox();
            lblTotalAmount = new Label();
            txtTotalAmount = new TextBox();
            lblPaymentMethod = new Label();
            cmbPaymentMethod = new ComboBox();
            lblPaymentStatus = new Label();
            cmbPaymentStatus = new ComboBox();
            tlpButtons = new TableLayoutPanel();
            btnPay = new Button();
            btnPrint = new Button();
            btnClear = new Button();

            pnlGridContainer = new Panel();
            lblGridTitle = new Label();
            pnlSearchBar = new Panel();
            lblSearchIcon = new Label();
            txtSearch = new TextBox();
            pnlFilterSpacer = new Panel();
            cmbFilterStatus = new ComboBox();
            dgvInvoices = new DataGridView();
            colInvoiceNo = new DataGridViewTextBoxColumn();
            colResId = new DataGridViewTextBoxColumn();
            colGuestName = new DataGridViewTextBoxColumn();
            colRoomNumber = new DataGridViewTextBoxColumn();
            colRoomCharges = new DataGridViewTextBoxColumn();
            colExtras = new DataGridViewTextBoxColumn();
            colTotal = new DataGridViewTextBoxColumn();
            colMethod = new DataGridViewTextBoxColumn();
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
            ((System.ComponentModel.ISupportInitialize)dgvInvoices).BeginInit();
            SuspendLayout();

            // ──────────── HEADER ────────────
            pnlHeader.BackColor = System.Drawing.Color.FromArgb(31, 58, 95);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Height = 70;
            pnlHeader.Padding = new Padding(24, 15, 24, 15);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Controls.Add(btnBack);

            lblTitle.Text = "Billing & Invoices";
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

            lblFormTitle.Text = "Invoice & Payment Details";
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
            tlpButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 36F));
            tlpButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 34F));
            tlpButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tlpButtons.RowCount = 1;
            tlpButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));

            btnPay.Text = "💳  Process Payment";
            btnPay.Dock = DockStyle.Fill;
            btnPay.Margin = new Padding(0, 0, 8, 0);
            btnPay.FlatStyle = FlatStyle.Flat;
            btnPay.FlatAppearance.BorderSize = 0;
            btnPay.BackColor = System.Drawing.Color.FromArgb(42, 157, 143);
            btnPay.ForeColor = System.Drawing.Color.White;
            btnPay.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            btnPay.Cursor = Cursors.Hand;
            btnPay.Click += btnPay_Click;

            btnPrint.Text = "🖨  Print Receipt";
            btnPrint.Dock = DockStyle.Fill;
            btnPrint.Margin = new Padding(0, 0, 8, 0);
            btnPrint.FlatStyle = FlatStyle.Flat;
            btnPrint.FlatAppearance.BorderSize = 0;
            btnPrint.BackColor = System.Drawing.Color.FromArgb(31, 58, 95);
            btnPrint.ForeColor = System.Drawing.Color.White;
            btnPrint.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            btnPrint.Cursor = Cursors.Hand;
            btnPrint.Click += btnPrint_Click;

            btnClear.Text = "✖  Clear";
            btnClear.Dock = DockStyle.Fill;
            btnClear.Margin = new Padding(0);
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(31, 58, 95);
            btnClear.BackColor = System.Drawing.Color.White;
            btnClear.ForeColor = System.Drawing.Color.FromArgb(31, 58, 95);
            btnClear.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            btnClear.Cursor = Cursors.Hand;
            btnClear.Click += btnClear_Click;

            tlpButtons.Controls.Add(btnPay, 0, 0);
            tlpButtons.Controls.Add(btnPrint, 1, 0);
            tlpButtons.Controls.Add(btnClear, 2, 0);

            pnlFormScroll.Dock = DockStyle.Fill;
            pnlFormScroll.AutoScroll = true;
            pnlFormScroll.Padding = new Padding(0, 4, 4, 4);

            pnlFormFields.Dock = DockStyle.Top;
            pnlFormFields.AutoSize = true;
            pnlFormFields.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            pnlFormFields.ColumnCount = 1;
            pnlFormFields.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            pnlFormFields.RowCount = 20;
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
            pnlFormFields.RowStyles.Add(new RowStyle(SizeType.Absolute, 24F));
            pnlFormFields.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));

            System.Drawing.Font lblFont = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            System.Drawing.Color lblColor = System.Drawing.Color.FromArgb(80, 80, 80);
            System.Drawing.Font inputFont = new System.Drawing.Font("Segoe UI", 10.5F);

            lblInvoiceNo.Text = "Invoice #";
            lblInvoiceNo.Font = lblFont;
            lblInvoiceNo.ForeColor = lblColor;
            lblInvoiceNo.Dock = DockStyle.Fill;
            lblInvoiceNo.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            pnlFormFields.Controls.Add(lblInvoiceNo, 0, 0);

            txtInvoiceNo.Dock = DockStyle.Fill;
            txtInvoiceNo.Font = inputFont;
            txtInvoiceNo.ReadOnly = true;
            txtInvoiceNo.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);
            txtInvoiceNo.PlaceholderText = "Auto-generated";
            pnlFormFields.Controls.Add(txtInvoiceNo, 0, 1);

            lblReservationId.Text = "Reservation #";
            lblReservationId.Font = lblFont;
            lblReservationId.ForeColor = lblColor;
            lblReservationId.Dock = DockStyle.Fill;
            lblReservationId.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            pnlFormFields.Controls.Add(lblReservationId, 0, 2);

            txtReservationId.Dock = DockStyle.Fill;
            txtReservationId.Font = inputFont;
            txtReservationId.ReadOnly = true;
            txtReservationId.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);
            pnlFormFields.Controls.Add(txtReservationId, 0, 3);

            lblGuestName.Text = "Guest Name";
            lblGuestName.Font = lblFont;
            lblGuestName.ForeColor = lblColor;
            lblGuestName.Dock = DockStyle.Fill;
            lblGuestName.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            pnlFormFields.Controls.Add(lblGuestName, 0, 4);

            txtGuestName.Dock = DockStyle.Fill;
            txtGuestName.Font = inputFont;
            txtGuestName.ReadOnly = true;
            txtGuestName.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);
            pnlFormFields.Controls.Add(txtGuestName, 0, 5);

            lblRoomCharges.Text = "Room Charges ($)";
            lblRoomCharges.Font = lblFont;
            lblRoomCharges.ForeColor = lblColor;
            lblRoomCharges.Dock = DockStyle.Fill;
            lblRoomCharges.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            pnlFormFields.Controls.Add(lblRoomCharges, 0, 6);

            txtRoomCharges.Dock = DockStyle.Fill;
            txtRoomCharges.Font = inputFont;
            txtRoomCharges.ReadOnly = true;
            txtRoomCharges.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);
            pnlFormFields.Controls.Add(txtRoomCharges, 0, 7);

            lblServiceCharges.Text = "Additional Services / Extras ($)";
            lblServiceCharges.Font = lblFont;
            lblServiceCharges.ForeColor = lblColor;
            lblServiceCharges.Dock = DockStyle.Fill;
            lblServiceCharges.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            pnlFormFields.Controls.Add(lblServiceCharges, 0, 8);

            txtServiceCharges.Dock = DockStyle.Fill;
            txtServiceCharges.Font = inputFont;
            txtServiceCharges.PlaceholderText = "e.g. 0.00";
            pnlFormFields.Controls.Add(txtServiceCharges, 0, 9);

            lblDiscount.Text = "Discount ($)";
            lblDiscount.Font = lblFont;
            lblDiscount.ForeColor = lblColor;
            lblDiscount.Dock = DockStyle.Fill;
            lblDiscount.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            pnlFormFields.Controls.Add(lblDiscount, 0, 10);

            txtDiscount.Dock = DockStyle.Fill;
            txtDiscount.Font = inputFont;
            txtDiscount.PlaceholderText = "e.g. 0.00";
            pnlFormFields.Controls.Add(txtDiscount, 0, 11);

            lblTax.Text = "Tax / VAT ($)";
            lblTax.Font = lblFont;
            lblTax.ForeColor = lblColor;
            lblTax.Dock = DockStyle.Fill;
            lblTax.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            pnlFormFields.Controls.Add(lblTax, 0, 12);

            txtTax.Dock = DockStyle.Fill;
            txtTax.Font = inputFont;
            txtTax.ReadOnly = true;
            txtTax.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);
            pnlFormFields.Controls.Add(txtTax, 0, 13);

            lblTotalAmount.Text = "Grand Total ($)";
            lblTotalAmount.Font = lblFont;
            lblTotalAmount.ForeColor = System.Drawing.Color.FromArgb(31, 58, 95);
            lblTotalAmount.Dock = DockStyle.Fill;
            lblTotalAmount.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            pnlFormFields.Controls.Add(lblTotalAmount, 0, 14);

            txtTotalAmount.Dock = DockStyle.Fill;
            txtTotalAmount.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            txtTotalAmount.ForeColor = System.Drawing.Color.FromArgb(31, 58, 95);
            txtTotalAmount.ReadOnly = true;
            txtTotalAmount.BackColor = System.Drawing.Color.FromArgb(238, 245, 244);
            pnlFormFields.Controls.Add(txtTotalAmount, 0, 15);

            lblPaymentMethod.Text = "Payment Method";
            lblPaymentMethod.Font = lblFont;
            lblPaymentMethod.ForeColor = lblColor;
            lblPaymentMethod.Dock = DockStyle.Fill;
            lblPaymentMethod.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            pnlFormFields.Controls.Add(lblPaymentMethod, 0, 16);

            cmbPaymentMethod.Dock = DockStyle.Fill;
            cmbPaymentMethod.Font = inputFont;
            cmbPaymentMethod.FormattingEnabled = true;
            cmbPaymentMethod.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPaymentMethod.Items.AddRange(new object[] { "Cash", "Credit Card", "Debit Card", "Bank Transfer", "E-Wallet" });
            pnlFormFields.Controls.Add(cmbPaymentMethod, 0, 17);

            lblPaymentStatus.Text = "Payment Status";
            lblPaymentStatus.Font = lblFont;
            lblPaymentStatus.ForeColor = lblColor;
            lblPaymentStatus.Dock = DockStyle.Fill;
            lblPaymentStatus.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            pnlFormFields.Controls.Add(lblPaymentStatus, 0, 18);

            cmbPaymentStatus.Dock = DockStyle.Fill;
            cmbPaymentStatus.Font = inputFont;
            cmbPaymentStatus.FormattingEnabled = true;
            cmbPaymentStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPaymentStatus.Items.AddRange(new object[] { "Unpaid", "Partial", "Paid", "Refunded" });
            pnlFormFields.Controls.Add(cmbPaymentStatus, 0, 19);

            pnlFormScroll.Controls.Add(pnlFormFields);
            pnlFormContainer.Controls.Add(pnlFormScroll);
            pnlFormContainer.Controls.Add(tlpButtons);
            pnlFormContainer.Controls.Add(lblFormTitle);

            // ═══════════ RIGHT CARD — GRID (50%) ═══════════
            pnlGridContainer.Dock = DockStyle.Fill;
            pnlGridContainer.BackColor = System.Drawing.Color.White;
            pnlGridContainer.Margin = new Padding(10, 0, 0, 0);
            pnlGridContainer.Padding = new Padding(24, 18, 24, 18);

            lblGridTitle.Text = "Invoices & Payment History";
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
            cmbFilterStatus.Width = 145;
            cmbFilterStatus.Font = new System.Drawing.Font("Segoe UI", 10F);
            cmbFilterStatus.FormattingEnabled = true;
            cmbFilterStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFilterStatus.Items.AddRange(new object[] { "All Statuses", "Unpaid", "Partial", "Paid", "Refunded" });

            txtSearch.Dock = DockStyle.Fill;
            txtSearch.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            txtSearch.PlaceholderText = "Search invoices by invoice #, reservation #, or guest...";
            txtSearch.TextChanged += txtSearch_TextChanged;

            pnlSearchBar.Controls.Add(txtSearch);
            pnlSearchBar.Controls.Add(pnlFilterSpacer);
            pnlSearchBar.Controls.Add(cmbFilterStatus);
            pnlSearchBar.Controls.Add(lblSearchIcon);

            dgvInvoices.Dock = DockStyle.Fill;
            dgvInvoices.BackgroundColor = System.Drawing.Color.White;
            dgvInvoices.BorderStyle = BorderStyle.None;
            dgvInvoices.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvInvoices.RowHeadersVisible = false;
            dgvInvoices.AllowUserToAddRows = false;
            dgvInvoices.AllowUserToDeleteRows = false;
            dgvInvoices.AllowUserToResizeRows = false;
            dgvInvoices.ReadOnly = true;
            dgvInvoices.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvInvoices.MultiSelect = false;
            dgvInvoices.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvInvoices.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvInvoices.ColumnHeadersHeight = 42;
            dgvInvoices.RowTemplate.Height = 36;
            dgvInvoices.EnableHeadersVisualStyles = false;
            dgvInvoices.GridColor = System.Drawing.Color.FromArgb(230, 230, 230);

            rowStyle.Font = new System.Drawing.Font("Segoe UI", 10F);
            rowStyle.ForeColor = System.Drawing.Color.FromArgb(50, 50, 50);
            rowStyle.SelectionBackColor = System.Drawing.Color.FromArgb(200, 230, 226);
            rowStyle.SelectionForeColor = System.Drawing.Color.Black;
            rowStyle.Padding = new Padding(6, 0, 6, 0);
            dgvInvoices.DefaultCellStyle = rowStyle;

            altRowStyle.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            dgvInvoices.AlternatingRowsDefaultCellStyle = altRowStyle;

            headerStyle.BackColor = System.Drawing.Color.FromArgb(31, 58, 95);
            headerStyle.ForeColor = System.Drawing.Color.White;
            headerStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            headerStyle.Padding = new Padding(6, 0, 6, 0);
            headerStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvInvoices.ColumnHeadersDefaultCellStyle = headerStyle;

            dgvInvoices.CellClick += dgvInvoices_CellClick;

            colInvoiceNo.HeaderText = "Invoice #";
            colInvoiceNo.Name = "colInvoiceNo";
            colInvoiceNo.FillWeight = 70;

            colResId.HeaderText = "Res #";
            colResId.Name = "colResId";
            colResId.FillWeight = 60;

            colGuestName.HeaderText = "Guest Name";
            colGuestName.Name = "colGuestName";
            colGuestName.FillWeight = 110;

            colRoomNumber.HeaderText = "Room #";
            colRoomNumber.Name = "colRoomNumber";
            colRoomNumber.FillWeight = 60;

            colRoomCharges.HeaderText = "Room";
            colRoomCharges.Name = "colRoomCharges";
            colRoomCharges.FillWeight = 70;

            colExtras.HeaderText = "Extras";
            colExtras.Name = "colExtras";
            colExtras.FillWeight = 65;

            colTotal.HeaderText = "Total";
            colTotal.Name = "colTotal";
            colTotal.FillWeight = 75;

            colMethod.HeaderText = "Method";
            colMethod.Name = "colMethod";
            colMethod.FillWeight = 80;

            colStatus.HeaderText = "Status";
            colStatus.Name = "colStatus";
            colStatus.FillWeight = 70;

            dgvInvoices.Columns.AddRange(new DataGridViewColumn[] {
                colInvoiceNo, colResId, colGuestName, colRoomNumber, colRoomCharges, colExtras, colTotal, colMethod, colStatus
            });

            pnlGridContainer.Controls.Add(dgvInvoices);
            pnlGridContainer.Controls.Add(pnlSearchBar);
            pnlGridContainer.Controls.Add(lblGridTitle);

            // ──────────── FORM ────────────
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new System.Drawing.Size(1200, 720);
            Controls.Add(pnlBody);
            Controls.Add(pnlHeader);
            Name = "Billing";
            Text = "Billing & Invoices — StaySync";
            Load += Billing_Load;

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
            ((System.ComponentModel.ISupportInitialize)dgvInvoices).EndInit();
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
        private Label lblInvoiceNo;
        private TextBox txtInvoiceNo;
        private Label lblReservationId;
        private TextBox txtReservationId;
        private Label lblGuestName;
        private TextBox txtGuestName;
        private Label lblRoomCharges;
        private TextBox txtRoomCharges;
        private Label lblServiceCharges;
        private TextBox txtServiceCharges;
        private Label lblDiscount;
        private TextBox txtDiscount;
        private Label lblTax;
        private TextBox txtTax;
        private Label lblTotalAmount;
        private TextBox txtTotalAmount;
        private Label lblPaymentMethod;
        private ComboBox cmbPaymentMethod;
        private Label lblPaymentStatus;
        private ComboBox cmbPaymentStatus;
        private TableLayoutPanel tlpButtons;
        private Button btnPay;
        private Button btnPrint;
        private Button btnClear;

        private Panel pnlGridContainer;
        private Label lblGridTitle;
        private Panel pnlSearchBar;
        private Label lblSearchIcon;
        private TextBox txtSearch;
        private Panel pnlFilterSpacer;
        private ComboBox cmbFilterStatus;
        private DataGridView dgvInvoices;
        private DataGridViewTextBoxColumn colInvoiceNo;
        private DataGridViewTextBoxColumn colResId;
        private DataGridViewTextBoxColumn colGuestName;
        private DataGridViewTextBoxColumn colRoomNumber;
        private DataGridViewTextBoxColumn colRoomCharges;
        private DataGridViewTextBoxColumn colExtras;
        private DataGridViewTextBoxColumn colTotal;
        private DataGridViewTextBoxColumn colMethod;
        private DataGridViewTextBoxColumn colStatus;
    }
}

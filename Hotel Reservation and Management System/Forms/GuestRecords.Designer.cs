namespace Hotel_Reservation_and_Management_System
{
    partial class GuestRecords
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
            lblGuestId = new Label();
            txtGuestId = new TextBox();
            lblFullName = new Label();
            txtFullName = new TextBox();
            lblPhone = new Label();
            txtPhone = new TextBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblIdType = new Label();
            cmbIdType = new ComboBox();
            lblIdNumber = new Label();
            txtIdNumber = new TextBox();
            lblNationality = new Label();
            txtNationality = new TextBox();
            lblAddress = new Label();
            txtAddress = new TextBox();
            tlpButtons = new TableLayoutPanel();
            btnSave = new Button();
            btnDelete = new Button();
            btnClear = new Button();

            pnlGridContainer = new Panel();
            lblGridTitle = new Label();
            pnlSearchBar = new Panel();
            lblSearchIcon = new Label();
            txtSearch = new TextBox();
            dgvGuests = new DataGridView();
            colGuestId = new DataGridViewTextBoxColumn();
            colFullName = new DataGridViewTextBoxColumn();
            colPhone = new DataGridViewTextBoxColumn();
            colEmail = new DataGridViewTextBoxColumn();
            colIdType = new DataGridViewTextBoxColumn();
            colIdNumber = new DataGridViewTextBoxColumn();
            colNationality = new DataGridViewTextBoxColumn();
            colTotalStays = new DataGridViewTextBoxColumn();

            pnlHeader.SuspendLayout();
            pnlBody.SuspendLayout();
            tlpMain.SuspendLayout();
            pnlFormContainer.SuspendLayout();
            pnlFormScroll.SuspendLayout();
            pnlFormFields.SuspendLayout();
            tlpButtons.SuspendLayout();
            pnlGridContainer.SuspendLayout();
            pnlSearchBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGuests).BeginInit();
            SuspendLayout();

            // ──────────── HEADER ────────────
            pnlHeader.BackColor = System.Drawing.Color.FromArgb(31, 58, 95);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Height = 70;
            pnlHeader.Padding = new Padding(24, 15, 24, 15);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Controls.Add(btnBack);

            lblTitle.Text = "Guest Records";
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

            lblFormTitle.Text = "Guest Profile";
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
            tlpButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 32F));
            tlpButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 32F));
            tlpButtons.RowCount = 1;
            tlpButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));

            btnSave.Text = "➕  Save Guest";
            btnSave.Dock = DockStyle.Fill;
            btnSave.Margin = new Padding(0, 0, 8, 0);
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.BackColor = System.Drawing.Color.FromArgb(42, 157, 143);
            btnSave.ForeColor = System.Drawing.Color.White;
            btnSave.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            btnSave.Cursor = Cursors.Hand;
            btnSave.Click += btnSave_Click;

            btnDelete.Text = "🗑  Delete";
            btnDelete.Dock = DockStyle.Fill;
            btnDelete.Margin = new Padding(0, 0, 8, 0);
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.BackColor = System.Drawing.Color.FromArgb(200, 60, 60);
            btnDelete.ForeColor = System.Drawing.Color.White;
            btnDelete.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.Click += btnDelete_Click;

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

            tlpButtons.Controls.Add(btnSave, 0, 0);
            tlpButtons.Controls.Add(btnDelete, 1, 0);
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

            lblGuestId.Text = "Guest ID";
            lblGuestId.Font = lblFont;
            lblGuestId.ForeColor = lblColor;
            lblGuestId.Dock = DockStyle.Fill;
            lblGuestId.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            pnlFormFields.Controls.Add(lblGuestId, 0, 0);

            txtGuestId.Dock = DockStyle.Fill;
            txtGuestId.Font = inputFont;
            txtGuestId.ReadOnly = true;
            txtGuestId.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);
            txtGuestId.PlaceholderText = "Auto-generated";
            pnlFormFields.Controls.Add(txtGuestId, 0, 1);

            lblFullName.Text = "Full Name";
            lblFullName.Font = lblFont;
            lblFullName.ForeColor = lblColor;
            lblFullName.Dock = DockStyle.Fill;
            lblFullName.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            pnlFormFields.Controls.Add(lblFullName, 0, 2);

            txtFullName.Dock = DockStyle.Fill;
            txtFullName.Font = inputFont;
            txtFullName.PlaceholderText = "e.g. Maria Clara";
            pnlFormFields.Controls.Add(txtFullName, 0, 3);

            lblPhone.Text = "Phone Number";
            lblPhone.Font = lblFont;
            lblPhone.ForeColor = lblColor;
            lblPhone.Dock = DockStyle.Fill;
            lblPhone.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            pnlFormFields.Controls.Add(lblPhone, 0, 4);

            txtPhone.Dock = DockStyle.Fill;
            txtPhone.Font = inputFont;
            txtPhone.PlaceholderText = "e.g. +63 912 345 6789";
            pnlFormFields.Controls.Add(txtPhone, 0, 5);

            lblEmail.Text = "Email Address";
            lblEmail.Font = lblFont;
            lblEmail.ForeColor = lblColor;
            lblEmail.Dock = DockStyle.Fill;
            lblEmail.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            pnlFormFields.Controls.Add(lblEmail, 0, 6);

            txtEmail.Dock = DockStyle.Fill;
            txtEmail.Font = inputFont;
            txtEmail.PlaceholderText = "e.g. guest@email.com";
            pnlFormFields.Controls.Add(txtEmail, 0, 7);

            lblIdType.Text = "ID Type";
            lblIdType.Font = lblFont;
            lblIdType.ForeColor = lblColor;
            lblIdType.Dock = DockStyle.Fill;
            lblIdType.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            pnlFormFields.Controls.Add(lblIdType, 0, 8);

            cmbIdType.Dock = DockStyle.Fill;
            cmbIdType.Font = inputFont;
            cmbIdType.FormattingEnabled = true;
            cmbIdType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbIdType.Items.AddRange(new object[] { "National ID", "Passport", "Driver's License", "Company ID" });
            pnlFormFields.Controls.Add(cmbIdType, 0, 9);

            lblIdNumber.Text = "ID Number";
            lblIdNumber.Font = lblFont;
            lblIdNumber.ForeColor = lblColor;
            lblIdNumber.Dock = DockStyle.Fill;
            lblIdNumber.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            pnlFormFields.Controls.Add(lblIdNumber, 0, 10);

            txtIdNumber.Dock = DockStyle.Fill;
            txtIdNumber.Font = inputFont;
            txtIdNumber.PlaceholderText = "Enter ID number";
            pnlFormFields.Controls.Add(txtIdNumber, 0, 11);

            lblNationality.Text = "Nationality";
            lblNationality.Font = lblFont;
            lblNationality.ForeColor = lblColor;
            lblNationality.Dock = DockStyle.Fill;
            lblNationality.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            pnlFormFields.Controls.Add(lblNationality, 0, 12);

            txtNationality.Dock = DockStyle.Fill;
            txtNationality.Font = inputFont;
            txtNationality.PlaceholderText = "e.g. Filipino";
            pnlFormFields.Controls.Add(txtNationality, 0, 13);

            lblAddress.Text = "Home Address";
            lblAddress.Font = lblFont;
            lblAddress.ForeColor = lblColor;
            lblAddress.Dock = DockStyle.Fill;
            lblAddress.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            pnlFormFields.Controls.Add(lblAddress, 0, 14);

            txtAddress.Dock = DockStyle.Fill;
            txtAddress.Font = inputFont;
            txtAddress.Multiline = true;
            txtAddress.ScrollBars = ScrollBars.Vertical;
            txtAddress.PlaceholderText = "Street, City, Province / Country";
            pnlFormFields.Controls.Add(txtAddress, 0, 15);

            pnlFormScroll.Controls.Add(pnlFormFields);
            pnlFormContainer.Controls.Add(pnlFormScroll);
            pnlFormContainer.Controls.Add(tlpButtons);
            pnlFormContainer.Controls.Add(lblFormTitle);

            // ═══════════ RIGHT CARD — GRID (50%) ═══════════
            pnlGridContainer.Dock = DockStyle.Fill;
            pnlGridContainer.BackColor = System.Drawing.Color.White;
            pnlGridContainer.Margin = new Padding(10, 0, 0, 0);
            pnlGridContainer.Padding = new Padding(24, 18, 24, 18);

            lblGridTitle.Text = "Guest Directory";
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
            txtSearch.PlaceholderText = "Search guests by name, phone, email, or ID number...";
            txtSearch.TextChanged += txtSearch_TextChanged;

            pnlSearchBar.Controls.Add(txtSearch);
            pnlSearchBar.Controls.Add(lblSearchIcon);

            dgvGuests.Dock = DockStyle.Fill;
            dgvGuests.BackgroundColor = System.Drawing.Color.White;
            dgvGuests.BorderStyle = BorderStyle.None;
            dgvGuests.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvGuests.RowHeadersVisible = false;
            dgvGuests.AllowUserToAddRows = false;
            dgvGuests.AllowUserToDeleteRows = false;
            dgvGuests.AllowUserToResizeRows = false;
            dgvGuests.ReadOnly = true;
            dgvGuests.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvGuests.MultiSelect = false;
            dgvGuests.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvGuests.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvGuests.ColumnHeadersHeight = 42;
            dgvGuests.RowTemplate.Height = 36;
            dgvGuests.EnableHeadersVisualStyles = false;
            dgvGuests.GridColor = System.Drawing.Color.FromArgb(230, 230, 230);

            rowStyle.Font = new System.Drawing.Font("Segoe UI", 10F);
            rowStyle.ForeColor = System.Drawing.Color.FromArgb(50, 50, 50);
            rowStyle.SelectionBackColor = System.Drawing.Color.FromArgb(200, 230, 226);
            rowStyle.SelectionForeColor = System.Drawing.Color.Black;
            rowStyle.Padding = new Padding(6, 0, 6, 0);
            dgvGuests.DefaultCellStyle = rowStyle;

            altRowStyle.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            dgvGuests.AlternatingRowsDefaultCellStyle = altRowStyle;

            headerStyle.BackColor = System.Drawing.Color.FromArgb(31, 58, 95);
            headerStyle.ForeColor = System.Drawing.Color.White;
            headerStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            headerStyle.Padding = new Padding(6, 0, 6, 0);
            headerStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvGuests.ColumnHeadersDefaultCellStyle = headerStyle;

            dgvGuests.CellClick += dgvGuests_CellClick;

            colGuestId.HeaderText = "ID";
            colGuestId.Name = "colGuestId";
            colGuestId.FillWeight = 45;

            colFullName.HeaderText = "Full Name";
            colFullName.Name = "colFullName";
            colFullName.FillWeight = 110;

            colPhone.HeaderText = "Phone";
            colPhone.Name = "colPhone";
            colPhone.FillWeight = 90;

            colEmail.HeaderText = "Email";
            colEmail.Name = "colEmail";
            colEmail.FillWeight = 120;

            colIdType.HeaderText = "ID Type";
            colIdType.Name = "colIdType";
            colIdType.FillWeight = 80;

            colIdNumber.HeaderText = "ID #";
            colIdNumber.Name = "colIdNumber";
            colIdNumber.FillWeight = 85;

            colNationality.HeaderText = "Nationality";
            colNationality.Name = "colNationality";
            colNationality.FillWeight = 75;

            colTotalStays.HeaderText = "Stays";
            colTotalStays.Name = "colTotalStays";
            colTotalStays.FillWeight = 50;

            dgvGuests.Columns.AddRange(new DataGridViewColumn[] {
                colGuestId, colFullName, colPhone, colEmail, colIdType, colIdNumber, colNationality, colTotalStays
            });

            pnlGridContainer.Controls.Add(dgvGuests);
            pnlGridContainer.Controls.Add(pnlSearchBar);
            pnlGridContainer.Controls.Add(lblGridTitle);

            // ──────────── FORM ────────────
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new System.Drawing.Size(1200, 720);
            Controls.Add(pnlBody);
            Controls.Add(pnlHeader);
            Name = "GuestRecords";
            Text = "Guest Records — StaySync";
            Load += GuestRecords_Load;

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
            ((System.ComponentModel.ISupportInitialize)dgvGuests).EndInit();
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
        private Label lblGuestId;
        private TextBox txtGuestId;
        private Label lblFullName;
        private TextBox txtFullName;
        private Label lblPhone;
        private TextBox txtPhone;
        private Label lblEmail;
        private TextBox txtEmail;
        private Label lblIdType;
        private ComboBox cmbIdType;
        private Label lblIdNumber;
        private TextBox txtIdNumber;
        private Label lblNationality;
        private TextBox txtNationality;
        private Label lblAddress;
        private TextBox txtAddress;
        private TableLayoutPanel tlpButtons;
        private Button btnSave;
        private Button btnDelete;
        private Button btnClear;

        private Panel pnlGridContainer;
        private Label lblGridTitle;
        private Panel pnlSearchBar;
        private Label lblSearchIcon;
        private TextBox txtSearch;
        private DataGridView dgvGuests;
        private DataGridViewTextBoxColumn colGuestId;
        private DataGridViewTextBoxColumn colFullName;
        private DataGridViewTextBoxColumn colPhone;
        private DataGridViewTextBoxColumn colEmail;
        private DataGridViewTextBoxColumn colIdType;
        private DataGridViewTextBoxColumn colIdNumber;
        private DataGridViewTextBoxColumn colNationality;
        private DataGridViewTextBoxColumn colTotalStays;
    }
}

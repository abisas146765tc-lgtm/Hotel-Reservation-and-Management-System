namespace Hotel_Reservation_and_Management_System
{
    partial class RoomManagement
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
            lblRoomNumber = new Label();
            txtRoomNumber = new TextBox();
            lblRoomType = new Label();
            cmbRoomType = new ComboBox();
            lblStatus = new Label();
            cmbStatus = new ComboBox();
            lblCapacity = new Label();
            nudCapacity = new NumericUpDown();
            lblPrice = new Label();
            txtPrice = new TextBox();
            lblDescription = new Label();
            txtDescription = new TextBox();
            tlpButtons = new TableLayoutPanel();
            btnSave = new Button();
            btnDelete = new Button();
            btnClear = new Button();

            pnlGridContainer = new Panel();
            lblGridTitle = new Label();
            pnlSearchBar = new Panel();
            lblSearchIcon = new Label();
            txtSearch = new TextBox();
            dgvRooms = new DataGridView();
            colRoomNumber = new DataGridViewTextBoxColumn();
            colRoomType = new DataGridViewTextBoxColumn();
            colStatus = new DataGridViewTextBoxColumn();
            colCapacity = new DataGridViewTextBoxColumn();
            colPrice = new DataGridViewTextBoxColumn();
            colDescription = new DataGridViewTextBoxColumn();

            pnlHeader.SuspendLayout();
            pnlBody.SuspendLayout();
            tlpMain.SuspendLayout();
            pnlFormContainer.SuspendLayout();
            pnlFormScroll.SuspendLayout();
            pnlFormFields.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudCapacity).BeginInit();
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

            lblTitle.Text = "Room Management";
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

            lblFormTitle.Text = "Room Details";
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

            btnSave.Text = "➕  Add Room";
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

            // Scrollable form fields
            pnlFormScroll.Dock = DockStyle.Fill;
            pnlFormScroll.AutoScroll = true;
            pnlFormScroll.Padding = new Padding(0, 4, 4, 4);

            pnlFormFields.Dock = DockStyle.Top;
            pnlFormFields.AutoSize = true;
            pnlFormFields.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            pnlFormFields.ColumnCount = 1;
            pnlFormFields.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            pnlFormFields.RowCount = 12;
            pnlFormFields.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            pnlFormFields.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
            pnlFormFields.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            pnlFormFields.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
            pnlFormFields.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            pnlFormFields.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
            pnlFormFields.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            pnlFormFields.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
            pnlFormFields.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            pnlFormFields.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
            pnlFormFields.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            pnlFormFields.RowStyles.Add(new RowStyle(SizeType.Absolute, 96F));

            System.Drawing.Font lblFont = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            System.Drawing.Color lblColor = System.Drawing.Color.FromArgb(80, 80, 80);
            System.Drawing.Font inputFont = new System.Drawing.Font("Segoe UI", 10.5F);

            lblRoomNumber.Text = "Room Number";
            lblRoomNumber.Font = lblFont;
            lblRoomNumber.ForeColor = lblColor;
            lblRoomNumber.Dock = DockStyle.Fill;
            lblRoomNumber.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            pnlFormFields.Controls.Add(lblRoomNumber, 0, 0);

            txtRoomNumber.Dock = DockStyle.Fill;
            txtRoomNumber.Font = inputFont;
            txtRoomNumber.PlaceholderText = "e.g. 101";
            pnlFormFields.Controls.Add(txtRoomNumber, 0, 1);

            lblRoomType.Text = "Room Type";
            lblRoomType.Font = lblFont;
            lblRoomType.ForeColor = lblColor;
            lblRoomType.Dock = DockStyle.Fill;
            lblRoomType.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            pnlFormFields.Controls.Add(lblRoomType, 0, 2);

            cmbRoomType.Dock = DockStyle.Fill;
            cmbRoomType.Font = inputFont;
            cmbRoomType.FormattingEnabled = true;
            cmbRoomType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRoomType.Items.AddRange(new object[] { "Single", "Double", "Suite", "Deluxe", "Family", "Penthouse" });
            pnlFormFields.Controls.Add(cmbRoomType, 0, 3);

            lblStatus.Text = "Status";
            lblStatus.Font = lblFont;
            lblStatus.ForeColor = lblColor;
            lblStatus.Dock = DockStyle.Fill;
            lblStatus.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            pnlFormFields.Controls.Add(lblStatus, 0, 4);

            cmbStatus.Dock = DockStyle.Fill;
            cmbStatus.Font = inputFont;
            cmbStatus.FormattingEnabled = true;
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.Items.AddRange(new object[] { "Available", "Occupied", "Maintenance", "Reserved" });
            pnlFormFields.Controls.Add(cmbStatus, 0, 5);

            lblCapacity.Text = "Capacity (Guests)";
            lblCapacity.Font = lblFont;
            lblCapacity.ForeColor = lblColor;
            lblCapacity.Dock = DockStyle.Fill;
            lblCapacity.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            pnlFormFields.Controls.Add(lblCapacity, 0, 6);

            nudCapacity.Dock = DockStyle.Fill;
            nudCapacity.Font = inputFont;
            nudCapacity.Minimum = 1;
            nudCapacity.Maximum = 20;
            nudCapacity.Value = 1;
            pnlFormFields.Controls.Add(nudCapacity, 0, 7);

            lblPrice.Text = "Price Per Night ($)";
            lblPrice.Font = lblFont;
            lblPrice.ForeColor = lblColor;
            lblPrice.Dock = DockStyle.Fill;
            lblPrice.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            pnlFormFields.Controls.Add(lblPrice, 0, 8);

            txtPrice.Dock = DockStyle.Fill;
            txtPrice.Font = inputFont;
            txtPrice.PlaceholderText = "e.g. 120.00";
            pnlFormFields.Controls.Add(txtPrice, 0, 9);

            lblDescription.Text = "Description / Notes";
            lblDescription.Font = lblFont;
            lblDescription.ForeColor = lblColor;
            lblDescription.Dock = DockStyle.Fill;
            lblDescription.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            pnlFormFields.Controls.Add(lblDescription, 0, 10);

            txtDescription.Dock = DockStyle.Fill;
            txtDescription.Font = inputFont;
            txtDescription.Multiline = true;
            txtDescription.ScrollBars = ScrollBars.Vertical;
            txtDescription.PlaceholderText = "Floor, view, amenities...";
            pnlFormFields.Controls.Add(txtDescription, 0, 11);

            pnlFormScroll.Controls.Add(pnlFormFields);
            pnlFormContainer.Controls.Add(pnlFormScroll);
            pnlFormContainer.Controls.Add(tlpButtons);
            pnlFormContainer.Controls.Add(lblFormTitle);

            // ═══════════ RIGHT CARD — GRID (50%) ═══════════
            pnlGridContainer.Dock = DockStyle.Fill;
            pnlGridContainer.BackColor = System.Drawing.Color.White;
            pnlGridContainer.Margin = new Padding(10, 0, 0, 0);
            pnlGridContainer.Padding = new Padding(24, 18, 24, 18);

            lblGridTitle.Text = "Room Inventory";
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
            txtSearch.PlaceholderText = "Search rooms...";
            txtSearch.TextChanged += txtSearch_TextChanged;

            pnlSearchBar.Controls.Add(txtSearch);
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

            colRoomType.HeaderText = "Type";
            colRoomType.Name = "colRoomType";
            colRoomType.FillWeight = 80;

            colStatus.HeaderText = "Status";
            colStatus.Name = "colStatus";
            colStatus.FillWeight = 90;

            colCapacity.HeaderText = "Capacity";
            colCapacity.Name = "colCapacity";
            colCapacity.FillWeight = 70;

            colPrice.HeaderText = "Price/Night";
            colPrice.Name = "colPrice";
            colPrice.FillWeight = 85;

            colDescription.HeaderText = "Description";
            colDescription.Name = "colDescription";
            colDescription.FillWeight = 140;

            dgvRooms.Columns.AddRange(new DataGridViewColumn[] {
                colRoomNumber, colRoomType, colStatus, colCapacity, colPrice, colDescription
            });

            pnlGridContainer.Controls.Add(dgvRooms);
            pnlGridContainer.Controls.Add(pnlSearchBar);
            pnlGridContainer.Controls.Add(lblGridTitle);

            // ──────────── FORM ────────────
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new System.Drawing.Size(1200, 720);
            Controls.Add(pnlBody);
            Controls.Add(pnlHeader);
            Name = "RoomManagement";
            Text = "Room Management — StaySync";
            Load += RoomManagement_Load;

            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlBody.ResumeLayout(false);
            tlpMain.ResumeLayout(false);
            pnlFormContainer.ResumeLayout(false);
            pnlFormScroll.ResumeLayout(false);
            pnlFormScroll.PerformLayout();
            pnlFormFields.ResumeLayout(false);
            pnlFormFields.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudCapacity).EndInit();
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
        private Label lblRoomNumber;
        private TextBox txtRoomNumber;
        private Label lblRoomType;
        private ComboBox cmbRoomType;
        private Label lblStatus;
        private ComboBox cmbStatus;
        private Label lblCapacity;
        private NumericUpDown nudCapacity;
        private Label lblPrice;
        private TextBox txtPrice;
        private Label lblDescription;
        private TextBox txtDescription;
        private TableLayoutPanel tlpButtons;
        private Button btnSave;
        private Button btnDelete;
        private Button btnClear;

        private Panel pnlGridContainer;
        private Label lblGridTitle;
        private Panel pnlSearchBar;
        private Label lblSearchIcon;
        private TextBox txtSearch;
        private DataGridView dgvRooms;
        private DataGridViewTextBoxColumn colRoomNumber;
        private DataGridViewTextBoxColumn colRoomType;
        private DataGridViewTextBoxColumn colStatus;
        private DataGridViewTextBoxColumn colCapacity;
        private DataGridViewTextBoxColumn colPrice;
        private DataGridViewTextBoxColumn colDescription;
    }
}

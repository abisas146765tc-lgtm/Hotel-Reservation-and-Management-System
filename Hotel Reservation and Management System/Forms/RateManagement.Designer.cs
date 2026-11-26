namespace Hotel_Reservation_and_Management_System
{
    partial class RateManagement
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
            lblRateId = new Label();
            txtRateId = new TextBox();
            lblRoomType = new Label();
            cmbRoomType = new ComboBox();
            lblSeason = new Label();
            cmbSeason = new ComboBox();
            lblBaseRate = new Label();
            txtBaseRate = new TextBox();
            lblWeekendSurcharge = new Label();
            nudWeekendSurcharge = new NumericUpDown();
            lblEffectiveFrom = new Label();
            dtpEffectiveFrom = new DateTimePicker();
            lblEffectiveTo = new Label();
            dtpEffectiveTo = new DateTimePicker();
            lblStatus = new Label();
            cmbStatus = new ComboBox();
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
            dgvRates = new DataGridView();
            colRateId = new DataGridViewTextBoxColumn();
            colRoomType = new DataGridViewTextBoxColumn();
            colSeason = new DataGridViewTextBoxColumn();
            colBaseRate = new DataGridViewTextBoxColumn();
            colWeekend = new DataGridViewTextBoxColumn();
            colEffectiveFrom = new DataGridViewTextBoxColumn();
            colEffectiveTo = new DataGridViewTextBoxColumn();
            colStatus = new DataGridViewTextBoxColumn();

            pnlHeader.SuspendLayout();
            pnlBody.SuspendLayout();
            tlpMain.SuspendLayout();
            pnlFormContainer.SuspendLayout();
            pnlFormScroll.SuspendLayout();
            pnlFormFields.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudWeekendSurcharge).BeginInit();
            tlpButtons.SuspendLayout();
            pnlGridContainer.SuspendLayout();
            pnlSearchBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRates).BeginInit();
            SuspendLayout();

            // ──────────── HEADER ────────────
            pnlHeader.BackColor = System.Drawing.Color.FromArgb(31, 58, 95);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Height = 70;
            pnlHeader.Padding = new Padding(24, 15, 24, 15);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Controls.Add(btnBack);

            lblTitle.Text = "Rate Management";
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

            lblFormTitle.Text = "Room Rate Configuration";
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

            btnSave.Text = "➕  Save Rate";
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
            pnlFormFields.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));

            System.Drawing.Font lblFont = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            System.Drawing.Color lblColor = System.Drawing.Color.FromArgb(80, 80, 80);
            System.Drawing.Font inputFont = new System.Drawing.Font("Segoe UI", 10.5F);

            lblRateId.Text = "Rate ID";
            lblRateId.Font = lblFont;
            lblRateId.ForeColor = lblColor;
            lblRateId.Dock = DockStyle.Fill;
            lblRateId.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            pnlFormFields.Controls.Add(lblRateId, 0, 0);

            txtRateId.Dock = DockStyle.Fill;
            txtRateId.Font = inputFont;
            txtRateId.ReadOnly = true;
            txtRateId.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);
            txtRateId.PlaceholderText = "Auto-generated";
            pnlFormFields.Controls.Add(txtRateId, 0, 1);

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

            lblSeason.Text = "Rate Tier / Season";
            lblSeason.Font = lblFont;
            lblSeason.ForeColor = lblColor;
            lblSeason.Dock = DockStyle.Fill;
            lblSeason.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            pnlFormFields.Controls.Add(lblSeason, 0, 4);

            cmbSeason.Dock = DockStyle.Fill;
            cmbSeason.Font = inputFont;
            cmbSeason.FormattingEnabled = true;
            cmbSeason.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSeason.Items.AddRange(new object[] { "Regular", "Peak / Holiday", "Off-Peak", "Weekend", "Corporate" });
            pnlFormFields.Controls.Add(cmbSeason, 0, 5);

            lblBaseRate.Text = "Base Nightly Rate ($)";
            lblBaseRate.Font = lblFont;
            lblBaseRate.ForeColor = lblColor;
            lblBaseRate.Dock = DockStyle.Fill;
            lblBaseRate.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            pnlFormFields.Controls.Add(lblBaseRate, 0, 6);

            txtBaseRate.Dock = DockStyle.Fill;
            txtBaseRate.Font = inputFont;
            txtBaseRate.PlaceholderText = "e.g. 120.00";
            pnlFormFields.Controls.Add(txtBaseRate, 0, 7);

            lblWeekendSurcharge.Text = "Weekend Surcharge (%)";
            lblWeekendSurcharge.Font = lblFont;
            lblWeekendSurcharge.ForeColor = lblColor;
            lblWeekendSurcharge.Dock = DockStyle.Fill;
            lblWeekendSurcharge.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            pnlFormFields.Controls.Add(lblWeekendSurcharge, 0, 8);

            nudWeekendSurcharge.Dock = DockStyle.Fill;
            nudWeekendSurcharge.Font = inputFont;
            nudWeekendSurcharge.Minimum = 0;
            nudWeekendSurcharge.Maximum = 200;
            nudWeekendSurcharge.Value = 0;
            pnlFormFields.Controls.Add(nudWeekendSurcharge, 0, 9);

            lblEffectiveFrom.Text = "Effective From";
            lblEffectiveFrom.Font = lblFont;
            lblEffectiveFrom.ForeColor = lblColor;
            lblEffectiveFrom.Dock = DockStyle.Fill;
            lblEffectiveFrom.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            pnlFormFields.Controls.Add(lblEffectiveFrom, 0, 10);

            dtpEffectiveFrom.Dock = DockStyle.Fill;
            dtpEffectiveFrom.Font = inputFont;
            dtpEffectiveFrom.Format = DateTimePickerFormat.Short;
            pnlFormFields.Controls.Add(dtpEffectiveFrom, 0, 11);

            lblEffectiveTo.Text = "Effective To";
            lblEffectiveTo.Font = lblFont;
            lblEffectiveTo.ForeColor = lblColor;
            lblEffectiveTo.Dock = DockStyle.Fill;
            lblEffectiveTo.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            pnlFormFields.Controls.Add(lblEffectiveTo, 0, 12);

            dtpEffectiveTo.Dock = DockStyle.Fill;
            dtpEffectiveTo.Font = inputFont;
            dtpEffectiveTo.Format = DateTimePickerFormat.Short;
            pnlFormFields.Controls.Add(dtpEffectiveTo, 0, 13);

            lblStatus.Text = "Status";
            lblStatus.Font = lblFont;
            lblStatus.ForeColor = lblColor;
            lblStatus.Dock = DockStyle.Fill;
            lblStatus.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            pnlFormFields.Controls.Add(lblStatus, 0, 14);

            cmbStatus.Dock = DockStyle.Fill;
            cmbStatus.Font = inputFont;
            cmbStatus.FormattingEnabled = true;
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.Items.AddRange(new object[] { "Active", "Inactive" });
            pnlFormFields.Controls.Add(cmbStatus, 0, 15);

            lblDescription.Text = "Description / Inclusions";
            lblDescription.Font = lblFont;
            lblDescription.ForeColor = lblColor;
            lblDescription.Dock = DockStyle.Fill;
            lblDescription.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            pnlFormFields.Controls.Add(lblDescription, 0, 16);

            txtDescription.Dock = DockStyle.Fill;
            txtDescription.Font = inputFont;
            txtDescription.Multiline = true;
            txtDescription.ScrollBars = ScrollBars.Vertical;
            txtDescription.PlaceholderText = "Breakfast included, free cancellation...";
            pnlFormFields.Controls.Add(txtDescription, 0, 17);

            pnlFormScroll.Controls.Add(pnlFormFields);
            pnlFormContainer.Controls.Add(pnlFormScroll);
            pnlFormContainer.Controls.Add(tlpButtons);
            pnlFormContainer.Controls.Add(lblFormTitle);

            // ═══════════ RIGHT CARD — GRID (50%) ═══════════
            pnlGridContainer.Dock = DockStyle.Fill;
            pnlGridContainer.BackColor = System.Drawing.Color.White;
            pnlGridContainer.Margin = new Padding(10, 0, 0, 0);
            pnlGridContainer.Padding = new Padding(24, 18, 24, 18);

            lblGridTitle.Text = "Configured Room Rates";
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
            txtSearch.PlaceholderText = "Search rates by room type, tier, or status...";
            txtSearch.TextChanged += txtSearch_TextChanged;

            pnlSearchBar.Controls.Add(txtSearch);
            pnlSearchBar.Controls.Add(lblSearchIcon);

            dgvRates.Dock = DockStyle.Fill;
            dgvRates.BackgroundColor = System.Drawing.Color.White;
            dgvRates.BorderStyle = BorderStyle.None;
            dgvRates.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvRates.RowHeadersVisible = false;
            dgvRates.AllowUserToAddRows = false;
            dgvRates.AllowUserToDeleteRows = false;
            dgvRates.AllowUserToResizeRows = false;
            dgvRates.ReadOnly = true;
            dgvRates.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRates.MultiSelect = false;
            dgvRates.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRates.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvRates.ColumnHeadersHeight = 42;
            dgvRates.RowTemplate.Height = 36;
            dgvRates.EnableHeadersVisualStyles = false;
            dgvRates.GridColor = System.Drawing.Color.FromArgb(230, 230, 230);

            rowStyle.Font = new System.Drawing.Font("Segoe UI", 10F);
            rowStyle.ForeColor = System.Drawing.Color.FromArgb(50, 50, 50);
            rowStyle.SelectionBackColor = System.Drawing.Color.FromArgb(200, 230, 226);
            rowStyle.SelectionForeColor = System.Drawing.Color.Black;
            rowStyle.Padding = new Padding(6, 0, 6, 0);
            dgvRates.DefaultCellStyle = rowStyle;

            altRowStyle.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            dgvRates.AlternatingRowsDefaultCellStyle = altRowStyle;

            headerStyle.BackColor = System.Drawing.Color.FromArgb(31, 58, 95);
            headerStyle.ForeColor = System.Drawing.Color.White;
            headerStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            headerStyle.Padding = new Padding(6, 0, 6, 0);
            headerStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvRates.ColumnHeadersDefaultCellStyle = headerStyle;

            dgvRates.CellClick += dgvRates_CellClick;

            colRateId.HeaderText = "ID";
            colRateId.Name = "colRateId";
            colRateId.FillWeight = 45;

            colRoomType.HeaderText = "Room Type";
            colRoomType.Name = "colRoomType";
            colRoomType.FillWeight = 90;

            colSeason.HeaderText = "Season / Tier";
            colSeason.Name = "colSeason";
            colSeason.FillWeight = 100;

            colBaseRate.HeaderText = "Base Rate";
            colBaseRate.Name = "colBaseRate";
            colBaseRate.FillWeight = 80;

            colWeekend.HeaderText = "Weekend +%";
            colWeekend.Name = "colWeekend";
            colWeekend.FillWeight = 75;

            colEffectiveFrom.HeaderText = "From";
            colEffectiveFrom.Name = "colEffectiveFrom";
            colEffectiveFrom.FillWeight = 80;

            colEffectiveTo.HeaderText = "To";
            colEffectiveTo.Name = "colEffectiveTo";
            colEffectiveTo.FillWeight = 80;

            colStatus.HeaderText = "Status";
            colStatus.Name = "colStatus";
            colStatus.FillWeight = 65;

            dgvRates.Columns.AddRange(new DataGridViewColumn[] {
                colRateId, colRoomType, colSeason, colBaseRate, colWeekend, colEffectiveFrom, colEffectiveTo, colStatus
            });

            pnlGridContainer.Controls.Add(dgvRates);
            pnlGridContainer.Controls.Add(pnlSearchBar);
            pnlGridContainer.Controls.Add(lblGridTitle);

            // ──────────── FORM ────────────
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new System.Drawing.Size(1200, 720);
            Controls.Add(pnlBody);
            Controls.Add(pnlHeader);
            Name = "RateManagement";
            Text = "Rate Management — StaySync";
            Load += RateManagement_Load;

            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlBody.ResumeLayout(false);
            tlpMain.ResumeLayout(false);
            pnlFormContainer.ResumeLayout(false);
            pnlFormScroll.ResumeLayout(false);
            pnlFormScroll.PerformLayout();
            pnlFormFields.ResumeLayout(false);
            pnlFormFields.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudWeekendSurcharge).EndInit();
            tlpButtons.ResumeLayout(false);
            pnlGridContainer.ResumeLayout(false);
            pnlGridContainer.PerformLayout();
            pnlSearchBar.ResumeLayout(false);
            pnlSearchBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRates).EndInit();
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
        private Label lblRateId;
        private TextBox txtRateId;
        private Label lblRoomType;
        private ComboBox cmbRoomType;
        private Label lblSeason;
        private ComboBox cmbSeason;
        private Label lblBaseRate;
        private TextBox txtBaseRate;
        private Label lblWeekendSurcharge;
        private NumericUpDown nudWeekendSurcharge;
        private Label lblEffectiveFrom;
        private DateTimePicker dtpEffectiveFrom;
        private Label lblEffectiveTo;
        private DateTimePicker dtpEffectiveTo;
        private Label lblStatus;
        private ComboBox cmbStatus;
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
        private DataGridView dgvRates;
        private DataGridViewTextBoxColumn colRateId;
        private DataGridViewTextBoxColumn colRoomType;
        private DataGridViewTextBoxColumn colSeason;
        private DataGridViewTextBoxColumn colBaseRate;
        private DataGridViewTextBoxColumn colWeekend;
        private DataGridViewTextBoxColumn colEffectiveFrom;
        private DataGridViewTextBoxColumn colEffectiveTo;
        private DataGridViewTextBoxColumn colStatus;
    }
}

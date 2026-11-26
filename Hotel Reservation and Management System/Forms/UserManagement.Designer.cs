namespace Hotel_Reservation_and_Management_System
{
    partial class UserManagement
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
            lblUserId = new Label();
            txtUserId = new TextBox();
            lblUsername = new Label();
            txtUsername = new TextBox();
            lblFullName = new Label();
            txtFullName = new TextBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblRole = new Label();
            cmbRole = new ComboBox();
            lblUserStatus = new Label();
            cmbUserStatus = new ComboBox();
            pnlPasswordFields = new Panel();
            tblPasswordFields = new TableLayoutPanel();
            lblPassword = new Label();
            txtPassword = new TextBox();
            lblConfirmPassword = new Label();
            txtConfirmPassword = new TextBox();
            tlpButtons = new TableLayoutPanel();
            btnSave = new Button();
            btnDelete = new Button();
            btnClear = new Button();

            pnlGridContainer = new Panel();
            lblGridTitle = new Label();
            pnlSearchBar = new Panel();
            lblSearchIcon = new Label();
            txtSearch = new TextBox();
            dgvUsers = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colUsername = new DataGridViewTextBoxColumn();
            colFullName = new DataGridViewTextBoxColumn();
            colEmail = new DataGridViewTextBoxColumn();
            colRole = new DataGridViewTextBoxColumn();
            colStatus = new DataGridViewTextBoxColumn();

            pnlHeader.SuspendLayout();
            pnlBody.SuspendLayout();
            tlpMain.SuspendLayout();
            pnlFormContainer.SuspendLayout();
            pnlFormScroll.SuspendLayout();
            pnlFormFields.SuspendLayout();
            pnlPasswordFields.SuspendLayout();
            tblPasswordFields.SuspendLayout();
            tlpButtons.SuspendLayout();
            pnlGridContainer.SuspendLayout();
            pnlSearchBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            SuspendLayout();

            // ──────────── HEADER ────────────
            pnlHeader.BackColor = System.Drawing.Color.FromArgb(31, 58, 95);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Height = 70;
            pnlHeader.Padding = new Padding(24, 15, 24, 15);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Controls.Add(btnBack);

            lblTitle.Text = "User Management";
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

            lblFormTitle.Text = "User Details";
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

            btnSave.Text = "➕  Add User";
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

            // Scrollable form panel
            pnlFormScroll.Dock = DockStyle.Fill;
            pnlFormScroll.AutoScroll = true;
            pnlFormScroll.Padding = new Padding(0, 4, 4, 4);

            pnlFormFields.Dock = DockStyle.Top;
            pnlFormFields.AutoSize = true;
            pnlFormFields.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            pnlFormFields.ColumnCount = 1;
            pnlFormFields.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            pnlFormFields.RowCount = 13;
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
            pnlFormFields.RowStyles.Add(new RowStyle(SizeType.AutoSize));

            System.Drawing.Font lblFont = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            System.Drawing.Color lblColor = System.Drawing.Color.FromArgb(80, 80, 80);
            System.Drawing.Font inputFont = new System.Drawing.Font("Segoe UI", 10.5F);

            lblUserId.Text = "User ID";
            lblUserId.Font = lblFont;
            lblUserId.ForeColor = lblColor;
            lblUserId.Dock = DockStyle.Fill;
            lblUserId.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            pnlFormFields.Controls.Add(lblUserId, 0, 0);

            txtUserId.Dock = DockStyle.Fill;
            txtUserId.Font = inputFont;
            txtUserId.PlaceholderText = "Auto-generated";
            txtUserId.ReadOnly = true;
            txtUserId.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);
            pnlFormFields.Controls.Add(txtUserId, 0, 1);

            lblUsername.Text = "Username";
            lblUsername.Font = lblFont;
            lblUsername.ForeColor = lblColor;
            lblUsername.Dock = DockStyle.Fill;
            lblUsername.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            pnlFormFields.Controls.Add(lblUsername, 0, 2);

            txtUsername.Dock = DockStyle.Fill;
            txtUsername.Font = inputFont;
            txtUsername.PlaceholderText = "e.g. jdoe";
            pnlFormFields.Controls.Add(txtUsername, 0, 3);

            lblFullName.Text = "Full Name";
            lblFullName.Font = lblFont;
            lblFullName.ForeColor = lblColor;
            lblFullName.Dock = DockStyle.Fill;
            lblFullName.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            pnlFormFields.Controls.Add(lblFullName, 0, 4);

            txtFullName.Dock = DockStyle.Fill;
            txtFullName.Font = inputFont;
            txtFullName.PlaceholderText = "e.g. John Doe";
            pnlFormFields.Controls.Add(txtFullName, 0, 5);

            lblEmail.Text = "Email Address";
            lblEmail.Font = lblFont;
            lblEmail.ForeColor = lblColor;
            lblEmail.Dock = DockStyle.Fill;
            lblEmail.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            pnlFormFields.Controls.Add(lblEmail, 0, 6);

            txtEmail.Dock = DockStyle.Fill;
            txtEmail.Font = inputFont;
            txtEmail.PlaceholderText = "e.g. user@staysync.com";
            pnlFormFields.Controls.Add(txtEmail, 0, 7);

            lblRole.Text = "Role";
            lblRole.Font = lblFont;
            lblRole.ForeColor = lblColor;
            lblRole.Dock = DockStyle.Fill;
            lblRole.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            pnlFormFields.Controls.Add(lblRole, 0, 8);

            cmbRole.Dock = DockStyle.Fill;
            cmbRole.Font = inputFont;
            cmbRole.FormattingEnabled = true;
            cmbRole.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRole.Items.AddRange(new object[] { "Super Admin", "Receptionist" });
            pnlFormFields.Controls.Add(cmbRole, 0, 9);

            lblUserStatus.Text = "Status";
            lblUserStatus.Font = lblFont;
            lblUserStatus.ForeColor = lblColor;
            lblUserStatus.Dock = DockStyle.Fill;
            lblUserStatus.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            pnlFormFields.Controls.Add(lblUserStatus, 0, 10);

            cmbUserStatus.Dock = DockStyle.Fill;
            cmbUserStatus.Font = inputFont;
            cmbUserStatus.FormattingEnabled = true;
            cmbUserStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbUserStatus.Items.AddRange(new object[] { "Active", "Inactive" });
            pnlFormFields.Controls.Add(cmbUserStatus, 0, 11);

            pnlPasswordFields.Dock = DockStyle.Fill;
            pnlPasswordFields.AutoSize = true;
            pnlPasswordFields.AutoSizeMode = AutoSizeMode.GrowAndShrink;

            tblPasswordFields.Dock = DockStyle.Top;
            tblPasswordFields.AutoSize = true;
            tblPasswordFields.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tblPasswordFields.ColumnCount = 1;
            tblPasswordFields.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblPasswordFields.RowCount = 4;
            tblPasswordFields.RowStyles.Add(new RowStyle(SizeType.Absolute, 24F));
            tblPasswordFields.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            tblPasswordFields.RowStyles.Add(new RowStyle(SizeType.Absolute, 24F));
            tblPasswordFields.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));

            lblPassword = new Label();
            lblPassword.Text = "Password";
            lblPassword.Font = lblFont;
            lblPassword.ForeColor = lblColor;
            lblPassword.Dock = DockStyle.Fill;
            lblPassword.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            tblPasswordFields.Controls.Add(lblPassword, 0, 0);

            txtPassword.Dock = DockStyle.Fill;
            txtPassword.Font = inputFont;
            txtPassword.UseSystemPasswordChar = true;
            txtPassword.PlaceholderText = "Min. 6 characters";
            tblPasswordFields.Controls.Add(txtPassword, 0, 1);

            lblConfirmPassword = new Label();
            lblConfirmPassword.Text = "Confirm Password";
            lblConfirmPassword.Font = lblFont;
            lblConfirmPassword.ForeColor = lblColor;
            lblConfirmPassword.Dock = DockStyle.Fill;
            lblConfirmPassword.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            tblPasswordFields.Controls.Add(lblConfirmPassword, 0, 2);

            txtConfirmPassword.Dock = DockStyle.Fill;
            txtConfirmPassword.Font = inputFont;
            txtConfirmPassword.UseSystemPasswordChar = true;
            txtConfirmPassword.PlaceholderText = "Re-enter password";
            tblPasswordFields.Controls.Add(txtConfirmPassword, 0, 3);

            pnlPasswordFields.Controls.Add(tblPasswordFields);
            pnlFormFields.Controls.Add(pnlPasswordFields, 0, 12);

            pnlFormScroll.Controls.Add(pnlFormFields);
            pnlFormContainer.Controls.Add(pnlFormScroll);
            pnlFormContainer.Controls.Add(tlpButtons);
            pnlFormContainer.Controls.Add(lblFormTitle);

            // ═══════════ RIGHT CARD — GRID (50%) ═══════════
            pnlGridContainer.Dock = DockStyle.Fill;
            pnlGridContainer.BackColor = System.Drawing.Color.White;
            pnlGridContainer.Margin = new Padding(10, 0, 0, 0);
            pnlGridContainer.Padding = new Padding(24, 18, 24, 18);

            lblGridTitle.Text = "User Accounts";
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
            txtSearch.PlaceholderText = "Search users...";
            txtSearch.TextChanged += txtSearch_TextChanged;

            pnlSearchBar.Controls.Add(txtSearch);
            pnlSearchBar.Controls.Add(lblSearchIcon);

            dgvUsers.Dock = DockStyle.Fill;
            dgvUsers.BackgroundColor = System.Drawing.Color.White;
            dgvUsers.BorderStyle = BorderStyle.None;
            dgvUsers.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvUsers.RowHeadersVisible = false;
            dgvUsers.AllowUserToAddRows = false;
            dgvUsers.AllowUserToDeleteRows = false;
            dgvUsers.AllowUserToResizeRows = false;
            dgvUsers.ReadOnly = true;
            dgvUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsers.MultiSelect = false;
            dgvUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvUsers.ColumnHeadersHeight = 42;
            dgvUsers.RowTemplate.Height = 36;
            dgvUsers.EnableHeadersVisualStyles = false;
            dgvUsers.GridColor = System.Drawing.Color.FromArgb(230, 230, 230);

            rowStyle.Font = new System.Drawing.Font("Segoe UI", 10F);
            rowStyle.ForeColor = System.Drawing.Color.FromArgb(50, 50, 50);
            rowStyle.SelectionBackColor = System.Drawing.Color.FromArgb(200, 230, 226);
            rowStyle.SelectionForeColor = System.Drawing.Color.Black;
            rowStyle.Padding = new Padding(6, 0, 6, 0);
            dgvUsers.DefaultCellStyle = rowStyle;

            altRowStyle.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            dgvUsers.AlternatingRowsDefaultCellStyle = altRowStyle;

            headerStyle.BackColor = System.Drawing.Color.FromArgb(31, 58, 95);
            headerStyle.ForeColor = System.Drawing.Color.White;
            headerStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            headerStyle.Padding = new Padding(6, 0, 6, 0);
            headerStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvUsers.ColumnHeadersDefaultCellStyle = headerStyle;

            dgvUsers.CellClick += dgvUsers_CellClick;

            colId.HeaderText = "ID";
            colId.Name = "colId";
            colId.FillWeight = 40;

            colUsername.HeaderText = "Username";
            colUsername.Name = "colUsername";
            colUsername.FillWeight = 80;

            colFullName.HeaderText = "Full Name";
            colFullName.Name = "colFullName";
            colFullName.FillWeight = 100;

            colEmail.HeaderText = "Email";
            colEmail.Name = "colEmail";
            colEmail.FillWeight = 130;

            colRole.HeaderText = "Role";
            colRole.Name = "colRole";
            colRole.FillWeight = 90;

            colStatus.HeaderText = "Status";
            colStatus.Name = "colStatus";
            colStatus.FillWeight = 70;

            dgvUsers.Columns.AddRange(new DataGridViewColumn[] {
                colId, colUsername, colFullName, colEmail, colRole, colStatus
            });

            pnlGridContainer.Controls.Add(dgvUsers);
            pnlGridContainer.Controls.Add(pnlSearchBar);
            pnlGridContainer.Controls.Add(lblGridTitle);

            // ──────────── FORM ────────────
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new System.Drawing.Size(1200, 720);
            Controls.Add(pnlBody);
            Controls.Add(pnlHeader);
            Name = "UserManagement";
            Text = "User Management — StaySync";
            Load += UserManagement_Load;

            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlBody.ResumeLayout(false);
            tlpMain.ResumeLayout(false);
            pnlFormContainer.ResumeLayout(false);
            pnlFormScroll.ResumeLayout(false);
            pnlFormScroll.PerformLayout();
            pnlFormFields.ResumeLayout(false);
            pnlFormFields.PerformLayout();
            pnlPasswordFields.ResumeLayout(false);
            pnlPasswordFields.PerformLayout();
            tblPasswordFields.ResumeLayout(false);
            tblPasswordFields.PerformLayout();
            tlpButtons.ResumeLayout(false);
            pnlGridContainer.ResumeLayout(false);
            pnlGridContainer.PerformLayout();
            pnlSearchBar.ResumeLayout(false);
            pnlSearchBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
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
        private Label lblUserId;
        private TextBox txtUserId;
        private Label lblUsername;
        private TextBox txtUsername;
        private Label lblFullName;
        private TextBox txtFullName;
        private Label lblEmail;
        private TextBox txtEmail;
        private Label lblRole;
        private ComboBox cmbRole;
        private Label lblUserStatus;
        private ComboBox cmbUserStatus;
        private Panel pnlPasswordFields;
        private TableLayoutPanel tblPasswordFields;
        private Label lblPassword;
        private TextBox txtPassword;
        private Label lblConfirmPassword;
        private TextBox txtConfirmPassword;
        private TableLayoutPanel tlpButtons;
        private Button btnSave;
        private Button btnDelete;
        private Button btnClear;

        private Panel pnlGridContainer;
        private Label lblGridTitle;
        private Panel pnlSearchBar;
        private Label lblSearchIcon;
        private TextBox txtSearch;
        private DataGridView dgvUsers;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colUsername;
        private DataGridViewTextBoxColumn colFullName;
        private DataGridViewTextBoxColumn colEmail;
        private DataGridViewTextBoxColumn colRole;
        private DataGridViewTextBoxColumn colStatus;
    }
}

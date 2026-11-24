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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            pnlHeader = new Panel();
            lblTitle = new Label();
            btnBack = new Button();
            pnlBody = new Panel();
            splitContainer = new SplitContainer();
            pnlFormContainer = new Panel();
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
            pnlButtons = new FlowLayoutPanel();
            btnSave = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            lblFormTitle = new Label();
            pnlGridContainer = new Panel();
            dgvUsers = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colUsername = new DataGridViewTextBoxColumn();
            colFullName = new DataGridViewTextBoxColumn();
            colEmail = new DataGridViewTextBoxColumn();
            colRole = new DataGridViewTextBoxColumn();
            colStatus = new DataGridViewTextBoxColumn();
            pnlSearchBar = new Panel();
            txtSearch = new TextBox();
            lblSearchIcon = new Label();
            lblGridTitle = new Label();
            pnlHeader.SuspendLayout();
            pnlBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer).BeginInit();
            splitContainer.Panel1.SuspendLayout();
            splitContainer.Panel2.SuspendLayout();
            splitContainer.SuspendLayout();
            pnlFormContainer.SuspendLayout();
            pnlFormScroll.SuspendLayout();
            pnlFormFields.SuspendLayout();
            pnlPasswordFields.SuspendLayout();
            tblPasswordFields.SuspendLayout();
            pnlButtons.SuspendLayout();
            pnlGridContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            pnlSearchBar.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(31, 58, 95);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Controls.Add(btnBack);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Padding = new Padding(20, 0, 20, 0);
            pnlHeader.Size = new Size(1100, 70);
            pnlHeader.TabIndex = 1;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Dock = DockStyle.Left;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(20, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Padding = new Padding(10, 16, 0, 0);
            lblTitle.Size = new Size(233, 48);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "User Management";
            lblTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(31, 58, 95);
            btnBack.Cursor = Cursors.Hand;
            btnBack.Dock = DockStyle.Right;
            btnBack.FlatAppearance.BorderColor = Color.White;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(980, 0);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(100, 70);
            btnBack.TabIndex = 1;
            btnBack.Text = "← Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // pnlBody
            // 
            pnlBody.BackColor = Color.FromArgb(240, 243, 247);
            pnlBody.Controls.Add(splitContainer);
            pnlBody.Dock = DockStyle.Fill;
            pnlBody.Location = new Point(0, 70);
            pnlBody.Name = "pnlBody";
            pnlBody.Padding = new Padding(20);
            pnlBody.Size = new Size(1100, 630);
            pnlBody.TabIndex = 0;
            // 
            // splitContainer
            // 
            splitContainer.BackColor = Color.FromArgb(240, 243, 247);
            splitContainer.Dock = DockStyle.Fill;
            splitContainer.Location = new Point(20, 20);
            splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            splitContainer.Panel1.Controls.Add(pnlFormContainer);
            splitContainer.Panel1MinSize = 340;
            // 
            // splitContainer.Panel2
            // 
            splitContainer.Panel2.Controls.Add(pnlGridContainer);
            splitContainer.Panel2MinSize = 400;
            splitContainer.Size = new Size(1060, 590);
            splitContainer.SplitterDistance = 656;
            splitContainer.TabIndex = 0;
            // 
            // pnlFormContainer
            // 
            pnlFormContainer.BackColor = Color.White;
            pnlFormContainer.Controls.Add(pnlFormScroll);
            pnlFormContainer.Controls.Add(lblFormTitle);
            pnlFormContainer.Dock = DockStyle.Fill;
            pnlFormContainer.Location = new Point(0, 0);
            pnlFormContainer.Name = "pnlFormContainer";
            pnlFormContainer.Padding = new Padding(24, 16, 24, 16);
            pnlFormContainer.Size = new Size(656, 590);
            pnlFormContainer.TabIndex = 0;
            // 
            // pnlFormScroll
            // 
            pnlFormScroll.AutoScroll = true;
            pnlFormScroll.Controls.Add(pnlFormFields);
            pnlFormScroll.Dock = DockStyle.Fill;
            pnlFormScroll.Location = new Point(24, 60);
            pnlFormScroll.Name = "pnlFormScroll";
            pnlFormScroll.Size = new Size(608, 514);
            pnlFormScroll.TabIndex = 0;
            // 
            // pnlFormFields
            // 
            pnlFormFields.AutoSize = true;
            pnlFormFields.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            pnlFormFields.ColumnCount = 1;
            pnlFormFields.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            pnlFormFields.Controls.Add(lblUserId, 0, 0);
            pnlFormFields.Controls.Add(txtUserId, 0, 1);
            pnlFormFields.Controls.Add(lblUsername, 0, 2);
            pnlFormFields.Controls.Add(txtUsername, 0, 3);
            pnlFormFields.Controls.Add(lblFullName, 0, 4);
            pnlFormFields.Controls.Add(txtFullName, 0, 5);
            pnlFormFields.Controls.Add(lblEmail, 0, 6);
            pnlFormFields.Controls.Add(txtEmail, 0, 7);
            pnlFormFields.Controls.Add(lblRole, 0, 8);
            pnlFormFields.Controls.Add(cmbRole, 0, 9);
            pnlFormFields.Controls.Add(lblUserStatus, 0, 10);
            pnlFormFields.Controls.Add(cmbUserStatus, 0, 11);
            pnlFormFields.Controls.Add(pnlPasswordFields, 0, 12);
            pnlFormFields.Controls.Add(pnlButtons, 0, 13);
            pnlFormFields.Dock = DockStyle.Top;
            pnlFormFields.Location = new Point(0, 0);
            pnlFormFields.Name = "pnlFormFields";
            pnlFormFields.RowCount = 14;
            pnlFormFields.RowStyles.Add(new RowStyle(SizeType.Absolute, 24F));
            pnlFormFields.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
            pnlFormFields.RowStyles.Add(new RowStyle(SizeType.Absolute, 24F));
            pnlFormFields.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
            pnlFormFields.RowStyles.Add(new RowStyle(SizeType.Absolute, 24F));
            pnlFormFields.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
            pnlFormFields.RowStyles.Add(new RowStyle(SizeType.Absolute, 24F));
            pnlFormFields.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
            pnlFormFields.RowStyles.Add(new RowStyle(SizeType.Absolute, 24F));
            pnlFormFields.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
            pnlFormFields.RowStyles.Add(new RowStyle(SizeType.Absolute, 24F));
            pnlFormFields.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
            pnlFormFields.RowStyles.Add(new RowStyle());
            pnlFormFields.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            pnlFormFields.Size = new Size(591, 562);
            pnlFormFields.TabIndex = 0;
            // 
            // lblUserId
            // 
            lblUserId.Dock = DockStyle.Fill;
            lblUserId.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblUserId.ForeColor = Color.FromArgb(80, 80, 80);
            lblUserId.Location = new Point(3, 0);
            lblUserId.Name = "lblUserId";
            lblUserId.Size = new Size(585, 24);
            lblUserId.TabIndex = 0;
            lblUserId.Text = "User ID";
            lblUserId.TextAlign = ContentAlignment.BottomLeft;
            // 
            // txtUserId
            // 
            txtUserId.BackColor = Color.FromArgb(245, 245, 245);
            txtUserId.Dock = DockStyle.Fill;
            txtUserId.Font = new Font("Segoe UI", 10.5F);
            txtUserId.Location = new Point(3, 27);
            txtUserId.Name = "txtUserId";
            txtUserId.PlaceholderText = "Auto-generated";
            txtUserId.ReadOnly = true;
            txtUserId.Size = new Size(585, 26);
            txtUserId.TabIndex = 1;
            // 
            // lblUsername
            // 
            lblUsername.Dock = DockStyle.Fill;
            lblUsername.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblUsername.ForeColor = Color.FromArgb(80, 80, 80);
            lblUsername.Location = new Point(3, 62);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(585, 24);
            lblUsername.TabIndex = 2;
            lblUsername.Text = "Username";
            lblUsername.TextAlign = ContentAlignment.BottomLeft;
            // 
            // txtUsername
            // 
            txtUsername.Dock = DockStyle.Fill;
            txtUsername.Font = new Font("Segoe UI", 10.5F);
            txtUsername.Location = new Point(3, 89);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "e.g. jdoe";
            txtUsername.Size = new Size(585, 26);
            txtUsername.TabIndex = 3;
            // 
            // lblFullName
            // 
            lblFullName.Dock = DockStyle.Fill;
            lblFullName.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblFullName.ForeColor = Color.FromArgb(80, 80, 80);
            lblFullName.Location = new Point(3, 124);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(585, 24);
            lblFullName.TabIndex = 4;
            lblFullName.Text = "Full Name";
            lblFullName.TextAlign = ContentAlignment.BottomLeft;
            // 
            // txtFullName
            // 
            txtFullName.Dock = DockStyle.Fill;
            txtFullName.Font = new Font("Segoe UI", 10.5F);
            txtFullName.Location = new Point(3, 151);
            txtFullName.Name = "txtFullName";
            txtFullName.PlaceholderText = "e.g. John Doe";
            txtFullName.Size = new Size(585, 26);
            txtFullName.TabIndex = 5;
            // 
            // lblEmail
            // 
            lblEmail.Dock = DockStyle.Fill;
            lblEmail.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblEmail.ForeColor = Color.FromArgb(80, 80, 80);
            lblEmail.Location = new Point(3, 186);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(585, 24);
            lblEmail.TabIndex = 6;
            lblEmail.Text = "Email Address";
            lblEmail.TextAlign = ContentAlignment.BottomLeft;
            // 
            // txtEmail
            // 
            txtEmail.Dock = DockStyle.Fill;
            txtEmail.Font = new Font("Segoe UI", 10.5F);
            txtEmail.Location = new Point(3, 213);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "e.g. user@staysync.com";
            txtEmail.Size = new Size(585, 26);
            txtEmail.TabIndex = 7;
            // 
            // lblRole
            // 
            lblRole.Dock = DockStyle.Fill;
            lblRole.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblRole.ForeColor = Color.FromArgb(80, 80, 80);
            lblRole.Location = new Point(3, 248);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(585, 24);
            lblRole.TabIndex = 8;
            lblRole.Text = "Role";
            lblRole.TextAlign = ContentAlignment.BottomLeft;
            // 
            // cmbRole
            // 
            cmbRole.Dock = DockStyle.Fill;
            cmbRole.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRole.Font = new Font("Segoe UI", 10.5F);
            cmbRole.Items.AddRange(new object[] { "Super Admin", "Receptionist" });
            cmbRole.Location = new Point(3, 275);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(585, 27);
            cmbRole.TabIndex = 9;
            // 
            // lblUserStatus
            // 
            lblUserStatus.Dock = DockStyle.Fill;
            lblUserStatus.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblUserStatus.ForeColor = Color.FromArgb(80, 80, 80);
            lblUserStatus.Location = new Point(3, 310);
            lblUserStatus.Name = "lblUserStatus";
            lblUserStatus.Size = new Size(585, 24);
            lblUserStatus.TabIndex = 10;
            lblUserStatus.Text = "Status";
            lblUserStatus.TextAlign = ContentAlignment.BottomLeft;
            // 
            // cmbUserStatus
            // 
            cmbUserStatus.Dock = DockStyle.Fill;
            cmbUserStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbUserStatus.Font = new Font("Segoe UI", 10.5F);
            cmbUserStatus.Items.AddRange(new object[] { "Active", "Inactive" });
            cmbUserStatus.Location = new Point(3, 337);
            cmbUserStatus.Name = "cmbUserStatus";
            cmbUserStatus.Size = new Size(585, 27);
            cmbUserStatus.TabIndex = 11;
            // 
            // pnlPasswordFields
            // 
            pnlPasswordFields.AutoSize = true;
            pnlPasswordFields.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            pnlPasswordFields.Controls.Add(tblPasswordFields);
            pnlPasswordFields.Dock = DockStyle.Fill;
            pnlPasswordFields.Location = new Point(3, 375);
            pnlPasswordFields.Name = "pnlPasswordFields";
            pnlPasswordFields.Size = new Size(585, 124);
            pnlPasswordFields.TabIndex = 12;
            // 
            // tblPasswordFields
            // 
            tblPasswordFields.AutoSize = true;
            tblPasswordFields.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tblPasswordFields.ColumnCount = 1;
            tblPasswordFields.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblPasswordFields.Controls.Add(lblPassword, 0, 0);
            tblPasswordFields.Controls.Add(txtPassword, 0, 1);
            tblPasswordFields.Controls.Add(lblConfirmPassword, 0, 2);
            tblPasswordFields.Controls.Add(txtConfirmPassword, 0, 3);
            tblPasswordFields.Dock = DockStyle.Top;
            tblPasswordFields.Location = new Point(0, 0);
            tblPasswordFields.Name = "tblPasswordFields";
            tblPasswordFields.RowCount = 4;
            tblPasswordFields.RowStyles.Add(new RowStyle(SizeType.Absolute, 24F));
            tblPasswordFields.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
            tblPasswordFields.RowStyles.Add(new RowStyle(SizeType.Absolute, 24F));
            tblPasswordFields.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
            tblPasswordFields.Size = new Size(585, 124);
            tblPasswordFields.TabIndex = 0;
            // 
            // lblPassword
            // 
            lblPassword.Dock = DockStyle.Fill;
            lblPassword.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblPassword.ForeColor = Color.FromArgb(80, 80, 80);
            lblPassword.Location = new Point(3, 0);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(579, 24);
            lblPassword.TabIndex = 0;
            lblPassword.Text = "Password";
            lblPassword.TextAlign = ContentAlignment.BottomLeft;
            // 
            // txtPassword
            // 
            txtPassword.Dock = DockStyle.Fill;
            txtPassword.Font = new Font("Segoe UI", 10.5F);
            txtPassword.Location = new Point(3, 27);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Min. 6 characters";
            txtPassword.Size = new Size(579, 26);
            txtPassword.TabIndex = 1;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // lblConfirmPassword
            // 
            lblConfirmPassword.Dock = DockStyle.Fill;
            lblConfirmPassword.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblConfirmPassword.ForeColor = Color.FromArgb(80, 80, 80);
            lblConfirmPassword.Location = new Point(3, 62);
            lblConfirmPassword.Name = "lblConfirmPassword";
            lblConfirmPassword.Size = new Size(579, 24);
            lblConfirmPassword.TabIndex = 2;
            lblConfirmPassword.Text = "Confirm Password";
            lblConfirmPassword.TextAlign = ContentAlignment.BottomLeft;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Dock = DockStyle.Fill;
            txtConfirmPassword.Font = new Font("Segoe UI", 10.5F);
            txtConfirmPassword.Location = new Point(3, 89);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.PlaceholderText = "Re-enter password";
            txtConfirmPassword.Size = new Size(579, 26);
            txtConfirmPassword.TabIndex = 3;
            txtConfirmPassword.UseSystemPasswordChar = true;
            // 
            // pnlButtons
            // 
            pnlButtons.Controls.Add(btnSave);
            pnlButtons.Controls.Add(btnDelete);
            pnlButtons.Controls.Add(btnClear);
            pnlButtons.Dock = DockStyle.Fill;
            pnlButtons.Location = new Point(3, 505);
            pnlButtons.Name = "pnlButtons";
            pnlButtons.Padding = new Padding(0, 8, 0, 0);
            pnlButtons.Size = new Size(585, 54);
            pnlButtons.TabIndex = 13;
            pnlButtons.WrapContents = false;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(42, 157, 143);
            btnSave.Cursor = Cursors.Hand;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(3, 11);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(140, 42);
            btnSave.TabIndex = 0;
            btnSave.Text = "➕  Add User";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(200, 60, 60);
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.Enabled = false;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(149, 11);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(110, 42);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "🗑  Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.White;
            btnClear.Cursor = Cursors.Hand;
            btnClear.FlatAppearance.BorderColor = Color.FromArgb(31, 58, 95);
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnClear.ForeColor = Color.FromArgb(31, 58, 95);
            btnClear.Location = new Point(265, 11);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(100, 42);
            btnClear.TabIndex = 2;
            btnClear.Text = "✖  Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // lblFormTitle
            // 
            lblFormTitle.Dock = DockStyle.Top;
            lblFormTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblFormTitle.ForeColor = Color.FromArgb(31, 58, 95);
            lblFormTitle.Location = new Point(24, 16);
            lblFormTitle.Name = "lblFormTitle";
            lblFormTitle.Size = new Size(608, 44);
            lblFormTitle.TabIndex = 1;
            lblFormTitle.Text = "User Details";
            lblFormTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlGridContainer
            // 
            pnlGridContainer.BackColor = Color.White;
            pnlGridContainer.Controls.Add(dgvUsers);
            pnlGridContainer.Controls.Add(pnlSearchBar);
            pnlGridContainer.Controls.Add(lblGridTitle);
            pnlGridContainer.Dock = DockStyle.Fill;
            pnlGridContainer.Location = new Point(0, 0);
            pnlGridContainer.Name = "pnlGridContainer";
            pnlGridContainer.Padding = new Padding(24, 16, 24, 16);
            pnlGridContainer.Size = new Size(400, 590);
            pnlGridContainer.TabIndex = 0;
            // 
            // dgvUsers
            // 
            dgvUsers.AllowUserToAddRows = false;
            dgvUsers.AllowUserToDeleteRows = false;
            dgvUsers.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(248, 250, 252);
            dgvUsers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUsers.BackgroundColor = Color.White;
            dgvUsers.BorderStyle = BorderStyle.None;
            dgvUsers.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(31, 58, 95);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.Padding = new Padding(6, 0, 6, 0);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvUsers.ColumnHeadersHeight = 42;
            dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvUsers.Columns.AddRange(new DataGridViewColumn[] { colId, colUsername, colFullName, colEmail, colRole, colStatus });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(50, 50, 50);
            dataGridViewCellStyle3.Padding = new Padding(6, 0, 6, 0);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(42, 157, 143, 60);
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvUsers.DefaultCellStyle = dataGridViewCellStyle3;
            dgvUsers.Dock = DockStyle.Fill;
            dgvUsers.EnableHeadersVisualStyles = false;
            dgvUsers.GridColor = Color.FromArgb(230, 230, 230);
            dgvUsers.Location = new Point(24, 104);
            dgvUsers.MultiSelect = false;
            dgvUsers.Name = "dgvUsers";
            dgvUsers.ReadOnly = true;
            dgvUsers.RowHeadersVisible = false;
            dgvUsers.RowTemplate.Height = 36;
            dgvUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsers.Size = new Size(352, 470);
            dgvUsers.TabIndex = 0;
            dgvUsers.CellClick += dgvUsers_CellClick;
            // 
            // colId
            // 
            colId.FillWeight = 40F;
            colId.HeaderText = "ID";
            colId.Name = "colId";
            colId.ReadOnly = true;
            // 
            // colUsername
            // 
            colUsername.FillWeight = 80F;
            colUsername.HeaderText = "Username";
            colUsername.Name = "colUsername";
            colUsername.ReadOnly = true;
            // 
            // colFullName
            // 
            colFullName.HeaderText = "Full Name";
            colFullName.Name = "colFullName";
            colFullName.ReadOnly = true;
            // 
            // colEmail
            // 
            colEmail.FillWeight = 130F;
            colEmail.HeaderText = "Email";
            colEmail.Name = "colEmail";
            colEmail.ReadOnly = true;
            // 
            // colRole
            // 
            colRole.FillWeight = 90F;
            colRole.HeaderText = "Role";
            colRole.Name = "colRole";
            colRole.ReadOnly = true;
            // 
            // colStatus
            // 
            colStatus.FillWeight = 70F;
            colStatus.HeaderText = "Status";
            colStatus.Name = "colStatus";
            colStatus.ReadOnly = true;
            // 
            // pnlSearchBar
            // 
            pnlSearchBar.Controls.Add(txtSearch);
            pnlSearchBar.Controls.Add(lblSearchIcon);
            pnlSearchBar.Dock = DockStyle.Top;
            pnlSearchBar.Location = new Point(24, 60);
            pnlSearchBar.Name = "pnlSearchBar";
            pnlSearchBar.Padding = new Padding(0, 4, 0, 8);
            pnlSearchBar.Size = new Size(352, 44);
            pnlSearchBar.TabIndex = 1;
            // 
            // txtSearch
            // 
            txtSearch.Dock = DockStyle.Fill;
            txtSearch.Font = new Font("Segoe UI", 10.5F);
            txtSearch.Location = new Point(32, 4);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search users...";
            txtSearch.Size = new Size(320, 26);
            txtSearch.TabIndex = 0;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // lblSearchIcon
            // 
            lblSearchIcon.Dock = DockStyle.Left;
            lblSearchIcon.Font = new Font("Segoe UI", 12F);
            lblSearchIcon.Location = new Point(0, 4);
            lblSearchIcon.Name = "lblSearchIcon";
            lblSearchIcon.Size = new Size(32, 32);
            lblSearchIcon.TabIndex = 1;
            lblSearchIcon.Text = "🔍";
            lblSearchIcon.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblGridTitle
            // 
            lblGridTitle.Dock = DockStyle.Top;
            lblGridTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblGridTitle.ForeColor = Color.FromArgb(31, 58, 95);
            lblGridTitle.Location = new Point(24, 16);
            lblGridTitle.Name = "lblGridTitle";
            lblGridTitle.Size = new Size(352, 44);
            lblGridTitle.TabIndex = 2;
            lblGridTitle.Text = "User Accounts";
            lblGridTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // UserManagement
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(1100, 700);
            Controls.Add(pnlBody);
            Controls.Add(pnlHeader);
            Name = "UserManagement";
            Text = "User Management — StaySync";
            Load += UserManagement_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlBody.ResumeLayout(false);
            splitContainer.Panel1.ResumeLayout(false);
            splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer).EndInit();
            splitContainer.ResumeLayout(false);
            pnlFormContainer.ResumeLayout(false);
            pnlFormScroll.ResumeLayout(false);
            pnlFormScroll.PerformLayout();
            pnlFormFields.ResumeLayout(false);
            pnlFormFields.PerformLayout();
            pnlPasswordFields.ResumeLayout(false);
            pnlPasswordFields.PerformLayout();
            tblPasswordFields.ResumeLayout(false);
            tblPasswordFields.PerformLayout();
            pnlButtons.ResumeLayout(false);
            pnlGridContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            pnlSearchBar.ResumeLayout(false);
            pnlSearchBar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private Label lblTitle;
        private Button btnBack;
        private Panel pnlBody;
        private SplitContainer splitContainer;

        // Left — Form
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
        private FlowLayoutPanel pnlButtons;
        private Button btnSave;
        private Button btnDelete;
        private Button btnClear;

        // Right — Grid
        private Panel pnlGridContainer;
        private Label lblGridTitle;
        private Panel pnlSearchBar;
        private TextBox txtSearch;
        private Label lblSearchIcon;
        private DataGridView dgvUsers;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colUsername;
        private DataGridViewTextBoxColumn colFullName;
        private DataGridViewTextBoxColumn colEmail;
        private DataGridViewTextBoxColumn colRole;
        private DataGridViewTextBoxColumn colStatus;
    }
}

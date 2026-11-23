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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            pnlHeader = new Panel();
            lblTitle = new Label();
            btnBack = new Button();
            pnlBody = new Panel();
            splitContainer = new SplitContainer();
            pnlFormContainer = new Panel();
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
            pnlButtons = new FlowLayoutPanel();
            btnSave = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            lblFormTitle = new Label();
            pnlGridContainer = new Panel();
            dgvRooms = new DataGridView();
            colRoomNumber = new DataGridViewTextBoxColumn();
            colRoomType = new DataGridViewTextBoxColumn();
            colStatus = new DataGridViewTextBoxColumn();
            colCapacity = new DataGridViewTextBoxColumn();
            colPrice = new DataGridViewTextBoxColumn();
            colDescription = new DataGridViewTextBoxColumn();
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
            pnlFormFields.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudCapacity).BeginInit();
            pnlButtons.SuspendLayout();
            pnlGridContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRooms).BeginInit();
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
            lblTitle.Size = new Size(249, 48);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Room Management";
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
            splitContainer.Panel1MinSize = 320;
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
            pnlFormContainer.Controls.Add(pnlFormFields);
            pnlFormContainer.Controls.Add(lblFormTitle);
            pnlFormContainer.Dock = DockStyle.Fill;
            pnlFormContainer.Location = new Point(0, 0);
            pnlFormContainer.Name = "pnlFormContainer";
            pnlFormContainer.Padding = new Padding(24, 16, 24, 16);
            pnlFormContainer.Size = new Size(656, 590);
            pnlFormContainer.TabIndex = 0;
            // 
            // pnlFormFields
            // 
            pnlFormFields.ColumnCount = 1;
            pnlFormFields.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            pnlFormFields.Controls.Add(lblRoomNumber, 0, 0);
            pnlFormFields.Controls.Add(txtRoomNumber, 0, 1);
            pnlFormFields.Controls.Add(lblRoomType, 0, 2);
            pnlFormFields.Controls.Add(cmbRoomType, 0, 3);
            pnlFormFields.Controls.Add(lblStatus, 0, 4);
            pnlFormFields.Controls.Add(cmbStatus, 0, 5);
            pnlFormFields.Controls.Add(lblCapacity, 0, 6);
            pnlFormFields.Controls.Add(nudCapacity, 0, 7);
            pnlFormFields.Controls.Add(lblPrice, 0, 8);
            pnlFormFields.Controls.Add(txtPrice, 0, 9);
            pnlFormFields.Controls.Add(lblDescription, 0, 10);
            pnlFormFields.Controls.Add(txtDescription, 0, 11);
            pnlFormFields.Controls.Add(pnlButtons, 0, 12);
            pnlFormFields.Dock = DockStyle.Fill;
            pnlFormFields.Location = new Point(24, 60);
            pnlFormFields.Name = "pnlFormFields";
            pnlFormFields.RowCount = 13;
            pnlFormFields.RowStyles.Add(new RowStyle(SizeType.Absolute, 24F));
            pnlFormFields.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            pnlFormFields.RowStyles.Add(new RowStyle(SizeType.Absolute, 24F));
            pnlFormFields.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            pnlFormFields.RowStyles.Add(new RowStyle(SizeType.Absolute, 24F));
            pnlFormFields.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            pnlFormFields.RowStyles.Add(new RowStyle(SizeType.Absolute, 24F));
            pnlFormFields.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            pnlFormFields.RowStyles.Add(new RowStyle(SizeType.Absolute, 24F));
            pnlFormFields.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            pnlFormFields.RowStyles.Add(new RowStyle(SizeType.Absolute, 24F));
            pnlFormFields.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            pnlFormFields.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            pnlFormFields.Size = new Size(608, 514);
            pnlFormFields.TabIndex = 0;
            // 
            // lblRoomNumber
            // 
            lblRoomNumber.Dock = DockStyle.Fill;
            lblRoomNumber.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblRoomNumber.ForeColor = Color.FromArgb(80, 80, 80);
            lblRoomNumber.Location = new Point(3, 0);
            lblRoomNumber.Name = "lblRoomNumber";
            lblRoomNumber.Size = new Size(602, 24);
            lblRoomNumber.TabIndex = 0;
            lblRoomNumber.Text = "Room Number";
            lblRoomNumber.TextAlign = ContentAlignment.BottomLeft;
            // 
            // txtRoomNumber
            // 
            txtRoomNumber.Dock = DockStyle.Fill;
            txtRoomNumber.Font = new Font("Segoe UI", 10.5F);
            txtRoomNumber.Location = new Point(3, 27);
            txtRoomNumber.Name = "txtRoomNumber";
            txtRoomNumber.PlaceholderText = "e.g. 101";
            txtRoomNumber.Size = new Size(602, 26);
            txtRoomNumber.TabIndex = 1;
            // 
            // lblRoomType
            // 
            lblRoomType.Dock = DockStyle.Fill;
            lblRoomType.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblRoomType.ForeColor = Color.FromArgb(80, 80, 80);
            lblRoomType.Location = new Point(3, 64);
            lblRoomType.Name = "lblRoomType";
            lblRoomType.Size = new Size(602, 24);
            lblRoomType.TabIndex = 2;
            lblRoomType.Text = "Room Type";
            lblRoomType.TextAlign = ContentAlignment.BottomLeft;
            // 
            // cmbRoomType
            // 
            cmbRoomType.Dock = DockStyle.Fill;
            cmbRoomType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRoomType.Font = new Font("Segoe UI", 10.5F);
            cmbRoomType.Items.AddRange(new object[] { "Single", "Double", "Suite", "Deluxe", "Family", "Penthouse" });
            cmbRoomType.Location = new Point(3, 91);
            cmbRoomType.Name = "cmbRoomType";
            cmbRoomType.Size = new Size(602, 27);
            cmbRoomType.TabIndex = 3;
            // 
            // lblStatus
            // 
            lblStatus.Dock = DockStyle.Fill;
            lblStatus.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblStatus.ForeColor = Color.FromArgb(80, 80, 80);
            lblStatus.Location = new Point(3, 128);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(602, 24);
            lblStatus.TabIndex = 4;
            lblStatus.Text = "Status";
            lblStatus.TextAlign = ContentAlignment.BottomLeft;
            // 
            // cmbStatus
            // 
            cmbStatus.Dock = DockStyle.Fill;
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.Font = new Font("Segoe UI", 10.5F);
            cmbStatus.Items.AddRange(new object[] { "Available", "Occupied", "Maintenance", "Reserved" });
            cmbStatus.Location = new Point(3, 155);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(602, 27);
            cmbStatus.TabIndex = 5;
            // 
            // lblCapacity
            // 
            lblCapacity.Dock = DockStyle.Fill;
            lblCapacity.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblCapacity.ForeColor = Color.FromArgb(80, 80, 80);
            lblCapacity.Location = new Point(3, 192);
            lblCapacity.Name = "lblCapacity";
            lblCapacity.Size = new Size(602, 24);
            lblCapacity.TabIndex = 6;
            lblCapacity.Text = "Capacity (Guests)";
            lblCapacity.TextAlign = ContentAlignment.BottomLeft;
            // 
            // nudCapacity
            // 
            nudCapacity.Dock = DockStyle.Fill;
            nudCapacity.Font = new Font("Segoe UI", 10.5F);
            nudCapacity.Location = new Point(3, 219);
            nudCapacity.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            nudCapacity.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudCapacity.Name = "nudCapacity";
            nudCapacity.Size = new Size(602, 26);
            nudCapacity.TabIndex = 7;
            nudCapacity.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblPrice
            // 
            lblPrice.Dock = DockStyle.Fill;
            lblPrice.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblPrice.ForeColor = Color.FromArgb(80, 80, 80);
            lblPrice.Location = new Point(3, 256);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(602, 24);
            lblPrice.TabIndex = 8;
            lblPrice.Text = "Price Per Night ($)";
            lblPrice.TextAlign = ContentAlignment.BottomLeft;
            // 
            // txtPrice
            // 
            txtPrice.Dock = DockStyle.Fill;
            txtPrice.Font = new Font("Segoe UI", 10.5F);
            txtPrice.Location = new Point(3, 283);
            txtPrice.Name = "txtPrice";
            txtPrice.PlaceholderText = "e.g. 120.00";
            txtPrice.Size = new Size(602, 26);
            txtPrice.TabIndex = 9;
            // 
            // lblDescription
            // 
            lblDescription.Dock = DockStyle.Fill;
            lblDescription.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblDescription.ForeColor = Color.FromArgb(80, 80, 80);
            lblDescription.Location = new Point(3, 320);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(602, 24);
            lblDescription.TabIndex = 10;
            lblDescription.Text = "Description / Notes";
            lblDescription.TextAlign = ContentAlignment.BottomLeft;
            // 
            // txtDescription
            // 
            txtDescription.Dock = DockStyle.Fill;
            txtDescription.Font = new Font("Segoe UI", 10.5F);
            txtDescription.Location = new Point(3, 347);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.PlaceholderText = "Floor, view, amenities...";
            txtDescription.ScrollBars = ScrollBars.Vertical;
            txtDescription.Size = new Size(602, 104);
            txtDescription.TabIndex = 11;
            // 
            // pnlButtons
            // 
            pnlButtons.Controls.Add(btnSave);
            pnlButtons.Controls.Add(btnDelete);
            pnlButtons.Controls.Add(btnClear);
            pnlButtons.Dock = DockStyle.Fill;
            pnlButtons.Location = new Point(3, 457);
            pnlButtons.Name = "pnlButtons";
            pnlButtons.Padding = new Padding(0, 8, 0, 0);
            pnlButtons.Size = new Size(602, 54);
            pnlButtons.TabIndex = 12;
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
            btnSave.Text = "➕  Add Room";
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
            lblFormTitle.Text = "Room Details";
            lblFormTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlGridContainer
            // 
            pnlGridContainer.BackColor = Color.White;
            pnlGridContainer.Controls.Add(dgvRooms);
            pnlGridContainer.Controls.Add(pnlSearchBar);
            pnlGridContainer.Controls.Add(lblGridTitle);
            pnlGridContainer.Dock = DockStyle.Fill;
            pnlGridContainer.Location = new Point(0, 0);
            pnlGridContainer.Name = "pnlGridContainer";
            pnlGridContainer.Padding = new Padding(24, 16, 24, 16);
            pnlGridContainer.Size = new Size(400, 590);
            pnlGridContainer.TabIndex = 0;
            // 
            // dgvRooms
            // 
            dgvRooms.AllowUserToAddRows = false;
            dgvRooms.AllowUserToDeleteRows = false;
            dgvRooms.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(248, 250, 252);
            dgvRooms.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvRooms.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRooms.BackgroundColor = Color.White;
            dgvRooms.BorderStyle = BorderStyle.None;
            dgvRooms.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(31, 58, 95);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.Padding = new Padding(6, 0, 6, 0);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvRooms.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvRooms.ColumnHeadersHeight = 42;
            dgvRooms.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvRooms.Columns.AddRange(new DataGridViewColumn[] { colRoomNumber, colRoomType, colStatus, colCapacity, colPrice, colDescription });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(50, 50, 50);
            dataGridViewCellStyle3.Padding = new Padding(6, 0, 6, 0);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(42, 157, 143, 60);
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvRooms.DefaultCellStyle = dataGridViewCellStyle3;
            dgvRooms.Dock = DockStyle.Fill;
            dgvRooms.EnableHeadersVisualStyles = false;
            dgvRooms.GridColor = Color.FromArgb(230, 230, 230);
            dgvRooms.Location = new Point(24, 104);
            dgvRooms.MultiSelect = false;
            dgvRooms.Name = "dgvRooms";
            dgvRooms.ReadOnly = true;
            dgvRooms.RowHeadersVisible = false;
            dgvRooms.RowTemplate.Height = 36;
            dgvRooms.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRooms.Size = new Size(352, 470);
            dgvRooms.TabIndex = 0;
            dgvRooms.CellClick += dgvRooms_CellClick;
            // 
            // colRoomNumber
            // 
            colRoomNumber.FillWeight = 70F;
            colRoomNumber.HeaderText = "Room #";
            colRoomNumber.Name = "colRoomNumber";
            colRoomNumber.ReadOnly = true;
            // 
            // colRoomType
            // 
            colRoomType.FillWeight = 80F;
            colRoomType.HeaderText = "Type";
            colRoomType.Name = "colRoomType";
            colRoomType.ReadOnly = true;
            // 
            // colStatus
            // 
            colStatus.FillWeight = 90F;
            colStatus.HeaderText = "Status";
            colStatus.Name = "colStatus";
            colStatus.ReadOnly = true;
            // 
            // colCapacity
            // 
            colCapacity.FillWeight = 65F;
            colCapacity.HeaderText = "Capacity";
            colCapacity.Name = "colCapacity";
            colCapacity.ReadOnly = true;
            // 
            // colPrice
            // 
            colPrice.FillWeight = 85F;
            colPrice.HeaderText = "Price/Night";
            colPrice.Name = "colPrice";
            colPrice.ReadOnly = true;
            // 
            // colDescription
            // 
            colDescription.FillWeight = 150F;
            colDescription.HeaderText = "Description";
            colDescription.Name = "colDescription";
            colDescription.ReadOnly = true;
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
            txtSearch.PlaceholderText = "Search rooms...";
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
            lblGridTitle.Text = "Room Inventory";
            lblGridTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // RoomManagement
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(1100, 700);
            Controls.Add(pnlBody);
            Controls.Add(pnlHeader);
            Name = "RoomManagement";
            Text = "Room Management — StaySync";
            Load += RoomManagement_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlBody.ResumeLayout(false);
            splitContainer.Panel1.ResumeLayout(false);
            splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer).EndInit();
            splitContainer.ResumeLayout(false);
            pnlFormContainer.ResumeLayout(false);
            pnlFormFields.ResumeLayout(false);
            pnlFormFields.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudCapacity).EndInit();
            pnlButtons.ResumeLayout(false);
            pnlGridContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvRooms).EndInit();
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
        private DataGridView dgvRooms;
        private DataGridViewTextBoxColumn colRoomNumber;
        private DataGridViewTextBoxColumn colRoomType;
        private DataGridViewTextBoxColumn colStatus;
        private DataGridViewTextBoxColumn colCapacity;
        private DataGridViewTextBoxColumn colPrice;
        private DataGridViewTextBoxColumn colDescription;
    }
}

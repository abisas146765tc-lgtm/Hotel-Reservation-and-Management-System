namespace Hotel_Reservation_and_Management_System
{
    partial class frmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            label1 = new Label();
            lblTagline = new Label();
            lblHome = new Label();
            lblRooms = new Label();
            lblLogin = new Label();
            pnlTitle = new Panel();
            btnLogin = new Button();
            pnlRoleBox = new Panel();
            cmbRole = new ComboBox();
            pnlPassword = new Panel();
            lblEye = new Label();
            txtPassword = new TextBox();
            pnlUsername = new Panel();
            txtUsername = new TextBox();
            lblLoginInpnl = new Label();
            pnlTitle.SuspendLayout();
            pnlRoleBox.SuspendLayout();
            pnlPassword.SuspendLayout();
            pnlUsername.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(22, 15);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(149, 36);
            label1.TabIndex = 0;
            label1.Text = "StaySync";
            label1.Click += label1_Click;
            // 
            // lblTagline
            // 
            lblTagline.AutoSize = true;
            lblTagline.BackColor = Color.Transparent;
            lblTagline.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTagline.ForeColor = Color.White;
            lblTagline.Location = new Point(22, 47);
            lblTagline.Margin = new Padding(2, 0, 2, 0);
            lblTagline.Name = "lblTagline";
            lblTagline.RightToLeft = RightToLeft.Yes;
            lblTagline.Size = new Size(349, 20);
            lblTagline.TabIndex = 1;
            lblTagline.Text = "Seamless reservations, smarter hotel operations";
            // 
            // lblHome
            // 
            lblHome.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblHome.AutoSize = true;
            lblHome.BackColor = Color.Transparent;
            lblHome.Cursor = Cursors.Hand;
            lblHome.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            lblHome.ForeColor = Color.White;
            lblHome.Location = new Point(446, 50);
            lblHome.Margin = new Padding(2, 0, 2, 0);
            lblHome.Name = "lblHome";
            lblHome.Size = new Size(53, 17);
            lblHome.TabIndex = 3;
            lblHome.Text = "HOME";
            lblHome.MouseEnter += lblHome_MouseEnter;
            lblHome.MouseLeave += lblHome_MouseLeave;
            // 
            // lblRooms
            // 
            lblRooms.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblRooms.AutoSize = true;
            lblRooms.BackColor = Color.Transparent;
            lblRooms.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            lblRooms.ForeColor = Color.White;
            lblRooms.Location = new Point(511, 50);
            lblRooms.Margin = new Padding(2, 0, 2, 0);
            lblRooms.Name = "lblRooms";
            lblRooms.Size = new Size(65, 17);
            lblRooms.TabIndex = 4;
            lblRooms.Text = "ROOMS";
            lblRooms.MouseEnter += lblHome_MouseEnter;
            lblRooms.MouseLeave += lblHome_MouseLeave;
            // 
            // lblLogin
            // 
            lblLogin.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblLogin.AutoSize = true;
            lblLogin.BackColor = Color.Transparent;
            lblLogin.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLogin.ForeColor = Color.White;
            lblLogin.Location = new Point(581, 50);
            lblLogin.Margin = new Padding(2, 0, 2, 0);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(56, 17);
            lblLogin.TabIndex = 5;
            lblLogin.Text = "LOGIN";
            lblLogin.Click += lblLogin_Click;
            lblLogin.MouseEnter += lblHome_MouseEnter;
            lblLogin.MouseLeave += lblHome_MouseLeave;
            // 
            // pnlTitle
            // 
            pnlTitle.Anchor = AnchorStyles.None;
            pnlTitle.BorderStyle = BorderStyle.FixedSingle;
            pnlTitle.Controls.Add(btnLogin);
            pnlTitle.Controls.Add(pnlRoleBox);
            pnlTitle.Controls.Add(pnlPassword);
            pnlTitle.Controls.Add(pnlUsername);
            pnlTitle.Controls.Add(lblLoginInpnl);
            pnlTitle.Location = new Point(181, 83);
            pnlTitle.Margin = new Padding(2, 2, 2, 2);
            pnlTitle.Name = "pnlTitle";
            pnlTitle.Size = new Size(323, 301);
            pnlTitle.TabIndex = 6;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = SystemColors.HotTrack;
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Microsoft Sans Serif", 11F);
            btnLogin.ForeColor = SystemColors.ButtonFace;
            btnLogin.Location = new Point(52, 198);
            btnLogin.Margin = new Padding(2, 2, 2, 2);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(209, 33);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            // 
            // pnlRoleBox
            // 
            pnlRoleBox.BackColor = Color.Transparent;
            pnlRoleBox.Controls.Add(cmbRole);
            pnlRoleBox.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pnlRoleBox.ForeColor = SystemColors.GrayText;
            pnlRoleBox.Location = new Point(52, 139);
            pnlRoleBox.Margin = new Padding(2, 2, 2, 2);
            pnlRoleBox.Name = "pnlRoleBox";
            pnlRoleBox.Size = new Size(210, 37);
            pnlRoleBox.TabIndex = 1;
            // 
            // cmbRole
            // 
            cmbRole.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRole.FlatStyle = FlatStyle.Flat;
            cmbRole.ForeColor = SystemColors.GrayText;
            cmbRole.FormattingEnabled = true;
            cmbRole.Items.AddRange(new object[] { "Super Admin", "Receptionist" });
            cmbRole.Location = new Point(3, 9);
            cmbRole.Margin = new Padding(2, 2, 2, 2);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(206, 23);
            cmbRole.TabIndex = 0;
            cmbRole.TabStop = false;
            cmbRole.SelectedIndexChanged += cmbRole_SelectedIndexChanged;
            // 
            // pnlPassword
            // 
            pnlPassword.BackColor = Color.Transparent;
            pnlPassword.Controls.Add(lblEye);
            pnlPassword.Controls.Add(txtPassword);
            pnlPassword.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pnlPassword.ForeColor = SystemColors.GrayText;
            pnlPassword.Location = new Point(52, 98);
            pnlPassword.Margin = new Padding(2, 2, 2, 2);
            pnlPassword.Name = "pnlPassword";
            pnlPassword.Size = new Size(210, 37);
            pnlPassword.TabIndex = 2;
            // 
            // lblEye
            // 
            lblEye.AutoSize = true;
            lblEye.BackColor = Color.White;
            lblEye.Cursor = Cursors.Hand;
            lblEye.Font = new Font("Segoe UI Symbol", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEye.Location = new Point(181, 12);
            lblEye.Margin = new Padding(2, 0, 2, 0);
            lblEye.Name = "lblEye";
            lblEye.Size = new Size(19, 15);
            lblEye.TabIndex = 1;
            lblEye.Text = "👁";
            lblEye.Click += lblEye_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(2, 11);
            txtPassword.Margin = new Padding(2, 2, 2, 2);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Enter Password";
            txtPassword.Size = new Size(207, 21);
            txtPassword.TabIndex = 0;
            txtPassword.TabStop = false;
            txtPassword.Enter += txtPassword_Enter;
            txtPassword.Leave += txtPassword_Leave;
            // 
            // pnlUsername
            // 
            pnlUsername.BackColor = Color.Transparent;
            pnlUsername.Controls.Add(txtUsername);
            pnlUsername.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pnlUsername.ForeColor = SystemColors.GrayText;
            pnlUsername.Location = new Point(52, 58);
            pnlUsername.Margin = new Padding(2, 2, 2, 2);
            pnlUsername.Name = "pnlUsername";
            pnlUsername.Size = new Size(210, 37);
            pnlUsername.TabIndex = 1;
            // 
            // txtUsername
            // 
            txtUsername.ForeColor = SystemColors.WindowText;
            txtUsername.Location = new Point(2, 9);
            txtUsername.Margin = new Padding(2, 2, 2, 2);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "Enter Username";
            txtUsername.Size = new Size(207, 21);
            txtUsername.TabIndex = 0;
            txtUsername.TabStop = false;
            txtUsername.Enter += txtUsername_Enter;
            txtUsername.Leave += txtUsername_Leave;
            // 
            // lblLoginInpnl
            // 
            lblLoginInpnl.Anchor = AnchorStyles.None;
            lblLoginInpnl.AutoSize = true;
            lblLoginInpnl.BackColor = Color.Transparent;
            lblLoginInpnl.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLoginInpnl.ForeColor = SystemColors.Control;
            lblLoginInpnl.Location = new Point(130, 16);
            lblLoginInpnl.Margin = new Padding(2, 0, 2, 0);
            lblLoginInpnl.Name = "lblLoginInpnl";
            lblLoginInpnl.Size = new Size(64, 20);
            lblLoginInpnl.TabIndex = 0;
            lblLoginInpnl.Text = "LOGIN";
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(685, 386);
            Controls.Add(pnlTitle);
            Controls.Add(lblLogin);
            Controls.Add(lblRooms);
            Controls.Add(lblHome);
            Controls.Add(lblTagline);
            Controls.Add(label1);
            Margin = new Padding(2, 2, 2, 2);
            MaximumSize = new Size(705, 436);
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += frmLogin_Load;
            Shown += frmLogin_Shown;
            Resize += frmLogin_Resize;
            pnlTitle.ResumeLayout(false);
            pnlTitle.PerformLayout();
            pnlRoleBox.ResumeLayout(false);
            pnlPassword.ResumeLayout(false);
            pnlPassword.PerformLayout();
            pnlUsername.ResumeLayout(false);
            pnlUsername.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblTagline;
        private Label lblHome;
        private Label lblRooms;
        private Label lblLogin;
        private Panel pnlTitle;
        private Label lblLoginpnl;
        private Label lblLoginInpnl;
        private Panel pnlUsername;
        private TextBox txtUsername;
        private Panel pnlPassword;
        private TextBox txtPassword;
        private Label lblEye;
        private Panel pnlRoleBox;
        private ComboBox cmbRole;
        private Button btnLogin;
    }
}
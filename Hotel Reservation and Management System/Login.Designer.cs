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
            label1.Font = new Font("Showcard Gothic", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(31, 25);
            label1.Name = "label1";
            label1.Size = new Size(248, 54);
            label1.TabIndex = 0;
            label1.Text = "StaySync";
            label1.Click += label1_Click;
            // 
            // lblTagline
            // 
            lblTagline.AutoSize = true;
            lblTagline.BackColor = Color.Transparent;
            lblTagline.Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTagline.ForeColor = Color.White;
            lblTagline.Location = new Point(31, 79);
            lblTagline.Name = "lblTagline";
            lblTagline.RightToLeft = RightToLeft.Yes;
            lblTagline.Size = new Size(527, 32);
            lblTagline.TabIndex = 1;
            lblTagline.Text = "Seamless reservations, smarter hotel operations";
            // 
            // lblHome
            // 
            lblHome.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblHome.AutoSize = true;
            lblHome.BackColor = Color.Transparent;
            lblHome.Cursor = Cursors.Hand;
            lblHome.Font = new Font("Segoe UI Variable Display Semib", 10F, FontStyle.Bold);
            lblHome.ForeColor = Color.White;
            lblHome.Location = new Point(637, 84);
            lblHome.Name = "lblHome";
            lblHome.Size = new Size(70, 27);
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
            lblRooms.Font = new Font("Segoe UI Variable Display Semib", 10F, FontStyle.Bold);
            lblRooms.ForeColor = Color.White;
            lblRooms.Location = new Point(730, 84);
            lblRooms.Name = "lblRooms";
            lblRooms.Size = new Size(84, 27);
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
            lblLogin.Font = new Font("Segoe UI Variable Display Semib", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLogin.ForeColor = Color.White;
            lblLogin.Location = new Point(830, 84);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(71, 27);
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
            pnlTitle.Location = new Point(259, 139);
            pnlTitle.Name = "pnlTitle";
            pnlTitle.Size = new Size(460, 500);
            pnlTitle.TabIndex = 6;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = SystemColors.HotTrack;
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI Variable Display", 11F);
            btnLogin.ForeColor = SystemColors.ButtonFace;
            btnLogin.Location = new Point(75, 330);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(299, 55);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            // 
            // pnlRoleBox
            // 
            pnlRoleBox.BackColor = Color.Transparent;
            pnlRoleBox.Controls.Add(cmbRole);
            pnlRoleBox.Font = new Font("Segoe UI Variable Display", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pnlRoleBox.ForeColor = SystemColors.GrayText;
            pnlRoleBox.Location = new Point(74, 232);
            pnlRoleBox.Name = "pnlRoleBox";
            pnlRoleBox.Size = new Size(300, 62);
            pnlRoleBox.TabIndex = 1;
            // 
            // cmbRole
            // 
            cmbRole.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRole.FlatStyle = FlatStyle.Flat;
            cmbRole.ForeColor = SystemColors.GrayText;
            cmbRole.FormattingEnabled = true;
            cmbRole.Items.AddRange(new object[] { "Super Admin", "Receptionist" });
            cmbRole.Location = new Point(4, 15);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(293, 32);
            cmbRole.TabIndex = 0;
            cmbRole.TabStop = false;
            cmbRole.SelectedIndexChanged += cmbRole_SelectedIndexChanged;
            // 
            // pnlPassword
            // 
            pnlPassword.BackColor = Color.Transparent;
            pnlPassword.Controls.Add(lblEye);
            pnlPassword.Controls.Add(txtPassword);
            pnlPassword.Font = new Font("Segoe UI Variable Display", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pnlPassword.ForeColor = SystemColors.GrayText;
            pnlPassword.Location = new Point(74, 164);
            pnlPassword.Name = "pnlPassword";
            pnlPassword.Size = new Size(300, 62);
            pnlPassword.TabIndex = 2;
            // 
            // lblEye
            // 
            lblEye.AutoSize = true;
            lblEye.BackColor = Color.White;
            lblEye.Cursor = Cursors.Hand;
            lblEye.Font = new Font("Segoe UI Symbol", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEye.Location = new Point(259, 20);
            lblEye.Name = "lblEye";
            lblEye.Size = new Size(30, 25);
            lblEye.TabIndex = 1;
            lblEye.Text = "👁";
            lblEye.Click += lblEye_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(3, 18);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Enter Password";
            txtPassword.Size = new Size(294, 31);
            txtPassword.TabIndex = 0;
            txtPassword.TabStop = false;
            txtPassword.Enter += txtPassword_Enter;
            txtPassword.Leave += txtPassword_Leave;
            // 
            // pnlUsername
            // 
            pnlUsername.BackColor = Color.Transparent;
            pnlUsername.Controls.Add(txtUsername);
            pnlUsername.Font = new Font("Segoe UI Variable Display", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pnlUsername.ForeColor = SystemColors.GrayText;
            pnlUsername.Location = new Point(74, 96);
            pnlUsername.Name = "pnlUsername";
            pnlUsername.Size = new Size(300, 62);
            pnlUsername.TabIndex = 1;
            // 
            // txtUsername
            // 
            txtUsername.ForeColor = SystemColors.WindowText;
            txtUsername.Location = new Point(3, 15);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "Enter Username";
            txtUsername.Size = new Size(294, 31);
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
            lblLoginInpnl.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLoginInpnl.ForeColor = SystemColors.Control;
            lblLoginInpnl.Location = new Point(186, 27);
            lblLoginInpnl.Name = "lblLoginInpnl";
            lblLoginInpnl.Size = new Size(87, 30);
            lblLoginInpnl.TabIndex = 0;
            lblLoginInpnl.Text = "LOGIN";
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(978, 644);
            Controls.Add(pnlTitle);
            Controls.Add(lblLogin);
            Controls.Add(lblRooms);
            Controls.Add(lblHome);
            Controls.Add(lblTagline);
            Controls.Add(label1);
            MaximumSize = new Size(1000, 700);
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
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
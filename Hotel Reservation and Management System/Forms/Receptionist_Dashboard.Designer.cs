namespace Hotel_Reservation_and_Management_System
{
    partial class Receptionist_Dashboard
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
            label1 = new Label();
            panel1 = new Panel();
            btnNewReservation = new Button();
            btnCheckIn = new Button();
            btnCheckOut = new Button();
            btnManageReservation = new Button();
            btnGuestRecord = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(13, 9);
            label1.Name = "label1";
            label1.Size = new Size(308, 73);
            label1.TabIndex = 0;
            label1.Text = "Dashboard";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.DarkOliveGreen;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(2, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(647, 102);
            panel1.TabIndex = 1;
            // 
            // btnNewReservation
            // 
            btnNewReservation.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNewReservation.Location = new Point(123, 124);
            btnNewReservation.Name = "btnNewReservation";
            btnNewReservation.Size = new Size(173, 135);
            btnNewReservation.TabIndex = 2;
            btnNewReservation.Text = "New Reservation";
            btnNewReservation.UseVisualStyleBackColor = true;
            btnNewReservation.Click += btnNewReservation_Click;
            // 
            // btnCheckIn
            // 
            btnCheckIn.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCheckIn.Location = new Point(340, 124);
            btnCheckIn.Name = "btnCheckIn";
            btnCheckIn.Size = new Size(173, 135);
            btnCheckIn.TabIndex = 3;
            btnCheckIn.Text = "Check-In";
            btnCheckIn.UseVisualStyleBackColor = true;
            btnCheckIn.Click += btnCheckIn_Click;
            // 
            // btnCheckOut
            // 
            btnCheckOut.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCheckOut.Location = new Point(12, 286);
            btnCheckOut.Name = "btnCheckOut";
            btnCheckOut.Size = new Size(173, 135);
            btnCheckOut.TabIndex = 4;
            btnCheckOut.Text = "Check-Out";
            btnCheckOut.UseVisualStyleBackColor = true;
            btnCheckOut.Click += btnCheckOut_Click;
            // 
            // btnManageReservation
            // 
            btnManageReservation.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnManageReservation.Location = new Point(228, 288);
            btnManageReservation.Name = "btnManageReservation";
            btnManageReservation.Size = new Size(173, 133);
            btnManageReservation.TabIndex = 5;
            btnManageReservation.Text = "Search/Manage Reservation";
            btnManageReservation.UseVisualStyleBackColor = true;
            btnManageReservation.Click += btnManageReservation_Click;
            // 
            // btnGuestRecord
            // 
            btnGuestRecord.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGuestRecord.Location = new Point(448, 286);
            btnGuestRecord.Name = "btnGuestRecord";
            btnGuestRecord.Size = new Size(173, 135);
            btnGuestRecord.TabIndex = 6;
            btnGuestRecord.Text = "Guest Records";
            btnGuestRecord.UseVisualStyleBackColor = true;
            btnGuestRecord.Click += btnGuestRecord_Click;
            // 
            // Receptionist_Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(650, 457);
            Controls.Add(btnGuestRecord);
            Controls.Add(btnManageReservation);
            Controls.Add(btnCheckOut);
            Controls.Add(btnCheckIn);
            Controls.Add(btnNewReservation);
            Controls.Add(panel1);
            Name = "Receptionist_Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hotel Reservation and Management System";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Button btnNewReservation;
        private Button btnCheckIn;
        private Button btnCheckOut;
        private Button btnManageReservation;
        private Button btnGuestRecord;
    }
}
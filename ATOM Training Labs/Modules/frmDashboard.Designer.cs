namespace ATOM
{
    partial class frmDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDashboard));
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.buttonsPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblAdmission = new System.Windows.Forms.Label();
            this.meetupIconPanel = new System.Windows.Forms.Panel();
            this.lblMeetup = new System.Windows.Forms.Label();
            this.iptIconPanel = new System.Windows.Forms.Panel();
            this.lblIPT = new System.Windows.Forms.Label();
            this.internshipIconPanel = new System.Windows.Forms.Panel();
            this.lblInternship = new System.Windows.Forms.Label();
            this.enquiryIconPanel = new System.Windows.Forms.Panel();
            this.lblEnquiry = new System.Windows.Forms.Label();
            this.pixBoxLogo = new System.Windows.Forms.PictureBox();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.pnlHeader.SuspendLayout();
            this.buttonsPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.meetupIconPanel.SuspendLayout();
            this.iptIconPanel.SuspendLayout();
            this.internshipIconPanel.SuspendLayout();
            this.enquiryIconPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pixBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(198)))));
            this.pnlHeader.Controls.Add(this.buttonsPanel);
            this.pnlHeader.Controls.Add(this.pixBoxLogo);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1233, 60);
            this.pnlHeader.TabIndex = 4;
            this.pnlHeader.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlHeader_Paint);
            // 
            // buttonsPanel
            // 
            this.buttonsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonsPanel.Controls.Add(this.panel2);
            this.buttonsPanel.Controls.Add(this.meetupIconPanel);
            this.buttonsPanel.Controls.Add(this.iptIconPanel);
            this.buttonsPanel.Controls.Add(this.internshipIconPanel);
            this.buttonsPanel.Controls.Add(this.enquiryIconPanel);
            this.buttonsPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonsPanel.Location = new System.Drawing.Point(605, -2);
            this.buttonsPanel.Name = "buttonsPanel";
            this.buttonsPanel.Size = new System.Drawing.Size(590, 64);
            this.buttonsPanel.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblAdmission);
            this.panel2.Location = new System.Drawing.Point(125, 14);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(105, 35);
            this.panel2.TabIndex = 5;
            // 
            // lblAdmission
            // 
            this.lblAdmission.AutoSize = true;
            this.lblAdmission.BackColor = System.Drawing.Color.Transparent;
            this.lblAdmission.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblAdmission.ForeColor = System.Drawing.Color.White;
            this.lblAdmission.Location = new System.Drawing.Point(9, 7);
            this.lblAdmission.Name = "lblAdmission";
            this.lblAdmission.Size = new System.Drawing.Size(91, 20);
            this.lblAdmission.TabIndex = 0;
            this.lblAdmission.Text = "Admission";
            this.lblAdmission.Click += new System.EventHandler(this.lblAdmission_Click);
            // 
            // meetupIconPanel
            // 
            this.meetupIconPanel.Controls.Add(this.lblMeetup);
            this.meetupIconPanel.Location = new System.Drawing.Point(476, 14);
            this.meetupIconPanel.Name = "meetupIconPanel";
            this.meetupIconPanel.Size = new System.Drawing.Size(101, 35);
            this.meetupIconPanel.TabIndex = 3;
            // 
            // lblMeetup
            // 
            this.lblMeetup.AutoSize = true;
            this.lblMeetup.BackColor = System.Drawing.Color.Transparent;
            this.lblMeetup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblMeetup.ForeColor = System.Drawing.Color.White;
            this.lblMeetup.Location = new System.Drawing.Point(14, 7);
            this.lblMeetup.Name = "lblMeetup";
            this.lblMeetup.Size = new System.Drawing.Size(69, 20);
            this.lblMeetup.TabIndex = 0;
            this.lblMeetup.Text = "Meetup";
            this.lblMeetup.Click += new System.EventHandler(this.lblMeetup_Click);
            // 
            // iptIconPanel
            // 
            this.iptIconPanel.Controls.Add(this.lblIPT);
            this.iptIconPanel.Location = new System.Drawing.Point(365, 14);
            this.iptIconPanel.Name = "iptIconPanel";
            this.iptIconPanel.Size = new System.Drawing.Size(93, 35);
            this.iptIconPanel.TabIndex = 2;
            // 
            // lblIPT
            // 
            this.lblIPT.AutoSize = true;
            this.lblIPT.BackColor = System.Drawing.Color.Transparent;
            this.lblIPT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblIPT.ForeColor = System.Drawing.Color.White;
            this.lblIPT.Location = new System.Drawing.Point(25, 7);
            this.lblIPT.Name = "lblIPT";
            this.lblIPT.Size = new System.Drawing.Size(36, 20);
            this.lblIPT.TabIndex = 0;
            this.lblIPT.Text = "IPT";
            this.lblIPT.Click += new System.EventHandler(this.lblIPT_Click);
            // 
            // internshipIconPanel
            // 
            this.internshipIconPanel.Controls.Add(this.lblInternship);
            this.internshipIconPanel.Location = new System.Drawing.Point(246, 14);
            this.internshipIconPanel.Name = "internshipIconPanel";
            this.internshipIconPanel.Size = new System.Drawing.Size(101, 35);
            this.internshipIconPanel.TabIndex = 1;
            // 
            // lblInternship
            // 
            this.lblInternship.AutoSize = true;
            this.lblInternship.BackColor = System.Drawing.Color.Transparent;
            this.lblInternship.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblInternship.ForeColor = System.Drawing.Color.White;
            this.lblInternship.Location = new System.Drawing.Point(6, 7);
            this.lblInternship.Name = "lblInternship";
            this.lblInternship.Size = new System.Drawing.Size(90, 20);
            this.lblInternship.TabIndex = 0;
            this.lblInternship.Text = "Internship";
            this.lblInternship.Click += new System.EventHandler(this.lblInternship_Click);
            // 
            // enquiryIconPanel
            // 
            this.enquiryIconPanel.Controls.Add(this.lblEnquiry);
            this.enquiryIconPanel.Location = new System.Drawing.Point(16, 14);
            this.enquiryIconPanel.Name = "enquiryIconPanel";
            this.enquiryIconPanel.Size = new System.Drawing.Size(93, 35);
            this.enquiryIconPanel.TabIndex = 0;
            // 
            // lblEnquiry
            // 
            this.lblEnquiry.AutoSize = true;
            this.lblEnquiry.BackColor = System.Drawing.Color.Transparent;
            this.lblEnquiry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblEnquiry.ForeColor = System.Drawing.Color.White;
            this.lblEnquiry.Location = new System.Drawing.Point(9, 7);
            this.lblEnquiry.Name = "lblEnquiry";
            this.lblEnquiry.Size = new System.Drawing.Size(69, 20);
            this.lblEnquiry.TabIndex = 0;
            this.lblEnquiry.Text = "Enquiry";
            this.lblEnquiry.Click += new System.EventHandler(this.lblEnquiry_Click);
            // 
            // pixBoxLogo
            // 
            this.pixBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pixBoxLogo.Image")));
            this.pixBoxLogo.Location = new System.Drawing.Point(43, 12);
            this.pixBoxLogo.Name = "pixBoxLogo";
            this.pixBoxLogo.Size = new System.Drawing.Size(105, 30);
            this.pixBoxLogo.TabIndex = 6;
            this.pixBoxLogo.TabStop = false;
            // 
            // pnlContainer
            // 
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainer.Location = new System.Drawing.Point(0, 60);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(1233, 562);
            this.pnlContainer.TabIndex = 5;
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1233, 622);
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.pnlHeader);
            this.KeyPreview = true;
            this.Name = "frmDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "D A S H B O A R D";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmDashboard_Load);
            this.pnlHeader.ResumeLayout(false);
            this.buttonsPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.meetupIconPanel.ResumeLayout(false);
            this.meetupIconPanel.PerformLayout();
            this.iptIconPanel.ResumeLayout(false);
            this.iptIconPanel.PerformLayout();
            this.internshipIconPanel.ResumeLayout(false);
            this.internshipIconPanel.PerformLayout();
            this.enquiryIconPanel.ResumeLayout(false);
            this.enquiryIconPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pixBoxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel buttonsPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblAdmission;
        private System.Windows.Forms.Panel meetupIconPanel;
        private System.Windows.Forms.Label lblMeetup;
        private System.Windows.Forms.Panel iptIconPanel;
        private System.Windows.Forms.Label lblIPT;
        private System.Windows.Forms.Panel internshipIconPanel;
        private System.Windows.Forms.Label lblInternship;
        private System.Windows.Forms.Panel enquiryIconPanel;
        private System.Windows.Forms.Label lblEnquiry;
        private System.Windows.Forms.PictureBox pixBoxLogo;
        private System.Windows.Forms.Panel pnlContainer;



    }
}
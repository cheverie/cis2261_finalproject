namespace SleepEasyRegistry
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.txtCurrentUser = new System.Windows.Forms.RichTextBox();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tStripManagement = new System.Windows.Forms.ToolStripDropDownButton();
            this.tStripServices = new System.Windows.Forms.ToolStripMenuItem();
            this.tStripStaff = new System.Windows.Forms.ToolStripMenuItem();
            this.tStripReports = new System.Windows.Forms.ToolStripDropDownButton();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.report2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddReg = new System.Windows.Forms.Button();
            this.dataGridReg = new System.Windows.Forms.DataGridView();
            this.colRegId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colroomNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmpId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRoomRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPayMethod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCurrentStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCheckInDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCheckOutDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStayDuration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCostOfStay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEditReg = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnDeleteReg = new System.Windows.Forms.DataGridViewButtonColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridReg)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCurrentUser
            // 
            this.txtCurrentUser.Location = new System.Drawing.Point(16, 41);
            this.txtCurrentUser.Name = "txtCurrentUser";
            this.txtCurrentUser.ReadOnly = true;
            this.txtCurrentUser.Size = new System.Drawing.Size(128, 28);
            this.txtCurrentUser.TabIndex = 4;
            this.txtCurrentUser.TabStop = false;
            this.txtCurrentUser.Text = "";
            // 
            // btnLogOut
            // 
            this.btnLogOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogOut.Location = new System.Drawing.Point(989, 41);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(101, 30);
            this.btnLogOut.TabIndex = 2;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tStripManagement,
            this.tStripReports});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1102, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tStripManagement
            // 
            this.tStripManagement.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tStripManagement.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tStripServices,
            this.tStripStaff});
            this.tStripManagement.Image = ((System.Drawing.Image)(resources.GetObject("tStripManagement.Image")));
            this.tStripManagement.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tStripManagement.Name = "tStripManagement";
            this.tStripManagement.Size = new System.Drawing.Size(91, 22);
            this.tStripManagement.Text = "Management";
            this.tStripManagement.ToolTipText = "tStripManage";
            // 
            // tStripServices
            // 
            this.tStripServices.Name = "tStripServices";
            this.tStripServices.Size = new System.Drawing.Size(116, 22);
            this.tStripServices.Text = "Services";
            // 
            // tStripStaff
            // 
            this.tStripStaff.Name = "tStripStaff";
            this.tStripStaff.Size = new System.Drawing.Size(116, 22);
            this.tStripStaff.Text = "Staff";
            // 
            // tStripReports
            // 
            this.tStripReports.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tStripReports.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reportsToolStripMenuItem,
            this.report2ToolStripMenuItem});
            this.tStripReports.Image = ((System.Drawing.Image)(resources.GetObject("tStripReports.Image")));
            this.tStripReports.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tStripReports.Name = "tStripReports";
            this.tStripReports.Size = new System.Drawing.Size(60, 22);
            this.tStripReports.Text = "Reports";
            this.tStripReports.ToolTipText = "tStripReports";
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.reportsToolStripMenuItem.Text = "Availability Report";
            this.reportsToolStripMenuItem.Click += new System.EventHandler(this.reportsToolStripMenuItem_Click);
            // 
            // report2ToolStripMenuItem
            // 
            this.report2ToolStripMenuItem.Name = "report2ToolStripMenuItem";
            this.report2ToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.report2ToolStripMenuItem.Text = "Check-Out Bill Report";
            // 
            // btnAddReg
            // 
            this.btnAddReg.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAddReg.Location = new System.Drawing.Point(433, 43);
            this.btnAddReg.Name = "btnAddReg";
            this.btnAddReg.Size = new System.Drawing.Size(160, 28);
            this.btnAddReg.TabIndex = 1;
            this.btnAddReg.Text = "Add Registration";
            this.btnAddReg.UseVisualStyleBackColor = true;
            this.btnAddReg.Click += new System.EventHandler(this.btnAddReg_Click);
            // 
            // dataGridReg
            // 
            this.dataGridReg.AllowUserToAddRows = false;
            this.dataGridReg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridReg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridReg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridReg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colRegId,
            this.colroomNum,
            this.colEmpId,
            this.colRoomRate,
            this.colLastName,
            this.colFirstName,
            this.colAddress,
            this.colPayMethod,
            this.colCurrentStatus,
            this.colCheckInDate,
            this.colCheckOutDate,
            this.colStayDuration,
            this.colCostOfStay,
            this.colEmail,
            this.colPhoneNumber,
            this.btnEditReg,
            this.btnDeleteReg});
            this.dataGridReg.Location = new System.Drawing.Point(18, 77);
            this.dataGridReg.Name = "dataGridReg";
            this.dataGridReg.Size = new System.Drawing.Size(1072, 725);
            this.dataGridReg.TabIndex = 3;
            this.dataGridReg.TabStop = false;
            this.dataGridReg.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridReg_CellContentClick);
            // 
            // colRegId
            // 
            this.colRegId.HeaderText = "Registration ID";
            this.colRegId.Name = "colRegId";
            this.colRegId.ReadOnly = true;
            // 
            // colroomNum
            // 
            this.colroomNum.HeaderText = "Room Number";
            this.colroomNum.Name = "colroomNum";
            this.colroomNum.ReadOnly = true;
            // 
            // colEmpId
            // 
            this.colEmpId.HeaderText = "Employee ID";
            this.colEmpId.Name = "colEmpId";
            this.colEmpId.ReadOnly = true;
            // 
            // colRoomRate
            // 
            this.colRoomRate.HeaderText = "Room Rate";
            this.colRoomRate.Name = "colRoomRate";
            this.colRoomRate.ReadOnly = true;
            // 
            // colLastName
            // 
            this.colLastName.HeaderText = "Last Name";
            this.colLastName.Name = "colLastName";
            this.colLastName.ReadOnly = true;
            // 
            // colFirstName
            // 
            this.colFirstName.HeaderText = "First Name";
            this.colFirstName.Name = "colFirstName";
            this.colFirstName.ReadOnly = true;
            // 
            // colAddress
            // 
            this.colAddress.HeaderText = "Address";
            this.colAddress.Name = "colAddress";
            this.colAddress.ReadOnly = true;
            // 
            // colPayMethod
            // 
            this.colPayMethod.HeaderText = "Payment Method";
            this.colPayMethod.Name = "colPayMethod";
            this.colPayMethod.ReadOnly = true;
            // 
            // colCurrentStatus
            // 
            this.colCurrentStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colCurrentStatus.HeaderText = "Current Status";
            this.colCurrentStatus.Name = "colCurrentStatus";
            this.colCurrentStatus.ReadOnly = true;
            // 
            // colCheckInDate
            // 
            this.colCheckInDate.HeaderText = "Check-in Date";
            this.colCheckInDate.Name = "colCheckInDate";
            this.colCheckInDate.ReadOnly = true;
            // 
            // colCheckOutDate
            // 
            this.colCheckOutDate.HeaderText = "Check-Out Date";
            this.colCheckOutDate.Name = "colCheckOutDate";
            this.colCheckOutDate.ReadOnly = true;
            // 
            // colStayDuration
            // 
            this.colStayDuration.HeaderText = "Stay Duration";
            this.colStayDuration.Name = "colStayDuration";
            this.colStayDuration.ReadOnly = true;
            // 
            // colCostOfStay
            // 
            this.colCostOfStay.HeaderText = "Cost Of Stay";
            this.colCostOfStay.Name = "colCostOfStay";
            this.colCostOfStay.ReadOnly = true;
            // 
            // colEmail
            // 
            this.colEmail.HeaderText = "Email";
            this.colEmail.Name = "colEmail";
            this.colEmail.ReadOnly = true;
            // 
            // colPhoneNumber
            // 
            this.colPhoneNumber.HeaderText = "Phone Number";
            this.colPhoneNumber.Name = "colPhoneNumber";
            this.colPhoneNumber.ReadOnly = true;
            // 
            // btnEditReg
            // 
            this.btnEditReg.HeaderText = "Actions";
            this.btnEditReg.Name = "btnEditReg";
            this.btnEditReg.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btnEditReg.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.btnEditReg.Text = "Edit";
            this.btnEditReg.ToolTipText = "Edit";
            this.btnEditReg.UseColumnTextForButtonValue = true;
            // 
            // btnDeleteReg
            // 
            this.btnDeleteReg.HeaderText = "";
            this.btnDeleteReg.Name = "btnDeleteReg";
            this.btnDeleteReg.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btnDeleteReg.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.btnDeleteReg.Text = "Delete";
            this.btnDeleteReg.ToolTipText = "Delete";
            this.btnDeleteReg.UseColumnTextForButtonValue = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 814);
            this.Controls.Add(this.btnAddReg);
            this.Controls.Add(this.dataGridReg);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.txtCurrentUser);
            this.Name = "frmMain";
            this.Text = "SER";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridReg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtCurrentUser;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton tStripManagement;
        private System.Windows.Forms.ToolStripMenuItem tStripServices;
        private System.Windows.Forms.ToolStripDropDownButton tStripReports;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem report2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tStripStaff;
        private System.Windows.Forms.Button btnAddReg;
        private System.Windows.Forms.DataGridView dataGridReg;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRegId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colroomNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmpId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRoomRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPayMethod;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCurrentStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCheckInDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCheckOutDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStayDuration;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCostOfStay;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhoneNumber;
        private System.Windows.Forms.DataGridViewButtonColumn btnEditReg;
        private System.Windows.Forms.DataGridViewButtonColumn btnDeleteReg;
    }
}
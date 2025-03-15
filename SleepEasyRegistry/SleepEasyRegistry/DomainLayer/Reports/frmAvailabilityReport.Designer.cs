namespace SleepEasyRegistry.DomainLayer
{
    partial class frmAvailabilityReport
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
            this.dtpCheckOut = new System.Windows.Forms.DateTimePicker();
            this.lblCheckOut = new System.Windows.Forms.Label();
            this.dtpCheckIn = new System.Windows.Forms.DateTimePicker();
            this.lblCheckIn = new System.Windows.Forms.Label();
            this.dgvAvailability = new System.Windows.Forms.DataGridView();
            this.colRoomNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRoomDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRoomType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRoomRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblAvailabilityReport = new System.Windows.Forms.Label();
            this.lblSysName = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.lblSystemName = new System.Windows.Forms.Label();
            this.lblReportType = new System.Windows.Forms.Label();
            this.lblReportPurpose = new System.Windows.Forms.Label();
            this.lblPurpose = new System.Windows.Forms.Label();
            this.lblEmployee = new System.Windows.Forms.Label();
            this.txtEmployee = new System.Windows.Forms.TextBox();
            this.btnGenerateReport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvailability)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpCheckOut
            // 
            this.dtpCheckOut.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpCheckOut.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpCheckOut.CustomFormat = "yyyy-MM-dd";
            this.dtpCheckOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpCheckOut.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpCheckOut.Location = new System.Drawing.Point(336, 80);
            this.dtpCheckOut.MinDate = new System.DateTime(2025, 2, 22, 0, 0, 0, 0);
            this.dtpCheckOut.Name = "dtpCheckOut";
            this.dtpCheckOut.Size = new System.Drawing.Size(111, 27);
            this.dtpCheckOut.TabIndex = 57;
            this.dtpCheckOut.ValueChanged += new System.EventHandler(this.dtpCheckOut_ValueChanged);
            // 
            // lblCheckOut
            // 
            this.lblCheckOut.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCheckOut.AutoSize = true;
            this.lblCheckOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckOut.Location = new System.Drawing.Point(501, 40);
            this.lblCheckOut.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCheckOut.Name = "lblCheckOut";
            this.lblCheckOut.Size = new System.Drawing.Size(154, 25);
            this.lblCheckOut.TabIndex = 56;
            this.lblCheckOut.Text = "Check-Out Date";
            // 
            // dtpCheckIn
            // 
            this.dtpCheckIn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpCheckIn.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpCheckIn.CustomFormat = "yyyy-MM-dd";
            this.dtpCheckIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpCheckIn.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpCheckIn.Location = new System.Drawing.Point(506, 80);
            this.dtpCheckIn.MinDate = new System.DateTime(2025, 3, 9, 0, 0, 0, 0);
            this.dtpCheckIn.Name = "dtpCheckIn";
            this.dtpCheckIn.Size = new System.Drawing.Size(111, 27);
            this.dtpCheckIn.TabIndex = 55;
            this.dtpCheckIn.ValueChanged += new System.EventHandler(this.dtpCheckIn_ValueChanged);
            // 
            // lblCheckIn
            // 
            this.lblCheckIn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCheckIn.AutoSize = true;
            this.lblCheckIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckIn.Location = new System.Drawing.Point(331, 40);
            this.lblCheckIn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCheckIn.Name = "lblCheckIn";
            this.lblCheckIn.Size = new System.Drawing.Size(138, 25);
            this.lblCheckIn.TabIndex = 54;
            this.lblCheckIn.Text = "Check-In Date";
            // 
            // dgvAvailability
            // 
            this.dgvAvailability.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAvailability.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAvailability.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colRoomNum,
            this.colRoomDesc,
            this.colRoomType,
            this.colRoomRate});
            this.dgvAvailability.Location = new System.Drawing.Point(25, 275);
            this.dgvAvailability.Name = "dgvAvailability";
            this.dgvAvailability.Size = new System.Drawing.Size(749, 448);
            this.dgvAvailability.TabIndex = 58;
            // 
            // colRoomNum
            // 
            this.colRoomNum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colRoomNum.HeaderText = "Room Number";
            this.colRoomNum.Name = "colRoomNum";
            this.colRoomNum.ReadOnly = true;
            // 
            // colRoomDesc
            // 
            this.colRoomDesc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colRoomDesc.HeaderText = "Room Description";
            this.colRoomDesc.Name = "colRoomDesc";
            this.colRoomDesc.ReadOnly = true;
            // 
            // colRoomType
            // 
            this.colRoomType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colRoomType.HeaderText = "Room Type";
            this.colRoomType.Name = "colRoomType";
            this.colRoomType.ReadOnly = true;
            // 
            // colRoomRate
            // 
            this.colRoomRate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colRoomRate.HeaderText = "Room Rate";
            this.colRoomRate.Name = "colRoomRate";
            this.colRoomRate.ReadOnly = true;
            // 
            // lblAvailabilityReport
            // 
            this.lblAvailabilityReport.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblAvailabilityReport.AutoSize = true;
            this.lblAvailabilityReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvailabilityReport.Location = new System.Drawing.Point(36, 165);
            this.lblAvailabilityReport.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAvailabilityReport.Name = "lblAvailabilityReport";
            this.lblAvailabilityReport.Size = new System.Drawing.Size(134, 20);
            this.lblAvailabilityReport.TabIndex = 59;
            this.lblAvailabilityReport.Text = "Availability Report";
            // 
            // lblSysName
            // 
            this.lblSysName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblSysName.AutoSize = true;
            this.lblSysName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSysName.Location = new System.Drawing.Point(32, 81);
            this.lblSysName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSysName.Name = "lblSysName";
            this.lblSysName.Size = new System.Drawing.Size(151, 20);
            this.lblSysName.TabIndex = 60;
            this.lblSysName.Text = "Sleep Easy Registry";
            // 
            // lblDate
            // 
            this.lblDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(225, 40);
            this.lblDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(66, 25);
            this.lblDate.TabIndex = 61;
            this.lblDate.Text = "DATE";
            // 
            // txtDate
            // 
            this.txtDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDate.Location = new System.Drawing.Point(213, 78);
            this.txtDate.Name = "txtDate";
            this.txtDate.ReadOnly = true;
            this.txtDate.Size = new System.Drawing.Size(78, 26);
            this.txtDate.TabIndex = 62;
            // 
            // lblSystemName
            // 
            this.lblSystemName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblSystemName.AutoSize = true;
            this.lblSystemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSystemName.Location = new System.Drawing.Point(31, 40);
            this.lblSystemName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSystemName.Name = "lblSystemName";
            this.lblSystemName.Size = new System.Drawing.Size(159, 25);
            this.lblSystemName.TabIndex = 63;
            this.lblSystemName.Text = "SYSTEM NAME";
            // 
            // lblReportType
            // 
            this.lblReportType.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblReportType.AutoSize = true;
            this.lblReportType.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReportType.Location = new System.Drawing.Point(35, 126);
            this.lblReportType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReportType.Name = "lblReportType";
            this.lblReportType.Size = new System.Drawing.Size(156, 25);
            this.lblReportType.TabIndex = 64;
            this.lblReportType.Text = "REPORT NAME";
            // 
            // lblReportPurpose
            // 
            this.lblReportPurpose.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblReportPurpose.AutoSize = true;
            this.lblReportPurpose.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReportPurpose.Location = new System.Drawing.Point(350, 126);
            this.lblReportPurpose.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReportPurpose.Name = "lblReportPurpose";
            this.lblReportPurpose.Size = new System.Drawing.Size(194, 25);
            this.lblReportPurpose.TabIndex = 65;
            this.lblReportPurpose.Text = "REPORT PURPOSE";
            // 
            // lblPurpose
            // 
            this.lblPurpose.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblPurpose.AutoSize = true;
            this.lblPurpose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPurpose.Location = new System.Drawing.Point(297, 165);
            this.lblPurpose.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPurpose.Name = "lblPurpose";
            this.lblPurpose.Size = new System.Drawing.Size(302, 20);
            this.lblPurpose.TabIndex = 66;
            this.lblPurpose.Text = "Lists available Rooms for Specified Dates";
            // 
            // lblEmployee
            // 
            this.lblEmployee.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblEmployee.AutoSize = true;
            this.lblEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployee.Location = new System.Drawing.Point(35, 199);
            this.lblEmployee.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmployee.Name = "lblEmployee";
            this.lblEmployee.Size = new System.Drawing.Size(121, 25);
            this.lblEmployee.TabIndex = 67;
            this.lblEmployee.Text = "EMPLOYEE";
            // 
            // txtEmployee
            // 
            this.txtEmployee.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployee.Location = new System.Drawing.Point(36, 235);
            this.txtEmployee.Name = "txtEmployee";
            this.txtEmployee.ReadOnly = true;
            this.txtEmployee.Size = new System.Drawing.Size(116, 26);
            this.txtEmployee.TabIndex = 68;
            // 
            // btnGenerateReport
            // 
            this.btnGenerateReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateReport.Location = new System.Drawing.Point(287, 227);
            this.btnGenerateReport.Name = "btnGenerateReport";
            this.btnGenerateReport.Size = new System.Drawing.Size(160, 42);
            this.btnGenerateReport.TabIndex = 69;
            this.btnGenerateReport.Text = "Generate Report";
            this.btnGenerateReport.UseVisualStyleBackColor = true;
            this.btnGenerateReport.Click += new System.EventHandler(this.btnGenerateReport_Click);
            // 
            // frmAvailabilityReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 735);
            this.Controls.Add(this.btnGenerateReport);
            this.Controls.Add(this.txtEmployee);
            this.Controls.Add(this.lblEmployee);
            this.Controls.Add(this.lblPurpose);
            this.Controls.Add(this.lblReportPurpose);
            this.Controls.Add(this.lblReportType);
            this.Controls.Add(this.lblSystemName);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblSysName);
            this.Controls.Add(this.lblAvailabilityReport);
            this.Controls.Add(this.dgvAvailability);
            this.Controls.Add(this.dtpCheckOut);
            this.Controls.Add(this.lblCheckOut);
            this.Controls.Add(this.dtpCheckIn);
            this.Controls.Add(this.lblCheckIn);
            this.Name = "frmAvailabilityReport";
            this.Text = "Availability Report";
            this.Load += new System.EventHandler(this.frmAvailabilityReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvailability)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dtpCheckOut;
        private System.Windows.Forms.Label lblCheckOut;
        private System.Windows.Forms.DateTimePicker dtpCheckIn;
        private System.Windows.Forms.Label lblCheckIn;
        private System.Windows.Forms.DataGridView dgvAvailability;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRoomNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRoomDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRoomType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRoomRate;
        private System.Windows.Forms.Label lblAvailabilityReport;
        private System.Windows.Forms.Label lblSysName;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Label lblSystemName;
        private System.Windows.Forms.Label lblReportType;
        private System.Windows.Forms.Label lblReportPurpose;
        private System.Windows.Forms.Label lblPurpose;
        private System.Windows.Forms.Label lblEmployee;
        private System.Windows.Forms.TextBox txtEmployee;
        private System.Windows.Forms.Button btnGenerateReport;
    }
}
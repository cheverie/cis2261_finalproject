namespace SleepEasyRegistry
{
    partial class frmAddRegistration
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
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.lblPhoneNum = new System.Windows.Forms.Label();
            this.lblPayMethod = new System.Windows.Forms.Label();
            this.txtRoomRate = new System.Windows.Forms.TextBox();
            this.lblRoomRate = new System.Windows.Forms.Label();
            this.txtRoomType = new System.Windows.Forms.TextBox();
            this.lblRoomType = new System.Windows.Forms.Label();
            this.cmbAvailableRooms = new System.Windows.Forms.ComboBox();
            this.dtpCheckOut = new System.Windows.Forms.DateTimePicker();
            this.lblCheckOut = new System.Windows.Forms.Label();
            this.lblAvailableRooms = new System.Windows.Forms.Label();
            this.dtpCheckIn = new System.Windows.Forms.DateTimePicker();
            this.lblCheckIn = new System.Windows.Forms.Label();
            this.lblRegHeader = new System.Windows.Forms.Label();
            this.lblGuestHeader = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnConfirmReg = new System.Windows.Forms.Button();
            this.cmbPayMethod = new System.Windows.Forms.ComboBox();
            this.txtCostOfStay = new System.Windows.Forms.TextBox();
            this.lblcostOfStay = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(233, 251);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(148, 20);
            this.txtEmail.TabIndex = 64;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(33, 248);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(48, 20);
            this.lblEmail.TabIndex = 63;
            this.lblEmail.Text = "Email";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(233, 208);
            this.txtPhoneNumber.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPhoneNumber.MaxLength = 10;
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(148, 20);
            this.txtPhoneNumber.TabIndex = 62;
            this.txtPhoneNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhoneNumber_KeyPress);
            // 
            // lblPhoneNum
            // 
            this.lblPhoneNum.AutoSize = true;
            this.lblPhoneNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNum.Location = new System.Drawing.Point(33, 205);
            this.lblPhoneNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPhoneNum.Name = "lblPhoneNum";
            this.lblPhoneNum.Size = new System.Drawing.Size(115, 20);
            this.lblPhoneNum.TabIndex = 61;
            this.lblPhoneNum.Text = "Phone Number";
            // 
            // lblPayMethod
            // 
            this.lblPayMethod.AutoSize = true;
            this.lblPayMethod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayMethod.Location = new System.Drawing.Point(33, 291);
            this.lblPayMethod.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPayMethod.Name = "lblPayMethod";
            this.lblPayMethod.Size = new System.Drawing.Size(129, 20);
            this.lblPayMethod.TabIndex = 59;
            this.lblPayMethod.Text = "Payment Method";
            // 
            // txtRoomRate
            // 
            this.txtRoomRate.Location = new System.Drawing.Point(192, 610);
            this.txtRoomRate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRoomRate.Name = "txtRoomRate";
            this.txtRoomRate.ReadOnly = true;
            this.txtRoomRate.Size = new System.Drawing.Size(148, 20);
            this.txtRoomRate.TabIndex = 58;
            // 
            // lblRoomRate
            // 
            this.lblRoomRate.AutoSize = true;
            this.lblRoomRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomRate.Location = new System.Drawing.Point(33, 610);
            this.lblRoomRate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRoomRate.Name = "lblRoomRate";
            this.lblRoomRate.Size = new System.Drawing.Size(95, 20);
            this.lblRoomRate.TabIndex = 57;
            this.lblRoomRate.Text = "Room Rate:";
            // 
            // txtRoomType
            // 
            this.txtRoomType.Location = new System.Drawing.Point(192, 573);
            this.txtRoomType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRoomType.Name = "txtRoomType";
            this.txtRoomType.ReadOnly = true;
            this.txtRoomType.Size = new System.Drawing.Size(148, 20);
            this.txtRoomType.TabIndex = 56;
            // 
            // lblRoomType
            // 
            this.lblRoomType.AutoSize = true;
            this.lblRoomType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomType.Location = new System.Drawing.Point(33, 573);
            this.lblRoomType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRoomType.Name = "lblRoomType";
            this.lblRoomType.Size = new System.Drawing.Size(94, 20);
            this.lblRoomType.TabIndex = 55;
            this.lblRoomType.Text = "Room Type:";
            // 
            // cmbAvailableRooms
            // 
            this.cmbAvailableRooms.FormattingEnabled = true;
            this.cmbAvailableRooms.Location = new System.Drawing.Point(192, 536);
            this.cmbAvailableRooms.Name = "cmbAvailableRooms";
            this.cmbAvailableRooms.Size = new System.Drawing.Size(148, 21);
            this.cmbAvailableRooms.TabIndex = 54;
            this.cmbAvailableRooms.SelectedIndexChanged += new System.EventHandler(this.cmbAvailableRooms_SelectedIndexChanged);
            // 
            // dtpCheckOut
            // 
            this.dtpCheckOut.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpCheckOut.CustomFormat = "yyyy-MM-dd";
            this.dtpCheckOut.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpCheckOut.Location = new System.Drawing.Point(192, 463);
            this.dtpCheckOut.MinDate = new System.DateTime(2025, 2, 22, 0, 0, 0, 0);
            this.dtpCheckOut.Name = "dtpCheckOut";
            this.dtpCheckOut.Size = new System.Drawing.Size(275, 20);
            this.dtpCheckOut.TabIndex = 53;
            // 
            // lblCheckOut
            // 
            this.lblCheckOut.AutoSize = true;
            this.lblCheckOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckOut.Location = new System.Drawing.Point(33, 467);
            this.lblCheckOut.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCheckOut.Name = "lblCheckOut";
            this.lblCheckOut.Size = new System.Drawing.Size(124, 20);
            this.lblCheckOut.TabIndex = 52;
            this.lblCheckOut.Text = "Check-Out Date";
            // 
            // lblAvailableRooms
            // 
            this.lblAvailableRooms.AutoSize = true;
            this.lblAvailableRooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvailableRooms.Location = new System.Drawing.Point(33, 537);
            this.lblAvailableRooms.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAvailableRooms.Name = "lblAvailableRooms";
            this.lblAvailableRooms.Size = new System.Drawing.Size(131, 20);
            this.lblAvailableRooms.TabIndex = 51;
            this.lblAvailableRooms.Text = "Available Rooms:";
            // 
            // dtpCheckIn
            // 
            this.dtpCheckIn.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpCheckIn.CustomFormat = "yyyy-MM-dd";
            this.dtpCheckIn.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpCheckIn.Location = new System.Drawing.Point(192, 431);
            this.dtpCheckIn.MinDate = new System.DateTime(2025, 2, 22, 0, 0, 0, 0);
            this.dtpCheckIn.Name = "dtpCheckIn";
            this.dtpCheckIn.Size = new System.Drawing.Size(275, 20);
            this.dtpCheckIn.TabIndex = 50;
            // 
            // lblCheckIn
            // 
            this.lblCheckIn.AutoSize = true;
            this.lblCheckIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckIn.Location = new System.Drawing.Point(33, 431);
            this.lblCheckIn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCheckIn.Name = "lblCheckIn";
            this.lblCheckIn.Size = new System.Drawing.Size(112, 20);
            this.lblCheckIn.TabIndex = 49;
            this.lblCheckIn.Text = "Check-In Date";
            // 
            // lblRegHeader
            // 
            this.lblRegHeader.AutoSize = true;
            this.lblRegHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegHeader.Location = new System.Drawing.Point(16, 385);
            this.lblRegHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRegHeader.Name = "lblRegHeader";
            this.lblRegHeader.Size = new System.Drawing.Size(205, 24);
            this.lblRegHeader.TabIndex = 48;
            this.lblRegHeader.Text = "Registration Information";
            // 
            // lblGuestHeader
            // 
            this.lblGuestHeader.AutoSize = true;
            this.lblGuestHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuestHeader.Location = new System.Drawing.Point(13, 9);
            this.lblGuestHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGuestHeader.Name = "lblGuestHeader";
            this.lblGuestHeader.Size = new System.Drawing.Size(156, 24);
            this.lblGuestHeader.TabIndex = 47;
            this.lblGuestHeader.Text = "Guest Information";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(233, 165);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(148, 20);
            this.txtAddress.TabIndex = 46;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(233, 57);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(148, 20);
            this.txtFirstName.TabIndex = 45;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(33, 162);
            this.lblAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(68, 20);
            this.lblAddress.TabIndex = 44;
            this.lblAddress.Text = "Address";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(33, 108);
            this.lblLastName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(86, 20);
            this.lblLastName.TabIndex = 43;
            this.lblLastName.Text = "Last Name";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(33, 54);
            this.lblFirstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(86, 20);
            this.lblFirstName.TabIndex = 42;
            this.lblFirstName.Text = "First Name";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(233, 108);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(148, 20);
            this.txtLastName.TabIndex = 41;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.LightGray;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(316, 707);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(108, 52);
            this.btnCancel.TabIndex = 66;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnConfirmReg
            // 
            this.btnConfirmReg.BackColor = System.Drawing.Color.LightGray;
            this.btnConfirmReg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmReg.Location = new System.Drawing.Point(61, 707);
            this.btnConfirmReg.Name = "btnConfirmReg";
            this.btnConfirmReg.Size = new System.Drawing.Size(108, 52);
            this.btnConfirmReg.TabIndex = 65;
            this.btnConfirmReg.Text = "Confirm Registration";
            this.btnConfirmReg.UseVisualStyleBackColor = false;
            this.btnConfirmReg.Click += new System.EventHandler(this.btnConfirmReg_Click);
            // 
            // cmbPayMethod
            // 
            this.cmbPayMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPayMethod.FormattingEnabled = true;
            this.cmbPayMethod.Items.AddRange(new object[] {
            "Debit Card",
            "Credit Card",
            "Cash"});
            this.cmbPayMethod.Location = new System.Drawing.Point(233, 291);
            this.cmbPayMethod.Name = "cmbPayMethod";
            this.cmbPayMethod.Size = new System.Drawing.Size(148, 21);
            this.cmbPayMethod.TabIndex = 67;
            // 
            // txtCostOfStay
            // 
            this.txtCostOfStay.Location = new System.Drawing.Point(192, 646);
            this.txtCostOfStay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCostOfStay.Name = "txtCostOfStay";
            this.txtCostOfStay.ReadOnly = true;
            this.txtCostOfStay.Size = new System.Drawing.Size(148, 20);
            this.txtCostOfStay.TabIndex = 97;
            // 
            // lblcostOfStay
            // 
            this.lblcostOfStay.AutoSize = true;
            this.lblcostOfStay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcostOfStay.Location = new System.Drawing.Point(33, 646);
            this.lblcostOfStay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblcostOfStay.Name = "lblcostOfStay";
            this.lblcostOfStay.Size = new System.Drawing.Size(136, 20);
            this.lblcostOfStay.TabIndex = 96;
            this.lblcostOfStay.Text = "Registration Cost:";
            // 
            // frmAddRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 819);
            this.Controls.Add(this.txtCostOfStay);
            this.Controls.Add(this.lblcostOfStay);
            this.Controls.Add(this.cmbPayMethod);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirmReg);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.lblPhoneNum);
            this.Controls.Add(this.lblPayMethod);
            this.Controls.Add(this.txtRoomRate);
            this.Controls.Add(this.lblRoomRate);
            this.Controls.Add(this.txtRoomType);
            this.Controls.Add(this.lblRoomType);
            this.Controls.Add(this.cmbAvailableRooms);
            this.Controls.Add(this.dtpCheckOut);
            this.Controls.Add(this.lblCheckOut);
            this.Controls.Add(this.lblAvailableRooms);
            this.Controls.Add(this.dtpCheckIn);
            this.Controls.Add(this.lblCheckIn);
            this.Controls.Add(this.lblRegHeader);
            this.Controls.Add(this.lblGuestHeader);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.txtLastName);
            this.Name = "frmAddRegistration";
            this.Text = "Registration";
            this.Load += new System.EventHandler(this.frmAddRegistration_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Label lblPhoneNum;
        private System.Windows.Forms.Label lblPayMethod;
        private System.Windows.Forms.TextBox txtRoomRate;
        private System.Windows.Forms.Label lblRoomRate;
        private System.Windows.Forms.TextBox txtRoomType;
        private System.Windows.Forms.Label lblRoomType;
        private System.Windows.Forms.ComboBox cmbAvailableRooms;
        private System.Windows.Forms.DateTimePicker dtpCheckOut;
        private System.Windows.Forms.Label lblCheckOut;
        private System.Windows.Forms.Label lblAvailableRooms;
        private System.Windows.Forms.DateTimePicker dtpCheckIn;
        private System.Windows.Forms.Label lblCheckIn;
        private System.Windows.Forms.Label lblRegHeader;
        private System.Windows.Forms.Label lblGuestHeader;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnConfirmReg;
        private System.Windows.Forms.ComboBox cmbPayMethod;
        private System.Windows.Forms.TextBox txtCostOfStay;
        private System.Windows.Forms.Label lblcostOfStay;
    }
}
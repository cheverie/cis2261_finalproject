﻿namespace SleepEasyRegistry.DomainLayer
{
    partial class frmEditReg
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
            this.cmbPayMethod = new System.Windows.Forms.ComboBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.lblPhoneNum = new System.Windows.Forms.Label();
            this.lblPayMethod = new System.Windows.Forms.Label();
            this.txtRoomRate = new System.Windows.Forms.TextBox();
            this.lblRoomRate = new System.Windows.Forms.Label();
            this.txtRoomType = new System.Windows.Forms.TextBox();
            this.lblRoomType = new System.Windows.Forms.Label();
            this.cmbRooms = new System.Windows.Forms.ComboBox();
            this.dtpCheckOut = new System.Windows.Forms.DateTimePicker();
            this.lblCheckOut = new System.Windows.Forms.Label();
            this.lblRoom = new System.Windows.Forms.Label();
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
            this.btnConfirmEdit = new System.Windows.Forms.Button();
            this.lblcostOfStay = new System.Windows.Forms.Label();
            this.txtCostOfStay = new System.Windows.Forms.TextBox();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtRegId = new System.Windows.Forms.TextBox();
            this.lblRegId = new System.Windows.Forms.Label();
            this.btnServiceCharge = new System.Windows.Forms.Button();
            this.lblServices = new System.Windows.Forms.Label();
            this.cmbServices = new System.Windows.Forms.ComboBox();
            this.lblServivePrice = new System.Windows.Forms.Label();
            this.lblServiceQuntity = new System.Windows.Forms.Label();
            this.txtServicePrice = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.lblServiceHeader = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbPayMethod
            // 
            this.cmbPayMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPayMethod.FormattingEnabled = true;
            this.cmbPayMethod.Items.AddRange(new object[] {
            "Debit Card",
            "Credit Card",
            "Cash"});
            this.cmbPayMethod.Location = new System.Drawing.Point(233, 316);
            this.cmbPayMethod.Name = "cmbPayMethod";
            this.cmbPayMethod.Size = new System.Drawing.Size(148, 21);
            this.cmbPayMethod.TabIndex = 5;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(233, 276);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(148, 20);
            this.txtEmail.TabIndex = 4;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(33, 273);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(48, 20);
            this.lblEmail.TabIndex = 19;
            this.lblEmail.Text = "Email";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(233, 233);
            this.txtPhoneNumber.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPhoneNumber.MaxLength = 10;
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(148, 20);
            this.txtPhoneNumber.TabIndex = 3;
            // 
            // lblPhoneNum
            // 
            this.lblPhoneNum.AutoSize = true;
            this.lblPhoneNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNum.Location = new System.Drawing.Point(33, 230);
            this.lblPhoneNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPhoneNum.Name = "lblPhoneNum";
            this.lblPhoneNum.Size = new System.Drawing.Size(115, 20);
            this.lblPhoneNum.TabIndex = 18;
            this.lblPhoneNum.Text = "Phone Number";
            // 
            // lblPayMethod
            // 
            this.lblPayMethod.AutoSize = true;
            this.lblPayMethod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayMethod.Location = new System.Drawing.Point(33, 317);
            this.lblPayMethod.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPayMethod.Name = "lblPayMethod";
            this.lblPayMethod.Size = new System.Drawing.Size(129, 20);
            this.lblPayMethod.TabIndex = 20;
            this.lblPayMethod.Text = "Payment Method";
            // 
            // txtRoomRate
            // 
            this.txtRoomRate.Location = new System.Drawing.Point(189, 520);
            this.txtRoomRate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRoomRate.Name = "txtRoomRate";
            this.txtRoomRate.ReadOnly = true;
            this.txtRoomRate.Size = new System.Drawing.Size(148, 20);
            this.txtRoomRate.TabIndex = 30;
            // 
            // lblRoomRate
            // 
            this.lblRoomRate.AutoSize = true;
            this.lblRoomRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomRate.Location = new System.Drawing.Point(30, 520);
            this.lblRoomRate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRoomRate.Name = "lblRoomRate";
            this.lblRoomRate.Size = new System.Drawing.Size(95, 20);
            this.lblRoomRate.TabIndex = 26;
            this.lblRoomRate.Text = "Room Rate:";
            // 
            // txtRoomType
            // 
            this.txtRoomType.Location = new System.Drawing.Point(189, 483);
            this.txtRoomType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRoomType.Name = "txtRoomType";
            this.txtRoomType.ReadOnly = true;
            this.txtRoomType.Size = new System.Drawing.Size(148, 20);
            this.txtRoomType.TabIndex = 29;
            // 
            // lblRoomType
            // 
            this.lblRoomType.AutoSize = true;
            this.lblRoomType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomType.Location = new System.Drawing.Point(30, 483);
            this.lblRoomType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRoomType.Name = "lblRoomType";
            this.lblRoomType.Size = new System.Drawing.Size(94, 20);
            this.lblRoomType.TabIndex = 25;
            this.lblRoomType.Text = "Room Type:";
            // 
            // cmbRooms
            // 
            this.cmbRooms.FormattingEnabled = true;
            this.cmbRooms.Location = new System.Drawing.Point(189, 446);
            this.cmbRooms.Name = "cmbRooms";
            this.cmbRooms.Size = new System.Drawing.Size(148, 21);
            this.cmbRooms.TabIndex = 8;
            this.cmbRooms.SelectedIndexChanged += new System.EventHandler(this.cmbRooms_SelectedIndexChanged);
            // 
            // dtpCheckOut
            // 
            this.dtpCheckOut.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpCheckOut.CustomFormat = "yyyy-MM-dd";
            this.dtpCheckOut.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpCheckOut.Location = new System.Drawing.Point(189, 414);
            this.dtpCheckOut.MinDate = new System.DateTime(2025, 2, 22, 0, 0, 0, 0);
            this.dtpCheckOut.Name = "dtpCheckOut";
            this.dtpCheckOut.Size = new System.Drawing.Size(275, 20);
            this.dtpCheckOut.TabIndex = 7;
            this.dtpCheckOut.ValueChanged += new System.EventHandler(this.dtpCheckOut_ValueChanged);
            // 
            // lblCheckOut
            // 
            this.lblCheckOut.AutoSize = true;
            this.lblCheckOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckOut.Location = new System.Drawing.Point(30, 418);
            this.lblCheckOut.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCheckOut.Name = "lblCheckOut";
            this.lblCheckOut.Size = new System.Drawing.Size(124, 20);
            this.lblCheckOut.TabIndex = 23;
            this.lblCheckOut.Text = "Check-Out Date";
            // 
            // lblRoom
            // 
            this.lblRoom.AutoSize = true;
            this.lblRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoom.Location = new System.Drawing.Point(30, 447);
            this.lblRoom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRoom.Name = "lblRoom";
            this.lblRoom.Size = new System.Drawing.Size(56, 20);
            this.lblRoom.TabIndex = 24;
            this.lblRoom.Text = "Room:";
            // 
            // dtpCheckIn
            // 
            this.dtpCheckIn.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpCheckIn.CustomFormat = "yyyy-MM-dd";
            this.dtpCheckIn.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpCheckIn.Location = new System.Drawing.Point(189, 382);
            this.dtpCheckIn.MinDate = new System.DateTime(2010, 2, 22, 0, 0, 0, 0);
            this.dtpCheckIn.Name = "dtpCheckIn";
            this.dtpCheckIn.Size = new System.Drawing.Size(275, 20);
            this.dtpCheckIn.TabIndex = 6;
            this.dtpCheckIn.ValueChanged += new System.EventHandler(this.dtpCheckIn_ValueChanged);
            // 
            // lblCheckIn
            // 
            this.lblCheckIn.AutoSize = true;
            this.lblCheckIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckIn.Location = new System.Drawing.Point(30, 382);
            this.lblCheckIn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCheckIn.Name = "lblCheckIn";
            this.lblCheckIn.Size = new System.Drawing.Size(112, 20);
            this.lblCheckIn.TabIndex = 22;
            this.lblCheckIn.Text = "Check-In Date";
            // 
            // lblRegHeader
            // 
            this.lblRegHeader.AutoSize = true;
            this.lblRegHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegHeader.Location = new System.Drawing.Point(13, 336);
            this.lblRegHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRegHeader.Name = "lblRegHeader";
            this.lblRegHeader.Size = new System.Drawing.Size(205, 24);
            this.lblRegHeader.TabIndex = 21;
            this.lblRegHeader.Text = "Registration Information";
            // 
            // lblGuestHeader
            // 
            this.lblGuestHeader.AutoSize = true;
            this.lblGuestHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuestHeader.Location = new System.Drawing.Point(13, 34);
            this.lblGuestHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGuestHeader.Name = "lblGuestHeader";
            this.lblGuestHeader.Size = new System.Drawing.Size(156, 24);
            this.lblGuestHeader.TabIndex = 14;
            this.lblGuestHeader.Text = "Guest Information";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(233, 190);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(148, 20);
            this.txtAddress.TabIndex = 2;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(233, 82);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(148, 20);
            this.txtFirstName.TabIndex = 0;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(33, 187);
            this.lblAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(68, 20);
            this.lblAddress.TabIndex = 17;
            this.lblAddress.Text = "Address";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(33, 133);
            this.lblLastName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(86, 20);
            this.lblLastName.TabIndex = 16;
            this.lblLastName.Text = "Last Name";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(33, 79);
            this.lblFirstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(86, 20);
            this.lblFirstName.TabIndex = 15;
            this.lblFirstName.Text = "First Name";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(233, 133);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(148, 20);
            this.txtLastName.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.LightGray;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(301, 820);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(108, 52);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnConfirmEdit
            // 
            this.btnConfirmEdit.BackColor = System.Drawing.Color.LightGray;
            this.btnConfirmEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmEdit.Location = new System.Drawing.Point(61, 820);
            this.btnConfirmEdit.Name = "btnConfirmEdit";
            this.btnConfirmEdit.Size = new System.Drawing.Size(108, 52);
            this.btnConfirmEdit.TabIndex = 10;
            this.btnConfirmEdit.Text = "Confirm Edit";
            this.btnConfirmEdit.UseVisualStyleBackColor = false;
            this.btnConfirmEdit.Click += new System.EventHandler(this.btnConfirmEdit_Click);
            // 
            // lblcostOfStay
            // 
            this.lblcostOfStay.AutoSize = true;
            this.lblcostOfStay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcostOfStay.Location = new System.Drawing.Point(30, 559);
            this.lblcostOfStay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblcostOfStay.Name = "lblcostOfStay";
            this.lblcostOfStay.Size = new System.Drawing.Size(103, 20);
            this.lblcostOfStay.TabIndex = 27;
            this.lblcostOfStay.Text = "Cost Of Stay:";
            // 
            // txtCostOfStay
            // 
            this.txtCostOfStay.Location = new System.Drawing.Point(189, 559);
            this.txtCostOfStay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCostOfStay.Name = "txtCostOfStay";
            this.txtCostOfStay.ReadOnly = true;
            this.txtCostOfStay.Size = new System.Drawing.Size(148, 20);
            this.txtCostOfStay.TabIndex = 31;
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "Registered",
            "Checked-In",
            "Checked-Out"});
            this.cmbStatus.Location = new System.Drawing.Point(189, 595);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(148, 21);
            this.cmbStatus.TabIndex = 9;
            this.cmbStatus.SelectedIndexChanged += new System.EventHandler(this.cmbRooms_SelectedIndexChanged);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(30, 596);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(150, 20);
            this.lblStatus.TabIndex = 28;
            this.lblStatus.Text = "Registration Status:";
            // 
            // txtRegId
            // 
            this.txtRegId.Location = new System.Drawing.Point(146, 9);
            this.txtRegId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRegId.Name = "txtRegId";
            this.txtRegId.ReadOnly = true;
            this.txtRegId.Size = new System.Drawing.Size(63, 20);
            this.txtRegId.TabIndex = 13;
            // 
            // lblRegId
            // 
            this.lblRegId.AutoSize = true;
            this.lblRegId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRegId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegId.Location = new System.Drawing.Point(16, 9);
            this.lblRegId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRegId.Name = "lblRegId";
            this.lblRegId.Size = new System.Drawing.Size(122, 22);
            this.lblRegId.TabIndex = 12;
            this.lblRegId.Text = "Registration ID:";
            // 
            // btnServiceCharge
            // 
            this.btnServiceCharge.BackColor = System.Drawing.Color.LightGray;
            this.btnServiceCharge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServiceCharge.Location = new System.Drawing.Point(187, 828);
            this.btnServiceCharge.Name = "btnServiceCharge";
            this.btnServiceCharge.Size = new System.Drawing.Size(98, 37);
            this.btnServiceCharge.TabIndex = 32;
            this.btnServiceCharge.Text = "Service Charge";
            this.btnServiceCharge.UseVisualStyleBackColor = false;
            this.btnServiceCharge.Click += new System.EventHandler(this.btnServiceCharge_Click);
            // 
            // lblServices
            // 
            this.lblServices.AutoSize = true;
            this.lblServices.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServices.Location = new System.Drawing.Point(73, 679);
            this.lblServices.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblServices.Name = "lblServices";
            this.lblServices.Size = new System.Drawing.Size(136, 20);
            this.lblServices.TabIndex = 33;
            this.lblServices.Text = "Available Services";
            // 
            // cmbServices
            // 
            this.cmbServices.FormattingEnabled = true;
            this.cmbServices.Location = new System.Drawing.Point(229, 681);
            this.cmbServices.Name = "cmbServices";
            this.cmbServices.Size = new System.Drawing.Size(148, 21);
            this.cmbServices.TabIndex = 34;
            this.cmbServices.SelectedIndexChanged += new System.EventHandler(this.cmbServices_SelectedIndexChanged);
            // 
            // lblServivePrice
            // 
            this.lblServivePrice.AutoSize = true;
            this.lblServivePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServivePrice.Location = new System.Drawing.Point(73, 714);
            this.lblServivePrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblServivePrice.Name = "lblServivePrice";
            this.lblServivePrice.Size = new System.Drawing.Size(100, 20);
            this.lblServivePrice.TabIndex = 35;
            this.lblServivePrice.Text = "Service Price";
            // 
            // lblServiceQuntity
            // 
            this.lblServiceQuntity.AutoSize = true;
            this.lblServiceQuntity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServiceQuntity.Location = new System.Drawing.Point(73, 747);
            this.lblServiceQuntity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblServiceQuntity.Name = "lblServiceQuntity";
            this.lblServiceQuntity.Size = new System.Drawing.Size(68, 20);
            this.lblServiceQuntity.TabIndex = 36;
            this.lblServiceQuntity.Text = "Qunatity";
            // 
            // txtServicePrice
            // 
            this.txtServicePrice.Location = new System.Drawing.Point(229, 716);
            this.txtServicePrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtServicePrice.Name = "txtServicePrice";
            this.txtServicePrice.ReadOnly = true;
            this.txtServicePrice.Size = new System.Drawing.Size(148, 20);
            this.txtServicePrice.TabIndex = 37;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(229, 749);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(148, 20);
            this.txtQuantity.TabIndex = 38;
            // 
            // lblServiceHeader
            // 
            this.lblServiceHeader.AutoSize = true;
            this.lblServiceHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServiceHeader.Location = new System.Drawing.Point(157, 654);
            this.lblServiceHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblServiceHeader.Name = "lblServiceHeader";
            this.lblServiceHeader.Size = new System.Drawing.Size(140, 24);
            this.lblServiceHeader.TabIndex = 39;
            this.lblServiceHeader.Text = "Service Charge";
            // 
            // frmEditReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 884);
            this.Controls.Add(this.lblServiceHeader);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.txtServicePrice);
            this.Controls.Add(this.lblServiceQuntity);
            this.Controls.Add(this.lblServivePrice);
            this.Controls.Add(this.cmbServices);
            this.Controls.Add(this.lblServices);
            this.Controls.Add(this.btnServiceCharge);
            this.Controls.Add(this.txtRegId);
            this.Controls.Add(this.lblRegId);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.txtCostOfStay);
            this.Controls.Add(this.lblcostOfStay);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirmEdit);
            this.Controls.Add(this.cmbPayMethod);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.lblPhoneNum);
            this.Controls.Add(this.lblPayMethod);
            this.Controls.Add(this.txtRoomRate);
            this.Controls.Add(this.lblRoomRate);
            this.Controls.Add(this.txtRoomType);
            this.Controls.Add(this.lblRoomType);
            this.Controls.Add(this.cmbRooms);
            this.Controls.Add(this.dtpCheckOut);
            this.Controls.Add(this.lblCheckOut);
            this.Controls.Add(this.lblRoom);
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
            this.Name = "frmEditReg";
            this.Text = "frmEditReg";
            this.Load += new System.EventHandler(this.frmEditReg_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbPayMethod;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Label lblPhoneNum;
        private System.Windows.Forms.Label lblPayMethod;
        private System.Windows.Forms.TextBox txtRoomRate;
        private System.Windows.Forms.Label lblRoomRate;
        private System.Windows.Forms.TextBox txtRoomType;
        private System.Windows.Forms.Label lblRoomType;
        private System.Windows.Forms.ComboBox cmbRooms;
        private System.Windows.Forms.DateTimePicker dtpCheckOut;
        private System.Windows.Forms.Label lblCheckOut;
        private System.Windows.Forms.Label lblRoom;
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
        private System.Windows.Forms.Button btnConfirmEdit;
        private System.Windows.Forms.Label lblcostOfStay;
        private System.Windows.Forms.TextBox txtCostOfStay;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtRegId;
        private System.Windows.Forms.Label lblRegId;
        private System.Windows.Forms.Button btnServiceCharge;
        private System.Windows.Forms.Label lblServices;
        private System.Windows.Forms.ComboBox cmbServices;
        private System.Windows.Forms.Label lblServivePrice;
        private System.Windows.Forms.Label lblServiceQuntity;
        private System.Windows.Forms.TextBox txtServicePrice;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label lblServiceHeader;
    }
}
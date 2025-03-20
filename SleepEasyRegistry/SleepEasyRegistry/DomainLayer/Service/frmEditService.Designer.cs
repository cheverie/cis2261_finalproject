using System.ComponentModel;

namespace SleepEasyRegistry.DomainLayer
{
    partial class frmEditService
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.txtServiceId = new System.Windows.Forms.TextBox();
            this.lblServiceId = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtAvailability = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblAvailability = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnConfirmEdit = new System.Windows.Forms.Button();
            this.txtType = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtServiceId
            // 
            this.txtServiceId.Location = new System.Drawing.Point(143, 73);
            this.txtServiceId.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtServiceId.Name = "txtServiceId";
            this.txtServiceId.ReadOnly = true;
            this.txtServiceId.Size = new System.Drawing.Size(83, 22);
            this.txtServiceId.TabIndex = 100;
            // 
            // lblServiceId
            // 
            this.lblServiceId.Location = new System.Drawing.Point(37, 76);
            this.lblServiceId.Name = "lblServiceId";
            this.lblServiceId.Size = new System.Drawing.Size(100, 23);
            this.lblServiceId.TabIndex = 101;
            this.lblServiceId.Text = "Service ID:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(143, 118);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(196, 22);
            this.txtName.TabIndex = 102;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(143, 165);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(196, 22);
            this.txtPrice.TabIndex = 103;
            // 
            // txtAvailability
            // 
            this.txtAvailability.Location = new System.Drawing.Point(143, 259);
            this.txtAvailability.Name = "txtAvailability";
            this.txtAvailability.Size = new System.Drawing.Size(196, 22);
            this.txtAvailability.TabIndex = 105;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(143, 309);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(196, 22);
            this.txtDescription.TabIndex = 106;
            // 
            // lblName
            // 
            this.lblName.Location = new System.Drawing.Point(37, 121);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(100, 23);
            this.lblName.TabIndex = 107;
            this.lblName.Text = "Name";
            // 
            // lblPrice
            // 
            this.lblPrice.Location = new System.Drawing.Point(37, 168);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(100, 23);
            this.lblPrice.TabIndex = 108;
            this.lblPrice.Text = "Price";
            // 
            // lblType
            // 
            this.lblType.Location = new System.Drawing.Point(37, 215);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(100, 23);
            this.lblType.TabIndex = 109;
            this.lblType.Text = "Type";
            // 
            // lblAvailability
            // 
            this.lblAvailability.Location = new System.Drawing.Point(37, 262);
            this.lblAvailability.Name = "lblAvailability";
            this.lblAvailability.Size = new System.Drawing.Size(100, 23);
            this.lblAvailability.TabIndex = 110;
            this.lblAvailability.Text = "Availability";
            // 
            // lblDescription
            // 
            this.lblDescription.Location = new System.Drawing.Point(37, 312);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(100, 23);
            this.lblDescription.TabIndex = 111;
            this.lblDescription.Text = "Description";
            // 
            // lblTitle
            // 
            this.lblTitle.Location = new System.Drawing.Point(157, 25);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(182, 23);
            this.lblTitle.TabIndex = 112;
            this.lblTitle.Text = "Edit Service Information";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.LightGray;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(301, 378);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(144, 64);
            this.btnCancel.TabIndex = 114;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnConfirmEdit
            // 
            this.btnConfirmEdit.BackColor = System.Drawing.Color.LightGray;
            this.btnConfirmEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmEdit.Location = new System.Drawing.Point(37, 378);
            this.btnConfirmEdit.Margin = new System.Windows.Forms.Padding(4);
            this.btnConfirmEdit.Name = "btnConfirmEdit";
            this.btnConfirmEdit.Size = new System.Drawing.Size(144, 64);
            this.btnConfirmEdit.TabIndex = 113;
            this.btnConfirmEdit.Text = "Confirm Edit";
            this.btnConfirmEdit.UseVisualStyleBackColor = false;
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(143, 212);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(196, 22);
            this.txtType.TabIndex = 115;
            // 
            // frmEditService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 479);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirmEdit);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblAvailability);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtAvailability);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblServiceId);
            this.Controls.Add(this.txtServiceId);
            this.Name = "frmEditService";
            this.Text = "frmEditService";
            this.Load += new System.EventHandler(this.frmEditService_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox txtType;

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnConfirmEdit;

        private System.Windows.Forms.TextBox txtAvailability;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblAvailability;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblTitle;

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPrice;

        private System.Windows.Forms.TextBox txtServiceId;
        private System.Windows.Forms.Label lblServiceId;

        #endregion
    }
}
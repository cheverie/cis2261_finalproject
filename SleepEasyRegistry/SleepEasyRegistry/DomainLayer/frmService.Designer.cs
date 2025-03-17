using System.ComponentModel;

namespace SleepEasyRegistry.DomainLayer
{
    partial class frmService
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
            this.txtCurrentUser = new System.Windows.Forms.RichTextBox();
            this.btnAddService = new System.Windows.Forms.Button();
            this.dataGridService = new System.Windows.Forms.DataGridView();
            this.colServiceId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colavailability = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEditService = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnDeleteService = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridService)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCurrentUser
            // 
            this.txtCurrentUser.Location = new System.Drawing.Point(13, 40);
            this.txtCurrentUser.Margin = new System.Windows.Forms.Padding(4);
            this.txtCurrentUser.Name = "txtCurrentUser";
            this.txtCurrentUser.ReadOnly = true;
            this.txtCurrentUser.Size = new System.Drawing.Size(169, 34);
            this.txtCurrentUser.TabIndex = 3;
            this.txtCurrentUser.Text = "";
            // 
            // btnAddService
            // 
            this.btnAddService.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAddService.Location = new System.Drawing.Point(607, 40);
            this.btnAddService.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddService.Name = "btnAddService";
            this.btnAddService.Size = new System.Drawing.Size(213, 34);
            this.btnAddService.TabIndex = 8;
            this.btnAddService.Text = "Add Service";
            this.btnAddService.UseVisualStyleBackColor = true;
            this.btnAddService.Click += new System.EventHandler(this.btnAddService_Click);
            // 
            // dataGridService
            // 
            this.dataGridService.AllowUserToAddRows = false;
            this.dataGridService.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridService.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridService.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridService.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.colServiceId, this.colName, this.colPrice, this.colType, this.colavailability, this.colDescription, this.btnEditService, this.btnDeleteService });
            this.dataGridService.Location = new System.Drawing.Point(13, 82);
            this.dataGridService.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridService.Name = "dataGridService";
            this.dataGridService.Size = new System.Drawing.Size(1432, 420);
            this.dataGridService.TabIndex = 10;
            this.dataGridService.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridService_CellContentClick);
            // 
            // colServiceId
            // 
            this.colServiceId.HeaderText = "Service ID";
            this.colServiceId.Name = "colServiceId";
            this.colServiceId.ReadOnly = true;
            // 
            // colName
            // 
            this.colName.HeaderText = "Name";
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            // 
            // colPrice
            // 
            this.colPrice.HeaderText = "Price";
            this.colPrice.Name = "colPrice";
            this.colPrice.ReadOnly = true;
            // 
            // colType
            // 
            this.colType.HeaderText = "Type";
            this.colType.Name = "colType";
            this.colType.ReadOnly = true;
            // 
            // colavailability
            // 
            this.colavailability.HeaderText = "Availability";
            this.colavailability.Name = "colavailability";
            this.colavailability.ReadOnly = true;
            // 
            // colDescription
            // 
            this.colDescription.HeaderText = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.ReadOnly = true;
            // 
            // btnEditService
            // 
            this.btnEditService.HeaderText = "Actions";
            this.btnEditService.Name = "btnEditService";
            this.btnEditService.Text = "Edit";
            this.btnEditService.ToolTipText = "Edit";
            this.btnEditService.UseColumnTextForButtonValue = true;
            // 
            // btnDeleteService
            // 
            this.btnDeleteService.HeaderText = "";
            this.btnDeleteService.Name = "btnDeleteService";
            this.btnDeleteService.Text = "Delete";
            this.btnDeleteService.ToolTipText = "Delete";
            this.btnDeleteService.UseColumnTextForButtonValue = true;
            // 
            // frmService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1466, 515);
            this.Controls.Add(this.dataGridService);
            this.Controls.Add(this.btnAddService);
            this.Controls.Add(this.txtCurrentUser);
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "frmService";
            this.Load += new System.EventHandler(this.frmViewService_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridService)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.DataGridViewButtonColumn btnDeleteService;
        private System.Windows.Forms.DataGridViewButtonColumn btnEditService;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn colavailability;
        private System.Windows.Forms.DataGridViewTextBoxColumn colType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colServiceId;
        private System.Windows.Forms.DataGridView dataGridService;

        private System.Windows.Forms.Button btnAddService;

        private System.Windows.Forms.RichTextBox txtCurrentUser;

        #endregion
    }
}
namespace SleepEasyRegistry.DomainLayer
{
    partial class frmStaff
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
            this.btnAddStaff = new System.Windows.Forms.Button();
            this.dataGridStaff = new System.Windows.Forms.DataGridView();
            this.colEmpId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEditStaff = new System.Windows.Forms.DataGridViewButtonColumn();
            this.txtCurrentUser = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStaff)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddStaff
            // 
            this.btnAddStaff.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAddStaff.Location = new System.Drawing.Point(466, 7);
            this.btnAddStaff.Name = "btnAddStaff";
            this.btnAddStaff.Size = new System.Drawing.Size(160, 28);
            this.btnAddStaff.TabIndex = 11;
            this.btnAddStaff.Text = "Add Staff";
            this.btnAddStaff.UseVisualStyleBackColor = true;
            this.btnAddStaff.Click += new System.EventHandler(this.btnAddStaff_Click);
            // 
            // dataGridStaff
            // 
            this.dataGridStaff.AllowUserToAddRows = false;
            this.dataGridStaff.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridStaff.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridStaff.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colEmpId,
            this.colLastName,
            this.colFirstName,
            this.colTitle,
            this.btnEditStaff});
            this.dataGridStaff.Location = new System.Drawing.Point(16, 41);
            this.dataGridStaff.Name = "dataGridStaff";
            this.dataGridStaff.Size = new System.Drawing.Size(1072, 747);
            this.dataGridStaff.TabIndex = 10;
            this.dataGridStaff.TabStop = false;
            this.dataGridStaff.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridStaff_CellContentClick);
            // 
            // colEmpId
            // 
            this.colEmpId.HeaderText = "Employee ID";
            this.colEmpId.Name = "colEmpId";
            this.colEmpId.ReadOnly = true;
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
            // colTitle
            // 
            this.colTitle.HeaderText = "Title";
            this.colTitle.Name = "colTitle";
            this.colTitle.ReadOnly = true;
            // 
            // btnEditStaff
            // 
            this.btnEditStaff.HeaderText = "Actions";
            this.btnEditStaff.Name = "btnEditStaff";
            this.btnEditStaff.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btnEditStaff.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.btnEditStaff.Text = "Edit";
            this.btnEditStaff.ToolTipText = "Edit";
            this.btnEditStaff.UseColumnTextForButtonValue = true;
            // 
            // txtCurrentUser
            // 
            this.txtCurrentUser.Location = new System.Drawing.Point(14, 7);
            this.txtCurrentUser.Name = "txtCurrentUser";
            this.txtCurrentUser.ReadOnly = true;
            this.txtCurrentUser.Size = new System.Drawing.Size(128, 28);
            this.txtCurrentUser.TabIndex = 8;
            this.txtCurrentUser.Text = "";
            // 
            // frmStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 814);
            this.Controls.Add(this.btnAddStaff);
            this.Controls.Add(this.dataGridStaff);
            this.Controls.Add(this.txtCurrentUser);
            this.Name = "frmStaff";
            this.Text = "Staff";
            this.Load += new System.EventHandler(this.frmStaff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStaff)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAddStaff;
        private System.Windows.Forms.DataGridView dataGridStaff;
        private System.Windows.Forms.RichTextBox txtCurrentUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmpId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTitle;
        private System.Windows.Forms.DataGridViewButtonColumn btnEditStaff;
    }
}
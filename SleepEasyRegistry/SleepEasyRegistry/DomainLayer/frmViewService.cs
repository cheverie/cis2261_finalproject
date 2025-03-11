using System.Windows.Forms;
using SleepEasyRegistry.DomainLayer;
using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace SleepEasyRegistry.DomainLayer
{
    public partial class frmViewService : Form
    {
        // public string gCurrentEmpId;
        public int gAccessLevel;
        public string gFullName;

        // Database connection string
        private readonly string connectionString = "server=localhost;database=sleepeasyregistry;uid=root;pwd=\"\";";
        
        public frmViewService()
        {
            InitializeComponent();
        }
        
        private void frmViewService_Load(object sender, EventArgs e)
        {
            // LoadServiceData();
        }

        private void LoadServiceData()
        {
            
        }

        /// Sets the current user information and adjusts UI visibility based on access level.
        public void SetCurrentUser(string fullName, int accessLevel)
        {
            txtCurrentUser.Text = $"Welcome, {fullName}";
            gAccessLevel = accessLevel;
            gFullName = fullName;
        }
    }
}
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using SleepEasyRegistry.BusinessObjects;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Xml.Linq;

namespace SleepEasyRegistry.DomainLayer
{
    public partial class frmEditService : Form
    {
        private string connectionString = "server=localhost;database=sleepeasyregistry;uid=root;pwd=\"\";";
        private int serviceId;
        private frmService _serviceForm;

        public frmEditService(int serviceId, frmService serviceForm)
        {
            InitializeComponent();
            _serviceForm = serviceForm; // Store the reference to the main form
            this.serviceId = serviceId;
            // LoadServiceDetails();
        }

        private void frmEditService_Load(object sender, EventArgs e)
        {
            // PopulateRoom();

        }
    }
}
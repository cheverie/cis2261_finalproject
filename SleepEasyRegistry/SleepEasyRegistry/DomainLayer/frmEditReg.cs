using MySql.Data.MySqlClient;
using SleepEasyRegistry.BusinessObjects;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace SleepEasyRegistry.DomainLayer
{
    public partial class frmEditReg : Form
    {
        private string connectionString = "server=localhost;database=sleepeasyregistry;uid=root;pwd=\"\";";
        private List<Room> availableRooms = new List<Room>(); // List to store room information
        private int regId;
        private frmMain _mainForm;

        public frmEditReg(int regId, frmMain mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm; // Store the reference to the main form
            this.regId = regId;
            LoadRegistrationDetails();
        }

        private void frmEditReg_Load(object sender, EventArgs e)
        {
            PopulateRooms();

        }


        private void LoadRegistrationDetails()
        {
            string query = "SELECT * FROM registration WHERE regId = @regId";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@regId", regId);

                try
                {
                    conn.Open();
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Set the registration ID
                            txtRegId.Text = regId.ToString();

                            txtFirstName.Text = reader["firstName"].ToString();
                            txtLastName.Text = reader["lastName"].ToString();
                            txtEmail.Text = reader["email"].ToString();
                            txtPhoneNumber.Text = reader["phoneNumber"].ToString().Replace("-", "");
                            txtAddress.Text = reader["address"].ToString();
                            cmbPayMethod.Text = reader["payMethod"].ToString();

                            // Retrieve and process check-in date
                            DateTime checkInDate = Convert.ToDateTime(reader["checkInDate"]).Date; // Use .Date to strip time
                            dtpCheckIn.Value = checkInDate; // Set check-in date

                            // Retrieve and process check-out date
                            DateTime checkOutDate = Convert.ToDateTime(reader["checkOutDate"]).Date; // Use .Date to strip time
                            dtpCheckOut.Value = checkOutDate; // Set check-out date

                            // Check if both check-in and check-out dates are in the past
                            if (checkInDate < DateTime.Today && checkOutDate < DateTime.Today)
                            {
                                // Disable cmbRooms and show message, but still allow users to edit dates
                                cmbRooms.Enabled = false;
                                MessageBox.Show("Passed Check-In and Check-Out date.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                // Disable the DateTimePickers for past dates
                                dtpCheckIn.Enabled = false;
                                dtpCheckOut.Enabled = false;
                            }
                            else if (checkOutDate < DateTime.Today) // If only check-out date is in the past
                            {
                                MessageBox.Show("The check-out date is in the past.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                // Disable check-out DateTimePicker if the date is in the past
                                dtpCheckOut.Enabled = false;
                            }
                            else
                            {
                                // Enable both DateTimePickers if dates are not in the past
                                dtpCheckIn.Enabled = true;
                                dtpCheckOut.Enabled = true;
                            }

                            // Handle the status and its effects on the form
                            cmbRooms.Text = reader["roomNum"].ToString();
                            PopulateRooms();
                            LoadRoomDetails();

                            // Set cmbStatus based on currentStatus value using a switch statement
                            switch (reader["currentStatus"].ToString())
                            {
                                case "Registered":
                                    cmbStatus.SelectedItem = "Registered";
                                    break;
                                case "Checked-In":
                                    cmbStatus.SelectedItem = "Checked-In";
                                    dtpCheckIn.Enabled = false; // Disable DateTimePicker if the registration is checked-in
                                    cmbStatus.Items.Remove("Registered"); // Remove "Registered" from ComboBox
                                    break;
                                case "Checked-Out":
                                    cmbStatus.SelectedItem = "Checked-Out";
                                    cmbStatus.Items.Remove("Registered"); // Remove "Registered" from ComboBox
                                    cmbStatus.Items.Remove("Checked-In"); // Remove "Checked-In" from ComboBox
                                    DisableAllFields();
                                    break;
                                default:
                                    cmbStatus.SelectedItem = null;  // Or any default value if none of the cases match
                                    break;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading registration details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }



        private void DisableAllFields()
        {
            // Disable all textboxes
            txtFirstName.Enabled = false;
            txtLastName.Enabled = false;
            txtAddress.Enabled = false;
            txtEmail.Enabled = false;
            txtPhoneNumber.Enabled = false;
            txtAddress.Enabled = false;
            cmbPayMethod.Enabled = false;

            // Disable all datepickers
            dtpCheckIn.Enabled = false;
            dtpCheckOut.Enabled = false;

            // Disable the combo box
            cmbRooms.Enabled = false;
            cmbStatus.Enabled = false;
        }




        private void dtpCheckIn_ValueChanged(object sender, EventArgs e)
        {
            PopulateRooms();
        }

        private void dtpCheckOut_ValueChanged(object sender, EventArgs e)
        {
            PopulateRooms();
        }

        private void PopulateRooms()
        {
            cmbRooms.Items.Clear();  // Clear any previous items
            availableRooms.Clear();  // Clear previous room information

            // Get the selected dates from the DateTimePickers
            DateTime checkInDate = dtpCheckIn.Value.Date;
            DateTime checkOutDate = dtpCheckOut.Value.Date;

            // Query to fetch available rooms
            string query = @"
SELECT ri.roomNum, ri.roomDesc, ri.roomType, ri.roomRate
FROM roominventory ri
WHERE ri.roomNum NOT IN (
    SELECT r.roomNum
    FROM registration r
    WHERE (
        (r.checkInDate BETWEEN @CheckInDate AND @CheckOutDate) 
        OR 
        (r.checkOutDate BETWEEN @CheckInDate AND @CheckOutDate)
        OR 
        (r.checkInDate <= @CheckInDate AND r.checkOutDate >= @CheckOutDate)
    )
);
";

            // Add the room of the current registration to the combo box
            int selectedRoomIndex = -1; // To store the index of the current registration room
            if (regId > 0)
            {
                // Query to fetch the room number and details for the current registration
                string regRoomQuery = @"
    SELECT r.roomNum, ri.roomDesc, ri.roomType, ri.roomRate
    FROM registration r
    INNER JOIN roominventory ri ON r.roomNum = ri.roomNum
    WHERE r.regId = @RegId
    ";

                // Create MySQL connection and command for regId
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    MySqlCommand regCmd = new MySqlCommand(regRoomQuery, conn);
                    regCmd.Parameters.AddWithValue("@RegId", regId);

                    try
                    {
                        conn.Open(); // Open the MySQL connection

                        // Execute the query to get the current registration room details
                        MySqlDataReader reader = regCmd.ExecuteReader();
                        if (reader.Read())
                        {
                            // Create a Room object for the current registration's room
                            Room currentRoom = new Room(
                                Convert.ToInt32(reader["roomNum"]),
                                reader["roomDesc"].ToString(),
                                reader["roomType"].ToString(),
                                Convert.ToDecimal(reader["roomRate"])
                            );

                            // Add the room number to the combo box
                            cmbRooms.Items.Add(currentRoom.RoomNum);

                            // Add the current room object to the availableRooms list
                            availableRooms.Add(currentRoom);

                            // Find the index of the current registration's room and store it
                            selectedRoomIndex = cmbRooms.Items.IndexOf(currentRoom.RoomNum);
                        }
                        reader.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error fetching current registration room: " + ex.Message);
                    }
                }
            }

            // Create MySQL connection and command to fetch available rooms
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@CheckInDate", checkInDate);
                cmd.Parameters.AddWithValue("@CheckOutDate", checkOutDate);

                try
                {
                    conn.Open(); // Open the MySQL connection

                    // Execute the query and populate the combo box
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        // Create a Room object with room details
                        Room room = new Room(
                            Convert.ToInt32(reader["roomNum"]),
                            reader["roomDesc"].ToString(),
                            reader["roomType"].ToString(),
                            Convert.ToDecimal(reader["roomRate"])
                        );

                        // Add the room number to the combo box
                        cmbRooms.Items.Add(room.RoomNum);

                        // Store the room information in the list
                        availableRooms.Add(room);
                    }

                    reader.Close(); // Close the reader

                    // After populating the combo box, set the index to the current registration room
                    if (selectedRoomIndex >= 0)
                    {
                        cmbRooms.SelectedIndex = selectedRoomIndex; // Set the combo box to the current registration room
                        LoadRoomDetails(); // Call the method to populate the room details
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }



        private void LoadRoomDetails()
{
    // Ensure that a selection is made
    if (cmbRooms.SelectedIndex >= 0)
    {
        // Get the selected room number from the combo box
        int selectedRoomNum = Convert.ToInt32(cmbRooms.SelectedItem);

        // Find the room object corresponding to the selected room number
        Room selectedRoom = availableRooms.FirstOrDefault(r => r.RoomNum == selectedRoomNum);

        if (selectedRoom != null)
        {
            // Set the text fields with the corresponding room details
            txtRoomType.Text = selectedRoom.RoomType;
            txtRoomRate.Text = selectedRoom.RoomRate.ToString("C"); // Format as currency

            // Calculate the number of days between check-in and check-out
            int daysOfStay = (dtpCheckOut.Value.Date - dtpCheckIn.Value.Date).Days;

            if (daysOfStay > 0)
            {
                // Calculate the total cost of stay and set it to txtCostOfStay
                decimal totalCostOfStay = selectedRoom.RoomRate * daysOfStay;
                txtCostOfStay.Text = totalCostOfStay.ToString("C"); // Format as currency
            }
            else if (daysOfStay == 0)
            {
                // Handle the case when the check-out date is the same as the check-in date
                txtCostOfStay.Text = "Stay must be at least 1 day.";
            }
            else
            {
                // If the check-out date is earlier than the check-in date (for past records)
                txtCostOfStay.Text = "Check-out date cannot be before check-in date.";
            }
        }
    }
}


        private void cmbRooms_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Call the method to load the room details when the selection changes
            LoadRoomDetails();
        }
       
       



        //Button Functions
        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "You will lose any unsaved changes.",
                "Cancel",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void txtPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private bool IsValidPhoneNumber(string phoneNumber)
        {
            return phoneNumber.Length == 10 && phoneNumber.All(char.IsDigit);
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void btnConfirmEdit_Click(object sender, EventArgs e)
        {
            // Check if the first name is empty
            if (string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                MessageBox.Show("First Name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check if the last name is empty
            if (string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                MessageBox.Show("Last Name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check if the address is empty
            if (string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                MessageBox.Show("Address is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check if the phone number is empty or invalid
            if (string.IsNullOrWhiteSpace(txtPhoneNumber.Text) || !IsValidPhoneNumber(txtPhoneNumber.Text))
            {
                MessageBox.Show("Please enter a valid Phone Number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check if the email is empty or invalid
            if (string.IsNullOrWhiteSpace(txtEmail.Text) || !IsValidEmail(txtEmail.Text))
            {
                MessageBox.Show("Please enter a valid Email address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Get selected room number
            string roomNumber = cmbRooms.Text;

            // Access the static variable from frmLogin
            int empId = frmLogin.CurrentEmpId;  // Accessing the static variable

            string roomRateText = txtRoomRate.Text;

            // Remove the dollar sign ('$') and any other non-numeric characters
            roomRateText = roomRateText.Replace("$", "").Trim();

            // Try to parse the remaining text as a double
            double rate;
            if (!double.TryParse(roomRateText, out rate))
            {
                MessageBox.Show("Please enter a valid room rate.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Get other form details
            string fName = txtFirstName.Text;
            string lName = txtLastName.Text;
            string address = txtAddress.Text;
            string paymentMethod = cmbPayMethod.Text;

            // Calculate the duration between check-in and check-out dates
            DateTime checkInDate = dtpCheckIn.Value;
            DateTime checkOutDate = dtpCheckOut.Value;
            int duration = (checkOutDate - checkInDate).Days;

            // If duration is less than or equal to 0, show an error message
            if (duration <= 0)
            {
                MessageBox.Show("Check-out date must be later than check-in date.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Calculate the cost of stay
            double costOfStay = rate * duration;

            // Get email and phone number
            string email = txtEmail.Text;
            string phoneNum = txtPhoneNumber.Text;
            phoneNum = phoneNum.Insert(3, "-").Insert(7, "-");  // Format phone number

            string currentStatus = cmbStatus.Text;

            // Create SQL query to update the record in the registration table
            string query = @"
    UPDATE registration 
    SET roomNum = @RoomNum,
        empId = @EmpId,
        roomRate = @RoomRate,
        lastName = @LastName,
        firstName = @FirstName,
        address = @Address,
        payMethod = @PayMethod,
        currentStatus = @CurrentStatus,
        checkInDate = @CheckInDate,
        checkOutDate = @CheckOutDate,
        stayDuration = @StayDuration,
        costOfStay = @CostOfStay,
        email = @Email,
        phoneNumber = @PhoneNumber
    WHERE regId = @RegId;
";

            // Create MySQL connection and command
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                MySqlCommand cmd = new MySqlCommand(query, conn);

                // Add parameters to the SQL command
                cmd.Parameters.AddWithValue("@RoomNum", roomNumber);
                cmd.Parameters.AddWithValue("@EmpId", empId);
                cmd.Parameters.AddWithValue("@RoomRate", rate);
                cmd.Parameters.AddWithValue("@LastName", lName);
                cmd.Parameters.AddWithValue("@FirstName", fName);
                cmd.Parameters.AddWithValue("@Address", address);
                cmd.Parameters.AddWithValue("@PayMethod", paymentMethod);
                cmd.Parameters.AddWithValue("@CurrentStatus", currentStatus);
                cmd.Parameters.AddWithValue("@CheckInDate", checkInDate);
                cmd.Parameters.AddWithValue("@CheckOutDate", checkOutDate);
                cmd.Parameters.AddWithValue("@StayDuration", duration);
                cmd.Parameters.AddWithValue("@CostOfStay", costOfStay);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@PhoneNumber", phoneNum);
                cmd.Parameters.AddWithValue("@RegId", regId); // Add the regId to the parameters

                try
                {
                    conn.Open(); // Open the MySQL connection
                    cmd.ExecuteNonQuery(); // Execute the update command
                    MessageBox.Show("Registration updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    frmMain mainForm = Application.OpenForms.OfType<frmMain>().FirstOrDefault();
                    if (mainForm != null)
                    {
                        mainForm.LoadRegistrationData();
                    }
                    _mainForm.RefreshData();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
            }
        }
    

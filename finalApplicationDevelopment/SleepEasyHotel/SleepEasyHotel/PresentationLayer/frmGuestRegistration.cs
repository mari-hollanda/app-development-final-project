using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SleepEasyHotel.PresentationLayer
{
    public partial class frmGuestRegistration : UserControl
    {
        string sConnection = "Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=SleepEasyHotelDatabase.accdb";
        OleDbConnection dbConn;

        public frmGuestRegistration()
        {
            InitializeComponent();
        }

        public void PopulateAvailableRoomCombo()
        {
            //clear the form everytime when this method is called then populate
            //ClearForm();

            try
            {
                dbConn = new OleDbConnection(sConnection);
                //open connection to database
                dbConn.Open();
                //create query to select all rows from Guest table
                string sql;
                sql = "SELECT RoomID,RoomType from Rooms WHERE RoomStatus='Empty';";
                OleDbCommand dbCmd = new OleDbCommand();
                //set command SQL string
                dbCmd.CommandText = sql;

                //set the command connection
                dbCmd.Connection = dbConn;
                //create OleDbDataReader dbReader
                OleDbDataReader dbReader;
                //Read data into dbReader
                dbReader = dbCmd.ExecuteReader();
                //Read first record
                while (dbReader.Read())
                {
                    //Create a Guest object populate the firstName LastName and GuestId attibutes
                    //Guest guest = new Guest(dbReader["FirstName"].ToString(), dbReader["LastName"].ToString(), (int)dbReader["GuestId"]);

                    //load the Guest object per into the combobox
                    //when displayed the combo box will call toString by default on the Guest object.
                    //the toString only displays the FirstName and LastName of the Guest.
                    cmbRoomAvailable.Items.Add(dbReader["RoomID"].ToString());
                }
                //close Reader
                dbReader.Close();
                //close database connection
                dbConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void frmGuestRegistration_Load(object sender, EventArgs e)
        {
            PopulateAvailableRoomCombo();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                try
                {
                    dbConn = new OleDbConnection(sConnection);
                    //open connection to database
                    dbConn.Open();
                    //create query to select all rows from Guest table
                    string sql;


                    sql = "UPDATE Rooms SET RoomStatus='Occupied',CheckIn='" + dtpCheckInDate.Text + "' WHERE RoomID='" + cmbRoomAvailable.Text + "';";
                    OleDbCommand dbCmd = new OleDbCommand();


                    //set command SQL string
                    dbCmd.CommandText = sql;

                    //set the command connection
                    dbCmd.Connection = dbConn;



                    //create OleDbDataReader dbReader
                    OleDbDataReader dbReader;

                    //Read data into dbReader
                    dbReader = dbCmd.ExecuteReader();

                    //close database connection
                    dbConn.Close();


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }


                try
                {
                    dbConn = new OleDbConnection(sConnection);
                    //open connection to database
                    dbConn.Open();
                    //create query to select all rows from Guest table
                    string sql;



                    sql = "Insert into Guest(LastName, FirstName, Street, City, State, Zip, Phone, Email, RoomID) Values (@FirstName, @LastName, @Street, @City, @State, @Zip, @Phone, @Email, @RoomID);";
                    //create database command
                    OleDbCommand dbCmd = new OleDbCommand();

                    //set command SQL string
                    dbCmd.CommandText = sql;
                    //set the command connection
                    dbCmd.Connection = dbConn;

                    //bind parameters
                    dbCmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text);
                    dbCmd.Parameters.AddWithValue("@LastName", txtLastName.Text);
                    dbCmd.Parameters.AddWithValue("@Street", txtStreet.Text);
                    dbCmd.Parameters.AddWithValue("@City", txtCity.Text);
                    dbCmd.Parameters.AddWithValue("@State", txtProvince.Text);
                    dbCmd.Parameters.AddWithValue("@Zip", txtZipCode.Text);
                    dbCmd.Parameters.AddWithValue("@Phone", txtPhone.Text);
                    dbCmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                    dbCmd.Parameters.AddWithValue("@RoomID", cmbRoomAvailable.Text);

                    //execute insert. Check to see how many rows were affected
                    int rowCount = dbCmd.ExecuteNonQuery();

                    //close database connection
                    dbConn.Close();
                    if (rowCount == 1)
                    {
                        MessageBox.Show("Record inserted successfully");
                        //Update the form
                        ClearForm();
                        cmbRoomAvailable.Items.Clear();

                        // cmbBookedRoom.Items.Clear();
                        PopulateAvailableRoomCombo();


                        // PopulateBookedRooms();

                    }
                    else
                    {
                        MessageBox.Show("Error inserting record. Please try again.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }

        }

        private void ClearForm()
        {
            txtEmail.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            txtPhone.Clear();
            txtCity.Clear();
            txtProvince.Clear();
            txtStreet.Clear();
            txtZipCode.Clear();
            cmbRoomAvailable.SelectedIndex = -1;
            dtpCheckInDate.ResetText();
        }

        private bool ValidateForm()
        {
            string errMsg = "";


            if (txtFirstName.Text == "")
            {
                errMsg = "Missing First Name. \n";
            }
            else if (txtLastName.Text == "")
            {
                errMsg = "Missing Last Name. \n";
            }
            else if (txtPhone.Text == "")
            {
                errMsg = "Missing Phone. \n";
            }
            else if (txtEmail.Text == "")
            {
                errMsg = "Missing Email. \n";
            }
            else if (txtZipCode.Text == "")
            {
                errMsg = "Missing Zip Code \n";
            }
            else if (txtStreet.Text == "")
            {
                errMsg = "Missing Street \n";
            }
            else if (txtCity.Text == "")
            {
                errMsg = "Missing City. \n";
            }
            else if (txtProvince.Text == "")
            {
                errMsg = "Missing Province \n";
            }
            else if (cmbRoomAvailable.Text == "")
            {
                errMsg = "Missing Room Number \n";
            }
            else if (dtpCheckInDate.Text == "")
            {
                errMsg = "Missing checkIn Date \n";
            }


            if (errMsg.Length > 0)
            {
                MessageBox.Show(errMsg);
                return false;
            }
            else
            {
                return true;
            }

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            cmbRoomAvailable.Items.Clear();
            PopulateAvailableRoomCombo();
        }
    }
}

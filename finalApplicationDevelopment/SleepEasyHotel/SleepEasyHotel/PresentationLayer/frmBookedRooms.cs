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
using SleepEasyHotel.BusinessObjects;

namespace SleepEasyHotel.PresentationLayer
{
    public partial class frmBookedRooms : UserControl
    {
        private double total;
        private string name;
        private string checkIn;
        private string email;
        private string phone;
        private double serviceTotal;
        double grandTotal;



        string sConnection = "Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=SleepEasyHotelDatabase.accdb";
        OleDbConnection dbConn;
        public frmBookedRooms()
        {
            
            InitializeComponent();
        }

        public void PopulateBookedRooms()
        {
            //clear the form everytime when this method is called then populate
          //  ClearForm();

            try
            {
                dbConn = new OleDbConnection(sConnection);
                //open connection to database
                dbConn.Open();
                //create query to select all rows from Guest table
                string sql;
                sql = "SELECT RoomID from Rooms WHERE RoomStatus='Occupied';";
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
                    cmbRoomNumber.Items.Add(dbReader["RoomID"].ToString());
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

        public void PopulateServices()
        {
            //clear the form everytime when this method is called then populate
            //  ClearForm();

            try
            {
                dbConn = new OleDbConnection(sConnection);
                //open connection to database
                dbConn.Open();
                //create query to select all rows from Guest table
                string sql;
                sql = "SELECT Description,Price from Services;";
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
                    cmbServices.Items.Add(dbReader["Description"].ToString());
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



        private void frmBookedRooms_Load(object sender, EventArgs e)
        {
            PopulateServices();
            PopulateBookedRooms();
        }

        private void cmbRoomNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dbConn = new OleDbConnection(sConnection);
                //open connection to database
                dbConn.Open();
                //create query to select all rows from Guest table
                string sql;

                sql = "SELECT  Guest.GuestID,Guest.FirstName,Guest.LastName,Guest.Phone,Guest.email,Rooms.CheckOut, Rooms.CheckIn FROM Guest INNER JOIN Rooms ON Guest.RoomID = Rooms.RoomID Where Guest.RoomID='" + cmbRoomNumber.Text + "';";
                OleDbCommand dbCmd = new OleDbCommand();
                //set command SQL string
                dbCmd.CommandText = sql;

                //set the command connection
                dbCmd.Connection = dbConn;
                //create OleDbDataReader dbReader
                OleDbDataReader dbReader;
                ////////Read data into dbReader
                dbReader = dbCmd.ExecuteReader();
                //Read first record
                while (dbReader.Read())
                {
                    //Create a Guest object populate the firstName LastName and GuestId attibutes
                    //Guest guest = new Guest(dbReader["FirstName"].ToString(), dbReader["LastName"].ToString(), (int)dbReader["GuestId"]);

                    //load the Guest object per into the combobox
                    //when displayed the combo box will call toString by default on the Guest object.
                    //the toString only displays the FirstName and LastName of the Guest.
                    lblGuestID.Text= dbReader["GuestID"].ToString();
                    txtFirstName.Text = dbReader["FirstName"].ToString();
                    txtLastName.Text= dbReader["LastName"].ToString();
                    name = txtFirstName.Text+" "+ lblLastName.Text;
                    txtCheckInDate.Text = dbReader["CheckIn"].ToString();
                    checkIn = txtCheckInDate.Text;
                    txtEmail.Text = dbReader["email"].ToString();
                    email = txtEmail.Text;
                    txtPhone.Text = dbReader["Phone"].ToString();
                    phone = txtPhone.Text;
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


        private void ClearForm()
        {
            txtEmail.Clear();
            txtCheckInDate.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            txtPhone.Clear();
            cmbServices.SelectedIndex = -1;  
            cmbRoomNumber.SelectedIndex= -1;
            dtpCheckOutDate.ResetText() ;
            
        }

       

        private bool ValidateForm()
        {
            string errMsg = "";


            if (txtFirstName.Text == "")
            {
                errMsg = "Missing First Name. \n";
            }
            if (txtLastName.Text == "")
            {
                errMsg = "Missing Last Name. \n";
            }
            else if (txtCheckInDate.Text == "")
            {
                errMsg = "Missing CheckIn date. \n";
            }
            else if (txtEmail.Text == "")
            {
                errMsg = "Missing Email. \n";
            }
            else if (txtPhone.Text == "")
            {
                errMsg = "Missing Phone. \n";
            }
            else if (dtpCheckOutDate.Text == "")
            {
                errMsg = "Missing CheckOut Date. \n";
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

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                try
                {
                    dbConn = new OleDbConnection(sConnection);
                    //open connection to database
                    dbConn.Open();
                    //create query to update selected Guest record
                    string sql;
                    sql = "UPDATE Rooms SET RoomStatus='Empty',CheckOut='" + dtpCheckOutDate.Text + "' WHERE RoomID='" + cmbRoomNumber.Text + "';";
                    MessageBox.Show(dtpCheckOutDate.Text);
                    //create database command
                    OleDbCommand dbCmd = new OleDbCommand();

                    //set command SQL string
                    dbCmd.CommandText = sql;
                    //set the command connection
                    dbCmd.Connection = dbConn;

                    //bind parameters




                    //execute update. Check to see how many rows were affected
                    int rowCount = dbCmd.ExecuteNonQuery();

                    //close database connection
                    dbConn.Close();

                    if (rowCount == 1)
                    {
                         grandTotal = serviceTotal + total;
                        MessageBox.Show("Record updated successfully");
                        rtbTotal.Text ="Name: "+ name + "\nEmail: "+email+"\nPhone: "+phone + "\nSub Total: " + total+"\n Service Total: "+serviceTotal+"\nGrand Total: "+ grandTotal;



                        ClearForm();
                        cmbRoomNumber.Items.Clear();

                        PopulateBookedRooms();
                    }
                    else
                    {
                        MessageBox.Show("Error updating record. Please try again.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            rtbTotal.Clear();
            total = 0;
            serviceTotal = 0;
            grandTotal = 0;
            name = "";
            phone = "";
            email = "";
            checkIn = "";
        }

        private void dtpCheckOutDate_ValueChanged(object sender, EventArgs e)
        {
            BookedServicesAddition newService = new BookedServicesAddition();
            total = newService.CalculateTotal(checkIn, dtpCheckOutDate.Text);

        }

        private void btnService_Click(object sender, EventArgs e)
        {
            try
            {
                dbConn = new OleDbConnection(sConnection);
                //open connection to database
                dbConn.Open();
                //create query to select all rows from Guest table
                string sql;
                sql = "SELECT Price from Services WHERE Description='"+cmbServices.Text+"';";
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
                    serviceTotal = serviceTotal + int.Parse(dbReader["Price"].ToString());
                }
                //close Reader
                dbReader.Close();
                //close database connection
                dbConn.Close();
                MessageBox.Show("Service Added");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {


                try
                {
                    dbConn = new OleDbConnection(sConnection);
                    //open connection to database
                    dbConn.Open();
                    //create query to Update Staff table
                    string sql;


                    sql = "UPDATE Guest SET FirstName='" + txtFirstName.Text +
                     "',LastName='" + txtLastName.Text +
                      "',Phone=" + txtPhone.Text +
                      ",email='" + txtEmail.Text +
                        "'WHERE GuestID =" + lblGuestID.Text + ";";


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

                    ClearForm();
                    cmbRoomNumber.Items.Clear();
                    PopulateBookedRooms();
                    MessageBox.Show("Record Updated");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            cmbRoomNumber.Items.Clear();
            PopulateBookedRooms();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;
using SleepEasyHotel.PresentationLayer;
using SleepEasyHotel.BusinessObjects;

namespace SleepEasyHotel.PresentationLayer
{
    public partial class RegistrationServices : Form
    {
        public RegistrationServices()
        {
            InitializeComponent();
        }
        string sConnection = "Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=SleepEasyHotelDatabase.accdb";
        OleDbConnection dbConn;

       


        public void PopulateAvailableRoomCombo()
        {
            //clear the form everytime when this method is called then populate
            ClearForm();

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
        private void ClearForm()
        {
          //  cmbRoomAvailable.Items.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            txtCity.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
            txtState.Clear();
            txtStreet.Clear();
            txtZip.Clear();
            
        }


        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                dbConn = new OleDbConnection(sConnection);
                //open connection to database
                dbConn.Open();
                //create query to select all rows from Guest table
                string sql;


                sql = "UPDATE Rooms SET RoomStatus='Occupied',CheckIn='"+dtpCheckInDate.Text+"' WHERE RoomID='" + cmbRoomAvailable.Text + "';";
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
                dbCmd.Parameters.AddWithValue("@State", txtState.Text);
                dbCmd.Parameters.AddWithValue("@Zip", txtZip.Text);
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
                    cmbRoomAvailable.Items.Clear();
                   
                    cmbBookedRoom.Items.Clear();
                    PopulateAvailableRoomCombo();
                  
                    PopulateBookedRooms();

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

        private void RegistrationServices_Load(object sender, EventArgs e)
        {
            PopulateAvailableRoomCombo();
           
            PopulateBookedRooms();
        }


        public void PopulateBookedRooms()
        {
            //clear the form everytime when this method is called then populate
            ClearForm();

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
                    cmbBookedRoom.Items.Add(dbReader["RoomID"].ToString());
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


       

        private void cmbBookedRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dbConn = new OleDbConnection(sConnection);
                //open connection to database
                dbConn.Open();
                //create query to select all rows from Guest table
                string sql;
                
                sql = "SELECT Guest.FirstName,Guest.LastName,Guest.Phone,Guest.email,Rooms.CheckOut, Rooms.CheckIn FROM Guest INNER JOIN Rooms ON Guest.RoomID = Rooms.RoomID Where Guest.RoomID='"+cmbBookedRoom.Text+"';";
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
                   txtBookedName.Text= dbReader["FirstName"].ToString()+" "+ dbReader["LastName"].ToString();
                    txtBookedCheckInDate.Text = dbReader["CheckIn"].ToString();
                    txtBookedEmail.Text = dbReader["email"].ToString();
                    txtBookedPhone.Text = dbReader["Phone"].ToString();
                    txtTestCheckOut.Text = dbReader["CheckOut"].ToString();

                    BookedServicesAddition newService = new BookedServicesAddition(dbReader["CheckIn"].ToString(), dtpBookedCheckOutDate.Text);
                  

                    rtbBookedTotal.Text = newService.ToString();
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

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
           

            try
            {
                dbConn = new OleDbConnection(sConnection);
                //open connection to database
                dbConn.Open();
                //create query to update selected Guest record
                string sql;
                sql = "UPDATE Rooms SET RoomStatus='Empty',CheckOut='" + dtpBookedCheckOutDate.Text + "' WHERE RoomID='" + cmbBookedRoom.Text + "';";
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
                    MessageBox.Show("Record updated successfully");
                    cmbRoomAvailable.Items.Clear();
                    txtBookedPhone.Clear();
                    txtBookedEmail.Clear();
                    txtBookedName.Clear();
                    txtBookedCheckInDate.Clear();
                    PopulateAvailableRoomCombo();
                    cmbBookedRoom.Items.Clear();
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
}

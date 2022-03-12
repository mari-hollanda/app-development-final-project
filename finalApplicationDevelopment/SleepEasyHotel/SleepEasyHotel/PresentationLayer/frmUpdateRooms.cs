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
    public partial class frmUpdateRooms : UserControl
    {
        public frmUpdateRooms()
        {
            InitializeComponent();
        }
        string sConnection = "Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=SleepEasyHotelDatabase.accdb";
        OleDbConnection dbConn;
        private void frmUpdateRooms_Load(object sender, EventArgs e)
        {
            PopulatedRooms();
        }

        public void PopulatedRooms()
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
                sql = "SELECT RoomID from Rooms ;";
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
                    cmbRoomID.Items.Add(dbReader["RoomID"].ToString());
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

        private void cmbRoomID_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dbConn = new OleDbConnection(sConnection);
                //open connection to database
                dbConn.Open();
                //create query to select all rows from Guest table
                string sql;

                sql = "SELECT RoomID,RoomType,RoomStatus,CheckIn,CheckOut,StaffID FROM Rooms Where RoomID='" + cmbRoomID.Text + "';";
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
                    lblRoom.Text = dbReader["RoomID"].ToString();
                    if (dbReader["RoomType"].ToString() == "K")
                    {
                        cmbRoomType.SelectedIndex = 0;
                    }
                    else if (dbReader["RoomType"].ToString() == "Q")
                    {
                        cmbRoomType.SelectedIndex = 1;
                    }
                    else if (dbReader["RoomType"].ToString() == "D")
                    {
                        cmbRoomType.SelectedIndex = 2;
                    }

                    if (dbReader["RoomStatus"].ToString() == "Empty")
                    {
                        cmbRoomStatus.SelectedIndex = 0;
                    }
                    else if (dbReader["RoomStatus"].ToString() == "Occupied")
                    {
                        cmbRoomStatus.SelectedIndex = 1;
                    }
                    
                    txtStaff.Text = dbReader["StaffID"].ToString();
                   
                    if (dbReader["CheckIn"].ToString() == "")
                    {
                        dtpCheckInDate.CustomFormat="";
                    }
                    else 
                    { 
                        dtpCheckInDate.Value = DateTime.Parse(dbReader["CheckIn"].ToString());
                    }
                    if (dbReader["CheckOut"].ToString() == "")
                    {
                        dtpCheckOutDate.CustomFormat = "";

                    }
                    else
                    {
                        dtpCheckOutDate.Value = DateTime.Parse(dbReader["CheckOut"].ToString());
                    }
                    
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

                    if (txtStaff.Text == "")
                    {
                        sql = "UPDATE Rooms SET RoomStatus='" + cmbRoomStatus.Text + "',RoomType='" + cmbRoomType.Text + "',CheckIn='" + dtpCheckInDate.Text + "',CheckOut='" + dtpCheckOutDate.Text + "' WHERE RoomID='" + lblRoom.Text + "';";

                    }
                    else
                    {
                        sql = "UPDATE Rooms SET RoomStatus='" + cmbRoomStatus.Text + "',StaffID=" + txtStaff.Text + ",RoomType='" + cmbRoomType.Text + "',CheckIn='" + dtpCheckInDate.Text + "',CheckOut='" + dtpCheckOutDate.Text + "' WHERE RoomID='" + lblRoom.Text + "';";
                    }
                   
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
                    cmbRoomID.Items.Clear();
                    PopulatedRooms();
                    MessageBox.Show("Record Updated");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }


        private void ClearForm()
        {

            txtStaff.Clear();
            cmbRoomStatus.SelectedIndex = -1;
            cmbRoomType.SelectedIndex = -1;
            dtpCheckOutDate.ResetText();
            dtpCheckInDate.ResetText();

        }



        private bool ValidateForm()
        {
            string errMsg = "";


            
            if (cmbRoomType.Text == "")
            {
                errMsg = "Missing Room Type. \n";
            }
            else if (cmbRoomStatus.Text == "")
            {
                errMsg = "Missing Room Status \n";
            }
            else if (dtpCheckInDate.Text == "")
            {
                errMsg = "Missing CheckIn Date. \n";
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

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (lblRoom.Text == "")
            {
                MessageBox.Show("Please Select Room to Delete");
            }
            else
            {
                try
                {
                    dbConn = new OleDbConnection(sConnection);
                    //open connection to database
                    dbConn.Open();
                    //create query to Update Staff table
                    string sql;


                    sql = "DELETE FROM Rooms WHERE RoomID='" + lblRoom.Text + "';";

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

                    cmbRoomID.Items.Clear();
                    PopulatedRooms();
                    MessageBox.Show("Record Deleted");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

            }

        }
    }
}

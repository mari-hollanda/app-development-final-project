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
    public partial class frmStaffUpdate : UserControl
    {
        public frmStaffUpdate()
        {
            InitializeComponent();
            PopulateStaffCombo();
        }
      

        string sConnection = "Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=SleepEasyHotelDatabase.accdb";
        OleDbConnection dbConn;

        public void PopulateStaffCombo()
        {
            //clear the form everytime when this method is called then populate
           ClearForm();

            try
            {
                dbConn = new OleDbConnection(sConnection);
                //open connection to database
                dbConn.Open();
                //create query to select all rows from Staff table
                string sql;
                sql = "SELECT StaffID,FirstName,LastName,PositionID,PhoneNumber,Email,Title from Staff";
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


                    cmbUpdateFname.Items.Add(dbReader["FirstName"].ToString());


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

            cmbUpdateFname.Items.Clear();

            txtFirstName.Clear();
            txtLastName.Clear();

            cmbPID.SelectedIndex = -1;
            txtPhone.Clear();
            txtEmail.Clear();
            txtTitle.Clear();
            

        }
       
        private void cmbUpdateFname_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            try
            {
                dbConn = new OleDbConnection(sConnection);
                //open connection to database
                dbConn.Open();
                //create query to select all rows from Staff table
                string sql;

                sql = "SELECT StaffID,FirstName,LastName,PositionID,PhoneNumber,Email,Title FROM Staff Where FirstName='" + cmbUpdateFname.Text + "';";
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

                    txtFirstName.Text = dbReader["FirstName"].ToString();
                    txtLastName.Text = dbReader["LastName"].ToString();
                    if (dbReader["PositionId"].ToString() == "1")
                    {
                        cmbPID.SelectedIndex = 0;
                    }
                    else {
                        cmbPID.SelectedIndex = 1;
                    }
                    //cmbPID.Text = dbReader["PositionId"].ToString();
                    txtPhone.Text = dbReader["PhoneNumber"].ToString();
                    txtEmail.Text = dbReader["Email"].ToString();
                    txtTitle.Text = dbReader["Title"].ToString();
                    lblStaffIDtoUpdate.Text = dbReader["StaffID"].ToString();

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

        private void btnUpdateStaff_Click(object sender, EventArgs e)
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


                    sql = "UPDATE Staff SET FirstName='" + txtFirstName.Text +
                     "',LastName='" + txtLastName.Text +
                      "',PositionID=" + cmbPID.Text +
                      ",PhoneNumber=" + txtPhone.Text +
                      ",Email='" + txtEmail.Text +
                        "',Title='" + txtTitle.Text +
                        "'WHERE StaffID =" + lblStaffIDtoUpdate.Text + ";";


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

                    // ClearForm();
                    cmbUpdateFname.Items.Clear();
                    PopulateStaffCombo();
                    MessageBox.Show("Record Updated");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void btnDeleteStaff_Click(object sender, EventArgs e)
        {
            if (lblStaffIDtoUpdate.Text == "")
            {
                MessageBox.Show("Please Select Staff to Delete");
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


                    sql = "DELETE FROM Staff WHERE StaffID=" + lblStaffIDtoUpdate.Text + ";";

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

                    //ClearForm();
                   
                    cmbUpdateFname.Items.Clear();
                    PopulateStaffCombo();
                    MessageBox.Show("Record Deleted");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

            }
        }


       
            private bool ValidateForm()
            {
                string errMsg = "";

            if (cmbUpdateFname.Text == "")
            {
                errMsg = "Please select a staff. \n";
            }
            else if (txtLastName.Text == "")
                {
                    errMsg = "Missing Last name. \n";
                }
                else if (txtFirstName.Text == "")
                {
                    errMsg = "Missing first name. \n";
                }
                else if (txtEmail.Text == "")
                {
                    errMsg = "Missing Email. \n";
                }
                else if (txtPhone.Text == "")
                {
                    errMsg = "Missing Phone. \n";
                }
                else if (txtTitle.Text == "")
                {
                    errMsg = "Missing Title. \n";
                }
                 else if (cmbPID.Text == "")
                 {
                errMsg = "Please select a position Id. \n";
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
            cmbUpdateFname.Items.Clear();
            PopulateStaffCombo();
        }
    }
}

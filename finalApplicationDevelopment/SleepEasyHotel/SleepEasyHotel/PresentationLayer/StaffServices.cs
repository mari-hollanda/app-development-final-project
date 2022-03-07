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
    public partial class staffServices : Form
    {
        public staffServices()
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
           
            txtUpdateFirstName.Clear();
            cmbUpdatePID.Items.Clear();
            txtUpdateLname.Clear();
            cmbUpdatePID.Items.Clear();
           
            txtUpdatePhoneNumber.Clear();
            txtUpdateEmail.Clear();
            txtUpdateTitle.Clear();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cmbUpdateFname_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbUpdatePID.Items.Add("1");
            cmbUpdatePID.Items.Add("2");
            try
            {
                dbConn = new OleDbConnection(sConnection);
                //open connection to database
                dbConn.Open();
                //create query to select all rows from Guest table
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
                    
                    txtUpdateFirstName.Text = dbReader["FirstName"].ToString();
                    txtUpdateLname.Text = dbReader["LastName"].ToString();
                    cmbUpdatePID.Text = dbReader["PositionId"].ToString();
                    txtUpdatePhoneNumber.Text = dbReader["PhoneNumber"].ToString();
                    txtUpdateEmail.Text = dbReader["Email"].ToString();
                    txtUpdateTitle.Text = dbReader["Title"].ToString();
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
            try
            {
                dbConn = new OleDbConnection(sConnection);
                //open connection to database
                dbConn.Open();
                //create query to select all rows from Guest table
                string sql;


                sql = "UPDATE Staff SET FirstName='" + txtUpdateFirstName.Text +
                 "',LastName='" + txtUpdateLname.Text +
                  "',PositionID=" + cmbUpdatePID.Text +
                  ",PhoneNumber=" + txtUpdatePhoneNumber.Text +
                  ",Email='" + txtUpdateEmail.Text +
                    "',Title='" + txtUpdateTitle.Text + 
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


                PopulateStaffCombo();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}

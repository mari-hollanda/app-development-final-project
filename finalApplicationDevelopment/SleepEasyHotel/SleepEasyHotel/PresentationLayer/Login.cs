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


/*
 * Name: BadalKumar Patel
 * Course: CIS 2225 Windows Programming
 * Date: 25th November 2021
 * Subject: Assignment 6
 */

namespace SleepEasyHotel
{
    public partial class Login : Form
    {


        public Login()
        {
            InitializeComponent();
        }

        //build connection to Cottages
        //create connection string for Cottages database
        string sConnection = "Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=SleepEasyHotelDatabase.accdb";
        //Create OldDbConnection
        OleDbConnection dbConn;


        //When the form loads the guest combo box is populated 
        private void frmMain_Load(object sender, EventArgs e)
        {
          

           
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {


           
          
            try
            {
                dbConn = new OleDbConnection(sConnection);
                //open connection to database
                dbConn.Open();
                //create query to select all rows from Guest table
                string sql;

                 sql = "SELECT * from Login where Password Like '" + txtPassword.Text + "' AND Username Like '"+txtUsername.Text+"';";
             //   sql = "SELECT(Select count(GuestId) from Guests where GuestId = " + 5 + ") " +
               //         "as rowCount, * from Guests where GuestId = " + 5 + ";";
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
                dbReader.Read();
                if (dbReader.HasRows)
                {    mainFrm frm = new mainFrm();
                        frm.setInfo(dbReader["UserName"].ToString(), dbReader["PositionID"].ToString());
                       this.Hide();
                        frm.Show();
                        

                }
                else {
                    MessageBox.Show("Invalid Credentials");
                }
                //Close open connections
                dbReader.Close();
                dbConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}

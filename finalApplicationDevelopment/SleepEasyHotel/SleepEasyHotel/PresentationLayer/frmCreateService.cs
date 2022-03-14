using System;
using System.Data.OleDb;
using System.Windows.Forms;

/*
 * Create Service Form
 * @since 20220220
 * Form to create a service
 */
namespace SleepEasyHotel.PresentationLayer
{
    public partial class frmCreateService : UserControl
    {
        public frmCreateService()
        {
            InitializeComponent();
        }

        //Connect to database
        string sConnection = "Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=SleepEasyHotelDatabase.accdb";
        OleDbConnection dbConn;

        //Validate Form Method
        private bool ValidateForm()
        {
            string errMsg = "";

            if (txtDescription.Text == "")
            {
                errMsg = "Please enter Description. \n";
            }
            else if (txtPrice.Text == "")
            {
                errMsg = "Please enter Price. \n";
            }
            else if (txtType.Text == "")
            {
                errMsg = "Please enter Type. \n";
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

        //Create Button
        private void btnCreate_Click(object sender, EventArgs e)
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
                    sql = "Insert into Services(Description,Price,Type) Values('" + txtDescription.Text + "','" + txtPrice.Text + "','" + txtType.Text + "');";
                    //create database command
                    OleDbCommand dbCmd = new OleDbCommand();
                    //set command SQL string
                    dbCmd.CommandText = sql;
                    //set the command connection
                    dbCmd.Connection = dbConn;
                    //bind parameters
                    //execute insert. Check to see how many rows were affected
                    int rowCount = dbCmd.ExecuteNonQuery();
                    //close database connection
                    dbConn.Close();
                    if (rowCount == 1)
                    {
                        MessageBox.Show("Record inserted successfully");
                        //Update the form
                        txtDescription.Clear();
                        txtPrice.Clear();
                        txtType.Clear();
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
    }
}

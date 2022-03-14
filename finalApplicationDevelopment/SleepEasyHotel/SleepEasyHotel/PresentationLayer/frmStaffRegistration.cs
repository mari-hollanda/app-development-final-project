using System;
using System.Data.OleDb;
using System.Windows.Forms;

/*
 * Guest Registration Form
 * @since 20220220
 * Form to create a staff
 */
namespace SleepEasyHotel.PresentationLayer
{
    public partial class frmStaffRegistration : UserControl
    {
        public frmStaffRegistration()
        {
            InitializeComponent();
        }

        //Connect to database
        string sConnection = "Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=SleepEasyHotelDatabase.accdb";
        OleDbConnection dbConn;

        //Button to register the new staff
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
                    sql = "Insert into Staff(FirstName, LastName,PositionId, PhoneNumber, Email, Title) Values (@FirstName, @LastName, @PositionId, @PhoneNumber, @Email, @Title);";
                    //create database command
                    OleDbCommand dbCmd = new OleDbCommand();
                    //set command SQL string
                    dbCmd.CommandText = sql;
                    //set the command connection
                    dbCmd.Connection = dbConn;

                    //bind parameters
                    dbCmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text);
                    dbCmd.Parameters.AddWithValue("@LastName", txtLastName.Text);
                    dbCmd.Parameters.AddWithValue("@PositionId", cmbPID.Text);
                    dbCmd.Parameters.AddWithValue("@PhoneNumber", txtPhone.Text);
                    dbCmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                    dbCmd.Parameters.AddWithValue("@Title", txtTitle.Text);

                    //execute insert. Check to see how many rows were affected
                    int rowCount = dbCmd.ExecuteNonQuery();
                    //close database connection
                    dbConn.Close();
                    if (rowCount == 1)
                    {
                        MessageBox.Show("Record inserted successfully");
                        ClearForm();
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

        //Clear Form Method
        private void ClearForm()
        {
            txtEmail.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            txtPhone.Clear();
            txtTitle.Clear();
            cmbPID.SelectedIndex = -1;
        }

        //Validate Form Method
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
            else if (cmbPID.Text == "")
            {
                errMsg = "Please select a position Id. \n";
            }
            else if (txtTitle.Text == "")
            {
                errMsg = "Missing Title. \n";
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
    }
}

using System;
using System.Data.OleDb;
using System.Windows.Forms;

/*
 * Service Update Form
 * @since 20220220
 * Form to update, read and delete a room
 */
namespace SleepEasyHotel.PresentationLayer
{
    public partial class frmUpdateService : UserControl
    {
        public frmUpdateService()
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

            if (cmbDescription.Text == "")
            {
                errMsg = "Please select Description. \n";
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

        //Populate Services
        public void PopulateServices()
        {
            try
            {
                dbConn = new OleDbConnection(sConnection);
                //open connection to database
                dbConn.Open();
                //create query to select all rows from Guest table
                string sql;
                sql = "SELECT Description FROM Services;";
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
                    //load the Guest object per into the combobox
                    //when displayed the combo box will call toString by default on the Guest object.
                    //the toString only displays the FirstName and LastName of the Guest.
                    cmbDescription.Items.Add(dbReader["Description"].ToString());
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

        //Update Button
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
                    sql = "UPDATE Services SET Description='" + txtDescription.Text +
                          "',Price='" + txtPrice.Text +
                          "',Type='" + txtType.Text + "'WHERE Description = '" + cmbDescription.Text + "'; ";
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
                    lblServiceID.Text = "Service ID";
                    txtDescription.Clear();
                    txtPrice.Clear();
                    txtType.Clear();
                    cmbDescription.Items.Clear();
                    PopulateServices();
                    MessageBox.Show("Record Updated");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        //Method to insert data on fields when a service description is chosen on combobox
        private void cmbDescription_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dbConn = new OleDbConnection(sConnection);
                //open connection to database
                dbConn.Open();
                //create query to select all rows from Staff table
                string sql;
                sql = "SELECT RoomServiceID,Description,Price,Type FROM Services Where Description='" + cmbDescription.Text + "';";
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
                    txtDescription.Text = dbReader["Description"].ToString();
                    txtPrice.Text = dbReader["Price"].ToString();
                    txtType.Text = dbReader["Type"].ToString();
                    lblServiceID.Text = dbReader["RoomServiceID"].ToString();

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

        //Load Form
        private void frmUpdateService_Load(object sender, EventArgs e)
        {
            PopulateServices();
        }

        //Delete Button
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lblServiceID.Text == "")
            {
                MessageBox.Show("Please Select Service to Delete");
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
                    sql = "DELETE FROM Services WHERE RoomServiceID=" + lblServiceID.Text + ";";
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
                    lblServiceID.Text = "Service ID";
                    txtDescription.Clear();
                    txtPrice.Clear();
                    txtType.Clear();
                    cmbDescription.Items.Clear();
                    PopulateServices();
                    MessageBox.Show("Record Deleted");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

            }
        }

        //Refresh Button
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            lblServiceID.Text = "Service ID";
            txtDescription.Clear();
            txtPrice.Clear();
            txtType.Clear();
            cmbDescription.Items.Clear();
            PopulateServices();
            cmbDescription.Items.Clear();
            PopulateServices();
        }
    }
}

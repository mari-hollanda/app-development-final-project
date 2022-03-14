using System;
using System.Data.OleDb;
using System.Windows.Forms;
using SleepEasyHotel.PresentationLayer;

/*
 * Login Form
 * @since 20220220
 * Form to login users
 */
namespace SleepEasyHotel
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        //Connect to database
        string sConnection = "Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=SleepEasyHotelDatabase.accdb";
        OleDbConnection dbConn;

        //Login Button
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
                {
                    mainFrm frm = new mainFrm();
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

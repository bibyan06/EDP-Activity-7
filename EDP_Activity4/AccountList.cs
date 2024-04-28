using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EDP_Activity4
{
    public partial class AccountList : Form
    {
        public Connection myConnection;
        public AccountList()
        {
            InitializeComponent();
            myConnection = new Connection();
            accountlistdata.CellContentClick += accountlistdata_CellContentClick;
            this.Load += AccountList_Load;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard frm = new Dashboard();
            frm.ShowDialog();
            this.Close();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            About aboutForm = new About();
            aboutForm.Show();
        }
        private void AccountList_Load(object sender, EventArgs e)
        {
            loadData();
        }
        public void loadData()
        {
            try
            {
                // Ensure the connection is open before executing the query
                if (myConnection.Conn.State == ConnectionState.Closed)
                    myConnection.Conn.Open();

                string query = "SELECT username, name, email, phonenumber,position,status FROM admins";

                // Use the public MySqlConnection from Connection class
                using (MySqlCommand cmd = new MySqlCommand(query, myConnection.Conn))
                {
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable db = new DataTable();
                    adapter.Fill(db);
                    BindingSource bindingSource = new BindingSource();
                    bindingSource.DataSource = db;

                    accountlistdata.DataSource = bindingSource;
                }
            }
            catch (MySqlException ex) // Handle MySQL exceptions
            {
                Console.WriteLine("MySQL Error: " + ex.Message);
            }
            finally
            {
                // Always ensure to close the connection after use
                if (myConnection.Conn.State == ConnectionState.Open)
                    myConnection.CloseConnection();
            }
        }

        private void accountlistdata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && accountlistdata.Columns[e.ColumnIndex].Name == "UpdateUser")
            {
                string id = accountlistdata.Rows[e.RowIndex].Cells["id"].Value.ToString();
                string username = accountlistdata.Rows[e.RowIndex].Cells["username"].Value.ToString();
                string name = accountlistdata.Rows[e.RowIndex].Cells["name"].Value.ToString();
                string password = accountlistdata.Rows[e.RowIndex].Cells["password"].Value.ToString();
                string email = accountlistdata.Rows[e.RowIndex].Cells["email"].Value.ToString();
                string phonenumber = accountlistdata.Rows[e.RowIndex].Cells["phonenumber"].Value.ToString();
                string position = accountlistdata.Rows[e.RowIndex].Cells["position"].Value.ToString();
                string status = accountlistdata.Rows[e.RowIndex].Cells["status"].Value.ToString();

                //UserProfile userForm = new UserProfile();
                //userForm.SetUserValues(userID, email, password, username, first_name, surname, phone_num, acc_status);
                //userForm.ShowDialog();
            }
        }
        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addaccountButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddAccount frm = new AddAccount();
            frm.ShowDialog();
            this.Close();
        }

        private void updateaccountButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            UpdateAccount frm = new UpdateAccount();
            frm.ShowDialog();
            this.Close();
        }

        private void searchaccountTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void searchicon_Click(object sender, EventArgs e)
        {
            try
            {
                // Ensure the connection is open before executing the query
                if (myConnection.Conn.State == ConnectionState.Closed)
                    myConnection.Conn.Open();

                // Retrieve the emp_id entered by the user
                string username = searchaccountTxt.Text.Trim();

                // Execute the SQL query to search for the record with the specified emp_id
                string query = "SELECT * FROM admins WHERE username = @Username";
                using (MySqlCommand cmd = new MySqlCommand(query, myConnection.Conn))
                {
                    cmd.Parameters.AddWithValue("@Username", username);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable db = new DataTable();
                    adapter.Fill(db);

                    // Check if any record is found
                    if (db.Rows.Count > 0)
                    {
                        BindingSource bindingSource = new BindingSource();
                        bindingSource.DataSource = db;

                        accountlistdata.DataSource = bindingSource;

                        clearTextbox();
                    }
                    else
                    {
                        MessageBox.Show("Admin not found! Not existing admin.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Always ensure to close the connection after use
                if (myConnection.Conn.State == ConnectionState.Open)
                    myConnection.CloseConnection();
            }
        }
        private void clearTextbox()
        {
            searchaccountTxt.Text = "";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AccountLisy_Click(object sender, EventArgs e)
        {
            this.Hide();
            AccountList frm = new AccountList();
            frm.ShowDialog();
            this.Close();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            UpdateStatusToInactive();
            this.Hide();
            Form1 frm = new Form1();
            frm.ShowDialog();
            this.Close();

        }

        private void UpdateStatusToInactive()
        {
            string stm = "UPDATE admins SET status = 'Inactive'";

            try
            {
                // Open the connection if it's closed
                if (myConnection.Conn.State == ConnectionState.Closed)
                    myConnection.Conn.Open();

                using (MySqlCommand cmd = new MySqlCommand(stm, myConnection.Conn))
                {
                    cmd.ExecuteNonQuery();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                // Always ensure to close the connection after use
                if (myConnection.Conn.State == ConnectionState.Open)
                    myConnection.CloseConnection();
            }
        }

        private void close_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void transactionsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Transaction frm = new Transaction();
            frm.ShowDialog();
            this.Close();
        }
    }
}
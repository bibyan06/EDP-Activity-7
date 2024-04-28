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
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace EDP_Activity4
{
    public partial class AddAccount : Form
    {
        public Connection myConnection;

        public AddAccount()
        {
            InitializeComponent();
            myConnection = new Connection();
        }
        private bool allFilled()
        {
            // Check if all required fields are filled
            return !string.IsNullOrWhiteSpace(usernametxt.Text) &&
                   !string.IsNullOrWhiteSpace(nametxt.Text) &&
                   !string.IsNullOrWhiteSpace(passwordtxt.Text) &&
                   !string.IsNullOrWhiteSpace(emailtxt.Text) &&
                   !string.IsNullOrWhiteSpace(phonenumbertxt.Text) &&
                   !string.IsNullOrWhiteSpace(positiontxt.Text);
        }

        private void clearTextbox()
        {
            usernametxt.Text = "";
            nametxt.Text = "";
            passwordtxt.Text = "";
            emailtxt.Text = "";
            phonenumbertxt.Text = "";
            positiontxt.Text = "";
        }
        private void addaccountButton_Click(object sender, EventArgs e)
        {
            if (allFilled())
            {
                try
                {
                    // Create an instance of the Connection class
                    Connection database = new Connection();

                    if (database.Conn.State == ConnectionState.Open) // Check if the connection is open
                    {
                       
                        string insert_acc = "INSERT INTO admins (username, name, password, email, phonenumber, position) " +
                                             "VALUES (@username, @name, @password, @email, @phonenumber, @position)";
                        MySqlCommand insertCommand = new MySqlCommand(insert_acc, database.Conn);

                       
                        insertCommand.Parameters.AddWithValue("@username", usernametxt.Text);
                        insertCommand.Parameters.AddWithValue("@name", nametxt.Text);
                        insertCommand.Parameters.AddWithValue("@password", passwordtxt.Text);
                        insertCommand.Parameters.AddWithValue("@email", emailtxt.Text);
                        insertCommand.Parameters.AddWithValue("@phonenumber", phonenumbertxt.Text);
                        insertCommand.Parameters.AddWithValue("@position", positiontxt.Text);

                        try
                        {
                            int rowsAffected = insertCommand.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                UpdateStatusToInactive(database);

                                MessageBox.Show("Admin was successfully added!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                clearTextbox();
                                BackToAccountList();
                            }
                            else
                            {
                                MessageBox.Show("Failed to add admin!");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error in adding admin!" + ex.Message);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Database connection failed!");
                    }

                    database.CloseConnection(); // Close the database connection
                }
                catch (Exception ex)
                {
                    Console.WriteLine("MySQL Error!" + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please fill in all required fields!");
            }
        }
        private void UpdateStatusToInactive(Connection database)
        {
            string stm = "UPDATE admins SET status = 'Inactive' WHERE username != @username";

            try
            {
                if (database.Conn.State == ConnectionState.Closed)
                    database.Conn.Open();

                using (MySqlCommand cmd = new MySqlCommand(stm, database.Conn))
                {
                    cmd.Parameters.AddWithValue("@username", usernametxt.Text);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (database.Conn.State == ConnectionState.Open)
                    database.CloseConnection();
            }
        }
        private void BackToAccountList()
        {
            this.Hide();
            AccountList frm = new AccountList();
            frm.ShowDialog();
            this.Close();
        }

        private void cancelButton_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            AccountList frm = new AccountList();
            frm.ShowDialog();
            this.Close();
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimize_Click(object sender, EventArgs e)
        {

        }

        private void maximize_Click(object sender, EventArgs e)
        {

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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard frm = new Dashboard();
            frm.Show();
        }

        private void accountList_Click(object sender, EventArgs e)
        {
            this.Hide();
            AccountList frm = new AccountList();
            frm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            About frm = new About();
            frm.Show();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            UpdateAccount frm = new UpdateAccount();
            frm.Show();
        }

        private void transactionsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Transaction frm = new Transaction();
            frm.Show();
        }
    }
}
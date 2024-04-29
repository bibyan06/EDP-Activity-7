using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


namespace SirKitsItems
{
    public partial class UpdateAccount : Form
    {
        private Connection myConnection;

        public UpdateAccount()
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

        private void updateaccountButton_Click(object sender, EventArgs e)
        {
            if (allFilled())
            {
                try
                {
                    if (myConnection.Conn.State == ConnectionState.Open) // Check if the connection is open
                    {
                        string updateQuery = "UPDATE admins SET name = @name, password = @password, email = @email, phonenumber = @phonenumber, position = @position WHERE username = @username";
                        MySqlCommand updateCommand = new MySqlCommand(updateQuery, myConnection.Conn);

                        // Add parameters for update
                        updateCommand.Parameters.AddWithValue("@username", usernametxt.Text);
                        updateCommand.Parameters.AddWithValue("@name", nametxt.Text);
                        updateCommand.Parameters.AddWithValue("@password", passwordtxt.Text);
                        updateCommand.Parameters.AddWithValue("@email", emailtxt.Text);
                        updateCommand.Parameters.AddWithValue("@phonenumber", phonenumbertxt.Text);
                        updateCommand.Parameters.AddWithValue("@position", positiontxt.Text);

                        try
                        {
                            int rowsAffected = updateCommand.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("User information updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                clearTextbox();
                                BackToAccountList();
                            }
                            else
                            {
                                MessageBox.Show("Failed to update user information!");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error in updating user information!" + ex.Message);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Database connection failed!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("MySQL Error!" + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please fill in all required fields!");
            }
        }
        private void ClearTextBox()
        {
            usernametxt.Text = "";
            nametxt.Text = "";
            passwordtxt.Text = "";
            emailtxt.Text = "";
            phonenumbertxt.Text = "";
            positiontxt.Text = "";
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
            BackToAccountList();
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void cancelButton_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            AccountList frm = new AccountList();
            frm.Show();
        }

        private void addAccountButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddAccount frm = new AddAccount();
            frm.Show();
        }

        private void close_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dashboardButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard frm = new Dashboard();
            frm.Show();
        }

        private void accountlistsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AccountList frm = new AccountList();
            frm.ShowDialog();
            this.Close();
        }

        private void transactionsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Transaction frm = new Transaction();
            frm.Show();
        }

        private void aboutUsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            About frm = new About();
            frm.ShowDialog();
            this.Close();
        }

        private void logout_Click_1(object sender, EventArgs e)
        {
            UpdateStatusToInactive();
            this.Hide();
            Form1 frm = new Form1();
            frm.ShowDialog();
            this.Close();
        }
    }
}

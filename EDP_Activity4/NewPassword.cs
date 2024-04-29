using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SirKitsItems
{
    public partial class NewPassword : Form
    {
        public static string emailAddress;
        public Connection myConnection;
        public NewPassword()
        {
            InitializeComponent();
            myConnection = new Connection();
        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string newPassword = newpass.Text;
            string confirmedPassword = confirmpass.Text;

            // Check if passwords match
            if (newPassword != confirmedPassword)
            {
                MessageBox.Show("Passwords do not match! Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check if password meets minimum length requirement of 8 characters
            if (newPassword.Length < 8)
            {
                MessageBox.Show("Password must be at least 8 characters long.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string email = PasswordRecovery.emailAddress;

            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Email address not provided! Failed to reset password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                string stm = "UPDATE admins SET password = @Password WHERE email = @Email";

                // Use the connection from the Connection class
                using (MySqlCommand cmd = new MySqlCommand(stm, myConnection.Conn))
                {
                    cmd.Parameters.AddWithValue("@Password", newPassword);
                    cmd.Parameters.AddWithValue("@Email", email);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        // Successful password update, back to login
                        MessageBox.Show("Password updated! Please log in again.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoginForm();
                    }
                    else
                    {
                        // No rows affected (email not found)
                        MessageBox.Show("Email not found! Password update failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (MySqlException ex)
            {
                // Handle MySQL exceptions
                MessageBox.Show("MySQL Error!" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoginForm()
        {
            this.Hide();
            Form1 frm = new Form1();
            frm.ShowDialog();
            this.Close();
        }

        private void close_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}


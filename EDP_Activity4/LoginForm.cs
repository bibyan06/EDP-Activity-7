using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace EDP_Activity4
{
    public partial class Form1 : Form
    {
        public Connection myConnection;
        public string Username { get; set; }
        

        public Form1()
        {
            InitializeComponent();
            myConnection = new Connection();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            PasswordRecovery frm = new PasswordRecovery();
            frm.ShowDialog();
            this.Close();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
               passwordtextBox.UseSystemPasswordChar = false;
            }
            else
            {
                passwordtextBox.UseSystemPasswordChar = true;
            }
        }

        private void loginbttn_Click(object sender, EventArgs e)
        {
            
            try
            {
                // Create an instance of the Connection class
                Connection conn = new Connection();

                // Get the username and password from the input controls
                string username = usernametextBox.Text;
                string password = passwordtextBox.Text;
                string stm = "select username, password from admins WHERE username = @Name AND password = @Password";

                // Use the connection from the Connection class
                using (MySqlCommand cmd = new MySqlCommand(stm, conn.Conn))
                {
                    cmd.Parameters.AddWithValue("@Name", username);
                    cmd.Parameters.AddWithValue("@Password", password);

                    using (MySqlDataReader rdr = cmd.ExecuteReader())
                    {
                        if (rdr.HasRows)
                        {
                            // Successful login, navigate to the dashboard
                           
                            Username = usernametextBox.Text;
                            UpdateStatusToActive(username);
                            Dashboard();

                        }
                        else
                        {
                            // Username or password incorrect
                            MessageBox.Show("Username or password incorrect");
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                // Handle MySQL exceptions
                Console.WriteLine("MySQL Error: " + ex.Message);
                // You may want to display a user-friendly message or log the error
            }
        }
        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Dashboard()
        {
            this.Hide();
            Dashboard frm = new Dashboard();
            frm.ShowDialog();
            this.Close();
        }

        private void UpdateStatusToActive(string username)
        {
            try
            {
                // Update the status to "Active" for the logged-in user
                string updateStm = "UPDATE admins SET status = 'Active' WHERE username = @Name";

                using (MySqlCommand updateCmd = new MySqlCommand(updateStm, myConnection.Conn))
                {
                    updateCmd.Parameters.AddWithValue("@Name", username);
                    updateCmd.ExecuteNonQuery();
                }
            }
            catch (MySqlException ex)
            {
                // Handle MySQL exceptions for status update
                Console.WriteLine("MySQL Error during status update: " + ex.Message);
                // You may want to display a user-friendly message or log the error
            }
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                // Set the password character to a null character to reveal the inputted text
                passwordtextBox.PasswordChar = '\0';
            }
            else
            {
                // Set the password character to '*' to hide the inputted text
                passwordtextBox.PasswordChar = '*';
            }
        }
    }
}
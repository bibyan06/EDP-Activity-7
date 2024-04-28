using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using MySql.Data.MySqlClient;

namespace EDP_Activity4
{
    
    public partial class PasswordRecovery : Form
    {
        public static string emailAddress;
        public Connection myConnection;
        public PasswordRecovery()
        {
            InitializeComponent();
            myConnection = new Connection();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            try
            {
                string email = emailreset.Text;
                string stm = "SELECT email FROM admins WHERE email = @Email";
                using (MySqlCommand cmd = new MySqlCommand(stm, myConnection.Conn))
                {
                    cmd.Parameters.AddWithValue("@Email", emailreset.Text);

                    using (MySqlDataReader rdr = cmd.ExecuteReader())
                    {
                        if (rdr.HasRows)
                        {
                            // Set the value of the public static property
                            emailAddress = emailreset.Text;
                      
                            rdr.Read();
                            string dbEmail = rdr["email"].ToString();

                            if (email == dbEmail)
                            {
                                // Successful login, navigate to the dashboard
                                NewPasswordRedirect();
                                return; 
                            }
                        }
                        MessageBox.Show("Account does not exist! Incorrect email.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch(MySqlException ex) 
            {
                MessageBox.Show("MySQL Error!" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void NewPasswordRedirect()
        {
            this.Hide();
            NewPassword frm = new NewPassword();
            frm.ShowDialog();
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
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


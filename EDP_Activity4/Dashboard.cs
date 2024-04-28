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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace EDP_Activity4
{
    public partial class Dashboard : Form
    {
        public Connection myConnection;
        private string username;
        public Dashboard()
        {
            InitializeComponent();
            myConnection = new Connection();
            //this.username = username;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void aboutUs_Click(object sender, EventArgs e)
        {
            // Redirect to AccountList form
            OpenAccountList();
        }

        private void OpenAccountList()
        {
            this.Hide();
            AccountList frm = new AccountList();
            frm.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Transaction frm = new Transaction();
            frm.ShowDialog();

        }

        private void logout_Click(object sender, EventArgs e)
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

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            About frm = new About();
            frm.ShowDialog();
        }

        private void dashboardButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard frm = new Dashboard();
            frm.ShowDialog();
        }
    }
}

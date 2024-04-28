using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OfficeOpenXml;
using ClosedXML.Excel;
using ClosedXML.Extensions;
using System.Windows.Controls;
using System.IO;
using DocumentFormat.OpenXml.Drawing;
using System.Globalization;

namespace EDP_Activity4
{
    public partial class StocksReport : Form
    {
        private Connection myConnection;
        private string selectedFilePath;
        private string username;
        public StocksReport()
        {
            InitializeComponent();
            myConnection = new Connection();
            this.username = username;
            this.Load += StocksReport_Load;
            this.Load += totalSales_TextChanged;
            this.Load += totalOrders_TextChanged;
            this.Load += totalStockLeft_TextChanged;
            
        }

        private void StocksReport_Load(object sender, EventArgs e)
        {
            loadData();

        }

        public void loadData()
        {
            try
            {
                // Open the connection if it's closed
                if (myConnection.Conn.State == ConnectionState.Closed)
                    myConnection.Conn.Open();

               
                string query = "SELECT * FROM productstockview";

                // Execute the query
                using (MySqlCommand cmd = new MySqlCommand(query, myConnection.Conn))
                {
                    // Create a data adapter and fill a DataTable
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Set the DataTable as the DataSource for the DataGridView
                    transactionsData.DataSource = dataTable;
                }
            }
            catch (MySqlException ex)
            {
                // Handle MySQL exceptions
                Console.WriteLine("MySQL Error: " + ex.Message);
            }
            finally
            {
                // Close the connection if it's open
                if (myConnection.Conn.State == ConnectionState.Open)
                    myConnection.CloseConnection();
            }

        }

        private void totalSales_TextChanged(object sender, EventArgs e)
        {
            ComputeTotalSales();
        }
        private void ComputeTotalSales()
        {
            try
            {
                if (myConnection.Conn.State == ConnectionState.Closed)
                    myConnection.Conn.Open();

                string query = "SELECT SUM(TotalSale) AS TotalSales FROM totalsalesview";

                using (MySqlCommand cmd = new MySqlCommand(query, myConnection.Conn))
                {
                    object result = cmd.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        totalSales.Text = result.ToString();
                    }
                    else
                    {
                        totalSales.Text = "0"; // Set to 0 if no sales found
                    }
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("MySQL Error: " + ex.Message);
            }
            finally
            {
                if (myConnection.Conn.State == ConnectionState.Open)
                    myConnection.CloseConnection();
            }
        }

        private void totalOrders_TextChanged(object sender, EventArgs e)
        {
            ComputeTotalOrder();
        }
        private void ComputeTotalOrder()
        {
            try
            {
                if (myConnection.Conn.State == ConnectionState.Closed)
                    myConnection.Conn.Open();

                string query = "SELECT SUM(Quantity) AS TotalOrder FROM totalsalesview";

                using (MySqlCommand cmd = new MySqlCommand(query, myConnection.Conn))
                {
                    object result = cmd.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        totalOrders.Text = result.ToString();
                    }
                    else
                    {
                        totalOrders.Text = "0"; // Set to 0 if no sales found
                    }
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("MySQL Error: " + ex.Message);
            }
            finally
            {
                if (myConnection.Conn.State == ConnectionState.Open)
                    myConnection.CloseConnection();
            }
        }

        private void totalStockLeft_TextChanged(object sender, EventArgs e)
        {
            ComputeTotalStockLeft();
        }
        private void ComputeTotalStockLeft()
        {
            try
            {
                if (myConnection.Conn.State == ConnectionState.Closed)
                    myConnection.Conn.Open();

                string query = "SELECT SUM(StockQuantity) AS TotalStockLeft FROM totalsalesview";

                using (MySqlCommand cmd = new MySqlCommand(query, myConnection.Conn))
                {
                    object result = cmd.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        totalStockLeft.Text = result.ToString();
                    }
                    else
                    {
                        totalStockLeft.Text = "0"; // Set to 0 if no sales found
                    }
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("MySQL Error: " + ex.Message);
            }
            finally
            {
                if (myConnection.Conn.State == ConnectionState.Open)
                    myConnection.CloseConnection();
            }
        }

        private void filepath_TextChanged(object sender, EventArgs e)
        {
            filepath.Text = selectedFilePath;
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Excel Files|*.xlsx;*.xls";
                openFileDialog.Title = "Select Excel File";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Get the selected file path
                    selectedFilePath = openFileDialog.FileName;

                    filepath.Text = selectedFilePath;
                }
            }
        }

        private void printButton_Click(object sender, EventArgs e)
        {
           
            if (string.IsNullOrEmpty(selectedFilePath))
            {
                MessageBox.Show("Please select an Excel file.");
                return;
            }

            try
            {
                // Generate a unique file name based on the selected file path
                string newFilePath = GenerateUniqueFileName(selectedFilePath);

                // Load the selected Excel file as a template
                using (var workbook = new XLWorkbook(selectedFilePath))
                {
                    // Get the first worksheet in the workbook
                    var worksheet = workbook.Worksheet(1);

                    // Find the cell where you want to start writing the data
                    int startRow = 13; // Start from row 2 (assuming row 1 is for headers)
                    int startColumn = 3; // Start from column A

                    DateTime currentDate = DateTime.Now;
                    var dateRequestedCell = worksheet.Cell(startRow - 4, startColumn);
                    dateRequestedCell.Value = "Date Requested:";
                    dateRequestedCell.Style.Font.Bold = true;
                    worksheet.Cell(startRow - 4, startColumn + 1).Value = currentDate.ToString("MM/dd/yyyy");

                    // Loop through each row in the DataGridView
                    for (int i = 0; i < transactionsData.Rows.Count; i++)
                    {
                        // Loop through each column in the DataGridView
                        for (int j = 0; j < transactionsData.Columns.Count; j++)
                        {
                            // Write the cell value to the corresponding cell in Excel
                            if (transactionsData.Columns[j].Name == "ProductID" || transactionsData.Columns[j].Name == "StockQuantity")
                            {
                                // Parse the value to integer and write to Excel
                                int value;
                                if (int.TryParse(transactionsData.Rows[i].Cells[j].Value?.ToString(), out value))
                                {
                                    worksheet.Cell(startRow + i, startColumn + j).Value = value;
                                }
                            }
                            else
                            {
                                // Write other cell values to Excel
                                worksheet.Cell(startRow + i, startColumn + j).Value = transactionsData.Rows[i].Cells[j].Value?.ToString();
                            }
                        }
                    }

                    // Retrieve the username from the login form
                    string username = UserSession.LoggedInUsername;



                    // Write the username to the last row in the Excel sheet
                    int lastRow = startRow + transactionsData.Rows.Count;
                    worksheet.Cell(lastRow + 1, startColumn - 1).Value = "Prepared By:";
                    worksheet.Cell(lastRow + 3, startColumn).Value = "Admin Officer";
                    worksheet.Cell(lastRow + 3, startColumn + 1).Value = username.ToUpper();

                    // Save the modified workbook to the new file path
                    workbook.SaveAs(newFilePath);

                    MessageBox.Show("Data printed to Excel successfully.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while printing data to Excel: {ex.Message}");
            }
        }

        private string GenerateUniqueFileName(string filePath)
        {
            string directory = System.IO.Path.GetDirectoryName(filePath);

            // Get the file name without extension
            string fileNameWithoutExtension = System.IO.Path.GetFileNameWithoutExtension(filePath);

            // Get the file extension
            string fileExtension = System.IO.Path.GetExtension(filePath);

            // Generate a unique file name by appending a timestamp
            string uniqueFileName = $"{fileNameWithoutExtension}_{DateTime.Now:MMddyyyy_HHmmss}{fileExtension}";

            // Combine the directory and unique file name to get the new file path
            string newFilePath = System.IO.Path.Combine(directory, uniqueFileName);

            return newFilePath;
        }

        private void totalOrderButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            OrderReport frm = new OrderReport();
            frm.ShowDialog();
        }

        private void totalSalesButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Transaction frm = new Transaction();
            frm.ShowDialog();
        }

        private void stockonHandButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            StocksReport frm = new StocksReport();
            frm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard frm = new Dashboard();
            frm.ShowDialog();
        }

        private void AccountLisy_Click(object sender, EventArgs e)
        {
            this.Hide();
            AccountList frm = new AccountList();
            frm.ShowDialog();
        }

        private void transactionsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Transaction frm = new Transaction();
            frm.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            About frm = new About();
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
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
    }
}

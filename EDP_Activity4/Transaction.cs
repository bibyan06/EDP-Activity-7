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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace SirKitsItems
{
    public partial class Transaction : Form
    {
        private Connection myConnection;
        private string selectedFilePath;
        public Transaction()
        {
            InitializeComponent();
            myConnection = new Connection();
            transactionsData.CellContentClick += transactions_CellContentClick;
            this.Load += Transaction_Load;
            this.Load += totalSales_TextChanged;
            this.Load += totalOrders_TextChanged;
            this.Load += totalStockLeft_TextChanged;
            totalOrderButton.Click += totalOrderButton_Click;
            totalSalesButton.Click += totalSalesButton_Click;
            stockonHandButton.Click += stockonHandButton_Click;
            
        }

        private void Transaction_Load(object sender, EventArgs e)
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

                string query = "SELECT * FROM totalsalesview";

                // Use the public MySqlConnection from Connection class
                using (MySqlCommand cmd = new MySqlCommand(query, myConnection.Conn))
                {
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable db = new DataTable();
                    adapter.Fill(db);
                    BindingSource bindingSource = new BindingSource();
                    bindingSource.DataSource = db;

                    transactionsData.DataSource = bindingSource;
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


        private void transactions_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && transactionsData.Columns[e.ColumnIndex].Name == "Transaction")
            {
                string CustomerID = transactionsData.Rows[e.RowIndex].Cells["CustomerID"].Value.ToString();
                string CustomerName = transactionsData.Rows[e.RowIndex].Cells["CustomerName"].Value.ToString();
                string OrderID = transactionsData.Rows[e.RowIndex].Cells["OrderID"].Value.ToString();
                string OrderDate = transactionsData.Rows[e.RowIndex].Cells["OrderDate"].Value.ToString();
                string ProductID = transactionsData.Rows[e.RowIndex].Cells["ProductID"].Value.ToString();
                string ProductName = transactionsData.Rows[e.RowIndex].Cells["ProductName"].Value.ToString();
                string Quantity = transactionsData.Rows[e.RowIndex].Cells["Quantity"].Value.ToString();
                string TotalSale = transactionsData.Rows[e.RowIndex].Cells["TotalSale"].Value.ToString();
            }
        }

        private void totalSales_Paint(object sender, PaintEventArgs e)
        {

        }

        private void totalSalesClick_Paint(object sender, PaintEventArgs e)
        {
            loadData();
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard frm = new Dashboard();
            frm.Show();
        }

        private void AccountLisy_Click(object sender, EventArgs e)
        {
            this.Hide();
            AccountList frm = new AccountList();
            frm.Show();
        }

        private void transactionsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Transaction frm = new Transaction();
            frm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            About frm = new About();
            frm.Show();
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
                if (myConnection.Conn.State == ConnectionState.Open)
                    myConnection.CloseConnection();
            }
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            // Check if a file has been selected
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
                    int startRow = 13; 
                    int startColumn = 3;

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
                            if (transactionsData.Columns[j].Name == "TotalSale")
                            {
                                // Convert TotalSales to double
                                if (double.TryParse(transactionsData.Rows[i].Cells[j].Value?.ToString(), out double totalSalesValue))
                                {
                                    worksheet.Cell(startRow + i, startColumn + j).Value = totalSalesValue;
                                }
                                else
                                {
                                    worksheet.Cell(startRow + i, startColumn + j).Value = 0; // Set default value to 0
                                }
                            }
                            else if (transactionsData.Columns[j].Name == "CustomerID" ||
                                     transactionsData.Columns[j].Name == "OrderID" ||
                                     transactionsData.Columns[j].Name == "ProductID" ||
                                     transactionsData.Columns[j].Name == "Quantity" ||
                                     transactionsData.Columns[j].Name == "StockQuantity")
                            {
                                // Convert CustomerID, OrderID, ProductID, Quantity, and StockQuantity to integer
                                if (int.TryParse(transactionsData.Rows[i].Cells[j].Value?.ToString(), out int integerValue))
                                {
                                    worksheet.Cell(startRow + i, startColumn + j).Value = integerValue;
                                }
                                else
                                {
                                    worksheet.Cell(startRow + i, startColumn + j).Value = 0; // Set default value to 0
                                }
                            }
                            else
                            {
                                worksheet.Cell(startRow + i, startColumn + j).Value = transactionsData.Rows[i].Cells[j].Value?.ToString();
                            }
                        }
                    }

                    decimal totalSales = GetTotalSalesFromDatabase();
                    var totalSalesCell = worksheet.Cell(startRow + transactionsData.Rows.Count + 1, startColumn + 7);
                    totalSalesCell.Value = "Grand Total :";
                    totalSalesCell.Style.Font.Bold = true;
                    worksheet.Cell(startRow + transactionsData.Rows.Count + 1, startColumn + 8).Value = totalSales;

                    // Write the username to the last row in the Excel sheet
                    int lastRow = startRow + transactionsData.Rows.Count;
                    worksheet.Cell(lastRow + 2, startColumn - 1).Value = "Prepared By:";
                    worksheet.Cell(lastRow + 5, startColumn).Value = "Admin Officer";
                    //worksheet.Cell(lastRow + 3, startColumn + 1).Value = username;

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

        private decimal GetTotalSalesFromDatabase()
        {
            decimal totalSales = 0;

            try
            {
                if (myConnection.Conn.State == ConnectionState.Closed)
                    myConnection.Conn.Open();

                string query = "SELECT TotalSales FROM totalsalestotal";

                using (MySqlCommand cmd = new MySqlCommand(query, myConnection.Conn))
                {
                    object result = cmd.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        totalSales = Convert.ToDecimal(result);
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

            return totalSales;
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
        private void ShowSelectedOrdersColumns()
        {
            try
            {
                // Ensure the connection is open before executing the query
                if (myConnection.Conn.State == ConnectionState.Closed)
                    myConnection.Conn.Open();

                string query = "SELECT * FROM orderdetailsview";

                // Use the public MySqlConnection from Connection class
                using (MySqlCommand cmd = new MySqlCommand(query, myConnection.Conn))
                {
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable db = new DataTable();
                    adapter.Fill(db);
                    BindingSource bindingSource = new BindingSource();
                    bindingSource.DataSource = db;

                    transactionsData.DataSource = bindingSource;
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

        private void ShowSelectedStocksColumns()
        {
            try
            {
                // Ensure the connection is open before executing the query
                if (myConnection.Conn.State == ConnectionState.Closed)
                    myConnection.Conn.Open();

                string query = "SELECT * FROM productstockview";

                // Use the public MySqlConnection from Connection class
                using (MySqlCommand cmd = new MySqlCommand(query, myConnection.Conn))
                {
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable db = new DataTable();
                    adapter.Fill(db);
                    BindingSource bindingSource = new BindingSource();
                    bindingSource.DataSource = db;

                    transactionsData.DataSource = bindingSource;
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

        private void ShowTotalSalesView()
        {
            try
            {
                // Ensure the connection is open before executing the query
                if (myConnection.Conn.State == ConnectionState.Closed)
                    myConnection.Conn.Open();

                string query = "SELECT * FROM totalsalesview";

                // Use the public MySqlConnection from Connection class
                using (MySqlCommand cmd = new MySqlCommand(query, myConnection.Conn))
                {
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable db = new DataTable();
                    adapter.Fill(db);
                    BindingSource bindingSource = new BindingSource();
                    bindingSource.DataSource = db;

                    transactionsData.DataSource = bindingSource;
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
        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
        private void totalSalesButton_Click(object sender, EventArgs e)
        {
            ShowTotalSalesView();
        }

        private void totalOrderButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            OrderReport frm = new OrderReport();
            frm.ShowDialog();
        }

        private void stockonHandButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            StocksReport frm = new StocksReport();
            frm.ShowDialog();
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

        private void filepath_TextChanged(object sender, EventArgs e)
        {
            filepath.Text = selectedFilePath;
        }

      
        

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void minimize_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void maximize_Click(object sender, EventArgs e)
        {

        }

        private void iconButton4_Click(object sender, EventArgs e)
        {

        }

        private void iconButton5_Click(object sender, EventArgs e)
        {

        }

        private void iconButton6_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {

        }

        private void homesidebar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconButton10_Click(object sender, EventArgs e)
        {

        }

        private void about_Click(object sender, EventArgs e)
        {

        }

        private void house_Click(object sender, EventArgs e)
        {

        }

        private void iconButton9_Click(object sender, EventArgs e)
        {

        }

        private void homelogo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void dashboardcenter_Paint(object sender, PaintEventArgs e)
        {

        }

        private void print_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconButton7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void iconButton3_Click(object sender, EventArgs e)
        {

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

namespace EDP_Activity4
{
    partial class Transaction
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Transaction));
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.minimize = new FontAwesome.Sharp.IconButton();
            this.label3 = new System.Windows.Forms.Label();
            this.maximize = new FontAwesome.Sharp.IconButton();
            this.close = new FontAwesome.Sharp.IconButton();
            this.iconButton4 = new FontAwesome.Sharp.IconButton();
            this.iconButton5 = new FontAwesome.Sharp.IconButton();
            this.iconButton6 = new FontAwesome.Sharp.IconButton();
            this.homesidebar = new System.Windows.Forms.Panel();
            this.transactionsButton = new System.Windows.Forms.Button();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.button5 = new System.Windows.Forms.Button();
            this.iconButton10 = new FontAwesome.Sharp.IconButton();
            this.AccountLisy = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.about = new FontAwesome.Sharp.IconButton();
            this.house = new FontAwesome.Sharp.IconButton();
            this.logoutButton = new System.Windows.Forms.Button();
            this.iconButton9 = new FontAwesome.Sharp.IconButton();
            this.homelogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dashboardcenter = new System.Windows.Forms.Panel();
            this.browseButton = new FontAwesome.Sharp.IconButton();
            this.filepath = new System.Windows.Forms.TextBox();
            this.print = new FontAwesome.Sharp.IconButton();
            this.printButton = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.stockonHandButton = new System.Windows.Forms.Button();
            this.totalStockLeft = new System.Windows.Forms.TextBox();
            this.iconButton7 = new FontAwesome.Sharp.IconButton();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.totalOrderButton = new System.Windows.Forms.Button();
            this.totalOrders = new System.Windows.Forms.TextBox();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.totalSalesClick = new System.Windows.Forms.Panel();
            this.totalSalesButton = new System.Windows.Forms.Button();
            this.totalSales = new System.Windows.Forms.TextBox();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.transactionsData = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel7.SuspendLayout();
            this.panel2.SuspendLayout();
            this.homesidebar.SuspendLayout();
            this.homelogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.dashboardcenter.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.totalSalesClick.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsData)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel7.Controls.Add(this.panel2);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Margin = new System.Windows.Forms.Padding(4);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1089, 52);
            this.panel7.TabIndex = 1;
            this.panel7.Paint += new System.Windows.Forms.PaintEventHandler(this.panel7_Paint);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.minimize);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.maximize);
            this.panel2.Controls.Add(this.close);
            this.panel2.Controls.Add(this.iconButton4);
            this.panel2.Controls.Add(this.iconButton5);
            this.panel2.Controls.Add(this.iconButton6);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1089, 550);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // minimize
            // 
            this.minimize.BackColor = System.Drawing.Color.Transparent;
            this.minimize.FlatAppearance.BorderSize = 0;
            this.minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimize.ForeColor = System.Drawing.Color.Black;
            this.minimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.minimize.IconColor = System.Drawing.Color.Black;
            this.minimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.minimize.IconSize = 17;
            this.minimize.Location = new System.Drawing.Point(927, 12);
            this.minimize.Margin = new System.Windows.Forms.Padding(4);
            this.minimize.Name = "minimize";
            this.minimize.Size = new System.Drawing.Size(35, 28);
            this.minimize.TabIndex = 30;
            this.minimize.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.minimize.UseVisualStyleBackColor = false;
            this.minimize.Click += new System.EventHandler(this.minimize_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(29, 20);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 17);
            this.label3.TabIndex = 30;
            this.label3.Text = "Transactions";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // maximize
            // 
            this.maximize.BackColor = System.Drawing.Color.Transparent;
            this.maximize.FlatAppearance.BorderSize = 0;
            this.maximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.maximize.ForeColor = System.Drawing.Color.Black;
            this.maximize.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.maximize.IconColor = System.Drawing.Color.Black;
            this.maximize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.maximize.IconSize = 17;
            this.maximize.Location = new System.Drawing.Point(968, 12);
            this.maximize.Margin = new System.Windows.Forms.Padding(4);
            this.maximize.Name = "maximize";
            this.maximize.Size = new System.Drawing.Size(36, 30);
            this.maximize.TabIndex = 31;
            this.maximize.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.maximize.UseVisualStyleBackColor = false;
            this.maximize.Click += new System.EventHandler(this.maximize_Click);
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.Color.Transparent;
            this.close.FlatAppearance.BorderSize = 0;
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close.ForeColor = System.Drawing.Color.Transparent;
            this.close.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.close.IconColor = System.Drawing.Color.Black;
            this.close.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.close.IconSize = 17;
            this.close.Location = new System.Drawing.Point(1005, 12);
            this.close.Margin = new System.Windows.Forms.Padding(4);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(39, 28);
            this.close.TabIndex = 32;
            this.close.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.close.UseVisualStyleBackColor = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // iconButton4
            // 
            this.iconButton4.BackColor = System.Drawing.Color.Transparent;
            this.iconButton4.FlatAppearance.BorderSize = 0;
            this.iconButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton4.ForeColor = System.Drawing.Color.Black;
            this.iconButton4.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.iconButton4.IconColor = System.Drawing.Color.Black;
            this.iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton4.IconSize = 17;
            this.iconButton4.Location = new System.Drawing.Point(499, 258);
            this.iconButton4.Margin = new System.Windows.Forms.Padding(4);
            this.iconButton4.Name = "iconButton4";
            this.iconButton4.Size = new System.Drawing.Size(35, 32);
            this.iconButton4.TabIndex = 30;
            this.iconButton4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton4.UseVisualStyleBackColor = false;
            this.iconButton4.Click += new System.EventHandler(this.iconButton4_Click);
            // 
            // iconButton5
            // 
            this.iconButton5.BackColor = System.Drawing.Color.Transparent;
            this.iconButton5.FlatAppearance.BorderSize = 0;
            this.iconButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton5.ForeColor = System.Drawing.Color.Black;
            this.iconButton5.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.iconButton5.IconColor = System.Drawing.Color.Black;
            this.iconButton5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton5.IconSize = 17;
            this.iconButton5.Location = new System.Drawing.Point(527, 255);
            this.iconButton5.Margin = new System.Windows.Forms.Padding(4);
            this.iconButton5.Name = "iconButton5";
            this.iconButton5.Size = new System.Drawing.Size(36, 39);
            this.iconButton5.TabIndex = 31;
            this.iconButton5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton5.UseVisualStyleBackColor = false;
            this.iconButton5.Click += new System.EventHandler(this.iconButton5_Click);
            // 
            // iconButton6
            // 
            this.iconButton6.BackColor = System.Drawing.Color.Transparent;
            this.iconButton6.FlatAppearance.BorderSize = 0;
            this.iconButton6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton6.ForeColor = System.Drawing.Color.Transparent;
            this.iconButton6.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.iconButton6.IconColor = System.Drawing.Color.Black;
            this.iconButton6.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton6.IconSize = 17;
            this.iconButton6.Location = new System.Drawing.Point(551, 258);
            this.iconButton6.Margin = new System.Windows.Forms.Padding(4);
            this.iconButton6.Name = "iconButton6";
            this.iconButton6.Size = new System.Drawing.Size(39, 32);
            this.iconButton6.TabIndex = 32;
            this.iconButton6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton6.UseVisualStyleBackColor = false;
            this.iconButton6.Click += new System.EventHandler(this.iconButton6_Click);
            // 
            // homesidebar
            // 
            this.homesidebar.Controls.Add(this.transactionsButton);
            this.homesidebar.Controls.Add(this.iconButton1);
            this.homesidebar.Controls.Add(this.button5);
            this.homesidebar.Controls.Add(this.iconButton10);
            this.homesidebar.Controls.Add(this.AccountLisy);
            this.homesidebar.Controls.Add(this.button1);
            this.homesidebar.Controls.Add(this.about);
            this.homesidebar.Controls.Add(this.house);
            this.homesidebar.Controls.Add(this.logoutButton);
            this.homesidebar.Controls.Add(this.iconButton9);
            this.homesidebar.Controls.Add(this.homelogo);
            this.homesidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.homesidebar.Location = new System.Drawing.Point(0, 52);
            this.homesidebar.Margin = new System.Windows.Forms.Padding(4);
            this.homesidebar.Name = "homesidebar";
            this.homesidebar.Size = new System.Drawing.Size(217, 503);
            this.homesidebar.TabIndex = 2;
            this.homesidebar.Paint += new System.Windows.Forms.PaintEventHandler(this.homesidebar_Paint);
            // 
            // transactionsButton
            // 
            this.transactionsButton.BackColor = System.Drawing.Color.Transparent;
            this.transactionsButton.FlatAppearance.BorderSize = 0;
            this.transactionsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.transactionsButton.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transactionsButton.ForeColor = System.Drawing.Color.White;
            this.transactionsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.transactionsButton.Location = new System.Drawing.Point(60, 245);
            this.transactionsButton.Margin = new System.Windows.Forms.Padding(4);
            this.transactionsButton.Name = "transactionsButton";
            this.transactionsButton.Size = new System.Drawing.Size(129, 32);
            this.transactionsButton.TabIndex = 37;
            this.transactionsButton.Text = "Transactions";
            this.transactionsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.transactionsButton.UseCompatibleTextRendering = true;
            this.transactionsButton.UseVisualStyleBackColor = false;
            this.transactionsButton.Click += new System.EventHandler(this.transactionsButton_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.Transparent;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.ForeColor = System.Drawing.Color.Transparent;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.TableList;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 30;
            this.iconButton1.Location = new System.Drawing.Point(11, 239);
            this.iconButton1.Margin = new System.Windows.Forms.Padding(4);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(52, 47);
            this.iconButton1.TabIndex = 36;
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(60, 294);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(129, 32);
            this.button5.TabIndex = 29;
            this.button5.Text = "About Us";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.UseCompatibleTextRendering = true;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // iconButton10
            // 
            this.iconButton10.BackColor = System.Drawing.Color.Transparent;
            this.iconButton10.FlatAppearance.BorderSize = 0;
            this.iconButton10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton10.ForeColor = System.Drawing.Color.Transparent;
            this.iconButton10.IconChar = FontAwesome.Sharp.IconChar.CircleInfo;
            this.iconButton10.IconColor = System.Drawing.Color.White;
            this.iconButton10.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton10.IconSize = 30;
            this.iconButton10.Location = new System.Drawing.Point(11, 288);
            this.iconButton10.Margin = new System.Windows.Forms.Padding(4);
            this.iconButton10.Name = "iconButton10";
            this.iconButton10.Size = new System.Drawing.Size(52, 47);
            this.iconButton10.TabIndex = 28;
            this.iconButton10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton10.UseVisualStyleBackColor = false;
            this.iconButton10.Click += new System.EventHandler(this.iconButton10_Click);
            // 
            // AccountLisy
            // 
            this.AccountLisy.BackColor = System.Drawing.Color.Transparent;
            this.AccountLisy.FlatAppearance.BorderSize = 0;
            this.AccountLisy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AccountLisy.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccountLisy.ForeColor = System.Drawing.Color.White;
            this.AccountLisy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AccountLisy.Location = new System.Drawing.Point(60, 196);
            this.AccountLisy.Margin = new System.Windows.Forms.Padding(4);
            this.AccountLisy.Name = "AccountLisy";
            this.AccountLisy.Size = new System.Drawing.Size(129, 32);
            this.AccountLisy.TabIndex = 27;
            this.AccountLisy.Text = "My Teams";
            this.AccountLisy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AccountLisy.UseCompatibleTextRendering = true;
            this.AccountLisy.UseVisualStyleBackColor = false;
            this.AccountLisy.Click += new System.EventHandler(this.AccountLisy_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(60, 147);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 32);
            this.button1.TabIndex = 24;
            this.button1.Text = "Home";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // about
            // 
            this.about.BackColor = System.Drawing.Color.Transparent;
            this.about.FlatAppearance.BorderSize = 0;
            this.about.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.about.ForeColor = System.Drawing.Color.Transparent;
            this.about.IconChar = FontAwesome.Sharp.IconChar.UserGroup;
            this.about.IconColor = System.Drawing.Color.White;
            this.about.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.about.IconSize = 30;
            this.about.Location = new System.Drawing.Point(12, 189);
            this.about.Margin = new System.Windows.Forms.Padding(4);
            this.about.Name = "about";
            this.about.Size = new System.Drawing.Size(52, 47);
            this.about.TabIndex = 26;
            this.about.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.about.UseVisualStyleBackColor = false;
            this.about.Click += new System.EventHandler(this.about_Click);
            // 
            // house
            // 
            this.house.BackColor = System.Drawing.Color.Transparent;
            this.house.FlatAppearance.BorderSize = 0;
            this.house.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.house.ForeColor = System.Drawing.Color.White;
            this.house.IconChar = FontAwesome.Sharp.IconChar.House;
            this.house.IconColor = System.Drawing.Color.White;
            this.house.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.house.IconSize = 30;
            this.house.Location = new System.Drawing.Point(18, 142);
            this.house.Margin = new System.Windows.Forms.Padding(4);
            this.house.Name = "house";
            this.house.Size = new System.Drawing.Size(41, 39);
            this.house.TabIndex = 25;
            this.house.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.house.UseVisualStyleBackColor = false;
            this.house.Click += new System.EventHandler(this.house_Click);
            // 
            // logoutButton
            // 
            this.logoutButton.BackColor = System.Drawing.Color.Transparent;
            this.logoutButton.FlatAppearance.BorderSize = 0;
            this.logoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutButton.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutButton.ForeColor = System.Drawing.Color.White;
            this.logoutButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logoutButton.Location = new System.Drawing.Point(58, 456);
            this.logoutButton.Margin = new System.Windows.Forms.Padding(4);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(156, 32);
            this.logoutButton.TabIndex = 21;
            this.logoutButton.Text = "Logout";
            this.logoutButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logoutButton.UseCompatibleTextRendering = true;
            this.logoutButton.UseVisualStyleBackColor = false;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // iconButton9
            // 
            this.iconButton9.BackColor = System.Drawing.Color.Transparent;
            this.iconButton9.FlatAppearance.BorderSize = 0;
            this.iconButton9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton9.ForeColor = System.Drawing.Color.Transparent;
            this.iconButton9.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.iconButton9.IconColor = System.Drawing.Color.Red;
            this.iconButton9.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton9.IconSize = 29;
            this.iconButton9.Location = new System.Drawing.Point(24, 455);
            this.iconButton9.Margin = new System.Windows.Forms.Padding(4);
            this.iconButton9.Name = "iconButton9";
            this.iconButton9.Size = new System.Drawing.Size(29, 33);
            this.iconButton9.TabIndex = 20;
            this.iconButton9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton9.UseVisualStyleBackColor = false;
            this.iconButton9.Click += new System.EventHandler(this.iconButton9_Click);
            // 
            // homelogo
            // 
            this.homelogo.Controls.Add(this.pictureBox1);
            this.homelogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.homelogo.Location = new System.Drawing.Point(0, 0);
            this.homelogo.Margin = new System.Windows.Forms.Padding(4);
            this.homelogo.Name = "homelogo";
            this.homelogo.Size = new System.Drawing.Size(217, 102);
            this.homelogo.TabIndex = 0;
            this.homelogo.Paint += new System.Windows.Forms.PaintEventHandler(this.homelogo_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(7, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(201, 91);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // dashboardcenter
            // 
            this.dashboardcenter.BackColor = System.Drawing.Color.White;
            this.dashboardcenter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.dashboardcenter.Controls.Add(this.browseButton);
            this.dashboardcenter.Controls.Add(this.filepath);
            this.dashboardcenter.Controls.Add(this.print);
            this.dashboardcenter.Controls.Add(this.printButton);
            this.dashboardcenter.Controls.Add(this.panel5);
            this.dashboardcenter.Controls.Add(this.panel4);
            this.dashboardcenter.Controls.Add(this.totalSalesClick);
            this.dashboardcenter.Controls.Add(this.transactionsData);
            this.dashboardcenter.Location = new System.Drawing.Point(222, 57);
            this.dashboardcenter.Margin = new System.Windows.Forms.Padding(4);
            this.dashboardcenter.Name = "dashboardcenter";
            this.dashboardcenter.Size = new System.Drawing.Size(849, 491);
            this.dashboardcenter.TabIndex = 18;
            this.dashboardcenter.Paint += new System.Windows.Forms.PaintEventHandler(this.dashboardcenter_Paint);
            // 
            // browseButton
            // 
            this.browseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browseButton.IconChar = FontAwesome.Sharp.IconChar.None;
            this.browseButton.IconColor = System.Drawing.Color.Black;
            this.browseButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.browseButton.Location = new System.Drawing.Point(647, 126);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(37, 26);
            this.browseButton.TabIndex = 45;
            this.browseButton.Text = "...";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // filepath
            // 
            this.filepath.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filepath.Location = new System.Drawing.Point(8, 128);
            this.filepath.Name = "filepath";
            this.filepath.Size = new System.Drawing.Size(636, 27);
            this.filepath.TabIndex = 44;
            this.filepath.TextChanged += new System.EventHandler(this.filepath_TextChanged);
            // 
            // print
            // 
            this.print.BackColor = System.Drawing.Color.Transparent;
            this.print.FlatAppearance.BorderSize = 0;
            this.print.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.print.ForeColor = System.Drawing.Color.White;
            this.print.IconChar = FontAwesome.Sharp.IconChar.Download;
            this.print.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.print.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.print.IconSize = 30;
            this.print.Location = new System.Drawing.Point(706, 121);
            this.print.Margin = new System.Windows.Forms.Padding(4);
            this.print.Name = "print";
            this.print.Size = new System.Drawing.Size(41, 39);
            this.print.TabIndex = 42;
            this.print.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.print.UseVisualStyleBackColor = false;
            this.print.Click += new System.EventHandler(this.print_Click);
            // 
            // printButton
            // 
            this.printButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.printButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.printButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.printButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.printButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.printButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printButton.ForeColor = System.Drawing.Color.Black;
            this.printButton.Location = new System.Drawing.Point(748, 124);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(89, 27);
            this.printButton.TabIndex = 4;
            this.printButton.Text = "PRINT";
            this.printButton.UseVisualStyleBackColor = false;
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.stockonHandButton);
            this.panel5.Controls.Add(this.totalStockLeft);
            this.panel5.Controls.Add(this.iconButton7);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Location = new System.Drawing.Point(506, 22);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(258, 103);
            this.panel5.TabIndex = 3;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // stockonHandButton
            // 
            this.stockonHandButton.FlatAppearance.BorderSize = 0;
            this.stockonHandButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.stockonHandButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.stockonHandButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stockonHandButton.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockonHandButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.stockonHandButton.Location = new System.Drawing.Point(9, 8);
            this.stockonHandButton.Name = "stockonHandButton";
            this.stockonHandButton.Size = new System.Drawing.Size(160, 33);
            this.stockonHandButton.TabIndex = 42;
            this.stockonHandButton.Text = "Stock On Hand";
            this.stockonHandButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.stockonHandButton.UseVisualStyleBackColor = true;
            this.stockonHandButton.Click += new System.EventHandler(this.stockonHandButton_Click);
            // 
            // totalStockLeft
            // 
            this.totalStockLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalStockLeft.Location = new System.Drawing.Point(51, 50);
            this.totalStockLeft.Name = "totalStockLeft";
            this.totalStockLeft.Size = new System.Drawing.Size(159, 30);
            this.totalStockLeft.TabIndex = 41;
            this.totalStockLeft.TextChanged += new System.EventHandler(this.totalStockLeft_TextChanged);
            // 
            // iconButton7
            // 
            this.iconButton7.BackColor = System.Drawing.Color.Transparent;
            this.iconButton7.FlatAppearance.BorderSize = 0;
            this.iconButton7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton7.ForeColor = System.Drawing.Color.White;
            this.iconButton7.IconChar = FontAwesome.Sharp.IconChar.Box;
            this.iconButton7.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.iconButton7.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton7.IconSize = 30;
            this.iconButton7.Location = new System.Drawing.Point(9, 47);
            this.iconButton7.Margin = new System.Windows.Forms.Padding(4);
            this.iconButton7.Name = "iconButton7";
            this.iconButton7.Size = new System.Drawing.Size(41, 39);
            this.iconButton7.TabIndex = 40;
            this.iconButton7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton7.UseVisualStyleBackColor = false;
            this.iconButton7.Click += new System.EventHandler(this.iconButton7_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 12);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 23);
            this.label5.TabIndex = 14;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.totalOrderButton);
            this.panel4.Controls.Add(this.totalOrders);
            this.panel4.Controls.Add(this.iconButton3);
            this.panel4.Location = new System.Drawing.Point(252, 22);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(258, 103);
            this.panel4.TabIndex = 2;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // totalOrderButton
            // 
            this.totalOrderButton.FlatAppearance.BorderSize = 0;
            this.totalOrderButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.totalOrderButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.totalOrderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.totalOrderButton.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalOrderButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.totalOrderButton.Location = new System.Drawing.Point(9, 8);
            this.totalOrderButton.Name = "totalOrderButton";
            this.totalOrderButton.Size = new System.Drawing.Size(160, 33);
            this.totalOrderButton.TabIndex = 41;
            this.totalOrderButton.Text = "Total Orders";
            this.totalOrderButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.totalOrderButton.UseVisualStyleBackColor = true;
            this.totalOrderButton.Click += new System.EventHandler(this.totalOrderButton_Click);
            // 
            // totalOrders
            // 
            this.totalOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalOrders.Location = new System.Drawing.Point(53, 47);
            this.totalOrders.Name = "totalOrders";
            this.totalOrders.Size = new System.Drawing.Size(159, 30);
            this.totalOrders.TabIndex = 40;
            this.totalOrders.TextChanged += new System.EventHandler(this.totalOrders_TextChanged);
            // 
            // iconButton3
            // 
            this.iconButton3.BackColor = System.Drawing.Color.Transparent;
            this.iconButton3.FlatAppearance.BorderSize = 0;
            this.iconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton3.ForeColor = System.Drawing.Color.White;
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.BoxesAlt;
            this.iconButton3.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.IconSize = 30;
            this.iconButton3.Location = new System.Drawing.Point(9, 47);
            this.iconButton3.Margin = new System.Windows.Forms.Padding(4);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Size = new System.Drawing.Size(41, 39);
            this.iconButton3.TabIndex = 39;
            this.iconButton3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton3.UseVisualStyleBackColor = false;
            this.iconButton3.Click += new System.EventHandler(this.iconButton3_Click);
            // 
            // totalSalesClick
            // 
            this.totalSalesClick.Controls.Add(this.totalSalesButton);
            this.totalSalesClick.Controls.Add(this.totalSales);
            this.totalSalesClick.Controls.Add(this.iconButton2);
            this.totalSalesClick.Location = new System.Drawing.Point(-4, 22);
            this.totalSalesClick.Name = "totalSalesClick";
            this.totalSalesClick.Size = new System.Drawing.Size(258, 103);
            this.totalSalesClick.TabIndex = 1;
            this.totalSalesClick.Paint += new System.Windows.Forms.PaintEventHandler(this.totalSalesClick_Paint);
            // 
            // totalSalesButton
            // 
            this.totalSalesButton.FlatAppearance.BorderSize = 0;
            this.totalSalesButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.totalSalesButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.totalSalesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.totalSalesButton.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalSalesButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.totalSalesButton.Location = new System.Drawing.Point(18, 8);
            this.totalSalesButton.Name = "totalSalesButton";
            this.totalSalesButton.Size = new System.Drawing.Size(160, 33);
            this.totalSalesButton.TabIndex = 40;
            this.totalSalesButton.Text = "Total Sales";
            this.totalSalesButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.totalSalesButton.UseVisualStyleBackColor = true;
            this.totalSalesButton.Click += new System.EventHandler(this.totalSalesButton_Click);
            // 
            // totalSales
            // 
            this.totalSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalSales.Location = new System.Drawing.Point(59, 47);
            this.totalSales.Name = "totalSales";
            this.totalSales.Size = new System.Drawing.Size(159, 30);
            this.totalSales.TabIndex = 39;
            this.totalSales.TextChanged += new System.EventHandler(this.totalSales_TextChanged);
            // 
            // iconButton2
            // 
            this.iconButton2.BackColor = System.Drawing.Color.Transparent;
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.ForeColor = System.Drawing.Color.White;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.ChartSimple;
            this.iconButton2.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 30;
            this.iconButton2.Location = new System.Drawing.Point(18, 47);
            this.iconButton2.Margin = new System.Windows.Forms.Padding(4);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(41, 39);
            this.iconButton2.TabIndex = 38;
            this.iconButton2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton2.UseVisualStyleBackColor = false;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // transactionsData
            // 
            this.transactionsData.AllowUserToAddRows = false;
            this.transactionsData.AllowUserToDeleteRows = false;
            this.transactionsData.BackgroundColor = System.Drawing.Color.White;
            this.transactionsData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.transactionsData.GridColor = System.Drawing.Color.WhiteSmoke;
            this.transactionsData.Location = new System.Drawing.Point(8, 163);
            this.transactionsData.Margin = new System.Windows.Forms.Padding(4);
            this.transactionsData.Name = "transactionsData";
            this.transactionsData.ReadOnly = true;
            this.transactionsData.RowHeadersWidth = 51;
            this.transactionsData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.transactionsData.Size = new System.Drawing.Size(828, 320);
            this.transactionsData.TabIndex = 0;
            this.transactionsData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.transactions_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dashboardcenter);
            this.panel1.Controls.Add(this.homesidebar);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1089, 555);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1065, -143);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 36);
            this.label1.TabIndex = 23;
            this.label1.Text = "Members";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Transaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1084, 555);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Transaction";
            this.Text = "Form2";
            this.panel7.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.homesidebar.ResumeLayout(false);
            this.homelogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.dashboardcenter.ResumeLayout(false);
            this.dashboardcenter.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.totalSalesClick.ResumeLayout(false);
            this.totalSalesClick.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsData)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton minimize;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconButton maximize;
        private FontAwesome.Sharp.IconButton close;
        private FontAwesome.Sharp.IconButton iconButton4;
        private FontAwesome.Sharp.IconButton iconButton5;
        private FontAwesome.Sharp.IconButton iconButton6;
        private System.Windows.Forms.Panel homesidebar;
        private System.Windows.Forms.Button transactionsButton;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Button button5;
        private FontAwesome.Sharp.IconButton iconButton10;
        private System.Windows.Forms.Button AccountLisy;
        private System.Windows.Forms.Button button1;
        private FontAwesome.Sharp.IconButton about;
        private FontAwesome.Sharp.IconButton house;
        private System.Windows.Forms.Button logoutButton;
        private FontAwesome.Sharp.IconButton iconButton9;
        private System.Windows.Forms.Panel homelogo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel dashboardcenter;
        private FontAwesome.Sharp.IconButton browseButton;
        private System.Windows.Forms.TextBox filepath;
        private FontAwesome.Sharp.IconButton print;
        private System.Windows.Forms.Button printButton;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button stockonHandButton;
        private System.Windows.Forms.TextBox totalStockLeft;
        private FontAwesome.Sharp.IconButton iconButton7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button totalOrderButton;
        private System.Windows.Forms.TextBox totalOrders;
        private FontAwesome.Sharp.IconButton iconButton3;
        private System.Windows.Forms.Panel totalSalesClick;
        private System.Windows.Forms.Button totalSalesButton;
        private System.Windows.Forms.TextBox totalSales;
        private FontAwesome.Sharp.IconButton iconButton2;
        private System.Windows.Forms.DataGridView transactionsData;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}
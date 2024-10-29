namespace Project
{
    partial class Form1
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
            this.gb_User = new System.Windows.Forms.GroupBox();
            this.lbl_Register = new System.Windows.Forms.Label();
            this.dat_Register = new System.Windows.Forms.DateTimePicker();
            this.btn_DisplayUsers = new System.Windows.Forms.Button();
            this.btn_ClearUsers = new System.Windows.Forms.Button();
            this.btn_RemoveUser = new System.Windows.Forms.Button();
            this.lbl_Bank = new System.Windows.Forms.Label();
            this.lbl_Phone = new System.Windows.Forms.Label();
            this.lbl_Address = new System.Windows.Forms.Label();
            this.lbl_Email = new System.Windows.Forms.Label();
            this.lbl_UserName = new System.Windows.Forms.Label();
            this.lbl_UserID = new System.Windows.Forms.Label();
            this.txt_Phone = new System.Windows.Forms.TextBox();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.txt_UserName = new System.Windows.Forms.TextBox();
            this.txt_UserID = new System.Windows.Forms.TextBox();
            this.btn_AddUser = new System.Windows.Forms.Button();
            this.gb_Car = new System.Windows.Forms.GroupBox();
            this.lbl_Price = new System.Windows.Forms.Label();
            this.btn_DisplayCars = new System.Windows.Forms.Button();
            this.btn_ClearCars = new System.Windows.Forms.Button();
            this.btn_RemoveCar = new System.Windows.Forms.Button();
            this.lbl_Color = new System.Windows.Forms.Label();
            this.lbl_Mileage = new System.Windows.Forms.Label();
            this.lbl_Model = new System.Windows.Forms.Label();
            this.lbl_Brand = new System.Windows.Forms.Label();
            this.lbl_CarID = new System.Windows.Forms.Label();
            this.txt_Mileage = new System.Windows.Forms.TextBox();
            this.txt_Color = new System.Windows.Forms.TextBox();
            this.txt_Model = new System.Windows.Forms.TextBox();
            this.txt_Brand = new System.Windows.Forms.TextBox();
            this.txt_CarID = new System.Windows.Forms.TextBox();
            this.btn_AddCar = new System.Windows.Forms.Button();
            this.txt_Price = new System.Windows.Forms.TextBox();
            this.txt_Bank = new System.Windows.Forms.TextBox();
            this.lst_Users = new System.Windows.Forms.ListBox();
            this.lst_Cars = new System.Windows.Forms.ListBox();
            this.cob_CarAvailable = new System.Windows.Forms.ComboBox();
            this.lbl_CarAvalable = new System.Windows.Forms.Label();
            this.btn_RentCar = new System.Windows.Forms.Button();
            this.txt_Address = new System.Windows.Forms.TextBox();
            this.lbl_h_id = new System.Windows.Forms.Label();
            this.lbl_h_name = new System.Windows.Forms.Label();
            this.lbl_h_phone = new System.Windows.Forms.Label();
            this.lbl_h_bank = new System.Windows.Forms.Label();
            this.lbl_h_address = new System.Windows.Forms.Label();
            this.lbl_h_regist = new System.Windows.Forms.Label();
            this.lbl_h_email = new System.Windows.Forms.Label();
            this.lbl_h_available = new System.Windows.Forms.Label();
            this.lbl_h_color = new System.Windows.Forms.Label();
            this.lbl_h_price = new System.Windows.Forms.Label();
            this.lbl_h_mil = new System.Windows.Forms.Label();
            this.lbl_h_model = new System.Windows.Forms.Label();
            this.lbl_h_brand = new System.Windows.Forms.Label();
            this.lbl_id = new System.Windows.Forms.Label();
            this.gb_User.SuspendLayout();
            this.gb_Car.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_User
            // 
            this.gb_User.BackColor = System.Drawing.Color.Teal;
            this.gb_User.Controls.Add(this.lbl_h_email);
            this.gb_User.Controls.Add(this.lbl_h_regist);
            this.gb_User.Controls.Add(this.lbl_h_address);
            this.gb_User.Controls.Add(this.lbl_h_bank);
            this.gb_User.Controls.Add(this.lbl_h_phone);
            this.gb_User.Controls.Add(this.lbl_h_name);
            this.gb_User.Controls.Add(this.lbl_h_id);
            this.gb_User.Controls.Add(this.lst_Users);
            this.gb_User.Controls.Add(this.txt_Bank);
            this.gb_User.Controls.Add(this.lbl_Register);
            this.gb_User.Controls.Add(this.dat_Register);
            this.gb_User.Controls.Add(this.btn_DisplayUsers);
            this.gb_User.Controls.Add(this.btn_ClearUsers);
            this.gb_User.Controls.Add(this.btn_RemoveUser);
            this.gb_User.Controls.Add(this.lbl_Bank);
            this.gb_User.Controls.Add(this.lbl_Phone);
            this.gb_User.Controls.Add(this.lbl_Address);
            this.gb_User.Controls.Add(this.lbl_Email);
            this.gb_User.Controls.Add(this.lbl_UserName);
            this.gb_User.Controls.Add(this.lbl_UserID);
            this.gb_User.Controls.Add(this.txt_Address);
            this.gb_User.Controls.Add(this.txt_Phone);
            this.gb_User.Controls.Add(this.txt_Email);
            this.gb_User.Controls.Add(this.txt_UserName);
            this.gb_User.Controls.Add(this.txt_UserID);
            this.gb_User.Controls.Add(this.btn_AddUser);
            this.gb_User.Dock = System.Windows.Forms.DockStyle.Top;
            this.gb_User.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gb_User.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_User.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.gb_User.Location = new System.Drawing.Point(1, 1);
            this.gb_User.Name = "gb_User";
            this.gb_User.Size = new System.Drawing.Size(1337, 323);
            this.gb_User.TabIndex = 38;
            this.gb_User.TabStop = false;
            this.gb_User.Text = "User";
            // 
            // lbl_Register
            // 
            this.lbl_Register.AutoSize = true;
            this.lbl_Register.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Register.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.lbl_Register.Location = new System.Drawing.Point(255, 205);
            this.lbl_Register.Name = "lbl_Register";
            this.lbl_Register.Size = new System.Drawing.Size(129, 19);
            this.lbl_Register.TabIndex = 37;
            this.lbl_Register.Text = "Registration Date";
            // 
            // dat_Register
            // 
            this.dat_Register.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dat_Register.Location = new System.Drawing.Point(240, 237);
            this.dat_Register.Name = "dat_Register";
            this.dat_Register.Size = new System.Drawing.Size(161, 25);
            this.dat_Register.TabIndex = 36;
            this.dat_Register.Value = new System.DateTime(2023, 7, 4, 0, 0, 0, 0);
            // 
            // btn_DisplayUsers
            // 
            this.btn_DisplayUsers.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_DisplayUsers.Location = new System.Drawing.Point(427, 50);
            this.btn_DisplayUsers.Name = "btn_DisplayUsers";
            this.btn_DisplayUsers.Size = new System.Drawing.Size(107, 38);
            this.btn_DisplayUsers.TabIndex = 35;
            this.btn_DisplayUsers.Text = "Display Users";
            this.btn_DisplayUsers.UseVisualStyleBackColor = true;
            this.btn_DisplayUsers.Click += new System.EventHandler(this.btn_DisplayUsers_Click);
            // 
            // btn_ClearUsers
            // 
            this.btn_ClearUsers.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_ClearUsers.Location = new System.Drawing.Point(287, 50);
            this.btn_ClearUsers.Name = "btn_ClearUsers";
            this.btn_ClearUsers.Size = new System.Drawing.Size(107, 38);
            this.btn_ClearUsers.TabIndex = 34;
            this.btn_ClearUsers.Text = "Clear Users";
            this.btn_ClearUsers.UseVisualStyleBackColor = true;
            this.btn_ClearUsers.Click += new System.EventHandler(this.btn_ClearUsers_Click);
            // 
            // btn_RemoveUser
            // 
            this.btn_RemoveUser.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_RemoveUser.Location = new System.Drawing.Point(165, 50);
            this.btn_RemoveUser.Name = "btn_RemoveUser";
            this.btn_RemoveUser.Size = new System.Drawing.Size(107, 38);
            this.btn_RemoveUser.TabIndex = 33;
            this.btn_RemoveUser.Text = "Remove User";
            this.btn_RemoveUser.UseVisualStyleBackColor = true;
            this.btn_RemoveUser.Click += new System.EventHandler(this.btn_RemoveUser_Click);
            // 
            // lbl_Bank
            // 
            this.lbl_Bank.AutoSize = true;
            this.lbl_Bank.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Bank.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.lbl_Bank.Location = new System.Drawing.Point(452, 113);
            this.lbl_Bank.Name = "lbl_Bank";
            this.lbl_Bank.Size = new System.Drawing.Size(103, 19);
            this.lbl_Bank.TabIndex = 32;
            this.lbl_Bank.Text = "Bank Account";
            // 
            // lbl_Phone
            // 
            this.lbl_Phone.AutoSize = true;
            this.lbl_Phone.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Phone.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.lbl_Phone.Location = new System.Drawing.Point(305, 113);
            this.lbl_Phone.Name = "lbl_Phone";
            this.lbl_Phone.Size = new System.Drawing.Size(52, 19);
            this.lbl_Phone.TabIndex = 31;
            this.lbl_Phone.Text = "Phone";
            // 
            // lbl_Address
            // 
            this.lbl_Address.AutoSize = true;
            this.lbl_Address.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Address.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.lbl_Address.Location = new System.Drawing.Point(51, 205);
            this.lbl_Address.Name = "lbl_Address";
            this.lbl_Address.Size = new System.Drawing.Size(64, 19);
            this.lbl_Address.TabIndex = 30;
            this.lbl_Address.Text = "Address";
            // 
            // lbl_Email
            // 
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Email.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.lbl_Email.Location = new System.Drawing.Point(455, 205);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(49, 19);
            this.lbl_Email.TabIndex = 29;
            this.lbl_Email.Text = "Email";
            // 
            // lbl_UserName
            // 
            this.lbl_UserName.AutoSize = true;
            this.lbl_UserName.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UserName.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.lbl_UserName.Location = new System.Drawing.Point(184, 113);
            this.lbl_UserName.Name = "lbl_UserName";
            this.lbl_UserName.Size = new System.Drawing.Size(49, 19);
            this.lbl_UserName.TabIndex = 28;
            this.lbl_UserName.Text = "Name";
            // 
            // lbl_UserID
            // 
            this.lbl_UserID.AutoSize = true;
            this.lbl_UserID.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UserID.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.lbl_UserID.Location = new System.Drawing.Point(51, 113);
            this.lbl_UserID.Name = "lbl_UserID";
            this.lbl_UserID.Size = new System.Drawing.Size(63, 19);
            this.lbl_UserID.TabIndex = 27;
            this.lbl_UserID.Text = "User ID";
            // 
            // txt_Phone
            // 
            this.txt_Phone.Location = new System.Drawing.Point(283, 142);
            this.txt_Phone.Name = "txt_Phone";
            this.txt_Phone.Size = new System.Drawing.Size(100, 25);
            this.txt_Phone.TabIndex = 22;
            this.txt_Phone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(415, 237);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(189, 25);
            this.txt_Email.TabIndex = 25;
            this.txt_Email.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_UserName
            // 
            this.txt_UserName.Location = new System.Drawing.Point(162, 144);
            this.txt_UserName.Name = "txt_UserName";
            this.txt_UserName.Size = new System.Drawing.Size(100, 25);
            this.txt_UserName.TabIndex = 21;
            this.txt_UserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_UserID
            // 
            this.txt_UserID.Location = new System.Drawing.Point(33, 143);
            this.txt_UserID.Name = "txt_UserID";
            this.txt_UserID.Size = new System.Drawing.Size(100, 25);
            this.txt_UserID.TabIndex = 20;
            this.txt_UserID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_AddUser
            // 
            this.btn_AddUser.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_AddUser.Location = new System.Drawing.Point(37, 50);
            this.btn_AddUser.Name = "btn_AddUser";
            this.btn_AddUser.Size = new System.Drawing.Size(107, 38);
            this.btn_AddUser.TabIndex = 19;
            this.btn_AddUser.Text = "Add User";
            this.btn_AddUser.UseVisualStyleBackColor = true;
            this.btn_AddUser.Click += new System.EventHandler(this.btn_AddUser_Click);
            // 
            // gb_Car
            // 
            this.gb_Car.BackColor = System.Drawing.Color.Honeydew;
            this.gb_Car.Controls.Add(this.lbl_h_available);
            this.gb_Car.Controls.Add(this.lbl_h_color);
            this.gb_Car.Controls.Add(this.lbl_h_price);
            this.gb_Car.Controls.Add(this.lbl_h_mil);
            this.gb_Car.Controls.Add(this.lbl_h_model);
            this.gb_Car.Controls.Add(this.lbl_h_brand);
            this.gb_Car.Controls.Add(this.lbl_id);
            this.gb_Car.Controls.Add(this.btn_RentCar);
            this.gb_Car.Controls.Add(this.lbl_CarAvalable);
            this.gb_Car.Controls.Add(this.cob_CarAvailable);
            this.gb_Car.Controls.Add(this.lst_Cars);
            this.gb_Car.Controls.Add(this.txt_Price);
            this.gb_Car.Controls.Add(this.lbl_Price);
            this.gb_Car.Controls.Add(this.btn_DisplayCars);
            this.gb_Car.Controls.Add(this.btn_ClearCars);
            this.gb_Car.Controls.Add(this.btn_RemoveCar);
            this.gb_Car.Controls.Add(this.lbl_Color);
            this.gb_Car.Controls.Add(this.lbl_Mileage);
            this.gb_Car.Controls.Add(this.lbl_Model);
            this.gb_Car.Controls.Add(this.lbl_Brand);
            this.gb_Car.Controls.Add(this.lbl_CarID);
            this.gb_Car.Controls.Add(this.txt_Mileage);
            this.gb_Car.Controls.Add(this.txt_Color);
            this.gb_Car.Controls.Add(this.txt_Model);
            this.gb_Car.Controls.Add(this.txt_Brand);
            this.gb_Car.Controls.Add(this.txt_CarID);
            this.gb_Car.Controls.Add(this.btn_AddCar);
            this.gb_Car.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gb_Car.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gb_Car.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Car.Location = new System.Drawing.Point(1, 330);
            this.gb_Car.Name = "gb_Car";
            this.gb_Car.Size = new System.Drawing.Size(1337, 383);
            this.gb_Car.TabIndex = 38;
            this.gb_Car.TabStop = false;
            this.gb_Car.Text = "Car";
            // 
            // lbl_Price
            // 
            this.lbl_Price.AutoSize = true;
            this.lbl_Price.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Price.Location = new System.Drawing.Point(40, 206);
            this.lbl_Price.Name = "lbl_Price";
            this.lbl_Price.Size = new System.Drawing.Size(97, 19);
            this.lbl_Price.TabIndex = 56;
            this.lbl_Price.Text = "PricePerDay";
            // 
            // btn_DisplayCars
            // 
            this.btn_DisplayCars.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_DisplayCars.Location = new System.Drawing.Point(427, 50);
            this.btn_DisplayCars.Name = "btn_DisplayCars";
            this.btn_DisplayCars.Size = new System.Drawing.Size(107, 38);
            this.btn_DisplayCars.TabIndex = 54;
            this.btn_DisplayCars.Text = "Display Cars";
            this.btn_DisplayCars.UseVisualStyleBackColor = true;
            this.btn_DisplayCars.Click += new System.EventHandler(this.btn_DisplayCars_Click);
            // 
            // btn_ClearCars
            // 
            this.btn_ClearCars.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_ClearCars.Location = new System.Drawing.Point(287, 50);
            this.btn_ClearCars.Name = "btn_ClearCars";
            this.btn_ClearCars.Size = new System.Drawing.Size(107, 38);
            this.btn_ClearCars.TabIndex = 53;
            this.btn_ClearCars.Text = "Clear Cars";
            this.btn_ClearCars.UseVisualStyleBackColor = true;
            this.btn_ClearCars.Click += new System.EventHandler(this.btn_ClearCars_Click);
            // 
            // btn_RemoveCar
            // 
            this.btn_RemoveCar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_RemoveCar.Location = new System.Drawing.Point(165, 50);
            this.btn_RemoveCar.Name = "btn_RemoveCar";
            this.btn_RemoveCar.Size = new System.Drawing.Size(107, 38);
            this.btn_RemoveCar.TabIndex = 52;
            this.btn_RemoveCar.Text = "Remove Car";
            this.btn_RemoveCar.UseVisualStyleBackColor = true;
            this.btn_RemoveCar.Click += new System.EventHandler(this.btn_RemoveCar_Click);
            // 
            // lbl_Color
            // 
            this.lbl_Color.AutoSize = true;
            this.lbl_Color.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Color.Location = new System.Drawing.Point(184, 206);
            this.lbl_Color.Name = "lbl_Color";
            this.lbl_Color.Size = new System.Drawing.Size(49, 19);
            this.lbl_Color.TabIndex = 50;
            this.lbl_Color.Text = "Color";
            // 
            // lbl_Mileage
            // 
            this.lbl_Mileage.AutoSize = true;
            this.lbl_Mileage.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Mileage.Location = new System.Drawing.Point(469, 112);
            this.lbl_Mileage.Name = "lbl_Mileage";
            this.lbl_Mileage.Size = new System.Drawing.Size(65, 19);
            this.lbl_Mileage.TabIndex = 49;
            this.lbl_Mileage.Text = "Mileage";
            // 
            // lbl_Model
            // 
            this.lbl_Model.AutoSize = true;
            this.lbl_Model.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Model.Location = new System.Drawing.Point(330, 112);
            this.lbl_Model.Name = "lbl_Model";
            this.lbl_Model.Size = new System.Drawing.Size(54, 19);
            this.lbl_Model.TabIndex = 48;
            this.lbl_Model.Text = "Model";
            // 
            // lbl_Brand
            // 
            this.lbl_Brand.AutoSize = true;
            this.lbl_Brand.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Brand.Location = new System.Drawing.Point(184, 112);
            this.lbl_Brand.Name = "lbl_Brand";
            this.lbl_Brand.Size = new System.Drawing.Size(49, 19);
            this.lbl_Brand.TabIndex = 47;
            this.lbl_Brand.Text = "Brand";
            // 
            // lbl_CarID
            // 
            this.lbl_CarID.AutoSize = true;
            this.lbl_CarID.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CarID.Location = new System.Drawing.Point(54, 112);
            this.lbl_CarID.Name = "lbl_CarID";
            this.lbl_CarID.Size = new System.Drawing.Size(54, 19);
            this.lbl_CarID.TabIndex = 46;
            this.lbl_CarID.Text = "Car ID";
            // 
            // txt_Mileage
            // 
            this.txt_Mileage.Location = new System.Drawing.Point(456, 143);
            this.txt_Mileage.Name = "txt_Mileage";
            this.txt_Mileage.Size = new System.Drawing.Size(100, 25);
            this.txt_Mileage.TabIndex = 42;
            this.txt_Mileage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_Color
            // 
            this.txt_Color.Location = new System.Drawing.Point(165, 242);
            this.txt_Color.Name = "txt_Color";
            this.txt_Color.Size = new System.Drawing.Size(100, 25);
            this.txt_Color.TabIndex = 44;
            this.txt_Color.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_Model
            // 
            this.txt_Model.Location = new System.Drawing.Point(309, 143);
            this.txt_Model.Name = "txt_Model";
            this.txt_Model.Size = new System.Drawing.Size(100, 25);
            this.txt_Model.TabIndex = 41;
            this.txt_Model.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_Brand
            // 
            this.txt_Brand.Location = new System.Drawing.Point(162, 143);
            this.txt_Brand.Name = "txt_Brand";
            this.txt_Brand.Size = new System.Drawing.Size(100, 25);
            this.txt_Brand.TabIndex = 40;
            this.txt_Brand.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_CarID
            // 
            this.txt_CarID.Location = new System.Drawing.Point(37, 143);
            this.txt_CarID.Name = "txt_CarID";
            this.txt_CarID.Size = new System.Drawing.Size(100, 25);
            this.txt_CarID.TabIndex = 39;
            this.txt_CarID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_AddCar
            // 
            this.btn_AddCar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_AddCar.Location = new System.Drawing.Point(37, 50);
            this.btn_AddCar.Name = "btn_AddCar";
            this.btn_AddCar.Size = new System.Drawing.Size(107, 38);
            this.btn_AddCar.TabIndex = 38;
            this.btn_AddCar.Text = "Add Car";
            this.btn_AddCar.UseVisualStyleBackColor = true;
            this.btn_AddCar.Click += new System.EventHandler(this.btn_AddCar_Click);
            // 
            // txt_Price
            // 
            this.txt_Price.Location = new System.Drawing.Point(37, 242);
            this.txt_Price.Name = "txt_Price";
            this.txt_Price.Size = new System.Drawing.Size(100, 25);
            this.txt_Price.TabIndex = 43;
            this.txt_Price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_Bank
            // 
            this.txt_Bank.Location = new System.Drawing.Point(415, 145);
            this.txt_Bank.Name = "txt_Bank";
            this.txt_Bank.Size = new System.Drawing.Size(189, 25);
            this.txt_Bank.TabIndex = 23;
            this.txt_Bank.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lst_Users
            // 
            this.lst_Users.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lst_Users.FormattingEnabled = true;
            this.lst_Users.ItemHeight = 19;
            this.lst_Users.Location = new System.Drawing.Point(620, 51);
            this.lst_Users.Name = "lst_Users";
            this.lst_Users.Size = new System.Drawing.Size(714, 251);
            this.lst_Users.TabIndex = 39;
            // 
            // lst_Cars
            // 
            this.lst_Cars.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lst_Cars.FormattingEnabled = true;
            this.lst_Cars.ItemHeight = 20;
            this.lst_Cars.Location = new System.Drawing.Point(620, 50);
            this.lst_Cars.Name = "lst_Cars";
            this.lst_Cars.Size = new System.Drawing.Size(528, 224);
            this.lst_Cars.TabIndex = 58;
            // 
            // cob_CarAvailable
            // 
            this.cob_CarAvailable.FormattingEnabled = true;
            this.cob_CarAvailable.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cob_CarAvailable.Location = new System.Drawing.Point(309, 242);
            this.cob_CarAvailable.Name = "cob_CarAvailable";
            this.cob_CarAvailable.Size = new System.Drawing.Size(100, 25);
            this.cob_CarAvailable.TabIndex = 45;
            // 
            // lbl_CarAvalable
            // 
            this.lbl_CarAvalable.AutoSize = true;
            this.lbl_CarAvalable.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CarAvalable.Location = new System.Drawing.Point(330, 206);
            this.lbl_CarAvalable.Name = "lbl_CarAvalable";
            this.lbl_CarAvalable.Size = new System.Drawing.Size(71, 19);
            this.lbl_CarAvalable.TabIndex = 60;
            this.lbl_CarAvalable.Text = "Available";
            // 
            // btn_RentCar
            // 
            this.btn_RentCar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_RentCar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RentCar.ForeColor = System.Drawing.Color.DarkRed;
            this.btn_RentCar.Location = new System.Drawing.Point(3, 332);
            this.btn_RentCar.Name = "btn_RentCar";
            this.btn_RentCar.Size = new System.Drawing.Size(1331, 48);
            this.btn_RentCar.TabIndex = 61;
            this.btn_RentCar.Text = "Rent Car";
            this.btn_RentCar.UseVisualStyleBackColor = true;
            this.btn_RentCar.Click += new System.EventHandler(this.btn_RentCar_Click);
            // 
            // txt_Address
            // 
            this.txt_Address.Location = new System.Drawing.Point(33, 237);
            this.txt_Address.Name = "txt_Address";
            this.txt_Address.Size = new System.Drawing.Size(181, 25);
            this.txt_Address.TabIndex = 24;
            this.txt_Address.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_h_id
            // 
            this.lbl_h_id.AutoSize = true;
            this.lbl_h_id.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_h_id.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.lbl_h_id.Location = new System.Drawing.Point(627, 21);
            this.lbl_h_id.Name = "lbl_h_id";
            this.lbl_h_id.Size = new System.Drawing.Size(26, 19);
            this.lbl_h_id.TabIndex = 40;
            this.lbl_h_id.Text = "ID";
            // 
            // lbl_h_name
            // 
            this.lbl_h_name.AutoSize = true;
            this.lbl_h_name.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_h_name.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.lbl_h_name.Location = new System.Drawing.Point(679, 21);
            this.lbl_h_name.Name = "lbl_h_name";
            this.lbl_h_name.Size = new System.Drawing.Size(49, 19);
            this.lbl_h_name.TabIndex = 41;
            this.lbl_h_name.Text = "Name";
            // 
            // lbl_h_phone
            // 
            this.lbl_h_phone.AutoSize = true;
            this.lbl_h_phone.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_h_phone.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.lbl_h_phone.Location = new System.Drawing.Point(753, 21);
            this.lbl_h_phone.Name = "lbl_h_phone";
            this.lbl_h_phone.Size = new System.Drawing.Size(52, 19);
            this.lbl_h_phone.TabIndex = 42;
            this.lbl_h_phone.Text = "Phone";
            // 
            // lbl_h_bank
            // 
            this.lbl_h_bank.AutoSize = true;
            this.lbl_h_bank.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_h_bank.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.lbl_h_bank.Location = new System.Drawing.Point(834, 21);
            this.lbl_h_bank.Name = "lbl_h_bank";
            this.lbl_h_bank.Size = new System.Drawing.Size(43, 19);
            this.lbl_h_bank.TabIndex = 43;
            this.lbl_h_bank.Text = "Bank";
            // 
            // lbl_h_address
            // 
            this.lbl_h_address.AutoSize = true;
            this.lbl_h_address.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_h_address.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.lbl_h_address.Location = new System.Drawing.Point(937, 21);
            this.lbl_h_address.Name = "lbl_h_address";
            this.lbl_h_address.Size = new System.Drawing.Size(64, 19);
            this.lbl_h_address.TabIndex = 44;
            this.lbl_h_address.Text = "Address";
            // 
            // lbl_h_regist
            // 
            this.lbl_h_regist.AutoSize = true;
            this.lbl_h_regist.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_h_regist.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.lbl_h_regist.Location = new System.Drawing.Point(1075, 21);
            this.lbl_h_regist.Name = "lbl_h_regist";
            this.lbl_h_regist.Size = new System.Drawing.Size(93, 19);
            this.lbl_h_regist.TabIndex = 45;
            this.lbl_h_regist.Text = "Registration";
            // 
            // lbl_h_email
            // 
            this.lbl_h_email.AutoSize = true;
            this.lbl_h_email.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_h_email.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.lbl_h_email.Location = new System.Drawing.Point(1232, 21);
            this.lbl_h_email.Name = "lbl_h_email";
            this.lbl_h_email.Size = new System.Drawing.Size(49, 19);
            this.lbl_h_email.TabIndex = 46;
            this.lbl_h_email.Text = "Email";
            // 
            // lbl_h_available
            // 
            this.lbl_h_available.AutoSize = true;
            this.lbl_h_available.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_h_available.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_h_available.Location = new System.Drawing.Point(1051, 21);
            this.lbl_h_available.Name = "lbl_h_available";
            this.lbl_h_available.Size = new System.Drawing.Size(79, 19);
            this.lbl_h_available.TabIndex = 68;
            this.lbl_h_available.Text = "Avalibility";
            // 
            // lbl_h_color
            // 
            this.lbl_h_color.AutoSize = true;
            this.lbl_h_color.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_h_color.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_h_color.Location = new System.Drawing.Point(996, 21);
            this.lbl_h_color.Name = "lbl_h_color";
            this.lbl_h_color.Size = new System.Drawing.Size(49, 19);
            this.lbl_h_color.TabIndex = 67;
            this.lbl_h_color.Text = "Color";
            // 
            // lbl_h_price
            // 
            this.lbl_h_price.AutoSize = true;
            this.lbl_h_price.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_h_price.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_h_price.Location = new System.Drawing.Point(893, 21);
            this.lbl_h_price.Name = "lbl_h_price";
            this.lbl_h_price.Size = new System.Drawing.Size(97, 19);
            this.lbl_h_price.TabIndex = 66;
            this.lbl_h_price.Text = "PricePerDay";
            // 
            // lbl_h_mil
            // 
            this.lbl_h_mil.AutoSize = true;
            this.lbl_h_mil.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_h_mil.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_h_mil.Location = new System.Drawing.Point(822, 21);
            this.lbl_h_mil.Name = "lbl_h_mil";
            this.lbl_h_mil.Size = new System.Drawing.Size(65, 19);
            this.lbl_h_mil.TabIndex = 65;
            this.lbl_h_mil.Text = "Mileage";
            // 
            // lbl_h_model
            // 
            this.lbl_h_model.AutoSize = true;
            this.lbl_h_model.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_h_model.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_h_model.Location = new System.Drawing.Point(751, 21);
            this.lbl_h_model.Name = "lbl_h_model";
            this.lbl_h_model.Size = new System.Drawing.Size(54, 19);
            this.lbl_h_model.TabIndex = 64;
            this.lbl_h_model.Text = "Model";
            // 
            // lbl_h_brand
            // 
            this.lbl_h_brand.AutoSize = true;
            this.lbl_h_brand.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_h_brand.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_h_brand.Location = new System.Drawing.Point(679, 21);
            this.lbl_h_brand.Name = "lbl_h_brand";
            this.lbl_h_brand.Size = new System.Drawing.Size(49, 19);
            this.lbl_h_brand.TabIndex = 63;
            this.lbl_h_brand.Text = "Brand";
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_id.Location = new System.Drawing.Point(627, 21);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(26, 19);
            this.lbl_id.TabIndex = 62;
            this.lbl_id.Text = "ID";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1339, 714);
            this.Controls.Add(this.gb_Car);
            this.Controls.Add(this.gb_User);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1: Users and Cars managment";
            this.gb_User.ResumeLayout(false);
            this.gb_User.PerformLayout();
            this.gb_Car.ResumeLayout(false);
            this.gb_Car.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gb_User;
        private System.Windows.Forms.Label lbl_Register;
        private System.Windows.Forms.DateTimePicker dat_Register;
        private System.Windows.Forms.Button btn_DisplayUsers;
        private System.Windows.Forms.Button btn_ClearUsers;
        private System.Windows.Forms.Button btn_RemoveUser;
        private System.Windows.Forms.Label lbl_Bank;
        private System.Windows.Forms.Label lbl_Phone;
        private System.Windows.Forms.Label lbl_Address;
        private System.Windows.Forms.Label lbl_Email;
        private System.Windows.Forms.Label lbl_UserName;
        private System.Windows.Forms.Label lbl_UserID;
        private System.Windows.Forms.TextBox txt_Phone;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.TextBox txt_UserName;
        private System.Windows.Forms.TextBox txt_UserID;
        private System.Windows.Forms.Button btn_AddUser;
        private System.Windows.Forms.GroupBox gb_Car;
        private System.Windows.Forms.Label lbl_Price;
        private System.Windows.Forms.Button btn_DisplayCars;
        private System.Windows.Forms.Button btn_ClearCars;
        private System.Windows.Forms.Button btn_RemoveCar;
        private System.Windows.Forms.Label lbl_Color;
        private System.Windows.Forms.Label lbl_Mileage;
        private System.Windows.Forms.Label lbl_Model;
        private System.Windows.Forms.Label lbl_Brand;
        private System.Windows.Forms.Label lbl_CarID;
        private System.Windows.Forms.TextBox txt_Mileage;
        private System.Windows.Forms.TextBox txt_Color;
        private System.Windows.Forms.TextBox txt_Model;
        private System.Windows.Forms.TextBox txt_Brand;
        private System.Windows.Forms.TextBox txt_CarID;
        private System.Windows.Forms.Button btn_AddCar;
        private System.Windows.Forms.TextBox txt_Price;
        private System.Windows.Forms.TextBox txt_Bank;
        private System.Windows.Forms.ListBox lst_Users;
        private System.Windows.Forms.ListBox lst_Cars;
        private System.Windows.Forms.ComboBox cob_CarAvailable;
        private System.Windows.Forms.Label lbl_CarAvalable;
        private System.Windows.Forms.Button btn_RentCar;
        private System.Windows.Forms.TextBox txt_Address;
        private System.Windows.Forms.Label lbl_h_phone;
        private System.Windows.Forms.Label lbl_h_name;
        private System.Windows.Forms.Label lbl_h_id;
        private System.Windows.Forms.Label lbl_h_bank;
        private System.Windows.Forms.Label lbl_h_email;
        private System.Windows.Forms.Label lbl_h_regist;
        private System.Windows.Forms.Label lbl_h_address;
        private System.Windows.Forms.Label lbl_h_available;
        private System.Windows.Forms.Label lbl_h_color;
        private System.Windows.Forms.Label lbl_h_price;
        private System.Windows.Forms.Label lbl_h_mil;
        private System.Windows.Forms.Label lbl_h_model;
        private System.Windows.Forms.Label lbl_h_brand;
        private System.Windows.Forms.Label lbl_id;
    }
}


namespace Project
{
    partial class Form2
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
            this.lbl_UserID = new System.Windows.Forms.Label();
            this.chb_User = new System.Windows.Forms.CheckedListBox();
            this.lst_BorrowedCars = new System.Windows.Forms.ListBox();
            this.btn_Assigned = new System.Windows.Forms.Button();
            this.btn_UnAssigned = new System.Windows.Forms.Button();
            this.gb_Car = new System.Windows.Forms.GroupBox();
            this.lbl_Brand = new System.Windows.Forms.Label();
            this.txt_Brand = new System.Windows.Forms.TextBox();
            this.lbl_CarAvalable = new System.Windows.Forms.Label();
            this.cob_CarAvailable = new System.Windows.Forms.ComboBox();
            this.lbl_Model = new System.Windows.Forms.Label();
            this.txt_Model = new System.Windows.Forms.TextBox();
            this.lbl_CarID = new System.Windows.Forms.Label();
            this.cob_CarID = new System.Windows.Forms.ComboBox();
            this.lbl_Borrowed = new System.Windows.Forms.Label();
            this.gb_Car.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_UserID
            // 
            this.lbl_UserID.AutoSize = true;
            this.lbl_UserID.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UserID.Location = new System.Drawing.Point(218, 199);
            this.lbl_UserID.Name = "lbl_UserID";
            this.lbl_UserID.Size = new System.Drawing.Size(127, 19);
            this.lbl_UserID.TabIndex = 3;
            this.lbl_UserID.Text = "User Information";
            // 
            // chb_User
            // 
            this.chb_User.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chb_User.FormattingEnabled = true;
            this.chb_User.Location = new System.Drawing.Point(82, 235);
            this.chb_User.Name = "chb_User";
            this.chb_User.Size = new System.Drawing.Size(437, 180);
            this.chb_User.TabIndex = 65;
            this.chb_User.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.chb_User_ItemCheck);
            // 
            // lst_BorrowedCars
            // 
            this.lst_BorrowedCars.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lst_BorrowedCars.FormattingEnabled = true;
            this.lst_BorrowedCars.ItemHeight = 19;
            this.lst_BorrowedCars.Location = new System.Drawing.Point(560, 235);
            this.lst_BorrowedCars.Name = "lst_BorrowedCars";
            this.lst_BorrowedCars.Size = new System.Drawing.Size(94, 175);
            this.lst_BorrowedCars.TabIndex = 66;
            // 
            // btn_Assigned
            // 
            this.btn_Assigned.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Assigned.Location = new System.Drawing.Point(134, 117);
            this.btn_Assigned.Name = "btn_Assigned";
            this.btn_Assigned.Size = new System.Drawing.Size(131, 42);
            this.btn_Assigned.TabIndex = 67;
            this.btn_Assigned.Text = "Assigned Car";
            this.btn_Assigned.UseVisualStyleBackColor = true;
            this.btn_Assigned.Click += new System.EventHandler(this.btn_Assigned_Click);
            // 
            // btn_UnAssigned
            // 
            this.btn_UnAssigned.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_UnAssigned.Location = new System.Drawing.Point(307, 117);
            this.btn_UnAssigned.Name = "btn_UnAssigned";
            this.btn_UnAssigned.Size = new System.Drawing.Size(131, 42);
            this.btn_UnAssigned.TabIndex = 68;
            this.btn_UnAssigned.Text = "UnAssigned Car";
            this.btn_UnAssigned.UseVisualStyleBackColor = true;
            this.btn_UnAssigned.Click += new System.EventHandler(this.btn_UnAssigned_Click);
            // 
            // gb_Car
            // 
            this.gb_Car.Controls.Add(this.lbl_Brand);
            this.gb_Car.Controls.Add(this.txt_Brand);
            this.gb_Car.Controls.Add(this.lbl_CarAvalable);
            this.gb_Car.Controls.Add(this.cob_CarAvailable);
            this.gb_Car.Controls.Add(this.lbl_Model);
            this.gb_Car.Controls.Add(this.txt_Model);
            this.gb_Car.Controls.Add(this.lbl_CarID);
            this.gb_Car.Controls.Add(this.cob_CarID);
            this.gb_Car.Dock = System.Windows.Forms.DockStyle.Top;
            this.gb_Car.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Car.ForeColor = System.Drawing.Color.Maroon;
            this.gb_Car.Location = new System.Drawing.Point(1, 1);
            this.gb_Car.Name = "gb_Car";
            this.gb_Car.Size = new System.Drawing.Size(798, 101);
            this.gb_Car.TabIndex = 69;
            this.gb_Car.TabStop = false;
            this.gb_Car.Text = "Car Information";
            // 
            // lbl_Brand
            // 
            this.lbl_Brand.AutoSize = true;
            this.lbl_Brand.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Brand.Location = new System.Drawing.Point(439, 24);
            this.lbl_Brand.Name = "lbl_Brand";
            this.lbl_Brand.Size = new System.Drawing.Size(49, 19);
            this.lbl_Brand.TabIndex = 72;
            this.lbl_Brand.Text = "Brand";
            // 
            // txt_Brand
            // 
            this.txt_Brand.Location = new System.Drawing.Point(418, 55);
            this.txt_Brand.Name = "txt_Brand";
            this.txt_Brand.ReadOnly = true;
            this.txt_Brand.Size = new System.Drawing.Size(100, 27);
            this.txt_Brand.TabIndex = 71;
            this.txt_Brand.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_CarAvalable
            // 
            this.lbl_CarAvalable.AutoSize = true;
            this.lbl_CarAvalable.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CarAvalable.Location = new System.Drawing.Point(594, 24);
            this.lbl_CarAvalable.Name = "lbl_CarAvalable";
            this.lbl_CarAvalable.Size = new System.Drawing.Size(71, 19);
            this.lbl_CarAvalable.TabIndex = 70;
            this.lbl_CarAvalable.Text = "Available";
            // 
            // cob_CarAvailable
            // 
            this.cob_CarAvailable.FormattingEnabled = true;
            this.cob_CarAvailable.Items.AddRange(new object[] {
            "True",
            "False"});
            this.cob_CarAvailable.Location = new System.Drawing.Point(579, 55);
            this.cob_CarAvailable.Name = "cob_CarAvailable";
            this.cob_CarAvailable.Size = new System.Drawing.Size(100, 27);
            this.cob_CarAvailable.TabIndex = 69;
            // 
            // lbl_Model
            // 
            this.lbl_Model.AutoSize = true;
            this.lbl_Model.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Model.Location = new System.Drawing.Point(302, 25);
            this.lbl_Model.Name = "lbl_Model";
            this.lbl_Model.Size = new System.Drawing.Size(54, 19);
            this.lbl_Model.TabIndex = 68;
            this.lbl_Model.Text = "Model";
            // 
            // txt_Model
            // 
            this.txt_Model.Location = new System.Drawing.Point(281, 56);
            this.txt_Model.Name = "txt_Model";
            this.txt_Model.ReadOnly = true;
            this.txt_Model.Size = new System.Drawing.Size(100, 27);
            this.txt_Model.TabIndex = 67;
            this.txt_Model.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_CarID
            // 
            this.lbl_CarID.AutoSize = true;
            this.lbl_CarID.Location = new System.Drawing.Point(129, 27);
            this.lbl_CarID.Name = "lbl_CarID";
            this.lbl_CarID.Size = new System.Drawing.Size(54, 19);
            this.lbl_CarID.TabIndex = 66;
            this.lbl_CarID.Text = "Car ID";
            // 
            // cob_CarID
            // 
            this.cob_CarID.FormattingEnabled = true;
            this.cob_CarID.Location = new System.Drawing.Point(101, 55);
            this.cob_CarID.Name = "cob_CarID";
            this.cob_CarID.Size = new System.Drawing.Size(121, 27);
            this.cob_CarID.TabIndex = 65;
            this.cob_CarID.SelectedIndexChanged += new System.EventHandler(this.cob_CarID_SelectedIndexChanged);
            // 
            // lbl_Borrowed
            // 
            this.lbl_Borrowed.AutoSize = true;
            this.lbl_Borrowed.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Borrowed.Location = new System.Drawing.Point(556, 199);
            this.lbl_Borrowed.Name = "lbl_Borrowed";
            this.lbl_Borrowed.Size = new System.Drawing.Size(122, 19);
            this.lbl_Borrowed.TabIndex = 70;
            this.lbl_Borrowed.Text = "Borrowed CarID";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_Borrowed);
            this.Controls.Add(this.gb_Car);
            this.Controls.Add(this.btn_UnAssigned);
            this.Controls.Add(this.btn_Assigned);
            this.Controls.Add(this.lst_BorrowedCars);
            this.Controls.Add(this.chb_User);
            this.Controls.Add(this.lbl_UserID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form2";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2 : Borrowed";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.Shown += new System.EventHandler(this.Form2_Shown);
            this.gb_Car.ResumeLayout(false);
            this.gb_Car.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_UserID;
        private System.Windows.Forms.CheckedListBox chb_User;
        private System.Windows.Forms.ListBox lst_BorrowedCars;
        private System.Windows.Forms.Button btn_Assigned;
        private System.Windows.Forms.Button btn_UnAssigned;
        private System.Windows.Forms.GroupBox gb_Car;
        private System.Windows.Forms.Label lbl_CarAvalable;
        private System.Windows.Forms.ComboBox cob_CarAvailable;
        private System.Windows.Forms.Label lbl_Model;
        private System.Windows.Forms.TextBox txt_Model;
        private System.Windows.Forms.Label lbl_CarID;
        private System.Windows.Forms.ComboBox cob_CarID;
        private System.Windows.Forms.Label lbl_Brand;
        private System.Windows.Forms.TextBox txt_Brand;
        private System.Windows.Forms.Label lbl_Borrowed;
    }
}
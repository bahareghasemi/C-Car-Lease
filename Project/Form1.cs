using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Form1 : Form
    {
        Management management;
        public Form1()
        {
            InitializeComponent();
            management = new Management();
            dat_Register.Value = DateTime.Today;
        }

        private void btn_AddUser_Click(object sender, EventArgs e)
        {
            if ((txt_UserID.Text=="") || (txt_UserName.Text==""))
            {
                MessageBox.Show("Please enter User ID and Name!");
                return;
            }

            int userID;
            if (!int.TryParse(txt_UserID.Text, out userID))
            {
                MessageBox.Show("Invalid User ID. Please enter an Integer value!");
                return;
            }
            string name=txt_UserName.Text;
            User user=new User(userID,name,txt_Email.Text,txt_Phone.Text
                ,txt_Address.Text,txt_Bank.Text,dat_Register.Value.ToShortDateString());
            Boolean result=management.AddUser(user);
            if (result)
            {
                MessageBox.Show("User added!");
                ClearUserFields();
                lst_Users.Items.Add(userID + " : [" + name + "] - [" + user.Phone + "] - [" + user.Bank 
                    + "] - [" + user.Address + "] - [" + user.RegistrationDate + "] - [" + user.Email+"]");
            }
            else
            {
                MessageBox.Show("User ID already exists!");
            }
        }

        private void ClearUserFields()
        {
            txt_UserID.Text = "";
            txt_UserName.Text = "";
            txt_Email.Text = "";
            txt_Phone.Text = "";
            txt_Address.Text = "";
            txt_Bank.Text = "";
        }

        private void btn_RemoveUser_Click(object sender, EventArgs e)
        {
            if (txt_UserID.Text == "")
            {
                MessageBox.Show("Please enter User ID!");
                return;
            }

            int userID;
            if (!int.TryParse(txt_UserID.Text, out userID))
            {
                MessageBox.Show("Invalid User ID. Please enter an Integer value!");
                return;
            }

            Boolean result = management.RemoveUser(userID);
            if (result)
            {
                MessageBox.Show("User " + userID.ToString() + " removed!");
                ClearUserFields();
                Dictionary<int, User> users = management.GetAllUsers();
                lst_Users.Items.Clear();
                foreach (var user in users)
                {
                    lst_Users.Items.Add(user.Value.UserID + " : [" + user.Value.Name + "] : [" + user.Value.Phone + "] - [" 
                        + user.Value.Bank
                    + "] - [" + user.Value.Address + "] - [" + user.Value.RegistrationDate + "] - [" + user.Value.Email+"]");
                }
            }
            else
                MessageBox.Show("User not found!");  
        }

        private void btn_ClearUsers_Click(object sender, EventArgs e)
        {
            management.ClearUsers();
            lst_Users.Items.Clear();
            ClearUserFields();
        }

        private void btn_DisplayUsers_Click(object sender, EventArgs e)
        {
            Dictionary<int, User>  users =management.GetAllUsers();
            lst_Users.Items.Clear();
            foreach(var user in users) 
            {
                lst_Users.Items.Add(user.Value.UserID+" : ["+user.Value.Name + "] : [" + user.Value.Phone + "] - [" + user.Value.Bank
                    + "] - [" + user.Value.Address + "] - [" + user.Value.RegistrationDate + "] - [" + user.Value.Email+"]");
            }
        }

        private void btn_AddCar_Click(object sender, EventArgs e)
        {
            if (txt_CarID.Text == "")
            {
                MessageBox.Show("Please enter Car ID!");
                return;
            }

            int carID;
            if (!int.TryParse(txt_CarID.Text, out carID))
            {
                MessageBox.Show("Invalid Car ID. Please enter an Integer value!");
                return;
            }
            double mileage=0;
            if (txt_Mileage.Text != "")
            {
                if (!double.TryParse(txt_Mileage.Text, out mileage))
                {
                    MessageBox.Show("Invalid Mileage. Please enter an correct value!");
                    return;
                }
            }
            int price=0;
            if (txt_Price.Text != "")
            {
                if (!int.TryParse(txt_Price.Text, out price))
                {
                    MessageBox.Show("Invalid Price. Please enter Price!");
                    return;
                }
            }
            string mo = txt_Brand.Text;
            bool ava= true;
            if (cob_CarAvailable.Text=="No")
                ava=false;
            Car car = new Car(carID, mo, txt_Model.Text, txt_Color.Text
                , mileage, price, ava);
                
            Boolean result = management.AddCar(car);
            if (result)
            {
                MessageBox.Show("Car added!");
                ClearCarFields();
                lst_Cars.Items.Add(carID+" : ["+ mo + "] : [" + car.Model + "] : [" + car.Mileage + "] :    [" 
                    + car.PricePerDay + "]      : [" + car.Color + "] : [" + car.IsAvailable+"]");
            }
            else
            {
                MessageBox.Show("Car ID already exists!");
            }

        }

        private void ClearCarFields()
        {
            txt_CarID.Text = "";
            txt_Brand.Text = "";
            txt_Model.Text = "";
            txt_Color.Text = "";
            txt_Mileage.Text = "";
            txt_Price.Text = "";
            cob_CarAvailable.Text = "";
        }

        private void btn_RemoveCar_Click(object sender, EventArgs e)
        {

            if (txt_CarID.Text == "")
            {
                MessageBox.Show("Please enter Car ID!");
                return;
            }

            int carID;
            if (!int.TryParse(txt_CarID.Text, out carID))
            {
                MessageBox.Show("Invalid Car ID. Please enter an Integer value!");
                return;
            }

            Boolean result = management.RemoveCar(carID);
            if (result)
            {
                MessageBox.Show("Car " + carID.ToString() + " removed!");
                ClearCarFields();
                Dictionary<int, Car> cars = management.GetAllCars();
                lst_Cars.Items.Clear();
                foreach (var car in cars)
                {
                    lst_Cars.Items.Add(car.Value.CarID + " : " + car.Value.Brand + "] : [" + car.Value.Model + "] : [" 
                        + car.Value.Mileage 
                    + "] :    [" + car.Value.PricePerDay + "]      : [" + car.Value.Color + "] : [" + car.Value.IsAvailable + "]");
                }
            }
            else
                MessageBox.Show("Car not found!");
        }

        private void btn_ClearCars_Click(object sender, EventArgs e)
        {
            management.ClearCars();
            lst_Cars.Items.Clear();
            ClearCarFields();
        }

        private void btn_DisplayCars_Click(object sender, EventArgs e)
        {
            Dictionary<int, Car> cars = management.GetAllCars();
            lst_Cars.Items.Clear();
            foreach (var car in cars)
            {
                lst_Cars.Items.Add(car.Value.CarID + " : " + car.Value.Brand + "] : [" + car.Value.Model + "] : [" + car.Value.Mileage
                    + "] :    [" + car.Value.PricePerDay + "]      : [" + car.Value.Color + "] : [" + car.Value.IsAvailable + "]");
            }
        }

        private void btn_RentCar_Click(object sender, EventArgs e)
        {
            Form2 f= new Form2(management);
            f.Show();
            this.Hide();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Project
{
    public class User
    {
        public int UserID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Bank { get; set; }
        public string RegistrationDate { get; set; }
        public List<int> BorrowedCarIDs { get; set; }

        public User(int userID, string name, string email, string phone, string address, string bank, string registrationDate)
        {
            UserID = userID;
            Name = name;
            Email = email;
            Phone = phone;
            Address = address;
            BorrowedCarIDs = new List<int>();
            Bank = bank;
            RegistrationDate = registrationDate;
        }
    }
}

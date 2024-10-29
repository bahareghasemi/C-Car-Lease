using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Project
{
    public class Car
    {
        public int CarID { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public double Mileage { get; set; }
        public int PricePerDay { get; set; }
        public bool IsAvailable { get; set; }
        public Car(int carID, string brand, string model, string color, double mileage, int price, bool ava)
        {
            CarID = carID;
            Brand = brand;
            Model = model;
            Color = color;
            Mileage = mileage;
            PricePerDay=price;
            IsAvailable = ava;
        }
    }
}

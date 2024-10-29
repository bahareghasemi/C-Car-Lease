using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public class Management 
    {
        private Dictionary<int,User> users = new Dictionary<int, User>();
        private Dictionary<int, Car> cars = new Dictionary<int, Car>();

        public Management()
        {
            
        }

        public Boolean AddUser(User user)
        {
            User us = users.Where(u => u.Value.UserID == user.UserID).FirstOrDefault().Value;
            if (us == null)
            {
                users.Add(user.UserID,user);
                return true;
            }
            else
            {
                return false;
            }
        }

        public Boolean RemoveUser(int UserID)
        {
            User user = users.Where(u => u.Value.UserID == UserID).FirstOrDefault().Value;
            if (user != null)
            {
                users.Remove(UserID);
                return true;
            }
            else
            {
                return false;
            }
        }

        public void ClearUsers()
        {
            users.Clear();
        }

        public Dictionary<int, User> GetAllUsers()
        {
            return users;
        }

        public Boolean AddCar(Car car)
        {
            Car ca = cars.Where(u => u.Value.CarID == car.CarID).FirstOrDefault().Value;
            if (ca == null)
            {
                cars.Add(car.CarID, car);
                return true;
            }
            else
            {
                return false;
            }
        }

        public Boolean RemoveCar(int CarID)
        {
            Car ca = cars.Where(u => u.Value.CarID == CarID).FirstOrDefault().Value;
            if (ca != null)
            {
                cars.Remove(CarID);
                return true;
            }
            else
            {
                return false;
            }
        }

        public void ClearCars()
        {
            cars.Clear();
        }
        public Car GetCarByID(int carID)
        {
            var car=cars.Where(c => c.Value.CarID == carID).FirstOrDefault();
            return car.Value;
        }

        public Dictionary<int,Car> GetAllCars()
        {
            return cars;
        }

        public List<int> GetAllBorrowedCars(int UserID) 
        {
            User us=users.Where(u=>u.Key== UserID).FirstOrDefault().Value;
            return us.BorrowedCarIDs;
        }

        public Boolean AssignCarToUser(int carID, int UserID)
        {
            Boolean result = false;
            Car car = cars.Where(c => c.Value.CarID == carID).FirstOrDefault().Value;
            User user = users.Where(u => u.Value.UserID == UserID).FirstOrDefault().Value;

            if (car != null && user != null)
            {
                if (!user.BorrowedCarIDs.Contains(carID))
                {
                    if (car.IsAvailable)
                    {
                        car.IsAvailable = false;
                        user.BorrowedCarIDs.Add(carID);
                        MessageBox.Show("Car added to User " + user.Name+" by id "+UserID);
                        result= true;
                    }
                    else
                    {
                        MessageBox.Show("Car "+carID+" is already assigned to another User!");
                    }
                }
                else
                {
                    MessageBox.Show("Car "+carID+" is already assigned to the User!");
                }
            }
            else
            {
                MessageBox.Show("Car or User not found!");
            }
            return result;
        }

        public Boolean UnassignCarFromUser(int carID, int UserID)
        {
            Boolean result = false;
            Car car = cars.Where(c => c.Value.CarID == carID).FirstOrDefault().Value;
            User user = users.Where(u => u.Value.UserID == UserID).FirstOrDefault().Value;

            if (car != null && user != null)
            {
                if (user.BorrowedCarIDs.Contains(carID))
                {
                    car.IsAvailable = true;
                    user.BorrowedCarIDs.Remove(carID);
                    MessageBox.Show("Car unassigned from User " + user.Name + " by id " + UserID);
                    result= true;
                }
                else
                {
                    MessageBox.Show("Car "+carID+"  is not assigned to the User.");
                }
            }
            else
            {
                MessageBox.Show("Car or User not found.");
            }
            return result;
        }


    }
}

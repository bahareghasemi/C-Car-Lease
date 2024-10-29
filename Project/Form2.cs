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
    public partial class Form2 : Form
    {
        
        Form1 form1;
        Dictionary<int, Car> cars;
        Dictionary<int, User> users;
        Management management;
        public Form2(Management man)
        {
            InitializeComponent();
            cars= new Dictionary<int, Car>();
            users = new Dictionary<int, User>();
            management = man;
        }

        private void cob_CarID_SelectedIndexChanged(object sender, EventArgs e)
        {
            int k = cob_CarID.SelectedIndex;
            string str=cob_CarID.Items[k].ToString();
            foreach (KeyValuePair<int,Car> c in cars)
            {
                if (str==c.Key.ToString())
                {
                    txt_Model.Text = c.Value.Model;
                    if (!c.Value.IsAvailable)
                        cob_CarAvailable.BackColor = Color.Red;
                    else
                        cob_CarAvailable.BackColor = Color.White;
                    cob_CarAvailable.Text = c.Value.IsAvailable.ToString();
                    txt_Brand.Text= c.Value.Brand;
                    return; 
                }
            }
        }

        private void Form2_Shown(object sender, EventArgs e)
        {
            cob_CarID.Items.Clear();
            cars =management.GetAllCars();
            if (cars.Count > 0)
            {
                foreach (KeyValuePair<int, Car> c in cars)
                {
                    cob_CarID.Items.Add(c.Key.ToString());
                }
                cob_CarID.SelectedIndex = 0;
            }
            chb_User.Items.Clear();
            users=management.GetAllUsers();
            if (users.Count > 0)
            {
                foreach (KeyValuePair<int, User> u in users)
                {
                    chb_User.Items.Add(u.Key.ToString()+":"+u.Value.Name+" "+u.Value.Phone+" "+ u.Value.Bank);
                }
                
            }
        }

        private void chb_User_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            lst_BorrowedCars.Items.Clear();
            int id=GetUserID();
            List<int> borrowed;
            if (id == 0)
                return;
            borrowed=management.GetAllBorrowedCars(id);
            if (borrowed.Count == 0)
                return;
            foreach (int i in borrowed)
            {
                lst_BorrowedCars.Items.Add(i.ToString());
            }
        }

        private void btn_Assigned_Click(object sender, EventArgs e)
        {
            string str=cob_CarID.Text;
            int idcar;
            int.TryParse(str,out idcar);
            int iduser = GetUserID();
            Boolean res;
            if (iduser > 0)
            {
                res = management.AssignCarToUser(idcar, iduser);
                if (res)
                {
                    cob_CarAvailable.Text = false.ToString();
                    cob_CarAvailable.BackColor = Color.Red;
                }
            }
            
        }

        private void btn_UnAssigned_Click(object sender, EventArgs e)
        {
            string str = cob_CarID.Text;
            int idcar;
            int.TryParse(str, out idcar);
            int id = GetUserID();
            Boolean res; 
            if (id > 0)
            {
                res=management.UnassignCarFromUser(idcar, id);
                if (res)
                {
                    cob_CarAvailable.Text = true.ToString();
                    cob_CarAvailable.BackColor = Color.White;
                }
            }
            }

        private int GetUserID()
        {
            int id = chb_User.SelectedIndex;
            string str = chb_User.Items[id].ToString();
            string[] temp = str.Split(':');
            int.TryParse(temp[0], out id);
            return id;
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}

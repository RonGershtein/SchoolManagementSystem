using FinalProjectC_.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProjectC_
{
    public partial class FormLoginScreen : Form
    {
        public static FormLoginScreen instance;
       
        public FormLoginScreen()
        {
            InitializeComponent();
            instance = this; 

        }
         


        private void pictureBox2_Click(object sender, EventArgs e) //Exit Logo in login screen
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e) //Clear Button
        {
            txtboxPassword.Clear();
            txtboxUserName.Clear();
        }

        private bool isValid() //checking if the user give inforamtion about user and passwor
        {
            if (txtboxUserName.Text.TrimStart() == string.Empty)
            {
                MessageBox.Show("Please enter vaild user name", "error", MessageBoxButtons.OK);
                return false;
            }
            if (txtboxPassword.Text.TrimStart() == string.Empty)
            {
                MessageBox.Show("Please enter vaild password", "error", MessageBoxButtons.OK);
                return false;
            }
            return true;
        }

        public int permission = 0;
        public int loginIndex = 0; 

        public int CheckUserAndPassword(string username, string password)
        {
            if (txtboxUserName.Text == "admin" && txtboxPassword.Text == "admin")
            {
                loginIndex = -1;
                return 4; // Admin

            }

            foreach (Teacher obj in Program.myschool.Teacherlist)
            {

                if (obj is HouseKeeper)
                {
                    HouseKeeper houseKeeper = (HouseKeeper)obj;
                    if (houseKeeper.getUsername().Equals(username) && houseKeeper.getPassword().Equals(password))
                    {
                        return 2; // House Keeper
                    }
                }
                else if (obj is SchoolMenager)
                {
                    SchoolMenager schoolManager = (SchoolMenager)obj;
                    if (schoolManager.getUsername().Equals(username) && schoolManager.getPassword().Equals(password))
                    {
                        return 3; // School Manager
                    }
                }
                else if (obj is Teacher)
                {
                    if (obj.getUsername().Equals(username) && obj.getPassword().Equals(password))
                    {
                        return 1; // Regular Teacher
                    }
                }
                loginIndex++;
            }

            // No valid match found
            MessageBox.Show("Incorrect username or password", "Login error", MessageBoxButtons.OK);
            txtboxPassword.Clear();

            return 0; // No permission
        }

        private void button1_Click(object sender, EventArgs e) //Login Button
        {
            if(isValid())
            {
                int per = CheckUserAndPassword(txtboxUserName.Text, txtboxPassword.Text);
                if (per > 0)
                {
                    instance.permission = per;
                    this.Hide();
                    FormMain Mainform = new FormMain();
                    Mainform.Show();
                }
            }
           
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            txtboxPassword.UseSystemPasswordChar = false;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            txtboxPassword.UseSystemPasswordChar = true;
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            Program.myschool.LoadData();
        }
    }
}

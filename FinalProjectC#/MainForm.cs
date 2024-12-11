using FinalProjectC_.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProjectC_
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            if(FormLoginScreen.instance.loginIndex != -1)
                lblWhoAmI.Text = Program.myschool.Teacherlist[FormLoginScreen.instance.loginIndex].WhoAmI();
            else
            {
                lblWhoAmI.Text = string.Format("You logged in as an Admin\nRole: Admin\nSalary: ∞");
            }
            foreach (Teacher teacher in Program.myschool.Teacherlist)
                teacher.setSalary();
        }

        private void lblLoadingScreen_Click(object sender, EventArgs e)
        {

        }

        private void PictureBoxExitLogin_Click(object sender, EventArgs e) //Logout Picture
        {
            Program.myschool.SaveData();

            Application.Exit();

        }

        private void pictureBox2_Click(object sender, EventArgs e) //Personnel picture
        {
            if(FormLoginScreen.instance.permission > 2) 
            { 
                this.Hide();
                formPersonnelManagement formPersonnel = new formPersonnelManagement();
                formPersonnel.Show();
            }
            else
            {
                MessageBox.Show("You dont have permision");
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e) //vehicle
        {
            if (FormLoginScreen.instance.permission == 2 || FormLoginScreen.instance.permission == 4)
            { 
                this.Hide();
                Fault fault = new Fault();
                fault.Show();
            }
            else
            {
                MessageBox.Show("You dont have permision");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (FormLoginScreen.instance.permission >= 1 && FormLoginScreen.instance.permission != 2 )
            {
                this.Hide();
                FormStudent fault = new FormStudent();
                fault.Show();
                
            }
            else 
            {
                MessageBox.Show("You dont have permision");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblClockT.Text =  DateTime.Now.ToString("T");
            
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (FormLoginScreen.instance.permission > 2)
            { 
                FormAnalytics formAnalytics = new FormAnalytics();
                this.Hide();
                formAnalytics.Show();
            }
            else
            {
                MessageBox.Show("You dont have permision");
            }
        }
    }
}

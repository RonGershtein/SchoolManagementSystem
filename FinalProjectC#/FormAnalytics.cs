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
    public partial class FormAnalytics : Form
    {
        public FormAnalytics()
        {
            InitializeComponent();
            lblstudentfees.Text = "";
            lblteacherfees.Text = "";
            lblsubtotal.Text = "";
            lblstudents.Text = Program.myschool.StudentList.Count.ToString();
            lblteacher.Text = Program.myschool.Teacherlist.Count.ToString();
            lblstudentfees.Text = (Program.myschool.StudentList.Count * 750).ToString("N0");
            double totalFeesTeacher = 0;

            foreach (Teacher teacher in Program.myschool.Teacherlist)
                totalFeesTeacher += teacher.getSalary();

            lblteacherfees.Text += totalFeesTeacher.ToString("N2");
            lblsubtotal.Text = (totalFeesTeacher + (Program.myschool.StudentList.Count * 750)).ToString("N2");
        }

        private void timerclock_Tick(object sender, EventArgs e)
        {
            lblClock.Text = DateTime.Now.ToString("T");
        }

        private void PictureExit_Click(object sender, EventArgs e)
        {
            Program.myschool.SaveData();
            System.Windows.Forms.Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblteacher_Click(object sender, EventArgs e)
        {

        }

        private void picturehomeEmployee_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMain formMain = new FormMain();
            formMain.Show();
        }
    }
}

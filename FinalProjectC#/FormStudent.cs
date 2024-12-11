using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProjectC_
{
    public partial class FormStudent : Form
    {
        public FormStudent()
        {
            InitializeComponent();
            dataGridViewStudentgrades.AutoGenerateColumns = false;
            dataGridViewStudentgrades.DataSource = Program.myschool.StudentList;
            dataGridViewStudentgrades.Refresh();
        }

        private void dataGridViewStudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void picturehomeEmployee_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMain formMain = new FormMain();
            formMain.Show();
        }

        private void PictureExit_Click(object sender, EventArgs e)
        {
            Program.myschool.SaveData();
            Application.Exit();
        }
        int indexRow;
        private void dataGridViewStudentgrades_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexRow = e.RowIndex;
            if (indexRow >= 0)
            {
                DataGridViewRow row = dataGridViewStudentgrades.Rows[indexRow];

                if (row != null)
                {
                    txtboxName.Text = row.Cells[0].Value.ToString();
                    txtboxid.Text = row.Cells[1].Value.ToString();
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtboxgrade.Text, out int gradeValue))
            { 
                if (comboClass.Text == "Math")
                 {
                    if(gradeValue >= 1 && gradeValue <= 100)
                        Program.myschool.StudentList[indexRow].setmathgrade(gradeValue);
                    else
                    {
                        MessageBox.Show("Grade need to be between 1 - 100", "error", MessageBoxButtons.OK);
                    }
                }
                else if(comboClass.Text == "English")
                {
                    if (gradeValue >= 1 && gradeValue <= 100)
                        Program.myschool.StudentList[indexRow].setenglishgrade(gradeValue);
                    else
                    {
                        MessageBox.Show("Grade need to be between 1 - 100", "error", MessageBoxButtons.OK);
                    }
                }
                else if (comboClass.Text == "Hebrew")
                {
                    if (gradeValue >= 1 && gradeValue <= 100)
                        Program.myschool.StudentList[indexRow].sethebrewgrade(gradeValue);

                    else
                    {
                        MessageBox.Show("Grade need to be between 1 - 100", "error", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    MessageBox.Show("You need to choose a class before adding a grade", "error", MessageBoxButtons.OK);
                }

            }
            else
            {
                MessageBox.Show("invalid characters", "error", MessageBoxButtons.OK);

            }
            txtboxgrade.Text = string.Empty;
            dataGridViewStudentgrades.Refresh();
        }

        private void btndisturbance_Click(object sender, EventArgs e)
        {
            if (txtboxName.Text != string.Empty)
            { 
            Program.myschool.StudentList[indexRow].setdisturbance();
            dataGridViewStudentgrades.Refresh();
            }
        }

        private void btnabsence_Click(object sender, EventArgs e)
        {
            if (txtboxName.Text != string.Empty)
            {
                Program.myschool.StudentList[indexRow].setabsence();
                dataGridViewStudentgrades.Refresh();
            }
        }

        private void FormStudent_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_MouseEnter(object sender, EventArgs e)
        {
            btnAdd.BackColor = Color.Green;
        }

        private void btnAdd_MouseLeave(object sender, EventArgs e)
        {
            btnAdd.BackColor= Color.RosyBrown;
        }

        private void btndisturbance_MouseEnter(object sender, EventArgs e)
        {
            btndisturbance.BackColor = Color.Green; 
        }

        private void btndisturbance_MouseLeave(object sender, EventArgs e)
        {
            btndisturbance.BackColor= Color.RosyBrown;
        }

        private void btnabsence_MouseEnter(object sender, EventArgs e)
        {
            btnabsence.BackColor = Color.Green; 
        }

        private void btnabsence_MouseLeave(object sender, EventArgs e)
        {
            btnabsence.BackColor= Color.RosyBrown;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblClock.Text = DateTime.Now.ToString("T");
        }
    }
}

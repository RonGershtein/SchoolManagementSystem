using FinalProjectC_.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DGVPrinterHelper;
using Microsoft.Office.Interop.Excel;
using System.Text.RegularExpressions;

namespace FinalProjectC_
{


    public partial class formPersonnelManagement : Form
    {


        public formPersonnelManagement()
        {
            InitializeComponent();
            dataGridViewTeacher.AutoGenerateColumns = false;
            dataGridViewStudent.AutoGenerateColumns = false;
            dataGridViewTeacher.DataSource = Program.myschool.Teacherlist; // connect the data grid table to the list!!!!
            dataGridViewStudent.DataSource = Program.myschool.StudentList;
            dataGridViewStudent.Refresh();
            dataGridViewTeacher.Refresh();
            textboxseniority.Hide();
            comboEduction.Hide();
            lblEduction.Hide();
            lblseniority.Hide();
            dataGridViewTeacher.Hide();
            dataGridViewStudent.Hide();
            TableHeadline.Hide();
        }



        private void PictureExit_Click(object sender, EventArgs e) //logout bottom
        {
            Program.myschool.SaveData();
            System.Windows.Forms.Application.Exit();
        }

        private void btnClear_Click(object sender, EventArgs e) //clear bottom
        {
            txtboxAddrass.Clear();
            txtboxid.Clear();
            txtboxName.Clear();
            txtboxPhone.Clear();
            if (rdbteacher.Checked)
            {
                textboxseniority.Clear();

            }
        }

        private void picturehome_Click(object sender, EventArgs e) //Home buttom
        {
            this.Hide();
            FormMain formMain = new FormMain();
            formMain.Show();
        }



        private void rdbstudent_CheckedChanged(object sender, EventArgs e)
        {
            dataGridViewTeacher.Hide();
            dataGridViewStudent.Show();
            TableHeadline.Show();
            TableHeadline.Text = "Students";

            textboxseniority.Hide();
            comboEduction.Hide();
            lblEduction.Hide();
            lblseniority.Hide();
            txtboxAddrass.Enabled = true;
            txtboxid.Enabled = true;
            txtboxName.Enabled = true;
            txtboxPhone.Enabled = true;
            comboGender.Enabled = true;
            dateTimePicker1.Enabled = true;
            lblid.Enabled = true;
            lblname.Enabled = true;
            lblDB.Enabled = true;
            lblgender.Enabled = true;
            lbladdress.Enabled = true;
            lblphone.Enabled = true;

        }

        private void rdbteacher_CheckedChanged(object sender, EventArgs e)
        {
            dataGridViewStudent.Hide();
            TableHeadline.Show();
            TableHeadline.Text = "Teachers";

            dataGridViewTeacher.Show();
            textboxseniority.Show();
            comboEduction.Show();
            lblEduction.Show();
            lblseniority.Show();
            txtboxAddrass.Enabled = true;
            txtboxid.Enabled = true; 
            txtboxName.Enabled = true;
            txtboxPhone.Enabled = true;
            comboGender.Enabled = true;
            dateTimePicker1.Enabled = true;
            textboxseniority.Enabled = true;
            comboEduction.Enabled = true;
            lblid.Enabled = true;
            lblname.Enabled = true;
            lblDB.Enabled = true;
            lblgender.Enabled = true;
            lbladdress.Enabled = true;
            lblphone.Enabled = true;
            lblseniority.Enabled = true;
            lblEduction.Enabled = true;


        }

        public bool IsValid()
        {
            if (txtboxid.Text.TrimStart() == string.Empty ||
                txtboxName.Text.TrimStart() == string.Empty ||
                txtboxAddrass.Text.TrimStart() == string.Empty ||
                txtboxPhone.Text.TrimStart() == string.Empty ||
                comboGender.Text.TrimStart() == string.Empty)
            {
                MessageBox.Show("Missing information, please complete all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (rdbteacher.Checked)
            {
                if (comboEduction.Text.TrimStart() == string.Empty || textboxseniority.Text.TrimStart() == string.Empty)
                {
                    MessageBox.Show("Missing information, please complete all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                if (!Regex.IsMatch(textboxseniority.Text, @"^[0-9]{1,2}$") ||
                    int.Parse(textboxseniority.Text) < 0 ||
                    int.Parse(textboxseniority.Text) > 40)
                {
                    MessageBox.Show("Seniority should contain only numbers and they need to be between [0-40].", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }


            if (!Regex.IsMatch(txtboxid.Text, @"^\d+$"))
            {
                MessageBox.Show("ID should contain only numbers.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!Regex.IsMatch(txtboxName.Text, @"^[a-zA-Z ]+$"))
            {
                MessageBox.Show("Name should contain only letters and spaces.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!Regex.IsMatch(txtboxAddrass.Text, @"^[a-zA-Z0-9\s]+$"))
            {
                MessageBox.Show("Address should contain only letters, numbers, and spaces.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!Regex.IsMatch(txtboxPhone.Text, @"^[0-9-]+$"))
            {
                MessageBox.Show("Phone number should contain only numbers and dashes.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(IsValid()) 
            {
                if(rdbteacher.Checked)
                {
                    Teacher teacher = new Teacher();
                    teacher.setId (txtboxid.Text);
                    teacher.setName (txtboxName.Text);
                    teacher.setAddrass (txtboxAddrass.Text);
                    teacher.setPhoneNumber (txtboxPhone.Text);
                    teacher.setEducation(comboEduction.Text);
                    teacher.setSeniority(int.Parse(textboxseniority.Text));
                    teacher.setGender (comboGender.Text);
                    teacher.setusername();
                    teacher.setPassword();
                    DateTime selectday = dateTimePicker1.Value;
                    int SelectedYear = (selectday.Year);
                    teacher.setAge(2023 - SelectedYear);


                    Program.myschool.Addteacher(teacher);
                    btnClear_Click(sender, e);

                }
                if(rdbstudent.Checked)
                {
                    Student student = new Student();
                    student.setId(txtboxid.Text);
                    student.setName(txtboxName.Text);
                    student.setAddrass(txtboxAddrass.Text);
                    student.setPhoneNumber(txtboxPhone.Text);
                    student.setGender(comboGender.Text);

                    DateTime selectday = dateTimePicker1.Value;
                    int SelectedYear = (selectday.Year);
                    student.setAge(2023 - SelectedYear);
                    Program.myschool.Addstudent(student);
                    btnClear_Click(sender, e);

                }
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(rdbteacher.Checked && Program.myschool.Teacherlist.Count>0)
            {
                if(dataGridViewTeacher.CurrentRow.Index > 1)
                {
                    Program.myschool.Teacherlist.RemoveAt(dataGridViewTeacher.CurrentRow.Index);
                    btnClear_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("You don't have permission to delete this person.");
                }
            }

            if (rdbstudent.Checked && Program.myschool.StudentList.Count > 0)
            {
                Program.myschool.StudentList.RemoveAt(dataGridViewStudent.CurrentRow.Index);
                btnClear_Click(sender, e);
            }
        }

        public int indexRow;
        private void dataGridViewStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexRow = e.RowIndex;
            if(indexRow >= 0) 
            { 
            DataGridViewRow row = dataGridViewStudent.Rows[indexRow];
            
                if (row != null)
                {
                    txtboxName.Text = row.Cells[0].Value.ToString();
                    txtboxid.Text = row.Cells[1].Value.ToString();
                    comboGender.Text = row.Cells[3].Value.ToString();
                    txtboxAddrass.Text = row.Cells[4].Value.ToString();
                    txtboxPhone.Text = row.Cells[5].Value.ToString();
                }
            }
        }

        private void dataGridViewTeacher_CellClick(object sender, DataGridViewCellEventArgs e) // 
        {
            indexRow = e.RowIndex;
            if (indexRow >= 0)
            { 
                DataGridViewRow row = dataGridViewTeacher.Rows[indexRow];

                if (row != null)
                {
                    txtboxName.Text = row.Cells[1].Value.ToString();
                    txtboxid.Text = row.Cells[2].Value.ToString();
                    comboGender.Text = row.Cells[4].Value.ToString();
                    txtboxAddrass.Text = row.Cells[5].Value.ToString();
                    txtboxPhone.Text = row.Cells[6].Value.ToString();
                    comboEduction.Text = row.Cells[8].Value.ToString();
                    textboxseniority.Text = row.Cells[7].Value.ToString();
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if(IsValid())
            { 
                if(rdbteacher.Checked) 
                { 
                    DataGridViewRow newDataRow = dataGridViewTeacher.Rows[indexRow];
                    newDataRow.Cells[1].Value = txtboxName.Text;
                    newDataRow.Cells[2].Value = txtboxid.Text;
                    DateTime selectday = dateTimePicker1.Value;
                    int SelectedYear = (selectday.Year);
                    newDataRow.Cells[3].Value = 2023 - SelectedYear;
                    newDataRow.Cells[4].Value = comboGender.Text;
                    newDataRow.Cells[5].Value = txtboxAddrass.Text;
                    newDataRow.Cells[6].Value = txtboxPhone.Text;
                    newDataRow.Cells[7].Value = textboxseniority.Text;
                    newDataRow.Cells[8].Value = comboEduction.Text;
                    Program.myschool.Teacherlist[indexRow].setusername(); //if we change name we want to change username and password
                    Program.myschool.Teacherlist[indexRow].setPassword();
                    Program.myschool.Teacherlist[indexRow].setSalary();
                }
                if(rdbstudent.Checked)
                {
                    DataGridViewRow newDataRow = dataGridViewStudent.Rows[indexRow];
                    newDataRow.Cells[0].Value = txtboxName.Text;
                    newDataRow.Cells[1].Value = txtboxid.Text;
                    DateTime selectday = dateTimePicker1.Value;
                    int SelectedYear = (selectday.Year);
                    newDataRow.Cells[2].Value = 2023 - SelectedYear;
                    newDataRow.Cells[3].Value = comboGender.Text;
                    newDataRow.Cells[4].Value = txtboxAddrass.Text;
                    newDataRow.Cells[5].Value = txtboxPhone.Text;
                }
            }
            dataGridViewTeacher.Refresh();
        } //update the list when pressing the update B

        private void btnAdd_MouseEnter(object sender, EventArgs e)
        {
            btnAdd.BackColor = Color.Green;
        }

        private void btnAdd_MouseLeave(object sender, EventArgs e)
        {
            btnAdd.BackColor = Color.RosyBrown;
        }

        private void btnClear_MouseEnter(object sender, EventArgs e)
        {
            btnClear.BackColor = Color.Green;

        }

        private void btnClear_MouseLeave(object sender, EventArgs e)
        {
            btnClear.BackColor = Color.RosyBrown;
        }

        private void btnDelete_MouseEnter(object sender, EventArgs e)
        {
            btnDelete.BackColor = Color.Green;

        }

        private void btnDelete_MouseLeave(object sender, EventArgs e)
        {
            btnDelete.BackColor = Color.RosyBrown;
        }

        private void btnEdit_MouseEnter(object sender, EventArgs e)
        {
            btnEdit.BackColor = Color.Green;

        }

        private void btnEdit_MouseLeave(object sender, EventArgs e)
        {
            btnEdit.BackColor = Color.RosyBrown;
        }

        private void btnPrint_Click(object sender, EventArgs e) //printing table
        {
            if (rdbteacher.Checked) 
            { 
                DGVPrinter printer = new DGVPrinter();
                printer.Title = "Teacher Report";
                printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
                printer.PageNumbers = true;
                printer.PageNumberInHeader = true;
                printer.PorportionalColumns = true;
                printer.HeaderCellAlignment = StringAlignment.Near;
                printer.Footer = "L&R - School Mangment System";
                printer.FooterSpacing = 15;
                //customize the table

                dataGridViewTeacher.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
                dataGridViewTeacher.AutoResizeColumns();
                dataGridViewTeacher.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
                dataGridViewTeacher.AutoResizeRows();

                // Print the DataGridView
                printer.PrintDataGridView(dataGridViewTeacher);

                // Reset column widths and row heights to previous settings
                dataGridViewTeacher.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewTeacher.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            }
            if(rdbstudent.Checked) 
            {
                DGVPrinter printer = new DGVPrinter();

                printer.Title = "Student Report";
                printer.SubTitle = string.Format("Data: {0}", DateTime.Now.Date.ToString("dd/MM/yyyy"));
                printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
                printer.PageNumbers = true;
                printer.PageNumberInHeader = true;
                printer.PorportionalColumns = true;
                printer.HeaderCellAlignment = StringAlignment.Near;
                printer.Footer = "L&R - School Mangment System";
                printer.FooterSpacing = 15;
                

                dataGridViewTeacher.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
                dataGridViewTeacher.AutoResizeColumns();
                dataGridViewTeacher.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
                dataGridViewTeacher.AutoResizeRows();

                printer.PrintDataGridView(dataGridViewStudent);

                // Reset column widths and row heights to previous settings
                dataGridViewTeacher.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewTeacher.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            }  
        }

        private void Excel_Click(object sender, EventArgs e) //Excel table output
        {
            if (rdbteacher.Checked) 
            { 
                // Create a StringBuilder to hold the clipboard content
                StringBuilder dataGridInfo = new StringBuilder();
            
                // Add the header row to the clipboard content
                foreach (DataGridViewColumn column in dataGridViewTeacher.Columns)
                {
                    dataGridInfo.Append(column.HeaderText + "\t"); // Separate columns with a tab character
                }
                dataGridInfo.AppendLine(); // Move to the next line after the header

                // Add the data rows to the clipboard content
                foreach (DataGridViewRow row in dataGridViewTeacher.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        dataGridInfo.Append(cell.Value + "\t"); // Separate cells with a tab character
                    }
                    dataGridInfo.AppendLine(); // Move to the next line after the row
                }


                // Set the clipboard content (save temporary storage area in the computer's memory)
                Clipboard.SetText(dataGridInfo.ToString());

                // Now proceed with pasting into Excel and applying formatting
                Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
                excel.Visible = true;

                Microsoft.Office.Interop.Excel.Workbook xlWork;
                Microsoft.Office.Interop.Excel.Worksheet xlSheet;

               // object missingData = System.Reflection.Missing.Value;

                xlWork = excel.Workbooks.Add(); // add woorkbook
                xlSheet = xlWork.Worksheets.get_Item(1); //add sheet

                Microsoft.Office.Interop.Excel.Range xlRange = (Microsoft.Office.Interop.Excel.Range)xlSheet.Cells[1, 1];

                // Get the clipboard content as a tab-separated string
                string clipboardText = Clipboard.GetText();

                string[] lines = clipboardText.Split(new[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);

                // Populate Excel cells manually from the clipboard content
                for (int i = 0; i < lines.Length; i++)
                {
                    string[] values = lines[i].Split('\t');
                    for (int j = 0; j < values.Length; j++)
                    {
                        xlSheet.Cells[i + 1, j + 1] = values[j]; // +1 cause excel dont have 0A only 1A
                    }
                }

                // Apply formatting to the entire table (עיצוב טבלה)
                xlRange = xlSheet.Range[xlSheet.Cells[1, 1], xlSheet.Cells[dataGridViewTeacher.Rows.Count + 1, dataGridViewTeacher.Columns.Count]];
                xlRange.Borders.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
                xlRange.Font.Name = "Arial";
                xlRange.Font.Size = 12;
                xlRange.Cells.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

                // Apply formatting to the header row
                xlRange = xlSheet.Range[xlSheet.Cells[1, 1], xlSheet.Cells[1, dataGridViewTeacher.Columns.Count]];
                xlRange.Font.Color = System.Drawing.Color.White;
                xlRange.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.FromArgb(58, 56, 56));
                xlRange.Font.Bold = true;


                // Format values in column J (column index 10) to display as numbers with thousands separator
                xlRange = xlSheet.Range[xlSheet.Cells[2, 10], xlSheet.Cells[dataGridViewTeacher.Rows.Count + 1, 10]];
                xlRange.NumberFormat = "#,##0"; // Apply number format


                // Auto-fit columns
                xlSheet.DisplayRightToLeft = false;
                xlSheet.Columns.AutoFit();


            }

            if(rdbstudent.Checked)
            {
                // Create a StringBuilder to hold the clipboard content
                StringBuilder dataGridInfo = new StringBuilder();

                // Add the header row to the clipboard content
                foreach (DataGridViewColumn column in dataGridViewStudent.Columns)
                {
                    dataGridInfo.Append(column.HeaderText + "\t"); // Separate columns with a tab character
                }
                dataGridInfo.AppendLine(); // Move to the next line after the header

                // Add the data rows to the clipboard content
                foreach (DataGridViewRow row in dataGridViewStudent.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        dataGridInfo.Append(cell.Value + "\t"); // Separate cells with a tab character
                    }
                    dataGridInfo.AppendLine(); // Move to the next line after the row
                }


                // Set the clipboard content (save temporary storage area in the computer's memory)
                Clipboard.SetText(dataGridInfo.ToString());

                // Now proceed with pasting into Excel and applying formatting
                Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
                excel.Visible = true;

                Microsoft.Office.Interop.Excel.Workbook xlWork;
                Microsoft.Office.Interop.Excel.Worksheet xlSheet;

                // object missingData = System.Reflection.Missing.Value;

                xlWork = excel.Workbooks.Add(); // add woorkbook
                xlSheet = xlWork.Worksheets.get_Item(1); //add sheet

                Microsoft.Office.Interop.Excel.Range xlRange = (Microsoft.Office.Interop.Excel.Range)xlSheet.Cells[1, 1];

                // Get the clipboard content as a tab-separated string
                string clipboardText = Clipboard.GetText();
                string[] lines = clipboardText.Split(new[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);

                // Populate Excel cells manually from the clipboard content
                for (int i = 0; i < lines.Length; i++)
                {
                    string[] values = lines[i].Split('\t');
                    for (int j = 0; j < values.Length; j++)
                    {
                        xlSheet.Cells[i + 1, j + 1] = values[j]; // +1 cause excel dont have 0A only 1A
                    }
                }

                // Apply formatting to the header row and entire table (עיצוב טבלה)
                xlRange = xlSheet.Range[xlSheet.Cells[1, 1], xlSheet.Cells[dataGridViewStudent.Rows.Count + 1, dataGridViewStudent.Columns.Count]];
                xlRange.Borders.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
                xlRange.Font.Name = "Arial";
                xlRange.Font.Size = 12;
                xlRange.Cells.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

                // Apply formatting to the header row
                xlRange = xlSheet.Range[xlSheet.Cells[1, 1], xlSheet.Cells[1, dataGridViewStudent.Columns.Count]];
                xlRange.Font.Color = System.Drawing.Color.White;
                xlRange.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.FromArgb(58, 56, 56));
                xlRange.Font.Bold = true;


                // Format values in column J (column index 10) to display as numbers with thousands separator
                xlRange = xlSheet.Range[xlSheet.Cells[2, 10], xlSheet.Cells[dataGridViewStudent.Rows.Count + 1, 10]];
                xlRange.NumberFormat = "#,##0"; // Apply number format


                // Auto-fit columns
                xlSheet.DisplayRightToLeft = false;
                xlSheet.Columns.AutoFit();


            }

        }

        private void Excel_MouseEnter(object sender, EventArgs e)
        {
            btnExcel.BackColor = Color.Green;
        }

        private void Excel_MouseLeave(object sender, EventArgs e)
        {
            btnExcel.BackColor = Color.RosyBrown;
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            lblClock.Text = DateTime.Now.ToString("T");
        }

        private void lblClock_Click(object sender, EventArgs e)
        {

        }

        private void formPersonnelManagement_Load(object sender, EventArgs e)
        {

        }
    }
}

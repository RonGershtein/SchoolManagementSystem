using DGVPrinterHelper;
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
    public partial class Fault : Form
    {
        public Fault()
        {
            InitializeComponent();
            dataGridViewFault.AutoGenerateColumns = false;
            dataGridViewFault.DataSource = Program.myschool.faultsList;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            string des = txtboxdescription.Text;
            string loc = txtboxlocation.Text;

            FaultsClass fault = new FaultsClass(des, loc);
            Program.myschool.faultsList.Add(fault);
            btnClear_Click(sender, e);
        }

        private void PictureExit_Click(object sender, EventArgs e)
        {
            Program.myschool.SaveData();
            Application.Exit();
        }

        private void picturehomeEmployee_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMain formMain = new FormMain();
            formMain.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if ( Program.myschool.faultsList.Count > 0)
            {
                Program.myschool.faultsList.RemoveAt(dataGridViewFault.CurrentRow.Index);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtboxdescription.Clear();
            txtboxlocation.Clear(); 
        }

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

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblClock.Text = DateTime.Now.ToString("T"); 
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            // Store the original auto size settings
            DataGridViewAutoSizeColumnsMode originalColumnMode = dataGridViewFault.AutoSizeColumnsMode;
            DataGridViewAutoSizeRowsMode originalRowsMode = dataGridViewFault.AutoSizeRowsMode;

            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Faults Report";
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = true;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "L&R - School Mangment System";
            printer.FooterSpacing = 15;

            // Customize the table
            dataGridViewFault.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridViewFault.AutoResizeColumns();
            dataGridViewFault.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridViewFault.AutoResizeRows();

            // Print the DataGridView
            printer.PrintDataGridView(dataGridViewFault);

            // Reset column widths and row heights to previous settings
            dataGridViewFault.AutoSizeColumnsMode = originalColumnMode;
            dataGridViewFault.AutoSizeRowsMode = originalRowsMode;

            dataGridViewFault.Refresh();
        }
    }
}

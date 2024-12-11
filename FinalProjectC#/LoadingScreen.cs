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
    public partial class FormLoadingScreen : Form
    {
        public FormLoadingScreen()
        {
            InitializeComponent();
        }

        
        int Tbar = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            Tbar += 1;
            prograssbarLoading.Value = Tbar;
            lblPrograssBarPrecent.Text = Tbar + "%";
            if (prograssbarLoading.Value == 100)
            {
                tmrProgressBar.Stop();
                Tbar = 0;
                prograssbarLoading.Value = 0;
                this.Hide();
                FormLoginScreen nLogin = new FormLoginScreen();
                nLogin.TopMost = true;
                nLogin.Show();
            }
        }
    }
}

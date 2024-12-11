namespace FinalProjectC_
{
    partial class FormAnalytics
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label label5;
            this.panel1 = new System.Windows.Forms.Panel();
            this.picturehomeEmployee = new System.Windows.Forms.PictureBox();
            this.lblLoadingScreen = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.PictureExit = new System.Windows.Forms.PictureBox();
            this.lblClock = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblname = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblteacher = new System.Windows.Forms.Label();
            this.lblstudents = new System.Windows.Forms.Label();
            this.timerclock = new System.Windows.Forms.Timer(this.components);
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblteacherfees = new System.Windows.Forms.Label();
            this.lblstudentfees = new System.Windows.Forms.Label();
            this.lblsubtotal = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturehomeEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureExit)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lblsubtotal);
            this.panel1.Controls.Add(this.lblstudentfees);
            this.panel1.Controls.Add(this.lblteacherfees);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(-55, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(622, 343);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // picturehomeEmployee
            // 
            this.picturehomeEmployee.Image = global::FinalProjectC_.Properties.Resources._2;
            this.picturehomeEmployee.Location = new System.Drawing.Point(3, 8);
            this.picturehomeEmployee.Name = "picturehomeEmployee";
            this.picturehomeEmployee.Size = new System.Drawing.Size(76, 56);
            this.picturehomeEmployee.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picturehomeEmployee.TabIndex = 28;
            this.picturehomeEmployee.TabStop = false;
            this.picturehomeEmployee.Click += new System.EventHandler(this.picturehomeEmployee_Click);
            // 
            // lblLoadingScreen
            // 
            this.lblLoadingScreen.AutoSize = true;
            this.lblLoadingScreen.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoadingScreen.ForeColor = System.Drawing.Color.White;
            this.lblLoadingScreen.Location = new System.Drawing.Point(94, 22);
            this.lblLoadingScreen.Name = "lblLoadingScreen";
            this.lblLoadingScreen.Size = new System.Drawing.Size(169, 42);
            this.lblLoadingScreen.TabIndex = 27;
            this.lblLoadingScreen.Text = "Analytics";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.RosyBrown;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(485, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 15);
            this.label6.TabIndex = 35;
            this.label6.Text = "Exit&&Save";
            // 
            // PictureExit
            // 
            this.PictureExit.Image = global::FinalProjectC_.Properties.Resources._1;
            this.PictureExit.Location = new System.Drawing.Point(485, 8);
            this.PictureExit.Name = "PictureExit";
            this.PictureExit.Size = new System.Drawing.Size(58, 40);
            this.PictureExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureExit.TabIndex = 34;
            this.PictureExit.TabStop = false;
            this.PictureExit.Click += new System.EventHandler(this.PictureExit_Click);
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label5.ForeColor = System.Drawing.Color.White;
            label5.Location = new System.Drawing.Point(257, 416);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(302, 25);
            label5.TabIndex = 36;
            label5.Text = "L&R School Mangment System";
            // 
            // lblClock
            // 
            this.lblClock.AutoSize = true;
            this.lblClock.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblClock.ForeColor = System.Drawing.Color.White;
            this.lblClock.Location = new System.Drawing.Point(11, 416);
            this.lblClock.Name = "lblClock";
            this.lblClock.Size = new System.Drawing.Size(68, 25);
            this.lblClock.TabIndex = 33;
            this.lblClock.Text = "clock";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Orange;
            this.panel2.Controls.Add(this.lblteacher);
            this.panel2.Controls.Add(this.lblname);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Location = new System.Drawing.Point(84, 31);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(219, 129);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SeaGreen;
            this.panel3.Controls.Add(this.lblstudents);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Location = new System.Drawing.Point(379, 31);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(219, 129);
            this.panel3.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(10, 26);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 5);
            this.panel4.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Location = new System.Drawing.Point(10, 26);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(200, 5);
            this.panel5.TabIndex = 3;
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.BackColor = System.Drawing.Color.Orange;
            this.lblname.Enabled = false;
            this.lblname.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.ForeColor = System.Drawing.Color.Black;
            this.lblname.Location = new System.Drawing.Point(60, 2);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(92, 23);
            this.lblname.TabIndex = 10;
            this.lblname.Text = "Teachers";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SeaGreen;
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(65, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 23);
            this.label1.TabIndex = 11;
            this.label1.Text = "Students";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Enabled = false;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.RosyBrown;
            this.label2.Location = new System.Drawing.Point(90, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 23);
            this.label2.TabIndex = 37;
            this.label2.Text = "Teacher Fees ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Enabled = false;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.RosyBrown;
            this.label3.Location = new System.Drawing.Point(90, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 23);
            this.label3.TabIndex = 38;
            this.label3.Text = "Student Fees";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Enabled = false;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.RosyBrown;
            this.label4.Location = new System.Drawing.Point(90, 267);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 23);
            this.label4.TabIndex = 39;
            this.label4.Text = "Subtotal Expenses";
            // 
            // lblteacher
            // 
            this.lblteacher.AutoSize = true;
            this.lblteacher.BackColor = System.Drawing.Color.Orange;
            this.lblteacher.Enabled = false;
            this.lblteacher.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblteacher.ForeColor = System.Drawing.Color.Black;
            this.lblteacher.Location = new System.Drawing.Point(93, 62);
            this.lblteacher.Name = "lblteacher";
            this.lblteacher.Size = new System.Drawing.Size(29, 32);
            this.lblteacher.TabIndex = 11;
            this.lblteacher.Text = "0";
            this.lblteacher.Click += new System.EventHandler(this.lblteacher_Click);
            // 
            // lblstudents
            // 
            this.lblstudents.AutoSize = true;
            this.lblstudents.BackColor = System.Drawing.Color.SeaGreen;
            this.lblstudents.Enabled = false;
            this.lblstudents.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstudents.ForeColor = System.Drawing.Color.Black;
            this.lblstudents.Location = new System.Drawing.Point(94, 62);
            this.lblstudents.Name = "lblstudents";
            this.lblstudents.Size = new System.Drawing.Size(29, 32);
            this.lblstudents.TabIndex = 12;
            this.lblstudents.Text = "0";
            // 
            // timerclock
            // 
            this.timerclock.Enabled = true;
            this.timerclock.Tick += new System.EventHandler(this.timerclock_Tick);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Silver;
            this.panel6.Location = new System.Drawing.Point(94, 259);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(500, 2);
            this.panel6.TabIndex = 3;
            // 
            // lblteacherfees
            // 
            this.lblteacherfees.AutoSize = true;
            this.lblteacherfees.BackColor = System.Drawing.Color.White;
            this.lblteacherfees.Enabled = false;
            this.lblteacherfees.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblteacherfees.ForeColor = System.Drawing.Color.RosyBrown;
            this.lblteacherfees.Location = new System.Drawing.Point(348, 178);
            this.lblteacherfees.Name = "lblteacherfees";
            this.lblteacherfees.Size = new System.Drawing.Size(135, 23);
            this.lblteacherfees.TabIndex = 40;
            this.lblteacherfees.Text = "Teacher Fees ";
            // 
            // lblstudentfees
            // 
            this.lblstudentfees.AutoSize = true;
            this.lblstudentfees.BackColor = System.Drawing.Color.White;
            this.lblstudentfees.Enabled = false;
            this.lblstudentfees.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstudentfees.ForeColor = System.Drawing.Color.RosyBrown;
            this.lblstudentfees.Location = new System.Drawing.Point(348, 217);
            this.lblstudentfees.Name = "lblstudentfees";
            this.lblstudentfees.Size = new System.Drawing.Size(125, 23);
            this.lblstudentfees.TabIndex = 41;
            this.lblstudentfees.Text = "Student Fees";
            // 
            // lblsubtotal
            // 
            this.lblsubtotal.AutoSize = true;
            this.lblsubtotal.BackColor = System.Drawing.Color.White;
            this.lblsubtotal.Enabled = false;
            this.lblsubtotal.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsubtotal.ForeColor = System.Drawing.Color.RosyBrown;
            this.lblsubtotal.Location = new System.Drawing.Point(348, 267);
            this.lblsubtotal.Name = "lblsubtotal";
            this.lblsubtotal.Size = new System.Drawing.Size(125, 23);
            this.lblsubtotal.TabIndex = 42;
            this.lblsubtotal.Text = "Student Fees";
            // 
            // FormAnalytics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(559, 450);
            this.Controls.Add(this.lblClock);
            this.Controls.Add(label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.PictureExit);
            this.Controls.Add(this.picturehomeEmployee);
            this.Controls.Add(this.lblLoadingScreen);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAnalytics";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAnalytics";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturehomeEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureExit)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picturehomeEmployee;
        private System.Windows.Forms.Label lblLoadingScreen;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox PictureExit;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblClock;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblstudents;
        private System.Windows.Forms.Label lblteacher;
        private System.Windows.Forms.Timer timerclock;
        private System.Windows.Forms.Label lblsubtotal;
        private System.Windows.Forms.Label lblstudentfees;
        private System.Windows.Forms.Label lblteacherfees;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label2;
    }
}
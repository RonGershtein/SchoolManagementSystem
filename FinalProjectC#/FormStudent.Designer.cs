namespace FinalProjectC_
{
    partial class FormStudent
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
            this.dataGridViewStudentgrades = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.avarageMath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AVGENG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AVGHEB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnabsence = new System.Windows.Forms.Button();
            this.btndisturbance = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtboxgrade = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblgender = new System.Windows.Forms.Label();
            this.comboClass = new System.Windows.Forms.ComboBox();
            this.txtboxName = new System.Windows.Forms.TextBox();
            this.txtboxid = new System.Windows.Forms.TextBox();
            this.lblname = new System.Windows.Forms.Label();
            this.lblid = new System.Windows.Forms.Label();
            this.picturehomeEmployee = new System.Windows.Forms.PictureBox();
            this.lblLoadingScreen = new System.Windows.Forms.Label();
            this.PictureExit = new System.Windows.Forms.PictureBox();
            this.lblClock = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label6 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudentgrades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturehomeEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureExit)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label5.ForeColor = System.Drawing.Color.White;
            label5.Location = new System.Drawing.Point(635, 449);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(302, 25);
            label5.TabIndex = 44;
            label5.Text = "L&R School Mangment System";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.dataGridViewStudentgrades);
            this.panel1.Controls.Add(this.btnabsence);
            this.panel1.Controls.Add(this.btndisturbance);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.txtboxgrade);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblgender);
            this.panel1.Controls.Add(this.comboClass);
            this.panel1.Controls.Add(this.txtboxName);
            this.panel1.Controls.Add(this.txtboxid);
            this.panel1.Controls.Add(this.lblname);
            this.panel1.Controls.Add(this.lblid);
            this.panel1.Location = new System.Drawing.Point(-2, 69);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(939, 373);
            this.panel1.TabIndex = 0;
            // 
            // dataGridViewStudentgrades
            // 
            this.dataGridViewStudentgrades.AllowUserToAddRows = false;
            this.dataGridViewStudentgrades.AllowUserToDeleteRows = false;
            this.dataGridViewStudentgrades.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewStudentgrades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStudentgrades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.avarageMath,
            this.AVGENG,
            this.AVGHEB});
            this.dataGridViewStudentgrades.Location = new System.Drawing.Point(359, 31);
            this.dataGridViewStudentgrades.Name = "dataGridViewStudentgrades";
            this.dataGridViewStudentgrades.ReadOnly = true;
            this.dataGridViewStudentgrades.Size = new System.Drawing.Size(566, 324);
            this.dataGridViewStudentgrades.TabIndex = 42;
            this.dataGridViewStudentgrades.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewStudentgrades_CellClick);
            this.dataGridViewStudentgrades.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewStudent_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "name";
            this.dataGridViewTextBoxColumn1.HeaderText = "Name";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn2.HeaderText = "ID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "gradesAverage";
            this.dataGridViewTextBoxColumn7.HeaderText = "AVG Grades";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "disturbance";
            this.dataGridViewTextBoxColumn8.HeaderText = "Disturbance";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "absence";
            this.dataGridViewTextBoxColumn9.HeaderText = "Absence";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // avarageMath
            // 
            this.avarageMath.DataPropertyName = "AVGmath";
            this.avarageMath.HeaderText = "AVG Math";
            this.avarageMath.Name = "avarageMath";
            this.avarageMath.ReadOnly = true;
            // 
            // AVGENG
            // 
            this.AVGENG.DataPropertyName = "AVGeng";
            this.AVGENG.HeaderText = "AVG ENG";
            this.AVGENG.Name = "AVGENG";
            this.AVGENG.ReadOnly = true;
            // 
            // AVGHEB
            // 
            this.AVGHEB.DataPropertyName = "AVGheb";
            this.AVGHEB.HeaderText = "AVG HEB";
            this.AVGHEB.Name = "AVGHEB";
            this.AVGHEB.ReadOnly = true;
            // 
            // btnabsence
            // 
            this.btnabsence.BackColor = System.Drawing.Color.RosyBrown;
            this.btnabsence.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnabsence.ForeColor = System.Drawing.Color.White;
            this.btnabsence.Location = new System.Drawing.Point(22, 319);
            this.btnabsence.Name = "btnabsence";
            this.btnabsence.Size = new System.Drawing.Size(245, 36);
            this.btnabsence.TabIndex = 7;
            this.btnabsence.Text = "Add Absence";
            this.btnabsence.UseVisualStyleBackColor = false;
            this.btnabsence.Click += new System.EventHandler(this.btnabsence_Click);
            this.btnabsence.MouseEnter += new System.EventHandler(this.btnabsence_MouseEnter);
            this.btnabsence.MouseLeave += new System.EventHandler(this.btnabsence_MouseLeave);
            // 
            // btndisturbance
            // 
            this.btndisturbance.BackColor = System.Drawing.Color.RosyBrown;
            this.btndisturbance.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndisturbance.ForeColor = System.Drawing.Color.White;
            this.btndisturbance.Location = new System.Drawing.Point(22, 268);
            this.btndisturbance.Name = "btndisturbance";
            this.btndisturbance.Size = new System.Drawing.Size(245, 36);
            this.btndisturbance.TabIndex = 6;
            this.btndisturbance.Text = "Add Disturbance";
            this.btndisturbance.UseVisualStyleBackColor = false;
            this.btndisturbance.Click += new System.EventHandler(this.btndisturbance_Click);
            this.btndisturbance.MouseEnter += new System.EventHandler(this.btndisturbance_MouseEnter);
            this.btndisturbance.MouseLeave += new System.EventHandler(this.btndisturbance_MouseLeave);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.RosyBrown;
            this.btnAdd.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(22, 220);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(245, 36);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add Grade";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            this.btnAdd.MouseEnter += new System.EventHandler(this.btnAdd_MouseEnter);
            this.btnAdd.MouseLeave += new System.EventHandler(this.btnAdd_MouseLeave);
            // 
            // txtboxgrade
            // 
            this.txtboxgrade.Location = new System.Drawing.Point(116, 161);
            this.txtboxgrade.Name = "txtboxgrade";
            this.txtboxgrade.Size = new System.Drawing.Size(64, 20);
            this.txtboxgrade.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RosyBrown;
            this.label1.Location = new System.Drawing.Point(18, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 23);
            this.label1.TabIndex = 38;
            this.label1.Text = "Grade";
            // 
            // lblgender
            // 
            this.lblgender.AutoSize = true;
            this.lblgender.BackColor = System.Drawing.Color.White;
            this.lblgender.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgender.ForeColor = System.Drawing.Color.RosyBrown;
            this.lblgender.Location = new System.Drawing.Point(15, 120);
            this.lblgender.Name = "lblgender";
            this.lblgender.Size = new System.Drawing.Size(59, 23);
            this.lblgender.TabIndex = 36;
            this.lblgender.Text = "Class";
            // 
            // comboClass
            // 
            this.comboClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboClass.FormattingEnabled = true;
            this.comboClass.Items.AddRange(new object[] {
            "Math",
            "English",
            "Hebrew"});
            this.comboClass.Location = new System.Drawing.Point(116, 125);
            this.comboClass.Name = "comboClass";
            this.comboClass.Size = new System.Drawing.Size(140, 21);
            this.comboClass.TabIndex = 3;
            // 
            // txtboxName
            // 
            this.txtboxName.Location = new System.Drawing.Point(116, 78);
            this.txtboxName.Name = "txtboxName";
            this.txtboxName.Size = new System.Drawing.Size(237, 20);
            this.txtboxName.TabIndex = 2;
            // 
            // txtboxid
            // 
            this.txtboxid.Location = new System.Drawing.Point(116, 37);
            this.txtboxid.Name = "txtboxid";
            this.txtboxid.Size = new System.Drawing.Size(237, 20);
            this.txtboxid.TabIndex = 1;
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.BackColor = System.Drawing.Color.White;
            this.lblname.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.ForeColor = System.Drawing.Color.RosyBrown;
            this.lblname.Location = new System.Drawing.Point(15, 75);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(67, 23);
            this.lblname.TabIndex = 33;
            this.lblname.Text = "Name";
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.BackColor = System.Drawing.Color.White;
            this.lblid.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblid.ForeColor = System.Drawing.Color.RosyBrown;
            this.lblid.Location = new System.Drawing.Point(17, 37);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(28, 23);
            this.lblid.TabIndex = 32;
            this.lblid.Text = "ID";
            // 
            // picturehomeEmployee
            // 
            this.picturehomeEmployee.Image = global::FinalProjectC_.Properties.Resources._2;
            this.picturehomeEmployee.Location = new System.Drawing.Point(12, 7);
            this.picturehomeEmployee.Name = "picturehomeEmployee";
            this.picturehomeEmployee.Size = new System.Drawing.Size(76, 56);
            this.picturehomeEmployee.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picturehomeEmployee.TabIndex = 27;
            this.picturehomeEmployee.TabStop = false;
            this.picturehomeEmployee.Click += new System.EventHandler(this.picturehomeEmployee_Click);
            // 
            // lblLoadingScreen
            // 
            this.lblLoadingScreen.AutoSize = true;
            this.lblLoadingScreen.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoadingScreen.ForeColor = System.Drawing.Color.White;
            this.lblLoadingScreen.Location = new System.Drawing.Point(116, 21);
            this.lblLoadingScreen.Name = "lblLoadingScreen";
            this.lblLoadingScreen.Size = new System.Drawing.Size(394, 42);
            this.lblLoadingScreen.TabIndex = 28;
            this.lblLoadingScreen.Text = "Student management";
            // 
            // PictureExit
            // 
            this.PictureExit.Image = global::FinalProjectC_.Properties.Resources._1;
            this.PictureExit.Location = new System.Drawing.Point(865, 12);
            this.PictureExit.Name = "PictureExit";
            this.PictureExit.Size = new System.Drawing.Size(58, 40);
            this.PictureExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureExit.TabIndex = 29;
            this.PictureExit.TabStop = false;
            this.PictureExit.Click += new System.EventHandler(this.PictureExit_Click);
            // 
            // lblClock
            // 
            this.lblClock.AutoSize = true;
            this.lblClock.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblClock.ForeColor = System.Drawing.Color.White;
            this.lblClock.Location = new System.Drawing.Point(7, 448);
            this.lblClock.Name = "lblClock";
            this.lblClock.Size = new System.Drawing.Size(68, 25);
            this.lblClock.TabIndex = 43;
            this.lblClock.Text = "clock";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.RosyBrown;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(865, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 15);
            this.label6.TabIndex = 45;
            this.label6.Text = "Exit&&Save";
            // 
            // FormStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(935, 479);
            this.Controls.Add(this.label6);
            this.Controls.Add(label5);
            this.Controls.Add(this.lblClock);
            this.Controls.Add(this.PictureExit);
            this.Controls.Add(this.lblLoadingScreen);
            this.Controls.Add(this.picturehomeEmployee);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormStudent";
            this.Load += new System.EventHandler(this.FormStudent_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudentgrades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturehomeEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureExit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picturehomeEmployee;
        private System.Windows.Forms.Label lblLoadingScreen;
        private System.Windows.Forms.PictureBox PictureExit;
        private System.Windows.Forms.TextBox txtboxName;
        private System.Windows.Forms.TextBox txtboxid;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Label lblgender;
        private System.Windows.Forms.ComboBox comboClass;
        private System.Windows.Forms.TextBox txtboxgrade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnabsence;
        private System.Windows.Forms.Button btndisturbance;
        private System.Windows.Forms.DataGridView dataGridViewStudentgrades;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn avarageMath;
        private System.Windows.Forms.DataGridViewTextBoxColumn AVGENG;
        private System.Windows.Forms.DataGridViewTextBoxColumn AVGHEB;
        private System.Windows.Forms.Label lblClock;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label6;
    }
}
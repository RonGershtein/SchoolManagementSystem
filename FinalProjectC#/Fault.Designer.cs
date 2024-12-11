namespace FinalProjectC_
{
    partial class Fault
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPrint = new System.Windows.Forms.Button();
            this.txtboxlocation = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtboxdescription = new System.Windows.Forms.TextBox();
            this.lblFaulName = new System.Windows.Forms.Label();
            this.dataGridViewFault = new System.Windows.Forms.DataGridView();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.picturehomeEmployee = new System.Windows.Forms.PictureBox();
            this.lblLoadingScreen = new System.Windows.Forms.Label();
            this.PictureExit = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblClock = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFault)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturehomeEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureExit)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnPrint);
            this.panel1.Controls.Add(this.txtboxlocation);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.txtboxdescription);
            this.panel1.Controls.Add(this.lblFaulName);
            this.panel1.Controls.Add(this.dataGridViewFault);
            this.panel1.Location = new System.Drawing.Point(0, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1305, 537);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.RosyBrown;
            this.btnPrint.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Location = new System.Drawing.Point(475, 499);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(113, 35);
            this.btnPrint.TabIndex = 30;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // txtboxlocation
            // 
            this.txtboxlocation.Location = new System.Drawing.Point(150, 65);
            this.txtboxlocation.Name = "txtboxlocation";
            this.txtboxlocation.Size = new System.Drawing.Size(438, 20);
            this.txtboxlocation.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RosyBrown;
            this.label1.Location = new System.Drawing.Point(21, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 23);
            this.label1.TabIndex = 29;
            this.label1.Text = "Location";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.RosyBrown;
            this.btnClear.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(223, 105);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(167, 36);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            this.btnClear.MouseEnter += new System.EventHandler(this.btnClear_MouseEnter);
            this.btnClear.MouseLeave += new System.EventHandler(this.btnClear_MouseLeave);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.RosyBrown;
            this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(421, 105);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(167, 36);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            this.btnDelete.MouseEnter += new System.EventHandler(this.btnDelete_MouseEnter);
            this.btnDelete.MouseLeave += new System.EventHandler(this.btnDelete_MouseLeave);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.RosyBrown;
            this.btnAdd.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(25, 105);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(167, 36);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            this.btnAdd.MouseEnter += new System.EventHandler(this.btnAdd_MouseEnter);
            this.btnAdd.MouseLeave += new System.EventHandler(this.btnAdd_MouseLeave);
            // 
            // txtboxdescription
            // 
            this.txtboxdescription.Location = new System.Drawing.Point(150, 27);
            this.txtboxdescription.Name = "txtboxdescription";
            this.txtboxdescription.Size = new System.Drawing.Size(438, 20);
            this.txtboxdescription.TabIndex = 1;
            // 
            // lblFaulName
            // 
            this.lblFaulName.AutoSize = true;
            this.lblFaulName.BackColor = System.Drawing.Color.White;
            this.lblFaulName.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFaulName.ForeColor = System.Drawing.Color.RosyBrown;
            this.lblFaulName.Location = new System.Drawing.Point(21, 24);
            this.lblFaulName.Name = "lblFaulName";
            this.lblFaulName.Size = new System.Drawing.Size(113, 23);
            this.lblFaulName.TabIndex = 9;
            this.lblFaulName.Text = "Description";
            // 
            // dataGridViewFault
            // 
            this.dataGridViewFault.AllowUserToAddRows = false;
            this.dataGridViewFault.AllowUserToDeleteRows = false;
            this.dataGridViewFault.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewFault.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFault.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Description,
            this.location});
            this.dataGridViewFault.Location = new System.Drawing.Point(25, 147);
            this.dataGridViewFault.Name = "dataGridViewFault";
            this.dataGridViewFault.ReadOnly = true;
            this.dataGridViewFault.Size = new System.Drawing.Size(563, 346);
            this.dataGridViewFault.TabIndex = 0;
            // 
            // Description
            // 
            this.Description.DataPropertyName = "description";
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // location
            // 
            this.location.DataPropertyName = "location";
            this.location.HeaderText = "Location";
            this.location.Name = "location";
            this.location.ReadOnly = true;
            // 
            // picturehomeEmployee
            // 
            this.picturehomeEmployee.Image = global::FinalProjectC_.Properties.Resources._2;
            this.picturehomeEmployee.Location = new System.Drawing.Point(12, 6);
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
            this.lblLoadingScreen.Location = new System.Drawing.Point(119, 15);
            this.lblLoadingScreen.Name = "lblLoadingScreen";
            this.lblLoadingScreen.Size = new System.Drawing.Size(344, 42);
            this.lblLoadingScreen.TabIndex = 28;
            this.lblLoadingScreen.Text = "Fault management";
            // 
            // PictureExit
            // 
            this.PictureExit.Image = global::FinalProjectC_.Properties.Resources._1;
            this.PictureExit.Location = new System.Drawing.Point(544, 6);
            this.PictureExit.Name = "PictureExit";
            this.PictureExit.Size = new System.Drawing.Size(58, 40);
            this.PictureExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureExit.TabIndex = 29;
            this.PictureExit.TabStop = false;
            this.PictureExit.Click += new System.EventHandler(this.PictureExit_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(364, 619);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(228, 25);
            this.label8.TabIndex = 30;
            this.label8.Text = "L&R Mangment System";
            // 
            // lblClock
            // 
            this.lblClock.AutoSize = true;
            this.lblClock.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblClock.ForeColor = System.Drawing.Color.White;
            this.lblClock.Location = new System.Drawing.Point(9, 619);
            this.lblClock.Name = "lblClock";
            this.lblClock.Size = new System.Drawing.Size(68, 25);
            this.lblClock.TabIndex = 31;
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
            this.label6.Location = new System.Drawing.Point(544, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 15);
            this.label6.TabIndex = 32;
            this.label6.Text = "Exit&&Save";
            // 
            // Fault
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(604, 656);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblClock);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.PictureExit);
            this.Controls.Add(this.lblLoadingScreen);
            this.Controls.Add(this.picturehomeEmployee);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Fault";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fault";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFault)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridViewFault;
        private System.Windows.Forms.TextBox txtboxdescription;
        private System.Windows.Forms.Label lblFaulName;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtboxlocation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn location;
        private System.Windows.Forms.Label lblClock;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Label label6;
    }
}
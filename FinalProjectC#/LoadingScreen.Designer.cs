namespace FinalProjectC_
{
    partial class FormLoadingScreen
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
            this.lblLoadingScreen = new System.Windows.Forms.Label();
            this.prograssbarLoading = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPrograssBarPrecent = new System.Windows.Forms.Label();
            this.tmrProgressBar = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLoadingScreen
            // 
            this.lblLoadingScreen.AutoSize = true;
            this.lblLoadingScreen.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoadingScreen.ForeColor = System.Drawing.Color.Black;
            this.lblLoadingScreen.Location = new System.Drawing.Point(117, 9);
            this.lblLoadingScreen.Name = "lblLoadingScreen";
            this.lblLoadingScreen.Size = new System.Drawing.Size(351, 32);
            this.lblLoadingScreen.TabIndex = 1;
            this.lblLoadingScreen.Text = "School Mangment System";
            // 
            // prograssbarLoading
            // 
            this.prograssbarLoading.Location = new System.Drawing.Point(12, 273);
            this.prograssbarLoading.Name = "prograssbarLoading";
            this.prograssbarLoading.Size = new System.Drawing.Size(576, 23);
            this.prograssbarLoading.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 245);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Loading System";
            // 
            // lblPrograssBarPrecent
            // 
            this.lblPrograssBarPrecent.AutoSize = true;
            this.lblPrograssBarPrecent.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrograssBarPrecent.ForeColor = System.Drawing.Color.White;
            this.lblPrograssBarPrecent.Location = new System.Drawing.Point(561, 249);
            this.lblPrograssBarPrecent.Name = "lblPrograssBarPrecent";
            this.lblPrograssBarPrecent.Size = new System.Drawing.Size(22, 21);
            this.lblPrograssBarPrecent.TabIndex = 4;
            this.lblPrograssBarPrecent.Text = "%";
            // 
            // tmrProgressBar
            // 
            this.tmrProgressBar.Enabled = true;
            this.tmrProgressBar.Interval = 50;
            this.tmrProgressBar.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FinalProjectC_.Properties.Resources._11;
            this.pictureBox1.Location = new System.Drawing.Point(12, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(563, 174);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FormLoadingScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(600, 335);
            this.Controls.Add(this.lblPrograssBarPrecent);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.prograssbarLoading);
            this.Controls.Add(this.lblLoadingScreen);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FormLoadingScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblLoadingScreen;
        private System.Windows.Forms.ProgressBar prograssbarLoading;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPrograssBarPrecent;
        private System.Windows.Forms.Timer tmrProgressBar;
    }
}


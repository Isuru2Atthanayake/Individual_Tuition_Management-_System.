namespace Individual_tuition_mgtsystem
{
    partial class welcome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(welcome));
            this.lblexit = new System.Windows.Forms.Label();
            this.dtptoday = new System.Windows.Forms.DateTimePicker();
            this.lblenter = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnteacher = new System.Windows.Forms.Button();
            this.btnstudent = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblexit
            // 
            this.lblexit.AutoSize = true;
            this.lblexit.BackColor = System.Drawing.Color.Transparent;
            this.lblexit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblexit.Location = new System.Drawing.Point(905, 522);
            this.lblexit.Name = "lblexit";
            this.lblexit.Size = new System.Drawing.Size(74, 39);
            this.lblexit.TabIndex = 9;
            this.lblexit.Text = "Exit";
            this.lblexit.Click += new System.EventHandler(this.lblexit_Click);
            // 
            // dtptoday
            // 
            this.dtptoday.CalendarMonthBackground = System.Drawing.SystemColors.MenuHighlight;
            this.dtptoday.CalendarTitleBackColor = System.Drawing.Color.Transparent;
            this.dtptoday.Font = new System.Drawing.Font("Lucida Console", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtptoday.Location = new System.Drawing.Point(50, 602);
            this.dtptoday.Name = "dtptoday";
            this.dtptoday.Size = new System.Drawing.Size(305, 24);
            this.dtptoday.TabIndex = 8;
            // 
            // lblenter
            // 
            this.lblenter.AutoSize = true;
            this.lblenter.BackColor = System.Drawing.Color.Transparent;
            this.lblenter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblenter.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblenter.Location = new System.Drawing.Point(534, 289);
            this.lblenter.Name = "lblenter";
            this.lblenter.Size = new System.Drawing.Size(145, 58);
            this.lblenter.TabIndex = 7;
            this.lblenter.Text = "Enter";
            this.lblenter.Click += new System.EventHandler(this.lblenter_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Old English Text MT", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(441, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(340, 40);
            this.label2.TabIndex = 6;
            this.label2.Text = "Private Tiution system";
            // 
            // label1
            // 
            this.label1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(350, 101);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(574, 115);
            this.label1.TabIndex = 5;
            this.label1.Text = "WELCOME";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnteacher
            // 
            this.btnteacher.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnteacher.Font = new System.Drawing.Font("Adobe Gothic Std B", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnteacher.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnteacher.Location = new System.Drawing.Point(350, 425);
            this.btnteacher.Name = "btnteacher";
            this.btnteacher.Size = new System.Drawing.Size(167, 51);
            this.btnteacher.TabIndex = 11;
            this.btnteacher.Text = "TEACHER";
            this.btnteacher.UseVisualStyleBackColor = false;
            this.btnteacher.Click += new System.EventHandler(this.btnteacher_Click);
            // 
            // btnstudent
            // 
            this.btnstudent.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnstudent.Font = new System.Drawing.Font("Adobe Gothic Std B", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnstudent.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnstudent.Location = new System.Drawing.Point(747, 425);
            this.btnstudent.Name = "btnstudent";
            this.btnstudent.Size = new System.Drawing.Size(177, 51);
            this.btnstudent.TabIndex = 12;
            this.btnstudent.Text = "STUDENT";
            this.btnstudent.UseVisualStyleBackColor = false;
            this.btnstudent.Click += new System.EventHandler(this.btnstudent_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(12, 643);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(455, 28);
            this.label3.TabIndex = 13;
            this.label3.Text = "AllRightsReserved@IsuruAtthanayake";
            // 
            // welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1152, 680);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnstudent);
            this.Controls.Add(this.btnteacher);
            this.Controls.Add(this.lblexit);
            this.Controls.Add(this.dtptoday);
            this.Controls.Add(this.lblenter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.Name = "welcome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "welcome";
            this.Load += new System.EventHandler(this.welcome_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblexit;
        private System.Windows.Forms.DateTimePicker dtptoday;
        private System.Windows.Forms.Label lblenter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnteacher;
        private System.Windows.Forms.Button btnstudent;
        private System.Windows.Forms.Label label3;
    }
}
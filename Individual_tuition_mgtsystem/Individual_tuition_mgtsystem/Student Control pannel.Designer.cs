namespace Individual_tuition_mgtsystem
{
    partial class Student_Control_pannel
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
            this.btnleave = new System.Windows.Forms.Button();
            this.btnsearch = new System.Windows.Forms.Button();
            this.btnpay = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnleave
            // 
            this.btnleave.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnleave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnleave.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnleave.ForeColor = System.Drawing.Color.LawnGreen;
            this.btnleave.Location = new System.Drawing.Point(148, 103);
            this.btnleave.Name = "btnleave";
            this.btnleave.Size = new System.Drawing.Size(608, 60);
            this.btnleave.TabIndex = 0;
            this.btnleave.Text = "Requesting a Leave";
            this.btnleave.UseVisualStyleBackColor = false;
            this.btnleave.Click += new System.EventHandler(this.btnleave_Click);
            // 
            // btnsearch
            // 
            this.btnsearch.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnsearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsearch.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsearch.ForeColor = System.Drawing.Color.LawnGreen;
            this.btnsearch.Location = new System.Drawing.Point(151, 206);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(605, 60);
            this.btnsearch.TabIndex = 1;
            this.btnsearch.Text = "Search by ID";
            this.btnsearch.UseVisualStyleBackColor = false;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // btnpay
            // 
            this.btnpay.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnpay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnpay.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpay.ForeColor = System.Drawing.Color.LawnGreen;
            this.btnpay.Location = new System.Drawing.Point(148, 304);
            this.btnpay.Name = "btnpay";
            this.btnpay.Size = new System.Drawing.Size(606, 64);
            this.btnpay.TabIndex = 2;
            this.btnpay.Text = "Payment";
            this.btnpay.UseVisualStyleBackColor = false;
            this.btnpay.Click += new System.EventHandler(this.btnpay_Click);
            // 
            // btnback
            // 
            this.btnback.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnback.ForeColor = System.Drawing.Color.GreenYellow;
            this.btnback.Location = new System.Drawing.Point(762, 505);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(97, 43);
            this.btnback.TabIndex = 4;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Aqua;
            this.button1.Location = new System.Drawing.Point(760, 437);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 43);
            this.button1.TabIndex = 5;
            this.button1.Text = "Instructions";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Student_Control_pannel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(881, 560);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.btnpay);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.btnleave);
            this.MaximizeBox = false;
            this.Name = "Student_Control_pannel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student_Control_pannel";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnleave;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.Button btnpay;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Button button1;
    }
}
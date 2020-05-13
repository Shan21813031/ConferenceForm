namespace ConferenceForm
{
    partial class Totals
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Totals));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NumOfTeachers = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BWStat = new System.Windows.Forms.Label();
            this.SEStat = new System.Windows.Forms.Label();
            this.WSStat = new System.Windows.Forms.Label();
            this.Revenue = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.NumOfTeachers);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(46, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(268, 71);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Number of attendants";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.WSStat);
            this.groupBox2.Controls.Add(this.SEStat);
            this.groupBox2.Controls.Add(this.BWStat);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(46, 149);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(268, 169);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "School Statistics";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.Revenue);
            this.groupBox4.Location = new System.Drawing.Point(46, 324);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(268, 84);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Total Bills";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(416, 350);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 41);
            this.button1.TabIndex = 3;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(380, 54);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(205, 240);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number of Teachers:";
            // 
            // NumOfTeachers
            // 
            this.NumOfTeachers.BackColor = System.Drawing.SystemColors.Window;
            this.NumOfTeachers.Location = new System.Drawing.Point(165, 28);
            this.NumOfTeachers.Name = "NumOfTeachers";
            this.NumOfTeachers.Size = new System.Drawing.Size(80, 23);
            this.NumOfTeachers.TabIndex = 1;
            this.NumOfTeachers.Click += new System.EventHandler(this.NumOfTeachers_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "From Beechwood School:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "From SE School:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "From Wexham School:";
            // 
            // BWStat
            // 
            this.BWStat.BackColor = System.Drawing.SystemColors.Window;
            this.BWStat.Location = new System.Drawing.Point(22, 48);
            this.BWStat.Name = "BWStat";
            this.BWStat.Size = new System.Drawing.Size(100, 23);
            this.BWStat.TabIndex = 3;
            // 
            // SEStat
            // 
            this.SEStat.BackColor = System.Drawing.SystemColors.Window;
            this.SEStat.Location = new System.Drawing.Point(22, 94);
            this.SEStat.Name = "SEStat";
            this.SEStat.Size = new System.Drawing.Size(100, 23);
            this.SEStat.TabIndex = 4;
            // 
            // WSStat
            // 
            this.WSStat.BackColor = System.Drawing.SystemColors.Window;
            this.WSStat.Location = new System.Drawing.Point(22, 137);
            this.WSStat.Name = "WSStat";
            this.WSStat.Size = new System.Drawing.Size(100, 23);
            this.WSStat.TabIndex = 5;
            // 
            // Revenue
            // 
            this.Revenue.BackColor = System.Drawing.SystemColors.Window;
            this.Revenue.Location = new System.Drawing.Point(19, 26);
            this.Revenue.Name = "Revenue";
            this.Revenue.Size = new System.Drawing.Size(168, 23);
            this.Revenue.TabIndex = 0;
            // 
            // Totals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Totals";
            this.Text = "Totals";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label NumOfTeachers;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label WSStat;
        public System.Windows.Forms.Label SEStat;
        public System.Windows.Forms.Label BWStat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label Revenue;
    }
}
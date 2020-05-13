namespace ConferenceForm
{
    partial class Bill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bill));
            this.Greetings = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.LunchList = new System.Windows.Forms.ListBox();
            this.DinnerList = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.TotalBill = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Accept = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Greetings
            // 
            this.Greetings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Greetings.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.Greetings.Location = new System.Drawing.Point(27, 18);
            this.Greetings.Name = "Greetings";
            this.Greetings.Size = new System.Drawing.Size(478, 63);
            this.Greetings.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.Greetings);
            this.groupBox1.Location = new System.Drawing.Point(32, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(533, 103);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.LunchList);
            this.groupBox2.Controls.Add(this.DinnerList);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(32, 179);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(448, 90);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Options";
            // 
            // LunchList
            // 
            this.LunchList.FormattingEnabled = true;
            this.LunchList.ItemHeight = 16;
            this.LunchList.Items.AddRange(new object[] {
            "Caesar Salad",
            "Chilli Fish Cakes",
            "Chicken Soup",
            "Prawn Club Sandwich"});
            this.LunchList.Location = new System.Drawing.Point(215, 35);
            this.LunchList.Name = "LunchList";
            this.LunchList.Size = new System.Drawing.Size(176, 36);
            this.LunchList.TabIndex = 1;
            this.LunchList.SelectedIndexChanged += new System.EventHandler(this.LunchList_SelectedIndexChanged);
            // 
            // DinnerList
            // 
            this.DinnerList.FormattingEnabled = true;
            this.DinnerList.ItemHeight = 16;
            this.DinnerList.Items.AddRange(new object[] {
            "Chicken Curry",
            "Beef Lasagna",
            "Shawarma",
            "Steak and Fries"});
            this.DinnerList.Location = new System.Drawing.Point(15, 35);
            this.DinnerList.Name = "DinnerList";
            this.DinnerList.Size = new System.Drawing.Size(161, 36);
            this.DinnerList.TabIndex = 0;
            this.DinnerList.SelectedIndexChanged += new System.EventHandler(this.DinnerList_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.TotalBill);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(32, 325);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(344, 73);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Total Bill";
            // 
            // TotalBill
            // 
            this.TotalBill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.TotalBill.ForeColor = System.Drawing.Color.Black;
            this.TotalBill.Location = new System.Drawing.Point(15, 22);
            this.TotalBill.Name = "TotalBill";
            this.TotalBill.Size = new System.Drawing.Size(311, 36);
            this.TotalBill.TabIndex = 0;
            this.TotalBill.Click += new System.EventHandler(this.TotalBill_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Dinner:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(275, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Lunch:";
            // 
            // Accept
            // 
            this.Accept.Location = new System.Drawing.Point(445, 325);
            this.Accept.Name = "Accept";
            this.Accept.Size = new System.Drawing.Size(106, 34);
            this.Accept.TabIndex = 4;
            this.Accept.Text = "Accept Bill";
            this.Accept.UseVisualStyleBackColor = true;
            this.Accept.Click += new System.EventHandler(this.Accept_Click);
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(445, 365);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(106, 34);
            this.Back.TabIndex = 5;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Bill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(610, 450);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Accept);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Bill";
            this.Text = "Bill Form";
            this.Load += new System.EventHandler(this.Bill_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Label Greetings;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.ListBox DinnerList;
        public System.Windows.Forms.ListBox LunchList;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label TotalBill;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Accept;
        private System.Windows.Forms.Button Back;
    }
}
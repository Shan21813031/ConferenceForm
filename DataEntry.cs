using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConferenceForm
{
    /// <summary>
    /// Task 4.7 - 4.9
    /// Below is a multiform application used by attendees to fill out details
    /// regarding which school they're from, their names, the dinner and/or lunch options they would
    /// prefer to opt for. It is also a form for University staff to view statistics of the conference.
    /// Author: Shan Ahmed 21813031
    /// </summary>
    public partial class Form1 : Form
    {
        public double totalDelegates = 0, totalBeechwood = 0, totalSESchool = 0, totalWexham = 0, totalRevenue = 0;

        /// <summary>
        /// Below increments school statistics by 1
        /// </summary>

        private void Schools_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (Schools.Text)
            {
                case "Beechwood School": totalBeechwood++; break;
                case "Wexham School": totalWexham++; break;
                case "Slough & EtonSchool": totalSESchool++; break;
            }

        }

        /// <summary>
        /// below values are sent to "totals" form
        /// </summary>

        private void button3_Click(object sender, EventArgs e)
        {
            Totals TotalForm = new Totals();
            TotalForm.NumOfTeachers.Text = totalDelegates.ToString();
            TotalForm.BWStat.Text = totalBeechwood.ToString();
            TotalForm.SEStat.Text = totalSESchool.ToString();
            TotalForm.WSStat.Text = totalWexham.ToString();
            TotalForm.Revenue.Text = totalRevenue.ToString();
            TotalForm.ShowDialog();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// attendee is shown options for lunch and/or dinner depending on what they choose otherwise they don't.
        /// </summary>

        private void button2_Click(object sender, EventArgs e)
        {
            Bill BillForm = new Bill();
            BillForm.Show();
            if (Lunch.Checked)
            {
                BillForm.LunchList.Show();
            }
            else
            {
                BillForm.LunchList.Hide();
            }
            if (Dinner.Checked)
            {
                BillForm.DinnerList.Show();
            }
            else
            {
                BillForm.DinnerList.Hide();
            }

            BillForm.Greetings.Text = "Hello " + Name.Text + " of " + Schools.Text + " !";
        }

        private void Lunch_CheckedChanged(object sender, EventArgs e)
        {
        }
    }
}

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
    /// In this form, the main calculation of each teachers bill is completed
    /// </summary>
    public partial class Bill : Form
    {
        public double LunchCost = 0, DinnerCost = 0, TotalCost = 0, EntryCharge = 50;
        public Bill()
        {
            InitializeComponent();
        }

        private void DinnerList_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (DinnerList.Text)
            {
                case "Chicken Curry": DinnerCost = 15.00; break;
                case "Beef Lasagna": DinnerCost = 15.00; break;
                case "Shawarma": DinnerCost = 15.00; break;
                case "Steak and Fries": DinnerCost = 15.00; break;
            }

            TotalCost = LunchCost + DinnerCost + EntryCharge;
            TotalBill.Text = TotalCost.ToString();

        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Accept_Click(object sender, EventArgs e)
        {
            Confirm Confirmation = new Confirm();
            Confirmation.Show();
        }

        private void LunchList_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (LunchList.Text)
            {
                case "Caesar Salad": LunchCost = 10.00; break;
                case "Chilli Fish Cakes": LunchCost = 10.00; break;
                case "Chicken Soup": LunchCost = 10.00; break;
                case "Prawn Club Sandwich": LunchCost = 10.00; break;
            }

            TotalCost = LunchCost + DinnerCost + EntryCharge;
            TotalBill.Text = TotalCost.ToString();
        }

        private void Bill_Load(object sender, EventArgs e)
        {

        }

        private void TotalBill_Click(object sender, EventArgs e)
        {

        }
    }
}

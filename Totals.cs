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
    /// Displays data gathered in DataEntry form
    /// </summary>
    public partial class Totals : Form
    {
        public Totals()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NumOfTeachers_Click(object sender, EventArgs e)
        {
            
        }
    }
}

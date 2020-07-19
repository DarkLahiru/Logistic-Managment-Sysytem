using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ceylon_petroleum
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void dailyInputToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TransDaily Daily = new TransDaily();
            Daily.Show();
        }
        private void monthlyInputToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TransMonthly Monthly = new TransMonthly();
            Monthly.Show();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void dailyInputToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            TransDaily Daily = new TransDaily();
            Daily.Show();
        }

        private void monthlyIncomeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TransMonthly Monthly = new TransMonthly();
            Monthly.Show();
        }

        private void otherExpenditureToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void monthlyIcomeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void transpotationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Revenue Monthly = new Revenue();
            Monthly.Show();
        }

        private void licenceDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            emp.Show();
        }
    }
}

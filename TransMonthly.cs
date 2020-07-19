using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using MySql.Data.MySqlClient;

namespace ceylon_petroleum
{
    public partial class TransMonthly : Form
    {
        public TransMonthly()
        {
            InitializeComponent();
            LoadDataIntoDataGridView();
        }

        private void TransMonthly_Load(object sender, EventArgs e)
        {

        }
        private void LoadDataIntoDataGridView()
        {
           /* MySqlConnection con = new MySqlConnection("datasource=127.0.0.1;port=3306;database=username;username=root;password=;");

            // MySqlCommand cmd = null;
            //string cmdString = "";
            //MySqlConnection con = new MySqlConnection(AppSettings.ConnectionString());
            con.Open();

            MySqlCommand cmd;
            cmd = con.CreateCommand();
            cmd.CommandText = "Select * from transportation";

            MySqlDataReader sdr = cmd.ExecuteReader();
            DataTable dtRecords = new DataTable();
            dtRecords.Load(sdr);

            dataGridView1.DataSource = dtRecords;*/
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

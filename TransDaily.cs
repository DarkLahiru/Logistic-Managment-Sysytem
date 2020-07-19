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
    public partial class TransDaily : Form
    {
        public TransDaily()
        {
            InitializeComponent();
            //LoadDataIntoDataGridView();
        }

       /* private void LoadDataIntoDataGridView()
        {
            MySqlConnection con = new MySqlConnection("datasource=127.0.0.1;port=3306;database=username;username=root;password=;");

            // MySqlCommand cmd = null;
            string cmdString = "";
            //MySqlConnection con = new MySqlConnection(AppSettings.ConnectionString());
            con.Open();

            MySqlCommand cmd;
            cmd = con.CreateCommand();
            cmd.CommandText = "Select * from user";

            MySqlDataReader sdr = cmd.ExecuteReader();
            DataTable dtRecords = new DataTable();
            dtRecords.Load(sdr);

            dataGridView1.DataSource = dtRecords;
        }*/

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*Int64 Id = Int64.Parse(textBox1.Text);
            string date = dateTimePicker1.Text;
            string month = comboBox2.Text;
            string tripe = textBox3.Text;
            string bowsertype = comboBox1.Text;
            float low = float.Parse(textBox5.Text);
            float up = float.Parse(textBox4.Text);
            float netamount =float.Parse(textBox8.Text);
            float paybleamount =float.Parse(textBox7.Text);

            dataGridView1.Rows.Add(dateTimePicker1.Text, comboBox2.Text, textBox3.Text, comboBox1.Text, textBox5.Text, textBox4.Text,textBox8.Text, textBox7.Text );
            MySqlConnection cnn = new MySqlConnection("datasource=127.0.0.1;port=3306;database=username;username=root;password=;");

            MySqlCommand cmd = null;
            string cmdString = "";
            cnn.Open();

            cmdString = "insert into transportation(Transaction_Id,Date,Month,Tripe,Bowser_Type,Low_Km,Up_Km,Net_Amount,Payble_Amount)values('"+Id+"','" +date+ "','" +month+ "','" +tripe+ "','"+bowsertype+ "','"+low+ "','"+up+ "','"+netamount+ "','"+paybleamount+ "')";

            cmd = new MySqlCommand(cmdString, cnn);
            cmd.ExecuteNonQuery();

            cnn.Close();

            MessageBox.Show("Data Stored Successfully");*/
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*Me.CenterToScreen();
            if connection.State=ConnectionState.Open Then
                    connection.Close();
            End if
                connecton.Open();
            Dis.data();*/

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Multiply();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /* private void Multiply()
         {
             if (comboBox1.Text == "66000 Litres")
             {
                 float a, b;

                 bool isAValid = float.TryParse(textBox5.Text, out a);
                 bool isBValid = float.TryParse(textBox4.Text, out b);

                 if (isAValid && isBValid)
                     textBox8.Text = ((a * 110) + (b * 100)).ToString();
                 else
                     textBox8.Text = "Invalid input";
             }
             else
             {
                 float a, b;

                 bool isAValid = float.TryParse(textBox5.Text, out a);
                 bool isBValid = float.TryParse(textBox4.Text, out b);

                 if (isAValid && isBValid)
                     textBox8.Text = ((a * 2) + (b * 10)).ToString();
                 else
                     textBox8.Text = "Invalid input";

             }
         }*/
    }
}

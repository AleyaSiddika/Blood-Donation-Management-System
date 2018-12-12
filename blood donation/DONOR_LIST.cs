using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace blood_donation
{
    public partial class DONOR_LIST : Form
    {
        public DONOR_LIST()
        {
            InitializeComponent();
        }
        string[] tableNames = {"ALL"};
        OleDbConnection con = new OleDbConnection("Provider =OraOLEDB.Oracle; Data Source =DESKTOP-CAPDTNP:1521; User Id = system; Password = tiger");
        OleDbConnection con1 = new OleDbConnection();
        //OleDbDataAdapter odapter;
      // DataSet ds;


        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            HOMEPAGE newForm1 = new HOMEPAGE();
            newForm1.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DONOR_LIST newForm2 = new DONOR_LIST();
            newForm2.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            BE_A_DONOR newForm3 = new BE_A_DONOR();
            newForm3.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            LOGIN newForm5 = new LOGIN();
            newForm5.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            con.Open();
            if (comboBox1.SelectedItem.ToString() == "ALL")
            {
                OleDbDataAdapter oda = new OleDbDataAdapter("select * FROM DONOR", con);
                DataTable dt = new DataTable();
                oda.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }

            

            else
            {
                MessageBox.Show("Please Choose");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            RULES newRULES = new RULES();
            newRULES.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SEARCH newForm5 = new SEARCH();
            newForm5.Show();
            this.Hide();
        }
    }
}

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
    public partial class LOGIN : Form
    {
        public LOGIN()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection("Provider =OraOLEDB.Oracle; Data Source =DESKTOP-CAPDTNP:1521; User Id = system; Password = tiger");

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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
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
            OleDbDataAdapter oda = new OleDbDataAdapter("select user_name, password from login where user_name = '" + textBox1.Text + "'and password = '" + textBox2.Text + "'", con);
            DataTable dt = new DataTable();
            oda.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Login sucess Welcome to Homepage");
                this.Hide();
                profile newprofile = new profile();
                newprofile.Show();
            }
            else
            {
                MessageBox.Show("Invalid Login please check username and password");
            }
            con.Close();

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FORGOT_PASSWORD newForm5 = new FORGOT_PASSWORD();
            newForm5.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
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
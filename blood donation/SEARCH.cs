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
    public partial class SEARCH : Form
    {
        public SEARCH()
        {
            InitializeComponent();
        }
        string[] tableNames = {"A+ (A positive)",
                                  "A- (A negative)",
                                  "B+ (B positive)",
                                  "B- (B negative)",
                                  "O+ (O positive)",
                                  "O- (O negative)",
                                  "AB+ (AB positive)",
                                  "AB- (AB negative)"};
        OleDbConnection con = new OleDbConnection("Provider =OraOLEDB.Oracle; Data Source =DESKTOP-CAPDTNP:1521; User Id = system; Password = tiger");
        OleDbConnection con1 = new OleDbConnection();
        OleDbDataAdapter odapter;
        DataSet ds;
        private void label1_Click(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
            SEARCH newForm5 = new SEARCH();
            newForm5.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RULES newRULES = new RULES();
            newRULES.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            con.Open();
            if (comboBox1.SelectedItem.ToString() == "A+ (A positive)")
            {
                OleDbDataAdapter oda = new OleDbDataAdapter("select ID,DONOR_NAME,AGE,ADDRESS,SEX,PHONE_NUMBER,TYPE_OF_DONOR,LAST_DONATION_DATE from DONOR where BLOOD_GROUP='A+'", con);
                DataTable dt = new DataTable();
                oda.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            else if (comboBox1.SelectedItem.ToString() == "A- (A negative)")
            {
                OleDbDataAdapter oda = new OleDbDataAdapter("select ID,DONOR_NAME,AGE,ADDRESS,SEX,PHONE_NUMBER,TYPE_OF_DONOR,LAST_DONATION_DATE from DONOR where BLOOD_GROUP='A-'", con);
                DataTable dt = new DataTable();
                oda.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();

            }
            else if (comboBox1.SelectedItem.ToString() == "B+ (B positive)")
            {
                OleDbDataAdapter oda = new OleDbDataAdapter("select ID,DONOR_NAME,AGE,ADDRESS,SEX,PHONE_NUMBER,TYPE_OF_DONOR,LAST_DONATION_DATE from DONOR where BLOOD_GROUP='B+'", con);
                DataTable dt = new DataTable();
                oda.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();

            }
            else if (comboBox1.SelectedItem.ToString() == "B- (B negative)")
            {
                OleDbDataAdapter oda = new OleDbDataAdapter("select ID,DONOR_NAME,AGE,ADDRESS,SEX,PHONE_NUMBER,TYPE_OF_DONOR,LAST_DONATION_DATE from DONOR where BLOOD_GROUP='B-'", con);
                DataTable dt = new DataTable();
                oda.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            else if (comboBox1.SelectedItem.ToString() == "O+ (O positive)")
            {
                OleDbDataAdapter oda = new OleDbDataAdapter("select ID,DONOR_NAME,AGE,ADDRESS,SEX,PHONE_NUMBER,TYPE_OF_DONOR,LAST_DONATION_DATE from DONOR where BLOOD_GROUP='O+'", con);
                DataTable dt = new DataTable();
                oda.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            else if (comboBox1.SelectedItem.ToString() == "O- (O negative)")
            {
                OleDbDataAdapter oda = new OleDbDataAdapter("select ID,DONOR_NAME,AGE,ADDRESS,SEX,PHONE_NUMBER,TYPE_OF_DONOR,LAST_DONATION_DATE from DONOR where BLOOD_GROUP='O-'", con);
                DataTable dt = new DataTable();
                oda.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }

            else if (comboBox1.SelectedItem.ToString() == "AB+ (AB positive)")
            {
                OleDbDataAdapter oda = new OleDbDataAdapter("select ID,DONOR_NAME,AGE,ADDRESS,SEX,PHONE_NUMBER,TYPE_OF_DONOR,LAST_DONATION_DATE from DONOR where BLOOD_GROUP='AB+'", con);
                DataTable dt = new DataTable();
                oda.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }

            else if (comboBox1.SelectedItem.ToString() == "AB- (AB negative)")
            {
                OleDbDataAdapter oda = new OleDbDataAdapter("select ID,DONOR_NAME,AGE,ADDRESS,SEX,PHONE_NUMBER,TYPE_OF_DONOR,LAST_DONATION_DATE from DONOR where BLOOD_GROUP='AB-'", con);
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
    }
}

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
    public partial class BE_A_DONOR : Form
    {
        public BE_A_DONOR()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection("Provider =OraOLEDB.Oracle; Data Source =DESKTOP-CAPDTNP:1521; User Id = system; Password = tiger");

        private void button4_Click(object sender, EventArgs e)
        {
            DONOR_LIST newForm2 = new DONOR_LIST();
            newForm2.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HOMEPAGE newForm1 = new HOMEPAGE();
            newForm1.Show();
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
            OleDbDataAdapter oda = new OleDbDataAdapter("INSERT INTO DONOR VALUES(" + 111 + ",'" + textBox1.Text + "','" + textBox3.Text + "','" + textBox6.Text + "','" + textBox8.Text + "','" + textBox4.Text + "','A+','" + textBox9.Text + "','" + textBox7.Text + "')", con);
            OleDbDataAdapter odap = new OleDbDataAdapter("INSERT INTO LOGIN VALUES(" + 111 + ",'" + textBox1.Text + "','" + textBox2.Text + "','USER')", con);
            DataTable dt = new DataTable();
            oda.Fill(dt);
            odap.Fill(dt);
            /* OleDbDataAdapter odap = new OleDbDataAdapter("INSERT INTO LOGIN VALUES(" + 111 + ",'" + textBox1.Text + "','" + textBox2.Text + "','USER')", con);
             DataTable dtt = new DataTable();
             oda.Fill(dtt);*/
            MessageBox.Show("registration successful!!");
            con.Close();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbDataAdapter oda = new OleDbDataAdapter("INSERT INTO DONOR VALUES(" + 111 + ",'" + textBox1.Text + "','" + textBox3.Text + "','" + textBox6.Text + "','" + textBox8.Text + "','" + textBox4.Text + "','A-','" + textBox9.Text + "','" + textBox7.Text + "')", con);
            OleDbDataAdapter odap = new OleDbDataAdapter("INSERT INTO LOGIN VALUES(" + 111 + ",'" + textBox1.Text + "','" + textBox2.Text + "','USER')", con);
            DataTable dt = new DataTable();
            oda.Fill(dt);
            odap.Fill(dt);
            MessageBox.Show("registration successful!!");
            con.Close();

        }

        private void button9_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbDataAdapter oda = new OleDbDataAdapter("INSERT INTO DONOR VALUES(" + 111 + ",'" + textBox1.Text + "','" + textBox3.Text + "','" + textBox6.Text + "','" + textBox8.Text + "','" + textBox4.Text + "','B+','" + textBox9.Text + "','" + textBox7.Text + "')", con);
            OleDbDataAdapter odap = new OleDbDataAdapter("INSERT INTO LOGIN VALUES(" + 111 + ",'" + textBox1.Text + "','" + textBox2.Text + "','USER')", con);
            DataTable dt = new DataTable();
            oda.Fill(dt);
            odap.Fill(dt);
            MessageBox.Show("registration successful!!");
            con.Close();

        }

        private void button10_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbDataAdapter oda = new OleDbDataAdapter("INSERT INTO DONOR VALUES(" + 111 + ",'" + textBox1.Text + "','" + textBox3.Text + "','" + textBox6.Text + "','" + textBox8.Text + "','" + textBox4.Text + "','B-','" + textBox9.Text + "','" + textBox7.Text + "')", con);
            OleDbDataAdapter odap = new OleDbDataAdapter("INSERT INTO LOGIN VALUES(" + 111 + ",'" + textBox1.Text + "','" + textBox2.Text + "','USER')", con);
            DataTable dt = new DataTable();
            oda.Fill(dt);
            odap.Fill(dt);
            MessageBox.Show("registration successful!!");
            con.Close();

        }

        private void button14_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbDataAdapter oda = new OleDbDataAdapter("INSERT INTO DONOR VALUES(" + 111 + ",'" + textBox1.Text + "','" + textBox3.Text + "','" + textBox6.Text + "','" + textBox8.Text + "','" + textBox4.Text + "','O+','" + textBox9.Text + "','" + textBox7.Text + "')", con);
            OleDbDataAdapter odap = new OleDbDataAdapter("INSERT INTO LOGIN VALUES(" + 111 + ",'" + textBox1.Text + "','" + textBox2.Text + "','USER')", con);
            DataTable dt = new DataTable();
            oda.Fill(dt);
            odap.Fill(dt);
            MessageBox.Show("registration successful!!");
            con.Close();

        }

        private void button13_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbDataAdapter oda = new OleDbDataAdapter("INSERT INTO DONOR VALUES(" + 111 + ",'" + textBox1.Text + "','" + textBox3.Text + "','" + textBox6.Text + "','" + textBox8.Text + "','" + textBox4.Text + "','O-','" + textBox9.Text + "','" + textBox7.Text + "')", con);
            OleDbDataAdapter odap = new OleDbDataAdapter("INSERT INTO LOGIN VALUES(" + 111 + ",'" + textBox1.Text + "','" + textBox2.Text + "','USER')", con);
            DataTable dt = new DataTable();
            oda.Fill(dt);
            odap.Fill(dt);
            MessageBox.Show("registration successful!!");
            con.Close();

        }

        private void button12_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbDataAdapter oda = new OleDbDataAdapter("INSERT INTO DONOR VALUES(" + 111 + ",'" + textBox1.Text + "','" + textBox3.Text + "','" + textBox6.Text + "','" + textBox8.Text + "','" + textBox4.Text + "','AB+','" + textBox9.Text + "','" + textBox7.Text + "')", con);
            OleDbDataAdapter odap = new OleDbDataAdapter("INSERT INTO LOGIN VALUES(" + 111 + ",'" + textBox1.Text + "','" + textBox2.Text + "','USER')", con);
            DataTable dt = new DataTable();
            oda.Fill(dt);
            odap.Fill(dt);
            MessageBox.Show("registration successful!!");
            con.Close();

        }

        private void button11_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbDataAdapter oda = new OleDbDataAdapter("INSERT INTO DONOR VALUES(" + 111 + ",'" + textBox1.Text + "','" + textBox3.Text + "','" + textBox6.Text + "','" + textBox8.Text + "','" + textBox4.Text + "','AB-','" + textBox9.Text + "','" + textBox7.Text + "')", con);
            OleDbDataAdapter odap = new OleDbDataAdapter("INSERT INTO LOGIN VALUES(" + 111 + ",'" + textBox1.Text + "','" + textBox2.Text + "','USER')", con);
            DataTable dt = new DataTable();
            oda.Fill(dt);
            odap.Fill(dt);
            MessageBox.Show("registration successful!!");
            con.Close();

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

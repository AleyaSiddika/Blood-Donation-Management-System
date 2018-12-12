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
    public partial class FORGOT_PASSWORD : Form
    {
        public FORGOT_PASSWORD()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection("Provider =OraOLEDB.Oracle; Data Source =DESKTOP-CAPDTNP:1521; User Id = system; Password = tiger");
        private void button7_Click(object sender, EventArgs e)
        {
            con.Open();

            OleDbDataAdapter odat = new OleDbDataAdapter("update LOGIN set PASSWORD='" + textBox2.Text + "'  where USER_NAME='" + textBox3.Text + "' and PASSWORD='" + textBox1.Text + "'", con);
            DataTable dtt = new DataTable();
            odat.Fill(dtt);

            MessageBox.Show("PASSWORD UPDATED");

            con.Close();
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

        private void button4_Click(object sender, EventArgs e)
        {
            DONOR_LIST newForm2 = new DONOR_LIST();
            newForm2.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RULES newRULES = new RULES();
            newRULES.Show();
            this.Hide();
        }
    }
}

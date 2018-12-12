using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace blood_donation
{
    public partial class HOMEPAGE : Form
    {
        public HOMEPAGE()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
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

        private void HOMEPAGE_Load(object sender, EventArgs e)
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

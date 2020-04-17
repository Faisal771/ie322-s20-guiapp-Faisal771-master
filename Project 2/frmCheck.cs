using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_2
{
    public partial class frmCheck : Form
    {
        public frmCheck()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string msg = "";

            if (chkCoffee.Checked == true)
            {
                msg= chkCoffee.Text;
            }
            if (chkDonut.Checked==true)
            {
                msg= msg+" " + chkDonut.Text;
            }
            if (chkBrownie.Checked == true)
            {
                msg= msg+ " " + chkBrownie.Text ;
            }
            if(msg.Length >0)
            {
                MessageBox.Show(msg + " ordered.");
            }
            else
            {
                MessageBox.Show("Nothing ordered.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }
    }
}

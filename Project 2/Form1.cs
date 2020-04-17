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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            if (TxtUser.Text== "Faisal" && TxtPW.Text=="1234")
            { MessageBox.Show("Login is succesful");
            }
            else { MessageBox.Show("Incorrect username");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            frmRadio frm = new frmRadio();
            frm.ShowDialog();

        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            frmPic01 frm = new frmPic01();
            frm.ShowDialog();
            //to close the form
            this.DialogResult = DialogResult.OK;
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void TxtPW_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnLogin_Click_1(object sender, EventArgs e)
        {
            if (TxtUser.Text == "Faisal")

            {
             
                if (TxtPW.Text == "1234")
                {
                    MessageBox.Show("Login is Successful");
                }
                else
                {
                    MessageBox.Show("invalid Password");
                }
            }
            else
            {
                MessageBox.Show("Invalid username");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmCheck frm = new frmCheck();
            frm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmCombo frm = new frmCombo();
            frm.ShowDialog();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            frmRandom frm = new frmRandom();
            frm.ShowDialog();
        }

        private void groupBox7_Enter(object sender, EventArgs e)
        {

        }
    }
}

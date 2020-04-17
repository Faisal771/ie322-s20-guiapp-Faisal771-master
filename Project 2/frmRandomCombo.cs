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
    public partial class frmRandomCombo : Form
    {
       


        public frmRandomCombo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            cmbRandom.ResetText();      //Resets the Text 
            cmbRandom.Items.Clear();    //Removes all items from Combo
            Random r = new Random();
            for (int i = 0; i < r.Next(1, 51); i++)
            {
                cmbRandom.Items.Add(r.Next(100, 999));
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            cmbRandom.ResetText();
            cmbRandom.Items.Clear();
            rdoLess.Checked = false;
            rdoGreater.Checked = false;



        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (Convert.ToInt32(cmbRandom.Text) > 499)
            {
                rdoGreater.Checked = true;
            }
            else
            {
                rdoLess.Checked = true;
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (Convert.ToInt32(cmbRandom2.Text) > 49)
            {
                rdoGreater2.Checked = true;
            }
            else
            {
                rdoLess2.Checked = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cmbRandom2.ResetText();
            cmbRandom2.Items.Clear();
            Random r = new Random();
            for (int i = 0; i < r.Next(2, 9) - 1; i++)
            {
                cmbRandom2.Items.Add(r.Next(10, 99));
            }
            label1.Text = Convert.ToString(cmbRandom2.Items.Count);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void btnReset2_Click(object sender, EventArgs e)
        {
            cmbRandom2.ResetText();
            cmbRandom2.Items.Clear();
            rdoLess2.Checked = false;
            rdoGreater2.Checked = false;
            label1.Text = Convert.ToString(cmbRandom2.Items.Count);
        }
    }
}

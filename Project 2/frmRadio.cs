﻿using System;
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
    public partial class frmRadio : Form
    {
        public frmRadio()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoRed.Checked==true)
            {
                rdoRed.ForeColor = Color.FromArgb(255, 0, 0); 
            }
            else
                rdoRed.ForeColor = Color.FromArgb(0, 0, 0);
                                                              // http://www.flounder.com/csharp_color_table.htm
        
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
        

            if (rdoGreen.Checked == true)
                rdoGreen.ForeColor = Color.FromName("green");
            else
                rdoGreen.ForeColor = Color.FromArgb(0, 0, 0);
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoBlue.Checked == true)
                rdoBlue.ForeColor = Color.FromName("blue");
            else
                rdoBlue.ForeColor = Color.FromArgb(0, 0, 0);

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoYellow.Checked == true)
                rdoYellow.ForeColor = Color.FromName("yellow");
            else
                rdoYellow.ForeColor = Color.FromArgb(0, 0, 0);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            rdoYellow.ForeColor = Color.FromName("Black");
            rdoRed.ForeColor = Color.FromName("Black");
            rdoGreen.ForeColor = Color.FromName("Black");
            rdoBlue.ForeColor = Color.FromName("Black");

            rdoRed.Checked = false;
            rdoGreen.Checked = false;
            rdoBlue.Checked = false;
            rdoYellow.Checked = false;

            rdoRed.ForeColor = Color.FromName("black");
            rdoGreen.ForeColor = Color.FromName("black");
            rdoBlue.ForeColor = Color.FromName("black");
            rdoYellow.ForeColor = Color.FromName("black");

            RdoRed2.Checked = false;
            RdoGreen2.Checked = false;
            RdoBlue2.Checked = false;
            RdoYellow2.Checked = false;

            RdoRed2.ForeColor = Color.FromName("black");
            RdoGreen2.ForeColor = Color.FromName("black");
            RdoBlue2.ForeColor = Color.FromName("black");
            RdoYellow2.ForeColor = Color.FromName("black");

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            RdoRed2.ForeColor = Color.FromName("red");
        }

        private void RdoGreen2_CheckedChanged(object sender, EventArgs e)
        {
            RdoGreen2.ForeColor = Color.FromName("green");
        }

        private void RdoBlue2_CheckedChanged(object sender, EventArgs e)
        {
            RdoBlue2.ForeColor = Color.FromName("blue");
        }

        private void RdoYellow2_CheckedChanged(object sender, EventArgs e)
        {
            RdoYellow2.ForeColor = Color.FromName("yellow");
        }
    }
}

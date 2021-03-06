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
    public partial class frmCombo : Form
    {
        public frmCombo()
        {
            InitializeComponent();
            //Adding items to the combobox
            CmbDays.Items.Add("Sunday");
            CmbDays.Items.Add("Monday");
            CmbDays.Items.Add("Tuesday");
            CmbDays.Items.Add("Wednesday");
            CmbDays.Items.Add("Thursday");
            CmbDays.Items.Add("Friday");
            CmbDays.Items.Add("Saturday");
            CmbDays.Items.Add("Funday");
            CmbDays.Items.Add("Examday");

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (CmbDays.Items.Count >= 2)
            {
                CmbDays.Items.RemoveAt(CmbDays.Items.Count - 2);
            }
            else
            {
                MessageBox.Show("Cant remove 2nd last item");
            }
        }

        private void frmCombo_Load(object sender, EventArgs e)
        {

        }

        private void BtnShowSelected1_Click(object sender, EventArgs e)
        {// Using method 1
            MessageBox.Show(CmbDays.Text);
        }

        private void ButtonShowSelected2_Click(object sender, EventArgs e)
        {
            //method2
            string itemText = CmbDays.GetItemText(CmbDays.SelectedItem);
            MessageBox.Show(itemText);



        }

        private void BtnRemoveByIndex_Click(object sender, EventArgs e)
        {
            //remove item at a the specified index or giving a specified 
            CmbDays.Items.RemoveAt(1);
            // the above code will remove the second item from the combobox



        }

        private void BtnShowSelected3_Click(object sender, EventArgs e)
        {
            //Method 3 
            var item = CmbDays.SelectedItem;
            if (item != null)
                MessageBox.Show(item.ToString()); // if item is Null, an error will occour

        }

        private void BtnRemoveByName_Click(object sender, EventArgs e)
        {
            CmbDays.Items.Remove("Friday");

            //remove item by giving a specified item by name.
           
        }

        private void BtnRemoveLast_Click(object sender, EventArgs e)
        {
            if (CmbDays.Items.Count >=1)
            {
                CmbDays.Items.RemoveAt(CmbDays.Items.Count - 1);

            }
            else
            {
                MessageBox.Show("cant remove last item");

            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssignmentFive
{
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
           MessageBox.Show("Hussam Eldin Moahmed , Dollar Computer App ,version 1.01");
        }

        private void OrderForm_Activated(object sender, EventArgs e)
        {
            ConditionTextBox.Text = Program.selectedProduct.Condition;
            PlatformTextBox.Text = Program.selectedProduct.Platform;
            ManuTextBox.Text = Program.selectedProduct.Manufacturer;
            ModelTextBox.Text = Program.selectedProduct.Model;

            BiglistBox.Items.Add(Program.selectedProduct.Screensize);
            BiglistBox.Items.Add("");
            BiglistBox.Items.Add(Program.selectedProduct.RAM_size);
            BiglistBox.Items.Add("");
            BiglistBox.Items.Add(Program.selectedProduct.CPU_brand);
            BiglistBox.Items.Add("");
            BiglistBox.Items.Add(Program.selectedProduct.CPU_type);
            BiglistBox.Items.Add("");
            BiglistBox.Items.Add(Program.selectedProduct.CPU_number);
            BiglistBox.Items.Add("");
            BiglistBox.Items.Add(Program.selectedProduct.CPU_speed);
            BiglistBox.Items.Add("");
            BiglistBox.Items.Add(Program.selectedProduct.HDD_size);
            BiglistBox.Items.Add("");
            BiglistBox.Items.Add(Program.selectedProduct.GPU_Type);
            BiglistBox.Items.Add("");
            BiglistBox.Items.Add(Program.selectedProduct.Webcam);
            BiglistBox.Items.Add("");
            BiglistBox.Items.Add(Program.selectedProduct.OS);

            PriceTextBox.Text = Program.selectedProduct.Cost;
            var convertedCost = Convert.ToDouble(Program.selectedProduct.Cost);
            var calculatedTax = convertedCost * 0.13;
            TaxTextBox.Text = calculatedTax.ToString();
            var calculatedTotal = convertedCost + calculatedTax;
            TotalTexBox.Text = calculatedTotal.ToString();
        }

        private void OrderForm_Deactivate(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your Selection is Printing!");
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            //Program.productionForm.Show();
            //this.Hide();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FinishButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you!");
        }
    }
}


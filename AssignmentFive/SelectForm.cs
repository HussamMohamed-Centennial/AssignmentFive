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
    public partial class SelectForm : Form
    {
        public SelectForm()
        {
            InitializeComponent();
        }

        private void SelectForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dollarComputersDataSet.products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.dollarComputersDataSet.products);
            DollarComputorsDataGridView_CellClick(sender , e as DataGridViewCellEventArgs);

        }

        private void DollarComputorsDataGridView_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            //SelectionTextBox.Text = DollarComputorsDataGridView
            
        }

        private void DollarComputorsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var mannufacturer = DollarComputorsDataGridView.SelectedRows[0].Cells[2].Value;
            var model = DollarComputorsDataGridView.SelectedRows[0].Cells[3].Value;
            var cost = DollarComputorsDataGridView.SelectedRows[0].Cells[1].Value;
            //Debug.WriteLine($"{mannufacturer} , {model} , {cost}");
            SelectionTextBox.Text = $"{mannufacturer}, Model: {model}, which will cost: {cost}";
        }

        private void SelectFormNextButton_Click(object sender, EventArgs e)
        {
            Program.productionForm.Show();
            this.Hide();
            Program.selectedProduct.Cost = DollarComputorsDataGridView.SelectedRows[0].Cells[1].Value.ToString();
            Program.selectedProduct.Manufacturer = DollarComputorsDataGridView.SelectedRows[0].Cells[2].Value.ToString();
            Program.selectedProduct.Model = DollarComputorsDataGridView.SelectedRows[0].Cells[3].Value.ToString();
            Program.selectedProduct.RAM_type = DollarComputorsDataGridView.SelectedRows[0].Cells[4].Value.ToString();
            Program.selectedProduct.RAM_size = DollarComputorsDataGridView.SelectedRows[0].Cells[5].Value.ToString();
            Program.selectedProduct.Displaytype = DollarComputorsDataGridView.SelectedRows[0].Cells[6].Value.ToString();
            Program.selectedProduct.Screensize = DollarComputorsDataGridView.SelectedRows[0].Cells[7].Value.ToString();
            Program.selectedProduct.Resolution = DollarComputorsDataGridView.SelectedRows[0].Cells[8].Value.ToString();
            Program.selectedProduct.CPU_Class = DollarComputorsDataGridView.SelectedRows[0].Cells[9].Value.ToString();
            Program.selectedProduct.CPU_brand = DollarComputorsDataGridView.SelectedRows[0].Cells[10].Value.ToString();
            Program.selectedProduct.CPU_type = DollarComputorsDataGridView.SelectedRows[0].Cells[11].Value.ToString();
            Program.selectedProduct.CPU_speed = DollarComputorsDataGridView.SelectedRows[0].Cells[12].Value.ToString();
            Program.selectedProduct.CPU_number = DollarComputorsDataGridView.SelectedRows[0].Cells[13].Value.ToString();
            Program.selectedProduct.Condition = DollarComputorsDataGridView.SelectedRows[0].Cells[14].Value.ToString();
            Program.selectedProduct.OS = DollarComputorsDataGridView.SelectedRows[0].Cells[15].Value.ToString();
            Program.selectedProduct.Platform = DollarComputorsDataGridView.SelectedRows[0].Cells[16].Value.ToString();
            Program.selectedProduct.HDD_size = DollarComputorsDataGridView.SelectedRows[0].Cells[17].Value.ToString();
            Program.selectedProduct.HDD_speed = DollarComputorsDataGridView.SelectedRows[0].Cells[18].Value.ToString();
            Program.selectedProduct.GPU_Type = DollarComputorsDataGridView.SelectedRows[0].Cells[19].Value.ToString();
            Program.selectedProduct.Optical_drive = DollarComputorsDataGridView.SelectedRows[0].Cells[20].Value.ToString();
            Program.selectedProduct.Audio_type = DollarComputorsDataGridView.SelectedRows[0].Cells[21].Value.ToString();
            Program.selectedProduct.LAN = DollarComputorsDataGridView.SelectedRows[0].Cells[22].Value.ToString();
            Program.selectedProduct.WIFI = DollarComputorsDataGridView.SelectedRows[0].Cells[23].Value.ToString();
            Program.selectedProduct.Width = DollarComputorsDataGridView.SelectedRows[0].Cells[24].Value.ToString();
            Program.selectedProduct.Height = DollarComputorsDataGridView.SelectedRows[0].Cells[25].Value.ToString();
            Program.selectedProduct.Depth = DollarComputorsDataGridView.SelectedRows[0].Cells[26].Value.ToString();
            Program.selectedProduct.Weight = DollarComputorsDataGridView.SelectedRows[0].Cells[27].Value.ToString();
            Program.selectedProduct.Mouse_type = DollarComputorsDataGridView.SelectedRows[0].Cells[28].Value.ToString();
            Program.selectedProduct.Power = DollarComputorsDataGridView.SelectedRows[0].Cells[29].Value.ToString();
            Program.selectedProduct.Webcam = DollarComputorsDataGridView.SelectedRows[0].Cells[30].Value.ToString();

            //Debug.WriteLine(Program.selectedProduct.Cost);
        }
    }
}

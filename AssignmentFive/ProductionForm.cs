using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssignmentFive
{
    public partial class ProductionForm : Form
    {
        public static List<string> OpenFileData = new List<string>();
        public ProductionForm()
        {
            InitializeComponent();
        }

        private void ProductionForm_Load(object sender, EventArgs e)
        {
            
        }

        private void ProductionForm_Activated(object sender, EventArgs e)
        {
            ProductIDTextBox.Text = Program.selectedProduct.ProductID;
            ConditionTextBox.Text = Program.selectedProduct.Condition;
            CostTextBox.Text = Program.selectedProduct.Cost;
            PlatformTextBox.Text = Program.selectedProduct.Platform;
            OSTextBox.Text = Program.selectedProduct.OS;
            manuTextBox.Text = Program.selectedProduct.Manufacturer;
            ModelTextBox.Text = Program.selectedProduct.Model;
            MemoryTexBox.Text = Program.selectedProduct.RAM_size;
            LCDSizeTextBox.Text = Program.selectedProduct.Screensize;
            HDDTextBox.Text = Program.selectedProduct.HDD_size;
            BrandTextBox.Text = Program.selectedProduct.CPU_brand;
            NumberTextBox.Text = Program.selectedProduct.CPU_number;
            CPUTypeTextBox.Text = Program.selectedProduct.CPU_type;
            CPUSpeedTextBox.Text = Program.selectedProduct.CPU_speed;
            TypeTextBox.Text = Program.selectedProduct.GPU_Type;
            WebCamTextBox.Text = Program.selectedProduct.Webcam;


            Debug.WriteLine(Program.selectedProduct.ProductID);
        }

        private void SelectAnothorProductButton_Click(object sender, EventArgs e)
        {
            Program.selectForm.Show();
            this.Hide();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            Program.orderForm.Show();
            this.Hide();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductSaveFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            var productSaveFileDialogResult = ProductSaveFileDialog.ShowDialog();
            if (productSaveFileDialogResult != DialogResult.Cancel)
            {
                StreamWriter streamWriter = new StreamWriter(ProductSaveFileDialog.FileName);
                streamWriter.WriteLine(Program.selectedProduct.ProductID);
                streamWriter.WriteLine(Program.selectedProduct.Cost);
                streamWriter.WriteLine(Program.selectedProduct.Manufacturer);
                streamWriter.WriteLine(Program.selectedProduct.Model);
                streamWriter.WriteLine(Program.selectedProduct.RAM_type);
                streamWriter.WriteLine(Program.selectedProduct.RAM_size);
                streamWriter.WriteLine(Program.selectedProduct.Displaytype);
                streamWriter.WriteLine(Program.selectedProduct.Screensize);
                streamWriter.WriteLine(Program.selectedProduct.Resolution);
                streamWriter.WriteLine(Program.selectedProduct.CPU_Class);
                streamWriter.WriteLine(Program.selectedProduct.CPU_brand);
                streamWriter.WriteLine(Program.selectedProduct.CPU_type);
                streamWriter.WriteLine(Program.selectedProduct.CPU_speed);
                streamWriter.WriteLine(Program.selectedProduct.CPU_number);
                streamWriter.WriteLine(Program.selectedProduct.Condition);
                streamWriter.WriteLine(Program.selectedProduct.OS);
                streamWriter.WriteLine(Program.selectedProduct.Platform);
                streamWriter.WriteLine(Program.selectedProduct.HDD_size);
                streamWriter.WriteLine(Program.selectedProduct.HDD_speed);
                streamWriter.WriteLine(Program.selectedProduct.GPU_Type);
                streamWriter.WriteLine(Program.selectedProduct.Optical_drive);
                streamWriter.WriteLine(Program.selectedProduct.Audio_type);
                streamWriter.WriteLine(Program.selectedProduct.LAN);
                streamWriter.WriteLine(Program.selectedProduct.WIFI);
                streamWriter.WriteLine(Program.selectedProduct.Width);
                streamWriter.WriteLine(Program.selectedProduct.Height);
                streamWriter.WriteLine(Program.selectedProduct.Depth);
                streamWriter.WriteLine(Program.selectedProduct.Weight);
                streamWriter.WriteLine(Program.selectedProduct.Mouse_type);
                streamWriter.WriteLine(Program.selectedProduct.Power);
                streamWriter.WriteLine(Program.selectedProduct.Webcam);
                streamWriter.Flush();
                streamWriter.Close();
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductsopenFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            var ProductOpenFileDialogResult = ProductsopenFileDialog.ShowDialog();
            if (ProductOpenFileDialogResult != DialogResult.Cancel)
            {
                StreamReader streamReader = new StreamReader(ProductsopenFileDialog.FileName);
                while (! streamReader.EndOfStream)
                {
                    OpenFileData.Add(streamReader.ReadLine());
                }
                
                ProductIDTextBox.Text = OpenFileData[0].ToString();
                ConditionTextBox.Text = OpenFileData[14].ToString();
                CostTextBox.Text = OpenFileData[1].ToString();
                PlatformTextBox.Text = OpenFileData[16].ToString();
                OSTextBox.Text = OpenFileData[15].ToString();
                manuTextBox.Text = OpenFileData[2].ToString();
                ModelTextBox.Text = OpenFileData[3].ToString();
                MemoryTexBox.Text = OpenFileData[5].ToString();
                LCDSizeTextBox.Text = OpenFileData[7].ToString();
                HDDTextBox.Text = OpenFileData[17].ToString();
                BrandTextBox.Text = OpenFileData[10].ToString();
                NumberTextBox.Text = OpenFileData[13].ToString();
                CPUTypeTextBox.Text = OpenFileData[11].ToString();
                CPUSpeedTextBox.Text = OpenFileData[12].ToString();
                TypeTextBox.Text = OpenFileData[19].ToString();
                WebCamTextBox.Text = OpenFileData[30].ToString();


                streamReader.Close();
            }

        }
    }
}

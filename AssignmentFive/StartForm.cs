using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssignmentFive
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        //Event handler which will all the  user to move between forms 

        public void NewButton_Click(object sender, EventArgs e)
        {
            Program.startForm.Hide();
            Program.selectForm.Show();
        }

        //Event handler which will all the  user to move between forms 
        private void LoadButtom_Click(object sender, EventArgs e)
        {
            Program.startForm.Hide();
            Program.productionForm.Show();
        }

        private void ExitButtom_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

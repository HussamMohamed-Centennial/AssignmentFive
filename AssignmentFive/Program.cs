//=======================================================================================
//Author's Name      : Hussam Eldin Mohamed
//Student Id         : 301090956
//App Creation date  : Aug 23,2020
//App Description    : Computer's store app which will help the user to place an order
//                     through different pathways
//=======================================================================================

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssignmentFive
{
    static class Program
    {
        //Creation of static Forms to allow the app to move from a form to next one.
        public static SplashForm splashForm;
        public static StartForm startForm;
        public static SelectForm selectForm;
        public static ProductionForm productionForm;
        public static Products selectedProduct;
        public static OrderForm orderForm;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            splashForm = new SplashForm();
            startForm = new StartForm();
            selectForm = new SelectForm();
            productionForm = new ProductionForm();
            selectedProduct = new Products();
            orderForm = new OrderForm();
            Application.Run(splashForm);
        }
    }
}

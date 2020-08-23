using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssignmentFive
{
    static class Program
    {

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
            Application.Run(selectForm);
        }
    }
}

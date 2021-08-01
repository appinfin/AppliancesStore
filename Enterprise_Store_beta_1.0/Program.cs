using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
//using db_Model_Library;

namespace Enterprise_Store_beta_1._0
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //using db_Context_Store db = new db_Context_Store();

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
            Application.Run(new Test_Form());
            //Application.Run(new CatalogCounterparty_Form());
            //Application.Run(new CatalogStorage_Form());

            //Application.Run(new Calendar_Form());
            //Application.Run(new AddProduct_Form());
            //Application.Run(new BuyForm());
            //Application.Run(new SellForm());
            //Application.Run(new CreateBuy_Form());
            //Application.Run(new CatalogProducts_Form());
        }
    }
}

using OutLets.DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OutLets
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ProductDL.getFromFile();
            AuthDL.getDataFromFile();
            OrderDL.getFromFile();
            ShopKeeperDL.getFromFile();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ProductDL.printLinkedList();
            Application.Run(new LogIn());
        }
    }
}

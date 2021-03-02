using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text;
using System.Drawing;

namespace OOP_PROJECT
{
    
    static class Program
    {
        public static Order order = new Order();
        public static Person client = new Person();
        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainPage());
        }   
    }
    public class Order
    {
        public List<Dish> list = new List<Dish>();
        public List<int> items = new List<int>();
    }
}

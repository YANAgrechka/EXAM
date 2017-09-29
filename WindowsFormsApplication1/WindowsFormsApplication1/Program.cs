using System;
using System.Collections.Generic;

using System.Windows.Forms;


namespace WindowsFormsApplication1
{
    public class Car
    {
        
        public string model { get; set; }
        public int price { get; set; }
    }

    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
           
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
           
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T9
{
    internal static class Program
    {
        static public Form1 Form { get; private set; }
        static public PrintModel Print { get; private set; }
        static public CorrectModel Correct { get; private set; }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Form = new Form1();
            Print = new PrintModel();
            Correct = new CorrectModel();

            Application.Run(Form);
        }
    }
}

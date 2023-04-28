﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T9
{
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //MessageBox.Show($"{LevenshteinDistance.Find("test", "test")}");

            Controller controler = new Controller(new MainForm(), new Model("Dictionary.txt"));
            controler.RunView();
        }
    }
}

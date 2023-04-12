using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _12._04._2023_Task1
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();

        }

        private void clear_Click(object sender, EventArgs e)
        {
            listBox.Items.Clear();
        }

        private void search_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog(this) == DialogResult.OK)
            {
                string[] files = Directory.GetFiles(folderBrowserDialog.SelectedPath);
                foreach (string file in files) 
                {
                    if (Path.GetExtension(file) == textBox.Text) listBox.Items.Add(Path.GetFileName(file)); 
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _12._04._2023_Task3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public string filePath { get; set; } = string.Empty;
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string newfile = $"{Path.GetDirectoryName(filePath)}\\{textBox.Text}";
            File.Move(filePath, newfile);
            filePath = newfile;
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            textBox.Text = Path.GetFileName(filePath);
        }
    }
}

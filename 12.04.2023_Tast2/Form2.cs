using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _12._04._2023_Tast2
{
    public partial class Form2 : Form
    {
        public string NameP { get => textBox1.Text; set => textBox1.Text = value; }
        public int PriceP { get => Convert.ToInt16(textBox2.Text); set => textBox2.Text = value.ToString(); }
        public string DescriptionP { get => richTextBox1.Text; set => richTextBox1.Text = value; }
        public Form2()
        {
            InitializeComponent();
        }
    }
}

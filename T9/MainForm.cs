using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T9
{
    public partial class MainForm : Form
    {
        public Controller Controler { get; set; }
        public MainForm()
        {
            InitializeComponent();
        }

        public void PrintChar(char ch)
        {
            this.richTextBox.Text += ch;
        }
        public void RemChar()
        {
            if (this.richTextBox.Text.Length > 0)
            {
                this.richTextBox.Text = richTextBox.Text.Remove(richTextBox.Text.Length - 1);
            }
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            this.PrintChar((sender as Button).Text[0]);
            this.button36.Text = Controler.SuggestAReplacement(this.richTextBox.Text);
        }

        private void buttonSpace_Click(object sender, EventArgs e)
        {
            this.PrintChar(' ');
            this.button36.Text = "";
        }

        private void buttonRem_Click(object sender, EventArgs e)
        {
            this.RemChar();
            if (this.richTextBox.Text.Length > 1 )
                this.button36.Text = Controler.SuggestAReplacement(this.richTextBox.Text);
        }

        private void button32_Click(object sender, EventArgs e)
        {
            this.PrintChar('\n');
            this.button36.Text = "";
        }

        private void button36_Click(object sender, EventArgs e)
        {
            this.richTextBox.Text = Controler.ReplaceLast(richTextBox.Text, button36.Text);
        }
    }
}

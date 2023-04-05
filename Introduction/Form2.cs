using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Introduction
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Form2_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Rectangle rectangle = new Rectangle(
                    10,
                    10,
                    this.ClientSize.Width - 10,
                    this.ClientSize.Height - 10
                    );

                if (e.X < rectangle.Right &&
                    e.Y < rectangle.Bottom &&
                    e.X > rectangle.Left &&
                    e.Y > rectangle.Top)
                    MessageBox.Show($"Нажатие было в квадрате");
                else MessageBox.Show($"Нажатие было в не квадрата");
            }
            if (e.Button == MouseButtons.Right)
            {
                this.Text = String.Format($"Width: {this.ClientSize.Width} Height: {this.ClientSize.Height}");
            }
        }

        private void Form2_MouseMove(object sender, MouseEventArgs e)
        {
            this.Text = String.Format($"Left: {e.X} Right: {e.Y}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WhoWantToBeAMillionaire
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listView1.BackColor = Color.Black;
            listView1.ForeColor = Color.Yellow;
            listView1.Font.Dispose();
            listView1.Font = new Font("Microsoft Sans Serif", 14);
        }
    }
}

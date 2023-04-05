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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] msgs = new string[]
                { 
                    "Шеленговский А. Л.",
                    "C# Developer",
                    "Почта: thesheleng@gmail.com"
                };

            foreach (string msg in msgs)
            {
                MessageBox.Show(msg, "Резюме");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            const int max_num = 200;
            const int min_num = 1;

            int coubter = 1;
            MessageBox.Show($"Загадай число от {min_num} до {max_num}");
            Random r = new Random();
            while (true)
            {
                var res = MessageBox.Show($"Я думаю это {r.Next(min_num, max_num)}", "", MessageBoxButtons.YesNo);
                if (res is DialogResult.Yes) break;
                coubter++;
            }
            MessageBox.Show($"Ура! У меня получилось всего за {coubter} попыток.");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 testDialog = new Form2();
            testDialog.ShowDialog(this);
            testDialog.Dispose();
        }
    }
}

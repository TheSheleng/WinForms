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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Quiz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            progressBar1.Maximum = 9;
            timer1.Start();
        }
        private void UpdateProgress(object sender, EventArgs e)
        {
            int progress = 0;

            if (radioButton1.Checked || radioButton2.Checked || radioButton3.Checked || radioButton4.Checked) progress++;
            if (radioButton5.Checked || radioButton6.Checked || radioButton7.Checked || radioButton8.Checked) progress++;
            if (radioButton9.Checked || radioButton10.Checked || radioButton11.Checked || radioButton12.Checked) progress++;
            if (radioButton13.Checked || radioButton14.Checked || radioButton15.Checked || radioButton16.Checked) progress++;
            if (radioButton17.Checked || radioButton18.Checked || radioButton19.Checked || radioButton20.Checked) progress++;
            if (radioButton21.Checked || radioButton22.Checked || radioButton23.Checked) progress++;
            if (radioButton24.Checked || radioButton25.Checked || radioButton26.Checked || radioButton27.Checked) progress++;
            if (radioButton28.Checked || radioButton29.Checked || radioButton30.Checked || radioButton31.Checked) progress++;
            if (checkBox1.Checked || checkBox2.Checked || checkBox3.Checked || checkBox4.Checked) progress++;

            progressBar1.Value = progress;
        }

        private void CheckResult(object sender, EventArgs e)
        {
            checkBox1.Enabled = false;
            checkBox2.Enabled = false;
            checkBox3.Enabled = false;
            checkBox4.Enabled = false;
            radioButton1.Enabled = false;
            radioButton2.Enabled = false;
            radioButton3.Enabled = false;
            radioButton4.Enabled = false;
            radioButton5.Enabled = false;
            radioButton6.Enabled = false;
            radioButton7.Enabled = false;
            radioButton8.Enabled = false;
            radioButton9.Enabled = false;
            radioButton10.Enabled = false;
            radioButton11.Enabled = false;
            radioButton12.Enabled = false;
            radioButton13.Enabled = false;
            radioButton14.Enabled = false;
            radioButton15.Enabled = false;
            radioButton16.Enabled = false;
            radioButton17.Enabled = false;
            radioButton18.Enabled = false;
            radioButton19.Enabled = false;
            radioButton20.Enabled = false;
            radioButton21.Enabled = false;
            radioButton22.Enabled = false;
            radioButton23.Enabled = false;
            radioButton24.Enabled = false;
            radioButton25.Enabled = false;
            radioButton26.Enabled = false;
            radioButton27.Enabled = false;
            radioButton28.Enabled = false;
            radioButton29.Enabled = false;
            radioButton30.Enabled = false;
            radioButton31.Enabled = false;

            int result = 0;
            if (radioButton4.Checked) result++;
            if (radioButton10.Checked) result++;
            if (radioButton7.Checked) result++;
            if (radioButton16.Checked) result++;
            if (radioButton22.Checked) result++;
            if (radioButton26.Checked) result++;
            if (radioButton19.Checked) result++;
            if (radioButton28.Checked) result++;
            if (checkBox1.Checked && checkBox2.Checked && checkBox3.Checked && !checkBox4.Checked) result++;

            timer1.Stop();
            MessageBox.Show($"Поздравлюя с завершением теста, ваш результат: {result}/9", "Результат");
        }

        long time = 6000000000;
        private void timer(object sender, EventArgs e)
        {
            time -= 10000000;
            this.Text = $"Quiz: Оставшееся время {new DateTime(time).TimeOfDay}";
        }
    }
}

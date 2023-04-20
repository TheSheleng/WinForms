using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProcMenager
{
    public partial class Form1 : Form
    {
        void RefreshList()
        {
            ListViewItem item;
            foreach (Process process in Process.GetProcesses())
            {
                item = new ListViewItem(process.ProcessName);
                item.SubItems.Add(process.Id.ToString());
                this.listView1.Items.Add(item);
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshList();
            this.timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process proc = new Process();
            proc.StartInfo.FileName = this.textBox1.Text;
            proc.Start();
            RefreshList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem process in this.listView1.SelectedItems) 
            {
                Process.GetProcessById(Convert.ToInt16(process.SubItems[1].Text)).Kill();
            }
            RefreshList();
        }
    }
}

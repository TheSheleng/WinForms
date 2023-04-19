using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FileSearcher
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.folderBrowserDialog.ShowDialog();
        }

        Thread thred = null;

        private void SerchFile(object path)
        {
            DirectoryInfo dir = new DirectoryInfo(path as string);

            foreach (FileInfo file in dir.GetFiles())
            {
                if (file.Extension != this.textBox1.Text && "" != this.textBox1.Text) continue;
                if (!File.ReadAllText(file.FullName).Contains(this.textBox2.Text) && "" != this.textBox2.Text) continue;
                ListViewItem item = new ListViewItem(file.Name, 0);
                item.SubItems.Add(file.DirectoryName);
                item.SubItems.Add(file.Length.ToString());
                item.SubItems.Add(file.LastWriteTime.ToString());

                Action act = delegate { listView.Items.Add(item); };
                this.Invoke(act);
            }

            if (this.checkBox1.Checked)
            {
                foreach (DirectoryInfo directory in dir.GetDirectories()) SerchFile(directory.FullName);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.button3.Enabled = true;
            this.button2.Enabled = false;
            this.textBox1.Enabled = false;
            this.textBox2.Enabled = false;
            this.checkBox1.Enabled = false;
            this.button1.Enabled = false;

            listView.Items.Clear();

            thred = new Thread(new ParameterizedThreadStart(SerchFile));
            thred.IsBackground = true;
            thred.Start(this.folderBrowserDialog.SelectedPath);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.button3.Enabled = false;
            this.button2.Enabled = true;
            this.textBox1.Enabled = true;
            this.textBox2.Enabled = true;
            this.checkBox1.Enabled = true;
            this.button1.Enabled = true;

            thred.Abort();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _24._04._2023
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void OpenFolder_Click(object sender, EventArgs e)
        {
            this.folderBrowserDialog.ShowDialog();
            this.FolderTextBox.Text = this.folderBrowserDialog.SelectedPath;
        }

        private async void SerchInFolder(string path)
        {
            if (this.Subdirectories.Checked)
                await Task.Run(() => {
                    foreach (string dir in Directory.GetDirectories(path)) SerchInFolder(dir);
                });

            foreach (string file in Directory.GetFiles(path))
            {
                using (StreamReader reader = new StreamReader(file))
                {
                    string text = reader.ReadToEnd();
                    int amount = new Regex(this.FindTextBox.Text).Matches(text).Count;
                    if (amount > 0)
                    {
                        this.Invoke(new Action(() => {
                            this.listBox.Items.AddRange(new string[] {
                                $"Название файла: {Path.GetFileName(file)}",
                                $"Путь: {file}",
                                $"Количество вхождений: {amount}",
                                $""
                            });
                        }));
                    }
                }
            }
        }

        private void Start_Click(object sender, EventArgs e)
        {
            listBox.Items.Clear();
            SerchInFolder(FolderTextBox.Text);
        }
    }
}

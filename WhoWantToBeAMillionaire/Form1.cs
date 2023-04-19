using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WhoWantToBeAMillionaire
{
    public partial class Form1 : Form
    {
        String file_name = "questions.xml";
        List<Question> _questions = new List<Question>();

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

            XmlDocument doc = new XmlDocument();
            doc.Load(file_name);

            foreach (XmlNode questions in doc.DocumentElement.ChildNodes)
            {
                Question question = new Question();
                question.Title = questions.Attributes.Item(0).Value;
                question.AnswerA = questions.ChildNodes.Item(0).Name;
                question.AnswerB = questions.ChildNodes.Item(1).Name;
                question.AnswerC = questions.ChildNodes.Item(2).Name;
                question.AnswerD = questions.ChildNodes.Item(3).Name;
                _questions.Add(question);
            }
        }

        private void addQToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
        }

        private void DelQToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void changeQToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}

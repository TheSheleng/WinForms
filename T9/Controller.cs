using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T9
{
    public class Controller
    {
        private MainForm form;
        private Model model;
        public Controller(MainForm form, Model model)
        {
            this.form = form;
            this.form.Controler = this;

            this.model = model;
            this.model.Controler = this;
        }

        public void RunView()
        {
            Application.Run(form);
        }

        public string SuggestAReplacement(string text)
        {
            string repW = text.Split(
                new char[] { ' ', '\n', '\t', '\r' }, 
                StringSplitOptions.RemoveEmptyEntries
            ).Last();
            return model.Similar(repW);
        }

        public string ReplaceLast(string text, string nWord)
        {
            int remStart = text.Length;
            int remCount = 0;

            char ch = text[remStart - 1];
            while (ch == ' ' || ch == '\n' || ch == '\r' || ch == '\t')
            {
                remStart--;
                remCount++;
                if (remStart > 0) ch = text[remStart - 1];
                else break;
            }

            ch = text[remStart - 1];
            while (ch != ' ' && ch != '\n' &&  ch != '\r' && ch != '\t')
            {
                remStart--;
                remCount++;
                if (remStart > 0) ch = text[remStart - 1];
                else break;
            }

            return text.Remove(remStart, remCount) + nWord;
        }
    }
}

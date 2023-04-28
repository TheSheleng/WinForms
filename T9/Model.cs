using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T9
{
    public class Model
    {
        public Controller Controler { get; set; }

        private string[] Dictionary;

        public Model(string path)
        {
            using (StreamReader reader = new StreamReader(path))
            { 
                string text = reader.ReadToEnd();
                Dictionary = text.Split(
                    new char[] { ' ', '\n', '\t', '\r' }, 
                    StringSplitOptions.RemoveEmptyEntries
                );
            }
        }

        public string Similar(string word)
        {
            string res = Dictionary[0];
            int lDis = LevenshteinDistance.Find(word, Dictionary[0]);

            for (int i = 1; i < Dictionary.Length; i++)
            {
                int d = LevenshteinDistance.Find(word, Dictionary[i]);
                if (d < lDis)
                { 
                    res = Dictionary[i];
                    lDis = d;
                }
            }

            return res;
        }
    }
}

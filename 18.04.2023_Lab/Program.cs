using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _18._04._2023_Lab
{
    internal class Program
    {
        static void PrintColection(object col)
        { 
            foreach (var item in col as ICollection) 
            {
                Console.WriteLine(item.ToString());
            }
        }
        static void Main(string[] args)
        {
            List<string> strings = new List<string>();
            strings.Add("test 1");
            strings.Add("test 2");
            strings.Add("test 3");
            strings.Add("test 4");

            new Thread(new ParameterizedThreadStart(PrintColection)).Start(strings);
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Multitheding_Bank
{
    internal class Program
    {
        class Bank
        {
            int money;
            string name;
            int percent;

            public event Action<Bank>? PropertyChanges;

            public int Money { get => money; set { money = value; PropertyChanges?.Invoke(this); } }
            public string Name { get => name; set { name = value; PropertyChanges?.Invoke(this); } }
            public int Percent { get => percent; set { percent = value; PropertyChanges?.Invoke(this); } }
        }
        static void Main(string[] args)
        {
            Bank bank = new Bank();
            bank.Money = 0;
            bank.Name = "";
            bank.Percent = 0;

            bank.PropertyChanges += delegate (Bank a)
            {
                Thread thread = new Thread(new ThreadStart(() =>
                {
                    Console.WriteLine($"{a.Name}\n{a.Money}\n{a.Percent}\n");
                }));
                thread.Start();
            };

            bank.Money += 100;
            bank.Name = "Test 1";
            bank.Percent = 1;
            Thread.Sleep(100);
            bank.Name = "Test 2";
            bank.Money -= 10;

            Thread.CurrentThread.Join();
        }
    }
}

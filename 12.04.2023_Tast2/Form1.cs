using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _12._04._2023_Tast2
{
    public partial class Form1 : Form
    {
        private List<Product> products = new List<Product>();

        public Form1()
        {
            InitializeComponent();

            products.Add(new Product());
            products.Last().Name = "Дешёвая мышка";
            products.Last().Price = 50;
            products.Last().Description = "Не самая лучшая, за то дёшево.";

            products.Add(new Product());
            products.Last().Name = "Старая клавиатура";
            products.Last().Price = 200;
            products.Last().Description = "Проверяна временем.";

            products.Add(new Product());
            products.Last().Name = "Крутая мышка";
            products.Last().Price = 400;
            products.Last().Description = "Новая серия, такие только у нас и Елвиса.";

            products.Add(new Product());
            products.Last().Name = "Монитор";
            products.Last().Price = 3000;
            products.Last().Description = "Картинка как на фото.";

            comboBox1.Items.AddRange(products.Select(i => i.Name).ToArray());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 about = new Form2();
            Product product = products.First(i => i.Name == comboBox1.Text);
            about.NameP = product.Name;
            about.PriceP = product.Price;
            about.DescriptionP = product.Description;
            about.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int price = Convert.ToInt32(textBox1.Text);
            price += products.First(i => i.Name == comboBox1.Text).Price;
            textBox1.Text = price.ToString();
        }
    }
}

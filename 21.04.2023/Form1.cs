using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _21._04._2023
{
    public partial class Form : System.Windows.Forms.Form
    {
        public SynchronizationContext uiContext;

        List<Employee> employees = new List<Employee>();
        List<Student> students = new List<Student>();
        List<Book> books = new List<Book>();
        List<Product> products = new List<Product>();

        public Form()
        {
            InitializeComponent();
            uiContext = SynchronizationContext.Current;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            await Task.Run(() =>
            {
                var strings = employees.Where(p => p.HouseNumber % 2 == 0 && textBox.Text == p.Street).Select(p => $"{p.BIO} - {p.PhoneNumber}");
                uiContext.Send(p => listBox.Items.AddRange(strings.ToArray()), null);
            });
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            await Task.Run(() =>
            {
                var strings = employees.Where(p => (p.Birth.Year - 5) % 12 == 0).Select(p => $"{p.BIO} - {p.PhoneNumber}");
                uiContext.Send(p => listBox.Items.AddRange(strings.ToArray()), null);
            });
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            await Task.Run(() =>
            {
                var strings = students.OrderByDescending(p => p.Rating).Select(p => $"{p.BIO} - {p.Rating}");
                uiContext.Send(p => listBox.Items.AddRange(strings.ToArray()), null);
            });
        }

        private async void button4_Click(object sender, EventArgs e)
        {
            await Task.Run(() =>
            {
                var strings = books.Where(p => (p.Withdrawal - Convert.ToDateTime(textBox.Text)).Ticks < 0).Select(p => $"{p.Name} - {p.Withdrawal}");
                uiContext.Send(p => listBox.Items.AddRange(strings.ToArray()), null);
            });
        }

        private async void button5_Click(object sender, EventArgs e)
        {
            await Task.Run(() =>
            {
                var strings = products.Where(p => (p.BestBeforeDate - Convert.ToDateTime(textBox.Text)).Ticks < 0).Select(p => $"{p.Name} - {p.BestBeforeDate}");
                uiContext.Send(p => listBox.Items.AddRange(strings.ToArray()), null);
            });
        }

        private void Form_Load(object sender, EventArgs e)
        {
            #region employees fill
            Employee tempEmployee = new Employee();
            tempEmployee.BIO = "Лихачёв Ираклий Борисович";
            tempEmployee.Birth = new DateTime(1997, 12, 30);
            tempEmployee.PhoneNumber = 0964586163;
            tempEmployee.Street = "Левитана";
            tempEmployee.HouseNumber = 75;
            employees.Add(tempEmployee);

            tempEmployee = new Employee();
            tempEmployee.BIO = "Тимофеев Степан Данилович";
            tempEmployee.Birth = new DateTime(1987, 1,26);
            tempEmployee.PhoneNumber = 0968389223;
            tempEmployee.Street = "Толбухина";
            tempEmployee.HouseNumber = 2;
            employees.Add(tempEmployee);

            tempEmployee = new Employee();
            tempEmployee.BIO = "Волков Цицерон Сергеевич";
            tempEmployee.Birth = new DateTime(1995, 6, 13);
            tempEmployee.PhoneNumber = 0976854666;
            tempEmployee.Street = "Глушко";
            tempEmployee.HouseNumber = 44;
            employees.Add(tempEmployee);

            tempEmployee = new Employee();
            tempEmployee.BIO = "Терентьев Бронислав Дмитриевич";
            tempEmployee.Birth = new DateTime(1985, 3, 2);
            tempEmployee.PhoneNumber = 0960098961;
            tempEmployee.Street = "Архитекторская";
            tempEmployee.HouseNumber = 61;
            employees.Add(tempEmployee);

            tempEmployee = new Employee();
            tempEmployee.BIO = "Марков Дан Сергеевич";
            tempEmployee.Birth = new DateTime(1989, 5, 6);
            tempEmployee.PhoneNumber = 0973676554;
            tempEmployee.Street = "Грецкая";
            tempEmployee.HouseNumber = 24;
            employees.Add(tempEmployee);
            #endregion

            #region students fill
            Student tempStudent = new Student();
            tempStudent.BIO = "Голубев Эрик Данилович";
            tempStudent.Groupe = 174;
            tempStudent.Rating = 75;
            students.Add(tempStudent);

            tempStudent = new Student();
            tempStudent.BIO = "Наумов Максим Виталиевич";
            tempStudent.Groupe = 45;
            tempStudent.Rating = 36;
            students.Add(tempStudent);

            tempStudent = new Student();
            tempStudent.BIO = "Семёнов Устин Романович";
            tempStudent.Groupe = 148;
            tempStudent.Rating = 84;
            students.Add(tempStudent);

            tempStudent = new Student();
            tempStudent.BIO = "Терещенко Цицерон Сергеевич";
            tempStudent.Groupe = 118;
            tempStudent.Rating = 43;
            students.Add(tempStudent);

            tempStudent = new Student();
            tempStudent.BIO = "Уваров Яков Александрович";
            tempStudent.Groupe = 162;
            tempStudent.Rating = 23;
            students.Add(tempStudent);
            #endregion

            #region books fill
            Book tempBook = new Book();
            tempBook.Name = "Сам дурак! или Приключения дракоши";
            tempBook.Withdrawal = new DateTime(2023, 4, 29);
            tempBook.LibraryСard = 5;
            books.Add(tempBook);

            tempBook = new Book();
            tempBook.Name = "Перемены";
            tempBook.Withdrawal = new DateTime(2023, 4, 30);
            tempBook.LibraryСard = 25;
            books.Add(tempBook);

            tempBook = new Book();
            tempBook.Name = "Предел";
            tempBook.Withdrawal = new DateTime(2023, 5, 15);
            tempBook.LibraryСard = 1;
            books.Add(tempBook);

            tempBook = new Book();
            tempBook.Name = "Рождество в домике Петсона";
            tempBook.Withdrawal = new DateTime(2023, 5, 24);
            tempBook.LibraryСard = 6;
            books.Add(tempBook);

            tempBook = new Book();
            tempBook.Name = "Токийские легенды";
            tempBook.Withdrawal = new DateTime(2023, 3, 25);
            tempBook.LibraryСard = 26;
            books.Add(tempBook);
            #endregion

            #region products fill
            Product tempProduct = new Product();
            tempProduct.Name = "Чай Minutka";
            tempProduct.Description = "";
            tempProduct.BestBeforeDate = new DateTime(2024, 12, 29);
            products.Add(tempProduct);

            tempProduct = new Product();
            tempProduct.Name = "Грудинка «Глобинський МК»";
            tempProduct.Description = "";
            tempProduct.BestBeforeDate = new DateTime(2023, 3, 1);
            products.Add(tempProduct);

            tempProduct = new Product();
            tempProduct.Name = "Вермішель «КМФ»";
            tempProduct.Description = "";
            tempProduct.BestBeforeDate = new DateTime(2026, 4, 12);
            products.Add(tempProduct);

            tempProduct = new Product();
            tempProduct.Name = "Горошок зелений Kwidzyn";
            tempProduct.Description = "";
            tempProduct.BestBeforeDate = new DateTime(2025, 2, 21);
            products.Add(tempProduct);

            tempProduct = new Product();
            tempProduct.Name = "Аджика «Руна»";
            tempProduct.Description = "";
            tempProduct.BestBeforeDate = new DateTime(2024, 11, 11);
            products.Add(tempProduct);
            #endregion
        }
    }
}

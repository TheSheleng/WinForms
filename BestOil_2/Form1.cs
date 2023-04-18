using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BestOil_2
{
    public partial class BestOil : Form
    {
        SortedDictionary<string, float> FuelPrice;
        public BestOil()
        {
            InitializeComponent();

            FuelPrice = new SortedDictionary<string, float>();
            FuelPrice.Add("A-95 Premium", 49);
            FuelPrice.Add("A-95", 47);
            FuelPrice.Add("A-92", 46);
            FuelPrice.Add("Diesel", 47);
            FuelPrice.Add("Gas", 22);

            this.comboOil.Items.AddRange(FuelPrice.Keys.ToArray());
            this.comboOil.SelectedIndex = 0;
        }

        private void checkBoxFood1_CheckedChanged(object sender, EventArgs e)
        {
            if (!(textBoxFoodCount1.Enabled = checkBoxFood1.Checked))
                textBoxFoodCount1.Text = "0";
        }

        private void checkBoxFood2_CheckedChanged(object sender, EventArgs e)
        {
            if (!(textBoxFoodCount2.Enabled = checkBoxFood2.Checked))
                textBoxFoodCount2.Text = "0";
        }

        private void checkBoxFood3_CheckedChanged(object sender, EventArgs e)
        {
            if (!(textBoxFoodCount3.Enabled = checkBoxFood3.Checked))
                textBoxFoodCount3.Text = "0";
        }

        private void checkBoxFood4_CheckedChanged(object sender, EventArgs e)
        {
            if (!(textBoxFoodCount4.Enabled = checkBoxFood4.Checked))
                textBoxFoodCount4.Text = "0";
        }

        private void CalcTotalFoodPrice(object sender, EventArgs e)
        {
            try
            {
                double totalFoodPrice = 0;
                if (textBoxFoodCount1.Enabled) totalFoodPrice += Convert.ToDouble(textBoxFoodCount1.Text) * Convert.ToDouble(textBoxFoodPrice1.Text);
                if (textBoxFoodCount2.Enabled) totalFoodPrice += Convert.ToDouble(textBoxFoodCount2.Text) * Convert.ToDouble(textBoxFoodPrice2.Text);
                if (textBoxFoodCount3.Enabled) totalFoodPrice += Convert.ToDouble(textBoxFoodCount3.Text) * Convert.ToDouble(textBoxFoodPrice3.Text);
                if (textBoxFoodCount4.Enabled) totalFoodPrice += Convert.ToDouble(textBoxFoodCount4.Text) * Convert.ToDouble(textBoxFoodPrice4.Text);
                FoodPrice.Text = totalFoodPrice.ToString(); 
            }
            catch 
            {
                FoodPrice.Text = "#Error";
            }
        }

        private void comboOil_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.textBoxPriceOil.Text = FuelPrice[comboOil.SelectedItem.ToString()].ToString();
            this.textBoxOilByAmount.Text = "0";
            this.textBoxOilByPrice.Text = "0";
        }

        private void textBoxOilByAmount_TextChanged(object sender, EventArgs e)
        {
            if (this.radioOilByAmount.Checked)
            {
                try
                {
                    this.textBoxOilByPrice.Text = 
                        (Convert.ToSingle(this.textBoxOilByAmount.Text) * 
                        Convert.ToSingle(this.textBoxPriceOil.Text))
                        .ToString();
                }
                catch
                {
                    this.textBoxOilByPrice.Text = "#Error";
                }
                this.AutoPrice.Text = this.textBoxOilByPrice.Text;
            }
        }

        private void radioOilByPrice_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioOilByAmount.Checked)
            {
                this.textBoxOilByPrice.ReadOnly = true;
                this.textBoxOilByAmount.ReadOnly = false;
            }
        }

        private void radioOilByAmount_CheckedChanged(object sender, EventArgs e)
        {

            if (this.radioOilByPrice.Checked)
            {
                this.textBoxOilByPrice.ReadOnly = false;
                this.textBoxOilByAmount.ReadOnly = true;
            }
        }

        private void textBoxOilByPrice_TextChanged(object sender, EventArgs e)
        {
            if (this.radioOilByPrice.Checked)
            {
                try
                {
                    this.textBoxOilByAmount.Text =
                        (Convert.ToSingle(this.textBoxOilByPrice.Text) /
                        Convert.ToSingle(this.textBoxPriceOil.Text))
                        .ToString();
                }
                catch
                {
                    this.textBoxOilByAmount.Text = "#Error";
                }
                this.AutoPrice.Text = this.textBoxOilByPrice.Text;
            }
        }

        private void AutoOrFoodPrice_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.TotalPrice.Text = 
                    (Convert.ToSingle(this.AutoPrice.Text) + 
                    Convert.ToSingle(this.FoodPrice.Text))
                    .ToString();
            }
            catch
            {
                this.TotalPrice.Text = "#Error";
            }
        }

        private void buttonFinalCulc_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Сумма заказа: {this.TotalPrice.Text}", "Посчитано");
        }
    }
}

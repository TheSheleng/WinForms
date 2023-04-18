namespace BestOil_2
{
    partial class BestOil
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPagePrice = new System.Windows.Forms.TabPage();
            this.groupMain = new System.Windows.Forms.GroupBox();
            this.TotalPriceL = new System.Windows.Forms.Label();
            this.TotalPrice = new System.Windows.Forms.Label();
            this.buttonFinalCulc = new System.Windows.Forms.Button();
            this.picture = new System.Windows.Forms.PictureBox();
            this.tabPageOil = new System.Windows.Forms.TabPage();
            this.textBoxPriceOil = new System.Windows.Forms.TextBox();
            this.groupTotalOilPrice = new System.Windows.Forms.GroupBox();
            this.AutoRiceL = new System.Windows.Forms.Label();
            this.AutoPrice = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxOilByPrice = new System.Windows.Forms.TextBox();
            this.textBoxOilByAmount = new System.Windows.Forms.TextBox();
            this.labelAmountOil = new System.Windows.Forms.Label();
            this.labelTotalOilPriceOil = new System.Windows.Forms.Label();
            this.radioOilByPrice = new System.Windows.Forms.RadioButton();
            this.radioOilByAmount = new System.Windows.Forms.RadioButton();
            this.labelPriceOil = new System.Windows.Forms.Label();
            this.labelOil = new System.Windows.Forms.Label();
            this.comboOil = new System.Windows.Forms.ComboBox();
            this.tabPageCofe = new System.Windows.Forms.TabPage();
            this.textBoxFoodCount4 = new System.Windows.Forms.TextBox();
            this.textBoxFoodCount3 = new System.Windows.Forms.TextBox();
            this.textBoxFoodPrice4 = new System.Windows.Forms.TextBox();
            this.textBoxFoodPrice3 = new System.Windows.Forms.TextBox();
            this.checkBoxFood4 = new System.Windows.Forms.CheckBox();
            this.checkBoxFood3 = new System.Windows.Forms.CheckBox();
            this.textBoxFoodCount2 = new System.Windows.Forms.TextBox();
            this.textBoxFoodPrice2 = new System.Windows.Forms.TextBox();
            this.checkBoxFood2 = new System.Windows.Forms.CheckBox();
            this.textBoxFoodCount1 = new System.Windows.Forms.TextBox();
            this.labelFoodCount = new System.Windows.Forms.Label();
            this.labelPriceFood = new System.Windows.Forms.Label();
            this.textBoxFoodPrice1 = new System.Windows.Forms.TextBox();
            this.checkBoxFood1 = new System.Windows.Forms.CheckBox();
            this.groupTotalFoodPrice = new System.Windows.Forms.GroupBox();
            this.FoodPriceL = new System.Windows.Forms.Label();
            this.FoodPrice = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPagePrice.SuspendLayout();
            this.groupMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.tabPageOil.SuspendLayout();
            this.groupTotalOilPrice.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPageCofe.SuspendLayout();
            this.groupTotalFoodPrice.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPagePrice);
            this.tabControl1.Controls.Add(this.tabPageOil);
            this.tabControl1.Controls.Add(this.tabPageCofe);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(617, 536);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPagePrice
            // 
            this.tabPagePrice.Controls.Add(this.groupMain);
            this.tabPagePrice.Location = new System.Drawing.Point(4, 46);
            this.tabPagePrice.Name = "tabPagePrice";
            this.tabPagePrice.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePrice.Size = new System.Drawing.Size(609, 486);
            this.tabPagePrice.TabIndex = 0;
            this.tabPagePrice.Text = "Оплата";
            this.tabPagePrice.UseVisualStyleBackColor = true;
            // 
            // groupMain
            // 
            this.groupMain.Controls.Add(this.TotalPriceL);
            this.groupMain.Controls.Add(this.TotalPrice);
            this.groupMain.Controls.Add(this.buttonFinalCulc);
            this.groupMain.Controls.Add(this.picture);
            this.groupMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupMain.Location = new System.Drawing.Point(6, 6);
            this.groupMain.Name = "groupMain";
            this.groupMain.Size = new System.Drawing.Size(590, 385);
            this.groupMain.TabIndex = 0;
            this.groupMain.TabStop = false;
            this.groupMain.Text = "ВСЕГО к оплате";
            // 
            // TotalPriceL
            // 
            this.TotalPriceL.AutoSize = true;
            this.TotalPriceL.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalPriceL.Location = new System.Drawing.Point(444, 314);
            this.TotalPriceL.Name = "TotalPriceL";
            this.TotalPriceL.Size = new System.Drawing.Size(69, 37);
            this.TotalPriceL.TabIndex = 2;
            this.TotalPriceL.Text = "грн.";
            // 
            // TotalPrice
            // 
            this.TotalPrice.AutoSize = true;
            this.TotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalPrice.Location = new System.Drawing.Point(60, 276);
            this.TotalPrice.Name = "TotalPrice";
            this.TotalPrice.Size = new System.Drawing.Size(255, 82);
            this.TotalPrice.TabIndex = 1;
            this.TotalPrice.Text = "0,0000";
            // 
            // buttonFinalCulc
            // 
            this.buttonFinalCulc.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFinalCulc.Location = new System.Drawing.Point(206, 70);
            this.buttonFinalCulc.Name = "buttonFinalCulc";
            this.buttonFinalCulc.Size = new System.Drawing.Size(316, 171);
            this.buttonFinalCulc.TabIndex = 1;
            this.buttonFinalCulc.Text = "Подсчитать";
            this.buttonFinalCulc.UseVisualStyleBackColor = true;
            this.buttonFinalCulc.Click += new System.EventHandler(this.buttonFinalCulc_Click);
            // 
            // picture
            // 
            this.picture.Image = global::BestOil_2.Properties.Resources.red;
            this.picture.Location = new System.Drawing.Point(22, 70);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(100, 100);
            this.picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picture.TabIndex = 1;
            this.picture.TabStop = false;
            // 
            // tabPageOil
            // 
            this.tabPageOil.Controls.Add(this.textBoxPriceOil);
            this.tabPageOil.Controls.Add(this.groupTotalOilPrice);
            this.tabPageOil.Controls.Add(this.groupBox2);
            this.tabPageOil.Controls.Add(this.labelPriceOil);
            this.tabPageOil.Controls.Add(this.labelOil);
            this.tabPageOil.Controls.Add(this.comboOil);
            this.tabPageOil.Location = new System.Drawing.Point(4, 46);
            this.tabPageOil.Name = "tabPageOil";
            this.tabPageOil.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageOil.Size = new System.Drawing.Size(609, 486);
            this.tabPageOil.TabIndex = 1;
            this.tabPageOil.Text = "Автозаправка";
            this.tabPageOil.UseVisualStyleBackColor = true;
            // 
            // textBoxPriceOil
            // 
            this.textBoxPriceOil.Location = new System.Drawing.Point(423, 13);
            this.textBoxPriceOil.Name = "textBoxPriceOil";
            this.textBoxPriceOil.ReadOnly = true;
            this.textBoxPriceOil.Size = new System.Drawing.Size(162, 44);
            this.textBoxPriceOil.TabIndex = 6;
            // 
            // groupTotalOilPrice
            // 
            this.groupTotalOilPrice.Controls.Add(this.AutoRiceL);
            this.groupTotalOilPrice.Controls.Add(this.AutoPrice);
            this.groupTotalOilPrice.Location = new System.Drawing.Point(3, 247);
            this.groupTotalOilPrice.Name = "groupTotalOilPrice";
            this.groupTotalOilPrice.Size = new System.Drawing.Size(590, 145);
            this.groupTotalOilPrice.TabIndex = 5;
            this.groupTotalOilPrice.TabStop = false;
            this.groupTotalOilPrice.Text = "К оплате";
            // 
            // AutoRiceL
            // 
            this.AutoRiceL.AutoSize = true;
            this.AutoRiceL.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AutoRiceL.Location = new System.Drawing.Point(514, 78);
            this.AutoRiceL.Name = "AutoRiceL";
            this.AutoRiceL.Size = new System.Drawing.Size(69, 37);
            this.AutoRiceL.TabIndex = 4;
            this.AutoRiceL.Text = "грн.";
            // 
            // AutoPrice
            // 
            this.AutoPrice.AutoSize = true;
            this.AutoPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AutoPrice.Location = new System.Drawing.Point(253, 40);
            this.AutoPrice.Name = "AutoPrice";
            this.AutoPrice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.AutoPrice.Size = new System.Drawing.Size(255, 82);
            this.AutoPrice.TabIndex = 3;
            this.AutoPrice.Text = "0,0000";
            this.AutoPrice.TextChanged += new System.EventHandler(this.AutoOrFoodPrice_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxOilByPrice);
            this.groupBox2.Controls.Add(this.textBoxOilByAmount);
            this.groupBox2.Controls.Add(this.labelAmountOil);
            this.groupBox2.Controls.Add(this.labelTotalOilPriceOil);
            this.groupBox2.Controls.Add(this.radioOilByPrice);
            this.groupBox2.Controls.Add(this.radioOilByAmount);
            this.groupBox2.Location = new System.Drawing.Point(6, 63);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(590, 178);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // textBoxOilByPrice
            // 
            this.textBoxOilByPrice.Location = new System.Drawing.Point(251, 105);
            this.textBoxOilByPrice.Name = "textBoxOilByPrice";
            this.textBoxOilByPrice.ReadOnly = true;
            this.textBoxOilByPrice.Size = new System.Drawing.Size(257, 44);
            this.textBoxOilByPrice.TabIndex = 9;
            this.textBoxOilByPrice.TextChanged += new System.EventHandler(this.textBoxOilByPrice_TextChanged);
            // 
            // textBoxOilByAmount
            // 
            this.textBoxOilByAmount.Location = new System.Drawing.Point(251, 42);
            this.textBoxOilByAmount.Name = "textBoxOilByAmount";
            this.textBoxOilByAmount.Size = new System.Drawing.Size(257, 44);
            this.textBoxOilByAmount.TabIndex = 8;
            this.textBoxOilByAmount.TextChanged += new System.EventHandler(this.textBoxOilByAmount_TextChanged);
            // 
            // labelAmountOil
            // 
            this.labelAmountOil.AutoSize = true;
            this.labelAmountOil.Location = new System.Drawing.Point(514, 45);
            this.labelAmountOil.Name = "labelAmountOil";
            this.labelAmountOil.Size = new System.Drawing.Size(42, 37);
            this.labelAmountOil.TabIndex = 7;
            this.labelAmountOil.Text = "л.";
            // 
            // labelTotalOilPriceOil
            // 
            this.labelTotalOilPriceOil.AutoSize = true;
            this.labelTotalOilPriceOil.Location = new System.Drawing.Point(514, 108);
            this.labelTotalOilPriceOil.Name = "labelTotalOilPriceOil";
            this.labelTotalOilPriceOil.Size = new System.Drawing.Size(69, 37);
            this.labelTotalOilPriceOil.TabIndex = 5;
            this.labelTotalOilPriceOil.Text = "грн.";
            // 
            // radioOilByPrice
            // 
            this.radioOilByPrice.AutoSize = true;
            this.radioOilByPrice.Location = new System.Drawing.Point(20, 103);
            this.radioOilByPrice.Name = "radioOilByPrice";
            this.radioOilByPrice.Size = new System.Drawing.Size(114, 41);
            this.radioOilByPrice.TabIndex = 6;
            this.radioOilByPrice.Text = "Цена";
            this.radioOilByPrice.UseVisualStyleBackColor = true;
            this.radioOilByPrice.CheckedChanged += new System.EventHandler(this.radioOilByPrice_CheckedChanged);
            // 
            // radioOilByAmount
            // 
            this.radioOilByAmount.AutoSize = true;
            this.radioOilByAmount.Checked = true;
            this.radioOilByAmount.Location = new System.Drawing.Point(20, 43);
            this.radioOilByAmount.Name = "radioOilByAmount";
            this.radioOilByAmount.Size = new System.Drawing.Size(208, 41);
            this.radioOilByAmount.TabIndex = 5;
            this.radioOilByAmount.TabStop = true;
            this.radioOilByAmount.Text = "Количество";
            this.radioOilByAmount.UseVisualStyleBackColor = true;
            this.radioOilByAmount.CheckedChanged += new System.EventHandler(this.radioOilByAmount_CheckedChanged);
            // 
            // labelPriceOil
            // 
            this.labelPriceOil.AutoSize = true;
            this.labelPriceOil.Location = new System.Drawing.Point(328, 16);
            this.labelPriceOil.Name = "labelPriceOil";
            this.labelPriceOil.Size = new System.Drawing.Size(89, 37);
            this.labelPriceOil.TabIndex = 2;
            this.labelPriceOil.Text = "Цена";
            // 
            // labelOil
            // 
            this.labelOil.AutoSize = true;
            this.labelOil.Location = new System.Drawing.Point(6, 15);
            this.labelOil.Name = "labelOil";
            this.labelOil.Size = new System.Drawing.Size(116, 37);
            this.labelOil.TabIndex = 1;
            this.labelOil.Text = "Бензин";
            // 
            // comboOil
            // 
            this.comboOil.FormattingEnabled = true;
            this.comboOil.Location = new System.Drawing.Point(136, 12);
            this.comboOil.Name = "comboOil";
            this.comboOil.Size = new System.Drawing.Size(171, 45);
            this.comboOil.TabIndex = 0;
            this.comboOil.SelectedIndexChanged += new System.EventHandler(this.comboOil_SelectedIndexChanged);
            // 
            // tabPageCofe
            // 
            this.tabPageCofe.Controls.Add(this.textBoxFoodCount4);
            this.tabPageCofe.Controls.Add(this.textBoxFoodCount3);
            this.tabPageCofe.Controls.Add(this.textBoxFoodPrice4);
            this.tabPageCofe.Controls.Add(this.textBoxFoodPrice3);
            this.tabPageCofe.Controls.Add(this.checkBoxFood4);
            this.tabPageCofe.Controls.Add(this.checkBoxFood3);
            this.tabPageCofe.Controls.Add(this.textBoxFoodCount2);
            this.tabPageCofe.Controls.Add(this.textBoxFoodPrice2);
            this.tabPageCofe.Controls.Add(this.checkBoxFood2);
            this.tabPageCofe.Controls.Add(this.textBoxFoodCount1);
            this.tabPageCofe.Controls.Add(this.labelFoodCount);
            this.tabPageCofe.Controls.Add(this.labelPriceFood);
            this.tabPageCofe.Controls.Add(this.textBoxFoodPrice1);
            this.tabPageCofe.Controls.Add(this.checkBoxFood1);
            this.tabPageCofe.Controls.Add(this.groupTotalFoodPrice);
            this.tabPageCofe.Location = new System.Drawing.Point(4, 46);
            this.tabPageCofe.Name = "tabPageCofe";
            this.tabPageCofe.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCofe.Size = new System.Drawing.Size(609, 486);
            this.tabPageCofe.TabIndex = 2;
            this.tabPageCofe.Text = "Мини-кафе";
            this.tabPageCofe.UseVisualStyleBackColor = true;
            // 
            // textBoxFoodCount4
            // 
            this.textBoxFoodCount4.Enabled = false;
            this.textBoxFoodCount4.Location = new System.Drawing.Point(476, 239);
            this.textBoxFoodCount4.Name = "textBoxFoodCount4";
            this.textBoxFoodCount4.Size = new System.Drawing.Size(120, 44);
            this.textBoxFoodCount4.TabIndex = 14;
            this.textBoxFoodCount4.Text = "0";
            this.textBoxFoodCount4.TextChanged += new System.EventHandler(this.CalcTotalFoodPrice);
            // 
            // textBoxFoodCount3
            // 
            this.textBoxFoodCount3.Enabled = false;
            this.textBoxFoodCount3.Location = new System.Drawing.Point(476, 177);
            this.textBoxFoodCount3.Name = "textBoxFoodCount3";
            this.textBoxFoodCount3.Size = new System.Drawing.Size(120, 44);
            this.textBoxFoodCount3.TabIndex = 17;
            this.textBoxFoodCount3.Text = "0";
            this.textBoxFoodCount3.TextChanged += new System.EventHandler(this.CalcTotalFoodPrice);
            // 
            // textBoxFoodPrice4
            // 
            this.textBoxFoodPrice4.Location = new System.Drawing.Point(308, 239);
            this.textBoxFoodPrice4.Name = "textBoxFoodPrice4";
            this.textBoxFoodPrice4.ReadOnly = true;
            this.textBoxFoodPrice4.Size = new System.Drawing.Size(120, 44);
            this.textBoxFoodPrice4.TabIndex = 13;
            this.textBoxFoodPrice4.Text = "4,40";
            // 
            // textBoxFoodPrice3
            // 
            this.textBoxFoodPrice3.Location = new System.Drawing.Point(308, 177);
            this.textBoxFoodPrice3.Name = "textBoxFoodPrice3";
            this.textBoxFoodPrice3.ReadOnly = true;
            this.textBoxFoodPrice3.Size = new System.Drawing.Size(120, 44);
            this.textBoxFoodPrice3.TabIndex = 16;
            this.textBoxFoodPrice3.Text = "7,20";
            // 
            // checkBoxFood4
            // 
            this.checkBoxFood4.AutoSize = true;
            this.checkBoxFood4.Location = new System.Drawing.Point(6, 242);
            this.checkBoxFood4.Name = "checkBoxFood4";
            this.checkBoxFood4.Size = new System.Drawing.Size(194, 41);
            this.checkBoxFood4.TabIndex = 12;
            this.checkBoxFood4.Text = "Кока-кола";
            this.checkBoxFood4.UseVisualStyleBackColor = true;
            this.checkBoxFood4.CheckedChanged += new System.EventHandler(this.checkBoxFood4_CheckedChanged);
            // 
            // checkBoxFood3
            // 
            this.checkBoxFood3.AutoSize = true;
            this.checkBoxFood3.Location = new System.Drawing.Point(6, 180);
            this.checkBoxFood3.Name = "checkBoxFood3";
            this.checkBoxFood3.Size = new System.Drawing.Size(249, 41);
            this.checkBoxFood3.TabIndex = 15;
            this.checkBoxFood3.Text = "Картошка фри";
            this.checkBoxFood3.UseVisualStyleBackColor = true;
            this.checkBoxFood3.CheckedChanged += new System.EventHandler(this.checkBoxFood3_CheckedChanged);
            // 
            // textBoxFoodCount2
            // 
            this.textBoxFoodCount2.Enabled = false;
            this.textBoxFoodCount2.Location = new System.Drawing.Point(476, 115);
            this.textBoxFoodCount2.Name = "textBoxFoodCount2";
            this.textBoxFoodCount2.Size = new System.Drawing.Size(120, 44);
            this.textBoxFoodCount2.TabIndex = 14;
            this.textBoxFoodCount2.Text = "0";
            this.textBoxFoodCount2.TextChanged += new System.EventHandler(this.CalcTotalFoodPrice);
            // 
            // textBoxFoodPrice2
            // 
            this.textBoxFoodPrice2.Location = new System.Drawing.Point(308, 115);
            this.textBoxFoodPrice2.Name = "textBoxFoodPrice2";
            this.textBoxFoodPrice2.ReadOnly = true;
            this.textBoxFoodPrice2.Size = new System.Drawing.Size(120, 44);
            this.textBoxFoodPrice2.TabIndex = 13;
            this.textBoxFoodPrice2.Text = "5,40";
            // 
            // checkBoxFood2
            // 
            this.checkBoxFood2.AutoSize = true;
            this.checkBoxFood2.Location = new System.Drawing.Point(6, 118);
            this.checkBoxFood2.Name = "checkBoxFood2";
            this.checkBoxFood2.Size = new System.Drawing.Size(192, 41);
            this.checkBoxFood2.TabIndex = 12;
            this.checkBoxFood2.Text = "Гамбургер";
            this.checkBoxFood2.UseVisualStyleBackColor = true;
            this.checkBoxFood2.CheckedChanged += new System.EventHandler(this.checkBoxFood2_CheckedChanged);
            // 
            // textBoxFoodCount1
            // 
            this.textBoxFoodCount1.Enabled = false;
            this.textBoxFoodCount1.Location = new System.Drawing.Point(476, 55);
            this.textBoxFoodCount1.Name = "textBoxFoodCount1";
            this.textBoxFoodCount1.Size = new System.Drawing.Size(120, 44);
            this.textBoxFoodCount1.TabIndex = 11;
            this.textBoxFoodCount1.Text = "0";
            this.textBoxFoodCount1.TextChanged += new System.EventHandler(this.CalcTotalFoodPrice);
            // 
            // labelFoodCount
            // 
            this.labelFoodCount.AutoSize = true;
            this.labelFoodCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFoodCount.Location = new System.Drawing.Point(474, 15);
            this.labelFoodCount.Name = "labelFoodCount";
            this.labelFoodCount.Size = new System.Drawing.Size(115, 37);
            this.labelFoodCount.TabIndex = 10;
            this.labelFoodCount.Text = "Кол-во";
            // 
            // labelPriceFood
            // 
            this.labelPriceFood.AutoSize = true;
            this.labelPriceFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPriceFood.Location = new System.Drawing.Point(325, 15);
            this.labelPriceFood.Name = "labelPriceFood";
            this.labelPriceFood.Size = new System.Drawing.Size(89, 37);
            this.labelPriceFood.TabIndex = 5;
            this.labelPriceFood.Text = "Цена";
            // 
            // textBoxFoodPrice1
            // 
            this.textBoxFoodPrice1.Location = new System.Drawing.Point(308, 55);
            this.textBoxFoodPrice1.Name = "textBoxFoodPrice1";
            this.textBoxFoodPrice1.ReadOnly = true;
            this.textBoxFoodPrice1.Size = new System.Drawing.Size(120, 44);
            this.textBoxFoodPrice1.TabIndex = 8;
            this.textBoxFoodPrice1.Text = "4,00";
            // 
            // checkBoxFood1
            // 
            this.checkBoxFood1.AutoSize = true;
            this.checkBoxFood1.Location = new System.Drawing.Point(6, 58);
            this.checkBoxFood1.Name = "checkBoxFood1";
            this.checkBoxFood1.Size = new System.Drawing.Size(151, 41);
            this.checkBoxFood1.TabIndex = 7;
            this.checkBoxFood1.Text = "Хот-дог";
            this.checkBoxFood1.UseVisualStyleBackColor = true;
            this.checkBoxFood1.CheckedChanged += new System.EventHandler(this.checkBoxFood1_CheckedChanged);
            // 
            // groupTotalFoodPrice
            // 
            this.groupTotalFoodPrice.Controls.Add(this.FoodPriceL);
            this.groupTotalFoodPrice.Controls.Add(this.FoodPrice);
            this.groupTotalFoodPrice.Location = new System.Drawing.Point(6, 315);
            this.groupTotalFoodPrice.Name = "groupTotalFoodPrice";
            this.groupTotalFoodPrice.Size = new System.Drawing.Size(590, 145);
            this.groupTotalFoodPrice.TabIndex = 6;
            this.groupTotalFoodPrice.TabStop = false;
            this.groupTotalFoodPrice.Text = "К оплате";
            // 
            // FoodPriceL
            // 
            this.FoodPriceL.AutoSize = true;
            this.FoodPriceL.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FoodPriceL.Location = new System.Drawing.Point(514, 78);
            this.FoodPriceL.Name = "FoodPriceL";
            this.FoodPriceL.Size = new System.Drawing.Size(69, 37);
            this.FoodPriceL.TabIndex = 4;
            this.FoodPriceL.Text = "грн.";
            // 
            // FoodPrice
            // 
            this.FoodPrice.AutoSize = true;
            this.FoodPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FoodPrice.Location = new System.Drawing.Point(253, 40);
            this.FoodPrice.Name = "FoodPrice";
            this.FoodPrice.Size = new System.Drawing.Size(255, 82);
            this.FoodPrice.TabIndex = 3;
            this.FoodPrice.Text = "0,0000";
            this.FoodPrice.TextChanged += new System.EventHandler(this.AutoOrFoodPrice_TextChanged);
            // 
            // BestOil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 560);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "BestOil";
            this.Text = "Form";
            this.tabControl1.ResumeLayout(false);
            this.tabPagePrice.ResumeLayout(false);
            this.groupMain.ResumeLayout(false);
            this.groupMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.tabPageOil.ResumeLayout(false);
            this.tabPageOil.PerformLayout();
            this.groupTotalOilPrice.ResumeLayout(false);
            this.groupTotalOilPrice.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPageCofe.ResumeLayout(false);
            this.tabPageCofe.PerformLayout();
            this.groupTotalFoodPrice.ResumeLayout(false);
            this.groupTotalFoodPrice.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPagePrice;
        private System.Windows.Forms.TabPage tabPageOil;
        private System.Windows.Forms.TabPage tabPageCofe;
        private System.Windows.Forms.GroupBox groupMain;
        private System.Windows.Forms.Label TotalPriceL;
        private System.Windows.Forms.Label TotalPrice;
        private System.Windows.Forms.Button buttonFinalCulc;
        private System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.GroupBox groupTotalOilPrice;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelAmountOil;
        private System.Windows.Forms.Label labelTotalOilPriceOil;
        private System.Windows.Forms.RadioButton radioOilByPrice;
        private System.Windows.Forms.RadioButton radioOilByAmount;
        private System.Windows.Forms.Label labelPriceOil;
        private System.Windows.Forms.Label labelOil;
        private System.Windows.Forms.ComboBox comboOil;
        private System.Windows.Forms.TextBox textBoxOilByPrice;
        private System.Windows.Forms.TextBox textBoxOilByAmount;
        private System.Windows.Forms.TextBox textBoxPriceOil;
        private System.Windows.Forms.Label AutoRiceL;
        private System.Windows.Forms.Label AutoPrice;
        private System.Windows.Forms.Label labelFoodCount;
        private System.Windows.Forms.Label labelPriceFood;
        private System.Windows.Forms.TextBox textBoxFoodPrice1;
        private System.Windows.Forms.CheckBox checkBoxFood1;
        private System.Windows.Forms.GroupBox groupTotalFoodPrice;
        private System.Windows.Forms.Label FoodPriceL;
        private System.Windows.Forms.Label FoodPrice;
        private System.Windows.Forms.TextBox textBoxFoodCount4;
        private System.Windows.Forms.TextBox textBoxFoodCount3;
        private System.Windows.Forms.TextBox textBoxFoodPrice4;
        private System.Windows.Forms.TextBox textBoxFoodPrice3;
        private System.Windows.Forms.CheckBox checkBoxFood4;
        private System.Windows.Forms.CheckBox checkBoxFood3;
        private System.Windows.Forms.TextBox textBoxFoodCount2;
        private System.Windows.Forms.TextBox textBoxFoodPrice2;
        private System.Windows.Forms.CheckBox checkBoxFood2;
        private System.Windows.Forms.TextBox textBoxFoodCount1;
    }
}


namespace _12._04._2023_Task1
{
    partial class Form
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
            this.search = new System.Windows.Forms.Button();
            this.listBox = new System.Windows.Forms.ListBox();
            this.clear = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(12, 12);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(243, 46);
            this.search.TabIndex = 0;
            this.search.Text = "Search";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 20;
            this.listBox.Location = new System.Drawing.Point(12, 103);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(486, 584);
            this.listBox.TabIndex = 2;
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(258, 12);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(240, 85);
            this.clear.TabIndex = 3;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(12, 64);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(240, 26);
            this.textBox.TabIndex = 4;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 700);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.search);
            this.Name = "Form";
            this.Text = "FileSerch";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button search;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
    }
}


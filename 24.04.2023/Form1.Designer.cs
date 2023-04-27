namespace _24._04._2023
{
    partial class Form1
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
            this.FolderTextBox = new System.Windows.Forms.TextBox();
            this.FindTextBox = new System.Windows.Forms.TextBox();
            this.Subdirectories = new System.Windows.Forms.CheckBox();
            this.Start = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.OpenFolder = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox = new System.Windows.Forms.ListBox();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // FolderTextBox
            // 
            this.FolderTextBox.Location = new System.Drawing.Point(173, 13);
            this.FolderTextBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.FolderTextBox.Name = "FolderTextBox";
            this.FolderTextBox.Size = new System.Drawing.Size(312, 35);
            this.FolderTextBox.TabIndex = 0;
            // 
            // FindTextBox
            // 
            this.FindTextBox.Location = new System.Drawing.Point(173, 67);
            this.FindTextBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.FindTextBox.Name = "FindTextBox";
            this.FindTextBox.Size = new System.Drawing.Size(404, 35);
            this.FindTextBox.TabIndex = 1;
            // 
            // Subdirectories
            // 
            this.Subdirectories.AutoSize = true;
            this.Subdirectories.Location = new System.Drawing.Point(17, 138);
            this.Subdirectories.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Subdirectories.Name = "Subdirectories";
            this.Subdirectories.Size = new System.Drawing.Size(229, 33);
            this.Subdirectories.TabIndex = 2;
            this.Subdirectories.Text = "Под директории";
            this.Subdirectories.UseVisualStyleBackColor = true;
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(256, 117);
            this.Start.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(321, 72);
            this.Start.TabIndex = 3;
            this.Start.Text = "Искать";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Директория";
            // 
            // OpenFolder
            // 
            this.OpenFolder.Location = new System.Drawing.Point(495, 9);
            this.OpenFolder.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.OpenFolder.Name = "OpenFolder";
            this.OpenFolder.Size = new System.Drawing.Size(82, 35);
            this.OpenFolder.TabIndex = 5;
            this.OpenFolder.Text = "...";
            this.OpenFolder.UseVisualStyleBackColor = true;
            this.OpenFolder.Click += new System.EventHandler(this.OpenFolder_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "Фрагмент";
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 29;
            this.listBox.Location = new System.Drawing.Point(12, 196);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(565, 439);
            this.listBox.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 652);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.OpenFolder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.Subdirectories);
            this.Controls.Add(this.FindTextBox);
            this.Controls.Add(this.FolderTextBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FolderTextBox;
        private System.Windows.Forms.TextBox FindTextBox;
        private System.Windows.Forms.CheckBox Subdirectories;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button OpenFolder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
    }
}


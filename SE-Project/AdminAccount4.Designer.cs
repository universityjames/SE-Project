namespace TogetherCulture
{
    partial class AdminAccount4
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
            button2 = new Button();
            listBox2 = new ListBox();
            listBox1 = new ListBox();
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            SuspendLayout();
            // 
            // button2
            // 
            button2.BackColor = SystemColors.MenuHighlight;
            button2.ForeColor = SystemColors.Control;
            button2.Location = new Point(30, 37);
            button2.Name = "button2";
            button2.Size = new Size(91, 40);
            button2.TabIndex = 23;
            button2.Text = "Dashboard";
            button2.UseVisualStyleBackColor = false;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Items.AddRange(new object[] { "Description..." });
            listBox2.Location = new Point(45, 167);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(180, 184);
            listBox2.TabIndex = 24;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Items.AddRange(new object[] { "..." });
            listBox1.Location = new Point(243, 167);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(416, 184);
            listBox1.TabIndex = 25;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(243, 147);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(238, 23);
            textBox1.TabIndex = 26;
            textBox1.Text = "Search event/module...";
            // 
            // comboBox1
            // 
            comboBox1.AccessibleDescription = "";
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(472, 147);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(187, 23);
            comboBox1.TabIndex = 27;
            comboBox1.Text = "Sort By";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(45, 147);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(121, 23);
            textBox2.TabIndex = 28;
            textBox2.Text = "Name";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(154, 147);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(71, 23);
            textBox3.TabIndex = 29;
            textBox3.Text = "N. of Guests";
            // 
            // AdminAccount4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(comboBox1);
            Controls.Add(textBox1);
            Controls.Add(listBox1);
            Controls.Add(listBox2);
            Controls.Add(button2);
            Name = "AdminAccount4";
            Text = "Together Culture Adminstrator Account event/module info";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private ListBox listBox2;
        private ListBox listBox1;
        private TextBox textBox1;
        private ComboBox comboBox1;
        private TextBox textBox2;
        private TextBox textBox3;
    }
}
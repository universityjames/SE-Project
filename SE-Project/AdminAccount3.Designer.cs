namespace TogetherCulture
{
    partial class AdminAccount3
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
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            button2 = new Button();
            textBox1 = new TextBox();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.AccessibleDescription = "";
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(500, 147);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(111, 23);
            comboBox1.TabIndex = 21;
            comboBox1.Text = "Sort By";
            // 
            // comboBox2
            // 
            comboBox2.AccessibleDescription = "";
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(372, 147);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(133, 23);
            comboBox2.TabIndex = 17;
            comboBox2.Text = "Filter";
            // 
            // button2
            // 
            button2.BackColor = SystemColors.MenuHighlight;
            button2.ForeColor = SystemColors.Control;
            button2.Location = new Point(48, 38);
            button2.Name = "button2";
            button2.Size = new Size(91, 40);
            button2.TabIndex = 20;
            button2.Text = "Dashboard";
            button2.UseVisualStyleBackColor = false;
            button2.Click += this.button2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(109, 147);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(266, 23);
            textBox1.TabIndex = 19;
            textBox1.Text = "Search event/module...";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Items.AddRange(new object[] { "..." });
            listBox1.Location = new Point(109, 167);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(502, 184);
            listBox1.TabIndex = 18;
            // 
            // AdminAccount3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBox1);
            Controls.Add(comboBox2);
            Controls.Add(button2);
            Controls.Add(textBox1);
            Controls.Add(listBox1);
            Name = "AdminAccount3";
            Text = "Together Culture Administrator Account event/module list";
            Load += this.AdminAccount3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Button button2;
        private TextBox textBox1;
        private ListBox listBox1;
    }
}
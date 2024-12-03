namespace TogetherCulture
{
    partial class AdminAccount
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
            comboBox2 = new ComboBox();
            listBox1 = new ListBox();
            textBox1 = new TextBox();
            button2 = new Button();
            comboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // comboBox2
            // 
            comboBox2.AccessibleDescription = "";
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(371, 147);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(133, 23);
            comboBox2.TabIndex = 12;
            comboBox2.Text = "Filter";
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Items.AddRange(new object[] { "..." });
            listBox1.Location = new Point(109, 167);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(502, 184);
            listBox1.TabIndex = 13;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(109, 147);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(266, 23);
            textBox1.TabIndex = 14;
            textBox1.Text = "Search member/user...";
            // 
            // button2
            // 
            button2.BackColor = SystemColors.MenuHighlight;
            button2.ForeColor = SystemColors.Control;
            button2.Location = new Point(48, 38);
            button2.Name = "button2";
            button2.Size = new Size(91, 40);
            button2.TabIndex = 15;
            button2.Text = "Dashboard";
            button2.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            comboBox1.AccessibleDescription = "";
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(500, 147);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(111, 23);
            comboBox1.TabIndex = 16;
            comboBox1.Text = "Sort By";
            // 
            // AdminAccount
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
            Name = "AdminAccount";
            Text = "Together Culture Administrator account member/user list";
            Load += Form4_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox2;
        private ListBox listBox1;
        private TextBox textBox1;
        private Button button2;
        private ComboBox comboBox1;
    }
}
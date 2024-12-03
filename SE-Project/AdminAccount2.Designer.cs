namespace TogetherCulture
{
    partial class AdminAccount2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminAccount2));
            button2 = new Button();
            listBox1 = new ListBox();
            textBox1 = new TextBox();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            pictureBox1 = new PictureBox();
            listBox2 = new ListBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button2
            // 
            button2.BackColor = SystemColors.MenuHighlight;
            button2.ForeColor = SystemColors.Control;
            button2.Location = new Point(30, 37);
            button2.Name = "button2";
            button2.Size = new Size(91, 40);
            button2.TabIndex = 16;
            button2.Text = "Dashboard";
            button2.UseVisualStyleBackColor = false;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Items.AddRange(new object[] { "..." });
            listBox1.Location = new Point(243, 167);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(416, 184);
            listBox1.TabIndex = 17;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(243, 147);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(180, 23);
            textBox1.TabIndex = 18;
            textBox1.Text = "Search event/module...";
            // 
            // comboBox2
            // 
            comboBox2.AccessibleDescription = "";
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(419, 147);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(133, 23);
            comboBox2.TabIndex = 19;
            comboBox2.Text = "Filter";
            // 
            // comboBox1
            // 
            comboBox1.AccessibleDescription = "";
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(548, 147);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(111, 23);
            comboBox1.TabIndex = 20;
            comboBox1.Text = "Sort By";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(155, 58);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(59, 59);
            pictureBox1.TabIndex = 21;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Items.AddRange(new object[] { "Bio..." });
            listBox2.Location = new Point(54, 152);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(160, 199);
            listBox2.TabIndex = 22;
            // 
            // AdminAccount2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(listBox2);
            Controls.Add(pictureBox1);
            Controls.Add(comboBox1);
            Controls.Add(comboBox2);
            Controls.Add(textBox1);
            Controls.Add(listBox1);
            Controls.Add(button2);
            Name = "AdminAccount2";
            Text = "Together Culture Administrator Account member/user info";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private ListBox listBox1;
        private TextBox textBox1;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private PictureBox pictureBox1;
        private ListBox listBox2;
    }
}
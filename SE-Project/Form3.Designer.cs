﻿namespace SE_Project
{
    partial class Form3
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
            this.searchevents_textbox = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // searchevents_textbox
            // 
            this.searchevents_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.searchevents_textbox.Location = new System.Drawing.Point(235, 192);
            this.searchevents_textbox.Margin = new System.Windows.Forms.Padding(4);
            this.searchevents_textbox.Name = "searchevents_textbox";
            this.searchevents_textbox.Size = new System.Drawing.Size(328, 28);
            this.searchevents_textbox.TabIndex = 2;
            this.searchevents_textbox.Text = "Search Activities...";
            this.searchevents_textbox.TextChanged += new System.EventHandler(this.searchevents_textbox_TextChanged);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 22;
            this.listBox1.Items.AddRange(new object[] {
            "*--------------",
            "*-----------",
            "*------",
            "*--------",
            "*------",
            "*----------"});
            this.listBox1.Location = new System.Drawing.Point(587, 138);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(201, 246);
            this.listBox1.TabIndex = 7;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(587, 110);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(201, 22);
            this.textBox1.TabIndex = 8;
            this.textBox1.Text = "Suggested Tags:";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(587, 39);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 51);
            this.button2.TabIndex = 11;
            this.button2.Text = "Sign-Up";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(694, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 51);
            this.button1.TabIndex = 12;
            this.button1.Text = "Log-In";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(291, 242);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 51);
            this.button3.TabIndex = 13;
            this.button3.Text = "Events";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(413, 242);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(94, 51);
            this.button4.TabIndex = 14;
            this.button4.Text = "Modules";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.searchevents_textbox);
            this.Name = "Form3";
            this.Text = "Together Culture Dashboard";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox searchevents_textbox;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}
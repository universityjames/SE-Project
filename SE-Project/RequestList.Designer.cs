namespace SE_Project
{
    partial class RequestList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RequestList));
            this.textbox_dashboard = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.searchevents_textbox = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textbox_dashboard
            // 
            this.textbox_dashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.textbox_dashboard.Location = new System.Drawing.Point(13, 13);
            this.textbox_dashboard.Margin = new System.Windows.Forms.Padding(4);
            this.textbox_dashboard.Name = "textbox_dashboard";
            this.textbox_dashboard.Size = new System.Drawing.Size(128, 28);
            this.textbox_dashboard.TabIndex = 2;
            this.textbox_dashboard.Text = "Dashboard";
            this.textbox_dashboard.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(19)))), ((int)(((byte)(38)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(103, 124);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(602, 256);
            this.textBox1.TabIndex = 23;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // searchevents_textbox
            // 
            this.searchevents_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.searchevents_textbox.Location = new System.Drawing.Point(103, 88);
            this.searchevents_textbox.Margin = new System.Windows.Forms.Padding(4);
            this.searchevents_textbox.Name = "searchevents_textbox";
            this.searchevents_textbox.Size = new System.Drawing.Size(315, 28);
            this.searchevents_textbox.TabIndex = 24;
            this.searchevents_textbox.Text = "Search Applicant...";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.textBox2.Location = new System.Drawing.Point(426, 88);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(136, 28);
            this.textBox2.TabIndex = 25;
            this.textBox2.Text = "V Filter";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.textBox3.Location = new System.Drawing.Point(570, 88);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(135, 28);
            this.textBox3.TabIndex = 26;
            this.textBox3.Text = "V Sort By";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // RequestList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.searchevents_textbox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textbox_dashboard);
            this.Name = "RequestList";
            this.Text = "Together Culture Administrator Account Space Request List";
            this.Load += new System.EventHandler(this.RequestList_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textbox_dashboard;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox searchevents_textbox;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
    }
}
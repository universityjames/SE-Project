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
            this.textbox_dashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(246)))), ((int)(((byte)(236)))));
            this.textbox_dashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.textbox_dashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(19)))), ((int)(((byte)(38)))));
            this.textbox_dashboard.Location = new System.Drawing.Point(10, 11);
            this.textbox_dashboard.Name = "textbox_dashboard";
            this.textbox_dashboard.Size = new System.Drawing.Size(97, 24);
            this.textbox_dashboard.TabIndex = 2;
            this.textbox_dashboard.Text = "Dashboard";
            this.textbox_dashboard.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(246)))), ((int)(((byte)(236)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(19)))), ((int)(((byte)(38)))));
            this.textBox1.Location = new System.Drawing.Point(77, 101);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(452, 208);
            this.textBox1.TabIndex = 23;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // searchevents_textbox
            // 
            this.searchevents_textbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(246)))), ((int)(((byte)(236)))));
            this.searchevents_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.searchevents_textbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(19)))), ((int)(((byte)(38)))));
            this.searchevents_textbox.Location = new System.Drawing.Point(77, 72);
            this.searchevents_textbox.Name = "searchevents_textbox";
            this.searchevents_textbox.Size = new System.Drawing.Size(237, 24);
            this.searchevents_textbox.TabIndex = 24;
            this.searchevents_textbox.Text = "Search Applicant...";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.textBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(246)))), ((int)(((byte)(236)))));
            this.textBox2.Location = new System.Drawing.Point(320, 72);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(102, 24);
            this.textBox2.TabIndex = 25;
            this.textBox2.Text = "V Filter";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.textBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(246)))), ((int)(((byte)(236)))));
            this.textBox3.Location = new System.Drawing.Point(428, 72);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(102, 24);
            this.textBox3.TabIndex = 26;
            this.textBox3.Text = "V Sort By";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // RequestList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(19)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.searchevents_textbox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textbox_dashboard);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
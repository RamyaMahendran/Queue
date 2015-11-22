namespace r
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.b1 = new System.Windows.Forms.Button();
            this.b2 = new System.Windows.Forms.Button();
            this.b3 = new System.Windows.Forms.Button();
            this.s = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.txtb1 = new System.Windows.Forms.TextBox();
            this.txtb2 = new System.Windows.Forms.TextBox();
            this.txtb3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 6000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // b1
            // 
            this.b1.Location = new System.Drawing.Point(0, 0);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(75, 23);
            this.b1.TabIndex = 0;
            this.b1.Text = "b1";
            this.b1.UseVisualStyleBackColor = true;
            // 
            // b2
            // 
            this.b2.Location = new System.Drawing.Point(81, 12);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(75, 23);
            this.b2.TabIndex = 1;
            this.b2.Text = "b2";
            this.b2.UseVisualStyleBackColor = true;
            // 
            // b3
            // 
            this.b3.Location = new System.Drawing.Point(172, 30);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(75, 23);
            this.b3.TabIndex = 2;
            this.b3.Text = "b3";
            this.b3.UseVisualStyleBackColor = true;
            // 
            // s
            // 
            this.s.Location = new System.Drawing.Point(92, 226);
            this.s.Name = "s";
            this.s.Size = new System.Drawing.Size(75, 23);
            this.s.TabIndex = 3;
            this.s.Text = "s";
            this.s.UseVisualStyleBackColor = true;
            this.s.TextChanged += new System.EventHandler(this.s_TextChanged_1);
            this.s.Click += new System.EventHandler(this.s_Click);
            // 
            // timer2
            // 
            this.timer2.Interval = 3000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // txtb1
            // 
            this.txtb1.Location = new System.Drawing.Point(0, 33);
            this.txtb1.Name = "txtb1";
            this.txtb1.Size = new System.Drawing.Size(48, 20);
            this.txtb1.TabIndex = 4;
            // 
            // txtb2
            // 
            this.txtb2.Location = new System.Drawing.Point(81, 57);
            this.txtb2.Name = "txtb2";
            this.txtb2.Size = new System.Drawing.Size(48, 20);
            this.txtb2.TabIndex = 5;
            // 
            // txtb3
            // 
            this.txtb3.Location = new System.Drawing.Point(172, 85);
            this.txtb3.Name = "txtb3";
            this.txtb3.Size = new System.Drawing.Size(48, 20);
            this.txtb3.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.txtb3);
            this.Controls.Add(this.txtb2);
            this.Controls.Add(this.txtb1);
            this.Controls.Add(this.s);
            this.Controls.Add(this.b3);
            this.Controls.Add(this.b2);
            this.Controls.Add(this.b1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.Button b3;
        private System.Windows.Forms.Button s;
        private System.Windows.Forms.TextBox txtb1;
        public System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.TextBox txtb2;
        private System.Windows.Forms.TextBox txtb3;
    }
}


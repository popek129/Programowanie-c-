namespace _16_03_podatki
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButton_VAT23 = new System.Windows.Forms.RadioButton();
            this.radioButton_VAT8 = new System.Windows.Forms.RadioButton();
            this.radioButton_VAT5 = new System.Windows.Forms.RadioButton();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.radioButton_VAT = new System.Windows.Forms.RadioButton();
            this.radioButton_PIT = new System.Windows.Forms.RadioButton();
            this.radioButton_CIT = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(58, 34);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kwota:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(164, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Podatek";
            // 
            // radioButton_VAT23
            // 
            this.radioButton_VAT23.AutoSize = true;
            this.radioButton_VAT23.Location = new System.Drawing.Point(6, 6);
            this.radioButton_VAT23.Name = "radioButton_VAT23";
            this.radioButton_VAT23.Size = new System.Drawing.Size(45, 17);
            this.radioButton_VAT23.TabIndex = 3;
            this.radioButton_VAT23.TabStop = true;
            this.radioButton_VAT23.Text = "23%";
            this.radioButton_VAT23.UseVisualStyleBackColor = true;
            this.radioButton_VAT23.CheckedChanged += new System.EventHandler(this.radioButton_VAT23_CheckedChanged);
            // 
            // radioButton_VAT8
            // 
            this.radioButton_VAT8.AutoSize = true;
            this.radioButton_VAT8.Location = new System.Drawing.Point(57, 6);
            this.radioButton_VAT8.Name = "radioButton_VAT8";
            this.radioButton_VAT8.Size = new System.Drawing.Size(39, 17);
            this.radioButton_VAT8.TabIndex = 4;
            this.radioButton_VAT8.TabStop = true;
            this.radioButton_VAT8.Text = "8%";
            this.radioButton_VAT8.UseVisualStyleBackColor = true;
            this.radioButton_VAT8.CheckedChanged += new System.EventHandler(this.radioButton_VAT8_CheckedChanged);
            // 
            // radioButton_VAT5
            // 
            this.radioButton_VAT5.AutoSize = true;
            this.radioButton_VAT5.Location = new System.Drawing.Point(102, 6);
            this.radioButton_VAT5.Name = "radioButton_VAT5";
            this.radioButton_VAT5.Size = new System.Drawing.Size(39, 17);
            this.radioButton_VAT5.TabIndex = 5;
            this.radioButton_VAT5.TabStop = true;
            this.radioButton_VAT5.Text = "5%";
            this.radioButton_VAT5.UseVisualStyleBackColor = true;
            this.radioButton_VAT5.CheckedChanged += new System.EventHandler(this.radioButton_VAT5_CheckedChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(276, 44);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(147, 20);
            this.textBox2.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(429, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Opis";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.radioButton_VAT23);
            this.groupBox1.Controls.Add(this.radioButton_VAT8);
            this.groupBox1.Controls.Add(this.radioButton_VAT5);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(276, 9);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(147, 29);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(167, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 9;
            // 
            // radioButton_VAT
            // 
            this.radioButton_VAT.AutoSize = true;
            this.radioButton_VAT.Location = new System.Drawing.Point(6, 0);
            this.radioButton_VAT.Name = "radioButton_VAT";
            this.radioButton_VAT.Size = new System.Drawing.Size(46, 17);
            this.radioButton_VAT.TabIndex = 10;
            this.radioButton_VAT.TabStop = true;
            this.radioButton_VAT.Text = "VAT";
            this.radioButton_VAT.UseVisualStyleBackColor = true;
            this.radioButton_VAT.CheckedChanged += new System.EventHandler(this.radioButton_VAT_CheckedChanged);
            // 
            // radioButton_PIT
            // 
            this.radioButton_PIT.AutoSize = true;
            this.radioButton_PIT.Location = new System.Drawing.Point(6, 23);
            this.radioButton_PIT.Name = "radioButton_PIT";
            this.radioButton_PIT.Size = new System.Drawing.Size(42, 17);
            this.radioButton_PIT.TabIndex = 11;
            this.radioButton_PIT.TabStop = true;
            this.radioButton_PIT.Text = "PIT";
            this.radioButton_PIT.UseVisualStyleBackColor = true;
            this.radioButton_PIT.CheckedChanged += new System.EventHandler(this.radioButton_PIT_CheckedChanged);
            // 
            // radioButton_CIT
            // 
            this.radioButton_CIT.AutoSize = true;
            this.radioButton_CIT.Location = new System.Drawing.Point(6, 46);
            this.radioButton_CIT.Name = "radioButton_CIT";
            this.radioButton_CIT.Size = new System.Drawing.Size(42, 17);
            this.radioButton_CIT.TabIndex = 12;
            this.radioButton_CIT.TabStop = true;
            this.radioButton_CIT.Text = "CIT";
            this.radioButton_CIT.UseVisualStyleBackColor = true;
            this.radioButton_CIT.CheckedChanged += new System.EventHandler(this.radioButton_CIT_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton_VAT);
            this.groupBox2.Controls.Add(this.radioButton_CIT);
            this.groupBox2.Controls.Add(this.radioButton_PIT);
            this.groupBox2.Location = new System.Drawing.Point(217, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(53, 63);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(720, 482);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.ForeColor = System.Drawing.Color.Lime;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "MAGIA PODATKÓW";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButton_VAT23;
        private System.Windows.Forms.RadioButton radioButton_VAT8;
        private System.Windows.Forms.RadioButton radioButton_VAT5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radioButton_VAT;
        private System.Windows.Forms.RadioButton radioButton_PIT;
        private System.Windows.Forms.RadioButton radioButton_CIT;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}


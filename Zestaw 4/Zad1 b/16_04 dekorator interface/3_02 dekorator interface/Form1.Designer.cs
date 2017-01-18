namespace _16_04_dekorator_interface
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gB_Deser = new System.Windows.Forms.GroupBox();
            this.rB_Gofry = new System.Windows.Forms.RadioButton();
            this.rB_Lody = new System.Windows.Forms.RadioButton();
            this.gB_Dodatki = new System.Windows.Forms.GroupBox();
            this.cB_sm = new System.Windows.Forms.CheckBox();
            this.cB_cp = new System.Windows.Forms.CheckBox();
            this.gB_Polewa = new System.Windows.Forms.GroupBox();
            this.cB_kr = new System.Windows.Forms.CheckBox();
            this.cB_tr = new System.Windows.Forms.CheckBox();
            this.cB_cz = new System.Windows.Forms.CheckBox();
            this.gB_Smak = new System.Windows.Forms.GroupBox();
            this.rB_m = new System.Windows.Forms.RadioButton();
            this.rB_kk = new System.Windows.Forms.RadioButton();
            this.rB_sm = new System.Windows.Forms.RadioButton();
            this.gB_Owoce = new System.Windows.Forms.GroupBox();
            this.cB_pm = new System.Windows.Forms.CheckBox();
            this.cB_kw = new System.Windows.Forms.CheckBox();
            this.cB_ws = new System.Windows.Forms.CheckBox();
            this.gB_Deser.SuspendLayout();
            this.gB_Dodatki.SuspendLayout();
            this.gB_Polewa.SuspendLayout();
            this.gB_Smak.SuspendLayout();
            this.gB_Owoce.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Maroon;
            this.button1.Location = new System.Drawing.Point(12, 109);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Pokaż zamówienie";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Twoje zamówienie:";
            // 
            // gB_Deser
            // 
            this.gB_Deser.Controls.Add(this.rB_Gofry);
            this.gB_Deser.Controls.Add(this.rB_Lody);
            this.gB_Deser.Location = new System.Drawing.Point(12, 12);
            this.gB_Deser.Name = "gB_Deser";
            this.gB_Deser.Size = new System.Drawing.Size(57, 91);
            this.gB_Deser.TabIndex = 2;
            this.gB_Deser.TabStop = false;
            this.gB_Deser.Text = "Deser";
            // 
            // rB_Gofry
            // 
            this.rB_Gofry.AutoSize = true;
            this.rB_Gofry.BackColor = System.Drawing.Color.Purple;
            this.rB_Gofry.Location = new System.Drawing.Point(6, 40);
            this.rB_Gofry.Name = "rB_Gofry";
            this.rB_Gofry.Size = new System.Drawing.Size(51, 17);
            this.rB_Gofry.TabIndex = 1;
            this.rB_Gofry.TabStop = true;
            this.rB_Gofry.Text = "Gofer";
            this.rB_Gofry.UseVisualStyleBackColor = false;
            this.rB_Gofry.CheckedChanged += new System.EventHandler(this.rB_Gofry_CheckedChanged);
            // 
            // rB_Lody
            // 
            this.rB_Lody.AutoSize = true;
            this.rB_Lody.BackColor = System.Drawing.Color.Purple;
            this.rB_Lody.Location = new System.Drawing.Point(6, 20);
            this.rB_Lody.Name = "rB_Lody";
            this.rB_Lody.Size = new System.Drawing.Size(48, 17);
            this.rB_Lody.TabIndex = 0;
            this.rB_Lody.TabStop = true;
            this.rB_Lody.Text = "Lody";
            this.rB_Lody.UseVisualStyleBackColor = false;
            this.rB_Lody.CheckedChanged += new System.EventHandler(this.rB_Lody_CheckedChanged);
            // 
            // gB_Dodatki
            // 
            this.gB_Dodatki.Controls.Add(this.cB_sm);
            this.gB_Dodatki.Controls.Add(this.cB_cp);
            this.gB_Dodatki.Location = new System.Drawing.Point(179, 12);
            this.gB_Dodatki.Name = "gB_Dodatki";
            this.gB_Dodatki.Size = new System.Drawing.Size(99, 91);
            this.gB_Dodatki.TabIndex = 3;
            this.gB_Dodatki.TabStop = false;
            this.gB_Dodatki.Text = "Dodatki";
            // 
            // cB_sm
            // 
            this.cB_sm.AutoSize = true;
            this.cB_sm.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.cB_sm.Location = new System.Drawing.Point(6, 41);
            this.cB_sm.Name = "cB_sm";
            this.cB_sm.Size = new System.Drawing.Size(88, 17);
            this.cB_sm.TabIndex = 1;
            this.cB_sm.Text = "bita śmietana";
            this.cB_sm.UseVisualStyleBackColor = false;
            // 
            // cB_cp
            // 
            this.cB_cp.AutoSize = true;
            this.cB_cp.BackColor = System.Drawing.Color.Silver;
            this.cB_cp.Location = new System.Drawing.Point(6, 18);
            this.cB_cp.Name = "cB_cp";
            this.cB_cp.Size = new System.Drawing.Size(85, 17);
            this.cB_cp.TabIndex = 0;
            this.cB_cp.Text = "cukier puder";
            this.cB_cp.UseVisualStyleBackColor = false;
            // 
            // gB_Polewa
            // 
            this.gB_Polewa.Controls.Add(this.cB_kr);
            this.gB_Polewa.Controls.Add(this.cB_tr);
            this.gB_Polewa.Controls.Add(this.cB_cz);
            this.gB_Polewa.Location = new System.Drawing.Point(284, 12);
            this.gB_Polewa.Name = "gB_Polewa";
            this.gB_Polewa.Size = new System.Drawing.Size(97, 91);
            this.gB_Polewa.TabIndex = 0;
            this.gB_Polewa.TabStop = false;
            this.gB_Polewa.Text = "Polewa";
            // 
            // cB_kr
            // 
            this.cB_kr.AutoSize = true;
            this.cB_kr.BackColor = System.Drawing.Color.Yellow;
            this.cB_kr.Location = new System.Drawing.Point(6, 64);
            this.cB_kr.Name = "cB_kr";
            this.cB_kr.Size = new System.Drawing.Size(77, 17);
            this.cB_kr.TabIndex = 2;
            this.cB_kr.Text = "karmelowa";
            this.cB_kr.UseVisualStyleBackColor = false;
            // 
            // cB_tr
            // 
            this.cB_tr.AutoSize = true;
            this.cB_tr.BackColor = System.Drawing.Color.Yellow;
            this.cB_tr.Location = new System.Drawing.Point(6, 41);
            this.cB_tr.Name = "cB_tr";
            this.cB_tr.Size = new System.Drawing.Size(89, 17);
            this.cB_tr.TabIndex = 2;
            this.cB_tr.Text = "truskawkowa";
            this.cB_tr.UseVisualStyleBackColor = false;
            // 
            // cB_cz
            // 
            this.cB_cz.AutoSize = true;
            this.cB_cz.BackColor = System.Drawing.Color.Yellow;
            this.cB_cz.Location = new System.Drawing.Point(6, 18);
            this.cB_cz.Name = "cB_cz";
            this.cB_cz.Size = new System.Drawing.Size(89, 17);
            this.cB_cz.TabIndex = 2;
            this.cB_cz.Text = "czekoladowa";
            this.cB_cz.UseVisualStyleBackColor = false;
            // 
            // gB_Smak
            // 
            this.gB_Smak.Controls.Add(this.rB_m);
            this.gB_Smak.Controls.Add(this.rB_kk);
            this.gB_Smak.Controls.Add(this.rB_sm);
            this.gB_Smak.Location = new System.Drawing.Point(76, 12);
            this.gB_Smak.Name = "gB_Smak";
            this.gB_Smak.Size = new System.Drawing.Size(97, 91);
            this.gB_Smak.TabIndex = 4;
            this.gB_Smak.TabStop = false;
            this.gB_Smak.Text = "Smak";
            // 
            // rB_m
            // 
            this.rB_m.AutoSize = true;
            this.rB_m.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.rB_m.Location = new System.Drawing.Point(7, 68);
            this.rB_m.Name = "rB_m";
            this.rB_m.Size = new System.Drawing.Size(68, 17);
            this.rB_m.TabIndex = 2;
            this.rB_m.TabStop = true;
            this.rB_m.Text = "mieszany";
            this.rB_m.UseVisualStyleBackColor = false;
            // 
            // rB_kk
            // 
            this.rB_kk.AutoSize = true;
            this.rB_kk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.rB_kk.Location = new System.Drawing.Point(7, 44);
            this.rB_kk.Name = "rB_kk";
            this.rB_kk.Size = new System.Drawing.Size(68, 17);
            this.rB_kk.TabIndex = 1;
            this.rB_kk.TabStop = true;
            this.rB_kk.Text = "kakaowy";
            this.rB_kk.UseVisualStyleBackColor = false;
            // 
            // rB_sm
            // 
            this.rB_sm.AutoSize = true;
            this.rB_sm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.rB_sm.Location = new System.Drawing.Point(7, 20);
            this.rB_sm.Name = "rB_sm";
            this.rB_sm.Size = new System.Drawing.Size(86, 17);
            this.rB_sm.TabIndex = 0;
            this.rB_sm.TabStop = true;
            this.rB_sm.Text = "śmietankowy";
            this.rB_sm.UseVisualStyleBackColor = false;
            // 
            // gB_Owoce
            // 
            this.gB_Owoce.Controls.Add(this.cB_pm);
            this.gB_Owoce.Controls.Add(this.cB_kw);
            this.gB_Owoce.Controls.Add(this.cB_ws);
            this.gB_Owoce.Location = new System.Drawing.Point(387, 12);
            this.gB_Owoce.Name = "gB_Owoce";
            this.gB_Owoce.Size = new System.Drawing.Size(90, 91);
            this.gB_Owoce.TabIndex = 0;
            this.gB_Owoce.TabStop = false;
            this.gB_Owoce.Text = "Owoce";
            // 
            // cB_pm
            // 
            this.cB_pm.AutoSize = true;
            this.cB_pm.BackColor = System.Drawing.Color.Red;
            this.cB_pm.Location = new System.Drawing.Point(6, 64);
            this.cB_pm.Name = "cB_pm";
            this.cB_pm.Size = new System.Drawing.Size(84, 17);
            this.cB_pm.TabIndex = 2;
            this.cB_pm.Text = "pomarańcze";
            this.cB_pm.UseVisualStyleBackColor = false;
            // 
            // cB_kw
            // 
            this.cB_kw.AutoSize = true;
            this.cB_kw.BackColor = System.Drawing.Color.Red;
            this.cB_kw.Location = new System.Drawing.Point(6, 41);
            this.cB_kw.Name = "cB_kw";
            this.cB_kw.Size = new System.Drawing.Size(44, 17);
            this.cB_kw.TabIndex = 2;
            this.cB_kw.Text = "kiwi";
            this.cB_kw.UseVisualStyleBackColor = false;
            // 
            // cB_ws
            // 
            this.cB_ws.AutoSize = true;
            this.cB_ws.BackColor = System.Drawing.Color.Red;
            this.cB_ws.Location = new System.Drawing.Point(6, 18);
            this.cB_ws.Name = "cB_ws";
            this.cB_ws.Size = new System.Drawing.Size(55, 17);
            this.cB_ws.TabIndex = 2;
            this.cB_ws.Text = "wiśnie";
            this.cB_ws.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(494, 282);
            this.Controls.Add(this.gB_Owoce);
            this.Controls.Add(this.gB_Polewa);
            this.Controls.Add(this.gB_Smak);
            this.Controls.Add(this.gB_Dodatki);
            this.Controls.Add(this.gB_Deser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "MAGIA DEKORATORÓW";
            this.gB_Deser.ResumeLayout(false);
            this.gB_Deser.PerformLayout();
            this.gB_Dodatki.ResumeLayout(false);
            this.gB_Dodatki.PerformLayout();
            this.gB_Polewa.ResumeLayout(false);
            this.gB_Polewa.PerformLayout();
            this.gB_Smak.ResumeLayout(false);
            this.gB_Smak.PerformLayout();
            this.gB_Owoce.ResumeLayout(false);
            this.gB_Owoce.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gB_Deser;
        private System.Windows.Forms.RadioButton rB_Gofry;
        private System.Windows.Forms.RadioButton rB_Lody;
        private System.Windows.Forms.GroupBox gB_Dodatki;
        private System.Windows.Forms.CheckBox cB_sm;
        private System.Windows.Forms.CheckBox cB_cp;
        private System.Windows.Forms.GroupBox gB_Polewa;
        private System.Windows.Forms.CheckBox cB_kr;
        private System.Windows.Forms.CheckBox cB_tr;
        private System.Windows.Forms.CheckBox cB_cz;
        private System.Windows.Forms.GroupBox gB_Smak;
        private System.Windows.Forms.RadioButton rB_m;
        private System.Windows.Forms.RadioButton rB_kk;
        private System.Windows.Forms.RadioButton rB_sm;
        private System.Windows.Forms.GroupBox gB_Owoce;
        private System.Windows.Forms.CheckBox cB_pm;
        private System.Windows.Forms.CheckBox cB_kw;
        private System.Windows.Forms.CheckBox cB_ws;
    }
}


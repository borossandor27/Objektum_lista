namespace Objektum_lista
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Nev = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBox_magyar = new System.Windows.Forms.CheckBox();
            this.checkBox_matek = new System.Windows.Forms.CheckBox();
            this.checkBox_enek = new System.Windows.Forms.CheckBox();
            this.comboBox_hobby = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button_Rogzit = new System.Windows.Forms.Button();
            this.listBox_Tanulok = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Név:";
            // 
            // textBox_Nev
            // 
            this.textBox_Nev.Location = new System.Drawing.Point(79, 24);
            this.textBox_Nev.Name = "textBox_Nev";
            this.textBox_Nev.Size = new System.Drawing.Size(287, 20);
            this.textBox_Nev.TabIndex = 1;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(79, 67);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 2;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown1.Value = new decimal(new int[] {
            180,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "magasság";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(205, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "cm";
            // 
            // checkBox_magyar
            // 
            this.checkBox_magyar.AutoSize = true;
            this.checkBox_magyar.Location = new System.Drawing.Point(36, 112);
            this.checkBox_magyar.Name = "checkBox_magyar";
            this.checkBox_magyar.Size = new System.Drawing.Size(60, 17);
            this.checkBox_magyar.TabIndex = 5;
            this.checkBox_magyar.Text = "magyar";
            this.checkBox_magyar.UseVisualStyleBackColor = true;
            // 
            // checkBox_matek
            // 
            this.checkBox_matek.AutoSize = true;
            this.checkBox_matek.Location = new System.Drawing.Point(146, 112);
            this.checkBox_matek.Name = "checkBox_matek";
            this.checkBox_matek.Size = new System.Drawing.Size(55, 17);
            this.checkBox_matek.TabIndex = 6;
            this.checkBox_matek.Text = "matek";
            this.checkBox_matek.UseVisualStyleBackColor = true;
            // 
            // checkBox_enek
            // 
            this.checkBox_enek.AutoSize = true;
            this.checkBox_enek.Location = new System.Drawing.Point(253, 112);
            this.checkBox_enek.Name = "checkBox_enek";
            this.checkBox_enek.Size = new System.Drawing.Size(50, 17);
            this.checkBox_enek.TabIndex = 7;
            this.checkBox_enek.Text = "ének";
            this.checkBox_enek.UseVisualStyleBackColor = true;
            // 
            // comboBox_hobby
            // 
            this.comboBox_hobby.FormattingEnabled = true;
            this.comboBox_hobby.Items.AddRange(new object[] {
            "Kerékpározás",
            "Futás",
            "Éneklés",
            "Tánc"});
            this.comboBox_hobby.Location = new System.Drawing.Point(79, 163);
            this.comboBox_hobby.Name = "comboBox_hobby";
            this.comboBox_hobby.Size = new System.Drawing.Size(121, 21);
            this.comboBox_hobby.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "hobby";
            // 
            // button_Rogzit
            // 
            this.button_Rogzit.Location = new System.Drawing.Point(68, 230);
            this.button_Rogzit.Name = "button_Rogzit";
            this.button_Rogzit.Size = new System.Drawing.Size(75, 23);
            this.button_Rogzit.TabIndex = 10;
            this.button_Rogzit.Text = "Rögzít";
            this.button_Rogzit.UseVisualStyleBackColor = true;
            this.button_Rogzit.Click += new System.EventHandler(this.button_Rogzit_Click);
            // 
            // listBox_Tanulok
            // 
            this.listBox_Tanulok.FormattingEnabled = true;
            this.listBox_Tanulok.Location = new System.Drawing.Point(433, 24);
            this.listBox_Tanulok.Name = "listBox_Tanulok";
            this.listBox_Tanulok.Size = new System.Drawing.Size(271, 368);
            this.listBox_Tanulok.TabIndex = 11;
            this.listBox_Tanulok.SelectedIndexChanged += new System.EventHandler(this.listBox_Tanulok_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox_Tanulok);
            this.Controls.Add(this.button_Rogzit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox_hobby);
            this.Controls.Add(this.checkBox_enek);
            this.Controls.Add(this.checkBox_matek);
            this.Controls.Add(this.checkBox_magyar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.textBox_Nev);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Tanulüi nyilvántartás";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Nev;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox_magyar;
        private System.Windows.Forms.CheckBox checkBox_matek;
        private System.Windows.Forms.CheckBox checkBox_enek;
        private System.Windows.Forms.ComboBox comboBox_hobby;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_Rogzit;
        private System.Windows.Forms.ListBox listBox_Tanulok;
    }
}


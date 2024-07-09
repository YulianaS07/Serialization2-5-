namespace Serializacja
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
            this.textBoxTytul = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBoxOcena = new System.Windows.Forms.TextBox();
            this.textBoxGatunek = new System.Windows.Forms.TextBox();
            this.textBoxRok = new System.Windows.Forms.TextBox();
            this.textBoxAutor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tytuł";
            // 
            // textBoxTytul
            // 
            this.textBoxTytul.Location = new System.Drawing.Point(3, 74);
            this.textBoxTytul.Name = "textBoxTytul";
            this.textBoxTytul.Size = new System.Drawing.Size(137, 26);
            this.textBoxTytul.TabIndex = 1;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(158, 51);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(905, 324);
            this.listBox1.TabIndex = 2;
            // 
            // textBoxOcena
            // 
            this.textBoxOcena.Location = new System.Drawing.Point(3, 349);
            this.textBoxOcena.Name = "textBoxOcena";
            this.textBoxOcena.Size = new System.Drawing.Size(137, 26);
            this.textBoxOcena.TabIndex = 4;
            // 
            // textBoxGatunek
            // 
            this.textBoxGatunek.Location = new System.Drawing.Point(3, 284);
            this.textBoxGatunek.Name = "textBoxGatunek";
            this.textBoxGatunek.Size = new System.Drawing.Size(137, 26);
            this.textBoxGatunek.TabIndex = 5;
            // 
            // textBoxRok
            // 
            this.textBoxRok.Location = new System.Drawing.Point(3, 211);
            this.textBoxRok.Name = "textBoxRok";
            this.textBoxRok.Size = new System.Drawing.Size(137, 26);
            this.textBoxRok.TabIndex = 6;
            // 
            // textBoxAutor
            // 
            this.textBoxAutor.Location = new System.Drawing.Point(3, 140);
            this.textBoxAutor.Name = "textBoxAutor";
            this.textBoxAutor.Size = new System.Drawing.Size(137, 26);
            this.textBoxAutor.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Autor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Rok wydania";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Gatunek";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 326);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Ocena";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(583, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Książki";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(158, 424);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(344, 34);
            this.button1.TabIndex = 13;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(728, 424);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(335, 34);
            this.button2.TabIndex = 14;
            this.button2.Text = "Zapisz do pliku";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 513);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxAutor);
            this.Controls.Add(this.textBoxRok);
            this.Controls.Add(this.textBoxGatunek);
            this.Controls.Add(this.textBoxOcena);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBoxTytul);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Biblioteka";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxTytul;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBoxOcena;
        private System.Windows.Forms.TextBox textBoxGatunek;
        private System.Windows.Forms.TextBox textBoxRok;
        private System.Windows.Forms.TextBox textBoxAutor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}


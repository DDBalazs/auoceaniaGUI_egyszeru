namespace auoceaniaGUI_egyszeru
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
            this.rtbadatok = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.btsave = new System.Windows.Forms.Button();
            this.btexit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblegnagyobb = new System.Windows.Forms.Label();
            this.lblegkisebb = new System.Windows.Forms.Label();
            this.lbatlagos = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtbadatok
            // 
            this.rtbadatok.Location = new System.Drawing.Point(36, 72);
            this.rtbadatok.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rtbadatok.Name = "rtbadatok";
            this.rtbadatok.ReadOnly = true;
            this.rtbadatok.Size = new System.Drawing.Size(347, 213);
            this.rtbadatok.TabIndex = 0;
            this.rtbadatok.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Adatok:";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(429, 75);
            this.richTextBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.Size = new System.Drawing.Size(304, 210);
            this.richTextBox2.TabIndex = 2;
            this.richTextBox2.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(426, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Népszerűségek: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(746, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Terület neve: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(746, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Területe [km2]: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(746, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Lakossága [fő]; ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(746, 272);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Népszerűség [fő/km2]";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(884, 272);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "label7";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(843, 191);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 9;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(843, 129);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 10;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(839, 72);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(170, 20);
            this.textBox3.TabIndex = 11;
            // 
            // btsave
            // 
            this.btsave.Location = new System.Drawing.Point(964, 99);
            this.btsave.Name = "btsave";
            this.btsave.Size = new System.Drawing.Size(140, 78);
            this.btsave.TabIndex = 12;
            this.btsave.Text = "Mentés";
            this.btsave.UseVisualStyleBackColor = true;
            this.btsave.Click += new System.EventHandler(this.button1_Click);
            // 
            // btexit
            // 
            this.btexit.Location = new System.Drawing.Point(964, 194);
            this.btexit.Name = "btexit";
            this.btexit.Size = new System.Drawing.Size(140, 78);
            this.btexit.TabIndex = 13;
            this.btexit.Text = "Kilépés";
            this.btexit.UseVisualStyleBackColor = true;
            this.btexit.Click += new System.EventHandler(this.btexit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.lbatlagos);
            this.panel1.Controls.Add(this.lblegkisebb);
            this.panel1.Controls.Add(this.lblegnagyobb);
            this.panel1.Location = new System.Drawing.Point(36, 306);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1068, 132);
            this.panel1.TabIndex = 14;
            // 
            // lblegnagyobb
            // 
            this.lblegnagyobb.AutoSize = true;
            this.lblegnagyobb.Location = new System.Drawing.Point(15, 24);
            this.lblegnagyobb.Name = "lblegnagyobb";
            this.lblegnagyobb.Size = new System.Drawing.Size(190, 13);
            this.lblegnagyobb.TabIndex = 0;
            this.lblegnagyobb.Text = "Legnagyobb népességű ország: ";
            // 
            // lblegkisebb
            // 
            this.lblegkisebb.AutoSize = true;
            this.lblegkisebb.Location = new System.Drawing.Point(15, 60);
            this.lblegkisebb.Name = "lblegkisebb";
            this.lblegkisebb.Size = new System.Drawing.Size(114, 13);
            this.lblegkisebb.TabIndex = 1;
            this.lblegkisebb.Text = "Legkisebb ország: ";
            // 
            // lbatlagos
            // 
            this.lbatlagos.AutoSize = true;
            this.lbatlagos.Location = new System.Drawing.Point(15, 95);
            this.lbatlagos.Name = "lbatlagos";
            this.lbatlagos.Size = new System.Drawing.Size(126, 13);
            this.lbatlagos.TabIndex = 2;
            this.lbatlagos.Text = "Átlagos népsűrűség: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1151, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btexit);
            this.Controls.Add(this.btsave);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtbadatok);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ausztrália és Óceánia";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbadatok;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button btsave;
        private System.Windows.Forms.Button btexit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbatlagos;
        private System.Windows.Forms.Label lblegkisebb;
        private System.Windows.Forms.Label lblegnagyobb;
    }
}


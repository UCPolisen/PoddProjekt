namespace PoddProjekt
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
            splitContainer1 = new System.Windows.Forms.SplitContainer();
            Button1 = new System.Windows.Forms.Button();
            comboBox1 = new System.Windows.Forms.ComboBox();
            label4 = new System.Windows.Forms.Label();
            textBox2 = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            textBox1 = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            splitContainer1.Location = new System.Drawing.Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(Button1);
            splitContainer1.Panel1.Controls.Add(comboBox1);
            splitContainer1.Panel1.Controls.Add(label4);
            splitContainer1.Panel1.Controls.Add(textBox2);
            splitContainer1.Panel1.Controls.Add(label3);
            splitContainer1.Panel1.Controls.Add(label2);
            splitContainer1.Panel1.Controls.Add(textBox1);
            splitContainer1.Panel1.Controls.Add(label1);
            splitContainer1.Size = new System.Drawing.Size(1624, 1091);
            splitContainer1.SplitterDistance = 541;
            splitContainer1.TabIndex = 0;
            // 
            // Button1
            // 
            Button1.Location = new System.Drawing.Point(194, 250);
            Button1.Name = "Button1";
            Button1.Size = new System.Drawing.Size(150, 46);
            Button1.TabIndex = 6;
            Button1.Text = "Lägg till";
            Button1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new System.Drawing.Point(142, 189);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new System.Drawing.Size(242, 40);
            comboBox1.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(28, 192);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(108, 32);
            label4.TabIndex = 5;
            label4.Text = "Kategori:";
            // 
            // textBox2
            // 
            textBox2.Location = new System.Drawing.Point(118, 138);
            textBox2.Name = "textBox2";
            textBox2.Size = new System.Drawing.Size(200, 39);
            textBox2.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(28, 138);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(84, 32);
            label3.TabIndex = 3;
            label3.Text = "Namn:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(28, 91);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(109, 32);
            label2.TabIndex = 2;
            label2.Text = "RSS/URL:";
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(143, 88);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(383, 39);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(131, 25);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(282, 32);
            label1.TabIndex = 0;
            label1.Text = "Grupp 25:s Poddbibliotek";
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1624, 1091);
            Controls.Add(splitContainer1);
            Name = "Form1";
            Text = "Form1";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Button1;
    }
}
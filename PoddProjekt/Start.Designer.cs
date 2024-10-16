namespace PoddProjekt
{
    partial class Start
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
            AddPodd = new System.Windows.Forms.Button();
            comboBox1 = new System.Windows.Forms.ComboBox();
            label5 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            listBox1 = new System.Windows.Forms.ListBox();
            textBox2 = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            textBox1 = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            button1 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
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
            splitContainer1.Panel1.Controls.Add(button2);
            splitContainer1.Panel1.Controls.Add(button1);
            splitContainer1.Panel1.Controls.Add(AddPodd);
            splitContainer1.Panel1.Controls.Add(comboBox1);
            splitContainer1.Panel1.Controls.Add(label4);
            splitContainer1.Panel1.Controls.Add(textBox2);
            splitContainer1.Panel1.Controls.Add(label3);
            splitContainer1.Panel1.Controls.Add(label2);
            splitContainer1.Panel1.Controls.Add(textBox1);
            splitContainer1.Panel1.Controls.Add(label1);
            splitContainer1.Panel1.Paint += splitContainer1_Panel1_Paint;
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(listBox1);
            splitContainer1.Panel2.Controls.Add(label5);
            splitContainer1.Size = new System.Drawing.Size(1566, 1091);
            splitContainer1.SplitterDistance = 550;
            splitContainer1.TabIndex = 0;
            // 
            // AddPodd
            // 
            AddPodd.Location = new System.Drawing.Point(194, 250);
            AddPodd.Name = "AddPodd";
            AddPodd.Size = new System.Drawing.Size(150, 46);
            AddPodd.TabIndex = 6;
            AddPodd.Text = "Lägg till";
            AddPodd.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new System.Drawing.Point(142, 189);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new System.Drawing.Size(242, 40);
            comboBox1.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(402, 25);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(151, 32);
            label5.TabIndex = 1;
            label5.Text = "Mina poddar";
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
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 32;
            listBox1.Location = new System.Drawing.Point(39, 88);
            listBox1.Name = "listBox1";
            listBox1.Size = new System.Drawing.Size(936, 964);
            listBox1.TabIndex = 0;
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
            // button1
            // 
            button1.Location = new System.Drawing.Point(66, 490);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(150, 46);
            button1.TabIndex = 7;
            button1.Text = "Kategorier";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new System.Drawing.Point(281, 490);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(150, 46);
            button2.TabIndex = 8;
            button2.Text = "Avsnitt";
            button2.UseVisualStyleBackColor = true;
            // 
            // Start
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1566, 1091);
            Controls.Add(splitContainer1);
            Name = "Start";
            Text = "Form1";
            Load += Start_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
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
        private System.Windows.Forms.Button AddPodd;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}
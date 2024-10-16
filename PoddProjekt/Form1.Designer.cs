namespace PoddProjekt
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            splitContainer1 = new System.Windows.Forms.SplitContainer();
            comboBox1 = new System.Windows.Forms.ComboBox();
            label3 = new System.Windows.Forms.Label();
            textBox2 = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            urlLbl = new System.Windows.Forms.Label();
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
            splitContainer1.Panel1.Controls.Add(comboBox1);
            splitContainer1.Panel1.Controls.Add(label3);
            splitContainer1.Panel1.Controls.Add(textBox2);
            splitContainer1.Panel1.Controls.Add(label2);
            splitContainer1.Panel1.Controls.Add(urlLbl);
            splitContainer1.Panel1.Controls.Add(textBox1);
            splitContainer1.Panel1.Controls.Add(label1);
            splitContainer1.Panel1.Paint += splitContainer1_Panel1_Paint;
            splitContainer1.Size = new System.Drawing.Size(1641, 1101);
            splitContainer1.SplitterDistance = 547;
            splitContainer1.TabIndex = 0;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Humor", "Historia", "Dokumentär", "Skitsnack" });
            comboBox1.Location = new System.Drawing.Point(127, 208);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new System.Drawing.Size(242, 40);
            comboBox1.TabIndex = 6;
            comboBox1.Text = "Välj kategori";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(12, 208);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(108, 32);
            label3.TabIndex = 5;
            label3.Text = "Kategori:";
            // 
            // textBox2
            // 
            textBox2.Location = new System.Drawing.Point(152, 158);
            textBox2.Name = "textBox2";
            textBox2.Size = new System.Drawing.Size(200, 39);
            textBox2.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(12, 158);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(134, 32);
            label2.TabIndex = 3;
            label2.Text = "Poddnamn:";
            label2.Click += label2_Click;
            // 
            // urlLbl
            // 
            urlLbl.AutoSize = true;
            urlLbl.Location = new System.Drawing.Point(12, 103);
            urlLbl.Name = "urlLbl";
            urlLbl.Size = new System.Drawing.Size(109, 32);
            urlLbl.TabIndex = 2;
            urlLbl.Text = "RSS/URL:";
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(127, 103);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(389, 39);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(142, 25);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(230, 32);
            label1.TabIndex = 0;
            label1.Text = "Grupp 25:s Poddcast";
            label1.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1641, 1101);
            Controls.Add(splitContainer1);
            Margin = new System.Windows.Forms.Padding(6);
            Name = "Form1";
            Text = "PoddApp";
            Load += Form1_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label urlLbl;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
    }
}

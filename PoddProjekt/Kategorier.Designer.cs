namespace PoddProjekt
{
    partial class Kategorier
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
            listBox1 = new System.Windows.Forms.ListBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            textBox1 = new System.Windows.Forms.TextBox();
            button1 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 32;
            listBox1.Location = new System.Drawing.Point(174, 180);
            listBox1.Name = "listBox1";
            listBox1.Size = new System.Drawing.Size(240, 164);
            listBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(174, 112);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(129, 32);
            label1.TabIndex = 1;
            label1.Text = "Kategorier:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(516, 112);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(197, 32);
            label2.TabIndex = 2;
            label2.Text = "Ändra kategorier:";
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(719, 109);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(200, 39);
            textBox1.TabIndex = 3;
            textBox1.Text = "Kategorinamn";
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(563, 180);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(150, 46);
            button1.TabIndex = 4;
            button1.Text = "Lägg till";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new System.Drawing.Point(754, 180);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(150, 46);
            button2.TabIndex = 5;
            button2.Text = "Ta bort";
            button2.UseVisualStyleBackColor = true;
            // 
            // Kategorier
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1054, 455);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listBox1);
            Name = "Kategorier";
            Text = "Kategorier";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}
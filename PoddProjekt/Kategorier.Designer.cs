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
            listBoxKategorier = new System.Windows.Forms.ListBox();
            label1 = new System.Windows.Forms.Label();
            textBoxNyEllerAndra = new System.Windows.Forms.TextBox();
            btnBekfraftaNyKategori = new System.Windows.Forms.Button();
            btnBekraftaAndradKategori = new System.Windows.Forms.Button();
            btnAndraNamnKategori = new System.Windows.Forms.Button();
            btnTaBortKategori = new System.Windows.Forms.Button();
            btnAngra = new System.Windows.Forms.Button();
            btnLaggTillNyKategori = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // listBoxKategorier
            // 
            listBoxKategorier.FormattingEnabled = true;
            listBoxKategorier.ItemHeight = 32;
            listBoxKategorier.Location = new System.Drawing.Point(174, 180);
            listBoxKategorier.Name = "listBoxKategorier";
            listBoxKategorier.Size = new System.Drawing.Size(316, 196);
            listBoxKategorier.TabIndex = 0;
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
            // textBoxNyEllerAndra
            // 
            textBoxNyEllerAndra.Location = new System.Drawing.Point(822, 252);
            textBoxNyEllerAndra.Name = "textBoxNyEllerAndra";
            textBoxNyEllerAndra.Size = new System.Drawing.Size(200, 39);
            textBoxNyEllerAndra.TabIndex = 3;
            // 
            // btnBekfraftaNyKategori
            // 
            btnBekfraftaNyKategori.Location = new System.Drawing.Point(719, 327);
            btnBekfraftaNyKategori.Name = "btnBekfraftaNyKategori";
            btnBekfraftaNyKategori.Size = new System.Drawing.Size(202, 78);
            btnBekfraftaNyKategori.TabIndex = 4;
            btnBekfraftaNyKategori.Text = "Lägg till kategori";
            btnBekfraftaNyKategori.UseVisualStyleBackColor = true;
            // 
            // btnBekraftaAndradKategori
            // 
            btnBekraftaAndradKategori.Location = new System.Drawing.Point(946, 335);
            btnBekraftaAndradKategori.Name = "btnBekraftaAndradKategori";
            btnBekraftaAndradKategori.Size = new System.Drawing.Size(220, 62);
            btnBekraftaAndradKategori.TabIndex = 5;
            btnBekraftaAndradKategori.Text = "Bekräfta namn";
            btnBekraftaAndradKategori.UseVisualStyleBackColor = true;
            // 
            // btnAndraNamnKategori
            // 
            btnAndraNamnKategori.Location = new System.Drawing.Point(176, 443);
            btnAndraNamnKategori.Name = "btnAndraNamnKategori";
            btnAndraNamnKategori.Size = new System.Drawing.Size(181, 77);
            btnAndraNamnKategori.TabIndex = 6;
            btnAndraNamnKategori.Text = "Ändra namn";
            btnAndraNamnKategori.UseVisualStyleBackColor = true;
            // 
            // btnTaBortKategori
            // 
            btnTaBortKategori.Location = new System.Drawing.Point(430, 442);
            btnTaBortKategori.Name = "btnTaBortKategori";
            btnTaBortKategori.Size = new System.Drawing.Size(188, 78);
            btnTaBortKategori.TabIndex = 7;
            btnTaBortKategori.Text = "Ta bort kategori";
            btnTaBortKategori.UseVisualStyleBackColor = true;
            // 
            // btnAngra
            // 
            btnAngra.Location = new System.Drawing.Point(979, 442);
            btnAngra.Name = "btnAngra";
            btnAngra.Size = new System.Drawing.Size(150, 46);
            btnAngra.TabIndex = 8;
            btnAngra.Text = "Ångra";
            btnAngra.UseVisualStyleBackColor = true;
            // 
            // btnLaggTillNyKategori
            // 
            btnLaggTillNyKategori.Location = new System.Drawing.Point(842, 117);
            btnLaggTillNyKategori.Name = "btnLaggTillNyKategori";
            btnLaggTillNyKategori.Size = new System.Drawing.Size(150, 46);
            btnLaggTillNyKategori.TabIndex = 9;
            btnLaggTillNyKategori.Text = "Lägg till ny kategori";
            btnLaggTillNyKategori.UseVisualStyleBackColor = true;
            // 
            // Kategorier
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1235, 722);
            Controls.Add(btnLaggTillNyKategori);
            Controls.Add(btnAngra);
            Controls.Add(btnTaBortKategori);
            Controls.Add(btnAndraNamnKategori);
            Controls.Add(btnBekraftaAndradKategori);
            Controls.Add(btnBekfraftaNyKategori);
            Controls.Add(textBoxNyEllerAndra);
            Controls.Add(label1);
            Controls.Add(listBoxKategorier);
            Name = "Kategorier";
            Text = "Kategorier";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ListBox listBoxKategorier;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNyEllerAndra;
        private System.Windows.Forms.Button btnBekfraftaNyKategori;
        private System.Windows.Forms.Button btnBekraftaAndradKategori;
        private System.Windows.Forms.Button btnAndraNamnKategori;
        private System.Windows.Forms.Button btnTaBortKategori;
        private System.Windows.Forms.Button btnAngra;
        private System.Windows.Forms.Button btnLaggTillNyKategori;
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PoddProjekt
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();

            comboBox1.Items.Add("Humor");
            comboBox1.Items.Add("Dokumentär");
            comboBox1.Items.Add("Historia");
            comboBox1.Items.Add("Skitsnack");

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Start_Load(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Kategorier kategorierForm = new Kategorier();

            kategorierForm.Show();
        }
    }
}

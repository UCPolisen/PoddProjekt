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


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Kategorier kategorierForm = new Kategorier();

            kategorierForm.Show();
        }
    }
}

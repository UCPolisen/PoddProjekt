using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PoddProjekt
{
    public partial class Form1 : Form
    {
        private IPoddRepository _poddRepository;
        public Form1()
        {
            InitializeComponent();
            _poddRepository = new PoddRepository();
        }

        private void AddPodd(string title, string author)
        {
            Podd newPodd = new Podd
            {
                Id = _poddRepository.GetAllPodds().Count() + 1;  //pluss 1 genererar enkelt  id som är 1 större än tidigare
                Title = title,
                Author = author
            };

            _poddRepository.AddPodd(newPodd);
            MessageBox.Show("Podd tillagd");
        }

        private void ShowAllPodds()
        {
            var podds = _poddRepository.GetAllPodds();
            foreach (var podd in podds)
            {
                listBoxPodds.Items.Add($"{podd.Id}: {podd.Title} av {podd.Author}");
            }
        }

        //vet ej  om metoden  nedan behövs
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void SavePodds()
        {
            var podds = _poddRepository.GetAllPodds().ToList(); // hämta alla poddar som en lista
            string jsonString = jasonSerializer.Serialize(podds);
            File.WriteAllText("podds.json", jsonString);
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Lägg till alternativ i ComboBox
            comboBox1.Items.Add("https://example1.com");
            comboBox1.Items.Add("https://example2.com");
            comboBox1.Items.Add("https://example3.com");
        }
    }
}

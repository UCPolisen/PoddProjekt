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

        private void button1_Click(object sender, EventArgs e)
        {
            u
        }
    }
}

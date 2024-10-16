using PoddProjekt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class KategoriRepository : HuvudRepository<Podcast>
    {
        Serialiserare nySerialiserare;
        List<Podcast> podcasts; // Ändrat till podcasts        

        public KategoriRepository()
        {
            nySerialiserare = new Serialiserare();
            podcasts = new List<Podcast>(); // Initiering av podcasts
            podcasts = GetAll(); // Hämtar podcasts och fyller listan
        }

        public override void Create(Podcast entitet)
        {
            podcasts.Add(entitet);
            SaveChanges();
        }

        public override void Delete(int id)
        {
            var podcastToRemove = podcasts.FirstOrDefault(pod => pod.ID == id);
            if (podcastToRemove != null)
            {
                podcasts.Remove(podcastToRemove);
                SaveChanges();
            }
        }

        public override List<Podcast> GetAll()
        {
            try
            {
                return nySerialiserare.DeSerialiseraPodcasts();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public KategoriLista LoadCategoryList()
        {
            var kategoriLista = new KategoriLista { Categories = new List<string>() };

            foreach (var podcast in GetAll())
            {
                kategoriLista.Categories.Add(podcast.Namn);
            }

            return kategoriLista;
        }

        public void SaveCategoryList(KategoriLista kategoriLista)
        {
            podcasts.Clear();
            foreach (var kategoriNamn in kategoriLista.Categories)
            {
                podcasts.Add(new Podcast { Namn = kategoriNamn });
            }
            SaveChanges();
        }

        public override void SaveChanges()
        {
            nySerialiserare.SerialiseraPodcasts(podcasts);
        }

        public override void Update(int id, Podcast entitet)
        {
            int index = podcasts.FindIndex(pod => pod.ID == entitet.ID);

            if (index >= 0)
            {
                podcasts[index] = entitet;
                SaveChanges();
            }
        }

        public Kategori GetById(int id)
        {
            var podcast = kategorier.FirstOrDefault(p => p.ID == id);
            if (podcast == null)
            {
                throw new Exception("Ingen podcast hittad med det angivna ID:t.");
            }
            return podcast;
        }
    }
}

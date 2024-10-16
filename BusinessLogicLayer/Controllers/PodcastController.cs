﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Repositories;
using Models;
using System.Xml;
using System.ServiceModel.Syndication;
using PoddProjekt;

namespace BusinessLogicLayer.Controllers
{
    public class PodcastController
    {

        private const int INITIAL_ID = 1;

        private readonly HuvudRepository<Podcast> huvudRepository; // Vårt data repository.

        public PodcastController()
        {
            HuvudRepository = new PodcastRepository();
        }

        public void AddPodcast(Podcast newPodcast)
        {
            if (newPodcast == null)
            {
                throw new ArgumentNullException(nameof(newPodcast), "Podcast kan inte vara null.");
            }

            if (string.IsNullOrEmpty(newPodcast.Url))
            {
                throw new ArgumentException("Podcast måste ha en giltig URL.");
            }

            if (string.IsNullOrEmpty(newPodcast.Titel))
            {
                throw new ArgumentException("Podcast måste ha ett namn.");
            }

            // Kontrollera om en podcast med samma URL redan finns.
            var existingPodcast = HuvudRepository.GetAll().FirstOrDefault(p => p.Url == newPodcast.Url);
            if (existingPodcast != null)
            {
                throw new InvalidOperationException("En podcast med samma URL finns redan.");
            }

            List<Podcast> allaPodcasts = GetAllPodcasts();

            int podcastensID = GetNextAvailableID(allaPodcasts);

            newPodcast.ID = podcastensID;

            HuvudRepository.Create(newPodcast);
        }

        public List<Podcast> GetAllPodcasts()
        {
            return HuvudRepository.GetAll();
        }

        public List<Podcast> GetPodcastsByKategori(Category category)
        {
            List<Podcast> allaPodcasts = GetAllPodcasts();

            int kategoriID = kategori.ID;

            var podcasts = allaPodcasts.Where(p => p.PodcastKategori.ID == kategoriID);

            List<Podcast> podcastsInomKategorin = podcasts.ToList();

            return podcastsInomKategorin;
        }

        public Avsnitt? GetPodcastensSenasteAvsnitt(Podcast valdPodcast)
        {
            Avsnitt senasteAvsnittet = valdPodcast.Episode[0];
            return senasteAvsnittet;
        }

        public Podcast? GetPodcastByUrl(string url)
        {
            return HuvudRepository.GetAll().FirstOrDefault(p => p.Url == url);
        }

        public void UpdatePodcast(int id, Podcast updatedPodcast)
        {
            try
            {
                var existingPodcast = HuvudRepository.GetAll().FirstOrDefault(p => p.ID == id);
                if (existingPodcast == null)
                {
                    throw new InvalidOperationException("Podcasten hittades inte.");
                }

                Console.WriteLine("Befintlig URL: " + existingPodcast.Url);
                Console.WriteLine("Uppdaterad URL: " + updatedPodcast.Url);

                // Validering för att inte tillåta URL att ändras.
                if ((existingPodcast.Url?.Trim() ?? string.Empty) != (updatedPodcast.Url?.Trim() ?? string.Empty))
                {
                    throw new InvalidOperationException("Det är inte tillåtet att ändra podcastens URL.");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            // Du kan lägga till fler valideringar här om det behövs.

            HuvudRepository.Update(id, updatedPodcast);
        }

        public void UpdatePodcastByUrl(string url, Podcast updatedPodcast)
        {
            var podcastToUpdate = GetPodcastByUrl(url);
            if (podcastToUpdate != null)
            {
                UpdatePodcast(podcastToUpdate.ID, updatedPodcast);
            }
            else
            {
                throw new InvalidOperationException("Ingen podcast med den angivna URL:en hittades.");
            }
        }

        public void DeletePodcast(int id)
        {
            HuvudRepository.Delete(id);
        }

        public void DeletePodcastByUrl(string url)
        {
            var podcastToDelete = GetPodcastByUrl(url);
            if (podcastToDelete != null)
            {
                DeletePodcast(podcastToDelete.ID);
            }
            else
            {
                throw new InvalidOperationException("Ingen podcast med den angivna URL:en hittades.");
            }
        }

        public int GetNextAvailableID(List<Podcast> allaPodcasts)
        {
            // Hämtar nästa lediga ID
            if (allaPodcasts.Count == 0)
            {
                return INITIAL_ID;
            }

            // Om listan inte är tom, hämtar vi det högsta ID:t och lägger till 1
            int maxID = allaPodcasts.Max(k => k.ID);
            return maxID + 1;
        }

        // ... andra relevanta metoder för affärslogik ...
    }
}

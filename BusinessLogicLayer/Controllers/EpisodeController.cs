using DataAccessLayer.Repositories;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Controllers
{
    public class EpisodeController
    {
        private readonly HuvudRepository<Episode> _repository;

        public EpisodeController(HuvudRepository<Episode> repository)
        {
            _repository = repository;
        }

        public void AddEpisode(Episode newEpisode)
        {
            // Valideringar och affärsregler för att lägga till ett avsnitt.
            _repository.Create(newEpisode);
        }

        public IEnumerable<Episode> GetAllEpisodes()
        {
            return _repository.GetAll();
        }

        public void UpdateEpisode(int id, Episode updatedEpisode)
        {
            // Valideringar och affärsregler för uppdatering.
            _repository.Update(id, updatedEpisode);
        }

        public void DeleteEpisode(int id)
        {
            _repository.Delete(id);
        }

        // ... fler metoder efter behov ...
    }
}

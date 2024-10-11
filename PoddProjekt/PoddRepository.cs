using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoddProjekt
{
    public class PoddRepository : IPoddRepository
    {
        private List<Podd> podds = new List<Podd>();

        public  void AddPodd(Podd podd)
        {
            podds.Add(podd);
        }

        public Podd GetPodd(int id)
        {
            return podds.First(b => b.Id == id);
        }

        public IEnumerable<Podd> GetAllPodds()
        {
            return podds;
        }

        public void UpdatePodd(Podd podd)
        {
            var  existingPodd = GetPodd(podd.Id);
            if (existingPodd != null)
            {
                existingPodd.Title = podd.Title;
                existingPodd.Author = podd.Author;
            }
        }

        public void DeletePodd(int id)
        {
            var podd = GetPodd(id);
            if (podd != null)
            {
                podds.Remove(podd);
            }
        }

    }
}

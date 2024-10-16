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


    }
}

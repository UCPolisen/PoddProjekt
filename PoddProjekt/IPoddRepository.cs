using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoddProjekt
{
    //Del av  repository pattern
    //fungerar som mellandhand  mellan repository och interface
    public interface IPoddRepository
    {
        void AddPodd(Podd podd);
        Podd GetPodd(int id);
        IEnumerable<Podd> GetAllPodds();
        void UpdatePodd(Podd podd);
        void DeletePodd(int id);
    }
}
HE HEJ HEK
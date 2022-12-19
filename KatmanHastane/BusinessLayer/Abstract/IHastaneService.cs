using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IHastaneService
    {
        int AddHastane(Hastane hastane);
        int UpdateHastane(Hastane hastane);
        int DeleteHastane(Hastane hastane);
        List<Hastane> GetAllHastaneList();
        Hastane getHastaneByID(int id);
    }
}

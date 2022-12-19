using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IPoliklinikService
    {
        int AddPoliklinik(Poliklinik poliklinik);
        int DeletePoliklinik(Poliklinik poliklinik);
        int UpdatePoliklinik(Poliklinik poliklinik);
        List<Poliklinik> GetAllPoliklinikList();
        Poliklinik GetPoliklinikById(int id);
    }
}

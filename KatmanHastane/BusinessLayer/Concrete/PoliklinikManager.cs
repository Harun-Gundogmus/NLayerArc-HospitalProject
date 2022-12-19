using BusinessLayer.Abstract;
using DataAccess.Abstract;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class PoliklinikManager : IPoliklinikService
    {
        IPoliklinikDal poliklinikDal;
        public PoliklinikManager(IPoliklinikDal poliklinikDal)
        {
            this.poliklinikDal = poliklinikDal;
        }

        public int AddPoliklinik(Poliklinik poliklinik)
        {
            return poliklinikDal.Add(poliklinik);
        }

        public int DeletePoliklinik(Poliklinik poliklinik)
        {
            return poliklinikDal.Delete(poliklinik);
        }

        public List<Poliklinik> GetAllPoliklinikList()
        {
            return poliklinikDal.getAll();
        }

        public Poliklinik GetPoliklinikById(int id)
        {
            return poliklinikDal.getByID(id);
        }

        public int UpdatePoliklinik(Poliklinik poliklinik)
        {
            return poliklinikDal.Update(poliklinik);
        }
    }
}

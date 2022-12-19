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
    public class HastaneManager : IHastaneService
    {
        IHastaneDal hastaneDal;
        public HastaneManager(IHastaneDal hastaneDal)
        {
            this.hastaneDal = hastaneDal;
        }

        public int AddHastane(Hastane hastane)
        {
            return hastaneDal.Add(hastane);
        }

        public int DeleteHastane(Hastane hastane)
        {
            return hastaneDal.Delete(hastane);
        }

        public List<Hastane> GetAllHastaneList()
        {
            return hastaneDal.getAll();
        }

        public Hastane getHastaneByID(int id)
        {
            return hastaneDal.getByID(id);
        }

        public int UpdateHastane(Hastane hastane)
        {
            return hastaneDal.Update(hastane);
        }
    }
}

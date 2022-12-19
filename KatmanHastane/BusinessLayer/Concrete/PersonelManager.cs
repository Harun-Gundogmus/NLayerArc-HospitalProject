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
    public class PersonelManager : IPersonelService
    {
        IPersonelDal personelDal;
        public PersonelManager(IPersonelDal personelDal)
        {
            this.personelDal = personelDal;
        }

        public int AddPersonel(Personel personel)
        {
            return personelDal.Add(personel);
        }

        public int DeletePersonel(Personel personel)
        {
            return personelDal.Delete(personel);
        }

        public List<Personel> GetAllPersonelList()
        {
            return personelDal.getAll();
        }

        public Personel getPersonelById(int id)
        {
            return personelDal.getByID(id);
        }

        public int UpdatePersonel(Personel personel)
        {
            return personelDal.Update(personel);
        }
    }
}

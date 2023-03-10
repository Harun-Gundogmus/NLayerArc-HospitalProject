using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IPersonelService
    {
        int AddPersonel(Personel personel);
        int UpdatePersonel(Personel personel);
        int DeletePersonel(Personel personel);
        List<Personel> GetAllPersonelList();
        Personel getPersonelById(int id);
    }
}

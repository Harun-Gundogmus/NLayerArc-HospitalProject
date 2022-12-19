using DataAccess.Abstract;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class PoliklinikDal: Repository<Poliklinik>, IPoliklinikDal
    {
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Poliklinik
    {
        [Key]
        public int poliklinik_ID { get; set; }
        public string poliklinik_Ad { get; set; }
        public ICollection<Personel> Personel { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Hastane
    {
        [Key]
        public int hastane_id { get; set; }
        public string hastane_ad { get; set; }
        public string hastane_sehir { get; set; }
        public ICollection<Personel> Personeller { get; set; }
    }
}

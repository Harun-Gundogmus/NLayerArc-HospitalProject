using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Personel
    {
        [Key]
        public int personel_ID { get; set; }
        public string personel_Adi { get; set; }    
        public string personel_Soyadi { get; set; }

        public Hastane hastane { get; set; }
        public Poliklinik poliklinik{ get; set; }
        
    }
}

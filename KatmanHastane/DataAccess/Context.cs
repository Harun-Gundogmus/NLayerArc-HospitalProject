using EntityLayer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=LAPTOP-5ETPORJT;database=HospitalDB;integrated security=true;");
        }

        public DbSet<Hastane> Hospitals { get; set; }
        public DbSet<Personel> Personals { get; set; }
        public DbSet<Poliklinik> Policlinics { get; set; }
        public DbSet<Login> Logins { get; set; }
    }
}

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JakubTadeuszLab5ZadDom.Models
{
    public class DatabaseContext: DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options): base(options)
        {

        }

        public DbSet<WitcherSchool> WitcherSchools { get; set; }

        public DbSet<Witcher> Witchers { get; set; }

        public DbSet<BeastType> BeastTypes { get; set; }

        public DbSet<Beast> Beasts { get; set; }

        public DbSet<Contract> Contracts { get; set; }
    }
}

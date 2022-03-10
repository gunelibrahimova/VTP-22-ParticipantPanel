using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class ParticipantDbContext : DbContext
    {
        public ParticipantDbContext(DbContextOptions<ParticipantDbContext> options)
           : base(options)
        {

        }

        public DbSet<Count> counts { get; set; }
        public DbSet<Itweb> ıtwebs { get; set; }
        public DbSet<Human> humen { get; set; } 
        public DbSet<Logistic> logistics { get; set; }
        public DbSet<AfDep> afDeps { get; set; }
    }
}

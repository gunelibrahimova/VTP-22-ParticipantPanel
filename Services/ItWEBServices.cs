using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class ItWEBServices
    {
        private readonly ParticipantDbContext _context;

        public ItWEBServices(ParticipantDbContext context)
        {
            _context = context;
        }

        public List<Itweb> GetAll()
        {
            return _context.ıtwebs.ToList();
        }

        public int GetCount()
        {
            return _context.ıtwebs.Count();
        }

        public List<AgePercentage> GetAgePercentage()
        {
            List<AgePercentage> universites = _context.ıtwebs
                .GroupBy(x => x.Age)
                .Select(x => new AgePercentage(x.Key, x.Count())).ToList();

            return universites;
        }
        public void Create(Itweb ıtweb)
        {
            _context.Add(ıtweb);
            _context.SaveChanges();
        }
        public void Delete(int id)
        {
            var itweb = _context.ıtwebs.Find(id);
            _context.Remove(itweb);
            _context.SaveChanges();
        }
    }

    public class AgePercentage
    {
        public int Age;
        public int AgeCount;

        public AgePercentage(int Age, int AgeCount)
        {
            this.Age = Age;
            this.AgeCount = AgeCount;
        }
    }
}


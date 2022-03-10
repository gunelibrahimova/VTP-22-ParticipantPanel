using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class AFServices
    {
        private readonly ParticipantDbContext _context;

        public AFServices(ParticipantDbContext context)
        {
            _context = context;
        }

        public List<AfDep> GetAll()
        {
            return _context.afDeps.ToList();
        }

        public void Create(AfDep afDep)
        {
            _context.Add(afDep);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var afdep = _context.afDeps.Find(id);
            _context.Remove(afdep);

        }
        public int GetCount()
        {
            return _context.afDeps.Count();
        }
    }
}

using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class HRServices
    {
        private readonly ParticipantDbContext _context;

        public HRServices(ParticipantDbContext context)
        {
            _context = context;
        }

        public List<Human> GetAll()
        {
            return _context.humen.ToList();
        }

        public void Create(Human humen)
        {
            _context.Add(humen);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var humen = _context.humen.Find(id);
            _context.Remove(humen);
            _context.SaveChanges();
        }

        public int GetCount()
        {
            return _context.humen.Count();
        }

    }
}

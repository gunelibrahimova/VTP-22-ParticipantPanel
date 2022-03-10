using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class LPServices
    {
        private readonly ParticipantDbContext _context;

        public LPServices(ParticipantDbContext context)
        {
            _context = context;
        }

        public List<Logistic> GetAll()
        {
            return _context.logistics.ToList();
        }

        public void Create(Logistic logistic)
        {
            _context.Add(logistic);
            _context.SaveChanges();

        }

        public void Delete(int id)
        {
            var logistic = _context.logistics.Find(id);
            _context.Remove(logistic);
            _context.SaveChanges();
        }

        public int GetCount()
        {
           return _context.logistics.Count();
        }
    }
}

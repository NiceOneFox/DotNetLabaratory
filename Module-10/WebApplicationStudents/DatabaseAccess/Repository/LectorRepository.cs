using DatabaseAccess.Models;
using DatabaseAccess.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CourseExceptions;

namespace DatabaseAccess.Repository
{
    public class LectorRepository : ILectorRepository
    {
        private readonly CourseDbContext _context;

        public LectorRepository(CourseDbContext courseDbContext)
        {
            _context = courseDbContext;
        }

        public void Delete(int id)
        {
            var lectorToDelete = _context.Lectors.Find(id);
            if (lectorToDelete is null) throw new NotFoundInstanceException($"Instance Lector with ${id} was not found to update");
            _context.Entry(lectorToDelete).State = EntityState.Deleted;
            _context.SaveChanges();
        }

        public LectorDb Edit(LectorDb lector)
        {
            if (_context.Lectors.Find(lector.Id) is LectorDb lectorInDb)
            {
                lectorInDb.FirstName = lector.FirstName;
                lectorInDb.LastName = lector.LastName;
                lectorInDb.Email = lector.Email;
                lectorInDb.Position = lector.Position;
                lectorInDb.SeriesId = lector.SeriesId;
                _context.Entry(lectorInDb).State = EntityState.Modified;
                _context.SaveChanges();
                return lectorInDb;
            } 
            else
            {
                throw new NotFoundInstanceException($"Instance {nameof(lector)} with ${lector.Id} was not found to update");
            }
        }

        public LectorDb? Get(int id)
        {
            return _context.Lectors.FirstOrDefault(l => l.Id == id);
        }

        public IEnumerable<LectorDb> GetAll()
        {
            return _context.Lectors.ToList();
        }

        public int New(LectorDb lector)
        {
            var result = _context.Lectors.Add(lector);
            _context.SaveChanges();
            return result.Entity.Id;
        }
    }
}

using DatabaseAccess.Models;
using DatabaseAccess.RepositoryInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CourseExceptions;

namespace DatabaseAccess.Repository
{
    public class MarkRepository : IMarkRepository
    {
        private readonly CourseDbContext _context;

        public MarkRepository(CourseDbContext context)
        {
            _context = context;
        }

        public double CountAverageMark(int studentId)
        {
            return _context.Marks.Where(m => m.StudentId == studentId).Average(m => m.Mark);
        }

        public void Delete(int id)
        {
            var markToDelete = _context.Marks.Find(id);
            _context.Entry(markToDelete).State = EntityState.Deleted;
            _context.SaveChanges();
        }

        public void Edit(MarkDb mark)
        {
            if (_context.Marks.Find(mark.Id) is MarkDb markInDb)
            {
                markInDb.Mark = mark.Mark;
                markInDb.Text = mark.Text;
                markInDb.StudentId = mark.StudentId;
                markInDb.LectureId = mark.LectureId;
                _context.Entry(markInDb).State = EntityState.Modified;
                _context.SaveChanges();
            } 
            else
            {
                throw new NotFoundInstanceException($"Instance {nameof(mark)} with {mark.Id} was not found in context");
            }
            
        }

        public MarkDb? Get(int id)
        {
            return _context.Marks.Find(id);
        }

        public IEnumerable<MarkDb> GetAll()
        {
            return _context.Marks.ToList();
        }

        public int New(MarkDb mark)
        {
            var result = _context.Marks.Add(mark);
            _context.SaveChanges();
            return result.Entity.Id;
        }
    }
}

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
    public class HomeworkRepository : IHomeworkRepository
    {
        private readonly CourseDbContext _context;

        public HomeworkRepository(CourseDbContext courseDbContext)
        {
            _context = courseDbContext;
        }
        public void Delete(int id)
        {
           var homeworkToDelete = _context.Homeworks.Find(id);
            _context.Entry(homeworkToDelete).State = EntityState.Deleted;
            _context.SaveChanges();
        }

        public HomeworkDb Edit(HomeworkDb homework)
        {
            if (_context.Homeworks.Find(homework.Id) is HomeworkDb homeworkInDb)
            {
                homeworkInDb.DeadLine = homework.DeadLine;
                homeworkInDb.Text = homework.Text;
                homeworkInDb.LectureId = homework.LectureId;
                _context.Entry(homeworkInDb).State = EntityState.Modified;
                _context.SaveChanges();
                return homeworkInDb;
            } 
            else
            {
                throw new NotFoundInstanceException($"Instance {nameof(homework)} with ${homework.Id} was not found to update");
            }
        }

        public HomeworkDb? Get(int id)
        {
            return _context.Homeworks.FirstOrDefault(h => h.Id == id);
        }

        public IEnumerable<HomeworkDb> GetAll()
        {
            return _context.Homeworks.ToList();
        }

        public int New(HomeworkDb homework)
        {
            var result = _context.Homeworks.Add(homework);
            _context.SaveChanges();
            return result.Entity.Id;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseAccess.Models;
using DatabaseAccess.RepositoryInterfaces;
using Microsoft.EntityFrameworkCore;

namespace DatabaseAccess.Repository
{
    public class LectureRepository : ILectureRepository
    {
        private readonly CourseDbContext _context;

        public LectureRepository(CourseDbContext context)
        {
            _context = context;
        }
        public void Delete(int id)
        {
            var lectureToDelete =_context.Lectures.Find(id);
            _context.Entry(lectureToDelete).State = EntityState.Deleted;
            _context.SaveChanges();
        }

        public void Edit(LectureDb lecture)
        {
            if (_context.Lectures.Find(lecture.Id) is LectureDb lectureInDb)
            {
                lectureInDb.Name = lecture.Name;
                lectureInDb.Date = lecture.Date;
                lectureInDb.SeriesId = lecture.SeriesId;
                lectureInDb.HomeworkId = lecture.HomeworkId;
                _context.Entry(lectureInDb).State = EntityState.Modified;
                _context.SaveChanges();
            }
        }

        public LectureDb? Get(int id)
        {
            return _context.Lectures.FirstOrDefault(l => l.Id == id);
        }

        public IEnumerable<LectureDb> GetAll()
        {
            return _context.Lectures.ToList();
        }

        public int New(LectureDb lecture)
        {
            var result = _context.Lectures.Add(lecture);
            _context.SaveChanges();
            return result.Entity.Id;
        }
    }
}

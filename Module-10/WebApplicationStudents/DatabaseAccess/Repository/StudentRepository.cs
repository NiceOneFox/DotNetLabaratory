using DatabaseAccess.Models;
using DatabaseAccess.Repository;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using CourseExceptions;

namespace DatabaseAccess.Repository
{
    public class StudentRepository : IStudentRepository
    {
        private readonly CourseDbContext _context;

        public StudentRepository(CourseDbContext coureDbContext)
        {
            _context = coureDbContext;
        }

        public void Delete(int id)
        {
            var studentToDelete = _context.Students.Find(id);
            _context.Entry(studentToDelete).State = EntityState.Deleted;
            _context.SaveChanges();
        }

        public StudentDb Edit(StudentDb student)
        {
            if (_context.Students.Find(student.Id) is StudentDb studentInDB)
            {
                studentInDB.FirstName = student.FirstName;
                studentInDB.LastName = student.LastName;
                studentInDB.Age = student.Age;
                studentInDB.Email = student.Email;
                studentInDB.Score = student.Score;
                _context.Entry(studentInDB).State = EntityState.Modified;
                _context.SaveChanges();
                return studentInDB;
            }
            else
            {
                throw new NotFoundInstanceException($"Instance {nameof(student)} with {student.Id} was not found in context");
            }
        }

        public StudentDb Get(int id)
        {
            return _context.Students.FirstOrDefault(s => s.Id == id);
        }

        public IEnumerable<StudentDb> GetAll()
        {
            return _context.Students.ToList();
        }

        public int New(StudentDb student)
        {
            var result = _context.Students.Add(student);
            _context.SaveChanges();
            return result.Entity.Id;
        }
    }
}
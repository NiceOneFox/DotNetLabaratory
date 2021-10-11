using DatabaseAccess.Models;
using DatabaseAccess.Repository;
using System.Collections.Generic;

namespace DatabaseAccess
{
    public class StudentRepository : IStudentRepository
    {
        private readonly StudentDbContext _studentDbContext;

        public StudentRepository(StudentDbContext studentDbContext)
        {
            _studentDbContext = studentDbContext;
        }

        public void Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public void Edit(StudentDb person)
        {
            throw new System.NotImplementedException();
        }

        public StudentDb Get(int id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<StudentDb> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public int New(StudentDb person)
        {
            throw new System.NotImplementedException();
        }
    }
}
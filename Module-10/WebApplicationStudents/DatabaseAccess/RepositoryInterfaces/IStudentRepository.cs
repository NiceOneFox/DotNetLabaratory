using DatabaseAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseAccess.Repository
{
    public interface IStudentRepository
    {
        void Delete(int id);
        StudentDb Edit(StudentDb student);
        StudentDb? Get(int id);
        IEnumerable<StudentDb> GetAll();
        int New(StudentDb student);
    }

}

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
        void Edit(StudentDb person);
        StudentDb? Get(int id);
        IEnumerable<StudentDb> GetAll();
        int New(StudentDb person);
    }

}

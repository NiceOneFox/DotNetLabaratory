using System;
using System.Collections.Generic;
using BusinessLogic.Models;

namespace BusinessLogic.ServiceInterfaces
{
    public interface IStudentService
    {
        StudentBl? Get(int id);
        IReadOnlyCollection<StudentBl> GetAll();
        int New(StudentBl student);
        StudentBl? Edit(StudentBl student);
        void Delete(int id);
    }
}

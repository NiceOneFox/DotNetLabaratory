using System;
using System.Collections.Generic;
using BusinessLogic.Models;

namespace BusinessLogic
{
    public interface IStudentService
    {
        Student? Get(int id);
        IReadOnlyCollection<Student> GetAll();
        int New(Student student);
        int Edit(Student student);
        void Delete(int id);
    }
}

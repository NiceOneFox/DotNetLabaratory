using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseAccess.Models;

namespace DatabaseAccess.RepositoryInterfaces
{
    public interface ILectureRepository
    {
        void Delete(int id);
        void Edit(LectureDb lecture);
        LectureDb? Get(int id);
        IEnumerable<LectureDb> GetAll();
        int New(LectureDb lecture);
    }
}

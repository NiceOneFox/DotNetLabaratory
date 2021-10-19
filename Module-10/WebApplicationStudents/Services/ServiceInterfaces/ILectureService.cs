using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogic.Models;

namespace BusinessLogic.ServiceInterfaces
{
    public interface ILectureService
    {
        Lecture? Get(int id);
        IReadOnlyCollection<Lecture> GetAll();
        int New(Lecture lecture);
        int Edit(Lecture lecture);
        void Delete(int id);
    }
}

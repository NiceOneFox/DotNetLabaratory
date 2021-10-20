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
        LectureBl? Get(int id);
        IReadOnlyCollection<LectureBl> GetAll();
        int New(LectureBl lecture);
        int Edit(LectureBl lecture);
        void Delete(int id);
    }
}

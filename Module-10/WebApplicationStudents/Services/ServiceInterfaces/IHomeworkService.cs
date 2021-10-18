using BusinessLogic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.ServiceInterfaces
{
    public interface IHomeworkService
    {
        Homework? Get(int id);
        IReadOnlyCollection<Homework> GetAll();
        int New(Homework homework);
        int Edit(Homework homework);
        void Delete(int id);
    }
}

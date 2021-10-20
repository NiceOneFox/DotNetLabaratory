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
        HomeworkBl? Get(int id);
        IReadOnlyCollection<HomeworkBl> GetAll();
        int New(HomeworkBl homework);
        int Edit(HomeworkBl homework);
        void Delete(int id);
    }
}

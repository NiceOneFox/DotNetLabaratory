using DatabaseAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseAccess.RepositoryInterfaces
{
    public interface IHomeworkRepository
    {
        void Delete(int id);
        void Edit(HomeworkDb homework);
        HomeworkDb? Get(int id);
        IEnumerable<HomeworkDb> GetAll();
        int New(HomeworkDb homework);
    }
}

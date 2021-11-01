using DatabaseAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseAccess.RepositoryInterfaces
{
    public interface IMarkRepository
    {
        void Delete(int id);
        void Edit(MarkDb mark);
        MarkDb? Get(int id);
        IEnumerable<MarkDb> GetAll();
        int New(MarkDb mark);
    }
}

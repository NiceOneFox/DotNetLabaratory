using DatabaseAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseAccess.Repository
{
    public interface ILectorRepository
    {
        void Delete(int id);
        int? Edit(LectorDb lector);
        LectorDb? Get(int id);
        IEnumerable<LectorDb> GetAll();
        int New(LectorDb lector);
    }
}

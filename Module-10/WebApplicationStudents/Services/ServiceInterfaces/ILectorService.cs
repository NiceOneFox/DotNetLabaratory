using BusinessLogic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.ServiceInterfaces
{
    public interface ILectorService
    {
        LectorBl? Get(int id);
        IReadOnlyCollection<LectorBl> GetAll();
        int New(LectorBl lector);
        LectorBl? Edit(LectorBl lector);
        void Delete(int id);
    }
}

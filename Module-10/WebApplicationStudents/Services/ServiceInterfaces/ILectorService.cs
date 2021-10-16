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
        Lector? Get(int id);
        IReadOnlyCollection<Lector> GetAll();
        int New(Lector lector);
        int Edit(Lector lector);
        void Delete(int id);
    }
}

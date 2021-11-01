using BusinessLogic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.ServiceInterfaces
{
    public interface IMarkService
    {
        MarkBl? Get(int id);
        IReadOnlyCollection<MarkBl> GetAll();
        int New(MarkBl mark);
        int Edit(MarkBl mark);
        void Delete(int id);

        void SendSMSMessage(string telephoneNumber, string message);
    }
}

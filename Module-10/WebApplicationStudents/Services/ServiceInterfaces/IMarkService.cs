using BusinessLogic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogic.SMSSender;

namespace BusinessLogic.ServiceInterfaces
{
    public interface IMarkService
    {
        MarkBl? Get(int id);
        IReadOnlyCollection<MarkBl> GetAll();
        int New(MarkBl mark);
        MarkBl? Edit(MarkBl mark);
        void Delete(int id);

        void SendSMSMessage(SMSMessage SMS);
    }
}

using AutoMapper;
using BusinessLogic.Models;
using BusinessLogic.ServiceInterfaces;
using DatabaseAccess.Models;
using DatabaseAccess.RepositoryInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Services
{
    public class MarkService : IMarkService
    {
        private readonly IMarkRepository _markRepository;

        private readonly IMapper _mapper;

        public MarkService(IMarkRepository markRepository, IMapper mapper)
        {
            _markRepository = markRepository;
            _mapper = mapper;
        }

        public void Delete(int id)
        {
            _markRepository.Delete(id);
        }

        public int Edit(MarkBl mark)
        {
            var markDb = _mapper.Map<MarkDb>(mark);
            _markRepository.Edit(markDb);
            return markDb.Id;
        }

        public MarkBl? Get(int id)
        {
            var markDb = _markRepository.Get(id);
            return _mapper.Map<MarkBl>(markDb);
        }

        public IReadOnlyCollection<MarkBl> GetAll()
        {
            var markDb = _markRepository.GetAll();
            return _mapper.Map<IReadOnlyCollection<MarkBl>>(markDb);
        }

        public int New(MarkBl mark)
        {
            var markDb = _mapper.Map<MarkDb>(mark);
            return _markRepository.New(markDb);
        }

        public void SendSMSMessage(string telephoneNumber, string message)
        {
            throw new NotImplementedException();
        }
    }
}

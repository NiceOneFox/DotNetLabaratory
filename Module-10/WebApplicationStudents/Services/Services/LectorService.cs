using AutoMapper;
using BusinessLogic.Models;
using BusinessLogic.ServiceInterfaces;
using DatabaseAccess.Models;
using DatabaseAccess.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Services
{
    public class LectorService : ILectorService
    {
        private readonly ILectorRepository _lectorRepository;

        private readonly IMapper _mapper;

        public LectorService(ILectorRepository lectorRepository, IMapper mapper)
        {
            _lectorRepository = lectorRepository;
            _mapper = mapper;
        }

        public void Delete(int id)
        {
            _lectorRepository.Delete(id);
        }

        public LectorBl? Edit(LectorBl lector)
        {
            var lectorDb = _mapper.Map<LectorDb>(lector);
            var editedLectorDb = _lectorRepository.Edit(lectorDb);
            return _mapper.Map<LectorBl>(editedLectorDb);
        }

        public LectorBl? Get(int id)
        {
            var lectorDb = _lectorRepository.Get(id);
            return _mapper.Map<LectorBl?>(lectorDb);
        }

        public IReadOnlyCollection<LectorBl> GetAll()
        {
            var lectorDb = _lectorRepository.GetAll();
            return _mapper.Map<IReadOnlyCollection<LectorBl>>(lectorDb);
        }

        public int New(LectorBl lector)
        {
            var lectorDb = _mapper.Map<LectorDb>(lector);
            return _lectorRepository.New(lectorDb);
        }
    }
}

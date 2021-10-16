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

        public int Edit(Lector lector)
        {
            var lectorDb = _mapper.Map<LectorDb>(lector);
            _lectorRepository.Edit(lectorDb);
            return lectorDb.Id;
        }

        public Lector? Get(int id)
        {
            var lectorDb = _lectorRepository.Get(id);
            return _mapper.Map<Lector?>(lectorDb);
        }

        public IReadOnlyCollection<Lector> GetAll()
        {
            var lectorDb = _lectorRepository.GetAll();
            return _mapper.Map<IReadOnlyCollection<Lector>>(lectorDb);
        }

        public int New(Lector lector)
        {
            var lectorDb = _mapper.Map<LectorDb>(lector);
            return _lectorRepository.New(lectorDb);
        }
    }
}

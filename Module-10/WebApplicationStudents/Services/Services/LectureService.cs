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
    public class LectureService : ILectureService
    {
        private readonly ILectureRepository _lectureRepository;

        private readonly IMapper _mapper;

        public LectureService(ILectureRepository lectureRepository, IMapper mapper)
        {
            _lectureRepository = lectureRepository;
            _mapper = mapper;
        }
        public void Delete(int id)
        {
            _lectureRepository.Delete(id);
        }

        public int Edit(Lecture lecture)
        {
            var lectureDb = _mapper.Map<LectureDb>(lecture);
            _lectureRepository.Edit(lectureDb);
            return lectureDb.Id;
        }

        public Lecture? Get(int id)
        {
            var lectureDb = _lectureRepository.Get(id);
            return _mapper.Map<Lecture?>(lectureDb);
        }

        public IReadOnlyCollection<Lecture> GetAll()
        {
            var lectureInDb = _lectureRepository.GetAll();
            return _mapper.Map<IReadOnlyCollection<Lecture>>(lectureInDb);
        }

        public int New(Lecture lecture)
        {
            var lectureDb = _mapper.Map<LectureDb>(lecture);
            return _lectureRepository.New(lectureDb);
        }
    }
}

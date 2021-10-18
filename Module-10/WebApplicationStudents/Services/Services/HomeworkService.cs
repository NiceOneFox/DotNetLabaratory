using BusinessLogic.Models;
using BusinessLogic.ServiceInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using DatabaseAccess.RepositoryInterfaces;
using DatabaseAccess.Models;

namespace BusinessLogic.Services
{
    public class HomeworkService : IHomeworkService
    {
        private readonly IHomeworkRepository _homeworkRepository;

        private readonly IMapper _mapper;

        public HomeworkService(IHomeworkRepository homeworkRepository, IMapper mapper)
        {
            _homeworkRepository = homeworkRepository;
            _mapper = mapper;
        }
        public void Delete(int id)
        {
            _homeworkRepository.Delete(id);
        }

        public int Edit(Homework homework)
        {
            var homeworkDb = _mapper.Map<HomeworkDb>(homework);
            _homeworkRepository.Edit(homeworkDb);
            return homeworkDb.Id;
        }

        public Homework? Get(int id)
        {
            var homeworkDb = _homeworkRepository.Get(id);
            return _mapper.Map<Homework?>(homeworkDb);
        }

        public IReadOnlyCollection<Homework> GetAll()
        {
            var homeworkDb = _homeworkRepository.GetAll();
            return _mapper.Map<IReadOnlyCollection<Homework>>(homeworkDb);
        }

        public int New(Homework homework)
        {
            var homeworkDb = _mapper.Map<HomeworkDb>(homework);
            return _homeworkRepository.New(homeworkDb);
        }
    }
}

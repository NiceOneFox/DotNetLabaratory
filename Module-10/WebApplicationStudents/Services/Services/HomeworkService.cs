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

        public int Edit(HomeworkBl homework)
        {
            var homeworkDb = _mapper.Map<HomeworkDb>(homework);
            _homeworkRepository.Edit(homeworkDb);
            return homeworkDb.Id;
        }

        public HomeworkBl? Get(int id)
        {
            var homeworkDb = _homeworkRepository.Get(id);
            return _mapper.Map<HomeworkBl?>(homeworkDb);
        }

        public IReadOnlyCollection<HomeworkBl> GetAll()
        {
            var homeworkDb = _homeworkRepository.GetAll();
            return _mapper.Map<IReadOnlyCollection<HomeworkBl>>(homeworkDb);
        }

        public int New(HomeworkBl homework)
        {
            var homeworkDb = _mapper.Map<HomeworkDb>(homework);
            return _homeworkRepository.New(homeworkDb);
        }
    }
}

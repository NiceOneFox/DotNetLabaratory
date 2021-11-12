using BusinessLogic.Models;
using System;
using System.Collections.Generic;
using DatabaseAccess.Repository;
using AutoMapper;
using DatabaseAccess.Models;

namespace BusinessLogic
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _studentRepository;

        private readonly IMapper _mapper;

        public StudentService(IStudentRepository studentRepository, IMapper mapper)
        {
            _studentRepository = studentRepository;
            _mapper = mapper;
        }

        public void Delete(int id)
        {
            _studentRepository.Delete(id);
        }

        public int Edit(Student student)
        {
            var studentDb = _mapper.Map<StudentDb>(student);
            _studentRepository.Edit(studentDb);
            return student.Id;
        }

        public Student? Get(int id)
        {
            var studentDb = _studentRepository.Get(id);
            return _mapper.Map<Student?>(studentDb);
        }

        public IReadOnlyCollection<Student> GetAll()
        {
            var studentDb = _studentRepository.GetAll();
            return _mapper.Map<IReadOnlyCollection<Student>>(studentDb);
        }

        public int New(Student student)
        {
            var studentDb = _mapper.Map<StudentDb>(student);
            return _studentRepository.New(studentDb);
        }
    }
}

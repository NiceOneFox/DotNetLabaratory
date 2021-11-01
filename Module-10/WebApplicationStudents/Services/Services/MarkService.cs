using AutoMapper;
using BusinessLogic.Models;
using BusinessLogic.ServiceInterfaces;
using BusinessLogic.SMSSender;
using DatabaseAccess.Models;
using DatabaseAccess.Repository;
using DatabaseAccess.RepositoryInterfaces;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twilio.Clients;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;
using CourseExceptions;

namespace BusinessLogic.Services
{
    public class MarkService : IMarkService
    {
        private readonly IMarkRepository _markRepository;

        private readonly IStudentRepository _studentRepository;

        private readonly IMapper _mapper;

        private readonly ITwilioRestClient _client;

        private readonly ILogger _logger;

        private const double averageMarkLimit = 4;

        public MarkService(IMarkRepository markRepository, IStudentRepository studentRepository, IMapper mapper, ITwilioRestClient client, ILogger logger)
        {
            _markRepository = markRepository;
            _studentRepository = studentRepository;
            _mapper = mapper;
            _client = client;
            _logger = logger;
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

            var resultId = _markRepository.New(markDb);
            CheckAverageMark(mark.StudentId);
            return resultId;
        }

        public void CheckAverageMark(int studentId)
        {
            var averageMarkOfStudent = _markRepository.CountAverageMark(studentId);
            
            if (averageMarkOfStudent < averageMarkLimit)
            {
                var studentDb = _studentRepository.Get(studentId);
                if (studentDb is null)
                {
                    throw new NotFoundInstanceException($"Instance {nameof(studentDb)} with Id {studentId} was not found in context");
                }
                SendSMSMessage(new SMSMessage()
                {
                    From = "+7823634060",
                    To = studentDb.Email,
                    Message = $"Your everage marks of course {averageMarkOfStudent} drop below {averageMarkLimit}"
                });                
            }
        }
        public void SendSMSMessage(SMSMessage SMS)
        {
           var message = MessageResource.Create(
               to: new PhoneNumber(SMS.To),
               from: new PhoneNumber(SMS.From),
               body: SMS.Message,
               client: _client); // pass in the custom client

            _logger.LogInformation($"Send SMS message to {SMS.To} from {SMS.From}");
        }
    }
}

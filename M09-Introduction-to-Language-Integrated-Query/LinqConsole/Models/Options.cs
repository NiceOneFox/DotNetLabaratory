using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandLine;

namespace LinqConsole.Models
{
    public class Options
    {
        [Option('s', "namestudent", Required = true, HelpText = "Full name of the student")]
        public string NameStudent
        {
            get => nameStudent;
            set
            {
                nameStudent = value.Replace("-", " ");
            }
        }

        private string nameStudent;

        [Option('m', "maxmark", Required = false, HelpText = "Max mark of student")]
        public int? MaxMark { get; set; }

        [Option('l', "minmark", Required = false, HelpText = "Min mark of student")]
        public int? MinMark { get; set; }

        [Option('f', "datefrom", Required = false, HelpText = "Date from retriving student's marks")]
        public DateTime? DateFrom
        {
            get => dateFrom;
            set
            {
                dateFrom = DateTime.Parse(value.ToString());
            }
        }

        private DateTime? dateFrom;


        [Option('t', "dateto", Required = false, HelpText = "Date to retriving student's marks")]
        public DateTime? DateTo
        {
            get => dateTo;
            set
            {
                dateTo = DateTime.Parse(value.ToString());
            }

        }

        private DateTime? dateTo;

        [Option('n', "test", Required = false, HelpText = "Test name")]
        public string? TestName { get; set; }

        [Option('r', "sort", Required = false, HelpText = "Sort by field", Separator = ' ')]
        public IEnumerable<string> Sort { get; set; }
      
    }
}

using CommandLine;
using LinqConsole.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqConsole
{
    public static class CommandLineParserLINQ
    {
        public static List<Student> ParseArguments(string[] args, List<Student> allStudents)
        {
            List<Student> sortedStudents = new List<Student>();

            Parser.Default.ParseArguments<Options>(args) // ./LinqConsole -s Grisha-Ivanov -m 5 -l 3
               .WithParsed<Options>(o =>
               {

                   sortedStudents = allStudents
                    .Where(x => (o.NameStudent is not null) ? x.Name == o.NameStudent : true)
                    .Where(x => (o.MaxMark is not null) ? x.Assesment <= o.MaxMark : true)
                    .Where(x => (o.MinMark is not null) ? x.Assesment >= o.MinMark : true)
                    .Where(x => (o.DateFrom is not null) ? x.Date >= o.DateFrom : true)
                    .Where(x => (o.DateTo is not null) ? x.Date <= o.DateTo : true)
                    .Where(x => (o.TestName is not null) ? x.TestName == o.TestName : true)
                    .ToList();


                   if (o.Sort is not null)
                   {
                       Func<Student, object> orderByFunc = item => item.GetType().GetProperty(o.Sort.First()).GetValue(item);

                       if (o.Sort.LastOrDefault() == "asc")
                       {
                           sortedStudents = sortedStudents.OrderBy(orderByFunc).ToList();
                       }
                       else if (o.Sort.LastOrDefault() == "desc")
                       {
                           sortedStudents = sortedStudents.OrderByDescending(orderByFunc).ToList();
                       }
                   }
               });

            return sortedStudents;
        }
    }

}

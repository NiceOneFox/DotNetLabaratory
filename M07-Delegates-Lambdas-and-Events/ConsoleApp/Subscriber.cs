using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Subscriber
    {
        public void Subscribe(Publisher publisher)
        {
            publisher.Notifier += worker_Progress;
        }
        private void worker_Progress(string message)
        {
            Console.WriteLine(message);
        }
    }
}

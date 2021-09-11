using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Publisher
    {
        public delegate void NotifierHandler(string message);

        public event NotifierHandler Notifier;

        public void Work()
        {
            for (int i = 20; i != 0; i--)
            { 
                if (i == 10)
                {
                    Notifier("Passed half time");
                }
                System.Threading.Thread.Sleep(100);
            }
            Notifier("Timer done work");
        }
        
    }
}

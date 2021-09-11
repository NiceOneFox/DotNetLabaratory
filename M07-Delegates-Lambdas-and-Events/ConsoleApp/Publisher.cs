using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Publisher
    {
        public delegate void NotifierHandler(int count);

        public event NotifierHandler Notifier;

        public void Work()
        {
            for (int i = 0; i < 10; i++)
            { 
                Notifier(i * 10); 
                System.Threading.Thread.Sleep(100);
            }
        }
        
    }
}

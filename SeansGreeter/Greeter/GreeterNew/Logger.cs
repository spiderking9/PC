using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlutaCompany.Greeter
{
    public class Logger : ILogger
    {
        private readonly TimeToFormat _formatter;

        public Logger(TimeToFormat formatter)
        {
            _formatter = formatter;
        }


        public void ShowStopWatchMsg(TimeSpan msg)
        {
            Console.WriteLine("Time taken by stopwatch: " + msg);
        }

        public void ShowStartMsg(string msg)
        {
            Console.WriteLine("I'm starting at " +msg);
        }

        public void ShowStopMsg(string msg)
        {
            Console.WriteLine("I'm stoping at " +msg);
        }

        public void Write(string msg)
        {
            Console.WriteLine($"{_formatter.TimeConverting(DateTime.Now)}  {msg}");
        }
    }
}

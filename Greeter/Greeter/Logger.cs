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

        //public void ShowStartMsg(string msg)
        //{
        //    Console.WriteLine("I'm starting at " +msg);
        //}

        //public void ShowStopMsg(string msg)
        //{
        //    Console.WriteLine("I'm stoping at " +msg);
        //}

        public void Write(string msg)
        {
            int counter = Properties.Settings.Default.counter;
            string arr = Properties.Settings.Default.arr;
            if (counter == 3)
            {
                Console.WriteLine(arr);
                Console.WriteLine($"{_formatter.TimeConverting(DateTime.Now)}  {msg}");
                arr = "";
                counter = 0;
            }
            else
            {
                arr =arr+ $"{_formatter.TimeConverting(DateTime.Now)}  {msg}";
                counter++;
            }
            Console.WriteLine(counter +" "+arr);
            Properties.Settings.Default.counter= counter;
            Properties.Settings.Default.arr = arr;
            Properties.Settings.Default.Save();
            
        }
    }
}

using PlutaCompany.Greeter;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing
{
    class Program
    {

        static void Main(string[] args)
        {

            string msg = "C:\\folder\\";

            // New LogMessage method that does this... 2018-12-08 08:12:02.874 I'm starting -- done
            // Google StopWatch class -- done
            // Remove default on GetGreetingText() -- done
            // If GetGreetingText() is called with null or empty string thow an exception -- done
            // 

            //string name1 = null;
            //string name2 = "sean";
            //string name3 = "";

            //Console.WriteLine(name1 + name2 + name3);
            //Console.WriteLine(string.Concat(name1, name2, name3));
            //Console.WriteLine($"{name1}{name2}{name3}");
            //Console.WriteLine(string.Format("{0}{1}{2}", name1, name2, name3));
            //Console.WriteLine(string.Join(",", new[] { name1, name2, name3 }));

            Stopwatch stopWatch = new Stopwatch();                   //stopwatch
            stopWatch.Start();                                       //stopwatch

            TimeToFormat timeCon = new TimeToFormat();

            ILogger logger = new Logger(timeCon);
            ILogger fileLogger = new LogToFile(timeCon);

            DateTime timeStart = DateTime.Now;                       //simple watch  ----------                          
            
            //fileLogger.ShowStartMsg(timeCon.TimeConverting(timeStart)); //simple watch  ----------
            //logger.ShowStartMsg(timeCon.TimeConverting(timeStart));     //simple watch  ----------
            
            IGreeter greeter = new Greeter(fileLogger);
            IGreeter polajtGreeter = new PolajtGreeter(greeter);
            var dobrze = polajtGreeter.GetGreetingText("");


            


            DateTime timeStop = DateTime.Now;                         //simple watch  ----------   
            stopWatch.Stop();                                         //stopwatch
            //fileLogger.ShowStopMsg(timeCon.TimeConverting(timeStop)); //simple watch  ----------
            //logger.ShowStopMsg(timeCon.TimeConverting(timeStop));        //stopwatch
            TimeSpan roznica = timeStop - timeStart;                  //simple watch  ----------   

            Console.WriteLine( dobrze + "time taken: " + roznica);    //simple watch  ---------- +++++ polajtgreeting text   
            //logger.ShowStopWatchMsg(stopWatch.Elapsed);                  //stopwatch
            //fileLogger.ShowStopWatchMsg(stopWatch.Elapsed);            //stopwatch
            Console.ReadKey();
        }
    }
}


using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlutaCompany.Greeter
{
    public class LogToFile: ILogger
    {
        private readonly TimeToFormat _formatter;

        public LogToFile(TimeToFormat formatter)
        {
            _formatter = formatter;
        }

        public static string ShowDate()
        {
            DateTime newDate = DateTime.Now;
            return newDate.ToString("yyyyMMdd");
        }

        static string GetFolderPath()
        {
            return ConfigurationSettings.AppSettings["logFilePath"];
        }

        readonly string filePath = GetFolderPath()+ "GreeterLog" + ShowDate()+".log";

        
        //string filePath1 = @"C:\users";
        //string filePath2 = "C:\users";
        //string filePath3 = "sean\tis\tgreat";

        // \n
        // \
        //

        //public void SaveFolderPath()
        //{
        //    File.AppendAllText(GetFolderPath() + "app.config", GetFolderPath());
        //}

        //public String ShowFolderPath()
        //{
        //    Console.WriteLine(File.ReadAllText(folderPath + "app.config"));
        //    return File.ReadAllText(folderPath + "app.config");
        //}

        public void ShowStopWatchMsg(TimeSpan msg)
        {
            File.AppendAllText(filePath, string.Format("Time taken by stopwatch: "+ msg + "{0}", Environment.NewLine));
        }

        public void ShowStartMsg(string msg)
        {
            File.AppendAllText(filePath, string.Format("I'm starting at " + msg + "{0}", Environment.NewLine));
        }

        public void ShowStopMsg(string msg)
        {
            File.AppendAllText(filePath, string.Format("I'm stoping at " + msg + "{0}", Environment.NewLine));
        }

        public void Write(string msg)
        {
            File.AppendAllText(filePath, string.Format($"{_formatter.TimeConverting(DateTime.Now)}  {msg} "+ "{0}", Environment.NewLine));
        }
    }
}

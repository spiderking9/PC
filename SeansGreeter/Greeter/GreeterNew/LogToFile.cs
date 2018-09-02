using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;

namespace PlutaCompany.Greeter
{
    public class LogToFile: ILogger
    {
        private readonly TimeToFormat _formatter;
        private readonly IList<string> _logMessages = new List<string>();
        private readonly string _logFilePath;

        public LogToFile(TimeToFormat formatter)
        {
            _formatter = formatter;
            _logFilePath = $"{GetFolderPathFromAppSettings()}GreeterLog_{DateTime.Today.ToString("yyyyMMdd")}.log";
        }
        
        static string GetFolderPathFromAppSettings()
        {
            return ConfigurationManager.AppSettings["logFilePath"];
        }
        
        public void Write(string msg)
        {
            _logMessages.Add($"{_formatter.TimeConverting(DateTime.Now)}  {msg}");
            FlushMessagesToFileIfWeHaveThree();
        }

        private void FlushMessagesToFileIfWeHaveThree()
        {
            if (_logMessages.Count % 3 == 0)
            {
                File.AppendAllLines(_logFilePath, _logMessages);
                _logMessages.Clear();
            }                
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlutaCompany.Greeter
{
    public class TimeToFormat
    {
        public string TimeConverting(DateTime time)
        {
            return time.ToString("yyyy-MM-dd HH:mm:ss.fff");
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlutaCompany.Greeter
{
    class CompositeLogger : ILogger
    {
        private readonly IEnumerable<ILogger> _composite;

        public CompositeLogger(IEnumerable<ILogger> composite)
        {
            _composite = composite;
        }

        public void ShowStopWatchMsg(TimeSpan msg)
        {
            throw new NotImplementedException();
        }

        public void Write(string msg)
        {
            throw new NotImplementedException();
        }
    }
}

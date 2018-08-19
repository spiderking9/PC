using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlutaCompany.Greeter
{
    public class PolajtGreeter: IGreeter
    {
        private IGreeter _greeter;

        public PolajtGreeter(IGreeter greeter)
        {
            _greeter = greeter;
        }

        public string GetGreetingText(string name)
        {
            String greetingText = _greeter.GetGreetingText(name);

            return greetingText + " how are you Today? ";
        }

    }
}

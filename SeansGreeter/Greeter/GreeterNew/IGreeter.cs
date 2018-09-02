using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlutaCompany.Greeter
{
    public interface IGreeter
    {
        string GetGreetingText(string name);
    }
}

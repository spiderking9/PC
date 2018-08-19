using System;

namespace PlutaCompany.Greeter
{
    public class Greeter: IGreeter
    {
        private ILogger _logger;

        public Greeter(ILogger logger)
        {
            _logger = logger;
        }

        public string GetGreetingText(string name)
        {
            _logger.Write($"I called GetGreetingText() with {name}");

            System.Threading.Thread.Sleep(50);

            try
            {
                if (String.IsNullOrEmpty(name))
                {
                    //Console.WriteLine("Wrong name, write again");
                    //Console.Beep(3136, 43);
                    throw new System.ArgumentException("Parameter cannot be null or empty", "name");
                }

            }
            catch (Exception ex)
            {
                _logger.Write("Error!"+ex.Message);
                
            }


            _logger.Write($"I finished calling GetGreetingText() with {name}");

            return string.Concat("hello, ", name);

                
                
        }
    }
}

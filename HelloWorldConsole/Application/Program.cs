using HelloWorldConsole.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ApplicationCode applicationCode = new ApplicationCode();

                Console.WriteLine("Web Service Response : " + applicationCode.Run());
                Console.WriteLine("Please press a key...");
                Console.Read();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.InnerException);
                Console.WriteLine(ex.Source);
            }
        }
    }
}

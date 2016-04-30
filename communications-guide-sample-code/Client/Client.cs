using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Example;

namespace Client
{
    class Client
    {
        public static void Main(string[] sa)
        {
            try
            {
                Ice.Communicator communicator = Ice.Util.initialize();
                ConverterPrx cvt = ConverterPrxHelper.checkedCast(
                  communicator.stringToProxy(" converter:tcp -p 10000 -h local host")
                );
                string upper = cvt.toUpper("hello world");
                System.Console.WriteLine("Server returned: " + upper);
                while (true) ; // Holds window to show output

         
            }
            catch (System.Exception ex)
            {
                System.Console.Error.WriteLine(ex);
                System.Environment.Exit(1);
            }
        }
    }
}

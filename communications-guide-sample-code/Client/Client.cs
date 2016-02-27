using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Example;

namespace Client
{
    public class Client
    {
        public static void Main(string[] sa)
        {
            try
            {
                Ice.Communicator communicator = Ice.Util.initialize();
                ConverterPrx cvt = ConverterPrxHelper.checkedCast(
                    communicator.stringToProxy("converter:tcp -p 10000 -h localhost")
                );
                string upper = cvt.toUpper("Hello World");
                System.Console.WriteLine("Server Returned:" + upper);
                while (true) ;
                communicator.destroy();
            }
            catch (System.Exception ex)
            {
                System.Console.Error.WriteLine(ex);
                System.Environment.Exit(1);
            }
        }
    }
}

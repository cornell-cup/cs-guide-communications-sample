using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ice;

namespace Client
{
    class ConverterI : Example.ConverterDisp_
    {
        public override string toUpper(string s, Ice.Current c)
        {
            return s.ToUpper();
        }
    }
}

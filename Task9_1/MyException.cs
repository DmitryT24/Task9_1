using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task9_1
{
    internal class MyException: Exception
    {
        public MyException():base("Custom The argument to a function ") { }
    }
}

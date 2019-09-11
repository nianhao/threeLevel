using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace threeLevel
{
    class Logger
    {
        public static void logWrite(string msg)
        {
            Trace.WriteLine(msg);
        }
    }
}

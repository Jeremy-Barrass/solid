using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreakingSingleResponsibility
{
    class ErrorLog
    {
        public void LogErrorToConsole(Exception error)
        {
            Console.WriteLine(error);
        }

        public void LogErrorToFile(Exception error)
        {
            System.IO.File.WriteAllText(@"C:\Error.txt", error.ToString());
        }
    }
}

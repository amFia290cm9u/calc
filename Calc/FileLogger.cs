using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    /// <summary>
    /// Log impl.
    /// </summary>
    class FileLogger : ILogger
    {
        public void LogIt(string message)
        {            
            File.AppendAllText(@"log.txt", String.Format("{0} - {1}", DateTime.Now.ToString(), message + Environment.NewLine));                        
        }
    }
}

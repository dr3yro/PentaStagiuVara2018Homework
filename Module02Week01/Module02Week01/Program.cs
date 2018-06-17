using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module02Week01
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleLogger consoleLogger = new ConsoleLogger();
            ReadFile readFile = new ReadFile();

            readFile.FileRead += consoleLogger.OnFileRead;
            readFile.FileDoesNotExist += consoleLogger.OnFileDoesNotExist;

            readFile.ReadFileStream();
            Console.ReadLine();
        }
    }
}

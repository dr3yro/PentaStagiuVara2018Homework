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
            
            while (true)
            {
                string userOption = consoleLogger.DisplayOptions();

                switch (userOption)
                {
                    case "1":
                        Console.Write("Please enter the new name: ");
                        string person = Console.ReadLine();
                        AppendFile appendNewUser = new AppendFile();
                        appendNewUser.fileManipulator(person);
                        readFile.ReadFileStream();
                        break;
                    case "2":
                        Console.WriteLine("Here we will delete a name from the list!");
                        break;
                    case "3":
                        return;
                    default:
                        Console.WriteLine("Wrong option! Please pick again:");
                        consoleLogger.DisplayOptions();
                        break;
                }
            }
        }
    }
}

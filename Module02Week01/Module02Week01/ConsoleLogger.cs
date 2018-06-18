using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module02Week01
{
    class ConsoleLogger
    {
        public string DisplayOptions()
        {
            Console.WriteLine();
            Console.WriteLine("Please choose one of the below options: ");
            Console.WriteLine("1. Insert a new person");
            Console.WriteLine("2. Delete a person");
            Console.WriteLine("3. Exit Application");
            Console.WriteLine();
            Console.Write("Please enter your option: ");
            string userChoise = Console.ReadLine();
            return userChoise;
        }

        public void OnFileRead(object source, EventArgs e)
        {
            Console.WriteLine("File OK!");
            Console.WriteLine();
        }

        public void OnFileDoesNotExist(object source, EventArgs e)
        {
            Console.WriteLine("Files could not be found! The file was created with the following dummy names: ");
            Console.WriteLine();
        }
    }
}

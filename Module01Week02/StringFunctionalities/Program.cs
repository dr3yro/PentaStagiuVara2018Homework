using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFunctionalities
{
    class Program
    {
        static void Main(string[] args)
        {
            //split
            Console.WriteLine("Testing the split functionality:");
            string testingSplit = "This string will be transformed into an array";
            string[] splittedTestingSplit = testingSplit.Split(' ');

            //iterate through array
            foreach (string word in splittedTestingSplit)
            {
                Console.WriteLine(word);
                
            }

            Console.WriteLine();

            //remove
            Console.WriteLine("Testing the remove functionality + overload:");
            string testingRemove = "Appreciation";
            string testedRemove = testingRemove.Remove(5);
            string testedRemoveOverload = testingRemove.Remove(5, 3);
            Console.WriteLine(testedRemove);
            Console.WriteLine(testedRemoveOverload);

            Console.ReadLine();
        }
    }
}

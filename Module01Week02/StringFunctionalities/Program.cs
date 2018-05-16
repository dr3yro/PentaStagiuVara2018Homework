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
            //1. split
            Console.WriteLine("Testing the split functionality:");
            string testingSplit = "This string will be transformed into an array";
            string[] splittedTestingSplit = testingSplit.Split(' ');

            foreach (string word in splittedTestingSplit)
            {
                Console.WriteLine(word);
                
            }

            Console.WriteLine();

            //2. remove
            Console.WriteLine("Testing the remove functionality + overload:");
            string testingRemove = "Appreciation";
            string testedRemove = testingRemove.Remove(5);
            string testedRemoveOverload = testingRemove.Remove(5, 3);
            Console.WriteLine(testedRemove);
            Console.WriteLine(testedRemoveOverload);

            Console.WriteLine();

            //3. contains
            Console.Write("Please enter a word to start searching for the substring \"test\": ");
            string userString = Console.ReadLine();
            if (userString.Contains("test"))
            {
                Console.WriteLine("Evaluation complete! The word you provided DOES contain the substring test!");
            }
            else
            {
                Console.WriteLine("Evaluation complete! The word you provided DOES NOT contain the substring test!");
            }

            Console.WriteLine();

            //4. empty
            Console.Write("Please enter a word. By not entering anything you will help show the functionality of \"empty\": ");
            userString = Console.ReadLine();
            if (userString == string.Empty)
            {
                Console.WriteLine("You did not provide any input! That`s great!");
            }
            else
            {
                Console.WriteLine("Well you decided not to be a team player!");
            }

            Console.WriteLine();

            // 5. equals
            Console.Write("Please enter a word for the first variable: ");
            string firstUserInput = Console.ReadLine();

            Console.Write("Please enter a word for the second variable: ");
            string secondUserInput = Console.ReadLine();

            if (firstUserInput.Equals(secondUserInput))
            {
                Console.WriteLine("Analysis complete! Strings match!");
            }
            else
            {
                Console.WriteLine("Analysis complete! Strings DO NOT match!");
            }

            Console.WriteLine();

            // 6. format

            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlogClass;

namespace Module01Week03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome! Please chhose one of the below options:");
            
            options:
            Console.WriteLine("1. Create user");
            Console.WriteLine();
            Console.Write("Please enter your option: ");
            int chosenOption = int.Parse(Console.ReadLine());

            switch(chosenOption){
                case 1:
                    Console.Write("Please enter your First Name: ");
                    string firstName = Console.ReadLine();

                    Console.Write("Please enter your Last Name: ");
                    string lastName = Console.ReadLine();

                    Console.Write("Please enter your E-Mail Address: ");
                    string eMail = Console.ReadLine();

                    Console.Write("Please enter your Birth Date: ");
                    DateTime birthDate = DateTime.Parse(Console.ReadLine());

                    string accountName = firstName + lastName;

                    Person user = new Person(firstName, lastName, eMail, birthDate);
                    Console.WriteLine($"Hello {user.GetName()}! Your account has been created.");
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine();
                    Console.WriteLine("Wrong option. Please choose one of the below options:");
                    goto options;
            }
        }
    }
}

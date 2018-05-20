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
            Console.WriteLine("Welcome! Please choose one of the below options:");
            
            options:
            Console.WriteLine("1. Create user");
            Console.WriteLine("2. Log In");
            Console.WriteLine("5. Exit");
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

                    Console.Write("Please enter your desired account name: ");
                    string accountId = Console.ReadLine();

                    Console.Write("Please enter your desired account password: ");
                    string password = Console.ReadLine();

                    User user = new User(firstName, lastName, eMail, birthDate, accountId, password);
                    Console.WriteLine($"The account {user.GetUserId()} has been created successfuly.");
                    Console.WriteLine();
                    Console.WriteLine("Please choose one of the below options:");

                    goto options;

                case 2:
                    Console.WriteLine();
                    Console.Write("Please provide your account name: ");
                    string providedAccountName = Console.ReadLine();

                    Console.Write("Please ptovide the account password: ");
                    string providedAccountPassword = Console.ReadLine();
                    break;

                case 5:
                    break;

                default:
                    Console.WriteLine();
                    Console.WriteLine("Wrong option. Please choose one of the below options:");
                    goto options;
            }
        }

        public void SetAccountInfo(string providedAccountName, string providedAccountPassword)
        {
            string accountName = providedAccountName;
            string accountPassword = providedAccountPassword;
        }
    }
}

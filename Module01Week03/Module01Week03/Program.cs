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
            while (true)
            {
                Console.WriteLine("1. Create a new Account");
                Console.WriteLine("2. Log in");
                Console.WriteLine("3. Log out");
                Console.WriteLine("4. Post a message");
                Console.WriteLine("5. Admin - display users");
                Console.WriteLine("6. Exit");

                Console.WriteLine();
                Console.Write("Please choose one of the above options: ");
                string userOption = Console.ReadLine();

                switch (userOption)
                {
                    case "1":
                        Application.createUser();
                        break;
                    case "2":
                        
                        break;
                    case "3":
                        break;
                    case "4":
                        break;
                    case "5":
                        Application.returnUserList();
                        break;
                    case "6":
                        return;
                }
            }
        }
    }
}

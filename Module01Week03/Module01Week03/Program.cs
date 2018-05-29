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
                string userOption = Application.DisplayMenu();

                switch (userOption)
                {
                    case "1":
                        Application.createUser();
                        break;
                    case "2":
                        Application.createPost();
                        break;
                    case "3":
                        Application.returnUserList();
                        break;
                    case "4":
                        Application.returnPostList();
                        break;
                    case "5":
                        return;
                }
            }
        }
    }
}

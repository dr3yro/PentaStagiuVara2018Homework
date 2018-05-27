using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlogClass;

/*
    Application
        - User
        - Board

    User:Person
        - UserId
        - Password
        - PostMessage()

       Person
        - EMail
        - FirstName
        - LastName
        - BirthDate
        - CreateAccount()

    Post
        - Message
        - Author
        - DateOfPost

    Board
        - DisplayAllPosts()
        - OrderPostsByDateASC()
*/
namespace BlogClass
{
    public class Application
    {
       static List<object> userList = new List<object>();

        public static void createUser()
        {
            Console.WriteLine();
            Console.Write("Please enter your first name: ");
            string firstName = Console.ReadLine();
            Console.Write("Please enter your last name: ");
            string lastName = Console.ReadLine();
            Console.Write("Please enter your E-Mail address: ");
            string eMail = Console.ReadLine();
            Console.Write("Please enter your birthdate: ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());
            User test = new User(firstName, lastName, eMail, birthDate);
            userList.Add(test);
            Console.WriteLine();
        }

        public static bool returnUserList()
        {
            Console.WriteLine();
            foreach (object user in userList)
            {
                Console.WriteLine(user.ToString());
            }
            Console.WriteLine();
            return true;
        }
    }

    public class Person
    {
        private string FirstName;
        private string LastName;
        private string EMail;
        private DateTime BirthDate;

        public Person(string firstName, string lastName, string eMail, DateTime birthDate)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.EMail = eMail;
            this.BirthDate = birthDate;
        }

    }

    public class User : Person
    {
        private string UserId;
        private string Password;
        private int loggedIn;

        public User(string firstName, string lastName, string eMail, DateTime birthDate) : base(firstName, lastName, eMail, birthDate)
        {
            this.UserId = CreateUserId(firstName, lastName);
            this.Password = RequestPassword();
        }

        private string RequestPassword()
        {
            Console.Write("Please provide your user Password: ");
            string userPassword = Console.ReadLine();
            return userPassword;
        }

        private string CreateUserId(string firstName, string lastname)
        {
            Random randomNumber = new Random();
            string randomizeAccount = randomNumber.Next(1, 500).ToString();
            string userId = firstName.Substring(0, 3) + lastname.Substring(0, 3) + randomizeAccount;
            return userId;
        }

        public override string ToString()
        {
            return $"{this.UserId}";
        }
    }

    public class Post
    {
        private string PostContent;
        private string Author;
        private DateTime DateOfPost;

        public Post(string postContent, string author, DateTime dateOfPost)
        {
            this.PostContent = postContent;
            this.Author = author;
            this.DateOfPost = dateOfPost;
        }
    }
}


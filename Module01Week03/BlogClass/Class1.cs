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
       static List<object> userPosts = new List<object>();

        public static string DisplayMenu()
        {
            Console.WriteLine("1. Create a new Account");
            Console.WriteLine("2. Post a message");
            Console.WriteLine("3. Admin - display users");
            Console.WriteLine("4. Display Posts");
            Console.WriteLine("5. Exit");

            Console.WriteLine();
            Console.Write("Please choose one of the above options: ");
            string userOption = Console.ReadLine();
            return userOption;
        }

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
            User user = new User(firstName, lastName, eMail, birthDate);
            userList.Add(user);
            Console.WriteLine();
        }

        public static void createPost()
        {
            Console.Write("Please enter your post body: ");
            string postBody = Console.ReadLine();

            Application.returnUserList();
            Console.Write("Please enter the number of one of the authors listed above: ");
            int selectedUser = int.Parse(Console.ReadLine());

            Post post = new Post(postBody,userList.ElementAt(selectedUser-1).ToString(),DateTime.Now);
            userPosts.Add(post);
            Console.WriteLine("Post added sucessfully!");
            Console.WriteLine();
        }

        public static bool returnUserList()
        {
            int counter = 1;
            Console.WriteLine();
            foreach (object user in userList)
            {
                 Console.WriteLine(counter + ". " + user.ToString());
                counter += 1;
            }
            Console.WriteLine();
            return true;
        }

        public static bool returnPostList()
        {
            int counter = 1;
            Console.WriteLine();
            foreach (object post in userPosts)
            {
                Console.WriteLine(counter + " - " + post.ToString());
                counter += 1;
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

        public override string ToString()
        {
            return $"{PostContent} - created by {Author} on {DateOfPost}";
        }
    }
}


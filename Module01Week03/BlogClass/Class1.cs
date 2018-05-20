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
        - PostMessage()
        - CreateAccount()

    User:Person

       Person
        - EMail
        - FirstName
        - LastName
        - BirthDate

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
    public class Person
    {
        private string FirstName;
        private string LastName;
        private string EMail;
        private DateTime BrithDate;

        public Person(string firstName, string lastName, string eMail, DateTime birthDate)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.EMail = eMail;
            this.BrithDate = birthDate;
        }
    }

    public class User : Person
    {
        private string UserId;

        public User(string firstName,string lastName,string eMail,DateTime birthDate) : base (firstName, lastName, eMail, birthDate)
        {
            this.UserId = firstName + lastName;
        }

        public string GetUserId()
        {
            return this.UserId;
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

    public class Board
    {
        
    }
}

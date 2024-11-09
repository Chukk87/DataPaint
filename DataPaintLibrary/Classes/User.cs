using System;

namespace DataPaintLibrary.Services.Classes
{
    public class User
    {
        public Guid Id { get; set; }
        public string Username { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public bool IsAdmin { get; set; }

        /// <summary>
        /// Used when creating a new user
        /// </summary>
        /// <param name="username"></param>
        /// <param name="firstName"></param>
        /// <param name="surname"></param>
        /// <param name="email"></param>
        public User(string username, string firstName, string surname, string email)
        {
            Username = username;
            FirstName = firstName;
            Surname = surname;
            Email = email;
        }

        /// <summary>
        /// Used when getting data from the data source
        /// </summary>
        /// <param name="id"></param>
        /// <param name="username"></param>
        /// <param name="firstName"></param>
        /// <param name="surname"></param>
        /// <param name="email"></param>
        public User(Guid id, string username, string firstName, string surname, string email)
        {
            Id = id;
            Username = username;
            FirstName = firstName;
            Surname = surname;
            Email = email;
        }

        //Get the full name
        public string FullName
        {
            get { return $"{FirstName} {Surname}"; }
        }
    }
}
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

        public User(string username, string firstName, string surname, string email)
        {
            Username = username;
            FirstName = firstName;
            Surname = surname;
            Email = email;
        }

        public User(Guid id, string username, string firstName, string surname, string email)
        {
            Id = id;
            Username = username;
            FirstName = firstName;
            Surname = surname;
            Email = email;
        }
    }
}
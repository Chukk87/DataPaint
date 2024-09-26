using System;
using System.ComponentModel.DataAnnotations;

namespace DataPaintLibrary.Classes
{
    public class OwnerGroup
    {
        private int _id;
        private string _name;
        private string _contactEmail;
        private string _phoneNumber;

        public int Id
        {
            get => _id;
            set
            {
                if (value <= 0)
                    throw new ArgumentOutOfRangeException(nameof(value), "Id must be greater than zero.");
                _id = value;
            }
        }

        [Required]
        [StringLength(100, ErrorMessage = "Name cannot exceed 100 characters.")]
        public string Name
        {
            get => _name;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Name cannot be null or empty.", nameof(value));
                _name = value;
            }
        }

        [EmailAddress]
        public string ContactEmail
        {
            get => _contactEmail;
            set => _contactEmail = value;
        }

        [Phone]
        public string PhoneNumber
        {
            get => _phoneNumber;
            set => _phoneNumber = value;
        }

        public OwnerGroup(int id, string name, string contactEmail = null, string phoneNumber = null)
        {
            Id = id;
            Name = name;
            ContactEmail = contactEmail ?? string.Empty; // Default to empty string if null
            PhoneNumber = phoneNumber ?? string.Empty;   // Default to empty string if null
        }

        public override string ToString()
        {
            return $"OwnerGroup [Id={Id}, Name={Name}, ContactEmail={ContactEmail}, PhoneNumber={PhoneNumber}]";
        }

        public override bool Equals(object obj)
        {
            if (obj is OwnerGroup other)
            {
                return Id == other.Id && Name == other.Name;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Name);
        }
    }
}
using System.Collections.Generic;
using System;

namespace ClassLibrary
{
    public class Customer
    {
        private string firstName;
        private string lastName;
        private string email;
        private string address;
        private string city;
        private string state;
        private string country;
        private string password;

        public int CustomerID { get; set; }
        public string FirstName
        {
            get => firstName;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("FirstName cannot be null or empty.");
                }
                firstName = value;
            }
        }
        public string LastName
        {
            get => lastName;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("LastName cannot be null or empty.");
                }
                lastName = value;
            }
        }
        public string Email
        {
            get => email;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Email cannot be null or empty.");
                }
                email = value;
            }
        }
        public long? Phone { get; set; } 
        public string Address
        {
            get => address;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Address cannot be null or empty.");
                }
                address = value;
            }
        }
        public string City
        {
            get => city;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("City cannot be null or empty.");
                }
                city = value;
            }
        }
        public string State
        {
            get => state;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("State cannot be null or empty.");
                }
                state = value;
            }
        }
        public string Country
        {
            get => country;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Country cannot be null or empty.");
                }
                country = value;
            }
        }
        public string Password
        {
            get => password;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Password cannot be null or empty.");
                }
                password = value;
            }
        }

        // Simulated data source
        private static readonly Dictionary<int, Customer> dataSource = new Dictionary<int, Customer>
    {
        { 1, new Customer { CustomerID = 1, FirstName = "John", LastName = "Doe", Email = "john.doe@example.com", Phone = 1234567890, Address = "123 Main St", City = "Anytown", State = "CA", Country = "USA", Password = "password123" } },
        { 2, new Customer { CustomerID = 2, FirstName = "Jane", LastName = "Smith", Email = "jane.smith@example.com", Phone = 2345678901, Address = "456 Elm St", City = "Othertown", State = "TX", Country = "USA", Password = "password456" } }
    };

        public bool Find(int customerID)
        {
            if (dataSource.ContainsKey(customerID))
            {
                var customer = dataSource[customerID];
                CustomerID = customer.CustomerID;
                FirstName = customer.FirstName;
                LastName = customer.LastName;
                Email = customer.Email;
                Phone = customer.Phone;
                Address = customer.Address;
                City = customer.City;
                State = customer.State;
                Country = customer.Country;
                Password = customer.Password;
                return true;
            }
            else
            {
                return false;
            }
        }

        public string Valid(string firstName, string lastName, string email, string address, string city, string state, string country, string password)
        {
            string error = "";

            if (string.IsNullOrWhiteSpace(firstName))
            {
                error += "FirstName cannot be null or empty. ";
            }
            if (string.IsNullOrWhiteSpace(lastName))
            {
                error += "LastName cannot be null or empty. ";
            }
            if (string.IsNullOrWhiteSpace(email))
            {
                error += "Email cannot be null or empty. ";
            }
            if (string.IsNullOrWhiteSpace(address))
            {
                error += "Address cannot be null or empty. ";
            }
            if (string.IsNullOrWhiteSpace(city))
            {
                error += "City cannot be null or empty. ";
            }
            if (string.IsNullOrWhiteSpace(state))
            {
                error += "State cannot be null or empty. ";
            }
            if (string.IsNullOrWhiteSpace(country))
            {
                error += "Country cannot be null or empty. ";
            }
            if (string.IsNullOrWhiteSpace(password))
            {
                error += "Password cannot be null or empty. ";
            }

            return error;
        }
    }
}
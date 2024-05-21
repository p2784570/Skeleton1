using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestingCustomer
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void CustomerClassOK()
        {
            // Create an instance of the class we want to create
            Customer customer = new Customer();
            // Test to see that it exists
            Assert.IsNotNull(customer);
        }

        [TestMethod]
        public void CreateCustomer_ShouldSetProperties()
        {
            var customer = new Customer
            {
                CustomerID = 1,
                FirstName = "John",
                LastName = "Doe",
                Email = "john.doe@example.com",
                Phone = 1234567890,
                Address = "123 Main St",
                City = "Anytown",
                State = "CA",
                Country = "USA",
                Password = "password123"
            };

            Assert.AreEqual(1, customer.CustomerID);
            Assert.AreEqual("John", customer.FirstName);
            Assert.AreEqual("Doe", customer.LastName);
            Assert.AreEqual("john.doe@example.com", customer.Email);
            Assert.AreEqual(1234567890, customer.Phone);
            Assert.AreEqual("123 Main St", customer.Address);
            Assert.AreEqual("Anytown", customer.City);
            Assert.AreEqual("CA", customer.State);
            Assert.AreEqual("USA", customer.Country);
            Assert.AreEqual("password123", customer.Password);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "FirstName cannot be null or empty.")]
        public void FirstName_ShouldThrowException_WhenNull()
        {
            var customer = new Customer
            {
                FirstName = null
            };
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "FirstName cannot be null or empty.")]
        public void FirstName_ShouldThrowException_WhenEmpty()
        {
            var customer = new Customer
            {
                FirstName = ""
            };
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "LastName cannot be null or empty.")]
        public void LastName_ShouldThrowException_WhenNull()
        {
            var customer = new Customer
            {
                LastName = null
            };
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "LastName cannot be null or empty.")]
        public void LastName_ShouldThrowException_WhenEmpty()
        {
            var customer = new Customer
            {
                LastName = ""
            };
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Email cannot be null or empty.")]
        public void Email_ShouldThrowException_WhenNull()
        {
            var customer = new Customer
            {
                Email = null
            };
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Email cannot be null or empty.")]
        public void Email_ShouldThrowException_WhenEmpty()
        {
            var customer = new Customer
            {
                Email = ""
            };
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Address cannot be null or empty.")]
        public void Address_ShouldThrowException_WhenNull()
        {
            var customer = new Customer
            {
                Address = null
            };
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Address cannot be null or empty.")]
        public void Address_ShouldThrowException_WhenEmpty()
        {
            var customer = new Customer
            {
                Address = ""
            };
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "City cannot be null or empty.")]
        public void City_ShouldThrowException_WhenNull()
        {
            var customer = new Customer
            {
                City = null
            };
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "City cannot be null or empty.")]
        public void City_ShouldThrowException_WhenEmpty()
        {
            var customer = new Customer
            {
                City = ""
            };
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "State cannot be null or empty.")]
        public void State_ShouldThrowException_WhenNull()
        {
            var customer = new Customer
            {
                State = null
            };
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "State cannot be null or empty.")]
        public void State_ShouldThrowException_WhenEmpty()
        {
            var customer = new Customer
            {
                State = ""
            };
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Country cannot be null or empty.")]
        public void Country_ShouldThrowException_WhenNull()
        {
            var customer = new Customer
            {
                Country = null
            };
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Country cannot be null or empty.")]
        public void Country_ShouldThrowException_WhenEmpty()
        {
            var customer = new Customer
            {
                Country = ""
            };
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Password cannot be null or empty.")]
        public void Password_ShouldThrowException_WhenNull()
        {
            var customer = new Customer
            {
                Password = null
            };
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Password cannot be null or empty.")]
        public void Password_ShouldThrowException_WhenEmpty()
        {
            var customer = new Customer
            {
                Password = ""
            };
        }

        [TestMethod]
        public void Valid_ShouldReturnEmptyString_WhenAllFieldsAreValid()
        {
            var customer = new Customer();
            string result = customer.Valid("John", "Doe", "john.doe@example.com", "123 Main St", "Anytown", "CA", "USA", "password123");

            Assert.AreEqual(string.Empty, result);
        }

        [TestMethod]
        public void Valid_ShouldReturnErrorMessage_WhenFieldsAreInvalid()
        {
            var customer = new Customer();
            string result = customer.Valid("", "", "", "", "", "", "", "");

            Assert.AreEqual("FirstName cannot be null or empty. LastName cannot be null or empty. Email cannot be null or empty. Address cannot be null or empty. City cannot be null or empty. State cannot be null or empty. Country cannot be null or empty. Password cannot be null or empty. ", result);
        }

        [TestMethod]
        public void Phone_ShouldAllowNullableValue()
        {
            var customer = new Customer
            {
                Phone = null
            };

            Assert.IsNull(customer.Phone);
        }

        [TestMethod]
        public void Phone_ShouldSetValue_WhenValid()
        {
            var customer = new Customer
            {
                Phone = 1234567890
            };

            Assert.AreEqual(1234567890, customer.Phone);
        }

        /****************** FIND METHOD TEST ******************/

        [TestMethod]
        public void FindMethodOK()
        {
            // Create an instance of the class we want to create
            Customer customer = new Customer();
            // Create a Boolean variable to store the results of the validation
            bool found = false;
            // Create some test data to use with the method
            int customerID = 1;
            // Invoke the method
            found = customer.Find(customerID);
            // Test to see if the result is true
            Assert.IsTrue(found);
        }

        [TestMethod]
        public void FindMethodNotFound()
        {
            // Create an instance of the class we want to create
            Customer customer = new Customer();
            // Create a Boolean variable to store the results of the validation
            bool found = false;
            // Create some test data to use with the method
            int customerID = 999; // Assume this ID does not exist
            // Invoke the method
            found = customer.Find(customerID);
            // Test to see if the result is false
            Assert.IsFalse(found);
        }
    }
}
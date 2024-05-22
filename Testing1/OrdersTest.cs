using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestingCustomer
{
    [TestClass]
    public class CustomerOrderTest
    {
        [TestMethod]
        public void OrderClassOK()
        {
            // Create an instance of the class we want to create
            Orders order = new Orders();
            // Test to see that it exists
            Assert.IsNotNull(order);
        }

        [TestMethod]
        public void CreateOrder_ShouldSetProperties()
        {
            var order = new Orders
            {
                OrderID = 1,
                CustomerID = 1,
                OrderTime = DateTime.Now,
                Totalprice = 99.99M,
                Status = "Pending"
            };

            Assert.AreEqual(1, order.OrderID);
            Assert.AreEqual(1, order.CustomerID);
            Assert.AreEqual(99.99M, order.Totalprice);
            Assert.AreEqual("Pending", order.Status);
            Assert.IsNotNull(order.OrderTime); // Check that OrderTime is set
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "CustomerID cannot be zero or negative.")]
        public void CustomerID_ShouldThrowException_WhenZero()
        {
            var order = new Orders
            {
                CustomerID = 0
            };
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "CustomerID cannot be zero or negative.")]
        public void CustomerID_ShouldThrowException_WhenNegative()
        {
            var order = new Orders
            {
                CustomerID = -1
            };
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Totalprice must be a positive value.")]
        public void Totalprice_ShouldThrowException_WhenNegative()
        {
            var order = new Orders
            {
                Totalprice = -1.0M
            };
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Totalprice must be a positive value.")]
        public void Totalprice_ShouldThrowException_WhenZero()
        {
            var order = new Orders
            {
                Totalprice = 0.0M
            };
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Status cannot be null or empty.")]
        public void Status_ShouldThrowException_WhenNull()
        {
            var order = new Orders
            {
                Status = null
            };
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Status cannot be null or empty.")]
        public void Status_ShouldThrowException_WhenEmpty()
        {
            var order = new Orders
            {
                Status = ""
            };
        }

        [TestMethod]
        public void Valid_ShouldReturnEmptyString_WhenAllFieldsAreValid()
        {
            var order = new Orders();
            string result = order.Valid(1, DateTime.Now, 99.99M, "Pending");

            Assert.AreEqual(string.Empty, result);
        }

        [TestMethod]
        public void Valid_ShouldReturnErrorMessage_WhenFieldsAreInvalid()
        {
            var order = new Orders();
            string result = order.Valid(-1, default(DateTime), -99.99M, "");

            Assert.AreEqual("CustomerID cannot be zero or negative. OrderTime cannot be default value. Totalprice must be a positive value. Status cannot be null or empty. ", result);
        }

        /****** FIND METHOD TEST ******/

        [TestMethod]
        public void FindMethodOK()
        {
            // Create an instance of the class we want to create
            Orders order = new Orders();
            // Create a Boolean variable to store the results of the validation
            bool found = false;
            // Create some test data to use with the method
            int orderID = 1;
            // Invoke the method
            found = order.Find(orderID);
            // Test to see if the result is true
            Assert.IsTrue(found);
        }

        [TestMethod]
        public void FindMethodNotFound()
        {
            // Create an instance of the class we want to create
            Orders order = new Orders();
            // Create a Boolean variable to store the results of the validation
            bool found = false;
            // Create some test data to use with the method
            int orderID = 999; // Assume this ID does not exist
            // Invoke the method
            found = order.Find(orderID);
            // Test to see if the result is false
            Assert.IsFalse(found);
        }
    }
}

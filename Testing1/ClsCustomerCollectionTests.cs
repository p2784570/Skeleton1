using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing1
{
    [TestClass]
    public class ClsCustomersCollectionTests
    {
        /******************** Property Tests *********************/
        [TestMethod]
        public void InstanceOK()
        {
            ClsCustomersCollection customers = new ClsCustomersCollection();
            Assert.IsNotNull(customers);
        }

        [TestMethod]
        public void CustomersListOK()
        {
            ClsCustomersCollection customers = new ClsCustomersCollection();
            List<ClsCustomer> testList = new List<ClsCustomer>();
            ClsCustomer testCustomer = new ClsCustomer
            {
                CustomerID = 1,
                FirstName = "Rupasi",
                LastName = "Ghimire",
                Email = "rupasi.ghimire@example.com",
                Phone = 1234567890,
                Address = "123 Main St",
                City = "City",
                State = "State",
                Country = "Country",
                Password = "password123"
            };
            testList.Add(testCustomer);
            customers.CustomersList = testList;
            Assert.AreEqual(customers.CustomersList, testList);
        }

        [TestMethod]
        public void ThisCustomerPropertyOK()
        {
            ClsCustomersCollection customers = new ClsCustomersCollection();
            ClsCustomer testCustomer = new ClsCustomer
            {
                CustomerID = 1,
                FirstName = "Rupasi",
                LastName = "Ghimire",
                Email = "rupasi.ghimire@example.com",
                Phone = 1234567890,
                Address = "123 Main St",
                City = "City",
                State = "State",
                Country = "Country",
                Password = "password123"
            };
            customers.ThisCustomer = testCustomer;
            Assert.AreEqual(customers.ThisCustomer, testCustomer);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            ClsCustomersCollection customers = new ClsCustomersCollection();
            List<ClsCustomer> testList = new List<ClsCustomer>();
            ClsCustomer testCustomer = new ClsCustomer
            {
                CustomerID = 1,
                FirstName = "Rupasi",
                LastName = "Ghimire",
                Email = "rupasi.ghimire@example.com",
                Phone = 1234567890,
                Address = "123 Main St",
                City = "City",
                State = "State",
                Country = "Country",
                Password = "password123"
            };
            testList.Add(testCustomer);
            customers.CustomersList = testList;
            Assert.AreEqual(customers.Count, testList.Count);
        }

        /******************** Add Method Tests *********************/
        [TestMethod]
        public void AddMethodOK()
        {
            ClsCustomersCollection customers = new ClsCustomersCollection();
            ClsCustomer testCustomer = new ClsCustomer
            {
                FirstName = "Rupasi",
                LastName = "Ghimire",
                Email = "rupasi.ghimire@example.com",
                Phone = 1234567890,
                Address = "123 Main St",
                City = "City",
                State = "State",
                Country = "Country",
                Password = "password123"
            };
            customers.ThisCustomer = testCustomer;
            int primaryKey = customers.Add();
            testCustomer.CustomerID = primaryKey;
            customers.ThisCustomer.Find(primaryKey);
            Assert.AreEqual(customers.ThisCustomer, testCustomer);
        }

        /******************** Delete Method Tests *********************/
        [TestMethod]
        public void DeleteMethodOK()
        {
            ClsCustomersCollection customers = new ClsCustomersCollection();
            ClsCustomer testCustomer = new ClsCustomer
            {
                FirstName = "Rupasi",
                LastName = "Ghimire",
                Email = "rupasi.ghimire@example.com",
                Phone = 1234567890,
                Address = "123 Main St",
                City = "City",
                State = "State",
                Country = "Country",
                Password = "password123"
            };
            customers.ThisCustomer = testCustomer;
            int primaryKey = customers.Add();
            testCustomer.CustomerID = primaryKey;
            customers.ThisCustomer.Find(primaryKey);
            customers.Delete();
            bool found = customers.ThisCustomer.Find(primaryKey);
            Assert.IsFalse(found);
        }

        /******************** Update Method Tests *********************/
        [TestMethod]
        public void UpdateMethodOK()
        {
            ClsCustomersCollection customers = new ClsCustomersCollection();
            ClsCustomer testCustomer = new ClsCustomer
            {
                FirstName = "Rupasi",
                LastName = "Ghimire",
                Email = "rupasi.ghimire@example.com",
                Phone = 1234567890,
                Address = "123 Main St",
                City = "City",
                State = "State",
                Country = "Country",
                Password = "password123"
            };
            customers.ThisCustomer = testCustomer;
            int primaryKey = customers.Add();
            testCustomer.CustomerID = primaryKey;
            testCustomer.FirstName = "UpdatedName";
            customers.ThisCustomer = testCustomer;
            customers.Update();
            customers.ThisCustomer.Find(primaryKey);
            Assert.AreEqual(customers.ThisCustomer.FirstName, "UpdatedName");
        }

        /******************** IsEmailRegistered Method Tests *********************/
        [TestMethod]
        public void IsEmailRegisteredMethodOK()
        {
            ClsCustomersCollection customers = new ClsCustomersCollection();
            ClsCustomer testCustomer = new ClsCustomer
            {
                FirstName = "Rupasi",
                LastName = "Ghimire",
                Email = "rupasi.ghimire@example.com",
                Phone = 1234567890,
                Address = "123 Main St",
                City = "City",
                State = "State",
                Country = "Country",
                Password = "password123"
            };
            customers.ThisCustomer = testCustomer;
            customers.Add();
            bool isRegistered = customers.IsEmailRegistered("rupasi.ghimire@example.com");
            Assert.IsTrue(isRegistered);
        }

        /******************** PopulateArray Method Tests *********************/
        [TestMethod]
        public void PopulateArrayMethodOK()
        {
            ClsCustomersCollection customers = new ClsCustomersCollection();
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblCustomer_SelectAll");
            customers.PopulateArray(DB);
            Assert.AreEqual(customers.Count, DB.Count);
        }
    }
}
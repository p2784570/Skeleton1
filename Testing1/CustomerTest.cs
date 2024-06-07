using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestingCustomer
{
    [TestClass]
    public class ClsCustomerTests
    {
        // Valid test data
        private string validFirstName = "Rupasi";
        private string validLastName = "Ghimire";
        private string validEmail = "rupasi.ghimire@example.com";
        private string validPhone = "1234567890";
        private string validAddress = "123 Main St";
        private string validCity = "City";
        private string validState = "State";
        private string validCountry = "Country";
        private string validPassword = "password123";

        /******************** Validation OK Tests *********************/
        [TestMethod]
        public void ValidMethodOK()
        {
            ClsCustomer customer = new ClsCustomer();
            String error = "";
            error = customer.Valid(validFirstName, validLastName, validEmail, validPhone, validAddress, validCity, validState, validCountry, validPassword);
            Assert.AreEqual(error, "");
        }

        /********************** FirstName Validation ************************/
        [TestMethod]
        public void FirstNameMinLessOne()
        {
            ClsCustomer customer = new ClsCustomer();
            String error = "";
            String firstName = "";
            error = customer.Valid(firstName, validLastName, validEmail, validPhone, validAddress, validCity, validState, validCountry, validPassword);
            Assert.AreEqual(error, "The first name may not be blank. ");
        }

        [TestMethod]
        public void FirstNameMin()
        {
            ClsCustomer customer = new ClsCustomer();
            String error = "";
            String firstName = "a";
            error = customer.Valid(firstName, validLastName, validEmail, validPhone, validAddress, validCity, validState, validCountry, validPassword);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void FirstNameMinPlusOne()
        {
            ClsCustomer customer = new ClsCustomer();
            String error = "";
            String firstName = "aa";
            error = customer.Valid(firstName, validLastName, validEmail, validPhone, validAddress, validCity, validState, validCountry, validPassword);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void FirstNameMaxLessOne()
        {
            ClsCustomer customer = new ClsCustomer();
            String error = "";
            String firstName = new string('a', 49);
            error = customer.Valid(firstName, validLastName, validEmail, validPhone, validAddress, validCity, validState, validCountry, validPassword);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void FirstNameMax()
        {
            ClsCustomer customer = new ClsCustomer();
            String error = "";
            String firstName = new string('a', 50);
            error = customer.Valid(firstName, validLastName, validEmail, validPhone, validAddress, validCity, validState, validCountry, validPassword);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void FirstNameMaxPlusOne()
        {
            ClsCustomer customer = new ClsCustomer();
            String error = "";
            String firstName = new string('a', 51);
            error = customer.Valid(firstName, validLastName, validEmail, validPhone, validAddress, validCity, validState, validCountry, validPassword);
            Assert.AreEqual(error, "The first name must be less than 50 characters. ");
        }

        /********************** LastName Validation ************************/
        [TestMethod]
        public void LastNameMinLessOne()
        {
            ClsCustomer customer = new ClsCustomer();
            String error = "";
            String lastName = "";
            error = customer.Valid(validFirstName, lastName, validEmail, validPhone, validAddress, validCity, validState, validCountry, validPassword);
            Assert.AreEqual(error, "The last name may not be blank. ");
        }

        [TestMethod]
        public void LastNameMin()
        {
            ClsCustomer customer = new ClsCustomer();
            String error = "";
            String lastName = "a";
            error = customer.Valid(validFirstName, lastName, validEmail, validPhone, validAddress, validCity, validState, validCountry, validPassword);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void LastNameMinPlusOne()
        {
            ClsCustomer customer = new ClsCustomer();
            String error = "";
            String lastName = "aa";
            error = customer.Valid(validFirstName, lastName, validEmail, validPhone, validAddress, validCity, validState, validCountry, validPassword);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void LastNameMaxLessOne()
        {
            ClsCustomer customer = new ClsCustomer();
            String error = "";
            String lastName = new string('a', 49);
            error = customer.Valid(validFirstName, lastName, validEmail, validPhone, validAddress, validCity, validState, validCountry, validPassword);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void LastNameMax()
        {
            ClsCustomer customer = new ClsCustomer();
            String error = "";
            String lastName = new string('a', 50);
            error = customer.Valid(validFirstName, lastName, validEmail, validPhone, validAddress, validCity, validState, validCountry, validPassword);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void LastNameMaxPlusOne()
        {
            ClsCustomer customer = new ClsCustomer();
            String error = "";
            String lastName = new string('a', 51);
            error = customer.Valid(validFirstName, lastName, validEmail, validPhone, validAddress, validCity, validState, validCountry, validPassword);
            Assert.AreEqual(error, "The last name must be less than 50 characters. ");
        }

        /********************** Email Validation ************************/
    

     

       

        [TestMethod]
        public void EmailMaxPlusOne()
        {
            ClsCustomer customer = new ClsCustomer();
            String error = "";
            String email = new string('a', 51) + "@example.com";
            error = customer.Valid(validFirstName, validLastName, email, validPhone, validAddress, validCity, validState, validCountry, validPassword);
            Assert.AreEqual(error, "The email must be less than 50 characters. ");
        }

        [TestMethod]
        public void EmailInvalidFormat()
        {
            ClsCustomer customer = new ClsCustomer();
            String error = "";
            String email = "invalid-email-format";
            error = customer.Valid(validFirstName, validLastName, email, validPhone, validAddress, validCity, validState, validCountry, validPassword);
            Assert.AreEqual(error, "The email format is not valid. ");
        }

        /********************** Password Validation ************************/
        [TestMethod]
        public void PasswordMinLessOne()
        {
            ClsCustomer customer = new ClsCustomer();
            String error = "";
            String password = "";
            error = customer.Valid(validFirstName, validLastName, validEmail, validPhone, validAddress, validCity, validState, validCountry, password);
            Assert.AreEqual(error, "The password may not be blank. ");
        }

        [TestMethod]
        public void PasswordMin()
        {
            ClsCustomer customer = new ClsCustomer();
            String error = "";
            String password = "a";
            error = customer.Valid(validFirstName, validLastName, validEmail, validPhone, validAddress, validCity, validState, validCountry, password);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void PasswordMinPlusOne()
        {
            ClsCustomer customer = new ClsCustomer();
            String error = "";
            String password = "aa";
            error = customer.Valid(validFirstName, validLastName, validEmail, validPhone, validAddress, validCity, validState, validCountry, password);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void PasswordMaxLessOne()
        {
            ClsCustomer customer = new ClsCustomer();
            String error = "";
            String password = new string('a', 49);
            error = customer.Valid(validFirstName, validLastName, validEmail, validPhone, validAddress, validCity, validState, validCountry, password);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void PasswordMax()
        {
            ClsCustomer customer = new ClsCustomer();
            String error = "";
            String password = new string('a', 50);
            error = customer.Valid(validFirstName, validLastName, validEmail, validPhone, validAddress, validCity, validState, validCountry, password);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void PasswordMaxPlusOne()
        {
            ClsCustomer customer = new ClsCustomer();
            String error = "";
            String password = new string('a', 51);
            error = customer.Valid(validFirstName, validLastName, validEmail, validPhone, validAddress, validCity, validState, validCountry, password);
            Assert.AreEqual(error, "The password must be less than 50 characters. ");
        }

        /********************** Phone Validation ************************/
        [TestMethod]
        public void PhoneValid()
        {
            ClsCustomer customer = new ClsCustomer();
            String error = "";
            String phone = "1234567890";
            error = customer.Valid(validFirstName, validLastName, validEmail, phone, validAddress, validCity, validState, validCountry, validPassword);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void PhoneNull()
        {
            ClsCustomer customer = new ClsCustomer();
            String error = "";
            String phone = "";
            error = customer.Valid(validFirstName, validLastName, validEmail, phone, validAddress, validCity, validState, validCountry, validPassword);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void PhoneNonNumeric()
        {
            ClsCustomer customer = new ClsCustomer();
            String error = "";
            String phone = "ABC123";
            error = customer.Valid(validFirstName, validLastName, validEmail, phone, validAddress, validCity, validState, validCountry, validPassword);
            Assert.AreEqual(error, "The phone number must be a valid number. ");
        }

        [TestMethod]
        public void PhoneSpecialCharacters()
        {
            ClsCustomer customer = new ClsCustomer();
            String error = "";
            String phone = "123-456-7890";
            error = customer.Valid(validFirstName, validLastName, validEmail, phone, validAddress, validCity, validState, validCountry, validPassword);
            Assert.AreEqual(error, "The phone number must be a valid number. ");
        }

        [TestMethod]
        public void PhoneExtremeMin()
        {
            ClsCustomer customer = new ClsCustomer();
            String error = "";
            String phone = "-9999999999";
            error = customer.Valid(validFirstName, validLastName, validEmail, phone, validAddress, validCity, validState, validCountry, validPassword);
            Assert.AreEqual(error, "The phone number must be a valid number. ");
        }

        [TestMethod]
        public void PhoneBoundary()
        {
            ClsCustomer customer = new ClsCustomer();
            String error = "";
            String phone = "1";
            error = customer.Valid(validFirstName, validLastName, validEmail, phone, validAddress, validCity, validState, validCountry, validPassword);
            Assert.AreEqual(error, "");
        }

       

        /********************** Find Method Tests ************************/
        [TestMethod]
        public void FindMethodOK()
        {
            ClsCustomer customer = new ClsCustomer();
            Boolean found = false;
            Int32 customerID = 1;
            found = customer.Find(customerID);
            Assert.IsTrue(found);
        }

        [TestMethod]
        public void TestCustomerIDFound()
        {
            ClsCustomer customer = new ClsCustomer();
            Boolean found = false;
            Boolean ok = true;
            Int32 customerID = 1;
            found = customer.Find(customerID);
            if (customer.CustomerID != 1)
            {
                ok = false;
            }
            Assert.IsTrue(ok);
        }


      
      
    }
}
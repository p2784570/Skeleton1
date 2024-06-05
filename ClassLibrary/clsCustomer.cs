using System.Collections.Generic;
using System;
using System.Text.RegularExpressions;

namespace ClassLibrary
{
    public class ClsCustomer
    {
        // Private data members
        private int mCustomerID;
        private string mFirstName;
        private string mLastName;
        private string mEmail;
        private int? mPhone;
        private string mAddress;
        private string mCity;
        private string mState;
        private string mCountry;
        private string mPassword;

        // Public properties
        public int CustomerID
        {
            get { return mCustomerID; }
            set { mCustomerID = value; }
        }

        public string FirstName
        {
            get { return mFirstName; }
            set { mFirstName = value; }
        }

        public string LastName
        {
            get { return mLastName; }
            set { mLastName = value; }
        }

        public string Email
        {
            get { return mEmail; }
            set { mEmail = value; }
        }

        public int? Phone
        {
            get { return mPhone; }
            set { mPhone = value; }
        }

        public string Address
        {
            get { return mAddress; }
            set { mAddress = value; }
        }

        public string City
        {
            get { return mCity; }
            set { mCity = value; }
        }

        public string State
        {
            get { return mState; }
            set { mState = value; }
        }

        public string Country
        {
            get { return mCountry; }
            set { mCountry = value; }
        }

        public string Password
        {
            get { return mPassword; }
            set { mPassword = value; }
        }

        // Find method for customer by CustomerID
        public bool Find(int customerID)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@CustomerID", customerID);
            DB.Execute("sproc_tblCustomer_FindByCustomerID");

            if (DB.Count == 1)
            {
                mCustomerID = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerID"]);
                mFirstName = Convert.ToString(DB.DataTable.Rows[0]["FirstName"]);
                mLastName = Convert.ToString(DB.DataTable.Rows[0]["LastName"]);
                mEmail = Convert.ToString(DB.DataTable.Rows[0]["Email"]);
                mPhone = DB.DataTable.Rows[0]["Phone"] != DBNull.Value ? (int?)Convert.ToInt32(DB.DataTable.Rows[0]["Phone"]) : null;
                mAddress = Convert.ToString(DB.DataTable.Rows[0]["Address"]);
                mCity = Convert.ToString(DB.DataTable.Rows[0]["City"]);
                mState = Convert.ToString(DB.DataTable.Rows[0]["State"]);
                mCountry = Convert.ToString(DB.DataTable.Rows[0]["Country"]);
                mPassword = Convert.ToString(DB.DataTable.Rows[0]["Password"]);
                return true;
            }
            else
            {
                return false;
            }
        }

        // Valid method
        public string Valid(string firstName, string lastName, string email, string phone, string address, string city, string state, string country, string password)
        {
            // Create a string variable to store the error
            string Error = "";

            // Validation rules

            // FirstName cannot be blank
            if (firstName.Length == 0)
            {
                Error += "The first name may not be blank. ";
            }
            // FirstName must be less than 50 characters
            if (firstName.Length > 50)
            {
                Error += "The first name must be less than 50 characters. ";
            }

            // LastName cannot be blank
            if (lastName.Length == 0)
            {
                Error += "The last name may not be blank. ";
            }
            // LastName must be less than 50 characters
            if (lastName.Length > 50)
            {
                Error += "The last name must be less than 50 characters. ";
            }

            // Email cannot be blank
            if (email.Length == 0)
            {
                Error += "The email may not be blank. ";
            }
            // Email must be less than 50 characters
            if (email.Length > 50)
            {
                Error += "The email must be less than 50 characters. ";
            }
            // Email must be in a valid format
            if (!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                Error += "The email format is not valid. ";
            }

            // Phone can be null, but if provided, must be a valid number
            if (!string.IsNullOrEmpty(phone))
            {
                if (!int.TryParse(phone, out int phoneNumber))
                {
                    Error += "The phone number must be a valid number. ";
                }
            }

            // Address cannot be blank
            if (address.Length == 0)
            {
                Error += "The address may not be blank. ";
            }
            // Address must be less than 50 characters
            if (address.Length > 50)
            {
                Error += "The address must be less than 50 characters. ";
            }

            // City cannot be blank
            if (city.Length == 0)
            {
                Error += "The city may not be blank. ";
            }
            // City must be less than 50 characters
            if (city.Length > 50)
            {
                Error += "The city must be less than 50 characters. ";
            }

            // State cannot be blank
            if (state.Length == 0)
            {
                Error += "The state may not be blank. ";
            }
            // State must be less than 50 characters
            if (state.Length > 50)
            {
                Error += "The state must be less than 50 characters. ";
            }

            // Country cannot be blank
            if (country.Length == 0)
            {
                Error += "The country may not be blank. ";
            }
            // Country must be less than 50 characters
            if (country.Length > 50)
            {
                Error += "The country must be less than 50 characters. ";
            }

            // Password cannot be blank
            if (password.Length == 0)
            {
                Error += "The password may not be blank. ";
            }
            // Password must be less than 50 characters
            if (password.Length > 50)
            {
                Error += "The password must be less than 50 characters. ";
            }

            // Return any error messages
            return Error;
        }
    }
}
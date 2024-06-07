using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class ClsCustomersCollection
    {
        // Private data member for the list
        private List<ClsCustomer> mCustomersList = new List<ClsCustomer>();
        // Private data member for ThisCustomer
        private ClsCustomer mThisCustomer = new ClsCustomer();

        // Public property for the CustomersList
        public List<ClsCustomer> CustomersList
        {
            get { return mCustomersList; }
            set { mCustomersList = value; }
        }

        // Public property for Count
        public int Count
        {
            get { return mCustomersList.Count; }
        }

        // Public property for ThisCustomer
        public ClsCustomer ThisCustomer
        {
            get { return mThisCustomer; }
            set { mThisCustomer = value; }
        }

        // Constructor for the class
        public ClsCustomersCollection()
        {
            // Object for the data connection
            clsDataConnection DB = new clsDataConnection();
            // Execute the stored procedure to get all customers
            DB.Execute("sproc_tblCustomer_SelectAll");
            // Populate the list with the data table
            PopulateArray(DB);
        }
       
        // Method to populate the list based on the data table in the parameter DB
        void PopulateArray(clsDataConnection DB)
        {
            // Populate the list based on the table in the database
            int Index = 0;
            int RecordCount = DB.Count;
            mCustomersList = new List<ClsCustomer>();
            while (Index < RecordCount)
            {
                ClsCustomer ACustomer = new ClsCustomer();
                ACustomer.CustomerID = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerID"]);
                ACustomer.FirstName = Convert.ToString(DB.DataTable.Rows[Index]["FirstName"]);
                ACustomer.LastName = Convert.ToString(DB.DataTable.Rows[Index]["LastName"]);
                ACustomer.Email = Convert.ToString(DB.DataTable.Rows[Index]["Email"]);
                ACustomer.Phone = DB.DataTable.Rows[Index]["Phone"] != DBNull.Value ? (int?)Convert.ToInt32(DB.DataTable.Rows[Index]["Phone"]) : null;
                ACustomer.Address = Convert.ToString(DB.DataTable.Rows[Index]["Address"]);
                ACustomer.City = Convert.ToString(DB.DataTable.Rows[Index]["City"]);
                ACustomer.State = Convert.ToString(DB.DataTable.Rows[Index]["State"]);
                ACustomer.Country = Convert.ToString(DB.DataTable.Rows[Index]["Country"]);
                ACustomer.Password = Convert.ToString(DB.DataTable.Rows[Index]["Password"]);
                mCustomersList.Add(ACustomer);
                Index++;
            }
        }

        public bool IsEmailRegistered(string email)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@Email", email);
            DB.Execute("sproc_tblCustomer_FindByEmail");
            if (DB.Count == 1)
            {
                return true;
            }
            return false;
        }
        public ClsCustomer FindById(int customerID)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@CustomerID", customerID);
            DB.Execute("sproc_tblCustomer_FindByCustomerID");

            if (DB.Count == 1)
            {
                ClsCustomer customer = new ClsCustomer();
                customer.CustomerID = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerID"]);
                customer.FirstName = Convert.ToString(DB.DataTable.Rows[0]["FirstName"]);
                customer.LastName = Convert.ToString(DB.DataTable.Rows[0]["LastName"]);
                customer.Email = Convert.ToString(DB.DataTable.Rows[0]["Email"]);
                customer.Phone = DB.DataTable.Rows[0]["Phone"] != DBNull.Value ? (int?)Convert.ToInt32(DB.DataTable.Rows[0]["Phone"]) : null;
                customer.Address = Convert.ToString(DB.DataTable.Rows[0]["Address"]);
                customer.City = Convert.ToString(DB.DataTable.Rows[0]["City"]);
                customer.State = Convert.ToString(DB.DataTable.Rows[0]["State"]);
                customer.Country = Convert.ToString(DB.DataTable.Rows[0]["Country"]);
                customer.Password = Convert.ToString(DB.DataTable.Rows[0]["Password"]);
                return customer;
            }
            else
            {
                return null;
            }
        }
        public int Add()
        {
            // Add a new record to the database based on the values of mThisCustomer
            clsDataConnection DB = new clsDataConnection();
            // Set the parameters for the stored procedure
            DB.AddParameter("@FirstName", mThisCustomer.FirstName);
            DB.AddParameter("@LastName", mThisCustomer.LastName);
            DB.AddParameter("@Email", mThisCustomer.Email);
            DB.AddParameter("@Phone", mThisCustomer.Phone);
            DB.AddParameter("@Address", mThisCustomer.Address);
            DB.AddParameter("@City", mThisCustomer.City);
            DB.AddParameter("@State", mThisCustomer.State);
            DB.AddParameter("@Country", mThisCustomer.Country);
            DB.AddParameter("@Password", mThisCustomer.Password);
            // Execute the query
            DB.Execute("sproc_tblCustomer_Insert");

            // Check if a new row has been added and return the new CustomerID
            if (DB.Count == 1)
            {
                return Convert.ToInt32(DB.DataTable.Rows[0]["CustomerID"]);
            }
            else
            {
                return -1; // Indicate failure
            }
        }
        // Method to retrieve a customer by email
        public ClsCustomer GetByEmail(string email)
        {
            // Optional: Perform any email validation here

            // Search for the customer in the CustomersList by email
            return CustomersList.FirstOrDefault(c => c.Email.Equals(email, StringComparison.OrdinalIgnoreCase));
        }
        public void Delete(int customerID)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@CustomerID", customerID);
            DB.Execute("sproc_tblCustomer_Delete");
        }
        public void Update()
        {
            if (string.IsNullOrEmpty(mThisCustomer.Password))
            {
                throw new ArgumentException("Password cannot be empty");
            }

            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@CustomerID", mThisCustomer.CustomerID);
            DB.AddParameter("@FirstName", mThisCustomer.FirstName);
            DB.AddParameter("@LastName", mThisCustomer.LastName);
            DB.AddParameter("@Email", mThisCustomer.Email);
            DB.AddParameter("@Phone", mThisCustomer.Phone);
            DB.AddParameter("@Address", mThisCustomer.Address);
            DB.AddParameter("@City", mThisCustomer.City);
            DB.AddParameter("@State", mThisCustomer.State);
            DB.AddParameter("@Country", mThisCustomer.Country);
            DB.AddParameter("@Password", mThisCustomer.Password);
            DB.Execute("sproc_tblCustomer_Update");
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        
    }
}
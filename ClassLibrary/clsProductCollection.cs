using System;
using System.Collections.Generic;
using ClassLibrary;

namespace ClassLibrary
{
    public class clsProductCollection
    {
        private List<clsProduct> mProductList;
        private clsProduct mThisProduct;

        public List<clsProduct> ProductList
        {
            get
            {
                //return the private data
                return mProductList;
            }
            set
            {
                //set the private data
                mProductList = value;
            }
        }

        public int Count
        {
            get
            {
                //return the private data
                return mProductList.Count;
            }
            set
            {
                //set the private data
            }
        }
        public clsProduct ThisProduct
        {
            get
            {
                //return the private data
                return mThisProduct;
            }
            set
            {
                //set private data
                mThisProduct = value;
            }
        }

        public clsProductCollection()
        {
            //object for the data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the store procedure
            DB.Execute("sproc_ProductTable_SelectAll");
            //populate the array list with the data table
            PopulateArray(DB);
        }
        public int Add()
        {
            //add a record to database based on the values of mThisProduct
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameter for the store procedure
            DB.AddParameter("@Company", mThisProduct.Company);
            DB.AddParameter("@ModelName", mThisProduct.ModelName);
            DB.AddParameter("@Ram", mThisProduct.Ram);
            DB.AddParameter("@InternalStorage", mThisProduct.InternalStorage);
            DB.AddParameter("@Display", mThisProduct.Display);
            DB.AddParameter("@Camera", mThisProduct.Camera);
            DB.AddParameter("@NetworkType", mThisProduct.NetworkType);
            DB.AddParameter("@SimType", mThisProduct.SimType);
            DB.AddParameter("@Price", mThisProduct.Price);
            DB.AddParameter("@Quantity", mThisProduct.Quantity);

            //execute the query returning the primary key value
            return DB.Execute("sproc_ProductTable_Insert");
        }

        public void Update()
        {
            //update an existing record based on the values of thisproduct
            //connect to database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the new stire procedures
            DB.AddParameter("@ProductId", mThisProduct.ProductId);
            DB.AddParameter("@Company", mThisProduct.Company);
            DB.AddParameter("@ModelName", mThisProduct.ModelName);
            DB.AddParameter("@Ram", mThisProduct.Ram);
            DB.AddParameter("@InternalStorage", mThisProduct.InternalStorage);
            DB.AddParameter("@Display", mThisProduct.Display);
            DB.AddParameter("@Camera", mThisProduct.Camera);
            DB.AddParameter("@NetworkType", mThisProduct.NetworkType);
            DB.AddParameter("@SimType", mThisProduct.SimType);
            DB.AddParameter("@Price", mThisProduct.Price);
            DB.AddParameter("@Quantity", mThisProduct.Quantity);
            //execute store procedures
            DB.Execute("sproc_ProductTable_Update");
        }

        public void Delete()
        {
            //deletes the record pointed to by thisProduct
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@ProductId", mThisProduct.ProductId);
            //execute the stored procedure
            DB.Execute("sproc_ProductTable_Delete");
        }

        public void ReportByModelName(string ModelName)
        {
            //filters the record based on a full or partial modelname
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //send the modelname parameter to the database
            DB.AddParameter("@ModelName", ModelName);
            //execute the store procedure
            DB.Execute("sproc_ProductTable_FilterByModelName");
            //populate the array list with the data table
            PopulateArray(DB);
        }
        public void PopulateArray(clsDataConnection DB)
        {
            //populates the array list based or the data table in the parameter DB
            //variable for the index
            Int32 Index = 0;
            //variable to store the record count
            Int32 RecordCount;
            //get the count of records
            RecordCount = DB.Count;
            //clear the private array list
            mProductList = new List<clsProduct>();
            //while there are record to process
            while (Index < RecordCount)
            {
                //create a blank Product
                clsProduct AProduct = new clsProduct();
                //read in the field for the current record
                AProduct.ProductId = Convert.ToInt32(DB.DataTable.Rows[Index]["ProductId"]);
                AProduct.Company = Convert.ToString(DB.DataTable.Rows[Index]["Company"]);
                AProduct.ModelName = Convert.ToString(DB.DataTable.Rows[Index]["ModelName"]);
                AProduct.Ram = Convert.ToString(DB.DataTable.Rows[Index]["Ram"]);
                AProduct.InternalStorage = Convert.ToString(DB.DataTable.Rows[Index]["InternalStorage"]);
                AProduct.Display = Convert.ToString(DB.DataTable.Rows[Index]["Display"]);
                AProduct.Camera = Convert.ToString(DB.DataTable.Rows[Index]["Camera"]);
                AProduct.NetworkType = Convert.ToString(DB.DataTable.Rows[Index]["NetworkType"]);
                AProduct.SimType = Convert.ToString(DB.DataTable.Rows[Index]["SimType"]);
                AProduct.Price = Convert.ToString(DB.DataTable.Rows[Index]["Price"]);
                AProduct.Quantity = Convert.ToInt32(DB.DataTable.Rows[Index]["Quantity"]);
                //add the record to the data private member
                mProductList.Add(AProduct);
                //point at the next record
                Index++;
            }
        }
    }
}
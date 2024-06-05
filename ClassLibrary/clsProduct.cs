using System;

namespace ClassLibrary
{
    public class clsProduct
    {

        //private data member for the product id property
        private Int32 mProductId;
        //productId public property
        public int ProductId
        {
            get
            {
                //this line of code sends data out of the property
                return mProductId;
            }
            set
            {
                //this line of code allows data into the property
                mProductId = value;
            }
        }
        //private data member for the company property
        private string mCompany;
        //company public property
        public string Company
        {
            get
            {
                //this line of code sends data out of the property
                return mCompany;
            }
            set
            {
                //this line of code allows data into the property
                mCompany = value;
            }
        }
        //private data member for the model name property
        private string mModelName;
        //model name public property
        public string ModelName
        {
            get
            {
                //this line of code sends data out of the property
                return mModelName;
            }
            set
            {
                //this line of code allows data into the property
                mModelName = value;
            }
        }
        //private data member for the ram property
        private string mRam;
        public string Ram
        {
            get
            {
                //this line of code sends data out of the property
                return mRam;
            }
            set
            {
                //this line of code allows data into the property
                mRam = value;
            }
        }
        //private data member for the internal storage property
        private string mInternalStorage;
        public string InternalStorage
        {
            get
            {
                //this line of code sends data out of the property
                return mInternalStorage;
            }
            set
            {
                //this line of code allows data into the property
                mInternalStorage = value;
            }
        }
        //private data member for the display property
        private string mDisplay;
        public string Display
        {
            get
            {
                //this line of code sends data out of the property
                return mDisplay;
            }
            set
            {
                //this line of code allows data into the property
                mDisplay = value;
            }
        }
        //private data member for the camera property
        private string mCamera;
        public string Camera
        {
            get
            {
                //this line of code sends data out of the property
                return mCamera;
            }
            set
            {
                //this line of code allows data into the property
                mCamera = value;
            }
        }
        //private data member for the networktype property
        private string mNetworkType;
        public string NetworkType
        {
            get
            {
                //this line of code sends data out of the property
                return mNetworkType;
            }
            set
            {
                //this line of code allows data into the property
                mNetworkType = value;
            }
        }
        //private data member for the simtype property
        private string mSimType;
        public string SimType
        {
            get
            {
                //this line of code sends data out of the property
                return mSimType;
            }
            set
            {
                //this line of code allows data into the property
                mSimType = value;
            }
        }
        //private data member for the price propert
        private string mPrice;
        public string Price
        {
            get
            {
                //this line of code sends data out of the property
                return mPrice;
            }
            set
            {
                //this line of code allows data into the property
                mPrice = value;
            }
        }
        //private data member for the quantity property
        private int mQuantity;
        public int Quantity
        {
            get
            {
                //this line of code sends data out of the property
                return mQuantity;
            }
            set
            {
                //this line of code allows data into the property
                mQuantity = value;
            }
        }

        public bool Find(int ProductId)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the product id to search for
            DB.AddParameter("@ProductId", ProductId);
            //execute the strore procedure
            DB.Execute("sproc_ProductTable_FilterByProductId");
            //if the record is found (there should be either one or zero)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mProductId = Convert.ToInt32(DB.DataTable.Rows[0]["ProductId"]);
                mCompany = Convert.ToString(DB.DataTable.Rows[0]["Company"]);
                mModelName = Convert.ToString(DB.DataTable.Rows[0]["ModelName"]);
                mRam = Convert.ToString(DB.DataTable.Rows[0]["Ram"]);
                mInternalStorage = Convert.ToString(DB.DataTable.Rows[0]["InternalStorage"]);
                mDisplay = Convert.ToString(DB.DataTable.Rows[0]["Display"]);
                mCamera = Convert.ToString(DB.DataTable.Rows[0]["Camera"]);
                mNetworkType = Convert.ToString(DB.DataTable.Rows[0]["NetworkType"]);
                mSimType = Convert.ToString(DB.DataTable.Rows[0]["SimType"]);
                mPrice = Convert.ToString(DB.DataTable.Rows[0]["Price"]);
                mQuantity = Convert.ToInt32(DB.DataTable.Rows[0]["Quantity"]);
                //return that everything worked ok
                return true;
            }
            //if no record was found
            else
            {
                //return false indicating there is a problem
                return false;
            }
        }

        public string Valid(string company, string modelName, string ram, string internalStorage, string display, string camera, string networkType, string simType, string price)
        {
            //create a string variable to store error
            String Error = "";
            //create a temporary variable to store data values
            //if the company is blank
            if (Company.Length == 0)
            {
                //record the error
                Error = Error + "The company name may not be blank :";
            }
            //if the company is greater than 50 characters
            if (Company.Length > 50)
            {
                //record the error
                Error = Error + "The company name must be less than 50 characters :";
            }
            //is the mmodelname blank
            if (ModelName.Length == 0)
            {
                //record the error
                Error = Error + "The modelname may not be blank :";
            }
            //if the modelname is too long
            if (ModelName.Length > 50)
            {
                Error = Error + "The modelname must be less than 50 character :";
            }
            if (Ram.Length == 0)
            {
                Error = Error + "The ram may not be blank :";
            }
            if (Ram.Length > 50)
            {
                Error = Error + "The ram must be less than 50 character :";
            }
            if (InternalStorage.Length == 0)
            {
                Error = Error + "The interstrorage may not be blank :";
            }
            if (InternalStorage.Length > 50)
            {
                Error = Error + "The internalstorage must be less than 50 character :";
            }
            if (Display.Length == 0)
            {
                Error = Error + "The display may not be blank :";
            }
            if (Display.Length > 50)
            {
                Error = Error + "The display must be less than 50 character :";
            }
            if (Camera.Length == 0)
            {
                Error = Error + "The camera may not be blank :";
            }
            if (Camera.Length > 50)
            {
                Error = Error + "The camera must be less than 50 character :";
            }
            if (NetworkType.Length == 0)
            {
                Error = Error + "The network Type may not be blank :";
            }
            if (NetworkType.Length > 50)
            {
                Error = Error + "The networktype must be less than 50 character :";
            }
            if (SimType.Length == 0)
            {
                Error = Error + "The sim type may not be blank :";
            }
            if (SimType.Length > 50)
            {
                Error = Error + "The sim type must be less than 50 character :";
            }
            if (Price.Length == 0)
            {
                Error = Error + "The price may not be blank :";
            }
            if (Price.Length > 50)
            {
                Error = Error + "The price must be less than 50 character :";
            }
            //return any error messages
            return Error;
        }

        public void Add(clsProduct testItem)
        {
            throw new NotImplementedException();
        }

        public string Valid(string company, string modelName, string ram, string internalStorage, string display, string camera, string networkType, string simType, string price, string quantity)
        {
            throw new NotImplementedException();
        }
    }
}
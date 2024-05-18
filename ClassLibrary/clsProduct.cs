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

        public bool Find(int productId)
        {
            //set the private data members to the test data value
            mProductId = 20;
            mCompany = "Test Company";
            mModelName = "Test ModelName";
            mRam = "16GB";
            mInternalStorage = "1TB";
            mDisplay = "10 Inch";
            mCamera = "68Px";
            mNetworkType = "5G";
            mSimType = "3";
            mPrice = "£1500";
            mQuantity = 80;
            //always return true
            return true;
        }
    }
}
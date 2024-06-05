using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Security.Cryptography;

namespace Testing2
{
    [TestClass]
    public class tstProduct
    {
        //good test data
        //create some test data to pass the method
        string Company = "Samsung";
        string ModelName = "model";
        string Ram = "4 GB";
        string InternalStorage = "64 GB";
        string Display = "8 Inch";
        string Camera = "48 Px";
        string NetworkType = "4G, 5G";
        string SimType = "3";
        string Price = "£450";

        public object AProduct { get; private set; }

        [TestMethod]
        public void InstanceOK()
        {
            //create instane of the class
            clsProduct AProduct = new clsProduct();
            //test its existance
            Assert.IsNotNull(AProduct);
        }
        [TestMethod]
        public void ProductIdPropertyOK()
        {
            //create new instane of the class
            clsProduct AProduct = new clsProduct();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AProduct.ProductId = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AProduct.ProductId, TestData);
        }
        [TestMethod]
        public void CompanyPropertyOK()
        {
            //create new instane of the class
            clsProduct AProduct = new clsProduct();
            //create some test data to assign to the property
            String TestData = "Some Name";
            //assign the data to the property
            AProduct.Company = TestData;
            //test to see the two values are the same
            Assert.AreEqual(AProduct.Company, TestData);
        }
        [TestMethod]
        public void ModelNamePropertyOK()
        {
            //create new instane of the class
            clsProduct AProduct = new clsProduct();
            //create some test data to assign to the property
            String TestData = "A54";
            //assign the data to the property
            AProduct.ModelName = TestData;
            //test to see the two values are the same
            Assert.AreEqual(AProduct.ModelName, TestData);
        }
        [TestMethod]
        public void RamPropertyOk()
        {
            //create new instane of the class
            clsProduct AProduct = new clsProduct();
            //create some test data to assign to the property
            String TestData = "4 GB";
            //assign the data to the property
            AProduct.Ram = TestData;
            //test to see the two values are the same
            Assert.AreEqual(AProduct.Ram, TestData);
        }
        [TestMethod]
        public void InternalStoragePropertyOK()
        {
            //create new instane of the class
            clsProduct AProduct = new clsProduct();
            //create some test data to assign to the property
            String TestData = "64 GB";
            //assign the data to the property
            AProduct.InternalStorage = TestData;
            //test to see the two values are the same
            Assert.AreEqual(AProduct.InternalStorage, TestData);
        }
        [TestMethod]
        public void DisplayPropertyOK()
        {
            //create new instane of the class
            clsProduct AProduct = new clsProduct();
            //create some test data to assign to the property
            String TestData = "8 Inch";
            //assign the data to the property
            AProduct.Display = TestData;
            //test to see the two values are the same
            Assert.AreEqual(AProduct.Display, TestData);
        }
        [TestMethod]
        public void CameraPropertyOK()
        {
            //create new instane of the class
            clsProduct AProduct = new clsProduct();
            //create some test data to assign to the property
            String TestData = "48Px";
            //assign the data to the property
            AProduct.Camera = TestData;
            //test to see the two values are the same
            Assert.AreEqual(AProduct.Camera, TestData);
        }
        [TestMethod]
        public void NetworkTypePropertyOK()
        {
            //create new instane of the class
            clsProduct AProduct = new clsProduct();
            //create some test data to assign to the property
            String TestData = "4G, 5G";
            //assign the data to the property
            AProduct.NetworkType = TestData;
            //test to see the two values are the same
            Assert.AreEqual(AProduct.NetworkType, TestData);
        }
        [TestMethod]
        public void SimTypePropertyOK()
        {
            //create new instane of the class
            clsProduct AProduct = new clsProduct();
            //create some test data to assign to the property
            String TestData = "3";
            //assign the data to the property
            AProduct.SimType = TestData;
            //test to see the two values are the same
            Assert.AreEqual(AProduct.SimType, TestData);
        }
        [TestMethod]
        public void PricePropertyOK()
        {
            //create new instane of the class
            clsProduct AProduct = new clsProduct();
            //create some test data to assign to the property
            String TestData = "£450";
            //assign the data to the property
            AProduct.Price = TestData;
            //test to see the two values are the same
            Assert.AreEqual(AProduct.Price, TestData);
        }
        [TestMethod]
        public void QuantityPropertyOK()
        {
            //create new instane of the class
            clsProduct AProduct = new clsProduct();
            //create some test data to assign to the property
            Int32 TestData = 30;
            //assign the data to the property
            AProduct.Quantity = TestData;
            //test to see the two values are the same
            Assert.AreEqual(AProduct.Quantity, TestData);
        }
        [TestMethod]
        public void FindMethodOK()
        {
            //create an instane of the class we want to create
            clsProduct AProduct = new clsProduct();
            //create a boolean variable to store the result of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 ProductId = 1;
            //invoke the method
            Found = AProduct.Find(ProductId);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void TestProductIdFound()
        {
            //create instane of the class
            clsProduct AProduct = new clsProduct();
            //create boolean variable to store the result of the search
            Boolean Found = false;
            //create boolean variable to record if the data is ok
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ProductId = 1;
            //invoke the method
            Found = AProduct.Find(ProductId);
            //check the Product id property
            if (AProduct.ProductId != 1)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestCompanyFound()
        {
            //create instane of the class
            clsProduct AProduct = new clsProduct();
            //create boolean variable to store the result of the search
            Boolean Found = false;
            //create boolean variable to record if the data is ok
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ProductId = 1;
            //invoke the method
            Found = AProduct.Find(ProductId);
            //check the Company property
            if (AProduct.Company != "Samsung")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestModelNameFound()
        {
            //create instane of the class
            clsProduct AProduct = new clsProduct();
            //create boolean variable to store the result of the search
            Boolean Found = false;
            //create boolean variable to record if the data is ok
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ProductId = 1;
            //invoke the method
            Found = AProduct.Find(ProductId);
            //check the Modelname property
            if (AProduct.ModelName != "A54")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestRamFound()
        {
            //create instane of the class
            clsProduct AProduct = new clsProduct();
            //create boolean variable to store the result of the search
            Boolean Found = false;
            //create boolean variable to record if the data is ok
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ProductId = 1;
            //invoke the method
            Found = AProduct.Find(ProductId);
            //check the ram property
            if (AProduct.Ram != "4 GB")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestInternalStorage()
        {
            //create instane of the class
            clsProduct AProduct = new clsProduct();
            //create boolean variable to store the result of the search
            Boolean Found = false;
            //create boolean variable to record if the data is ok
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ProductId = 1;
            //invoke the method
            Found = AProduct.Find(ProductId);
            //check the Internal storage property
            if (AProduct.InternalStorage != "64 GB")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestDisplayFound()
        {
            //create instane of the class
            clsProduct AProduct = new clsProduct();
            //create boolean variable to store the result of the search
            Boolean Found = false;
            //create boolean variable to record if the data is ok
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ProductId = 1;
            //invoke the method
            Found = AProduct.Find(ProductId);
            //check the Display property
            if (AProduct.Display != "8 Inch")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestCameraFound()
        {
            //create instane of the class
            clsProduct AProduct = new clsProduct();
            //create boolean variable to store the result of the search
            Boolean Found = false;
            //create boolean variable to record if the data is ok
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ProductId = 1;
            //invoke the method
            Found = AProduct.Find(ProductId);
            //check the camera property
            if (AProduct.Camera != "48 Px")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestNetworkTypeFound()
        {
            //create instane of the class
            clsProduct AProduct = new clsProduct();
            //create boolean variable to store the result of the search
            Boolean Found = false;
            //create boolean variable to record if the data is ok
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ProductId = 1;
            //invoke the method
            Found = AProduct.Find(ProductId);
            //check the Network type property
            if (AProduct.NetworkType != "4G, 5G")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestSimTypeFound()
        {
            //create instane of the class
            clsProduct AProduct = new clsProduct();
            //create boolean variable to store the result of the search
            Boolean Found = false;
            //create boolean variable to record if the data is ok
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ProductId = 1;
            //invoke the method
            Found = AProduct.Find(ProductId);
            //check the sim type property
            if (AProduct.SimType != "3")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestPriceFound()
        {
            //create instane of the class
            clsProduct AProduct = new clsProduct();
            //create boolean variable to store the result of the search
            Boolean Found = false;
            //create boolean variable to record if the data is ok
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ProductId = 1;
            //invoke the method
            Found = AProduct.Find(ProductId);
            //check the price property
            if (AProduct.Price != "£450")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestQuantityFound()
        { 
            //create instane of the class
            clsProduct AProduct = new clsProduct();
            //create boolean variable to store the result of the search
            Boolean Found = false;
            //create boolean variable to record if the data is ok
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ProductId = 1;
            //invoke the method
            Found = AProduct.Find(ProductId);
            //check the Quantity property
            if (AProduct.Quantity != 30)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //string variable to store my error message
            String Error = "";
            //invoke the method
            Error = AProduct.Valid(Company, ModelName, Ram, InternalStorage, Display, Camera, NetworkType, SimType, Price);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CompanyMinLessOne()
        {
            //create a instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //string variable to store any error message
            String Error = "";
            //this should fail
            String Company = "";
            //invoke the method
            Error = AProduct.Valid(Company, ModelName, Ram, InternalStorage, Display, Camera, NetworkType, SimType, Price);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CompanyMin()
        {
            //create a instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //string variable to store any error message
            String Error = "";
            //this should pass
            String Company = "a";
            //invoke the method
            Error = AProduct.Valid(Company, ModelName, Ram, InternalStorage, Display, Camera, NetworkType, SimType, Price);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CompanyMinPlusOne()
        {
            //create a instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //string variable to store any error message
            String Error = "";
            //this should pass
            String Company = "aa";
            //invoke the method
            Error = AProduct.Valid(Company, ModelName, Ram, InternalStorage, Display, Camera, NetworkType, SimType, Price);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CompanyMaxLessOne()
        {
            //create a instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //string variable to store any error message
            String Error = "";
            //this should pass
            String Company = "";
            Company = Company.PadRight(49, 'a');
            //invoke the method
            Error = AProduct.Valid(Company, ModelName, Ram, InternalStorage, Display, Camera, NetworkType, SimType, Price);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CompanyMax()
        {
            //create a instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //string variable to store any error message
            String Error = "";
            //this should pass
            String Company = "";
            Company = Company.PadRight(50, 'a');
            //invoke the method
            Error = AProduct.Valid(Company, ModelName, Ram, InternalStorage, Display, Camera, NetworkType, SimType, Price);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CompanyMaxPlusOne()
        {
            //create a instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //string variable to store any error message
            String Error = "";
            //this should fail
            String Company = "";
            Company = Company.PadRight(51, 'a');
            //invoke the method
            Error = AProduct.Valid(Company, ModelName, Ram, InternalStorage, Display, Camera, NetworkType, SimType, Price);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CompanyMid()
        {
            //create a instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //string variable to store any error message
            String Error = "";
            //this should pass
            String Company = "";
            Company = Company.PadRight(25, 'a');
            //invoke the method
            Error = AProduct.Valid(Company, ModelName, Ram, InternalStorage, Display, Camera, NetworkType, SimType, Price);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ModelNameMinLessOne()
        {
            //create a instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //string variable to store any error message
            String Error = "";
            //this should fail
            String ModelName = "";
            //invoke the method
            Error = AProduct.Valid(Company, ModelName, Ram, InternalStorage, Display, Camera, NetworkType, SimType, Price);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void ModelNameMin()
        {
            //create a instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //string variable to store any error message
            String Error = "";
            //this should pass
            String ModelName = "a";
            //invoke the method
            Error = AProduct.Valid(Company, ModelName, Ram, InternalStorage, Display, Camera, NetworkType, SimType, Price);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ModelNameMinPlusOne()
        {
            //create a instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //string variable to store any error message
            String Error = "";
            //this should pass
            String ModelName = "aa";
            //invoke the method
            Error = AProduct.Valid(Company, ModelName, Ram, InternalStorage, Display, Camera, NetworkType, SimType, Price);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ModelNameMaxLessOne()
        {
            //create a instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //string variable to store any error message
            String Error = "";
            //this should pass
            String ModelName = "";
            ModelName = ModelName.PadRight(49, 'a');
            //invoke the method
            Error = AProduct.Valid(Company, ModelName, Ram, InternalStorage, Display, Camera, NetworkType, SimType, Price);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ModelNameMax()
        {
            //create a instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //string variable to store any error message
            String Error = "";
            //this should pass
            String ModelName = "";
            ModelName = ModelName.PadRight(50, 'a');
            //invoke the method
            Error = AProduct.Valid(Company, ModelName, Ram, InternalStorage, Display, Camera, NetworkType, SimType, Price);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ModelNameMaxPlusOne()
        {
            //create a instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //string variable to store any error message
            String Error = "";
            //this should fail
            String ModelName = "";
            ModelName = ModelName.PadRight(51, 'a');
            //invoke the method
            Error = AProduct.Valid(Company, ModelName, Ram, InternalStorage, Display, Camera, NetworkType, SimType, Price);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void ModelNameMid()
        {
            //create a instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //string variable to store any error message
            String Error = "";
            //this should pass
            String ModelName = "";
            ModelName = ModelName.PadRight(25, 'a');
            //invoke the method
            Error = AProduct.Valid(Company, ModelName, Ram, InternalStorage, Display, Camera, NetworkType, SimType, Price);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void RamMinLessOne()
        {
            //create a instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //string variable to store any error message
            String Error = "";
            //this should fail
            String Ram = "";
            //invoke the method
            Error = AProduct.Valid(Company, ModelName, Ram, InternalStorage, Display, Camera, NetworkType, SimType, Price);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void RamMin()
        {
            //create a instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //string variable to store any error message
            String Error = "";
            //this should pass
            String Ram = "a";
            //invoke the method
            Error = AProduct.Valid(Company, ModelName, Ram, InternalStorage, Display, Camera, NetworkType, SimType, Price);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void RamMinPlusOne()
        {
            //create a instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //string variable to store any error message
            String Error = "";
            //this should pass
            String Ram = "aa";
            //invoke the method
            Error = AProduct.Valid(Company, ModelName, Ram, InternalStorage, Display, Camera, NetworkType, SimType, Price);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void RamMaxLessOne()
        {
            //create a instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //string variable to store any error message
            String Error = "";
            //this should pass
            String Ram = "";
            Ram = Ram.PadRight(49, 'a');
            //invoke the method
            Error = AProduct.Valid(Company, ModelName, Ram, InternalStorage, Display, Camera, NetworkType, SimType, Price);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void RamMax()
        {
            //create a instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //string variable to store any error message
            String Error = "";
            //this should pass
            String Ram = "";
            Ram = Ram.PadRight(50, 'a');
            //invoke the method
            Error = AProduct.Valid(Company, ModelName, Ram, InternalStorage, Display, Camera, NetworkType, SimType, Price);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void RamMaxPlusOne()
        {
            //create a instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //string variable to store any error message
            String Error = "";
            //this should fail
            String Ram = "";
            Ram = Ram.PadRight(51, 'a');
            //invoke the method
            Error = AProduct.Valid(Company, ModelName, Ram, InternalStorage, Display, Camera, NetworkType, SimType, Price);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void RamMid()
        {
            //create a instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //string variable to store any error message
            String Error = "";
            //this should pass
            String Ram = "";
            Ram = Ram.PadRight(25, 'a');
            //invoke the method
            Error = AProduct.Valid(Company, ModelName, Ram, InternalStorage, Display, Camera, NetworkType, SimType, Price);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void InternalStorageMinLessOne()
        {
            //create a instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //string variable to store any error message
            String Error = "";
            //this should fail
            String InternalStorage = "";
            //invoke the method
            Error = AProduct.Valid(Company, ModelName, Ram, InternalStorage, Display, Camera, NetworkType, SimType, Price);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void InternalStorageMin()
        {
            //create a instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //string variable to store any error message
            String Error = "";
            //this should pass
            String InternalStorage = "a";
            //invoke the method
            Error = AProduct.Valid(Company, ModelName, Ram, InternalStorage, Display, Camera, NetworkType, SimType, Price);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void InternalStorageMinPlusOne()
        {
            //create a instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //string variable to store any error message
            String Error = "";
            //this should pass
            String InternalStorage = "aa";
            //invoke the method
            Error = AProduct.Valid(Company, ModelName, Ram, InternalStorage, Display, Camera, NetworkType, SimType, Price);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void InternalStorageMaxLessOne()
        {
            //create a instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //string variable to store any error message
            String Error = "";
            //this should pass
            String Company = "";
            Company = Company.PadRight(49, 'a');
            //invoke the method
            Error = AProduct.Valid(Company, ModelName, Ram, InternalStorage, Display, Camera, NetworkType, SimType, Price);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void InternalStorageMax()
        {
            //create a instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //string variable to store any error message
            String Error = "";
            //this should pass
            String InternalStorage = "";
            InternalStorage = InternalStorage.PadRight(50, 'a');
            //invoke the method
            Error = AProduct.Valid(Company, ModelName, Ram, InternalStorage, Display, Camera, NetworkType, SimType, Price);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void InternalStorageMaxPlusOne()
        {
            //create a instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //string variable to store any error message
            String Error = "";
            //this should fail
            String InternalStorage = "";
            InternalStorage = InternalStorage.PadRight(51, 'a');
            //invoke the method
            Error = AProduct.Valid(Company, ModelName, Ram, InternalStorage, Display, Camera, NetworkType, SimType, Price);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void InternalStorageMid()
        {
            //create a instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //string variable to store any error message
            String Error = "";
            //this should pass
            String InternalStorage = "";
            InternalStorage = InternalStorage.PadRight(25, 'a');
            //invoke the method
            Error = AProduct.Valid(Company, ModelName, Ram, InternalStorage, Display, Camera, NetworkType, SimType, Price);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DisplayMinLessOne()
        {
            //create a instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //string variable to store any error message
            String Error = "";
            //this should fail
            String Display = "";
            //invoke the method
            Error = AProduct.Valid(Company, ModelName, Ram, InternalStorage, Display, Camera, NetworkType, SimType, Price);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DisplayMin()
        {
            //create a instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //string variable to store any error message
            String Error = "";
            //this should pass
            String Display = "a";
            //invoke the method
            Error = AProduct.Valid(Company, ModelName, Ram, InternalStorage, Display, Camera, NetworkType, SimType, Price);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DisplayMinPlusOne()
        {
            //create a instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //string variable to store any error message
            String Error = "";
            //this should pass
            String Display = "aa";
            //invoke the method
            Error = AProduct.Valid(Company, ModelName, Ram, InternalStorage, Display, Camera, NetworkType, SimType, Price);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DisplayMaxLessOne()
        {
            //create a instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //string variable to store any error message
            String Error = "";
            //this should pass
            String Display = "";
            Display = Display.PadRight(49, 'a');
            //invoke the method
            Error = AProduct.Valid(Company, ModelName, Ram, InternalStorage, Display, Camera, NetworkType, SimType, Price);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DisplayMax()
        {
            //create a instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //string variable to store any error message
            String Error = "";
            //this should pass
            String Display = "";
            Display = Display.PadRight(50, 'a');
            //invoke the method
            Error = AProduct.Valid(Company, ModelName, Ram, InternalStorage, Display, Camera, NetworkType, SimType, Price);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DisplayMaxPlusOne()
        {
            //create a instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //string variable to store any error message
            String Error = "";
            //this should fail
            String Display = "";
            Display = Display.PadRight(51, 'a');
            //invoke the method
            Error = AProduct.Valid(Company, ModelName, Ram, InternalStorage, Display, Camera, NetworkType, SimType, Price);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DisplayMid()
        {
            //create a instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //string variable to store any error message
            String Error = "";
            //this should pass
            String Display = "";
            Display = Display.PadRight(25, 'a');
            //invoke the method
            Error = AProduct.Valid(Company, ModelName, Ram, InternalStorage, Display, Camera, NetworkType, SimType, Price);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CameraMinLessOne()
        {
            //create a instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //string variable to store any error message
            String Error = "";
            //this should fail
            String Camera = "";
            //invoke the method
            Error = AProduct.Valid(Company, ModelName, Ram, InternalStorage, Display, Camera, NetworkType, SimType, Price);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CameraMin()
        {
            //create a instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //string variable to store any error message
            String Error = "";
            //this should pass
            String Camera = "a";
            //invoke the method
            Error = AProduct.Valid(Company, ModelName, Ram, InternalStorage, Display, Camera, NetworkType, SimType, Price);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CameraMinPlusOne()
        {
            //create a instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //string variable to store any error message
            String Error = "";
            //this should pass
            String Camera = "aa";
            //invoke the method
            Error = AProduct.Valid(Company, ModelName, Ram, InternalStorage, Display, Camera, NetworkType, SimType, Price);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CameraMaxLessOne()
        {
            //create a instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //string variable to store any error message
            String Error = "";
            //this should pass
            String Camera = "";
            Camera = Camera.PadRight(49, 'a');
            //invoke the method
            Error = AProduct.Valid(Company, ModelName, Ram, InternalStorage, Display, Camera, NetworkType, SimType, Price);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CameraMax()
        {
            //create a instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //string variable to store any error message
            String Error = "";
            //this should pass
            String Camera = "";
            Camera = Camera.PadRight(50, 'a');
            //invoke the method
            Error = AProduct.Valid(Company, ModelName, Ram, InternalStorage, Display, Camera, NetworkType, SimType, Price);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CameraMaxPlusOne()
        {
            //create a instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //string variable to store any error message
            String Error = "";
            //this should fail
            String Camera = "";
            Camera = Camera.PadRight(51, 'a');
            //invoke the method
            Error = AProduct.Valid(Company, ModelName, Ram, InternalStorage, Display, Camera, NetworkType, SimType, Price);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CameraMid()
        {
            //create a instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //string variable to store any error message
            String Error = "";
            //this should pass
            String Camera = "";
            Camera = Camera.PadRight(25, 'a');
            //invoke the method
            Error = AProduct.Valid(Company, ModelName, Ram, InternalStorage, Display, Camera, NetworkType, SimType, Price);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void NetworkTypeMinLessOne()
        {
            //create a instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //string variable to store any error message
            String Error = "";
            //this should fail
            String NetworkType = "";
            //invoke the method
            Error = AProduct.Valid(Company, ModelName, Ram, InternalStorage, Display, Camera, NetworkType, SimType, Price);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void NetWorkTypeMin()
        {
            //create a instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //string variable to store any error message
            String Error = "";
            //this should pass
            String NetworkType = "a";
            //invoke the method
            Error = AProduct.Valid(Company, ModelName, Ram, InternalStorage, Display, Camera, NetworkType, SimType, Price);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void NetworkTypeMinPlusOne()
        {
            //create a instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //string variable to store any error message
            String Error = "";
            //this should pass
            String NetworkType = "aa";
            //invoke the method
            Error = AProduct.Valid(Company, ModelName, Ram, InternalStorage, Display, Camera, NetworkType, SimType, Price);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void NetworkTypeMaxLessOne()
        {
            //create a instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //string variable to store any error message
            String Error = "";
            //this should pass
            String NetworkType = "";
            NetworkType = NetworkType.PadRight(49, 'a');
            //invoke the method
            Error = AProduct.Valid(Company, ModelName, Ram, InternalStorage, Display, Camera, NetworkType, SimType, Price);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void NetworkTypeMax()
        {
            //create a instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //string variable to store any error message
            String Error = "";
            //this should pass
            String NetworkType = "";
            NetworkType = NetworkType.PadRight(50, 'a');
            //invoke the method
            Error = AProduct.Valid(Company, ModelName, Ram, InternalStorage, Display, Camera, NetworkType, SimType, Price);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void NetworkTypeMaxPlusOne()
        {
            //create a instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //string variable to store any error message
            String Error = "";
            //this should fail
            String NetworkType = "";
            NetworkType = NetworkType.PadRight(51, 'a');
            //invoke the method
            Error = AProduct.Valid(Company, ModelName, Ram, InternalStorage, Display, Camera, NetworkType, SimType, Price);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void NetworkTypeMid()
        {
            //create a instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //string variable to store any error message
            String Error = "";
            //this should pass
            String NetworkType = "";
            NetworkType = NetworkType.PadRight(25, 'a');
            //invoke the method
            Error = AProduct.Valid(Company, ModelName, Ram, InternalStorage, Display, Camera, NetworkType, SimType, Price);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void SimtypeMinLessOne()
        {
            //create a instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //string variable to store any error message
            String Error = "";
            //this should fail
            String SimType = "";
            //invoke the method
            Error = AProduct.Valid(Company, ModelName, Ram, InternalStorage, Display, Camera, NetworkType, SimType, Price);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void SimTypeMin()
        {
            //create a instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //string variable to store any error message
            String Error = "";
            //this should pass
            String SimType = "a";
            //invoke the method
            Error = AProduct.Valid(Company, ModelName, Ram, InternalStorage, Display, Camera, NetworkType, SimType, Price);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void SimtypeMinPlusOne()
        {
            //create a instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //string variable to store any error message
            String Error = "";
            //this should pass
            String SimType = "aa";
            //invoke the method
            Error = AProduct.Valid(Company, ModelName, Ram, InternalStorage, Display, Camera, NetworkType, SimType, Price);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void SimTypeMaxLessOne()
        {
            //create a instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //string variable to store any error message
            String Error = "";
            //this should pass
            String SimType = "";
            SimType = SimType.PadRight(49, 'a');
            //invoke the method
            Error = AProduct.Valid(Company, ModelName, Ram, InternalStorage, Display, Camera, NetworkType, SimType, Price);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void SimTypeMax()
        {
            //create a instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //string variable to store any error message
            String Error = "";
            //this should pass
            String SimType = "";
            SimType = SimType.PadRight(50, 'a');
            //invoke the method
            Error = AProduct.Valid(Company, ModelName, Ram, InternalStorage, Display, Camera, NetworkType, SimType, Price);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void SimTypeMaxPlusOne()
        {
            //create a instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //string variable to store any error message
            String Error = "";
            //this should fail
            String SimType = "";
            SimType = SimType.PadRight(51, 'a');
            //invoke the method
            Error = AProduct.Valid(Company, ModelName, Ram, InternalStorage, Display, Camera, NetworkType, SimType, Price);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void SimTypeMid()
        {
            //create a instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //string variable to store any error message
            String Error = "";
            //this should pass
            String SimType = "";
            SimType = SimType.PadRight(25, 'a');
            //invoke the method
            Error = AProduct.Valid(Company, ModelName, Ram, InternalStorage, Display, Camera, NetworkType, SimType, Price);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PriceMinLessOne()
        {
            //create a instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //string variable to store any error message
            String Error = "";
            //this should fail
            String Price = "";
            //invoke the method
            Error = AProduct.Valid(Company, ModelName, Ram, InternalStorage, Display, Camera, NetworkType, SimType, Price);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void PriceMin()
        {
            //create a instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //string variable to store any error message
            String Error = "";
            //this should pass
            String Price = "a";
            //invoke the method
            Error = AProduct.Valid(Company, ModelName, Ram, InternalStorage, Display, Camera, NetworkType, SimType, Price);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PriceMinPlusOne()
        {
            //create a instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //string variable to store any error message
            String Error = "";
            //this should pass
            String Price = "aa";
            //invoke the method
            Error = AProduct.Valid(Company, ModelName, Ram, InternalStorage, Display, Camera, NetworkType, SimType, Price);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PriceMaxLessOne()
        {
            //create a instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //string variable to store any error message
            String Error = "";
            //this should pass
            String Price = "";
            Price = Price.PadRight(49, 'a');
            //invoke the method
            Error = AProduct.Valid(Company, ModelName, Ram, InternalStorage, Display, Camera, NetworkType, SimType, Price);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PriceMax()
        {
            //create a instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //string variable to store any error message
            String Error = "";
            //this should pass
            String Price = "";
            Price = Price.PadRight(50, 'a');
            //invoke the method
            Error = AProduct.Valid(Company, ModelName, Ram, InternalStorage, Display, Camera, NetworkType, SimType, Price);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PriceMaxPlusOne()
        {
            //create a instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //string variable to store any error message
            String Error = "";
            //this should fail
            String Price = "";
            Price = Price.PadRight(51, 'a');
            //invoke the method
            Error = AProduct.Valid(Company, ModelName, Ram, InternalStorage, Display, Camera, NetworkType, SimType, Price);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void PriceMid()
        {
            //create a instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //string variable to store any error message
            String Error = "";
            //this should pass
            String Price = "";
            Price = Price.PadRight(25, 'a');
            //invoke the method
            Error = AProduct.Valid(Company, ModelName, Ram, InternalStorage, Display, Camera, NetworkType, SimType, Price);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
    }
}

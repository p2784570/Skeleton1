using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing2
{
    [TestClass]
    public class tstProduct
    {
        [TestMethod]
        public void InstaneOK()
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
    }
}

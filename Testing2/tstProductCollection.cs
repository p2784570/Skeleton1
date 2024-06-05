using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing2
{
    [TestClass]
    public class tstProductCollection
    {
        public object AllProducts { get; private set; }

        [TestMethod]
        public void InstanceOK()
        {
            //create an isntance of the class we want to create
            clsProductCollection AllProducts = new clsProductCollection();
            //test to see that is exists
            Assert.IsNotNull(AllProducts);
        }

        [TestMethod]
        public void ProductList()
        {
            //create an instance of the class we want to create
            clsProductCollection AllProducts = new clsProductCollection();
            //create some test data to assign to the property
            clsProduct TestProduct = new clsProduct();
            //in this case the data needs to be a lists of a object
            List<clsProduct> TestList = new List<clsProduct>();
            //add an item to the list
            //create the item to the test data
            clsProduct TestItem = new clsProduct();
            //set its properties
            TestItem.ProductId = 1;
            TestItem.Company = "Samsung";
            TestItem.ModelName = "A54";
            TestItem.Ram = "4 GB";
            TestItem.InternalStorage = "64 GB";
            TestItem.Display = "8 Inch";
            TestItem.Camera = "48 Px";
            TestItem.NetworkType = "4G, 5G";
            TestItem.SimType = "3";
            TestItem.Price = "£450";
            TestItem.Quantity = 30;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllProducts.ProductList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllProducts.ProductList, TestList);
        }

        [TestMethod]
        public void ThisProductPropertyOK()
        {
            //create an instance of the class we want to create
            clsProductCollection AllProducts = new clsProductCollection();
            //create some test data to assign to the property
            clsProduct TestProduct = new clsProduct();
            //set properties of the test object
            TestProduct.ProductId = 1;
            TestProduct.Company = "Samsung";
            TestProduct.ModelName = "A54";
            TestProduct.Ram = "4 GB";
            TestProduct.InternalStorage = "64 GB";
            TestProduct.Display = "8 Inch";
            TestProduct.Camera = "48 Px";
            TestProduct.NetworkType = "4G, 5G";
            TestProduct.SimType = "3";
            TestProduct.Price = "£450";
            TestProduct.Quantity = 30;
            //assign the data to the property
            AllProducts.ThisProduct = TestProduct;
            //test to see that two values are the same
            Assert.AreEqual(AllProducts.ThisProduct, TestProduct);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsProductCollection AllProducts = new clsProductCollection();
            //create some test data to assign to the property
            clsProduct TestProduct = new clsProduct();
            //in this case the data needs to be a lists of a object
            List<clsProduct> TestList = new List<clsProduct>();
            //add an item to the list
            //create the item to the test data
            clsProduct TestItem = new clsProduct();
            //set its properties
            TestItem.ProductId = 1;
            TestItem.Company = "Samsung";
            TestItem.ModelName = "A54";
            TestItem.Ram = "4 GB";
            TestItem.InternalStorage = "64 GB";
            TestItem.Display = "8 Inch";
            TestItem.Camera = "48 Px";
            TestItem.NetworkType = "4G, 5G";
            TestItem.SimType = "3";
            TestItem.Price = "£450";
            TestItem.Quantity = 30;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllProducts.ProductList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllProducts.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create
            clsProductCollection AllProducts = new clsProductCollection();
            //create the item to test data
            clsProduct TestItem = new clsProduct();
            //variable to store primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.ProductId = 1;
            TestItem.Company = "Samsung";
            TestItem.ModelName = "A54";
            TestItem.Ram = "4 GB";
            TestItem.InternalStorage = "64 GB";
            TestItem.Display = "8 Inch";
            TestItem.Camera = "48 Px";
            TestItem.NetworkType = "4G, 5G";
            TestItem.SimType = "3";
            TestItem.Price = "£450";
            TestItem.Quantity = 30;
            //set thisproduct to test data
            AllProducts.ThisProduct = TestItem;
            //add the record
            PrimaryKey = AllProducts.Add();
            //set the primarykey of the test data
            TestItem.ProductId = PrimaryKey;
            //find the record
            AllProducts.ThisProduct.Find(PrimaryKey);
            //test to see that the two values are same
            Assert.AreEqual(AllProducts.ThisProduct, TestItem);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create
            clsProductCollection AllProducts = new clsProductCollection();
            //create item of the test data
            clsProduct TestItem = new clsProduct();
            //variable to strore primary key
            Int32 PrimaryKey = 0;
            //set its propertirs
            TestItem.Company = "Samsung";
            TestItem.ModelName = "A54";
            TestItem.Ram = "4 GB";
            TestItem.InternalStorage = "64 GB";
            TestItem.Display = "8 Inch";
            TestItem.Camera = "48 Px";
            TestItem.NetworkType = "4G, 5G";
            TestItem.SimType = "3";
            TestItem.Price = "£450";
            TestItem.Quantity = 30;
            //set thisproduct to test data
            AllProducts.ThisProduct = TestItem;
            //add the record
            PrimaryKey =AllProducts.Add();
            ////set primarykey of the test data
            TestItem.ProductId = PrimaryKey;
            //modify test record
            TestItem.Company = "Samsung";
            TestItem.ModelName = "A55";
            TestItem.Ram = "5 GB";
            TestItem.InternalStorage = "64 GB";
            TestItem.Display = "8 Inch";
            TestItem.Camera = "48 Px";
            TestItem.NetworkType = "4G, 5G";
            TestItem.SimType = "2, esim";
            TestItem.Price = "£550";
            TestItem.Quantity = 30;
            //set the record based on the new test data
            AllProducts.ThisProduct = TestItem;
            //update the record
            AllProducts.Update();
            //find the record
            AllProducts.ThisProduct.Find(PrimaryKey);
            //test to see if thisproduct matches the test data
            Assert.AreEqual(AllProducts.ThisProduct, TestItem);
        }
        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create
            clsProductCollection AllProducts = new clsProductCollection();
            //create the item to test data
            clsProduct TestItem = new clsProduct();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.ProductId = 1;
            TestItem.Company = "Samsung";
            TestItem.ModelName = "A54";
            TestItem.Ram = "4 GB";
            TestItem.InternalStorage = "64 GB";
            TestItem.Display = "8 Inch";
            TestItem.Camera = "48 Px";
            TestItem.NetworkType = "4G, 5G";
            TestItem.SimType = "3";
            TestItem.Price = "£450";
            TestItem.Quantity = 30;
            //set thisproduct to test data
            AllProducts.ThisProduct = TestItem ;
            //add the record
            PrimaryKey = AllProducts.Add();
            //set the primary key of the test data
            TestItem.ProductId = PrimaryKey;
            //find the record
            AllProducts.ThisProduct.Find(PrimaryKey) ;
            //delete the record
            AllProducts.Delete();
            //now find the record
            Boolean Found = AllProducts.ThisProduct.Find(PrimaryKey);
            //test to see that the record is not found
            Assert.IsFalse( Found );
        }
        [TestMethod]
        public void ReportByModelNameOK()
        {
            //create an instance of the filtered data
            clsProductCollection FilteredProducts = new clsProductCollection();
            //apply a modelname that doesnot exist
            FilteredProducts.ReportByModelName("xxxxxx");
            //test to see that two values are the same
            Assert.AreEqual(0, FilteredProducts.Count );
        }
        [TestMethod]
        public void ReportByModelNameTestDataFound()
        {
            //create an instance of the filtered data
            clsProductCollection FilteredProducts = new clsProductCollection();
            //variable to store the outcome
            Boolean OK = true;
            //apply a modelname that doesn't exist
            FilteredProducts.ReportByModelName("yyyyyy");
            //check that the correct member of the record are found
            if (FilteredProducts.Count == 2)
            {
                //check to see that first record is 25
                if (FilteredProducts.ProductList[0].ProductId != 25)
                {
                    OK = false;
                }
                //check to see that the first record is 26
                if (FilteredProducts.ProductList[1].ProductId != 26)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            //test to see that there are no record
            Assert.IsTrue( OK );
        }
    }
}

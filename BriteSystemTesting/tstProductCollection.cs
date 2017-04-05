using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProductClassLibrary;
using System.Collections.Generic;

namespace Test_Framework
{
    /// <summary>
    /// Summary description for tstProductCollection
    /// </summary>
    [TestClass]
    public class tstProductCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsProductCollection AllProducts = new clsProductCollection();
            //test to see that it exists
            Assert.IsNotNull(AllProducts);
        }

        [TestMethod]
        public void ProductListOK()
        {
            //create an instance for the class we want to create
            clsProductCollection AllProducts = new clsProductCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsProduct> TestList = new List<clsProduct>();
            //add an item to the list
            //create the item of the test data
            clsProduct TestItem = new clsProduct();
            //set its properties
            TestItem.CategoryID = 2;
            TestItem.NoAvailable = 10;
            TestItem.ProductDetail = "used";
            TestItem.ProductID = 3;
            TestItem.ProductName = "laptop";
            TestItem.ProductPrice = 650.00m;
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
            //setthe properties of the test object
            TestProduct.CategoryID = 2;
            TestProduct.NoAvailable = 10;
            TestProduct.ProductDetail = "used";
            TestProduct.ProductID = 3;
            TestProduct.ProductName = "laptop";
            TestProduct.ProductPrice = 650.00m;
            //assign the data to the property
            AllProducts.ThisProduct = TestProduct;
            //test to see the two values are the same
            Assert.AreEqual(AllProducts.ThisProduct, TestProduct);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsProductCollection AllProducts = new clsProductCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsProduct> TestList = new List<clsProduct>();
            //add new item to list
            //create the item of test data
            clsProduct TestItem = new clsProduct();
            TestItem.CategoryID = 2;
            TestItem.NoAvailable = 10;
            TestItem.ProductDetail = "used";
            TestItem.ProductID = 3;
            TestItem.ProductName = "laptop";
            TestItem.ProductPrice = 650.00m;
            //add the item to the list
            TestList.Add(TestItem);
            //assign the data to the property
            AllProducts.ProductList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllProducts.Count, TestList.Count);
        }

    }


}
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProductClassLibrary;

namespace Test_Framework
{
    [TestClass]
    public class tstProduct
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance for the class we want to create
            clsProduct AProduct = new clsProduct();
            //test to see if it exists
            Assert.IsNotNull(AProduct);
        }

        [TestMethod]
        public void CategoryID()
        {
            //create an instance for the class we want to create
            clsProduct AProduct = new clsProduct();
            //create some test data to assign to the property
            Int32 TestData = 2;
            //assign the data to the property
            AProduct.CategoryID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AProduct.CategoryID, TestData);
        }

        [TestMethod]
        public void ProductID()
        {
            //create an instance for the class we want to create
            clsProduct AProduct = new clsProduct();
            //create some test data to assign to the property
            Int32 TestData = 3;
            //assign the data to the property
            AProduct.ProductID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AProduct.ProductID, TestData);
        }

        [TestMethod]
        public void NumberAvailable()
        {
            //create an instance for the class we want to create
            clsProduct AProduct = new clsProduct();
            //create some test data to assign to the property
            Int32 TestData = 10;
            //assign the data to the property
            AProduct.NoAvailable = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AProduct.NoAvailable, TestData);
        }

        [TestMethod]
        public void ProductName()
        {
            //create an instance for the class we want to create
            clsProduct AProduct = new clsProduct();
            //create some test data to assign to the property
            string TestData = "Laptop";
            //assign the data to the property
            AProduct.ProductName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AProduct.ProductName, TestData);
        }

        [TestMethod]
        public void ProductDetail()
        {
            //create an instance for the class we want to create
            clsProduct AProduct = new clsProduct();
            //create some test data to assign to the property
            string TestData = "used";
            //assign the data to the property
            AProduct.ProductDetail = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AProduct.ProductDetail, TestData);
        }

        [TestMethod]
        public void ProductPrice()
        {
            //create an instance for the class we want to create
            clsProduct AProduct = new clsProduct();
            //create some test data to assign to the property
            decimal TestData = 650.0000m;
            //assign the data to the property
            AProduct.ProductPrice = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AProduct.ProductPrice, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create instance for the class we want to create
            clsProduct AProduct = new clsProduct();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 ProductID = 1;
            //invoke the method
            Found = AProduct.Find(ProductID);
            //test to see that the result is correct
            Assert.IsTrue(Found);
        }

        

        [TestMethod]
        public void TestCategoryIDFound()
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use it with the method
            Int32 ProductID = 3;
            //invoke the method 
            Found = AProduct.Find(ProductID);
            //check the property 
            if (AProduct.CategoryID != 2)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
         }

        [TestMethod]
        public void TestProductIDFound()
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use it with the method
            Int32 ProductID = 3;
            //invoke the method 
            Found = AProduct.Find(ProductID);
            //check the property 
            if (AProduct.ProductID != 3)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestNoAvailableFound()
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use it with the method
            Int32 ProductID = 3;
            //invoke the method 
            Found = AProduct.Find(ProductID);
            //check the property 
            if (AProduct.NoAvailable != 10)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestProductNameFound()
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use it with the method
            Int32 ProductID = 3;
            //invoke the method 
            Found = AProduct.Find(ProductID);
            //check the property 
            if (AProduct.ProductName != "Laptop")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestProductDetailFound()
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use it with the method
            Int32 ProductID = 3;
            //invoke the method 
            Found = AProduct.Find(ProductID);
            //check the property 
            if (AProduct.ProductDetail != "used")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestProductPriceFound()
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use it with the method
            Int32 ProductID = 3;
            //invoke the method 
            Found = AProduct.Find(ProductID);
            //check the property 
            if (AProduct.ProductPrice != 650.0000m)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            //create a instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string ProductID = "3";
            string ProductName = "laptop";
            string ProductDetail = "used";
            string ProductPrice = "650.00";
            string NoAvailable = "10";
            string CategoryID = "2";
            //invoke method
            OK = AProduct.Valid(ProductID, ProductName, ProductDetail, ProductPrice, NoAvailable, CategoryID);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ProductNameMin()
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string ProductID = "3";
            string ProductName = "a";
            string ProductDetail = "used";
            string ProductPrice = "650.00";
            string NoAvailable = "10";
            string CategoryID = "2";
            //invoke method
            OK = AProduct.Valid(ProductID, ProductName, ProductDetail, ProductPrice, NoAvailable, CategoryID);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ProductNameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string ProductID = "3";
            string ProductName = "aa";
            string ProductDetail = "used";
            string ProductPrice = "650.00";
            string NoAvailable = "10";
            string CategoryID = "2";
            //invoke method
            OK = AProduct.Valid(ProductID, ProductName, ProductDetail, ProductPrice, NoAvailable, CategoryID);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ProductNameMinLessOne()
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string ProductID = "3";
            string ProductName = "";
            string ProductDetail = "used";
            string ProductPrice = "650.00";
            string NoAvailable = "10";
            string CategoryID = "2";
            //invoke method
            OK = AProduct.Valid(ProductID, ProductName, ProductDetail, ProductPrice, NoAvailable, CategoryID);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }
        [TestMethod]
        public void ProductNameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string ProductID = "3";
            string ProductName = "";
            ProductName = ProductName.PadRight(24, 'a');
            string ProductDetail = "used";
            string ProductPrice = "650.00";
            string NoAvailable = "10";
            string CategoryID = "2";
            //invoke method
            OK = AProduct.Valid(ProductID, ProductName, ProductDetail, ProductPrice, NoAvailable, CategoryID);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ProductNameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string ProductID = "3";
            string ProductName = "";
            ProductName = ProductName.PadRight(26, 'a');
            string ProductDetail = "used";
            string ProductPrice = "650.00";
            string NoAvailable = "10";
            string CategoryID = "2";
            //invoke method
            OK = AProduct.Valid(ProductID, ProductName, ProductDetail, ProductPrice, NoAvailable, CategoryID);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }
        [TestMethod]
        public void ProductNameMax()
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string ProductID = "3";
            string ProductName = "";
            ProductName = ProductName.PadRight(25, 'a');
            string ProductDetail = "used";
            string ProductPrice = "650.00";
            string NoAvailable = "10";
            string CategoryID = "2";
            //invoke method
            OK = AProduct.Valid(ProductID, ProductName, ProductDetail, ProductPrice, NoAvailable, CategoryID);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ProductNameMid()
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string ProductID = "3";
            string ProductName = "";
            ProductName = ProductName.PadRight(12, 'a');
            string ProductDetail = "used";
            string ProductPrice = "650.00";
            string NoAvailable = "10";
            string CategoryID = "2";
            //invoke method
            OK = AProduct.Valid(ProductID, ProductName, ProductDetail, ProductPrice, NoAvailable, CategoryID);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ProductDetailMin()
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string ProductID = "3";
            string ProductName = "camera";
            string ProductDetail = "a";
            string ProductPrice = "650.00";
            string NoAvailable = "10";
            string CategoryID = "2";
            //invoke method
            OK = AProduct.Valid(ProductID, ProductName, ProductDetail, ProductPrice, NoAvailable, CategoryID);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ProductDetailMinPlusOne()
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string ProductID = "3";
            string ProductName = "camera";
            string ProductDetail = "aa";
            string ProductPrice = "650.00";
            string NoAvailable = "10";
            string CategoryID = "2";
            //invoke method
            OK = AProduct.Valid(ProductID, ProductName, ProductDetail, ProductPrice, NoAvailable, CategoryID);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ProductDetailMinLessOne()
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string ProductID = "3";
            string ProductName = "camera";
            string ProductDetail = "";
            string ProductPrice = "650.00";
            string NoAvailable = "10";
            string CategoryID = "2";
            //invoke method
            OK = AProduct.Valid(ProductID, ProductName, ProductDetail, ProductPrice, NoAvailable, CategoryID);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void ProductDetailMaxLessOne()
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string ProductID = "3";
            string ProductName = "camera";
            string ProductDetail = "";
            ProductDetail = ProductDetail.PadRight(24, 'a');
            string ProductPrice = "650.00";
            string NoAvailable = "10";
            string CategoryID = "2";
            //invoke method
            OK = AProduct.Valid(ProductID, ProductName, ProductDetail, ProductPrice, NoAvailable, CategoryID);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ProductDetailMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string ProductID = "3";
            string ProductName = "camera";
            string ProductDetail = "";
            ProductDetail = ProductDetail.PadRight(26, 'a');
            string ProductPrice = "650.00";
            string NoAvailable = "10";
            string CategoryID = "2";
            //invoke method
            OK = AProduct.Valid(ProductID, ProductName, ProductDetail, ProductPrice, NoAvailable, CategoryID);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }
        [TestMethod]
        public void ProductDetailMax()
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string ProductID = "3";
            string ProductName = "camera";
            string ProductDetail = "";
            ProductDetail = ProductDetail.PadRight(25, 'a');
            string ProductPrice = "650.00";
            string NoAvailable = "10";
            string CategoryID = "2";
            //invoke method
            OK = AProduct.Valid(ProductID, ProductName, ProductDetail, ProductPrice, NoAvailable, CategoryID);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ProductDetailMid()
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string ProductID = "3";
            string ProductName = "camera";
            string ProductDetail = "";
            ProductDetail = ProductDetail.PadRight(12, 'a');
            string ProductPrice = "650.00";
            string NoAvailable = "10";
            string CategoryID = "2";
            //invoke method
            OK = AProduct.Valid(ProductID, ProductName, ProductDetail, ProductPrice, NoAvailable, CategoryID);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ProductPriceMin()
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string ProductID = "3";
            string ProductName = "camera";
            string ProductDetail = "used";
            string ProductPrice = "00.01";
            string NoAvailable = "10";
            string CategoryID = "2";
            //invoke method
            OK = AProduct.Valid(ProductID, ProductName, ProductDetail, ProductPrice, NoAvailable, CategoryID);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ProductPriceMinPlusOne()
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string ProductID = "3";
            string ProductName = "camera";
            string ProductDetail = "used";
            string ProductPrice = "00.02";
            string NoAvailable = "10";
            string CategoryID = "2";
            //invoke method
            OK = AProduct.Valid(ProductID, ProductName, ProductDetail, ProductPrice, NoAvailable, CategoryID);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ProductPriceMinLessOne()
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string ProductID = "3";
            string ProductName = "camera";
            string ProductDetail = "used";
            string ProductPrice = "00.00";
            string NoAvailable = "10";
            string CategoryID = "2";
            //invoke method
            OK = AProduct.Valid(ProductID, ProductName, ProductDetail, ProductPrice, NoAvailable, CategoryID);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void ProductPriceMaxLessOne()
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string ProductID = "3";
            string ProductName = "camera";
            string ProductDetail = "used";
            string ProductPrice = "999.98";
            string NoAvailable = "10";
            string CategoryID = "2";
            //invoke method
            OK = AProduct.Valid(ProductID, ProductName, ProductDetail, ProductPrice, NoAvailable, CategoryID);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ProductPriceMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string ProductID = "3";
            string ProductName = "camera";
            string ProductDetail = "used";
            string ProductPrice = "1000.00";
            string NoAvailable = "10";
            string CategoryID = "2";
            //invoke method
            OK = AProduct.Valid(ProductID, ProductName, ProductDetail, ProductPrice, NoAvailable, CategoryID);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }
        [TestMethod]
        public void ProductPriceMax()
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string ProductID = "3";
            string ProductName = "camera";
            string ProductDetail = "used";
            string ProductPrice = "999.99";
            string NoAvailable = "10";
            string CategoryID = "2";
            //invoke method
            OK = AProduct.Valid(ProductID, ProductName, ProductDetail, ProductPrice, NoAvailable, CategoryID);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ProductPriceMid()
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string ProductID = "3";
            string ProductName = "camera";
            string ProductDetail = "used";
            string ProductPrice = "499.99";
            string NoAvailable = "10";
            string CategoryID = "2";
            //invoke method
            OK = AProduct.Valid(ProductID, ProductName, ProductDetail, ProductPrice, NoAvailable, CategoryID);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ProductCategoryMin()
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string ProductID = "3";
            string ProductName = "a";
            string ProductDetail = "used";
            string ProductPrice = "650.00";
            string NoAvailable = "10";
            string CategoryID = "1";
            //invoke method
            OK = AProduct.Valid(ProductID, ProductName, ProductDetail, ProductPrice, NoAvailable, CategoryID);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ProductCategoryMinPlusOne()
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string ProductID = "3";
            string ProductName = "camera";
            string ProductDetail = "used";
            string ProductPrice = "650.00";
            string NoAvailable = "10";
            string CategoryID = "2";
            //invoke method
            OK = AProduct.Valid(ProductID, ProductName, ProductDetail, ProductPrice, NoAvailable, CategoryID);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ProductCategoryMinLessOne()
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string ProductID = "3";
            string ProductName = "camera";
            string ProductDetail = "used";
            string ProductPrice = "650.00";
            string NoAvailable = "10";
            string CategoryID = "0";
            //invoke method
            OK = AProduct.Valid(ProductID, ProductName, ProductDetail, ProductPrice, NoAvailable, CategoryID);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void ProductCategoryMax()
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string ProductID = "3";
            string ProductName = "camera";
            string ProductDetail = "used";
            string ProductPrice = "650.00";
            string NoAvailable = "10";
            string CategoryID = "1";
            //invoke method
            OK = AProduct.Valid(ProductID, ProductName, ProductDetail, ProductPrice, NoAvailable, CategoryID);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ProductCategoryMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string ProductID = "3";
            string ProductName = "camera";
            string ProductDetail = "used";
            string ProductPrice = "650.00";
            string NoAvailable = "10";
            string CategoryID = "26";
            //invoke method
            OK = AProduct.Valid(ProductID, ProductName, ProductDetail, ProductPrice, NoAvailable, CategoryID);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ProductCategoryMaxLessOne()
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string ProductID = "3";
            string ProductName = "camera";
            string ProductDetail = "used";
            string ProductPrice = "650.00";
            string NoAvailable = "10";
            string CategoryID = "24";
            //invoke method
            OK = AProduct.Valid(ProductID, ProductName, ProductDetail, ProductPrice, NoAvailable, CategoryID);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ProductCategoryMid()
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string ProductID = "3";
            string ProductName = "camera";
            string ProductDetail = "used";
            string ProductPrice = "650.00";
            string NoAvailable = "10";
            string CategoryID = "12";
            //invoke method
            OK = AProduct.Valid(ProductID, ProductName, ProductDetail, ProductPrice, NoAvailable, CategoryID);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void NoAvailableMin()
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string ProductID = "3";
            string ProductName = "camera";
            string ProductDetail = "used";
            string ProductPrice = "650.00";
            string NoAvailable = "0";
            string CategoryID = "2";
            //invoke method
            OK = AProduct.Valid(ProductID, ProductName, ProductDetail, ProductPrice, NoAvailable, CategoryID);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void NoAvailableMinPlusOne()
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string ProductID = "3";
            string ProductName = "camera";
            string ProductDetail = "used";
            string ProductPrice = "650.00";
            string NoAvailable = "1";
            string CategoryID = "2";
            //invoke method
            OK = AProduct.Valid(ProductID, ProductName, ProductDetail, ProductPrice, NoAvailable, CategoryID);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void NoAvailableMinLessOne()
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string ProductID = "3";
            string ProductName = "camera";
            string ProductDetail = "used";
            string ProductPrice = "650.00";
            string NoAvailable = "";
            string CategoryID = "2";
            //invoke method
            OK = AProduct.Valid(ProductID, ProductName, ProductDetail, ProductPrice, NoAvailable, CategoryID);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void NoAvailableMaxLessOne()
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string ProductID = "3";
            string ProductName = "camera";
            string ProductDetail = "used";
            string ProductPrice = "650.00";
            string NoAvailable = "998";
            string CategoryID = "2";
            //invoke method
            OK = AProduct.Valid(ProductID, ProductName, ProductDetail, ProductPrice, NoAvailable, CategoryID);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void NoAvailableMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string ProductID = "3";
            string ProductName = "camera";
            string ProductDetail = "used";
            string ProductPrice = "650.00";
            string NoAvailable = "1000";
            string CategoryID = "2";
            //invoke method
            OK = AProduct.Valid(ProductID, ProductName, ProductDetail, ProductPrice, NoAvailable, CategoryID);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }
        [TestMethod]
        public void NoAvailableMax()
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string ProductID = "3";
            string ProductName = "camera";
            string ProductDetail = "used";
            string ProductPrice = "650.00";
            string NoAvailable = "999";
            string CategoryID = "2";
            //invoke method
            OK = AProduct.Valid(ProductID, ProductName, ProductDetail, ProductPrice, NoAvailable, CategoryID);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void NoAvailableMid()
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass the method
            string ProductID = "3";
            string ProductName = "camera";
            string ProductDetail = "used";
            string ProductPrice = "650.00";
            string NoAvailable = "499";
            string CategoryID = "2";
            //invoke method
            OK = AProduct.Valid(ProductID, ProductName, ProductDetail, ProductPrice, NoAvailable, CategoryID);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }



    }
}
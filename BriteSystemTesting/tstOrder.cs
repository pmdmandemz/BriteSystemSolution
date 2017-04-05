using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;

namespace TestFramwork
{
    [TestClass]
    public class tstOrder
    {

        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsOrder TestOrder = new clsOrder();
            //test to see that it exists
            Assert.IsNotNull(TestOrder);
        }

        [TestMethod]
        public void ActiveOrderOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the proerty
            AnOrder.Active = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.Active, TestData);
        }

        [TestMethod]
        public void DateAddedPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AnOrder.DateAdded = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.DateAdded, TestData);

        }

        [TestMethod]
        public void OrderOK()
        {
            //create an instance of the class we want to create
            clsOrder TestOrder = new clsOrder();
            //create some test data to assign to the property
            string TestData = "Iphone";
            //assign the data to the property
            TestOrder.Order = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(TestOrder.Order, TestData);

        }
        [TestMethod]
        public void OrderIDOK()
        {
            //create an instance of the class we want to create
            clsOrder TestOrder = new clsOrder();
            //create some test data to assign to the property
            Int32 TestData;
            TestData = 123;
            //assign the data to the property
            TestOrder.OrderIDOK = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(TestData, TestOrder.OrderIDOK);

        }
        [TestMethod]
        public void CustomerIDOK()
        {
            //create an instance of the class we want to create
            clsOrder TestOrder = new clsOrder();
            //create some test data to assign to the property
            string TestData = "123b";
            //assign the data to the property
            TestOrder.CustomerIDOK = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(TestOrder.CustomerIDOK, TestData);

        }
        [TestMethod]
        public void OrderTotalPriceOK()
        {
            //create an instance of the class we want to create
            clsOrder TestOrder = new clsOrder();
            //create some test data to assign to the property
            string TestData = "£30";
            //assign the data to the property
            TestOrder.OrderTotalPriceOK = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(TestOrder.OrderTotalPriceOK, TestData);

        }
        [TestMethod]
        public void SearchProductOK()
        {
            //create an instance of the class we want to create
            clsOrder TestOrder = new clsOrder();
            //create some test data to assign to the property
            string TestData = "Samsung";
            //assign the data to the property
            TestOrder.SearchProduct = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(TestOrder.SearchProduct, TestData);

        }

        [TestMethod]
        public void CardNameOK()
        {
            //create an instance of the class we want to create
            clsOrder TestOrder = new clsOrder();
            //create some test data to assign to the property
            string TestData = "Mr D Anthony";
            //assign the data to the property
            TestOrder.CardName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(TestOrder.CardName, TestData);

        }

        [TestMethod]
        public void CardNumberOK()
        {
            //create an instance of the class we want to create
            clsOrder TestOrder = new clsOrder();
            //create some test data to assign to the property
            string TestData = "5415546512344562";
            //assign the data to the property
            TestOrder.CardNumber = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(TestOrder.CardNumber, TestData);

        }
        [TestMethod]
        public void SecurityCodeOK()
        {
            //create an instance of the class we want to create
            clsOrder TestOrder = new clsOrder();
            //create some test data to assign to the property
            string TestData = "299";
            //assign the data to the property
            TestOrder.SecurityCode = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(TestOrder.SecurityCode, TestData);

        }

        [TestMethod]
        public void ExpirationDateOK()
        {
            //create an instance of the class we want to create
            clsOrder TestOrder = new clsOrder();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            TestOrder.ExpirationDate = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(TestOrder.ExpirationDate, TestData);

        }
        [TestMethod]
        public void AddressOK()
        {
            //create an instance of the class we want to create
            clsOrder TestOrder = new clsOrder();
            //create some test data to assign to the property
            string TestData = "123 Willow Street";
            //assign the data to the property
            TestOrder.Address = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(TestOrder.Address, TestData);

        }
        [TestMethod]
        public void CityOK()
        {
            //create an instance of the class we want to create
            clsOrder TestOrder = new clsOrder();
            //create some test data to assign to the property
            string TestData = "Leicester";
            //assign the data to the property
            TestOrder.City = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(TestOrder.City, TestData);

        }
        [TestMethod]
        public void PostCodeOK()
        {
            //create an instance of the class we want to create
            clsOrder TestOrder = new clsOrder();
            //create some test data to assign to the property
            string TestData = "LE5 0FH";
            //assign the data to the property
            TestOrder.PostCode = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(TestOrder.PostCode, TestData);

        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsOrder TestOrder = new clsOrder();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 CustomerID = 5;
            //invoke the method 
            Found = TestOrder.find(CustomerID);
            //test to see that the result is correct
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestCustomerIDFound()
        {
            //create an instance of the class we want to create
            clsOrder TestOrder = new clsOrder();
            //boolean variable to store the result of the search 
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 5;
            //invoke the method 
            Found = TestOrder.find(CustomerID);
            //check the customer ID
            if (TestOrder.CustomerID != 5)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void TestOrderIDFound()
        {
            //create an instance of the class we want to create
            clsOrder TestOrder = new clsOrder();
            //boolean variable to store the result of the search 
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 5;
            //invoke the method 
            Found = TestOrder.find(CustomerID);
            //check the customer ID
            if (TestOrder.OrderID != "Iphone7")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDateAddedFound()
        {
            //create an instance of the class we want to create
            clsOrder TestOrder = new clsOrder();
            //boolean variable to store the result of the search 
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 5;
            //invoke the method 
            Found = TestOrder.find(CustomerID);
            //check the property
            if (TestOrder.DateAdded != Convert.ToDateTime("15/03/2017"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestOrderTotalPriceFound()
        {
            //create an instance of the class we want to create
            clsOrder TestOrder = new clsOrder();
            //boolean variable to store the result of the search 
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 5;
            //invoke the method 
            Found = TestOrder.find(CustomerID);
            //check the property
            if (TestOrder.OrderTotalPrice != "89")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void TestActiveFound()
        {
            //create an instance of the class we want to create
            clsOrder TestOrder = new clsOrder();
            //boolean variable to store the result of the search 
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 5;
            //invoke the method 
            Found = TestOrder.find(CustomerID);
            //check the property
            if (TestOrder.Active != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestSearchProductFound()
        {
            //create an instance of the class we want to create
            clsOrder TestOrder = new clsOrder();
            //boolean variable to store the result of the search 
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 5;
            //invoke the method 
            Found = TestOrder.find(CustomerID);
            //check the property
            if (TestOrder.SearchProduct != "Iphone6s")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestCardNameFound()
        {
            //create an instance of the class we want to create
            clsOrder TestOrder = new clsOrder();
            //boolean variable to store the result of the search 
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 5;
            //invoke the method 
            Found = TestOrder.find(CustomerID);
            //check the property
            if (TestOrder.CardName != "MR D CHRIS")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void TestCardNumberFound()
        {
            //create an instance of the class we want to create
            clsOrder TestOrder = new clsOrder();
            //boolean variable to store the result of the search 
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 5;
            //invoke the method 
            Found = TestOrder.find(CustomerID);
            //check the property
            if (TestOrder.CardNumber != "1234567891234567")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestSecurityCodeFound()
        {
            //create an instance of the class we want to create
            clsOrder TestOrder = new clsOrder();
            //boolean variable to store the result of the search 
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 5;
            //invoke the method 
            Found = TestOrder.find(CustomerID);
            //check the property
            if (TestOrder.SecurityCode != "619")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void TestExpirationDateFound()
        {
            //create an instance of the class we want to create
            clsOrder TestOrder = new clsOrder();
            //boolean variable to store the result of the search 
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 5;
            //invoke the method 
            Found = TestOrder.find(CustomerID);
            //check the property
            if (TestOrder.ExpirationDate != Convert.ToDateTime("01/01/2019"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestAddressFound()
        {
            //create an instance of the class we want to create
            clsOrder TestOrder = new clsOrder();
            //boolean variable to store the result of the search 
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 5;
            //invoke the method 
            Found = TestOrder.find(CustomerID);
            //check the property
            if (TestOrder.Address != "135 Willow Street")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestCityFound()
        {
            //create an instance of the class we want to create
            clsOrder TestOrder = new clsOrder();
            //boolean variable to store the result of the search 
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 5;
            //invoke the method 
            Found = TestOrder.find(CustomerID);
            //check the property
            if (TestOrder.City != "Leicester")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void TestPostCodeFound()
        {
            //create an instance of the class we want to create
            clsOrder TestOrder = new clsOrder();
            //boolean variable to store the result of the search 
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 5;
            //invoke the method 
            Found = TestOrder.find(CustomerID);
            //check the property
            if (TestOrder.PostCode != "LE5 0FH")
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
            clsOrder TestOrder = new clsOrder();
            //boolean variable to store the result of the validation 
            Boolean OK = false;
            //create some test data to pass to the method
            string CustomerID = "5";
            string OrderID = "Iphone7";
            string DateAdded = DateTime.Now.Date.ToString();
            string OrderTotalPrice = "89";
            string SearchProduct = "Iphone6s";
            string CardName = "MR D CHRIS";
            string CardNumber = "1234567891234567";
            string SecurityCode = "619";
            string ExpirationDate = "01/01/2019";
            string Address = "135 Willow Street";
            string City = "Leicester";
            string PostCode = "LE5 0FH";
            //invoke the method
            OK = TestOrder.Valid(CustomerID, OrderID, DateAdded, OrderTotalPrice, SearchProduct, CardName, CardNumber, SecurityCode, ExpirationDate, Address, City, PostCode);
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void CustomerIDMinlessOne()
        {
            //create an instance of the class we want to create
            clsOrder TestOrder = new clsOrder();
            //boolean variable to store the result of the validation 
            Boolean OK = false;
            //create some test data to pass to the method
            string CustomerID = "";
            string OrderID = "Iphone7";
            string DateAdded = DateTime.Now.Date.ToString();
            string OrderTotalPrice = "89";
            string SearchProduct = "Iphone6s";
            string CardName = "MR D CHRIS";
            string CardNumber = "1234567891234567";
            string SecurityCode = "619";
            string ExpirationDate = "01/01/2019";
            string Address = "135 Willow Street";
            string City = "Leicester";
            string PostCode = "LE5 0FH";
            //invoke the method
            OK = TestOrder.Valid(CustomerID, OrderID, DateAdded, OrderTotalPrice, SearchProduct, CardName, CardNumber, SecurityCode, ExpirationDate, Address, City, PostCode);
            //test to see that the result is correct
            Assert.IsFalse(OK);

        }
        [TestMethod]
        public void CustomerIDMin()
        {
            //create an instance of the class we want to create
            clsOrder TestOrder = new clsOrder();
            //boolean variable to store the result of the validation 
            Boolean OK = false;
            //create some test data to pass to the method
            string CustomerID = "a";
            string OrderID = "Iphone7";
            string DateAdded = DateTime.Now.Date.ToString();
            string OrderTotalPrice = "89";
            string SearchProduct = "Iphone6s";
            string CardName = "MR D CHRIS";
            string CardNumber = "1234567891234567";
            string SecurityCode = "619";
            string ExpirationDate = "01/01/2019";
            string Address = "135 Willow Street";
            string City = "Leicester";
            string PostCode = "LE5 0FH";
            //invoke the method
            OK = TestOrder.Valid(CustomerID, OrderID, DateAdded, OrderTotalPrice, SearchProduct, CardName, CardNumber, SecurityCode, ExpirationDate, Address, City, PostCode);
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void CustomerIDMinPLusOne()
        {
            //create an instance of the class we want to create
            clsOrder TestOrder = new clsOrder();
            //boolean variable to store the result of the validation 
            Boolean OK = false;
            //create some test data to pass to the method
            string CustomerID = "aa";
            string OrderID = "Iphone7";
            string DateAdded = DateTime.Now.Date.ToString();
            string OrderTotalPrice = "89";
            string SearchProduct = "Iphone6s";
            string CardName = "MR D CHRIS";
            string CardNumber = "1234567891234567";
            string SecurityCode = "619";
            string ExpirationDate = "01/01/2019";
            string Address = "135 Willow Street";
            string City = "Leicester";
            string PostCode = "LE5 0FH";
            //invoke the method
            OK = TestOrder.Valid(CustomerID, OrderID, DateAdded, OrderTotalPrice, SearchProduct, CardName, CardNumber, SecurityCode, ExpirationDate, Address, City, PostCode);
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void CustomerIDMaxLessOne()
        {
            //create an instance of the class we want to create
            clsOrder TestOrder = new clsOrder();
            //boolean variable to store the result of the validation 
            Boolean OK = false;
            //create some test data to pass to the method
            string CustomerID = "aaaa";
            string OrderID = "Iphone7";
            string DateAdded = DateTime.Now.Date.ToString();
            string OrderTotalPrice = "89";
            string SearchProduct = "Iphone6s";
            string CardName = "MR D CHRIS";
            string CardNumber = "1234567891234567";
            string SecurityCode = "619";
            string ExpirationDate = "01/01/2019";
            string Address = "135 Willow Street";
            string City = "Leicester";
            string PostCode = "LE5 0FH";
            //invoke the method
            OK = TestOrder.Valid(CustomerID, OrderID, DateAdded, OrderTotalPrice, SearchProduct, CardName, CardNumber, SecurityCode, ExpirationDate, Address, City, PostCode);
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void CustomerIDMax()
        {
            //create an instance of the class we want to create
            clsOrder TestOrder = new clsOrder();
            //boolean variable to store the result of the validation 
            Boolean OK = false;
            //create some test data to pass to the method
            string CustomerID = "aaaaa";
            string OrderID = "Iphone7";
            string DateAdded = DateTime.Now.Date.ToString();
            string OrderTotalPrice = "89";
            string SearchProduct = "Iphone6s";
            string CardName = "MR D CHRIS";
            string CardNumber = "1234567891234567";
            string SecurityCode = "619";
            string ExpirationDate = "01/01/2019";
            string Address = "135 Willow Street";
            string City = "Leicester";
            string PostCode = "LE5 0FH";
            //invoke the method
            OK = TestOrder.Valid(CustomerID, OrderID, DateAdded, OrderTotalPrice, SearchProduct, CardName, CardNumber, SecurityCode, ExpirationDate, Address, City, PostCode);
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void CustomerIDMid()
        {
            //create an instance of the class we want to create
            clsOrder TestOrder = new clsOrder();
            //boolean variable to store the result of the validation 
            Boolean OK = false;
            //create some test data to pass to the method
            string CustomerID = "aaa";
            string OrderID = "Iphone7";
            string DateAdded = DateTime.Now.Date.ToString();
            string OrderTotalPrice = "89";
            string SearchProduct = "Iphone6s";
            string CardName = "MR D CHRIS";
            string CardNumber = "1234567891234567";
            string SecurityCode = "619";
            string ExpirationDate = "01/01/2019";
            string Address = "135 Willow Street";
            string City = "Leicester";
            string PostCode = "LE5 0FH";
            //invoke the method
            OK = TestOrder.Valid(CustomerID, OrderID, DateAdded, OrderTotalPrice, SearchProduct, CardName, CardNumber, SecurityCode, ExpirationDate, Address, City, PostCode);
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void CustomerIDMaxPLusOne()
        {
            //create an instance of the class we want to create
            clsOrder TestOrder = new clsOrder();
            //boolean variable to store the result of the validation 
            Boolean OK = false;
            //create some test data to pass to the method
            string CustomerID = "aaaaaaa";
            string OrderID = "Iphone7";
            string DateAdded = DateTime.Now.Date.ToString();
            string OrderTotalPrice = "89";
            string SearchProduct = "Iphone6s";
            string CardName = "MR D CHRIS";
            string CardNumber = "1234567891234567";
            string SecurityCode = "619";
            string ExpirationDate = "01/01/2019";
            string Address = "135 Willow Street";
            string City = "Leicester";
            string PostCode = "LE5 0FH";
            //invoke the method
            OK = TestOrder.Valid(CustomerID, OrderID, DateAdded, OrderTotalPrice, SearchProduct, CardName, CardNumber, SecurityCode, ExpirationDate, Address, City, PostCode);
            //test to see that the result is correct
            Assert.IsFalse(OK);

        }
        [TestMethod]
        public void CustomerIDExtremeMax()
        {
            //create an instance of the class we want to create
            clsOrder TestOrder = new clsOrder();
            //boolean variable to store the result of the validation 
            Boolean OK = false;
            //create some test data to pass to the method
            string CustomerID = "";
            CustomerID = CustomerID.PadRight(500, 'a');
            string OrderID = "Iphone7";
            string DateAdded = DateTime.Now.Date.ToString();
            string OrderTotalPrice = "89";
            string SearchProduct = "Iphone6s";
            string CardName = "MR D CHRIS";
            string CardNumber = "1234567891234567";
            string SecurityCode = "619";
            string ExpirationDate = "01/01/2019";
            string Address = "135 Willow Street";
            string City = "Leicester";
            string PostCode = "LE5 0FH";
            //invoke the method
            OK = TestOrder.Valid(CustomerID, OrderID, DateAdded, OrderTotalPrice, SearchProduct, CardName, CardNumber, SecurityCode, ExpirationDate, Address, City, PostCode);
            //test to see that the result is correct
            Assert.IsFalse(OK);

        }
        [TestMethod]
        public void DateAddedExtremeMin()
        {
            //create an instance of the class we want to create
            clsOrder TestOrder = new clsOrder();
            //boolean variable to store the result of the validation 
            Boolean OK = false;
            //create some test data to pass to the method
            string CustomerID = "a";
            string OrderID = "Iphone7";
            string OrderTotalPrice = "89";
            string SearchProduct = "Iphone6s";
            string CardName = "MR D CHRIS";
            string CardNumber = "1234567891234567";
            string SecurityCode = "619";
            string ExpirationDate = "01/01/2019";
            string Address = "135 Willow Street";
            string City = "Leicester";
            string PostCode ="LE5 0FH";
            //create variable to store the test date data
            DateTime TestDate;
            //set today date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(-100);
            //convert the data variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            OK = TestOrder.Valid(CustomerID, OrderID, DateAdded, OrderTotalPrice, SearchProduct, CardName, CardNumber, SecurityCode, ExpirationDate, Address, City, PostCode);
            //test to see that the result is correct
            Assert.IsFalse(OK);

        }
        [TestMethod]
        public void DateAddedMinLessOne()
        {
            //create an instance of the class we want to create
            clsOrder TestOrder = new clsOrder();
            //boolean variable to store the result of the validation 
            Boolean OK = false;
            //create some test data to pass to the method
            string CustomerID = "5";
            string OrderID = "Iphone7";
            string OrderTotalPrice = "89";
            string SearchProduct = "Iphone6s";
            string CardName = "MR D CHRIS";
            string CardNumber = "1234567891234567";
            string SecurityCode = "619";
            string ExpirationDate = "01/01/2019";
            string Address = "135 Willow Street";
            string City = "Leicester";
            string PostCode = "LE5 0FH";
            //create variable to store the test date data
            DateTime TestDate;
            //set today date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddDays(-1);
            //convert the data variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            OK = TestOrder.Valid(CustomerID, OrderID, DateAdded, OrderTotalPrice, SearchProduct, CardName, CardNumber, SecurityCode, ExpirationDate, Address, City, PostCode);
            //test to see that the result is correct
            Assert.IsFalse(OK);

        }
        [TestMethod]
        public void DateAddedMin()
        {
            //create an instance of the class we want to create
            clsOrder TestOrder = new clsOrder();
            //boolean variable to store the result of the validation 
            Boolean OK = false;
            //create some test data to pass to the method
            string CustomerID = "5";
            string OrderID = "Iphone7";
            string OrderTotalPrice = "89";
            string SearchProduct = "Iphone6s";
            string CardName = "MR D CHRIS";
            string CardNumber = "1234567891234567";
            string SecurityCode = "619";
            string ExpirationDate = "01/01/2019";
            string Address = "135 Willow Street";
            string City = "Leicester";
            string PostCode = "LE5 0FH";
            //create variable to store the test date data
            DateTime TestDate;
            //set today date
            TestDate = DateTime.Now.Date;
            //convert the data variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            OK = TestOrder.Valid(CustomerID, OrderID, DateAdded, OrderTotalPrice, SearchProduct, CardName, CardNumber, SecurityCode, ExpirationDate, Address, City, PostCode);
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void DateAddedMinPLusOne()
        {
            //create an instance of the class we want to create
            clsOrder TestOrder = new clsOrder();
            //boolean variable to store the result of the validation 
            Boolean OK = false;
            //create some test data to pass to the method
            string CustomerID = "5";
            string OrderID = "Iphone7";
            string OrderTotalPrice = "89";
            string SearchProduct = "Iphone6s";
            string CardName = "MR D CHRIS";
            string CardNumber = "1234567891234567";
            string SecurityCode = "619";
            string ExpirationDate = "01/01/2019";
            string Address = "135 Willow Street";
            string City = "Leicester";
            string PostCode = "LE5 0FH";
            //create variable to store the test date data
            DateTime TestDate;
            //set today date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddDays(1);
            //convert the data variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            OK = TestOrder.Valid(CustomerID, OrderID, DateAdded, OrderTotalPrice, SearchProduct, CardName, CardNumber, SecurityCode, ExpirationDate, Address, City, PostCode);
            //test to see that the result is correct
            Assert.IsFalse(OK);

        }
        [TestMethod]
        public void DateAddedExtremeMax()
        {
            //create an instance of the class we want to create
            clsOrder TestOrder = new clsOrder();
            //boolean variable to store the result of the validation 
            Boolean OK = false;
            //create some test data to pass to the method
            string CustomerID = "5";
            string OrderID = "Iphone7";
            string OrderTotalPrice = "89";
            string SearchProduct = "Iphone6s";
            string CardName = "MR D CHRIS";
            string CardNumber = "1234567891234567";
            string SecurityCode = "619";
            string ExpirationDate = "01/01/2019";
            string Address = "135 Willow Street";
            string City = "Leicester";
            string PostCode = "LE5 0FH";
            //create variable to store the test date data
            DateTime TestDate;
            //set today date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(100);
            //convert the data variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            OK = TestOrder.Valid(CustomerID, OrderID, DateAdded, OrderTotalPrice, SearchProduct, CardName, CardNumber, SecurityCode, ExpirationDate, Address, City, PostCode);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }
        [TestMethod]
        public void DateAddedInvalidData()
        {
            //create an instance of the class we want to create
            clsOrder TestOrder = new clsOrder();
            //boolean variable to store the result of the validation 
            Boolean OK = false;
            //create some test data to pass to the method
            string CustomerID = "5";
            string OrderID = "Iphone7";
            string OrderTotalPrice = "89";
            string SearchProduct = "Iphone6s";
            string CardName = "MR D CHRIS";
            string CardNumber = "1234567891234567";
            string SecurityCode = "619";
            string ExpirationDate = "01/01/2019";
            string Address = "135 Willow Street";
            string City = "Leicester";
            string PostCode = "LE5 0FH";
            //set the DateAdded to non date avlue
            string DateAdded = "";
            //invoke the method
            OK = TestOrder.Valid(CustomerID, OrderID, DateAdded, OrderTotalPrice, SearchProduct, CardName, CardNumber, SecurityCode, ExpirationDate, Address, City, PostCode);
            //test to see that the result is correct
            Assert.IsFalse(OK);


        }
        [TestMethod]
        public void PostCodeMinLessOne()
        {
            //create an instance of the class we want to create
            clsOrder TestOrder = new clsOrder();
            //boolean variable to store the result of the validation 
            Boolean OK = false;
            //create some test data to pass to the method
            string CustomerID = "5";
            string OrderID = "Iphone7";
            string DateAdded = "15/03/2017";
            string OrderTotalPrice = "89";
            string SearchProduct = "Iphone6s";
            string CardName = "MR D CHRIS";
            string CardNumber = "1234567891234567";
            string SecurityCode = "619";
            string ExpirationDate = "01/01/2019";
            string Address = "135 Willow Street";
            string City = "Leicester";
            string PostCode = "";
            //invoke the method
            OK = TestOrder.Valid(CustomerID, OrderID, DateAdded, OrderTotalPrice, SearchProduct, CardName, CardNumber, SecurityCode, ExpirationDate, Address, City, PostCode);
            //test to see that the result is correct
            Assert.IsFalse(OK);


        }
        [TestMethod]
        public void PostCodeMin()
        {
            //create an instance of the class we want to create
            clsOrder TestOrder = new clsOrder();
            //boolean variable to store the result of the validation 
            Boolean OK = false;
            //create some test data to pass to the method
            string CustomerID = "5";
            string OrderID = "Iphone7";
            string DateAdded = Convert.ToString(DateTime.Now.Date);
            string OrderTotalPrice = "89";
            string SearchProduct = "Iphone6s";
            string CardName = "MR D CHRIS";
            string CardNumber = "1234567891234567";
            string SecurityCode = "619";
            string ExpirationDate = "01/01/2019";
            string Address = "135 Willow Street";
            string City = "Leicester";
            string PostCode = "a";
            //invoke the method
            OK = TestOrder.Valid(CustomerID, OrderID, DateAdded, OrderTotalPrice, SearchProduct, CardName, CardNumber, SecurityCode, ExpirationDate, Address, City, PostCode);
            //test to see that the result is correct
            Assert.IsTrue(OK);


        }
        [TestMethod]
        public void PostCodeMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder TestOrder = new clsOrder();
            //boolean variable to store the result of the validation 
            Boolean OK = false;
            //create some test data to pass to the method
            string CustomerID = "5";
            string OrderID = "Iphone7";
            string DateAdded = Convert.ToString(DateTime.Now.Date);
            string OrderTotalPrice = "89";
            string SearchProduct = "Iphone6s";
            string CardName = "MR D CHRIS";
            string CardNumber = "1234567891234567";
            string SecurityCode = "619";
            string ExpirationDate = "01/01/2019";
            string Address = "135 Willow Street";
            string City = "Leicester";
            string PostCode = "aa";
            //invoke the method
            OK = TestOrder.Valid(CustomerID, OrderID, DateAdded, OrderTotalPrice, SearchProduct, CardName, CardNumber, SecurityCode, ExpirationDate, Address, City, PostCode);
            //test to see that the result is correct
            Assert.IsTrue(OK);


        }

        [TestMethod]
        public void PostCodeMaxLessOne()
        {
            //create an instance of the class we want to create
            clsOrder TestOrder = new clsOrder();
            //boolean variable to store the result of the validation 
            Boolean OK = false;
            //create some test data to pass to the method
            string CustomerID = "5";
            string OrderID = "Iphone7";
            string DateAdded = Convert.ToString(DateTime.Now.Date);
            string OrderTotalPrice = "89";
            string SearchProduct = "Iphone6s";
            string CardName = "MR D CHRIS";
            string CardNumber = "1234567891234567";
            string SecurityCode = "619";
            string ExpirationDate = "01/01/2019";
            string Address = "135 Willow Street";
            string City = "Leicester";
            string PostCode = "aaaaaaa";
            //invoke the method
            OK = TestOrder.Valid(CustomerID, OrderID, DateAdded, OrderTotalPrice, SearchProduct, CardName, CardNumber, SecurityCode, ExpirationDate, Address, City, PostCode);
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void PostCodeMax()
        {
            //create an instance of the class we want to create
            clsOrder TestOrder = new clsOrder();
            //boolean variable to store the result of the validation 
            Boolean OK = false;
            //create some test data to pass to the method
            string CustomerID = "5";
            string OrderID = "Iphone7";
            string DateAdded = Convert.ToString(DateTime.Now.Date);
            string OrderTotalPrice = "89";
            string SearchProduct = "Iphone6s";
            string CardName = "MR D CHRIS";
            string CardNumber = "1234567891234567";
            string SecurityCode = "619";
            string ExpirationDate = "01/01/2019";
            string Address = "135 Willow Street";
            string City = "Leicester";
            string PostCode = "aaaaaaaa";
            //invoke the method
            OK = TestOrder.Valid(CustomerID, OrderID, DateAdded, OrderTotalPrice, SearchProduct, CardName, CardNumber, SecurityCode, ExpirationDate, Address, City, PostCode);
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void PostCodeMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder TestOrder = new clsOrder();
            //boolean variable to store the result of the validation 
            Boolean OK = false;
            //create some test data to pass to the method
            string CustomerID = "5";
            string OrderID = "Iphone7";
            string DateAdded = "15/03/2017";
            string OrderTotalPrice = "89";
            string SearchProduct = "Iphone6s";
            string CardName = "MR D CHRIS";
            string CardNumber = "1234567891234567";
            string SecurityCode = "619";
            string ExpirationDate = "01/01/2019";
            string Address = "135 Willow Street";
            string City = "Leicester";
            string PostCode = "aaaaaaa";
            //invoke the method
            OK = TestOrder.Valid(CustomerID, OrderID, DateAdded, OrderTotalPrice, SearchProduct, CardName, CardNumber, SecurityCode, ExpirationDate, Address, City, PostCode);
            //test to see that the result is correct
            Assert.IsFalse(OK);

        }
        [TestMethod]
        public void PostCodeMid()
        {
            //create an instance of the class we want to create
            clsOrder TestOrder = new clsOrder();
            //boolean variable to store the result of the validation 
            Boolean OK = false;
            //create some test data to pass to the method
            string CustomerID = "5";
            string OrderID = "Iphone7";
            string DateAdded = Convert.ToString(DateTime.Now.Date);
            string OrderTotalPrice = "89";
            string SearchProduct = "Iphone6s";
            string CardName = "MR D CHRIS";
            string CardNumber = "1234567891234567";
            string SecurityCode = "619";
            string ExpirationDate = "01/01/2019";
            string Address = "135 Willow Street";
            string City = "Leicester";
            string PostCode = "aaaaaaa";
            //invoke the method
            OK = TestOrder.Valid(CustomerID, OrderID, DateAdded, OrderTotalPrice, SearchProduct, CardName, CardNumber, SecurityCode, ExpirationDate, Address, City, PostCode);
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void OrderIDMinLessOne()
        {
            //create an instance of the class we want to create
            clsOrder TestOrder = new clsOrder();
            //boolean variable to store the result of the validation 
            Boolean OK = false;
            //create some test data to pass to the method
            string CustomerID = "5";
            string OrderID = "";
            string DateAdded = "15/03/2017";
            string OrderTotalPrice = "89";
            string SearchProduct = "Iphone6s";
            string CardName = "MR D CHRIS";
            string CardNumber = "1234567891234567";
            string SecurityCode = "619";
            string ExpirationDate = "01/01/2019";
            string Address = "135 Willow Street";
            string City = "Leicester";
            string PostCode = "LE5 0FH";
            //invoke the method
            OK = TestOrder.Valid(CustomerID, OrderID, DateAdded, OrderTotalPrice, SearchProduct, CardName, CardNumber, SecurityCode, ExpirationDate, Address, City, PostCode);
            //test to see that the result is correct
            Assert.IsFalse(OK);

        }
        [TestMethod]
        public void OrderIDMin()
        {
            //create an instance of the class we want to create
            clsOrder TestOrder = new clsOrder();
            //boolean variable to store the result of the validation 
            Boolean OK = false;
            //create some test data to pass to the method
            string CustomerID = "5";
            string OrderID = "a";
            string DateAdded = Convert.ToString(DateTime.Now.Date);
            string OrderTotalPrice = "89";
            string SearchProduct = "Iphone6s";
            string CardName = "MR D CHRIS";
            string CardNumber = "1234567891234567";
            string SecurityCode = "619";
            string ExpirationDate = "01/01/2019";
            string Address = "135 Willow Street";
            string City = "Leicester";
            string PostCode = "LE5 0FH";
            //invoke the method
            OK = TestOrder.Valid(CustomerID, OrderID, DateAdded, OrderTotalPrice, SearchProduct, CardName, CardNumber, SecurityCode, ExpirationDate, Address, City, PostCode);
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void OrderIDMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder TestOrder = new clsOrder();
            //boolean variable to store the result of the validation 
            Boolean OK = false;
            //create some test data to pass to the method
            string CustomerID = "5";
            string OrderID = "aa";
            string DateAdded = Convert.ToString(DateTime.Now.Date);
            string OrderTotalPrice = "89";
            string SearchProduct = "Iphone6s";
            string CardName = "MR D CHRIS";
            string CardNumber = "1234567891234567";
            string SecurityCode = "619";
            string ExpirationDate = "01/01/2019";
            string Address = "135 Willow Street";
            string City = "Leicester";
            string PostCode = "LE5 0FH";
            //invoke the method
            OK = TestOrder.Valid(CustomerID, OrderID, DateAdded, OrderTotalPrice, SearchProduct, CardName, CardNumber, SecurityCode, ExpirationDate, Address, City, PostCode);
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void OrderIDMaxLessOne()
        {
            //create an instance of the class we want to create
            clsOrder TestOrder = new clsOrder();
            //boolean variable to store the result of the validation 
            Boolean OK = false;
            //create some test data to pass to the method
            string CustomerID = "5";
            string OrderID = "";
            OrderID = OrderID.PadRight(49, 'a');
            string DateAdded = Convert.ToString(DateTime.Now.Date);
            string OrderTotalPrice = "89";
            string SearchProduct = "Iphone6s";
            string CardName = "MR D CHRIS";
            string CardNumber = "1234567891234567";
            string SecurityCode = "619";
            string ExpirationDate = "01/01/2019";
            string Address = "135 Willow Street";
            string City = "Leicester";
            string PostCode = "LE5 0FH";
            //invoke the method
            OK = TestOrder.Valid(CustomerID, OrderID, DateAdded, OrderTotalPrice, SearchProduct, CardName, CardNumber, SecurityCode, ExpirationDate, Address, City, PostCode);
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void OrderIDMax()
        {
            //create an instance of the class we want to create
            clsOrder TestOrder = new clsOrder();
            //boolean variable to store the result of the validation 
            Boolean OK = false;
            //create some test data to pass to the method
            string CustomerID = "5";
            string OrderID = "";
            OrderID = OrderID.PadRight(50, 'a');
            string DateAdded = Convert.ToString(DateTime.Now.Date);
            string OrderTotalPrice = "89";
            string SearchProduct = "Iphone6s";
            string CardName = "MR D CHRIS";
            string CardNumber = "1234567891234567";
            string SecurityCode = "619";
            string ExpirationDate = "01/01/2019";
            string Address = "135 Willow Street";
            string City = "Leicester";
            string PostCode = "LE5 0FH";
            //invoke the method
            OK = TestOrder.Valid(CustomerID, OrderID, DateAdded, OrderTotalPrice, SearchProduct, CardName, CardNumber, SecurityCode, ExpirationDate, Address, City, PostCode);
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void OrderIDMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder TestOrder = new clsOrder();
            //boolean variable to store the result of the validation 
            Boolean OK = false;
            //create some test data to pass to the method
            string CustomerID = "5";
            string OrderID = "";
            OrderID = OrderID.PadRight(51, 'a');
            string DateAdded = Convert.ToString(DateTime.Now.Date);
            string OrderTotalPrice = "89";
            string SearchProduct = "Iphone6s";
            string CardName = "MR D CHRIS";
            string CardNumber = "1234567891234567";
            string SecurityCode = "619";
            string ExpirationDate = "01/01/2019";
            string Address = "135 Willow Street";
            string City = "Leicester";
            string PostCode = "LE5 0FH";
            //invoke the method
            OK = TestOrder.Valid(CustomerID, OrderID, DateAdded, OrderTotalPrice, SearchProduct, CardName, CardNumber, SecurityCode, ExpirationDate, Address, City, PostCode);
            //test to see that the result is correct
            Assert.IsFalse(OK);

        }
        [TestMethod]
        public void OrderIDMid()
        {
            //create an instance of the class we want to create
            clsOrder TestOrder = new clsOrder();
            //boolean variable to store the result of the validation 
            Boolean OK = false;
            //create some test data to pass to the method
            string CustomerID = "5";
            string OrderID = "";
            OrderID = OrderID.PadRight(25, 'a');
            string DateAdded = Convert.ToString(DateTime.Now.Date);
            string OrderTotalPrice = "89";
            string SearchProduct = "Iphone6s";
            string CardName = "MR D CHRIS";
            string CardNumber = "1234567891234567";
            string SecurityCode = "619";
            string ExpirationDate = "01/01/2019";
            string Address = "135 Willow Street";
            string City = "Leicester";
            string PostCode = "LE5 0FH";
            //invoke the method
            OK = TestOrder.Valid(CustomerID, OrderID, DateAdded, OrderTotalPrice, SearchProduct, CardName, CardNumber, SecurityCode, ExpirationDate, Address, City, PostCode);
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void SearchProductMinLessOne()
        {
            //create an instance of the class we want to create
            clsOrder TestOrder = new clsOrder();
            //boolean variable to store the result of the validation 
            Boolean OK = false;
            //create some test data to pass to the method
            string CustomerID = "5";
            string OrderID = "Iphone6s";
            string DateAdded = "15/03/2017";
            string OrderTotalPrice = "89";
            string SearchProduct = "";
            string CardName = "MR D CHRIS";
            string CardNumber = "1234567891234567";
            string SecurityCode = "619";
            string ExpirationDate = "01/01/2019";
            string Address = "135 Willow Street";
            string City = "Leicester";
            string PostCode = "LE5 0FH";
            //invoke the method
            OK = TestOrder.Valid(CustomerID, OrderID, DateAdded, OrderTotalPrice, SearchProduct, CardName, CardNumber, SecurityCode, ExpirationDate, Address, City, PostCode);
            //test to see that the result is correct
            Assert.IsFalse(OK);

        }
        [TestMethod]
        public void SearchProductMin()
        {
            //create an instance of the class we want to create
            clsOrder TestOrder = new clsOrder();
            //boolean variable to store the result of the validation 
            Boolean OK = false;
            //create some test data to pass to the method
            string CustomerID = "5";
            string OrderID = "Iphone7";
            string DateAdded = Convert.ToString(DateTime.Now.Date);
            string OrderTotalPrice = "89";
            string SearchProduct = "a";
            string CardName = "MR D CHRIS";
            string CardNumber = "1234567891234567";
            string SecurityCode = "619";
            string ExpirationDate = "01/01/2019";
            string Address = "135 Willow Street";
            string City = "Leicester";
            string PostCode = "LE5 0FH";
            //invoke the method
            OK = TestOrder.Valid(CustomerID, OrderID, DateAdded, OrderTotalPrice, SearchProduct, CardName, CardNumber, SecurityCode, ExpirationDate, Address, City, PostCode);
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void SearchProductMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder TestOrder = new clsOrder();
            //boolean variable to store the result of the validation 
            Boolean OK = false;
            //create some test data to pass to the method
            string CustomerID = "5";
            string OrderID = "Iphone7";
            string DateAdded = Convert.ToString(DateTime.Now.Date);
            string OrderTotalPrice = "89";
            string SearchProduct = "aa";
            string CardName = "MR D CHRIS";
            string CardNumber = "1234567891234567";
            string SecurityCode = "619";
            string ExpirationDate = "01/01/2019";
            string Address = "135 Willow Street";
            string City = "Leicester";
            string PostCode = "LE5 0FH";
            //invoke the method
            OK = TestOrder.Valid(CustomerID, OrderID, DateAdded, OrderTotalPrice, SearchProduct, CardName, CardNumber, SecurityCode, ExpirationDate, Address, City, PostCode);
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void SearchProductMaxLessOne()
        {
            //create an instance of the class we want to create
            clsOrder TestOrder = new clsOrder();
            //boolean variable to store the result of the validation 
            Boolean OK = false;
            //create some test data to pass to the method
            string CustomerID = "5";
            string OrderID = "Iphone6s";
            string DateAdded = Convert.ToString(DateTime.Now.Date);
            string OrderTotalPrice = "89";
            string SearchProduct = "";
            SearchProduct = SearchProduct.PadRight(49, 'a');
            string CardName = "MR D CHRIS";
            string CardNumber = "1234567891234567";
            string SecurityCode = "619";
            string ExpirationDate = "01/01/2019";
            string Address = "135 Willow Street";
            string City = "Leicester";
            string PostCode = "LE5 0FH";
            //invoke the method
            OK = TestOrder.Valid(CustomerID, OrderID, DateAdded, OrderTotalPrice, SearchProduct, CardName, CardNumber, SecurityCode, ExpirationDate, Address, City, PostCode);
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void SearchProductMax()
        {
            //create an instance of the class we want to create
            clsOrder TestOrder = new clsOrder();
            //boolean variable to store the result of the validation 
            Boolean OK = false;
            //create some test data to pass to the method
            string CustomerID = "5";
            string OrderID = "Iphone7";
            string DateAdded = Convert.ToString(DateTime.Now.Date);
            string OrderTotalPrice = "89";
            string SearchProduct = "";
            SearchProduct = SearchProduct.PadRight(50, 'a');
            string CardName = "MR D CHRIS";
            string CardNumber = "1234567891234567";
            string SecurityCode = "619";
            string ExpirationDate = "01/01/2019";
            string Address = "135 Willow Street";
            string City = "Leicester";
            string PostCode = "LE5 0FH";
            //invoke the method
            OK = TestOrder.Valid(CustomerID, OrderID, DateAdded, OrderTotalPrice, SearchProduct, CardName, CardNumber, SecurityCode, ExpirationDate, Address, City, PostCode);
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void SearchProductPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder TestOrder = new clsOrder();
            //boolean variable to store the result of the validation 
            Boolean OK = false;
            //create some test data to pass to the method
            string CustomerID = "5";
            string OrderID = "Iphone7";
            string DateAdded = "15/03/2017";
            string OrderTotalPrice = "89";
            string SearchProduct = "";
            SearchProduct = SearchProduct.PadRight(51, 'a');
            string CardName = "MR D CHRIS";
            string CardNumber = "1234567891234567";
            string SecurityCode = "619";
            string ExpirationDate = "01/01/2019";
            string Address = "135 Willow Street";
            string City = "Leicester";
            string PostCode = "LE5 0FH";
            //invoke the method
            OK = TestOrder.Valid(CustomerID, OrderID, DateAdded, OrderTotalPrice, SearchProduct, CardName, CardNumber, SecurityCode, ExpirationDate, Address, City, PostCode);
            //test to see that the result is correct
            Assert.IsFalse(OK);

        }
        [TestMethod]
        public void SearchProductMid()
        {
            //create an instance of the class we want to create
            clsOrder TestOrder = new clsOrder();
            //boolean variable to store the result of the validation 
            Boolean OK = false;
            //create some test data to pass to the method
            string CustomerID = "5";
            string OrderID = "Iphone7";
            string DateAdded = Convert.ToString(DateTime.Now.Date);
            string OrderTotalPrice = "89";
            string SearchProduct = "";
            SearchProduct = SearchProduct.PadRight(25, 'a');
            string CardName = "MR D CHRIS";
            string CardNumber = "1234567891234567";
            string SecurityCode = "619";
            string ExpirationDate = "01/01/2019";
            string Address = "135 Willow Street";
            string City = "Leicester";
            string PostCode = "LE5 0FH";
            //invoke the method
            OK = TestOrder.Valid(CustomerID, OrderID, DateAdded, OrderTotalPrice, SearchProduct, CardName, CardNumber, SecurityCode, ExpirationDate, Address, City, PostCode);
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void CardNameMinLessOne()
        {
            //create an instance of the class we want to create
            clsOrder TestOrder = new clsOrder();
            //boolean variable to store the result of the validation 
            Boolean OK = false;
            //create some test data to pass to the method
            string CustomerID = "5";
            string OrderID = "Iphone7";
            string DateAdded = "15/03/2017";
            string OrderTotalPrice = "89";
            string SearchProduct = "Iphone6s";
            string CardName = "";
            string CardNumber = "1234567891234567";
            string SecurityCode = "619";
            string ExpirationDate = "01/01/2019";
            string Address = "135 Willow Street";
            string City = "Leicester";
            string PostCode = "LE5 0FH";
            //invoke the method
            OK = TestOrder.Valid(CustomerID, OrderID, DateAdded, OrderTotalPrice, SearchProduct, CardName, CardNumber, SecurityCode, ExpirationDate, Address, City, PostCode);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }
        [TestMethod]
        public void CardNameMin()
        {
            //create an instance of the class we want to create
            clsOrder TestOrder = new clsOrder();
            //boolean variable to store the result of the validation 
            Boolean OK = false;
            //create some test data to pass to the method
            string CustomerID = "5";
            string OrderID = "Iphone7";
            string DateAdded = Convert.ToString(DateTime.Now.Date);
            string OrderTotalPrice = "89";
            string SearchProduct = "Iphone6s";
            string CardName = "a";
            string CardNumber = "1234567891234567";
            string SecurityCode = "619";
            string ExpirationDate = "01/01/2019";
            string Address = "135 Willow Street";
            string City = "Leicester";
            string PostCode = "LE5 0FH";
            //invoke the method
            OK = TestOrder.Valid(CustomerID, OrderID, DateAdded, OrderTotalPrice, SearchProduct, CardName, CardNumber, SecurityCode, ExpirationDate, Address, City, PostCode);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void CardNameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder TestOrder = new clsOrder();
            //boolean variable to store the result of the validation 
            Boolean OK = false;
            //create some test data to pass to the method
            string CustomerID = "5";
            string OrderID = "Iphone7";
            string DateAdded = Convert.ToString(DateTime.Now.Date);
            string OrderTotalPrice = "89";
            string SearchProduct = "Iphone6s";
            string CardName = "aa";
            string CardNumber = "1234567891234567";
            string SecurityCode = "619";
            string ExpirationDate = "01/01/2019";
            string Address = "135 Willow Street";
            string City = "Leicester";
            string PostCode = "LE5 0FH";
            //invoke the method
            OK = TestOrder.Valid(CustomerID, OrderID, DateAdded, OrderTotalPrice, SearchProduct, CardName, CardNumber, SecurityCode, ExpirationDate, Address, City, PostCode);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void CardNameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsOrder TestOrder = new clsOrder();
            //boolean variable to store the result of the validation 
            Boolean OK = false;
            //create some test data to pass to the method
            string CustomerID = "5";
            string OrderID = "Iphone7";
            string DateAdded = Convert.ToString(DateTime.Now.Date);
            string OrderTotalPrice = "89";
            string SearchProduct = "Iphone6s";
            string CardName = "";
            CardName = CardName.PadRight(49, 'a');
            string CardNumber = "1234567891234567";
            string SecurityCode = "619";
            string ExpirationDate = "01/01/2019";
            string Address = "135 Willow Street";
            string City = "Leicester";
            string PostCode = "LE5 0FH";
            //invoke the method
            OK = TestOrder.Valid(CustomerID, OrderID, DateAdded, OrderTotalPrice, SearchProduct, CardName, CardNumber, SecurityCode, ExpirationDate, Address, City, PostCode);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void CardNameMax()
        {
            //create an instance of the class we want to create
            clsOrder TestOrder = new clsOrder();
            //boolean variable to store the result of the validation 
            Boolean OK = false;
            //create some test data to pass to the method
            string CustomerID = "5";
            string OrderID = "Iphone7";
            string DateAdded = Convert.ToString(DateTime.Now.Date);
            string OrderTotalPrice = "89";
            string SearchProduct = "Iphone6s";
            string CardName = "";
            CardName = CardName.PadRight(50, 'a');
            string CardNumber = "1234567891234567";
            string SecurityCode = "619";
            string ExpirationDate = "01/01/2019";
            string Address = "135 Willow Street";
            string City = "Leicester";
            string PostCode = "LE5 0FH";
            //invoke the method
            OK = TestOrder.Valid(CustomerID, OrderID, DateAdded, OrderTotalPrice, SearchProduct, CardName, CardNumber, SecurityCode, ExpirationDate, Address, City, PostCode);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void CardNameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder TestOrder = new clsOrder();
            //boolean variable to store the result of the validation 
            Boolean OK = false;
            //create some test data to pass to the method
            string CustomerID = "5";
            string OrderID = "Iphone7";
            string DateAdded = "15/03/2017";
            string OrderTotalPrice = "89";
            string SearchProduct = "Iphone6s";
            string CardName = "";
            CardName = CardName.PadRight(51, 'a');
            string CardNumber = "1234567891234567";
            string SecurityCode = "619";
            string ExpirationDate = "01/01/2019";
            string Address = "135 Willow Street";
            string City = "Leicester";
            string PostCode = "LE5 0FH";
            //invoke the method
            OK = TestOrder.Valid(CustomerID, OrderID, DateAdded, OrderTotalPrice, SearchProduct, CardName, CardNumber, SecurityCode, ExpirationDate, Address, City, PostCode);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }
        [TestMethod]
        public void CardNameMid()
        {
            //create an instance of the class we want to create
            clsOrder TestOrder = new clsOrder();
            //boolean variable to store the result of the validation 
            Boolean OK = false;
            //create some test data to pass to the method
            string CustomerID = "5";
            string OrderID = "Iphone7";
            string DateAdded = Convert.ToString(DateTime.Now.Date);
            string OrderTotalPrice = "89";
            string SearchProduct = "Iphone6s";
            string CardName = "";
            CardName = CardName.PadRight(25, 'a');
            string CardNumber = "1234567891234567";
            string SecurityCode = "619";
            string ExpirationDate = "01/01/2019";
            string Address = "135 Willow Street";
            string City = "Leicester";
            string PostCode = "LE5 0FH";
            //invoke the method
            OK = TestOrder.Valid(CustomerID, OrderID, DateAdded, OrderTotalPrice, SearchProduct, CardName, CardNumber, SecurityCode, ExpirationDate, Address, City, PostCode);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void CardNumberMinLessOne()
        {
            //create an instance of the class we want to create
            clsOrder TestOrder = new clsOrder();
            //boolean variable to store the result of the validation 
            Boolean OK = false;
            //create some test data to pass to the method
            string CustomerID = "5";
            string OrderID = "Iphone7";
            string DateAdded = "15/03/2017";
            string OrderTotalPrice = "89";
            string SearchProduct = "Iphone6s";
            string CardName = "MR D CHRIS";
            string CardNumber = "";
            string SecurityCode = "619";
            string ExpirationDate = "01/01/2019";
            string Address = "135 Willow Street";
            string City = "Leicester";
            string PostCode = "LE5 0FH";
            //invoke the method
            OK = TestOrder.Valid(CustomerID, OrderID, DateAdded, OrderTotalPrice, SearchProduct, CardName, CardNumber, SecurityCode, ExpirationDate, Address, City, PostCode);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }
        [TestMethod]
        public void CardNumberMin()
        {
            //create an instance of the class we want to create
            clsOrder TestOrder = new clsOrder();
            //boolean variable to store the result of the validation 
            Boolean OK = false;
            //create some test data to pass to the method
            string CustomerID = "5";
            string OrderID = "Iphone7";
            string DateAdded = Convert.ToString(DateTime.Now.Date);
            string OrderTotalPrice = "89";
            string SearchProduct = "Iphone6s";
            string CardName = "MR D CHRIS";
            string CardNumber = "a";
            string SecurityCode = "619";
            string ExpirationDate = "01/01/2019";
            string Address = "135 Willow Street";
            string City = "Leicester";
            string PostCode = "LE5 0FH";
            //invoke the method
            OK = TestOrder.Valid(CustomerID, OrderID, DateAdded, OrderTotalPrice, SearchProduct, CardName, CardNumber, SecurityCode, ExpirationDate, Address, City, PostCode);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void CardNumberMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder TestOrder = new clsOrder();
            //boolean variable to store the result of the validation 
            Boolean OK = false;
            //create some test data to pass to the method
            string CustomerID = "5";
            string OrderID = "Iphone7";
            string DateAdded = Convert.ToString(DateTime.Now.Date);
            string OrderTotalPrice = "89";
            string SearchProduct = "Iphone6s";
            string CardName = "MR D CHRIS";
            string CardNumber = "aa";
            string SecurityCode = "619";
            string ExpirationDate = "01/01/2019";
            string Address = "135 Willow Street";
            string City = "Leicester";
            string PostCode = "LE5 0FH";
            //invoke the method
            OK = TestOrder.Valid(CustomerID, OrderID, DateAdded, OrderTotalPrice, SearchProduct, CardName, CardNumber, SecurityCode, ExpirationDate, Address, City, PostCode);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void CardNumberMaxLessOne()
        {
            //create an instance of the class we want to create
            clsOrder TestOrder = new clsOrder();
            //boolean variable to store the result of the validation 
            Boolean OK = false;
            //create some test data to pass to the method
            string CustomerID = "5";
            string OrderID = "Iphone7";
            string DateAdded = Convert.ToString(DateTime.Now.Date);
            string OrderTotalPrice = "89";
            string SearchProduct = "Iphone6s";
            string CardName = "MR D CHRIS";
            string CardNumber = "";
            CardNumber = CardNumber.PadRight(15, 'a');
            string SecurityCode = "619";
            string ExpirationDate = "01/01/2019";
            string Address = "135 Willow Street";
            string City = "Leicester";
            string PostCode = "LE5 0FH";
            //invoke the method
            OK = TestOrder.Valid(CustomerID, OrderID, DateAdded, OrderTotalPrice, SearchProduct, CardName, CardNumber, SecurityCode, ExpirationDate, Address, City, PostCode);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void CardNumberMax()
        {
            //create an instance of the class we want to create
            clsOrder TestOrder = new clsOrder();
            //boolean variable to store the result of the validation 
            Boolean OK = false;
            //create some test data to pass to the method
            string CustomerID = "5";
            string OrderID = "Iphone7";
            string DateAdded = Convert.ToString(DateTime.Now.Date);
            string OrderTotalPrice = "89";
            string SearchProduct = "Iphone6s";
            string CardName = "MR D CHRIS";
            string CardNumber = "";
            CardNumber = CardNumber.PadRight(16, 'a');
            string SecurityCode = "619";
            string ExpirationDate = "01/01/2019";
            string Address = "135 Willow Street";
            string City = "Leicester";
            string PostCode = "LE5 0FH";
            //invoke the method
            OK = TestOrder.Valid(CustomerID, OrderID, DateAdded, OrderTotalPrice, SearchProduct, CardName, CardNumber, SecurityCode, ExpirationDate, Address, City, PostCode);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void CardNumberMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder TestOrder = new clsOrder();
            //boolean variable to store the result of the validation 
            Boolean OK = false;
            //create some test data to pass to the method
            string CustomerID = "5";
            string OrderID = "Iphone7";
            string DateAdded = "15/03/2017";
            string OrderTotalPrice = "89";
            string SearchProduct = "Iphone6s";
            string CardName = "MR D CHRIS";
            string CardNumber = "";
            CardNumber = CardNumber.PadRight(25, 'a');
            string SecurityCode = "619";
            string ExpirationDate = "01/01/2019";
            string Address = "135 Willow Street";
            string City = "Leicester";
            string PostCode = "LE5 0FH";
            //invoke the method
            OK = TestOrder.Valid(CustomerID, OrderID, DateAdded, OrderTotalPrice, SearchProduct, CardName, CardNumber, SecurityCode, ExpirationDate, Address, City, PostCode);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }
        [TestMethod]
        public void CardNumberMid()
        {
            //create an instance of the class we want to create
            clsOrder TestOrder = new clsOrder();
            //boolean variable to store the result of the validation 
            Boolean OK = false;
            //create some test data to pass to the method
            string CustomerID = "5";
            string OrderID = "Iphone7";
            string DateAdded = Convert.ToString(DateTime.Now.Date);
            string OrderTotalPrice = "89";
            string SearchProduct = "Iphone6s";
            string CardName = "MR D CHRIS";
            string CardNumber = "";
            CardNumber = CardNumber.PadRight(8, 'a');
            string SecurityCode = "619";
            string ExpirationDate = "01/01/2019";
            string Address = "135 Willow Street";
            string City = "Leicester";
            string PostCode = "LE5 0FH";
            //invoke the method
            OK = TestOrder.Valid(CustomerID, OrderID, DateAdded, OrderTotalPrice, SearchProduct, CardName, CardNumber, SecurityCode, ExpirationDate, Address, City, PostCode);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void SecurityCodeMinLessOne()
        {
            //create an instance of the class we want to create
            clsOrder TestOrder = new clsOrder();
            //boolean variable to store the result of the validation 
            Boolean OK = false;
            //create some test data to pass to the method
            string CustomerID = "5";
            string OrderID = "Iphone7";
            string DateAdded = "15/03/2017";
            string OrderTotalPrice = "89";
            string SearchProduct = "Iphone6s";
            string CardName = "MR D CHRIS";
            string CardNumber = "1234567891234567";
            string SecurityCode = "";
            string ExpirationDate = "01/01/2019";
            string Address = "135 Willow Street";
            string City = "Leicester";
            string PostCode = "LE5 0FH";
            //invoke the method
            OK = TestOrder.Valid(CustomerID, OrderID, DateAdded, OrderTotalPrice, SearchProduct, CardName, CardNumber, SecurityCode, ExpirationDate, Address, City, PostCode);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }
        [TestMethod]
        public void SecurityCodeMin()
        {
            //create an instance of the class we want to create
            clsOrder TestOrder = new clsOrder();
            //boolean variable to store the result of the validation 
            Boolean OK = false;
            //create some test data to pass to the method
            string CustomerID = "5";
            string OrderID = "Iphone7";
            string DateAdded = Convert.ToString(DateTime.Now.Date);
            string OrderTotalPrice = "89";
            string SearchProduct = "Iphone6s";
            string CardName = "MR D CHRIS";
            string CardNumber = "1234567891234567";
            string SecurityCode = "a";
            string ExpirationDate = "01/01/2019";
            string Address = "135 Willow Street";
            string City = "Leicester";
            string PostCode = "LE5 0FH";
            //invoke the method
            OK = TestOrder.Valid(CustomerID, OrderID, DateAdded, OrderTotalPrice, SearchProduct, CardName, CardNumber, SecurityCode, ExpirationDate, Address, City, PostCode);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void SecurityCodeMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder TestOrder = new clsOrder();
            //boolean variable to store the result of the validation 
            Boolean OK = false;
            //create some test data to pass to the method
            string CustomerID = "5";
            string OrderID = "Iphone7";
            string DateAdded = Convert.ToString(DateTime.Now.Date);
            string SearchProduct = "Iphone6s";
            string OrderTotalPrice = "89";
            string CardName = "MR D CHRIS";
            string CardNumber = "1234567891234567";
            string SecurityCode = "aa";
            string ExpirationDate = "01/01/2019";
            string Address = "135 Willow Streett";
            string City = "Leicester";
            string PostCode = "LE5 0FH";
            //invoke the method
            OK = TestOrder.Valid(CustomerID, OrderID, DateAdded, OrderTotalPrice, SearchProduct, CardName, CardNumber, SecurityCode, ExpirationDate, Address, City, PostCode);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void SecurityCodeMaxLessOne()
        {
            //create an instance of the class we want to create
            clsOrder TestOrder = new clsOrder();
            //boolean variable to store the result of the validation 
            Boolean OK = false;
            //create some test data to pass to the method
            string CustomerID = "5";
            string OrderID = "Iphone7";
            string DateAdded = Convert.ToString(DateTime.Now.Date);
            string OrderTotalPrice = "89";
            string SearchProduct = "Iphone6s";
            string CardName = "MR D CHRIS";
            string CardNumber = "1234567891234567";
            string SecurityCode = "";
            SecurityCode = SecurityCode.PadRight(5, 'a');
            string ExpirationDate = "01/01/2019";
            string Address = "135 Willow Street";
            string City = "Leicester";
            string PostCode = "LE5 0FH";
            //invoke the method
            OK = TestOrder.Valid(CustomerID, OrderID, DateAdded, OrderTotalPrice, SearchProduct, CardName, CardNumber, SecurityCode, ExpirationDate, Address, City, PostCode);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void SecurityCodeMax()
        {
            //create an instance of the class we want to create
            clsOrder TestOrder = new clsOrder();
            //boolean variable to store the result of the validation 
            Boolean OK = false;
            //create some test data to pass to the method
            string CustomerID = "5";
            string OrderID = "Iphone7";
            string DateAdded = Convert.ToString(DateTime.Now.Date);
            string OrderTotalPrice = "89";
            string SearchProduct = "Iphone6s";
            string CardName = "MR D CHRIS";
            string CardNumber = "1234567891234567";
            string SecurityCode = "";
            SecurityCode = SecurityCode.PadRight(6, 'a');
            string ExpirationDate = "01/01/2019";
            string Address = "135 Willow Street";
            string City = "Leicester";
            string PostCode = "LE5 0FH";
            //invoke the method
            OK = TestOrder.Valid(CustomerID, OrderID, DateAdded, OrderTotalPrice, SearchProduct, CardName, CardNumber, SecurityCode, ExpirationDate, Address, City, PostCode);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void SecurityCodeMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder TestOrder = new clsOrder();
            //boolean variable to store the result of the validation 
            Boolean OK = false;
            //create some test data to pass to the method
            string CustomerID = "5";
            string OrderID = "Iphone7";
            string DateAdded = "15/03/2017";
            string OrderTotalPrice = "89";
            string SearchProduct = "Iphone6s";
            string CardName = "MR D CHRIS";
            string CardNumber = "1234567891234567";
            string SecurityCode = "";
            SecurityCode = SecurityCode.PadRight(7, 'a');
            string ExpirationDate = "01/01/2019";
            string Address = "135 Willow Street";
            string City = "Leicester";
            string PostCode = "LE5 0FH";
            //invoke the method
            OK = TestOrder.Valid(CustomerID, OrderID, DateAdded, OrderTotalPrice, SearchProduct, CardName, CardNumber, SecurityCode, ExpirationDate, Address, City, PostCode);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }
        [TestMethod]
        public void SecurityCodeMid()
        {
            //create an instance of the class we want to create
            clsOrder TestOrder = new clsOrder();
            //boolean variable to store the result of the validation 
            Boolean OK = false;
            //create some test data to pass to the method
            string CustomerID = "5";
            string OrderID = "Iphone7";
            string DateAdded = Convert.ToString(DateTime.Now.Date);
            string OrderTotalPrice = "89";
            string SearchProduct = "Iphone6s";
            string CardName = "MR D CHRIS";
            string CardNumber = "1234567891234567";
            string SecurityCode = "";
            SecurityCode = SecurityCode.PadRight(3, 'a');
            string ExpirationDate = "01/01/2019";
            string Address = "135 Willow Street";
            string City = "Leicester";
            string PostCode = "LE5 0FH";
            //invoke the method
            OK = TestOrder.Valid(CustomerID, OrderID, DateAdded, OrderTotalPrice, SearchProduct, CardName, CardNumber, SecurityCode, ExpirationDate, Address, City, PostCode);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void AddressMinLessOne()
        {
            //create an instance of the class we want to create
            clsOrder TestOrder = new clsOrder();
            //boolean variable to store the result of the validation 
            Boolean OK = false;
            //create some test data to pass to the method
            string CustomerID = "5";
            string OrderID = "Iphone7";
            string DateAdded = "15/03/2017";
            string OrderTotalPrice = "89";
            string SearchProduct = "Iphone6s";
            string CardName = "MR D CHRIS";
            string CardNumber = "1234567891234567";
            string SecurityCode = "619";
            string ExpirationDate = "01/01/2019";
            string Address = "";
            string City = "Leicester";
            string PostCode = "LE5 0FH";
            //invoke the method
            OK = TestOrder.Valid(CustomerID, OrderID, DateAdded, OrderTotalPrice, SearchProduct, CardName, CardNumber, SecurityCode, ExpirationDate, Address, City, PostCode);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }
        [TestMethod]
        public void AddressMin()
        {
            //create an instance of the class we want to create
            clsOrder TestOrder = new clsOrder();
            //boolean variable to store the result of the validation 
            Boolean OK = false;
            //create some test data to pass to the method
            string CustomerID = "5";
            string OrderID = "Iphone7";
            string DateAdded = Convert.ToString(DateTime.Now.Date);
            string OrderTotalPrice = "89";
            string SearchProduct = "Iphone6s";
            string CardName = "MR D CHRIS";
            string CardNumber = "1234567891234567";
            string SecurityCode = "619";
            string ExpirationDate = "01/01/2019";
            string Address = "a";
            string City = "Leicester";
            string PostCode = "LE5 0FH";
            //invoke the method
            OK = TestOrder.Valid(CustomerID, OrderID, DateAdded, OrderTotalPrice, SearchProduct, CardName, CardNumber, SecurityCode, ExpirationDate, Address, City, PostCode);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void AddressMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder TestOrder = new clsOrder();
            //boolean variable to store the result of the validation 
            Boolean OK = false;
            //create some test data to pass to the method
            string CustomerID = "5";
            string OrderID = "Iphone7";
            string DateAdded = Convert.ToString(DateTime.Now.Date);
            string OrderTotalPrice = "89";
            string SearchProduct = "Iphone6s";
            string CardName = "MR D CHRIS";
            string CardNumber = "1234567891234567";
            string SecurityCode = "619";
            string ExpirationDate = "01/01/2019";
            string Address = "aa";
            string City = "Leicester";
            string PostCode = "LE5 0FH";
            //invoke the method
            OK = TestOrder.Valid(CustomerID, OrderID, DateAdded, OrderTotalPrice, SearchProduct, CardName, CardNumber, SecurityCode, ExpirationDate, Address, City, PostCode);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void AddressMaxLessOne()
        {
            //create an instance of the class we want to create
            clsOrder TestOrder = new clsOrder();
            //boolean variable to store the result of the validation 
            Boolean OK = false;
            //create some test data to pass to the method
            string CustomerID = "5";
            string OrderID = "Iphone7";
            string DateAdded = Convert.ToString(DateTime.Now.Date);
            string OrderTotalPrice = "89";
            string SearchProduct = "Iphone6s";
            string CardName = "MR D CHRIS";
            string CardNumber = "1234567891234567";
            string SecurityCode = "619";
            string ExpirationDate = "01/01/2019";
            string Address = "";
            Address = Address.PadRight(49, 'a');
            string City = "Leicester";
            string PostCode = "LE5 0FH";
            //invoke the method
            OK = TestOrder.Valid(CustomerID, OrderID, DateAdded, OrderTotalPrice, SearchProduct, CardName, CardNumber, SecurityCode, ExpirationDate, Address, City, PostCode);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void AddressMax()
        {
            //create an instance of the class we want to create
            clsOrder TestOrder = new clsOrder();
            //boolean variable to store the result of the validation 
            Boolean OK = false;
            //create some test data to pass to the method
            string CustomerID = "5";
            string OrderID = "Iphone7";
            string DateAdded = Convert.ToString(DateTime.Now.Date);
            string OrderTotalPrice = "89";
            string SearchProduct = "Iphone6s";
            string CardName = "MR D CHRIS";
            string CardNumber = "1234567891234567";
            string SecurityCode = "619";
            string ExpirationDate = "01/01/2019";
            string Address = "";
            Address = Address.PadRight(50, 'a');
            string City = "Leicester";
            string PostCode = "LE5 0FH";
            //invoke the method
            OK = TestOrder.Valid(CustomerID, OrderID, DateAdded, OrderTotalPrice, SearchProduct, CardName, CardNumber, SecurityCode, ExpirationDate, Address, City, PostCode);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void AddressMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder TestOrder = new clsOrder();
            //boolean variable to store the result of the validation 
            Boolean OK = false;
            //create some test data to pass to the method
            string CustomerID = "5";
            string OrderID = "Iphone7";
            string DateAdded = "15/03/2017";
            string OrderTotalPrice = "89";
            string SearchProduct = "Iphone6s";
            string CardName = "MR D CHRIS";
            string CardNumber = "1234567891234567";
            string SecurityCode = "619";
            string ExpirationDate = "01/01/2019";
            string Address = "";
            Address = Address.PadRight(51, 'a');
            string City = "Leicester";
            string PostCode = "LE5 0FH";
            //invoke the method
            OK = TestOrder.Valid(CustomerID, OrderID, DateAdded, OrderTotalPrice, SearchProduct, CardName, CardNumber, SecurityCode, ExpirationDate, Address, City, PostCode);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }
        [TestMethod]
        public void AddressMid()
        {
            //create an instance of the class we want to create
            clsOrder TestOrder = new clsOrder();
            //boolean variable to store the result of the validation 
            Boolean OK = false;
            //create some test data to pass to the method
            string CustomerID = "5";
            string OrderID = "Iphone7";
            string DateAdded = Convert.ToString(DateTime.Now.Date);
            string OrderTotalPrice = "89";
            string SearchProduct = "Iphone6s";
            string CardName = "MR D CHRIS";
            string CardNumber = "1234567891234567";
            string SecurityCode = "619";
            string ExpirationDate = "01/01/2019";
            string Address = "";
            Address = Address.PadRight(25, 'a');
            string City = "Leicester";
            string PostCode = "LE5 0FH";
            //invoke the method
            OK = TestOrder.Valid(CustomerID, OrderID, DateAdded, OrderTotalPrice, SearchProduct, CardName, CardNumber, SecurityCode, ExpirationDate, Address, City, PostCode);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void CityMinLessOne()
        {
            //create an instance of the class we want to create
            clsOrder TestOrder = new clsOrder();
            //boolean variable to store the result of the validation 
            Boolean OK = false;
            //create some test data to pass to the method
            string CustomerID = "5";
            string OrderID = "Iphone7";
            string DateAdded = "15/03/2017";
            string OrderTotalPrice = "89";
            string SearchProduct = "Iphone6s";
            string CardName = "MR D CHRIS";
            string CardNumber = "1234567891234567";
            string SecurityCode = "619";
            string ExpirationDate = "01/01/2019";
            string Address = "135 Willow Street";
            string City = "";
            string PostCode = "LE5 0FH";
            //invoke the method
            OK = TestOrder.Valid(CustomerID, OrderID, DateAdded, OrderTotalPrice, SearchProduct, CardName, CardNumber, SecurityCode, ExpirationDate, Address, City, PostCode);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }
        [TestMethod]
        public void CityMin()
        {
            //create an instance of the class we want to create
            clsOrder TestOrder = new clsOrder();
            //boolean variable to store the result of the validation 
            Boolean OK = false;
            //create some test data to pass to the method
            string CustomerID = "5";
            string OrderID = "Iphone7";
            string DateAdded = Convert.ToString(DateTime.Now.Date);
            string OrderTotalPrice = "89";
            string SearchProduct = "Iphone6s";
            string CardName = "MR D CHRIS";
            string CardNumber = "1234567891234567";
            string SecurityCode = "619";
            string ExpirationDate = "01/01/2019";
            string Address = "135 Willow Street";
            string City = "a";
            string PostCode = "LE5 0FH";
            //invoke the method
            OK = TestOrder.Valid(CustomerID, OrderID, DateAdded, OrderTotalPrice, SearchProduct, CardName, CardNumber, SecurityCode, ExpirationDate, Address, City, PostCode);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void CityMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder TestOrder = new clsOrder();
            //boolean variable to store the result of the validation 
            Boolean OK = false;
            //create some test data to pass to the method
            string CustomerID = "5";
            string OrderID = "Iphone7";
            string DateAdded = Convert.ToString(DateTime.Now.Date);
            string OrderTotalPrice = "89";
            string SearchProduct = "Iphone6s";
            string CardName = "MR D CHRIS";
            string CardNumber = "1234567891234567";
            string SecurityCode = "619";
            string ExpirationDate = "01/01/2019";
            string Address = "135 Willow Streett";
            string City = "aa";
            string PostCode = "LE5 0FH";
            //invoke the method
            OK = TestOrder.Valid(CustomerID, OrderID, DateAdded, OrderTotalPrice, SearchProduct, CardName, CardNumber, SecurityCode, ExpirationDate, Address, City, PostCode);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void CityMaxLessOne()
        {
            //create an instance of the class we want to create
            clsOrder TestOrder = new clsOrder();
            //boolean variable to store the result of the validation 
            Boolean OK = false;
            //create some test data to pass to the method
            string CustomerID = "5";
            string OrderID = "Iphone7";
            string DateAdded = Convert.ToString(DateTime.Now.Date);
            string OrderTotalPrice = "89";
            string SearchProduct = "Iphone6s";
            string CardName = "MR D CHRIS";
            string CardNumber = "1234567891234567";
            string SecurityCode = "619";
            string ExpirationDate = "01/01/2019";
            string Address = "135 Willow Street";
            string City = "";
            City = City.PadRight(49, 'a');
            string PostCode = "LE5 0FH";
            //invoke the method
            OK = TestOrder.Valid(CustomerID, OrderID, DateAdded, OrderTotalPrice, SearchProduct, CardName, CardNumber, SecurityCode, ExpirationDate, Address, City, PostCode);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void CityMax()
        {
            //create an instance of the class we want to create
            clsOrder TestOrder = new clsOrder();
            //boolean variable to store the result of the validation 
            Boolean OK = false;
            //create some test data to pass to the method
            string CustomerID = "5";
            string OrderID = "Iphone7";
            string DateAdded = Convert.ToString(DateTime.Now.Date);
            string OrderTotalPrice = "89";
            string SearchProduct = "Iphone6s";
            string CardName = "MR D CHRIS";
            string CardNumber = "1234567891234567";
            string SecurityCode = "619";
            string ExpirationDate = "01/01/2019";
            string Address = "135 Willow Street";
            string City = "";
            City = City.PadRight(50, 'a');
            string PostCode = "LE5 0FH";
            //invoke the method
            OK = TestOrder.Valid(CustomerID, OrderID, DateAdded, OrderTotalPrice, SearchProduct, CardName, CardNumber, SecurityCode, ExpirationDate, Address, City, PostCode);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void CityMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder TestOrder = new clsOrder();
            //boolean variable to store the result of the validation 
            Boolean OK = false;
            //create some test data to pass to the method
            string CustomerID = "5";
            string OrderID = "Iphone7";
            string DateAdded = "15/03/2017";
            string OrderTotalPrice = "89";
            string SearchProduct = "Iphone6s";
            string CardName = "MR D CHRIS";
            string CardNumber = "1234567891234567";
            string SecurityCode = "619";
            string ExpirationDate = "01/01/2019";
            string Address = "135 Willow Street";
            string City = "";
            City = City.PadRight(51, 'a');
            string PostCode = "LE5 0FH";
            //invoke the method
            OK = TestOrder.Valid(CustomerID, OrderID, DateAdded, OrderTotalPrice, SearchProduct, CardName, CardNumber, SecurityCode, ExpirationDate, Address, City, PostCode);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }
        [TestMethod]
        public void CityMid()
        {
            //create an instance of the class we want to create
            clsOrder TestOrder = new clsOrder();
            //boolean variable to store the result of the validation 
            Boolean OK = false;
            //create some test data to pass to the method
            string CustomerID = "5";
            string OrderID = "Iphone7";
            string DateAdded = Convert.ToString(DateTime.Now.Date);
            string OrderTotalPrice = "89";
            string SearchProduct = "Iphone6s";
            string CardName = "MR D CHRIS";
            string CardNumber = "1234567891234567";
            string SecurityCode = "619";
            string ExpirationDate = "01/01/2019";
            string Address = "135 Willow Street";
            string City = "";
            City = City.PadRight(25, 'a');
            string PostCode = "LE5 0FH";
            //invoke the method
            OK = TestOrder.Valid(CustomerID, OrderID, DateAdded, OrderTotalPrice, SearchProduct, CardName, CardNumber, SecurityCode, ExpirationDate, Address, City, PostCode);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

    }
}

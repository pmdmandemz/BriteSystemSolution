using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyClassLib;

namespace MyTestUnit
{
    [TestClass]
    public class TstCustomer
    {
        [TestMethod]
        public void InstanceOK()
        {
            //Create an inst of the class 
            ClsCustomer ACustomer = new ClsCustomer();
            //test to see if this exist
            Assert.IsNotNull(ACustomer);
        }

        [TestMethod]
        public void ActiveOK()
        {
            //create an inst of the class we want to create
            ClsCustomer ACustomer = new ClsCustomer();
            //create some test data to assign to the prop
            Boolean TestData = true;
            //asign the data to the prop
            ACustomer.Active = TestData;
            //test top see that two vals are the same
            Assert.AreEqual(ACustomer.Active, TestData);
        }

        [TestMethod]
        public void Address1()
        {
            //create an inst of the class we want to create
            ClsCustomer ACustomer = new ClsCustomer();
            //create some test data to assign to the prop
            string TestData = "70 harrow road";
            //asign the data to the prop
            ACustomer.Address1 = TestData;
            //test top see that two vals are the same
            Assert.AreEqual(ACustomer.Address1, TestData);
        }

        [TestMethod]
        public void Address2()
        {
            //create an inst of the class we want to create
            ClsCustomer ACustomer = new ClsCustomer();
            //create some test data to assign to the prop
            string TestData = "Westcotes";
            //asign the data to the prop
            ACustomer.Address2 = TestData;
            //test top see that two vals are the same
            Assert.AreEqual(ACustomer.Address2, TestData);
        }

        [TestMethod]
        public void Address3()
        {
            //create an inst of the class we want to create
            ClsCustomer ACustomer = new ClsCustomer();
            //create some test data to assign to the prop
            string TestData = "sfhsifuhsfi";
            //asign the data to the prop
            ACustomer.Address3 = TestData;
            //test top see that two vals are the same
            Assert.AreEqual(ACustomer.Address3, TestData);
        }

        [TestMethod]
        public void City()
        {
            //create an inst of the class we want to create
            ClsCustomer ACustomer = new ClsCustomer();
            //create some test data to assign to the prop
            string TestData = "Leicester";
            //asign the data to the prop
            ACustomer.City = TestData;
            //test top see that two vals are the same
            Assert.AreEqual(ACustomer.City, TestData);
        }

        [TestMethod]
        public void Postcode()
        {
            //create an inst of the class we want to create
            ClsCustomer ACustomer = new ClsCustomer();
            //create some test data to assign to the prop
            string TestData = "LE3 0JW";
            //asign the data to the prop
            ACustomer.Postcode = TestData;
            //test top see that two vals are the same
            Assert.AreEqual(ACustomer.Postcode, TestData);
        }

        [TestMethod]
        public void Forename()
        {
            //create an inst of the class we want to create
            ClsCustomer ACustomer = new ClsCustomer();
            //create some test data to assign to the prop
            string TestData = "Vicki";
            //asign the data to the prop
            ACustomer.Forename = TestData;
            //test top see that two vals are the same
            Assert.AreEqual(ACustomer.Forename, TestData);
        }

        [TestMethod]
        public void Surname()
        {
            //create an inst of the class we want to create
            ClsCustomer ACustomer = new ClsCustomer();
            //create some test data to assign to the prop
            string TestData = "Bills";
            //asign the data to the prop
            ACustomer.Surname = TestData;
            //test top see that two vals are the same
            Assert.AreEqual(ACustomer.Surname, TestData);
        }

        [TestMethod]
        public void Tel()
        {
            //create an inst of the class we want to create
            ClsCustomer ACustomer = new ClsCustomer();
            //create some test data to assign to the prop
            string TestData = "07522819616";
            //asign the data to the prop
            ACustomer.Tel = TestData;
            //test top see that two vals are the same
            Assert.AreEqual(ACustomer.Tel, TestData);
        }

        [TestMethod]
        public void CustID()
        {
            //create an inst of the class we want to create
            ClsCustomer ACustomer = new ClsCustomer();
            //create some test data to assign to the prop
            Int32 TestData = 12345;
            //asign the data to the prop
            ACustomer.CustID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.CustID, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create an inst of the class we want to create
            ClsCustomer ACustomer = new ClsCustomer();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 CustID = 2;
            //invoke the method
            Found = ACustomer.Find(CustID);
            //Test to see the result is correct
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestCustomerIDFound()
        {
            //create an instance of the class we want to create
            ClsCustomer ACustomer = new ClsCustomer();
            //boolena variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is ok
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustID = 2;
            //invoke the method
            Found = ACustomer.Find(CustID);
            //check the customer id
            if (ACustomer.CustID != 2)
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
            ClsCustomer ACustomer = new ClsCustomer();
            //boolena variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is ok
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustID = 2;
            //invoke the method
            Found = ACustomer.Find(CustID);
            //check the porperty
            if (ACustomer.Active != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestAddress1Found()
        {
            //create an instance of the class we want to create
            ClsCustomer ACustomer = new ClsCustomer();
            //boolena variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is ok
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustID = 2;
            //invoke the method
            Found = ACustomer.Find(CustID);
            //check the property
            if (ACustomer.Address1 != "70 Harrow Road")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestAddress2Found()
        {
            //create an instance of the class we want to create
            ClsCustomer ACustomer = new ClsCustomer();
            //boolena variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is ok
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustID = 2;
            //invoke the method
            Found = ACustomer.Find(CustID);
            //check the porperty
            if (ACustomer.Address2 != "Westcotes")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestAddress3Found()
        {
            //create an instance of the class we want to create
            ClsCustomer ACustomer = new ClsCustomer();
            //boolena variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is ok
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustID = 2;
            //invoke the method
            Found = ACustomer.Find(CustID);
            //check the porperty
            if (ACustomer.Address3 != "wefrrgthterhyterj")
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
            ClsCustomer ACustomer = new ClsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is ok
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustID = 2;
            //invoke the method
            Found = ACustomer.Find(CustID);
            //check the porperty
            if (ACustomer.City != "TestCity")
            {
                OK = false;
            }
            //test to see the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestForenameFound()
        {
            //create an instance of the class we want to create
            ClsCustomer ACustomer = new ClsCustomer();
            //boolena variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is ok
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustID = 2;
            //invoke the method
            Found = ACustomer.Find(CustID);
            //check the porperty
            if (ACustomer.Forename != "TestForename")
            {
                OK = false;
            }
            //test to see the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestSurnameFound()
        {
            //create an instance of the class we want to create
            ClsCustomer ACustomer = new ClsCustomer();
            //boolena variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is ok
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustID = 2;
            //invoke the method
            Found = ACustomer.Find(CustID);
            //check the porperty
            if (ACustomer.Surname != "TestSurname")
            {
                OK = false;
            }
            //test to see the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPostcodeFound()
        {
            //create an instance of the class we want to create
            ClsCustomer ACustomer = new ClsCustomer();
            //boolena variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is ok
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustID = 2;
            //invoke the method
            Found = ACustomer.Find(CustID);
            //check the porperty
            if (ACustomer.Postcode != "LE3 2EU")
            {
                OK = false;
            }
            //test to see the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestTelFound()
        {
            //create an instance of the class we want to create
            ClsCustomer ACustomer = new ClsCustomer();
            //boolena variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is ok
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustID = 2;
            //invoke the method
            Found = ACustomer.Find(CustID);
            //check the porperty
            if (ACustomer.Tel != "07910453483")
            {
                OK = false;
            }
            //test to see the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            ClsCustomer ACustomer = new ClsCustomer();
            //boolean variable to store the results of the validation 
            Boolean OK = false;
            //create some test data to pass to the method
            String Address1 = "70 Harow Road";
            String Address2 = "Westcotes";
            String Address3 = "wefrrgthterhyterj";
            String City = "TestCity";
            String Forename = "TestForename";
            String Surname = "TestSurname";
            String Postcode = "LE3 2EU";
            String Tel = "07910453483";
            //invoke the method 
            OK = ACustomer.Valid(Address1, Address2, Address3, City, Forename, Surname, Postcode, Tel);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void Address1MinLessOne()
        {
            //create an instance of the class we cant to create 
            ClsCustomer ACustomer = new ClsCustomer();
            //boolean to store variable for the result of the validation
            Boolean OK = false;
            //create some test data to pass the result of the validation 
            String Address1 = "";//this should trigger an error
            String Address2 = "Westcotes";
            String Address3 = "wefrrgthterhyterj";
            String City = "TestCity";
            String Forename = "TestForename";
            String Surname = "TestSurname";
            String Postcode = "LE3 2EU";
            String Tel = "07910453483";
            //inovoke the method
            OK = ACustomer.Valid(Address1, Address2, Address3, City, Forename, Surname, Postcode, Tel);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }


        [TestMethod]
        public void Address1Min()
        {
            //create an instance of the class we cant to create 
            ClsCustomer ACustomer = new ClsCustomer();
            //boolean to store variable for the result of the validation
            Boolean OK = false;
            //create some test data to pass the result of the validation 
            String Address1 = "c";
            String Address2 = "Westcotes";
            String Address3 = "wefrrgthterhyterj";
            String City = "TestCity";
            String Forename = "TestForename";
            String Surname = "TestSurname";
            String Postcode = "LE3 2EU";
            String Tel = "07910453483";
            //inovoke the method
            OK = ACustomer.Valid(Address1, Address2, Address3, City, Forename, Surname, Postcode, Tel);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void Address1MinPlusOne()
        {
            //create an instance of the class we cant to create 
            ClsCustomer ACustomer = new ClsCustomer();
            //boolean to store variable for the result of the validation
            Boolean OK = false;
            //create some test data to pass the result of the validation 
            String Address1 = "xc";
            String Address2 = "Westcotes";
            String Address3 = "wefrrgthterhyterj";
            String City = "TestCity";
            String Forename = "TestForename";
            String Surname = "TestSurname";
            String Postcode = "LE3 2EU";
            String Tel = "07910453483";
            //inovoke the method
            OK = ACustomer.Valid(Address1, Address2, Address3, City, Forename, Surname, Postcode, Tel);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void Address1MaxLessOne()
        {
            //create an instance of the class we cant to create 
            ClsCustomer ACustomer = new ClsCustomer();
            //boolean to store variable for the result of the validation
            Boolean OK = false;
            //create some test data to pass the result of the validation 
            String Address1 = "awswswswswswswswswswawswswswswswswswswsweeeeeeeee"; // 49 characters
            String Address2 = "Westcotes";
            String Address3 = "wefrrgthterhyterj";
            String City = "TestCity";
            String Forename = "TestForename";
            String Surname = "TestSurname";
            String Postcode = "LE3 2EU";
            String Tel = "07910453483";
            //inovoke the method
            OK = ACustomer.Valid(Address1, Address2, Address3, City, Forename, Surname, Postcode, Tel);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void Address1Max()
        {
            //create an instance of the class we cant to create 
            ClsCustomer ACustomer = new ClsCustomer();
            //boolean to store variable for the result of the validation
            Boolean OK = false;
            //create some test data to pass the result of the validation 
            String Address1 = "awswswswswswswswswswawswswswswswswswswsweweeeeeeee"; // 50 characters
            String Address2 = "Westcotes";
            String Address3 = "wefrrgthterhyterj";
            String City = "TestCity";
            String Forename = "TestForename";
            String Surname = "TestSurname";
            String Postcode = "LE3 2EU";
            String Tel = "07910453483";
            //inovoke the method
            OK = ACustomer.Valid(Address1, Address2, Address3, City, Forename, Surname, Postcode, Tel);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void Address1Mid()
        {
            //create an instance of the class we cant to create 
            ClsCustomer ACustomer = new ClsCustomer();
            //boolean to store variable for the result of the validation
            Boolean OK = false;
            //create some test data to pass the result of the validation 
            String Address1 = "awswawswswawswswswswwswsw"; // 25 characters
            String Address2 = "Westcotes";
            String Address3 = "wefrrgthterhyterj";
            String City = "TestCity";
            String Forename = "TestForename";
            String Surname = "TestSurname";
            String Postcode = "LE3 2EU";
            String Tel = "07910453483";
            //inovoke the method
            OK = ACustomer.Valid(Address1, Address2, Address3, City, Forename, Surname, Postcode, Tel);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void Address1MaxPlusOne()
        {
            //create an instance of the class we cant to create 
            ClsCustomer ACustomer = new ClsCustomer();
            //boolean to store variable for the result of the validation
            Boolean OK = false;
            //create some test data to pass the result of the validation 
            String Address1 = "";
            Address1.PadRight(50, 'a'); // this should fail 
            String Address2 = "Westcotes";
            String Address3 = "wefrrgthterhyterj";
            String City = "TestCity";
            String Forename = "TestForename";
            String Surname = "TestSurname";
            String Postcode = "LE3 2EU";
            String Tel = "07910453483";
            //inovoke the method
            OK = ACustomer.Valid(Address1, Address2, Address3, City, Forename, Surname, Postcode, Tel);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }


        [TestMethod]
        public void Address1ExtremeMax()
        {
            //create an instance of the class we cant to create 
            ClsCustomer ACustomer = new ClsCustomer();
            //boolean to store variable for the result of the validation
            Boolean OK = false;
            //create some test data to pass the result of the validation 
            String Address1 = "";
            Address1.PadRight(1000, 'a'); // this should fail 
            String Address2 = "Westcotes";
            String Address3 = "wefrrgthterhyterj";
            String City = "TestCity";
            String Forename = "TestForename";
            String Surname = "TestSurname";
            String Postcode = "LE3 2EU";
            String Tel = "07910453483";
            //inovoke the method
            OK = ACustomer.Valid(Address1, Address2, Address3, City, Forename, Surname, Postcode, Tel);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void Address2MinLessOne()
        {
            //create an instance of the class we cant to create 
            ClsCustomer ACustomer = new ClsCustomer();
            //boolean to store variable for the result of the validation
            Boolean OK = false;
            //create some test data to pass the result of the validation 
            String Address1 = "70 harror road";
            String Address2 = "";//this should triggar an error
            String Address3 = "wefrrgthterhyterj";
            String City = "TestCity";
            String Forename = "TestForename";
            String Surname = "TestSurname";
            String Postcode = "LE3 2EU";
            String Tel = "07910453483";
            //inovoke the method
            OK = ACustomer.Valid(Address1, Address2, Address3, City, Forename, Surname, Postcode, Tel);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }


        [TestMethod]
        public void Address2Min()
        {
            //create an instance of the class we cant to create 
            ClsCustomer ACustomer = new ClsCustomer();
            //boolean to store variable for the result of the validation
            Boolean OK = false;
            //create some test data to pass the result of the validation 
            String Address1 = "70 Harror Road";
            String Address2 = "a";
            String Address3 = "wefrrgthterhyterj";
            String City = "TestCity";
            String Forename = "TestForename";
            String Surname = "TestSurname";
            String Postcode = "LE3 2EU";
            String Tel = "07910453483";
            //inovoke the method
            OK = ACustomer.Valid(Address1, Address2, Address3, City, Forename, Surname, Postcode, Tel);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void Address2MinPlusOne()
        {
            //create an instance of the class we cant to create 
            ClsCustomer ACustomer = new ClsCustomer();
            //boolean to store variable for the result of the validation
            Boolean OK = false;
            //create some test data to pass the result of the validation 
            String Address1 = "70 Harrow road";
            String Address2 = "xc";
            String Address3 = "wefrrgthterhyterj";
            String City = "TestCity";
            String Forename = "TestForename";
            String Surname = "TestSurname";
            String Postcode = "LE3 2EU";
            String Tel = "07910453483";
            //inovoke the method
            OK = ACustomer.Valid(Address1, Address2, Address3, City, Forename, Surname, Postcode, Tel);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void Address2MaxLessOne()
        {
            //create an instance of the class we cant to create 
            ClsCustomer ACustomer = new ClsCustomer();
            //boolean to store variable for the result of the validation
            Boolean OK = false;
            //create some test data to pass the result of the validation 
            String Address1 = "70 Harrow Road"; 
            String Address2 = "awswswswswswswswswswawswswswswswswswswsweeeeeeeee"; // 49 characters
            String Address3 = "wefrrgthterhyterj";
            String City = "TestCity";
            String Forename = "TestForename";
            String Surname = "TestSurname";
            String Postcode = "LE3 2EU";
            String Tel = "07910453483";
            //inovoke the method
            OK = ACustomer.Valid(Address1, Address2, Address3, City, Forename, Surname, Postcode, Tel);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void Address2Max()
        {
            //create an instance of the class we cant to create 
            ClsCustomer ACustomer = new ClsCustomer();
            //boolean to store variable for the result of the validation
            Boolean OK = false;
            //create some test data to pass the result of the validation 
            String Address1 = "70 Harrow Road"; 
            String Address2 = "awswswswswswswswswswawswswswswswswswswsweweeeeeeee"; // 50 characters
            String Address3 = "wefrrgthterhyterj";
            String City = "TestCity";
            String Forename = "TestForename";
            String Surname = "TestSurname";
            String Postcode = "LE3 2EU";
            String Tel = "07910453483";
            //inovoke the method
            OK = ACustomer.Valid(Address1, Address2, Address3, City, Forename, Surname, Postcode, Tel);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void Address2Mid()
        {
            //create an instance of the class we cant to create 
            ClsCustomer ACustomer = new ClsCustomer();
            //boolean to store variable for the result of the validation
            Boolean OK = false;
            //create some test data to pass the result of the validation 
            String Address1 = "70 Harrow road"; 
            String Address2 = "awswawswswawswswswswwswsw";// 25 characters
            String Address3 = "wefrrgthterhyterj";
            String City = "TestCity";
            String Forename = "TestForename";
            String Surname = "TestSurname";
            String Postcode = "LE3 2EU";
            String Tel = "07910453483";
            //inovoke the method
            OK = ACustomer.Valid(Address1, Address2, Address3, City, Forename, Surname, Postcode, Tel);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void Address2MaxPlusOne()
        {
            //create an instance of the class we cant to create 
            ClsCustomer ACustomer = new ClsCustomer();
            //boolean to store variable for the result of the validation
            Boolean OK = false;
            //create some test data to pass the result of the validation 
            String Address1 = "70 harrow road";
            String Address2 = "";
            Address2.PadRight(51, 'a'); // this should fail 
            String Address3 = "wefrrgthterhyterj";
            String City = "TestCity";
            String Forename = "TestForename";
            String Surname = "TestSurname";
            String Postcode = "LE3 2EU";
            String Tel = "07910453483";
            //inovoke the method
            OK = ACustomer.Valid(Address1, Address2, Address3, City, Forename, Surname, Postcode, Tel);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }


        [TestMethod]
        public void Address2ExtremeMax()
        {
            //create an instance of the class we cant to create 
            ClsCustomer ACustomer = new ClsCustomer();
            //boolean to store variable for the result of the validation
            Boolean OK = false;
            //create some test data to pass the result of the validation 
            String Address1 = "70 Harrow Road";
            String Address2 = "";
            Address2.PadRight(10000, 'a'); // this should fail
            String Address3 = "wefrrgthterhyterj";
            String City = "TestCity";
            String Forename = "TestForename";
            String Surname = "TestSurname";
            String Postcode = "LE3 2EU";
            String Tel = "07910453483";
            //inovoke the method
            OK = ACustomer.Valid(Address1, Address2, Address3, City, Forename, Surname, Postcode, Tel);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void Address3MinLessOne()
        {
            //create an instance of the class we cant to create 
            ClsCustomer ACustomer = new ClsCustomer();
            //boolean to store variable for the result of the validation
            Boolean OK = false;
            //create some test data to pass the result of the validation 
            String Address1 = "70 harror road";
            String Address2 = "Westcotes";
            String Address3 = "";//this should triggar an error
            String City = "TestCity";
            String Forename = "TestForename";
            String Surname = "TestSurname";
            String Postcode = "LE3 2EU";
            String Tel = "07910453483";
            //inovoke the method
            OK = ACustomer.Valid(Address1, Address2, Address3, City, Forename, Surname, Postcode, Tel);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }


        [TestMethod]
        public void Address3Min()
        {
            //create an instance of the class we cant to create 
            ClsCustomer ACustomer = new ClsCustomer();
            //boolean to store variable for the result of the validation
            Boolean OK = false;
            //create some test data to pass the result of the validation 
            String Address1 = "70 Harror Road";
            String Address2 = "Westcotes";
            String Address3 = "a";
            String City = "TestCity";
            String Forename = "TestForename";
            String Surname = "TestSurname";
            String Postcode = "LE3 2EU";
            String Tel = "07910453483";
            //inovoke the method
            OK = ACustomer.Valid(Address1, Address2, Address3, City, Forename, Surname, Postcode, Tel);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void Address3MinPlusOne()
        {
            //create an instance of the class we cant to create 
            ClsCustomer ACustomer = new ClsCustomer();
            //boolean to store variable for the result of the validation
            Boolean OK = false;
            //create some test data to pass the result of the validation 
            String Address1 = "70 Harrow road";
            String Address2 = "Westcotes";
            String Address3 = "xc";
            String City = "TestCity";
            String Forename = "TestForename";
            String Surname = "TestSurname";
            String Postcode = "LE3 2EU";
            String Tel = "07910453483";
            //inovoke the method
            OK = ACustomer.Valid(Address1, Address2, Address3, City, Forename, Surname, Postcode, Tel);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void Address3MaxLessOne()
        {
            //create an instance of the class we cant to create 
            ClsCustomer ACustomer = new ClsCustomer();
            //boolean to store variable for the result of the validation
            Boolean OK = false;
            //create some test data to pass the result of the validation 
            String Address1 = "70 Harrow Road";
            String Address2 = "Westcotes"; 
            String Address3 = "awswswswswswswswswswawswswswswswswswswsweeeeeeeee"; // 49 characters
            String City = "TestCity";
            String Forename = "TestForename";
            String Surname = "TestSurname";
            String Postcode = "LE3 2EU";
            String Tel = "07910453483";
            //inovoke the method
            OK = ACustomer.Valid(Address1, Address2, Address3, City, Forename, Surname, Postcode, Tel);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void Address3Max()
        {
            //create an instance of the class we cant to create 
            ClsCustomer ACustomer = new ClsCustomer();
            //boolean to store variable for the result of the validation
            Boolean OK = false;
            //create some test data to pass the result of the validation 
            String Address1 = "70 Harrow Road"; 
            String Address2 = "Westcotes";
            String Address3 = "awswswswswswswswswswawswswswswswswswswsweweeeeeeee"; // 50 characters
            String City = "TestCity";
            String Forename = "TestForename";
            String Surname = "TestSurname";
            String Postcode = "LE3 2EU";
            String Tel = "07910453483";
            //inovoke the method
            OK = ACustomer.Valid(Address1, Address2, Address3, City, Forename, Surname, Postcode, Tel);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void Address3Mid()
        {
            //create an instance of the class we cant to create 
            ClsCustomer ACustomer = new ClsCustomer();
            //boolean to store variable for the result of the validation
            Boolean OK = false;
            //create some test data to pass the result of the validation 
            String Address1 = "70 Harrow road";
            String Address2 = "Westcotes";
            String Address3 = "awswawswswawswswswswwswsw"; // 25 characters
            String City = "TestCity";
            String Forename = "TestForename";
            String Surname = "TestSurname";
            String Postcode = "LE3 2EU";
            String Tel = "07910453483";
            //inovoke the method
            OK = ACustomer.Valid(Address1, Address2, Address3, City, Forename, Surname, Postcode, Tel);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void Address3MaxPlusOne()
        {
            //create an instance of the class we cant to create 
            ClsCustomer ACustomer = new ClsCustomer();
            //boolean to store variable for the result of the validation
            Boolean OK = false;
            //create some test data to pass the result of the validation 
            String Address1 = "70 harrow road";
            String Address2 = "Westcotes";
            String Address3 = "";
            Address3.PadRight(51, 'a'); // this should fail 
            String City = "TestCity";
            String Forename = "TestForename";
            String Surname = "TestSurname";
            String Postcode = "LE3 2EU";
            String Tel = "07910453483";
            //inovoke the method
            OK = ACustomer.Valid(Address1, Address2, Address3, City, Forename, Surname, Postcode, Tel);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }


        [TestMethod]
        public void Address3ExtremeMax()
        {
            //create an instance of the class we cant to create 
            ClsCustomer ACustomer = new ClsCustomer();
            //boolean to store variable for the result of the validation
            Boolean OK = false;
            //create some test data to pass the result of the validation 
            String Address1 = "70 Harrow Road";
            String Address2 = "Westcotes";
            String Address3 = "";
            Address3.PadRight(10000, 'a'); // this should fail
            String City = "TestCity";
            String Forename = "TestForename";
            String Surname = "TestSurname";
            String Postcode = "LE3 2EU";
            String Tel = "07910453483";
            //inovoke the method
            OK = ACustomer.Valid(Address1, Address2, Address3, City, Forename, Surname, Postcode, Tel);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }


        [TestMethod]
        public void CityMinLessOne()
        {
            //create an instance of the class we cant to create 
            ClsCustomer ACustomer = new ClsCustomer();
            //boolean to store variable for the result of the validation
            Boolean OK = false;
            //create some test data to pass the result of the validation 
            String Address1 = "70 harror road";
            String Address2 = "Westcotes";
            String Address3 = "";
            String City = ""; //this should triggar an error
            String Forename = "TestForename";
            String Surname = "TestSurname";
            String Postcode = "LE3 2EU";
            String Tel = "07910453483";
            //inovoke the method
            OK = ACustomer.Valid(Address1, Address2, Address3, City, Forename, Surname, Postcode, Tel);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }


        [TestMethod]
        public void CityMin()
        {
            //create an instance of the class we cant to create 
            ClsCustomer ACustomer = new ClsCustomer();
            //boolean to store variable for the result of the validation
            Boolean OK = false;
            //create some test data to pass the result of the validation 
            String Address1 = "70 Harror Road";
            String Address2 = "Westcotes";
            String Address3 = "wefrrgthterhyterj";
            String City = "c";
            String Forename = "TestForename";
            String Surname = "TestSurname";
            String Postcode = "LE3 2EU";
            String Tel = "07910453483";
            //inovoke the method
            OK = ACustomer.Valid(Address1, Address2, Address3, City, Forename, Surname, Postcode, Tel);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void CityMinPlusOne()
        {
            //create an instance of the class we cant to create 
            ClsCustomer ACustomer = new ClsCustomer();
            //boolean to store variable for the result of the validation
            Boolean OK = false;
            //create some test data to pass the result of the validation 
            String Address1 = "70 Harrow road";
            String Address2 = "Westcotes";
            String Address3 = "wefrrgthterhyterj";
            String City = "hg";
            String Forename = "TestForename";
            String Surname = "TestSurname";
            String Postcode = "LE3 2EU";
            String Tel = "07910453483";
            //inovoke the method
            OK = ACustomer.Valid(Address1, Address2, Address3, City, Forename, Surname, Postcode, Tel);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void CityMaxLessOne()
        {
            //create an instance of the class we cant to create 
            ClsCustomer ACustomer = new ClsCustomer();
            //boolean to store variable for the result of the validation
            Boolean OK = false;
            //create some test data to pass the result of the validation 
            String Address1 = "70 Harrow Road";
            String Address2 = "Westcotes";
            String Address3 = "wefrrgthterhyterj";
            String City = "awsedrfes"; // 9 char
            String Forename = "TestForename";
            String Surname = "TestSurname";
            String Postcode = "LE3 2EU";
            String Tel = "07910453483";
            //inovoke the method
            OK = ACustomer.Valid(Address1, Address2, Address3, City, Forename, Surname, Postcode, Tel);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void CityMax()
        {
            //create an instance of the class we cant to create 
            ClsCustomer ACustomer = new ClsCustomer();
            //boolean to store variable for the result of the validation
            Boolean OK = false;
            //create some test data to pass the result of the validation 
            String Address1 = "70 Harrow Road";
            String Address2 = "Westcotes";
            String Address3 = "wefrrgthterhyterj";
            String City = "awswsededewsedrfredr"; // 20 char
            String Forename = "TestForename";
            String Surname = "TestSurname";
            String Postcode = "LE3 2EU";
            String Tel = "07910453483";
            //inovoke the method
            OK = ACustomer.Valid(Address1, Address2, Address3, City, Forename, Surname, Postcode, Tel);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void CityMid()
        {
            //create an instance of the class we cant to create 
            ClsCustomer ACustomer = new ClsCustomer();
            //boolean to store variable for the result of the validation
            Boolean OK = false;
            //create some test data to pass the result of the validation 
            String Address1 = "70 Harrow road";
            String Address2 = "Westcotes";
            String Address3 = "wefrrgthterhyterj"; 
            String City = "awswswsedr"; //10 char
            String Forename = "TestForename";
            String Surname = "TestSurname";
            String Postcode = "LE3 2EU";
            String Tel = "07910453483";
            //inovoke the method
            OK = ACustomer.Valid(Address1, Address2, Address3, City, Forename, Surname, Postcode, Tel);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void CityMaxPlusOne()
        {
            //create an instance of the class we cant to create 
            ClsCustomer ACustomer = new ClsCustomer();
            //boolean to store variable for the result of the validation
            Boolean OK = false;
            //create some test data to pass the result of the validation 
            String Address1 = "70 harrow road";
            String Address2 = "Westcotes";
            String Address3 = "wefrrgthterhyterj";
            String City = "";
            City.PadRight(21, 'a'); // this should fail 
            String Forename = "TestForename";
            String Surname = "TestSurname";
            String Postcode = "LE3 2EU";
            String Tel = "07910453483";
            //inovoke the method
            OK = ACustomer.Valid(Address1, Address2, Address3, City, Forename, Surname, Postcode, Tel);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }


        [TestMethod]
        public void CityExtremeMax()
        {
            //create an instance of the class we cant to create 
            ClsCustomer ACustomer = new ClsCustomer();
            //boolean to store variable for the result of the validation
            Boolean OK = false;
            //create some test data to pass the result of the validation 
            String Address1 = "70 Harrow Road";
            String Address2 = "Westcotes";
            String Address3 = "wefrrgthterhyterj";
            String City = "";
            City.PadRight(50, 'a'); // this should fail
            String Forename = "TestForename";
            String Surname = "TestSurname";
            String Postcode = "LE3 2EU";
            String Tel = "07910453483";
            //inovoke the method
            OK = ACustomer.Valid(Address1, Address2, Address3, City, Forename, Surname, Postcode, Tel);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void ForenameMinLessOne()
        {
            //create an instance of the class we cant to create 
            ClsCustomer ACustomer = new ClsCustomer();
            //boolean to store variable for the result of the validation
            Boolean OK = false;
            //create some test data to pass the result of the validation 
            String Address1 = "70 harror road";
            String Address2 = "Westcotes";
            String Address3 = "wefrrgthterhyterj";
            String City = "TestCity";
            String Forename = ""; // this should trigger an error
            String Surname = "TestSurname";
            String Postcode = "LE3 2EU";
            String Tel = "07910453483";
            //inovoke the method
            OK = ACustomer.Valid(Address1, Address2, Address3, City, Forename, Surname, Postcode, Tel);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }


        [TestMethod]
        public void ForenameMin()
        {
            //create an instance of the class we cant to create 
            ClsCustomer ACustomer = new ClsCustomer();
            //boolean to store variable for the result of the validation
            Boolean OK = false;
            //create some test data to pass the result of the validation 
            String Address1 = "70 Harror Road";
            String Address2 = "Westcotes";
            String Address3 = "wefrrgthterhyterj";
            String City = "TestCity";
            String Forename = "a";
            String Surname = "TestSurname";
            String Postcode = "LE3 2EU";
            String Tel = "07910453483";
            //inovoke the method
            OK = ACustomer.Valid(Address1, Address2, Address3, City, Forename, Surname, Postcode, Tel);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ForenameMinPlusOne()
        {
            //create an instance of the class we cant to create 
            ClsCustomer ACustomer = new ClsCustomer();
            //boolean to store variable for the result of the validation
            Boolean OK = false;
            //create some test data to pass the result of the validation 
            String Address1 = "70 Harrow road";
            String Address2 = "Westcotes";
            String Address3 = "wefrrgthterhyterj";
            String City = "TestCity";
            String Forename = "hg";
            String Surname = "TestSurname";
            String Postcode = "LE3 2EU";
            String Tel = "07910453483";
            //inovoke the method
            OK = ACustomer.Valid(Address1, Address2, Address3, City, Forename, Surname, Postcode, Tel);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ForenameMaxLessOne()
        {
            //create an instance of the class we cant to create 
            ClsCustomer ACustomer = new ClsCustomer();
            //boolean to store variable for the result of the validation
            Boolean OK = false;
            //create some test data to pass the result of the validation 
            String Address1 = "70 Harrow Road";
            String Address2 = "Westcotes";
            String Address3 = "wefrrgthterhyterj";
            String City = "TestCity";
            String Forename = "awsedrfrdeswawsedrfeawse"; //24 char
            String Surname = "TestSurname";
            String Postcode = "LE3 2EU";
            String Tel = "07910453483";
            //inovoke the method
            OK = ACustomer.Valid(Address1, Address2, Address3, City, Forename, Surname, Postcode, Tel);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ForenameMax()
        {
            //create an instance of the class we cant to create 
            ClsCustomer ACustomer = new ClsCustomer();
            //boolean to store variable for the result of the validation
            Boolean OK = false;
            //create some test data to pass the result of the validation 
            String Address1 = "70 Harrow Road";
            String Address2 = "Westcotes";
            String Address3 = "wefrrgthterhyterj";
            String City = "TestCity";
            String Forename = "awsedrfrdeswawsedrfeawsed"; //25 char
            String Surname = "TestSurname";
            String Postcode = "LE3 2EU";
            String Tel = "07910453483";
            //inovoke the method
            OK = ACustomer.Valid(Address1, Address2, Address3, City, Forename, Surname, Postcode, Tel);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ForenameMid()
        {
            //create an instance of the class we cant to create 
            ClsCustomer ACustomer = new ClsCustomer();
            //boolean to store variable for the result of the validation
            Boolean OK = false;
            //create some test data to pass the result of the validation 
            String Address1 = "70 Harrow road";
            String Address2 = "Westcotes";
            String Address3 = "wefrrgthterhyterj";
            String City = "TextCity";
            String Forename = "awsedredredsw"; //13 char
            String Surname = "TestSurname";
            String Postcode = "LE3 2EU";
            String Tel = "07910453483";
            //inovoke the method
            OK = ACustomer.Valid(Address1, Address2, Address3, City, Forename, Surname, Postcode, Tel);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ForenameMaxPlusOne()
        {
            //create an instance of the class we cant to create 
            ClsCustomer ACustomer = new ClsCustomer();
            //boolean to store variable for the result of the validation
            Boolean OK = false;
            //create some test data to pass the result of the validation 
            String Address1 = "70 harrow road";
            String Address2 = "Westcotes";
            String Address3 = "wefrrgthterhyterj";
            String City = "TestCity";
            String Forename = "";
            Forename.PadRight(26, 'a'); // this should fail 
            String Surname = "TestSurname";
            String Postcode = "LE3 2EU";
            String Tel = "07910453483";
            //inovoke the method
            OK = ACustomer.Valid(Address1, Address2, Address3, City, Forename, Surname, Postcode, Tel);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }


        [TestMethod]
        public void ForenameExtremeMax()
        {
            //create an instance of the class we cant to create 
            ClsCustomer ACustomer = new ClsCustomer();
            //boolean to store variable for the result of the validation
            Boolean OK = false;
            //create some test data to pass the result of the validation 
            String Address1 = "70 Harrow Road";
            String Address2 = "Westcotes";
            String Address3 = "wefrrgthterhyterj";
            String City = "TestCity";
            String Forename = "";
            Forename.PadRight(50, 'a'); // this should fail
            String Surname = "TestSurname";
            String Postcode = "LE3 2EU";
            String Tel = "07910453483";
            //inovoke the method
            OK = ACustomer.Valid(Address1, Address2, Address3, City, Forename, Surname, Postcode, Tel);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void SurenameMinLessOne()
        {
            //create an instance of the class we cant to create 
            ClsCustomer ACustomer = new ClsCustomer();
            //boolean to store variable for the result of the validation
            Boolean OK = false;
            //create some test data to pass the result of the validation 
            String Address1 = "70 harror road";
            String Address2 = "Westcotes";
            String Address3 = "wefrrgthterhyterj";
            String City = "TestCity";
            String Forename = "TestForename"; 
            String Surname = "";// this should trigger an error
            String Postcode = "LE3 2EU";
            String Tel = "07910453483";
            //inovoke the method
            OK = ACustomer.Valid(Address1, Address2, Address3, City, Forename, Surname, Postcode, Tel);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }


        [TestMethod]
        public void SurnameMin()
        {
            //create an instance of the class we cant to create 
            ClsCustomer ACustomer = new ClsCustomer();
            //boolean to store variable for the result of the validation
            Boolean OK = false;
            //create some test data to pass the result of the validation 
            String Address1 = "70 Harror Road";
            String Address2 = "Westcotes";
            String Address3 = "wefrrgthterhyterj";
            String City = "TestCity";
            String Forename = "TestForname";
            String Surname = "a";
            String Postcode = "LE3 2EU";
            String Tel = "07910453483";
            //inovoke the method
            OK = ACustomer.Valid(Address1, Address2, Address3, City, Forename, Surname, Postcode, Tel);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void SurnameMinPlusOne()
        {
            //create an instance of the class we cant to create 
            ClsCustomer ACustomer = new ClsCustomer();
            //boolean to store variable for the result of the validation
            Boolean OK = false;
            //create some test data to pass the result of the validation 
            String Address1 = "70 Harrow road";
            String Address2 = "Westcotes";
            String Address3 = "wefrrgthterhyterj";
            String City = "TestCity";
            String Forename = "TestForename";
            String Surname = "hh";
            String Postcode = "LE3 2EU";
            String Tel = "07910453483";
            //inovoke the method
            OK = ACustomer.Valid(Address1, Address2, Address3, City, Forename, Surname, Postcode, Tel);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void SurnameMaxLessOne()
        {
            //create an instance of the class we cant to create 
            ClsCustomer ACustomer = new ClsCustomer();
            //boolean to store variable for the result of the validation
            Boolean OK = false;
            //create some test data to pass the result of the validation 
            String Address1 = "70 Harrow Road";
            String Address2 = "Westcotes";
            String Address3 = "wefrrgthterhyterj";
            String City = "TestCity";
            String Forename = "TestForename"; 
            String Surname = "awsedrfrdeswawsedrfeawse"; //24 char
            String Postcode = "LE3 2EU";
            String Tel = "07910453483";
            //inovoke the method
            OK = ACustomer.Valid(Address1, Address2, Address3, City, Forename, Surname, Postcode, Tel);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void SurnameMax()
        {
            //create an instance of the class we cant to create 
            ClsCustomer ACustomer = new ClsCustomer();
            //boolean to store variable for the result of the validation
            Boolean OK = false;
            //create some test data to pass the result of the validation 
            String Address1 = "70 Harrow Road";
            String Address2 = "Westcotes";
            String Address3 = "wefrrgthterhyterj";
            String City = "TestCity";
            String Forename = "TestForename"; 
            String Surname = "awsedrfrdeswawsedrfeawsed"; //25 char
            String Postcode = "LE3 2EU";
            String Tel = "07910453483";
            //inovoke the method
            OK = ACustomer.Valid(Address1, Address2, Address3, City, Forename, Surname, Postcode, Tel);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void SurnameMid()
        {
            //create an instance of the class we cant to create 
            ClsCustomer ACustomer = new ClsCustomer();
            //boolean to store variable for the result of the validation
            Boolean OK = false;
            //create some test data to pass the result of the validation 
            String Address1 = "70 Harrow road";
            String Address2 = "Westcotes";
            String Address3 = "wefrrgthterhyterj";
            String City = "TextCity";
            String Forename = "TestSurename";
            String Surname = "awsdedededesw"; //13 char
            String Postcode = "LE3 2EU";
            String Tel = "07910453483";
            //inovoke the method
            OK = ACustomer.Valid(Address1, Address2, Address3, City, Forename, Surname, Postcode, Tel);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void SurnameMaxPlusOne()
        {
            //create an instance of the class we cant to create 
            ClsCustomer ACustomer = new ClsCustomer();
            //boolean to store variable for the result of the validation
            Boolean OK = false;
            //create some test data to pass the result of the validation 
            String Address1 = "70 harrow road";
            String Address2 = "Westcotes";
            String Address3 = "wefrrgthterhyterj";
            String City = "TestCity";
            String Forename = "TestForename";
            String Surname = "";
            Forename.PadRight(26, 'a'); // this should fail 
            String Postcode = "LE3 2EU";
            String Tel = "07910453483";
            //inovoke the method
            OK = ACustomer.Valid(Address1, Address2, Address3, City, Forename, Surname, Postcode, Tel);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }


        [TestMethod]
        public void SurnameExtremeMax()
        {
            //create an instance of the class we cant to create 
            ClsCustomer ACustomer = new ClsCustomer();
            //boolean to store variable for the result of the validation
            Boolean OK = false;
            //create some test data to pass the result of the validation 
            String Address1 = "70 Harrow Road";
            String Address2 = "Westcotes";
            String Address3 = "wefrrgthterhyterj";
            String City = "TestCity";
            String Forename = "TestForename";
            String Surname = "";
            Surname.PadRight(50, 'a'); // this should fail
            String Postcode = "LE3 2EU";
            String Tel = "07910453483";
            //inovoke the method
            OK = ACustomer.Valid(Address1, Address2, Address3, City, Forename, Surname, Postcode, Tel);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void PostcodeMinLessOne()
        {
            //create an instance of the class we cant to create 
            ClsCustomer ACustomer = new ClsCustomer();
            //boolean to store variable for the result of the validation
            Boolean OK = false;
            //create some test data to pass the result of the validation 
            String Address1 = "70 harror road";
            String Address2 = "Westcotes";
            String Address3 = "wefrrgthterhyterj";
            String City = "TestCity";
            String Forename = "TestForename";
            String Surname = "TestSurname";
            String Postcode = "";//this should trigger an error
            String Tel = "07910453483";
            //inovoke the method
            OK = ACustomer.Valid(Address1, Address2, Address3, City, Forename, Surname, Postcode, Tel);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }


        [TestMethod]
        public void PostcodeMin()
        {
            //create an instance of the class we cant to create 
            ClsCustomer ACustomer = new ClsCustomer();
            //boolean to store variable for the result of the validation
            Boolean OK = false;
            //create some test data to pass the result of the validation 
            String Address1 = "70 Harror Road";
            String Address2 = "Westcotes";
            String Address3 = "wefrrgthterhyterj";
            String City = "TestCity";
            String Forename = "TestForname";
            String Surname = "TestSurename";
            String Postcode = "x";
            String Tel = "07910453483";
            //inovoke the method
            OK = ACustomer.Valid(Address1, Address2, Address3, City, Forename, Surname, Postcode, Tel);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void PostcodeMinPlusOne()
        {
            //create an instance of the class we cant to create 
            ClsCustomer ACustomer = new ClsCustomer();
            //boolean to store variable for the result of the validation
            Boolean OK = false;
            //create some test data to pass the result of the validation 
            String Address1 = "70 Harrow road";
            String Address2 = "Westcotes";
            String Address3 = "wefrrgthterhyterj";
            String City = "TestCity";
            String Forename = "TestForename";
            String Surname = "TestSurname";
            String Postcode = "aa";
            String Tel = "07910453483";
            //inovoke the method
            OK = ACustomer.Valid(Address1, Address2, Address3, City, Forename, Surname, Postcode, Tel);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void PostcodeMaxLessOne()
        {
            //create an instance of the class we cant to create 
            ClsCustomer ACustomer = new ClsCustomer();
            //boolean to store variable for the result of the validation
            Boolean OK = false;
            //create some test data to pass the result of the validation 
            String Address1 = "70 Harrow Road";
            String Address2 = "Westcotes";
            String Address3 = "wefrrgthterhyterj";
            String City = "TestCity";
            String Forename = "TestForename";
            String Surname = "TestSurname";
            String Postcode = "xxxxxx"; //6 char
            String Tel = "07910453483";
            //inovoke the method
            OK = ACustomer.Valid(Address1, Address2, Address3, City, Forename, Surname, Postcode, Tel);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void PostcodeMax()
        {
            //create an instance of the class we cant to create 
            ClsCustomer ACustomer = new ClsCustomer();
            //boolean to store variable for the result of the validation
            Boolean OK = false;
            //create some test data to pass the result of the validation 
            String Address1 = "70 Harrow Road";
            String Address2 = "Westcotes";
            String Address3 = "wefrrgthterhyterj";
            String City = "TestCity";
            String Forename = "TestForename";
            String Surname = "TestSurname";
            String Postcode = "xxxxxxx"; //7 char
            String Tel = "07910453483";
            //inovoke the method
            OK = ACustomer.Valid(Address1, Address2, Address3, City, Forename, Surname, Postcode, Tel);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void PostcodeMid()
        {
            //create an instance of the class we cant to create 
            ClsCustomer ACustomer = new ClsCustomer();
            //boolean to store variable for the result of the validation
            Boolean OK = false;
            //create some test data to pass the result of the validation 
            String Address1 = "70 Harrow road";
            String Address2 = "Westcotes";
            String Address3 = "wefrrgthterhyterj";
            String City = "TextCity";
            String Forename = "TestSurename";
            String Surname = "TestSurname";
            String Postcode = "aaaa"; //4 char
            String Tel = "07910453483";
            //inovoke the method
            OK = ACustomer.Valid(Address1, Address2, Address3, City, Forename, Surname, Postcode, Tel);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void PostcodeMaxPlusOne()
        {
            //create an instance of the class we cant to create 
            ClsCustomer ACustomer = new ClsCustomer();
            //boolean to store variable for the result of the validation
            Boolean OK = false;
            //create some test data to pass the result of the validation 
            String Address1 = "70 harrow road";
            String Address2 = "Westcotes";
            String Address3 = "wefrrgthterhyterj";
            String City = "TestCity";
            String Forename = "TestForename";
            String Surname = "TestSurname";
            String Postcode = "xxxxxxxx"; //8 char
            String Tel = "07910453483";
            //inovoke the method
            OK = ACustomer.Valid(Address1, Address2, Address3, City, Forename, Surname, Postcode, Tel);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void PostcodeExtremeMax()
        {
            //create an instance of the class we cant to create 
            ClsCustomer ACustomer = new ClsCustomer();
            //boolean to store variable for the result of the validation
            Boolean OK = false;
            //create some test data to pass the result of the validation 
            String Address1 = "70 Harrow Road";
            String Address2 = "Westcotes";
            String Address3 = "wefrrgthterhyterj";
            String City = "TestCity";
            String Forename = "TestForename";
            String Surname = "TestSurname";
            String Postcode = "";
            Postcode.PadRight(50, 'a'); // this should fail
            String Tel = "07910453483";
            //inovoke the method
            OK = ACustomer.Valid(Address1, Address2, Address3, City, Forename, Surname, Postcode, Tel);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void TelMax()
        {
            //create an instance of the class we cant to create 
            ClsCustomer ACustomer = new ClsCustomer();
            //boolean to store variable for the result of the validation
            Boolean OK = false;
            //create some test data to pass the result of the validation 
            String Address1 = "70 Harrow Road";
            String Address2 = "Westcotes";
            String Address3 = "wefrrgthterhyterj";
            String City = "TestCity";
            String Forename = "TestForename";
            String Surname = "TestSurname";
            String Postcode = "LE3 2EU";
            String Tel = "07910453483"; //11 char
            //inovoke the method
            OK = ACustomer.Valid(Address1, Address2, Address3, City, Forename, Surname, Postcode, Tel);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TelMaxPlusOne()
        {
            //create an instance of the class we cant to create 
            ClsCustomer ACustomer = new ClsCustomer();
            //boolean to store variable for the result of the validation
            Boolean OK = false;
            //create some test data to pass the result of the validation 
            String Address1 = "70 Harrow road";
            String Address2 = "Westcotes";
            String Address3 = "wefrrgthterhyterj";
            String City = "TextCity";
            String Forename = "TestSurename";
            String Surname = "TestSurname";
            String Postcode = "LE3 2EU";
            String Tel = "142414141414"; //12 char
            //inovoke the method
            OK = ACustomer.Valid(Address1, Address2, Address3, City, Forename, Surname, Postcode, Tel);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void TelMaxLessOne()
        {
            //create an instance of the class we cant to create 
            ClsCustomer ACustomer = new ClsCustomer();
            //boolean to store variable for the result of the validation
            Boolean OK = false;
            //create some test data to pass the result of the validation 
            String Address1 = "70 Harrow road";
            String Address2 = "Westcotes";
            String Address3 = "wefrrgthterhyterj";
            String City = "TextCity";
            String Forename = "TestSurename";
            String Surname = "TestSurname";
            String Postcode = "LE3 2EU";
            String Tel = "1424141414"; //10 char
            //inovoke the method
            OK = ACustomer.Valid(Address1, Address2, Address3, City, Forename, Surname, Postcode, Tel);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void TelMinPlusOne()
        {
            //create an instance of the class we cant to create 
            ClsCustomer ACustomer = new ClsCustomer();
            //boolean to store variable for the result of the validation
            Boolean OK = false;
            //create some test data to pass the result of the validation 
            String Address1 = "70 Harrow road";
            String Address2 = "Westcotes";
            String Address3 = "wefrrgthterhyterj";
            String City = "TextCity";
            String Forename = "TestSurename";
            String Surname = "TestSurname";
            String Postcode = "LE3 2EU";
            String Tel = "1"; //1 char
            //inovoke the method
            OK = ACustomer.Valid(Address1, Address2, Address3, City, Forename, Surname, Postcode, Tel);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void TelMin()
        {
            //create an instance of the class we cant to create 
            ClsCustomer ACustomer = new ClsCustomer();
            //boolean to store variable for the result of the validation
            Boolean OK = false;
            //create some test data to pass the result of the validation 
            String Address1 = "70 Harrow road";
            String Address2 = "Westcotes";
            String Address3 = "wefrrgthterhyterj";
            String City = "TextCity";
            String Forename = "TestSurename";
            String Surname = "TestSurname";
            String Postcode = "LE3 2EU";
            String Tel = ""; //this should fail
            //inovoke the method
            OK = ACustomer.Valid(Address1, Address2, Address3, City, Forename, Surname, Postcode, Tel);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }
        [TestMethod]
        public void TelMid()
        {
            //create an instance of the class we cant to create 
            ClsCustomer ACustomer = new ClsCustomer();
            //boolean to store variable for the result of the validation
            Boolean OK = false;
            //create some test data to pass the result of the validation 
            String Address1 = "70 Harrow road";
            String Address2 = "Westcotes";
            String Address3 = "wefrrgthterhyterj";
            String City = "TextCity";
            String Forename = "TestSurename";
            String Surname = "TestSurname";
            String Postcode = "LE3 2EU";
            String Tel = "145251"; //6  char
            //inovoke the method
            OK = ACustomer.Valid(Address1, Address2, Address3, City, Forename, Surname, Postcode, Tel);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void TelExtremeMax()
        {
            //create an instance of the class we cant to create 
            ClsCustomer ACustomer = new ClsCustomer();
            //boolean to store variable for the result of the validation
            Boolean OK = false;
            //create some test data to pass the result of the validation 
            String Address1 = "70 Harrow Road";
            String Address2 = "Westcotes";
            String Address3 = "wefrrgthterhyterj";
            String City = "TestCity";
            String Forename = "TestForename";
            String Surname = "TestSurname";
            String Postcode = "LE3 2EU";
            String Tel = "";
            Tel.PadRight(50, 'a'); // this should fail
            //inovoke the method
            OK = ACustomer.Valid(Address1, Address2, Address3, City, Forename, Surname, Postcode, Tel);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }
    }
}
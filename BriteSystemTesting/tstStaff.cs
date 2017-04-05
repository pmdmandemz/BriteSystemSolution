using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyClassLibrary;

namespace TestFramework
{
    [TestClass]
    public class tstStaff
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //test to see that it exists
            Assert.IsNotNull(AStaff);
        }

        [TestMethod]
        public void AddressPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to asign to the property
            string TestData = "8 Bingan Street";
            //assign the data to the property
            AStaff.Address = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.Address, TestData);
        }
        [TestMethod]
        public void ForenamePropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            string TestData = "Jack";
            //assign the data to the property
            AStaff.Forename = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.Forename, TestData);
        }
        [TestMethod]
        public void MobilePropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            Int64 TestData = 07765676968;
            //assign the data to the property
            AStaff.Mobile = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.Mobile, TestData);
        }
        [TestMethod]
        public void NI_NumberPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            string TestData = "PU089490Y";
            //assign the data to the property
            AStaff.NI_Number = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.NI_Number, TestData);
        }
        [TestMethod]
        public void PostcodePropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            string TestData = "OP8 6GT";
            //assign the data to the property
            AStaff.Postcode = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.Postcode, TestData);
        }
        [TestMethod]
        public void SalaryPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            Int32 TestData = 7000;
            //assign the data to the property
            AStaff.Salary = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.Salary, TestData);
        }
        [TestMethod]
        public void SurnamePropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            string TestData = "Fryer";
            //assign the data to the property
            AStaff.Surname = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.Surname, TestData);
        }
        [TestMethod]
        public void Staff_IDPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AStaff.Staff_ID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.Staff_ID, TestData);
        }
        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 Staff_ID = 1;
            //invoke the method
            Found = AStaff.Find(Staff_ID);
            //test to see that the result is correct
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void TestStaff_IDFound()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is ok
            Boolean OK = true;
            //create some test data to use with the method
            Int32 Staff_ID = 1;
            //invoke the method
            Found = AStaff.Find(Staff_ID);
            //check the staff ID
            if (AStaff.Staff_ID != 1)
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
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is ok
            Boolean OK = true;
            //create some test data to use with the method
            Int32 Staff_ID = 1;
            //invoke the method
            Found = AStaff.Find(Staff_ID);
            //check the property
            if (AStaff.Address != "8 Bingan Street")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestForenameFound()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is ok
            Boolean OK = true;
            //create some test data to use with the method
            Int32 Staff_ID = 1;
            //invoke the method
            Found = AStaff.Find(Staff_ID);
            //check the property
            if (AStaff.Forename != "Ryan")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestMobileFound()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is ok
            Boolean OK = true;
            //create some test data to use with the method
            Int32 Staff_ID = 1;
            //invoke the method
            Found = AStaff.Find(Staff_ID);
            //check the property
            if (AStaff.Mobile != 07714890621)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestNI_NumberFound()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is ok
            Boolean OK = true;
            //create some test data to use with the method
            Int32 Staff_ID = 1;
            //invoke the method
            Found = AStaff.Find(Staff_ID);
            //check the property
            if (AStaff.NI_Number != "PA098746Y")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestPostcodeFound()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is ok
            Boolean OK = true;
            //create some test data to use with the method
            Int32 Staff_ID = 1;
            //invoke the method
            Found = AStaff.Find(Staff_ID);
            //check the property
            if (AStaff.Postcode != "LE4 8UY")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestSalaryFound()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is ok
            Boolean OK = true;
            //create some test data to use with the method
            Int32 Staff_ID = 1;
            //invoke the method
            Found = AStaff.Find(Staff_ID);
            //check the property
            if (AStaff.Salary != 18000)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestSurnameFound()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is ok
            Boolean OK = true;
            //create some test data to use with the method
            Int32 Staff_ID = 1;
            //invoke the method
            Found = AStaff.Find(Staff_ID);
            //check the property
            if (AStaff.Surname != "Fryer")
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
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string Address = "8 Bingan Street";
            string Forename = "Ryan";
            string Mobile = "07714890621";
            string NI_Number = "PA098746Y";
            string Postcode = "LE4 8UY";
            string Salary = "18000";
            string Surname = "Fryer";
            string Staff_ID = "1";
            //invoke the method
            OK = AStaff.Valid(Address, Forename, Mobile, NI_Number, Postcode, Salary, Surname, Staff_ID);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void AddressMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string Address = ""; //This should trigger an error
            string Forename = "Ryan";
            string Mobile = "07714890621";
            string NI_Number = "PA098746Y";
            string Postcode = "LE4 8UY";
            string Salary = "18000";
            string Surname = "Fryer";
            string Staff_ID = "1";
            //invoke the method
            OK = AStaff.Valid(Address, Forename, Mobile, NI_Number, Postcode, Salary, Surname, Staff_ID);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }
        [TestMethod]
        public void AddressMin()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string Address = "8"; //This should pass
            string Forename = "Ryan";
            string Mobile = "07714890621";
            string NI_Number = "PA098746Y";
            string Postcode = "LE4 8UY";
            string Salary = "18000";
            string Surname = "Fryer";
            string Staff_ID = "1";
            //invoke the method
            OK = AStaff.Valid(Address, Forename, Mobile, NI_Number, Postcode, Salary, Surname, Staff_ID);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void AddressMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string Address = "88"; //This should pass
            string Forename = "Ryan";
            string Mobile = "07714890621";
            string NI_Number = "PA098746Y";
            string Postcode = "LE4 8UY";
            string Salary = "18000";
            string Surname = "Fryer";
            string Staff_ID = "1";
            //invoke the method
            OK = AStaff.Valid(Address, Forename, Mobile, NI_Number, Postcode, Salary, Surname, Staff_ID);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void AddressMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string Address = "";
            Address = Address.PadRight(49, '8'); //this should pass
            string Forename = "Ryan";
            string Mobile = "07714890621";
            string NI_Number = "PA098746Y";
            string Postcode = "LE4 8UY";
            string Salary = "18000";
            string Surname = "Fryer";
            string Staff_ID = "1";
            //invoke the method
            OK = AStaff.Valid(Address, Forename, Mobile, NI_Number, Postcode, Salary, Surname, Staff_ID);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void AddressMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string Address = "";
            Address = Address.PadRight(50, '8'); //this should pass
            string Forename = "Ryan";
            string Mobile = "07714890621";
            string NI_Number = "PA098746Y";
            string Postcode = "LE4 8UY";
            string Salary = "18000";
            string Surname = "Fryer";
            string Staff_ID = "1";
            //invoke the method
            OK = AStaff.Valid(Address, Forename, Mobile, NI_Number, Postcode, Salary, Surname, Staff_ID);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void AddressMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string Address = "";
            Address = Address.PadRight(51, '8'); //this should fail
            string Forename = "Ryan";
            string Mobile = "07714890621";
            string NI_Number = "PA098746Y";
            string Postcode = "LE4 8UY";
            string Salary = "18000";
            string Surname = "Fryer";
            string Staff_ID = "1";
            //invoke the method
            OK = AStaff.Valid(Address, Forename, Mobile, NI_Number, Postcode, Salary, Surname, Staff_ID);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }
        [TestMethod]
        public void AddressMid()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string Address = "";
            Address = Address.PadRight(25, '8'); //this should pass
            string Forename = "Ryan";
            string Mobile = "07714890621";
            string NI_Number = "PA098746Y";
            string Postcode = "LE4 8UY";
            string Salary = "18000";
            string Surname = "Fryer";
            string Staff_ID = "1";
            //invoke the method
            OK = AStaff.Valid(Address, Forename, Mobile, NI_Number, Postcode, Salary, Surname, Staff_ID);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void ForenameMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string Address = "8 Bingan Street";
            string Forename = ""; //This should fail
            string Mobile = "07714890621";
            string NI_Number = "PA098746Y";
            string Postcode = "LE4 8UY";
            string Salary = "18000";
            string Surname = "Fryer";
            string Staff_ID = "1";
            //invoke the method
            OK = AStaff.Valid(Address, Forename, Mobile, NI_Number, Postcode, Salary, Surname, Staff_ID);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }
        [TestMethod]
        public void ForenameMin()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string Address = "8 Bingan Street";
            string Forename = "R"; //This should pass
            string Mobile = "07714890621";
            string NI_Number = "PA098746Y";
            string Postcode = "LE4 8UY";
            string Salary = "18000";
            string Surname = "Fryer";
            string Staff_ID = "1";
            //invoke the method
            OK = AStaff.Valid(Address, Forename, Mobile, NI_Number, Postcode, Salary, Surname, Staff_ID);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void ForenameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string Address = "8 Bingan Street";
            string Forename = "Ry"; //This should pass
            string Mobile = "07714890621";
            string NI_Number = "PA098746Y";
            string Postcode = "LE4 8UY";
            string Salary = "18000";
            string Surname = "Fryer";
            string Staff_ID = "1";
            //invoke the method
            OK = AStaff.Valid(Address, Forename, Mobile, NI_Number, Postcode, Salary, Surname, Staff_ID);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void ForenameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string Address = "8 Bingan Street";
            string Forename = "Ryan";
            Forename = Forename.PadRight(24, 'J'); //this should pass
            string Mobile = "07714890621";
            string NI_Number = "PA098746Y";
            string Postcode = "LE4 8UY";
            string Salary = "18000";
            string Surname = "Fryer";
            string Staff_ID = "1";
            //invoke the method
            OK = AStaff.Valid(Address, Forename, Mobile, NI_Number, Postcode, Salary, Surname, Staff_ID);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void ForenameMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string Address = "8 Bingan Street";
            string Forename = "Ryan";
            Forename = Forename.PadRight(25, 'J'); //this should pass
            string Mobile = "07714890621";
            string NI_Number = "PA098746Y";
            string Postcode = "LE4 8UY";
            string Salary = "18000";
            string Surname = "Fryer";
            string Staff_ID = "1";
            //invoke the method
            OK = AStaff.Valid(Address, Forename, Mobile, NI_Number, Postcode, Salary, Surname, Staff_ID);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void ForenameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string Address = "8 Bingan Street";
            string Forename = "Ryan";
            Forename = Forename.PadRight(26, 'J'); //this should fail
            string Mobile = "07714890621";
            string NI_Number = "PA098746Y";
            string Postcode = "LE4 8UY";
            string Salary = "18000";
            string Surname = "Fryer";
            string Staff_ID = "1";
            //invoke the method
            OK = AStaff.Valid(Address, Forename, Mobile, NI_Number, Postcode, Salary, Surname, Staff_ID);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }
        [TestMethod]
        public void ForenameMid()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string Address = "8 Bingan Street";
            string Forename = "Ryan";
            Forename = Forename.PadRight(13, 'J'); //this should pass
            string Mobile = "07714890621";
            string NI_Number = "PA098746Y";
            string Postcode = "LE4 8UY";
            string Salary = "18000";
            string Surname = "Fryer";
            string Staff_ID = "1";
            //invoke the method
            OK = AStaff.Valid(Address, Forename, Mobile, NI_Number, Postcode, Salary, Surname, Staff_ID);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void MobileMin()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string Address = "8 Bingan Street";
            string Forename = "Ryan";
            string Mobile = "07714890621"; //This should pass
            string NI_Number = "PA098746Y";
            string Postcode = "LE4 8UY";
            string Salary = "18000";
            string Surname = "Fryer";
            string Staff_ID = "1";
            //invoke the method
            OK = AStaff.Valid(Address, Forename, Mobile, NI_Number, Postcode, Salary, Surname, Staff_ID);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void MobileMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string Address = "8 Bingan Street";
            string Forename = "Ryan";
            string Mobile = "077148906211"; //This should fail
            string NI_Number = "PA098746Y";
            string Postcode = "LE4 8UY";
            string Salary = "18000";
            string Surname = "Fryer";
            string Staff_ID = "1";
            //invoke the method
            OK = AStaff.Valid(Address, Forename, Mobile, NI_Number, Postcode, Salary, Surname, Staff_ID);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }
        [TestMethod]
        public void MobileMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string Address = "8 Bingan Street";
            string Forename = "Ryan";
            string Mobile = "0771489062"; //This should fail
            string NI_Number = "PA098746Y";
            string Postcode = "LE4 8UY";
            string Salary = "18000";
            string Surname = "Fryer";
            string Staff_ID = "1";
            //invoke the method
            OK = AStaff.Valid(Address, Forename, Mobile, NI_Number, Postcode, Salary, Surname, Staff_ID);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }
        [TestMethod]
        public void NI_NumberMin()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string Address = "8 Bingan Street";
            string Forename = "Ryan";
            string Mobile = "07714890621";
            string NI_Number = "PA098746Y"; //This should pass
            string Postcode = "LE4 8UY";
            string Salary = "18000";
            string Surname = "Fryer";
            string Staff_ID = "1";
            //invoke the method
            OK = AStaff.Valid(Address, Forename, Mobile, NI_Number, Postcode, Salary, Surname, Staff_ID);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void NI_NumberMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string Address = "8 Bingan Street";
            string Forename = "Ryan";
            string Mobile = "07714890621";
            string NI_Number = "PA098746YY"; //This should fail
            string Postcode = "LE4 8UY";
            string Salary = "18000";
            string Surname = "Fryer";
            string Staff_ID = "1";
            //invoke the method
            OK = AStaff.Valid(Address, Forename, Mobile, NI_Number, Postcode, Salary, Surname, Staff_ID);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }
        [TestMethod]
        public void NI_NumberMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string Address = "8 Bingan Street";
            string Forename = "Ryan";
            string Mobile = "07714890621";
            string NI_Number = "PA098746"; //This should fail
            string Postcode = "LE4 8UY";
            string Salary = "18000";
            string Surname = "Fryer";
            string Staff_ID = "1";
            //invoke the method
            OK = AStaff.Valid(Address, Forename, Mobile, NI_Number, Postcode, Salary, Surname, Staff_ID);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }
        [TestMethod]
        public void PostcodeMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string Address = "8 Bingan Street";
            string Forename = "Ryan";
            string Mobile = "07714890621";
            string NI_Number = "PA098746Y";
            string Postcode = ""; //This should fail
            string Salary = "18000";
            string Surname = "Fryer";
            string Staff_ID = "1";
            //invoke the method
            OK = AStaff.Valid(Address, Forename, Mobile, NI_Number, Postcode, Salary, Surname, Staff_ID);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }
        [TestMethod]
        public void PostcodeMin()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string Address = "8 Bingan Street";
            string Forename = "Ryan";
            string Mobile = "07714890621";
            string NI_Number = "PA098746Y";
            string Postcode = "L"; //This should pass
            string Salary = "18000";
            string Surname = "Fryer";
            string Staff_ID = "1";
            //invoke the method
            OK = AStaff.Valid(Address, Forename, Mobile, NI_Number, Postcode, Salary, Surname, Staff_ID);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void PostcodeMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string Address = "8 Bingan Street";
            string Forename = "Ryan";
            string Mobile = "07714890621";
            string NI_Number = "PA098746Y";
            string Postcode = "LE"; //This should pass
            string Salary = "18000";
            string Surname = "Fryer";
            string Staff_ID = "1";
            //invoke the method
            OK = AStaff.Valid(Address, Forename, Mobile, NI_Number, Postcode, Salary, Surname, Staff_ID);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void PostcodeMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string Address = "8 Bingan Street";
            string Forename = "Ryan";
            string Mobile = "07714890621";
            string NI_Number = "PA098746Y";
            string Postcode = "LE4LE4LE"; //This should pass
            string Salary = "18000";
            string Surname = "Fryer";
            string Staff_ID = "1";
            //invoke the method
            OK = AStaff.Valid(Address, Forename, Mobile, NI_Number, Postcode, Salary, Surname, Staff_ID);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void PostcodeMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string Address = "8 Bingan Street";
            string Forename = "Ryan";
            string Mobile = "07714890621";
            string NI_Number = "PA098746Y";
            string Postcode = "LE4LE4LE4"; //this should pass
            string Salary = "18000";
            string Surname = "Fryer";
            string Staff_ID = "1";
            //invoke the method
            OK = AStaff.Valid(Address, Forename, Mobile, NI_Number, Postcode, Salary, Surname, Staff_ID);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void PostcodeMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string Address = "8 Bingan Street";
            string Forename = "Ryan";
            string Mobile = "07714890621";
            string NI_Number = "PA098746Y";
            string Postcode = "LE4LE4LE4L"; //This should fail
            string Salary = "18000";
            string Surname = "Fryer";
            string Staff_ID = "1";
            //invoke the method
            OK = AStaff.Valid(Address, Forename, Mobile, NI_Number, Postcode, Salary, Surname, Staff_ID);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }
        [TestMethod]
        public void PostcodeMid()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string Address = "8 Bingan Street";
            string Forename = "Ryan";
            string Mobile = "07714890621";
            string NI_Number = "PA098746Y";
            string Postcode = "LE4 8U"; //This should pass
            string Salary = "18000";
            string Surname = "Fryer";
            string Staff_ID = "1";
            //invoke the method
            OK = AStaff.Valid(Address, Forename, Mobile, NI_Number, Postcode, Salary, Surname, Staff_ID);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void SalaryMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string Address = "8 Bingan Street";
            string Forename = "Ryan";
            string Mobile = "07714890621";
            string NI_Number = "PA098746Y";
            string Postcode = "LE4 8UY";
            string Salary = ""; //This should fail
            string Surname = "Fryer";
            string Staff_ID = "1";
            //invoke the method
            OK = AStaff.Valid(Address, Forename, Mobile, NI_Number, Postcode, Salary, Surname, Staff_ID);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }
        [TestMethod]
        public void SalaryMin()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string Address = "8 Bingan Street";
            string Forename = "Ryan";
            string Mobile = "07714890621";
            string NI_Number = "PA098746Y";
            string Postcode = "LE4 8UY";
            string Salary = "1"; //This should pass
            string Surname = "Fryer";
            string Staff_ID = "1";
            //invoke the method
            OK = AStaff.Valid(Address, Forename, Mobile, NI_Number, Postcode, Salary, Surname, Staff_ID);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void SalaryMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string Address = "8 Bingan Street";
            string Forename = "Ryan";
            string Mobile = "07714890621";
            string NI_Number = "PA098746Y";
            string Postcode = "LE4 8UY";
            string Salary = "18"; //This should pass
            string Surname = "Fryer";
            string Staff_ID = "1";
            //invoke the method
            OK = AStaff.Valid(Address, Forename, Mobile, NI_Number, Postcode, Salary, Surname, Staff_ID);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void SalaryMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string Address = "8 Bingan Street";
            string Forename = "Ryan";
            string Mobile = "07714890621";
            string NI_Number = "PA098746Y";
            string Postcode = "LE4 8UY";
            string Salary = "180000"; //This should pass
            string Surname = "Fryer";
            string Staff_ID = "1";
            //invoke the method
            OK = AStaff.Valid(Address, Forename, Mobile, NI_Number, Postcode, Salary, Surname, Staff_ID);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void SalaryMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string Address = "8 Bingan Street";
            string Forename = "Ryan";
            string Mobile = "07714890621";
            string NI_Number = "PA098746Y";
            string Postcode = "LE4 8UY";
            string Salary = "1800000"; //This should pass
            string Surname = "Fryer";
            string Staff_ID = "1";
            //invoke the method
            OK = AStaff.Valid(Address, Forename, Mobile, NI_Number, Postcode, Salary, Surname, Staff_ID);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void SalaryMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string Address = "8 Bingan Street";
            string Forename = "Ryan";
            string Mobile = "07714890621";
            string NI_Number = "PA098746Y";
            string Postcode = "LE4 8UY";
            string Salary = "18000000"; //This should fail
            string Surname = "Fryer";
            string Staff_ID = "1";
            //invoke the method
            OK = AStaff.Valid(Address, Forename, Mobile, NI_Number, Postcode, Salary, Surname, Staff_ID);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }
        [TestMethod]
        public void SalaryMid()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string Address = "8 Bingan Street";
            string Forename = "Ryan";
            string Mobile = "07714890621";
            string NI_Number = "PA098746Y";
            string Postcode = "LE4 8UY";
            string Salary = "1800"; //This should pass
            string Surname = "Fryer";
            string Staff_ID = "1";
            //invoke the method
            OK = AStaff.Valid(Address, Forename, Mobile, NI_Number, Postcode, Salary, Surname, Staff_ID);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void SurnameMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string Address = "8 Bingan Street";
            string Forename = "Ryan";
            string Mobile = "07714890621";
            string NI_Number = "PA098746Y";
            string Postcode = "LE4 8UY";
            string Salary = "18000";
            string Surname = ""; //This should fail
            string Staff_ID = "1";
            //invoke the method
            OK = AStaff.Valid(Address, Forename, Mobile, NI_Number, Postcode, Salary, Surname, Staff_ID);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }
        [TestMethod]
        public void SurnameMin()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string Address = "8 Bingan Street";
            string Forename = "Ryan";
            string Mobile = "07714890621";
            string NI_Number = "PA098746Y";
            string Postcode = "LE4 8UY";
            string Salary = "18000";
            string Surname = "F"; //This should pass
            string Staff_ID = "1";
            //invoke the method
            OK = AStaff.Valid(Address, Forename, Mobile, NI_Number, Postcode, Salary, Surname, Staff_ID);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void SurnameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string Address = "8 Bingan Street";
            string Forename = "Ryan";
            string Mobile = "07714890621";
            string NI_Number = "PA098746Y";
            string Postcode = "LE4 8UY";
            string Salary = "18000";
            string Surname = "Fr"; //This should pass
            string Staff_ID = "1";
            //invoke the method
            OK = AStaff.Valid(Address, Forename, Mobile, NI_Number, Postcode, Salary, Surname, Staff_ID);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void SurnameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string Address = "8 Bingan Street";
            string Forename = "Ryan";
            string Mobile = "07714890621";
            string NI_Number = "PA098746Y";
            string Postcode = "LE4 8UY";
            string Salary = "18000";
            string Surname = "Fryer";
            Surname = Surname.PadRight(24, 'a'); //This should pass
            string Staff_ID = "1";
            //invoke the method
            OK = AStaff.Valid(Address, Forename, Mobile, NI_Number, Postcode, Salary, Surname, Staff_ID);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void SurnameMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string Address = "8 Bingan Street";
            string Forename = "Ryan";
            string Mobile = "07714890621";
            string NI_Number = "PA098746Y";
            string Postcode = "LE4 8UY";
            string Salary = "18000";
            string Surname = "Fryer";
            Surname = Surname.PadRight(25, 'a'); // This should pass
            string Staff_ID = "1";
            //invoke the method
            OK = AStaff.Valid(Address, Forename, Mobile, NI_Number, Postcode, Salary, Surname, Staff_ID);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void SurnameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string Address = "8 Bingan Street";
            string Forename = "Ryan";
            string Mobile = "07714890621";
            string NI_Number = "PA098746Y";
            string Postcode = "LE4 8UY";
            string Salary = "18000";
            string Surname = "Fryer";
            Surname = Surname.PadRight(26, 'a'); //This should fail
            string Staff_ID = "1";
            //invoke the method
            OK = AStaff.Valid(Address, Forename, Mobile, NI_Number, Postcode, Salary, Surname, Staff_ID);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }
        [TestMethod]
        public void SurnameMid()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string Address = "8 Bingan Street";
            string Forename = "Ryan";
            string Mobile = "07714890621";
            string NI_Number = "PA098746Y";
            string Postcode = "LE4 8UY";
            string Salary = "18000";
            string Surname = "Fryer";
            Surname = Surname.PadRight(13, 'a'); //This should pass
            string Staff_ID = "1";
            //invoke the method
            OK = AStaff.Valid(Address, Forename, Mobile, NI_Number, Postcode, Salary, Surname, Staff_ID);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void Staff_IDMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string Address = "8 Bingan Street";
            string Forename = "Ryan";
            string Mobile = "07714890621";
            string NI_Number = "PA098746Y";
            string Postcode = "LE4 8UY";
            string Salary = "18000";
            string Surname = "Fryer";
            string Staff_ID = ""; //This should fail
            //invoke the method
            OK = AStaff.Valid(Address, Forename, Mobile, NI_Number, Postcode, Salary, Surname, Staff_ID);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }
        [TestMethod]
        public void Staff_IDMin()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string Address = "8 Bingan Street";
            string Forename = "Ryan";
            string Mobile = "07714890621";
            string NI_Number = "PA098746Y";
            string Postcode = "LE4 8UY";
            string Salary = "18000";
            string Surname = "Fryer";
            string Staff_ID = "1"; //This should pass
            //invoke the method
            OK = AStaff.Valid(Address, Forename, Mobile, NI_Number, Postcode, Salary, Surname, Staff_ID);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void Staff_IDMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string Address = "8 Bingan Street";
            string Forename = "Ryan";
            string Mobile = "07714890621";
            string NI_Number = "PA098746Y";
            string Postcode = "LE4 8UY";
            string Salary = "18000";
            string Surname = "Fryer";
            string Staff_ID = "2"; //This should pass
            //invoke the method
            OK = AStaff.Valid(Address, Forename, Mobile, NI_Number, Postcode, Salary, Surname, Staff_ID);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void Staff_IDMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string Address = "8 Bingan Street";
            string Forename = "Ryan";
            string Mobile = "07714890621";
            string NI_Number = "PA098746Y";
            string Postcode = "LE4 8UY";
            string Salary = "18000";
            string Surname = "Fryer";
            string Staff_ID = "998"; //This should pass
            //invoke the method
            OK = AStaff.Valid(Address, Forename, Mobile, NI_Number, Postcode, Salary, Surname, Staff_ID);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void Staff_IDMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string Address = "8 Bingan Street";
            string Forename = "Ryan";
            string Mobile = "07714890621";
            string NI_Number = "PA098746Y";
            string Postcode = "LE4 8UY";
            string Salary = "18000";
            string Surname = "Fryer";
            string Staff_ID = "999"; //This should pass
            //invoke the method
            OK = AStaff.Valid(Address, Forename, Mobile, NI_Number, Postcode, Salary, Surname, Staff_ID);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void Staff_IDMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string Address = "8 Bingan Street";
            string Forename = "Ryan";
            string Mobile = "07714890621";
            string NI_Number = "PA098746Y";
            string Postcode = "LE4 8UY";
            string Salary = "18000";
            string Surname = "Fryer";
            string Staff_ID = "1000"; //This should fail
            //invoke the method
            OK = AStaff.Valid(Address, Forename, Mobile, NI_Number, Postcode, Salary, Surname, Staff_ID);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }
        [TestMethod]
        public void Staff_IDMid()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string Address = "8 Bingan Street";
            string Forename = "Ryan";
            string Mobile = "07714890621";
            string NI_Number = "PA098746Y";
            string Postcode = "LE4 8UY";
            string Salary = "18000";
            string Surname = "Fryer";
            string Staff_ID = "99"; //this should pass
            //invoke the method
            OK = AStaff.Valid(Address, Forename, Mobile, NI_Number, Postcode, Salary, Surname, Staff_ID);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
    }
}

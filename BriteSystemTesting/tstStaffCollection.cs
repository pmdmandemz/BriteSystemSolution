using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyClassLibrary;
using System.Collections.Generic;

namespace TestFramework
{
    [TestClass]
    public class tstStaffCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //test to see that it exists
            Assert.IsNotNull(AllStaff);
        }
        [TestMethod]
        public void StaffListOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsStaff> TestList = new List<clsStaff>();
            //add an item to the list
            //create the item of test data
            clsStaff TestItem = new clsStaff();
            //set the properties
            TestItem.Address = "8 Bingan Street";
            TestItem.Forename = "Ryan";
            TestItem.Mobile = 07714890621;
            TestItem.NI_Number = "PA098746Y";
            TestItem.Postcode = "LE4 8UY";
            TestItem.Salary = 18000;
            TestItem.Surname = "Fryer";
            TestItem.Staff_ID = 1;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllStaff.StaffList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllStaff.StaffList, TestList);
        }
        [TestMethod]
        public void ThisStaffPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create some test data to assign to the property
            clsStaff TestStaff = new clsStaff();
            //set the properties of the test object
            TestStaff.Address = "8 Bingan Street";
            TestStaff.Forename = "Ryan";
            TestStaff.Mobile = 07714890621;
            TestStaff.NI_Number = "PA098746Y";
            TestStaff.Postcode = "LE4 8UY";
            TestStaff.Salary = 18000;
            TestStaff.Surname = "Fryer";
            TestStaff.Staff_ID = 1;
            //assign the data to the property
            AllStaff.ThisStaff = TestStaff;
            //test to see that the two values are the same
            Assert.AreEqual(AllStaff.ThisStaff, TestStaff);
        }
        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsStaff> TestList = new List<clsStaff>();
            //add an item to the list
            //create the item of test data
            clsStaff TestItem = new clsStaff();
            //set its properties
            TestItem.Address = "8 Bingan Street";
            TestItem.Forename = "Ryan";
            TestItem.Mobile = 07714890621;
            TestItem.NI_Number = "PA098746Y";
            TestItem.Postcode = "LE4 8UY";
            TestItem.Salary = 18000;
            TestItem.Surname = "Fryer";
            TestItem.Staff_ID = 1;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllStaff.StaffList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllStaff.Count, TestList.Count);
        }
    }
}

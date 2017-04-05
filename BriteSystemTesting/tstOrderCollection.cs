using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;
using System.Collections.Generic;

namespace TestFramwork
{
    [TestClass]
    public class tstOrderCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrder = new clsOrderCollection();
            //test to see that it exists
            Assert.IsNotNull(AllOrder);
        }

        [TestMethod]
        public void OrderListOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrder = new clsOrderCollection();
            //create some test data to assign to the property
            //in this case the data needs to be list of objects
            List<clsOrder> TestList = new List<clsOrder>();
            //add an item to the List
            //create the item of test data
            clsOrder TestItem = new clsOrder();
            //set its properties
            TestItem.Active = true;
            TestItem.CustomerID = 6;
            TestItem.OrderID = "Iphone8";
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.SearchProduct = "Nokia";
            TestItem.CardName = "MR D Patel";
            TestItem.CardNumber = "2356233245675643";
            TestItem.SecurityCode = "122";
            TestItem.Address = "131 Acorn Street";
            TestItem.City = "Conventry";
            TestItem.PostCode = "CD2 8WH";
            //add the item to the test list 
            TestList.Add(TestItem);
            //assign the data to the property
            AllOrder.OrderList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllOrder.OrderList, TestList);

        }
        [TestMethod]
        public void CountPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrder = new clsOrderCollection();
            //create some test data to assign to the property
            Int32 SomeCount = 2;
            //assign the data to the property
            AllOrder.Count = SomeCount;
            //test to see that the two values are the same
            Assert.AreEqual(AllOrder.Count, SomeCount);
        }
        [TestMethod]
        public void ThisOrderPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrder = new clsOrderCollection();
            //create some test data to assign to the property
            clsOrder TestOrder = new clsOrder();
            //set the properties of the test object
            TestOrder.Active = true;
            TestOrder.CustomerID = 6;
            TestOrder.OrderID = "Iphone8";
            TestOrder.DateAdded = DateTime.Now.Date;
            TestOrder.SearchProduct = "Nokia";
            TestOrder.CardName = "MR D Patel";
            TestOrder.CardNumber = "2356233245675643";
            TestOrder.SecurityCode = "122";
            TestOrder.Address = "131 Acorn Street";
            TestOrder.City = "Conventry";
            TestOrder.PostCode = "CD2 8WH";
            //assign the data that the two values are the same 
            AllOrder.ThisOrder = TestOrder;
            //test to see that the two vlaues are the same
            Assert.AreEqual(AllOrder.ThisOrder, TestOrder);
        }
        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrder = new clsOrderCollection();
            //create some test data to assign to the property
            //in this case the data need sto be a list of objects
            List<clsOrder> TestList = new List<clsOrder>();
            //add an item of test data
            clsOrder TestItem = new clsOrder();
            //set the properties of the test object
            TestItem.Active = true;
            TestItem.CustomerID = 6;
            TestItem.OrderID = "Iphone8";
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.SearchProduct = "Nokia";
            TestItem.CardName = "MR D Patel";
            TestItem.CardNumber = "2356233245675643";
            TestItem.SecurityCode = "122";
            TestItem.Address = "131 Acorn Street";
            TestItem.City = "Conventry";
            TestItem.PostCode = "CD2 8WH";
            //add the item tot he test list
            TestList.Add(TestItem);
            //assign the data that the two values are the same 
            AllOrder.OrderList = TestList;
            //test to see that the two vlaues are the same
            Assert.AreEqual(AllOrder.Count, TestList.Count);
        }
        [TestMethod]
        public void TwoRecordsPresentOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrder = new clsOrderCollection();
            //test to see that the two values are the same
            Assert.AreEqual(AllOrder.Count, 2);
        
        }


    }
}

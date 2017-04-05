using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsOrderCollection
    {
        //pricate data member for the list
        List<clsOrder> mOrderList = new List<clsOrder>();

        public List<clsOrder> OrderList
        {
            get
            {
                //return the private data 
                return mOrderList;
            }
            set
            {
                mOrderList = value;
            }
        }
        public clsOrder ThisOrder { get; set; }

        public int Count
        {
            get
            {
                //return the count of the list
                return mOrderList.Count;
            }
            set
            {
                //we shall worry about this later

            }
        }

        //constructor for the class
        public clsOrderCollection()
        {
            //add an item of test data
            clsOrder TestItem = new clsOrder();
            //set the properties of the test object
            TestItem.Active = true;
            TestItem.CustomerID = 6;
            TestItem.OrderID = "Iphone8";
            TestItem.SearchProduct = "Nokia";
            TestItem.CardName = "MR D Patel";
            TestItem.CardNumber = "2356233245675643";
            TestItem.SecurityCode = "122";
            TestItem.Address = "131 Acorn Street";
            TestItem.City = "Conventry";
            TestItem.PostCode = "CD2 8WH";
            //add the item to the test list
            mOrderList.Add(TestItem);
            //re initialise the object for some new data
            TestItem = new clsOrder();
            //set its properties 
            TestItem.Active = true;
            TestItem.CustomerID = 6;
            TestItem.OrderID = "Iphone8";
            TestItem.SearchProduct = "Nokia";
            TestItem.CardName = "MR D Patel";
            TestItem.CardNumber = "2356233245675643";
            TestItem.SecurityCode = "122";
            TestItem.Address = "131 Acorn Street";
            TestItem.City = "Conventry";
            TestItem.PostCode = "CD2 8WH";
            //add the item tot he test list
            mOrderList.Add(TestItem);       

        }

    }
}
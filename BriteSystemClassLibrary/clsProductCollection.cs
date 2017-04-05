using System;
using System.Collections.Generic;

namespace ProductClassLibrary
{
    public class clsProductCollection
    {
        //private data member for the list
        List<clsProduct> mProductList = new List<clsProduct>();

        //constructor for the class
        public clsProductCollection()
        {
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount = 0;
            //object for the data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblProduct_SelectAll");
            //get the count of records
            RecordCount = DB.Count;
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank product
                clsProduct AProduct = new clsProduct();
                //read in the fields from the current record
                AProduct.CategoryID = Convert.ToInt32(DB.DataTable.Rows[Index]["Category_ID"]);
                AProduct.NoAvailable = Convert.ToInt32(DB.DataTable.Rows[Index]["No_Available"]);
                AProduct.ProductDetail = Convert.ToString(DB.DataTable.Rows[Index]["Product_Detail"]);
                AProduct.ProductID = Convert.ToInt32(DB.DataTable.Rows[Index]["Product_ID"]);
                AProduct.ProductName = Convert.ToString(DB.DataTable.Rows[Index]["Product_Name"]);
                AProduct.ProductPrice = Convert.ToDecimal(DB.DataTable.Rows[Index]["Product_Price"]);
                //add the record to the private data member
                mProductList.Add(AProduct);
                //point at the next record
                Index++;
            }
        }

        public int Count //public property for count
        {
            get
            {
                //return the count of the list
                return mProductList.Count;
            }
            set
            {
                //we shall worry about this later
            }
        }

        public List<clsProduct> ProductList //public property for the product list 
        {
            get
            {
                //return the private data
                return mProductList;
            }
            set
            {
                //set the private data 
                mProductList = value;
            }
        }
        public clsProduct ThisProduct { get; set; }
    }
}
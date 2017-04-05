using System;

namespace ProductClassLibrary
{
    public class clsProduct
    {
        //private data member for the categoryID property
        private Int32 mCategoryID;
        //private data member for the productID property
        private Int32 mProductID;
        //private data member for the NoAvailable property
        private Int32 mNoAvailable;
        //private data member for the ProductName property
        private string mProductName;
        //private data member for the Product Detail property
        private string mProductDetail;
        //private data member for the Product Price property
        private decimal mProductPrice;


        //public property for CategoryID
        public int CategoryID
        {
            get
            {
                //return the private data
                return mCategoryID;
            }
            set
            {
                //set the private data
                mCategoryID = value;
            }
        }

        //public property for ProductID
        public int ProductID
        {
            get
            {
                //return the private data
                return mProductID;
            }
            set
            {
                //set the private data
                mProductID = value;
            }
        }

        //public property for NoAvailable
        public int NoAvailable
        {
            get
            {
                //return the private data
                return mNoAvailable;
            }
            set
            {
                //set the private data
                mNoAvailable = value;
            }
        }

        //public property for ProductName
        public string ProductName
        {
            get
            {
                //return the private data
                return mProductName;
            }
            set
            {
                //set the private data
                mProductName = value;
            }
        }

        //public property for ProductDetail
        public string ProductDetail
        {
            get
            {
                //return the private data
                return mProductDetail;
            }
            set
            {
                //set the private data
                mProductDetail = value;
            }
        }

        //public property for ProductPrice
        public decimal ProductPrice
        {
            get
            {
                //return the private data
                return mProductPrice;
            }
            set
            {
                //set the private data
                mProductPrice = value;
            }
        }

        public bool Find(int ProductID)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the prod id search for 
            DB.AddParameter("@ProductID", ProductID);
            //execute the stored proc
            DB.Execute("sproc_tblProduct_FilterByProductID");
            //if one record is found 
            if (DB.Count == 1)
            {
                //copy the data fron the database to the priv data memb
                mCategoryID = Convert.ToInt32(DB.DataTable.Rows[0]["Category_ID"]);
                mProductID = Convert.ToInt32(DB.DataTable.Rows[0]["Product_ID"]);
                mProductName = Convert.ToString(DB.DataTable.Rows[0]["Product_Name"]);
                mProductDetail = Convert.ToString(DB.DataTable.Rows[0]["Product_Detail"]);
                mNoAvailable = Convert.ToInt32(DB.DataTable.Rows[0]["No_Available"]);
                mProductPrice = Convert.ToDecimal(DB.DataTable.Rows[0]["Product_Price"]);
                //always return true
                return true;
            }
            //if no record found
            else
            {
                return false;
            }
        }

        public bool Valid(string productID, string productName, string productDetail, string productPrice, string noAvailable, string categoryID)
        {
            //create boolean variable to flag the error
            Boolean OK = true;
            //if product name is blank
            if (productName.Length == 0)
            {
                //set the flag OK to false 
                OK = false;
            }

            //if the product name is greater than 25
            if (productName.Length > 25)
            {
                //set the flag OK to false
                OK = false;
            }
            //if product detail is blank
            if (productDetail.Length == 0)
            {
                //set the flag OK to false 
                OK = false;
            }
            //if the product Detail is greater than 25
            if (productDetail.Length > 25)
            {
                //set the flag OK to false
                OK = false;
            }

            try
            {
                decimal TempPrice = Convert.ToDecimal(productPrice);
                //if product price is blank
                if (TempPrice == 00.00m)
                {
                    //set the flag OK to false 
                    OK = false;
                }
                //if the product price is greater than 25
                if (TempPrice > 999.99m)
                {
                    //set the flag OK to false
                    OK = false;
                }
            }
            catch
            {
                //set the flag OK to false
                OK = false;
            }

            try
            {
                Int32 TempCategoryID = Convert.ToInt32(categoryID);
                //if category id is blank
                if (TempCategoryID == 0)
                {
                    //set the flag OK to false 
                    OK = false;
                }
                //if the category id is greater than three integers long
                if (TempCategoryID > 999)
                {
                    //set the flag OK to false
                    OK = false;
                }
            }
            catch
            {
                //set the flag OK to false
                OK = false;
            }

            try
            {
                Int32 TempNoAvailable = Convert.ToInt32(noAvailable);
                //if category id is blank
                if (TempNoAvailable == 0)
                {
                    //set the flag OK to false 
                    OK = true;
                }
                //if the number available is greater than 999
                if (TempNoAvailable > 999)
                {
                    //set the flag OK to false
                    OK = false;
                }
            }
            catch
            {
                //set the flag OK to false
                OK = false;
            }

            //return the value of OK
            return OK;
        }
    }
}
using System;

namespace ClassLibrary
{
    public class clsOrder
    {

        public string CustomerIDOK { get; set; }
        public string Order { get; set; }
        public int OrderIDOK { get; set; }
        public string OrderTotalPriceOK { get; set; }

        private bool mActive;
        private int mCustomerID;
        private String mOrderID;
        private DateTime mDateAdded;
        private string mOrderTotalPrice;
        private string mSearchProduct;
        private string mCardName;
        private string mCardNumber;
        private string mSecurityCode;
        private DateTime mExpirationDate;
        private string mAddress;
        private string mCity;
        private string mPostCode;

        //public property for active
        public bool Active
        {
            get
            {
                //return the private data
                return mActive;
            }
            set
            {
                //set the private data
                mActive = value;
            }
        }

        
        //public property for the Customer ID
        public int CustomerID
        {
            get
            {
                //retrun the private data
                return mCustomerID;

            }
            set
            {
                //set the value of the private data 
                mCustomerID = value;
            }
        }

        //public property for the order ID
        public string OrderID
        {
            get
            {
                //return the private data
                return mOrderID;
            }
            set
            {
                //set the value for the private
                mOrderID = value;
            }
        }

        //public property for the dataAdded        
        public DateTime DateAdded
        {
            get
            {
                //return the private data
                return mDateAdded;
            }
            set
            {
                //set the value for the private
                mDateAdded = value;
            }
        }

        //public property for the OrderTotalPrice
        public string OrderTotalPrice
        {
            get
            {
                //return the private data
                return mOrderTotalPrice;
            }
            set
            {
                //set the value for the private
                mOrderTotalPrice = value;
            }
        }

        public string SearchProduct
        {
            get
            {
                return mSearchProduct;
            }
            set
            {
                mSearchProduct = value;
            }
        }



        public string CardName
        {
            get
            {
                return mCardName;
            } 
            set
            {
                mCardName = value;
            }
        }
        public string CardNumber
        {
            get
            {
                return mCardNumber;
            }
            set
            {
                mCardNumber = value;
            }
        }

        public string SecurityCode
        {
            get
            {
                return mSecurityCode;
            }
            set
            {
                mSecurityCode = value;
            }
        }
        public DateTime ExpirationDate
        {
            get
            {
                return mExpirationDate;
            }
            set
            {
                mExpirationDate = value;
            }
        }
        public string Address
        {
            get
            {
                return mAddress;
            }
            set
            {
                mAddress = value;
            }
        }
        public string City
        {
            get
            {
                return mCity;
            }
            set
            {
                mCity = value;
            }
        }
        public string PostCode
        {
            get
            {
                return mPostCode;
            }
            set
            {
                mPostCode = value;
            }
        }


        //public property for find the Customer ID
        public bool find(int CustomerID)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the customer ID to search for
            DB.AddParameter("@CustomerID", CustomerID);
            //execute the stored procedure
            DB.Execute("sproc_tblOrder_FilterByCustomerID");

            //if one record if dound (there should be either one or zero!)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mCustomerID = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerID"]);
                mOrderID = Convert.ToString(DB.DataTable.Rows[0]["OrderID"]);
                mDateAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["DateAdded"]);
                mOrderTotalPrice = Convert.ToString(DB.DataTable.Rows[0]["OrderTotalPrice"]);
                mActive = Convert.ToBoolean(DB.DataTable.Rows[0]["Active"]);
                mSearchProduct = Convert.ToString(DB.DataTable.Rows[0]["SearchProduct"]);
                mCardName = Convert.ToString(DB.DataTable.Rows[0]["CardName"]);
                mCardNumber = Convert.ToString(DB.DataTable.Rows[0]["CardNumber"]);
                mSecurityCode = Convert.ToString(DB.DataTable.Rows[0]["SecurityCode"]);
                mExpirationDate = Convert.ToDateTime(DB.DataTable.Rows[0]["ExpirationDate"]);
                mAddress = Convert.ToString(DB.DataTable.Rows[0]["Address"]);
                mCity = Convert.ToString(DB.DataTable.Rows[0]["City"]);
                mPostCode = Convert.ToString(DB.DataTable.Rows[0]["PostCode"]);
                //return that everything worked OK
                return true;

            }
            //if no record found
            else
            {
                //return false indicating a problem
                return false;
            }
           

        }


        public bool Valid(string customerID, string orderID, string dateAdded, string orderTotalPrice, string searchProduct, string cardName, string cardNumber, string securityCode, string expirationDate, string address, string city, string postCode)
        {
            //create a Boolean variable to flag a error
            Boolean OK = true;
            //create a temporary variable to store data values
            DateTime DateTemp;
            //if the customerID is blank
            if (customerID.Length == 0)
            {
                //set the flag OK to False
                OK = false;

            }
            //if the CustomerID is greater than 6 characters
            if (customerID.Length > 6)
            {
                OK = false;
            }
            //try the date validation assuming the data is a valid date
            try
            {
                //copy the dataeAdded value to the DateTemp Variable
                DateTemp = Convert.ToDateTime(dateAdded);
                //check to see if the data is less than todya's date
                if (DateTemp < DateTime.Now.Date)
                {

                    //set the flag OK to false
                    OK = false;
                }
                //check to see if the data is greater than todays date
                if (DateTemp > DateTime.Now.Date)
                {
                    //set the flag to False
                    OK = false;
                }

            }
            //the data was not a date so flag an error
            catch
            {
                //set the flag OK to false
                OK = false;
            }
            if (postCode.Length == 0)
            {
                OK = false;
            }
            if (postCode.Length > 9)
            {
                OK = false;
            }
            if (address.Length == 0)
            {
                OK = false;
            }
            if (address.Length > 50)
            {
                OK = false;
            }
            if (orderID.Length == 0)
            {
                OK = false;
            }
            if (orderID.Length > 50)
            {
                OK = false;
            }
            if (cardName.Length == 0)
            {
                OK = false;
            }
            if (cardName.Length > 50)
            {
                OK = false;
            }
            if (cardNumber.Length == 0)
            {
                OK = false;
            }
            if (cardNumber.Length > 16)
            {
                OK = false;
            }
            if (city.Length == 0)
            {
                OK = false;
            }
            if (city.Length > 50)
            {
                OK = false;
            }
            if (searchProduct.Length == 0)
            {
                OK = false;
            }
            if (searchProduct.Length > 50)
            {
                OK = false;
            }
            if (securityCode.Length == 0)
            {
                OK = false;
            }
            if (securityCode.Length > 6)
            {
                OK = false;
            }
            //return the value of OK
            return OK;

        }

    }
}
using System;

namespace MyClassLib
{
    public class ClsCustomer
    {
        // private data member for the customer property
        private Int32 mCustomerID;
        // private data member for the customer property
        private Boolean mCustActive;
        // private data member for the customer property
        private String mAddress1;
        // private data member for the customer property
        private String mAddress2;
        // private data member for the customer property
        private String mAddress3;
        // private data member for the customer property
        private String mCity;
        // private data member for the customer property
        private String mForename;
        // private data member for the customer property
        private String mSurename;
        // private data member for the customer property
        private String mPostcode;
        // private data member for the customer property
        private String mTel;

        public ClsCustomer()
        { }

        public bool Active
        {
            get
            {
                //return the private data
                return mCustActive;
            }
            set
            {
                //set value of the private data member
                mCustActive = value;
            }
        }
        public string Address1
        {
            get
            {
                //return the private data
                return mAddress1;
            }
            set
            {
                //set value of the private data member
                mAddress1 = value;
            }
        }
        public string Address2
        {
            get
            {
                //return the private data
                return mAddress2;
            }
            set
            {
                //set value of the private data member
                mAddress2 = value;
            }
        }
        public string Address3
        {
            get
            {
                //return the private data
                return mAddress3;
            }
            set
            {
                //set value of the private data member
                mAddress3 = value;
            }
        }
        public string City
        {
            get
            {
                //return the private data
                return mCity;
            }
            set
            {
                //set value of the private data member
                mCity = value;
            }
        }
        public int CustID
        {
            get
            {
                //return the private data
                return mCustomerID;
            }
            set
            {
                //set value of the private data member
                mCustomerID = value;
            }
        }
        public string Forename
        {
            get
            {
                //return the private data
                return mForename;
            }
            set
            {
                //set value of the private data member
                mForename = value;
            }
        }
        public string Postcode
        {
            get
            {
                //return the private data
                return mPostcode;
            }
            set
            {
                //set value of the private data member
                mPostcode = value;
            }
        }
        public string Surname
        {
            get
            {
                //return the private data
                return mSurename;
            }
            set
            {
                //set value of the private data member
                mSurename = value;
            }
        }
        public string Tel
        {
            get
            {
                //return the private data
                return mTel;
            }
            set
            {
                //set value of the private data member
                mTel = value;
            }
        }

        public bool Find(int custID)
        {
            //create an instance of the data connection
            clsDataConnection  DB = new clsDataConnection();
            //add the parameter for the customerID to search for
            DB.AddParameter("@CustID", custID);
            //execute the sored proc
            DB.Execute("Sproc_Customer_filterByCustID");
            //if one record is found (there should be eitehr a one or sero)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mCustomerID = Convert.ToInt32(DB.DataTable.Rows[0]["Cust_ID"]);
                mCustActive = Convert.ToBoolean(DB.DataTable.Rows[0]["Cust_Active"]);
                mAddress1 = Convert.ToString(DB.DataTable.Rows[0]["Cust_Address1"]);
                mAddress2 = Convert.ToString(DB.DataTable.Rows[0]["Cust_Address2"]);
                mAddress3 = Convert.ToString(DB.DataTable.Rows[0]["Cust_Address3"]);
                mCity = Convert.ToString(DB.DataTable.Rows[0]["Cust_City"]);
                mForename = Convert.ToString(DB.DataTable.Rows[0]["Cust_Forename"]);
                mSurename = Convert.ToString(DB.DataTable.Rows[0]["Cust_Surname"]);
                mPostcode = Convert.ToString(DB.DataTable.Rows[0]["Cust_Postcode"]);
                mTel = Convert.ToString(DB.DataTable.Rows[0]["Cust_Tel"]);
                //return that everything worked ok
                return true;
            }
            //if no record was found
            else
            {
                //return false
                return false;
            }
        }

        public bool Valid(string address1, string address2, string address3, string city, string forename, string surname, string postcode, string tel)
        {
            //create a Boolean Variable to flag the error
            Boolean OK = true;
            //if Address1 is blank
            if(address1.Length == 0)
            {
                //set the flag OK to false
                OK = false;
            }

            //if address1 is greateed that 50
            if(address1.Length > 50)
            {
                //set flag ok is false
                OK = false;
            }

            //if address2 is blank
            if (address2.Length == 0)
            {
                //set the flag OK to false
                OK = false;
            }

            //if address3 is greateed that 50
            if (address3.Length > 50)
            {
                //set flag ok is false
                OK = false;
            }

            //if address3 is blank
            if (address3.Length == 0)
            {
                //set the flag OK to false
                OK = false;
            }

            //if address3 is greateed that 50
            if (address3.Length > 50)
            {
                //set flag ok is false
                OK = false;
            }

            //if City is blank
            if (city.Length == 0)
            {
                //set the flag OK to false
                OK = false;
            }

            //if City is greater that 20
            if (city.Length > 20)
            {
                //set flag ok is false
                OK = false;
            }

            //if forename is blank
            if (forename.Length == 0)
            {
                //set the flag OK to false
                OK = false;
            }

            //if forename is greater that 25
            if (forename.Length > 25)
            {
                //set flag ok is false
                OK = false;
            }

            //if Surname is blank
            if (surname.Length == 0)
            {
                //set the flag OK to false
                OK = false;
            }

            //if surename is greater that 25
            if (surname.Length > 25)
            {
                //set flag ok is false
                OK = false;
            }

            //if postcode is blank
            if (postcode.Length == 0)
            {
                //set the flag OK to false
                OK = false;
            }

            //if postcode is greateed that 50
            if (postcode.Length > 7)
            {
                //set flag ok is false
                OK = false;
            }

            //if the tel is greater than 11
            if(tel.Length > 11)
            {
                //set the flag ok false
                OK = false;
            }

            //if the tel is less than 11
            if(tel.Length < 11)
            {
                //set ok as false
                OK = false;
            }
            
            //return the value if OK
            return OK;
        }


    }

}
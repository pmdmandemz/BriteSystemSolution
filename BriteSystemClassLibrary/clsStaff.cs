using System;

namespace MyClassLibrary
{
    public class clsStaff
    {
        //private data member for the Staff_ID property
        private Int32 mStaff_ID;
        //private data member for Address
        private string mAddress;
        //private data member for Forename
        private string mForename;
        //private data member for Mobile
        private Int64 mMobile;
        //private data member for NI_Number
        private string mNI_Number;
        //private data member for Postcode
        private string mPostcode;
        //private data member for Salary
        private Int32 mSalary;
        //private data member for Surname
        private string mSurname;

        public string Address
        {
            get
            {
                //return the private data
                return mAddress;
            }
            set
            {
                //set the value of the private data member
                mAddress = value;
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
                //set the value of the private data member
                mForename = value;
            }
        }
        public Int64 Mobile
        {
            get
            {
                //return the private data
                return mMobile;
            }
            set
            {
                //set the value of the private data member
                mMobile = value;
            }
        }
        public string NI_Number
        {
            get
            {
                //return the private data
                return mNI_Number;
            }
            set
            {
                //set the value of the private data member
                mNI_Number = value;
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
                //set the value of the private data member
                mPostcode = value;
            }
        }
        public int Salary
        {
            get
            {
                //return the private data
                return mSalary;
            }
            set
            {
                //set the value of the private data member
                mSalary = value;
            }
        }
        //public property for the Staff_ID
        public int Staff_ID
        {
            get
            {
                //return the private data
                return mStaff_ID;
            }
            set
            {
                //set the value of the private data member
                mStaff_ID = value;
            }
        }
        public string Surname
        {
            get
            {
                //return the private data member
                return mSurname;
            }
            set
            {
                //set the value of the private data member
                mSurname = value;
            }
        }

        public bool Find(int Staff_ID)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the address no to search for
            DB.AddParameter("@Staff_ID", Staff_ID);
            //execute the stored procedure
            DB.Execute("sproc_tblStaff_FilterByStaff_ID");
            //if one record is found (there should be either one or zero)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mStaff_ID = Convert.ToInt32(DB.DataTable.Rows[0]["Staff_ID"]);
                mAddress = Convert.ToString(DB.DataTable.Rows[0]["Address"]);
                mForename = Convert.ToString(DB.DataTable.Rows[0]["Forename"]);
                mMobile = Convert.ToInt64(DB.DataTable.Rows[0]["Mobile"]);
                mNI_Number = Convert.ToString(DB.DataTable.Rows[0]["NI_Number"]);
                mPostcode = Convert.ToString(DB.DataTable.Rows[0]["Postcode"]);
                mSalary = Convert.ToInt32(DB.DataTable.Rows[0]["Salary"]);
                mSurname = Convert.ToString(DB.DataTable.Rows[0]["Surname"]);
                //return that everything worked ok
                return true;
            }
            //if no record was found
            else
            {
                //return false indicating a problem
                return false;
            }
        }

        public bool Valid(string Address, string Forename, string Mobile, string NI_Number, string Postcode, string Salary, string Surname, string Staff_ID)
        {
            //create a boolean variable to flag the error
            Boolean OK = true;
            //if the address is blank
            if (Address.Length == 0)
            {
                //set the flag OK to false
                OK = false;
            }
            //if the address is greater than 50 characters
            if (Address.Length > 50)
            {
                //set the flag Ok to false
                OK = false;
            }
            //if the forename is blank
            if (Forename.Length == 0)
            {
                //set the flag Ok to false
                OK = false;
            }
            //if the forename is greater than 25
            if (Forename.Length > 25)
            {
                //set the flag ok to false
                OK = false;
            }
            //if the mobile is less than 11 characters
            if (Mobile.Length < 11)
            {
                //set the flag Ok to false
                OK = false;
            }
            //if the mobile is greater than 11 characters
            if (Mobile.Length > 11)
            {
                //set the flag OK to false
                OK = false;
            }
            //if the NI_Number is less than 9 characters
            if (NI_Number.Length < 9)
            {
                //set the flag OK to false
                OK = false;
            }
            // if the NI_Number is greater than 9 characters
            if (NI_Number.Length > 9)
            {
                //set the flag OK to false
                OK = false;
            }
            //if the postcode is blank
            if (Postcode.Length == 0)
            {
                //set the flag OK to false
                OK = false;
            }
            //if the postcode is greather than 9 characters
            if (Postcode.Length > 9)
            {
                //set the flag Ok to false
                OK = false;
            }
            //if the salary is blank
            if (Salary.Length == 0)
            {
                //set the flag Ok to false
                OK = false;
            }
            //if the salary is greater than 7 characters
            if (Salary.Length > 7)
            {
                //set the flag Ok to false
                OK = false;
            }
            //if the Staff_ID is blank
            if (Staff_ID.Length == 0)
            {
                //set the flag OK to false
                OK = false;
            }
            //if the Staff_ID is greather than 25 characters
            if (Staff_ID.Length > 3)
            {
                //set the flag OK to false
                OK = false;
            }
            //if surname is blank
            if (Surname.Length == 0)
            {
                //set the flag OK to false
                OK = false;
            }
            //if the surname is greater than 25 characters
            if (Surname.Length > 25)
            {
                //set the flag Ok to false
                OK = false;
            }
            //return the value ok OK
            return OK;
        }
    }
}
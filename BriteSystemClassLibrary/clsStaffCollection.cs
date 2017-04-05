using System;
using System.Collections.Generic;

namespace MyClassLibrary
{
    public class clsStaffCollection
    {
        //private data member for the list
        List<clsStaff> mStaffList = new List<clsStaff>();

        //public property for count
        public int Count
        {
            get
            {
                //return the count of the list
                return mStaffList.Count;
            }
            set
            {
                //we shall worry about this later
            }
        }
        
        //public property for the staff list
        public List<clsStaff> StaffList
        {
            get
            {
                //return the private data
                return mStaffList;
            }
            set
            {
                //set the private data
                mStaffList = value;
            }
        }
        public clsStaff ThisStaff { get; set; }

        //constructor for the class
        public clsStaffCollection()
        {
            //var for index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount = 0;
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblStaff_SelectAll");
            //get the count of records
            RecordCount = DB.Count;
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank staff record
                clsStaff AStaff = new clsStaff();
                //read in the fields from the current record
                AStaff.Address = Convert.ToString(DB.DataTable.Rows[Index]["Address"]);
                AStaff.Forename = Convert.ToString(DB.DataTable.Rows[Index]["Forename"]);
                AStaff.Mobile = Convert.ToInt64(DB.DataTable.Rows[Index]["Mobile"]);
                AStaff.NI_Number = Convert.ToString(DB.DataTable.Rows[Index]["NI_Number"]);
                AStaff.Postcode = Convert.ToString(DB.DataTable.Rows[Index]["Postcode"]);
                AStaff.Salary = Convert.ToInt32(DB.DataTable.Rows[Index]["Salary"]);
                AStaff.Surname = Convert.ToString(DB.DataTable.Rows[Index]["Surname"]);
                AStaff.Staff_ID = Convert.ToInt32(DB.DataTable.Rows[Index]["Staff_ID"]);
                //add the record to the private data member
                mStaffList.Add(AStaff);
                //point at the next record
                Index++;
            }
        }
    }
}
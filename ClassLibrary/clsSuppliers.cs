using System;
using System.Data;

namespace ClassLibrary
{
    public class clsSuppliers
    {
        // Private data member for the SupplierID property
        private Int32 mSupplierId;
        // SupplierId public property
        public int SupplierId
        {
            get
            {
                // This line of code sends data out of the property
                return mSupplierId;
            }
            set
            {
                // This line of code allows data into the property
                mSupplierId = value;
            }
        }

        // Private data member for the Supplier Name property
        private string mSupplierName;
        // SupplierName public property
        public string SupplierName
        {
            get
            {
                // This line of code sends data out of the property
                return mSupplierName;
            }
            set
            {
                // This line of code allows data into the property
                mSupplierName = value;
            }
        }

        // Private data member for the Supplier ContactPhone property
        private string mContactPhone;
        // ContactPhone public property
        public string ContactPhone
        {
            get
            {
                // This line of code sends data out of the property
                return mContactPhone;
            }
            set
            {
                // This line of code allows data into the property
                mContactPhone = value;
            }
        }

        // Private data member for the ContactEmail property
        private string mContactEmail;
        // ContactEmail public property
        public string ContactEmail
        {
            get
            {
                // This line of code sends data out of the property
                return mContactEmail;
            }
            set
            {
                // This line of code allows data into the property
                mContactEmail = value;
            }
        }

        // Private data member for the ContractStartDate property
        private DateTime mContractStartDate;
        // ContractStartDate public property
        public DateTime ContractStartDate
        {
            get
            {
                //this line of code sends data out of the property
                return mContractStartDate;
            }
            set
            {
                //this line of code allows data into the property
                mContractStartDate = value;
            }
        }

        // Private data member for the ContractEndDate property
        private DateTime mContractEndDate;
        // ContractEndDate public property
        public DateTime ContractEndDate
        {
            get
            {
                // This line of code sends data out of the property
                return mContractEndDate;
            }
            set
            {
                // This line of code allows data into the property
                mContractEndDate = value;
            }
        }

        // Private data member for the IsActive property
        private Boolean mIsActive;
        public object SuppliersList;

        // IsActive public property
        public bool IsActive
        {
            get
            {
                // This line of code sends data out of the property
                return mIsActive;
            }
            set
            {
                // This line of code allows data into the property
                mIsActive = value;
            }
        }








        /****** FIND METHOD ******/
        public bool Find(int SupplierId)
        {
            // Creating an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            // Adding the paramater for the supplier id to search for
            DB.AddParameter("@SupplierId", SupplierId);
            // Executing the stored procedure
            DB.Execute("dbo.sproc_tblSuppliers_FilterBySupplierId");
            // If a record is found (There should be either one or zero)
            if (DB.Count == 1)
            {
                // Copy the data from the database to the private data members
                mSupplierId = Convert.ToInt32(DB.DataTable.Rows[0]["SupplierId"]);
                mSupplierName = Convert.ToString(DB.DataTable.Rows[0]["SupplierName"]);
                mContactPhone = Convert.ToString(DB.DataTable.Rows[0]["ContactPhone"]);
                mContactEmail = Convert.ToString(DB.DataTable.Rows[0]["ContactEmail"]);
                mContractStartDate = Convert.ToDateTime(DB.DataTable.Rows[0]["ContractStartDate"]);
                mContractEndDate = Convert.ToDateTime(DB.DataTable.Rows[0]["ContractEndDate"]);
                mIsActive = Convert.ToBoolean(DB.DataTable.Rows[0]["IsActive"]);
                // Return that everything is ok
                return true;
            }
            // If no record is found
            else
            {
                // Return false indicating there is a problem
                return false;
            }





        }

        public string Valid(string supplierName, string contactPhone, string contactEmail, string contractStartDate, string contractEndDate)
        {
            // Creating a string variable to store the error
            String Error = "";
            // Creating a temporary variable to store the data values
            DateTime DateTemp;

            // If the SupplierName is blank
            if (supplierName.Length == 0)
            {
                // Recording the error
                Error = Error + "The supplier name may not be blank : ";
            }

            // If the Supplier Name is greater than 6 characters
            if (supplierName.Length > 40)
            {
                // Recording the error
                Error = Error + "The supplier name must be less than 40 characters : ";
            }

            if (contactPhone.Length == 0)
            {
                // Recording the error
                Error = Error + "The supplier contact phone number may not be blank : ";
            }
            // If the contact phone number is greater than 11 characters
            if (contactPhone.Length > 11)
            {
                // Recording the error
                Error = Error + "The supplier contact phone number must be less than 11 characters : ";
            }

            if (contactEmail.Length == 0)
            {
                // Recording the error
                Error = Error + "The supplier contact email may not be blank : ";
            }
            // If the contact phone number is greater than 11 characters
            if (contactEmail.Length > 100)
            {
                // Recording the error
                Error = Error + "The supplier contact email must be less than 100 characters : ";
            }

            // Creating an instance of DateTime to compare with DateTemp
            // In the if statement
            DateTime DateComp = DateTime.Now.Date;
            try
            {
                // Copy the ContractStartDate value to the DateTemp variable
                DateTemp = Convert.ToDateTime(contractStartDate);
                // Check to see if the date is less than today's date
                if (DateTemp > DateComp) // Comparing dateAdded with Date
                {
                    // Recording the error
                    Error = Error + "The date cannot be in the past : ";
                }
                // Checking to see if the date is greater than today's date
                if (DateTemp > DateComp)
                {
                    // Recording the error
                }
            }
            catch
            {
                Error = Error + "The contract start date was not a valid date : ";

            }

            try
            {
                // Copy the ContractEndDate value to the DateTemp variable
                DateTemp = Convert.ToDateTime(contractEndDate);
                if (DateTemp < DateComp) // Comparing dateAdded with Date
                {
                    // Recording the error
                    Error = Error + "The date cannot be in the past : ";
                }
                // Checking to see if the date is greater than today's date
                if (DateTemp < Convert.ToDateTime(contractStartDate))
                {
                    Error = Error + "The contract end date cannot be before the start date : ";
                }
            }
            catch
            {
                //record the error
                Error = Error + "The date was not a valid date : ";
            }



            // Return any error messages
            return Error;

        }

        /********Statistics Grouped by Active METHOD*******/
        public DataTable StatisticsGroupedByIsActive()
        {
            // Create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();

            // Execute the stored procedure
            DB.Execute("sproc_tblSuppliers_Count_GroupByIsActive");
            //There should be either zero, one or more records
            return DB.DataTable;

        }
        /********Statistics Grouped by Contract Start Date METHOD*******/
        public DataTable StatisticsGroupedContractStartDate()
        {
            // Create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            // Execute the stored procedure
            DB.Execute("sproc_tblSuppliers_Count_ContractStartDate");
            //There should be either zero, one or more records
            return DB.DataTable;
        }



    }
}


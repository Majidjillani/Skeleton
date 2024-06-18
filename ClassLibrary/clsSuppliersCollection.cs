using System;
using System.Collections.Generic;
using System.Reflection;
namespace ClassLibrary

{
    public class clsSuppliersCollection
    {
        // Private data member for the list
        List<clsSuppliers> mSuppliersList = new List<clsSuppliers>();
        // Private member data for this supplier
        clsSuppliers mThisSupplier = new clsSuppliers();

        // Public property for the suppliers list
        public List<clsSuppliers> SuppliersList 
        {
            get
            { 
                // Return the private data
                return mSuppliersList;
            }
            set 
            {
                // Set the private data
                mSuppliersList = value;
            }
        }

        // Public property for count 
        public int Count 
        {
            get 
            {
                // Return the count of this list
                return mSuppliersList.Count;
            }
            set 
            { 
                // Will be done later
            } 
        }

        // Public property for this supplier
        public clsSuppliers ThisSupplier 
        {
            get 
            { 
                // Return the private data
                return mThisSupplier;
            }
            set
            {
                // Set the private data
                mThisSupplier = value;
            } 
        }


        // Constructor for the class
        public clsSuppliersCollection()
        {
            // Variable for the index
            Int32 Index = 0;
            // Variable to store the record count
            Int32 RecordCount = 0;
            // Object for the data connect
            clsDataConnection DB = new clsDataConnection();
            // Execute the stored procedure
            DB.Execute("sproc_tblSuppliers_SelectAll");
            //Populate the array list with the data table
            PopulateArray(DB);
            // Get the count of records
            RecordCount = DB.Count;
            // While there are records to process
            while (Index < RecordCount) 
            {
                // Create a blank supplier
                clsSuppliers ASupplier = new clsSuppliers();
                // Read in the fields for the current record
                ASupplier.IsActive = Convert.ToBoolean(DB.DataTable.Rows[Index]["IsActive"]);
                ASupplier.SupplierId = Convert.ToInt32(DB.DataTable.Rows[Index]["SupplierId"]);
                ASupplier.SupplierName = Convert.ToString(DB.DataTable.Rows[Index]["SupplierName"]);
                ASupplier.ContactPhone = Convert.ToString(DB.DataTable.Rows[Index]["ContactPhone"]);
                ASupplier.ContactEmail = Convert.ToString(DB.DataTable.Rows[Index]["ContactEmail"]);
                ASupplier.ContractStartDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["ContractStartDate"]);
                ASupplier.ContractEndDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["ContractEndDate"]);
                // Add the record to the private data member
                mSuppliersList.Add(ASupplier);
                //point at the next record
                Index++;
            }

        }

        public int Add()
        {
            // Adds a record to the database based on the values of mThisSupplier
            //Connects to the database
            clsDataConnection DB = new clsDataConnection();
            //Sets parameter for the stored procedure
            DB.AddParameter("@SupplierName", mThisSupplier.SupplierName);
            DB.AddParameter("@ContactPhone", mThisSupplier.ContactPhone);
            DB.AddParameter("@ContactEmail", mThisSupplier.ContactEmail);
            DB.AddParameter("@ContractStartDate", mThisSupplier.ContractStartDate);
            DB.AddParameter("@ContractEndDate", mThisSupplier.ContractEndDate);
            DB.AddParameter("@IsActive", mThisSupplier.IsActive);
            
            //Execute the query returning the primary key value
            return DB.Execute("sproc_tblSuppliers_Insert");

        }

        public void Update()
        {
            //Update an existing record based on the values of mThisSupplier
            //Connects to the database
            clsDataConnection DB = new clsDataConnection();
            //Sets parameter for the stored procedure
            DB.AddParameter("@SupplierId", mThisSupplier.SupplierId);
            DB.AddParameter("@SupplierName", mThisSupplier.SupplierName);
            DB.AddParameter("@ContactPhone", mThisSupplier.ContactPhone);
            DB.AddParameter("@ContactEmail", mThisSupplier.ContactEmail);
            DB.AddParameter("@ContractStartDate", mThisSupplier.ContractStartDate);
            DB.AddParameter("@ContractEndDate", mThisSupplier.ContractEndDate);
            DB.AddParameter("@IsActive", mThisSupplier.IsActive);
            //Execute the stored procedure
            DB.Execute("sproc_tblSuppliers_Update");
        }

        public void Delete()
        {
            // Deletes the record pointed to by this supplier
            //Connects to the database
            clsDataConnection DB = new clsDataConnection();
            // Sets the paramaters for the stored procedure
            DB.AddParameter("@SupplierId", mThisSupplier.SupplierId);
            //Execute the stored procedure
            DB.Execute("sproc_tblSuppliers_Delete");
        }

        public void ReportBySupplierName(string SupplierName)
        {
            // Filters the record based on a full or partial supplier name 
            //Connects to the database
            clsDataConnection DB = new clsDataConnection();
            // Sends the supplier name paramater from the database
            DB.AddParameter("@SupplierName", SupplierName);
            //Execute the stored procedure
            DB.Execute("sproc_tblSuppliers_FilterBySupplierName");
            //Populate the array list with the data table
            PopulateArray(DB);
        }

        void PopulateArray (clsDataConnection DB) 
        {
            //Populates the array list based on the data table in the paramater DB
            // Variable for the index
            Int32 Index = 0;
            //variable to store the record count
            Int32 RecordCount;
            RecordCount = DB.Count;
            // Clear thw private array list
            mSuppliersList = new List<clsSuppliers> ();
            // while there are records to process 
            while (Index < RecordCount)
            {
                // Create a blank supplier
                clsSuppliers ASupplier = new clsSuppliers();
                // Read in the fields for the current record
                ASupplier.IsActive = Convert.ToBoolean(DB.DataTable.Rows[Index]["IsActive"]);
                ASupplier.SupplierId = Convert.ToInt32(DB.DataTable.Rows[Index]["SupplierId"]);
                ASupplier.SupplierName = Convert.ToString(DB.DataTable.Rows[Index]["SupplierName"]);
                ASupplier.ContactPhone = Convert.ToString(DB.DataTable.Rows[Index]["ContactPhone"]);
                ASupplier.ContactEmail = Convert.ToString(DB.DataTable.Rows[Index]["ContactEmail"]);
                ASupplier.ContractStartDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["ContractStartDate"]);
                ASupplier.ContractEndDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["ContractEndDate"]);
                // Add the record to the private data member
                mSuppliersList.Add(ASupplier);
                //point at the next record
                Index++;
            }
        }
    }
    
}
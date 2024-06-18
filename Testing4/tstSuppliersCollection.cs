using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing4
{
    [TestClass]
    public class tstSuppliersCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            // Creating an instance of the class I want to create
            clsSuppliersCollection AllSuppliers = new clsSuppliersCollection();
            // Tests to see that it is OK
            Assert.IsNotNull(AllSuppliers);
        }

        [TestMethod]
        public void SuppliersListOK ()
        {
            // Creating an instance of the class I want to create
            clsSuppliersCollection AllSuppliers = new clsSuppliersCollection();
            // Create some test data to assign to this property
            // in this case the data needs to be a list of objects
            List<clsSuppliers> TestList = new List<clsSuppliers>();
            // Add an item to the list
            // Create the item of test data
            clsSuppliers TestItem = new clsSuppliers();
            // Set it's properties
            TestItem.IsActive = true;
            TestItem.SupplierId = 1;
            TestItem.SupplierName = "Albion Engineering Ltd";
            TestItem.ContactPhone = "02079460953";
            TestItem.ContactEmail = "contact@albioneng.co.uk";
            TestItem.ContractStartDate = DateTime.Now;
            TestItem.ContractEndDate = DateTime.Now;
            // Add the items to the test list
            TestList.Add(TestItem);
            // Assign the data to the test property
            AllSuppliers.SuppliersList = TestList;
            // Test to see that the two values are the same
            Assert.AreEqual(AllSuppliers.SuppliersList , TestList);
        }


        [TestMethod]
        public void ThisSupplierPropertyOK()
        {
            // Creating an instance of the class I want to create
            clsSuppliersCollection AllSuppliers = new clsSuppliersCollection();
            // Create some test data to assign to this property
            clsSuppliers TestSuppliers = new clsSuppliers();
            // Set it's properties
            TestSuppliers.IsActive = true;
            TestSuppliers.SupplierId = 1;
            TestSuppliers.SupplierName = "Albion Engineering Ltd";
            TestSuppliers.ContactPhone = "02079460953";
            TestSuppliers.ContactEmail = "contact@albioneng.co.uk";
            TestSuppliers.ContractStartDate = DateTime.Now;
            TestSuppliers.ContractEndDate = DateTime.Now;
            // Assign the data to the test property
            AllSuppliers.ThisSupplier = TestSuppliers;
            // Test to see that the two values are the same
            Assert.AreEqual(AllSuppliers.ThisSupplier, TestSuppliers);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            // Creating an instance of the class I want to create
            clsSuppliersCollection AllSuppliers = new clsSuppliersCollection();
            // Create some test data to assign to this property
            // in this case the data needs to be a list of objects
            List<clsSuppliers> TestList = new List<clsSuppliers>();
            // Add an item to the list
            // Create the item of test data
            clsSuppliers TestItem = new clsSuppliers();
            // Set it's properties
            TestItem.IsActive = true;
            TestItem.SupplierId = 1;
            TestItem.SupplierName = "Albion Engineering Ltd";
            TestItem.ContactPhone = "02079460953";
            TestItem.ContactEmail = "contact@albioneng.co.uk";
            TestItem.ContractStartDate = DateTime.Now;
            TestItem.ContractEndDate = DateTime.Now;
            // Add the items to the test list
            TestList.Add(TestItem);
            // Assign the data to the test property
            AllSuppliers.SuppliersList = TestList;
            // Test to see that the two values are the same
            Assert.AreEqual(AllSuppliers.SuppliersList, TestList);
        }

        [TestMethod]
        public void AddMethodOK()
        {

            // Creating an instance of the class I want to create
            clsSuppliersCollection AllSuppliers = new clsSuppliersCollection();
            // Create the item of test data
            clsSuppliers TestItem = new clsSuppliers();
            // Variable to store the primary key
            Int32 PrimaryKey = 0;
            // Setting it's properties
            TestItem.IsActive = true;
            TestItem.SupplierId = 1;
            TestItem.SupplierName = "Albion Engineering Ltd";
            TestItem.ContactPhone = "02079460953";
            TestItem.ContactEmail = "contact@albioneng.co.uk";
            TestItem.ContractStartDate = DateTime.Now;
            TestItem.ContractEndDate = DateTime.Now;
            // Set ThisSupplier to the test data
            AllSuppliers.ThisSupplier = TestItem;
            // Add the record
            PrimaryKey = AllSuppliers.Add();
            // Set the primary ket of the test data
            TestItem.SupplierId = PrimaryKey;
            // Find the record
            AllSuppliers.ThisSupplier.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllSuppliers.ThisSupplier, TestItem);
        }

        [TestMethod]

        public void UpdateMethodOK()
        {
            // Creating an instance of the class I want to create
            clsSuppliersCollection AllSuppliers = new clsSuppliersCollection();
            // Create the item of test data
            clsSuppliers TestItem = new clsSuppliers();
            // Variable to store the primary key
            Int32 PrimaryKey = 0;
            // Setting it's properties
            TestItem.IsActive = true;
            TestItem.SupplierId = 1;
            TestItem.SupplierName = "Albion Engineering Ltd";
            TestItem.ContactPhone = "02079460953";
            TestItem.ContactEmail = "contact@albioneng.co.uk";
            TestItem.ContractStartDate = DateTime.Now;
            TestItem.ContractEndDate = DateTime.Now;
            // Set ThisSupplier to the test data
            AllSuppliers.ThisSupplier = TestItem;
            // Add the record
            PrimaryKey = AllSuppliers.Add();
            // Set the primary ket of the test data
            TestItem.SupplierId = PrimaryKey;
            // Modify the test record
            TestItem.IsActive = false;
            TestItem.SupplierId = 4;
            TestItem.SupplierName = "Ireland IT solutions";
            TestItem.ContactPhone = "02354530912";
            TestItem.ContactEmail = "irelandittech@gmail.com";
            TestItem.ContractStartDate = DateTime.Now;
            TestItem.ContractEndDate = DateTime.Now;
            // Set the record based on the new test data 
            AllSuppliers.ThisSupplier = TestItem;
            //update the record
            AllSuppliers.Update();
            //find the record
            AllSuppliers.ThisSupplier.Find(PrimaryKey);
            //test to see if ThisAddress matches the test data 
            Assert.AreEqual(AllSuppliers.ThisSupplier, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            // Creating an instance of the class I want to create
            clsSuppliersCollection AllSuppliers = new clsSuppliersCollection();
            // Creates the item of test data
            clsSuppliers TestItem = new clsSuppliers();
            // Variable to store the primary key
            Int32 PrimaryKey = 0;
            // Setting it's properties
            TestItem.IsActive = true;
            TestItem.SupplierId = 1;
            TestItem.SupplierName = "Albion Engineering Ltd";
            TestItem.ContactPhone = "02079460953";
            TestItem.ContactEmail = "contact@albioneng.co.uk";
            TestItem.ContractStartDate = DateTime.Now;
            TestItem.ContractEndDate = DateTime.Now;
            // Set ThisSupplier to the test data
            AllSuppliers.ThisSupplier = TestItem;
            // Add the record
            PrimaryKey = AllSuppliers.Add();
            // Set the primary ket of the test data
            TestItem.SupplierId = PrimaryKey;
            //find the record
            AllSuppliers.ThisSupplier.Find(PrimaryKey);
            // Delete the record
            AllSuppliers.Delete();
            // Now find the record
            Boolean Found = AllSuppliers.ThisSupplier.Find(PrimaryKey);
            //test to see that the record was not found 
            Assert.IsFalse(Found);
        }

        [TestMethod]

        public void ReportBySupplierName(string SupplierName)
        {

            // Creating an instance of the class I want to create
            clsSuppliersCollection AllSuppliers = new clsSuppliersCollection();
            // Creating an instance filtered suppliers
            clsSuppliersCollection FilteredSuppliers = new clsSuppliersCollection();
            // Apply a blank string, should retutn all records
            FilteredSuppliers.ReportBySupplierName("");
            //test to see that the two values are the same
            Assert.AreEqual(AllSuppliers.Count, FilteredSuppliers.Count);
        }

        [TestMethod]
        public void ReportBySupplierNameNoneFound()
        {

            // Creating an instance of the class I want to create
            clsSuppliersCollection FilteredsSuppliers = new clsSuppliersCollection();
            // Creating an instance filtered suppliers
            clsSuppliersCollection FilteredSuppliers = new clsSuppliersCollection();
            // Applying a Supplier name which doesn't exist 
            FilteredSuppliers.ReportBySupplierName("");
            //test to see that there are no records
            Assert.AreEqual(0, FilteredSuppliers.Count);
        }

        [TestMethod]
        public void ReportBySupplierNameTestDataFound()
        {

            // Creating an instance of the class I want to create
            clsSuppliersCollection FilteredsSuppliers = new clsSuppliersCollection();
            // Creating an instance filtered suppliers
            clsSuppliersCollection FilteredSuppliers = new clsSuppliersCollection();
            // Variable to store the outcome
            Boolean OK = true;
            // Apply a supplier name that doesn't exist
            FilteredSuppliers.ReportBySupplierName("Birmingham");
            // Check that the correct number of records are found
            if (FilteredSuppliers.Count == 2)
            {
                // Check to see that the first record is 4
                if (FilteredSuppliers.SuppliersList[0].SupplierId != 4)
                {
                    OK = false;
                }
                // Check to see that the first record is 10
                if (FilteredSuppliers.SuppliersList[0].SupplierId != 10)
                {
                    OK = false;
                }
            }

            else
            {
                OK = false;
                // Test to see that there are no records
                Assert.IsTrue(OK);
            }

        }
    }
}

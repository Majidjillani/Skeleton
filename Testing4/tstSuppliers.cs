using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data;

namespace Testing4
{
    [TestClass]
    public class tstSuppliers
    {

        // Good Test Data
        // Create some tests to pass the data
        string SupplierName = "London Tech";
        string ContactPhone = "01162349865";
        string ContactEmail = "support@londontech.com";
        string ContractStartDate = "24/03/2022";
        string ContractEndDate = "24/04/2026";

        /******************INSTANCE OF THE CLASS TEST******************/
        [TestMethod]
        public void InstanceOK()
        {
            // Creating an instance of the class I want to create
            clsSuppliers ASupplier = new clsSuppliers();
            // Testing to see that it actually exists
            Assert.IsNotNull(ASupplier);
        }

        /******************PROPERTY OK TESTS******************/
        [TestMethod]
        public void IsActivePropertyOK()
        {
            // Creating an instance of the class I want to create
            clsSuppliers ASupplier = new clsSuppliers();
            // Creating some test data to assign to this property
            Boolean TestData = true;
            // Assigning the data to this property
            ASupplier.IsActive = TestData;
            // Testing to see that both these values are the same
            Assert.AreEqual(ASupplier.IsActive, TestData);
        }

        /***Contract Start Date Property Test ***/
        [TestMethod]
        public void ContractStartDatePropertyOK()
        {
            // Creating an instance of the class I want to create
            clsSuppliers ASupplier = new clsSuppliers();
            // Creating some test data to assign to this property
            DateTime TestData = DateTime.Now.Date;
            // Assigning the data to this property
            ASupplier.ContractStartDate = TestData;
            // Testing to see that both these values are the same
            Assert.AreEqual(ASupplier.ContractStartDate, TestData);
        }

        /***Contract End Date Property Test ***/
        [TestMethod]
        public void ContractEndDatePropertyOK()
        {
            // Creating an instance of the class I want to create
            clsSuppliers ASupplier = new clsSuppliers();
            // Creating some test data to assign to this property
            DateTime TestData = DateTime.Now.Date;
            // Assigning the data to this property
            ASupplier.ContractEndDate = TestData;
            // Testing to see that both these values are the same
            Assert.AreEqual(ASupplier.ContractEndDate, TestData);


        }

        /***Supplier ID Property Test ***/
        [TestMethod]
        public void SupplierIdPropertyOK()
        {
            // Creating an instance of the class I want to create
            clsSuppliers ASupplier = new clsSuppliers();
            // Creating some test data to assign to this property
            Int32 TestData = 1;
            // Assigning the data to this property
            ASupplier.SupplierId = TestData;
            // Testing to see that both these values are the same
            Assert.AreEqual(ASupplier.SupplierId, TestData);
        }

        /***Supplier Name Property Test ***/
        [TestMethod]
        public void SupplierNamePropertyOK()
        {
            // Creating an instance of the class I want to create
            clsSuppliers ASupplier = new clsSuppliers();
            // Creating some test data to assign to this property
            string TestData = "Birmingham Tech Ltd";
            // Assigning the data to this property
            ASupplier.SupplierName = TestData;
            // Testing to see that both these values are the same
            Assert.AreEqual(ASupplier.SupplierName, TestData);


        }

        /***Contact Phone Property Test ***/
        [TestMethod]
        public void ContactPhonePropertyOK()
        {
            // Creating an instance of the class I want to test
            clsSuppliers ASupplier = new clsSuppliers();
            // Creating some test data to assign to this property
            string TestData = "01133468290";
            // Assigning the data to this property
            ASupplier.ContactPhone = TestData;
            // Testing to see that both these values are the same
            Assert.AreEqual(ASupplier.ContactPhone, TestData);
        }

        /***Contact Email Property Tests ***/
        [TestMethod]
        public void ContactEmailPropertyOK()
        {
            // Creating an instance of the class I want to test
            clsSuppliers ASupplier = new clsSuppliers();
            // Creating some test data to assign to this property
            string TestData = "example@example.com";
            // Assigning the data to this property
            ASupplier.ContactEmail = TestData;
            // Testing to see that both these values are the same
            Assert.AreEqual(ASupplier.ContactEmail, TestData);
        }

        /******************FIND METHOD TEST******************/
        [TestMethod]
        public void FindMethodOK()
        {
            // Creating an instance of the class I want to test
            clsSuppliers ASupplier = new clsSuppliers();
            // Creating a Boolean variable to store the results of the validation
            Boolean Found = false;
            // Creating some test data to use with the method
            Int32 SupplierId = 8;
            // Invoking the method
            Found = ASupplier.Find(SupplierId);
            // Testing to see if the result is true
            Assert.IsTrue(Found);
        }

        /******************PROPERTY DATA TESTS******************/
        [TestMethod]
        public void TestSupplierIdFound()
        {
            // Creating an instance of the class I want to create
            clsSuppliers ASupplier = new clsSuppliers();
            // Creating a Boolean variable to store the result of the search
            Boolean Found = false;
            // Creating a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            // Creating some test data to use with the method
            Int32 SupplierId = 8;
            // Invoking the method
            Found = ASupplier.Find(SupplierId);
            // Checking the supplier id property
            if (ASupplier.SupplierId != 8)
            {
                OK = false;
            }
            // Testing to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestSupplierNameFound()
        {
            // Creating an instance of the class I want to create
            clsSuppliers ASupplier = new clsSuppliers();
            // Creating a Boolean variable to store the result of the search
            Boolean Found = false;
            // Creating a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            // Creating some test data to use with the method
            Int32 SupplierId = 8;
            // Invoking the method
            Found = ASupplier.Find(SupplierId);
            // Checking the supplier name property
            if (ASupplier.SupplierName != "Bristol Ergonomic Keyboards")
            {
                OK = false;
            }
            // Testing to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestContactPhoneNumberFound()
        {
            // Creating an instance of the class I want to create
            clsSuppliers ASupplier = new clsSuppliers();
            // Creating a Boolean variable to store the result of the search
            Boolean Found = false;
            // Creating a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            // Creating some test data to use with the method
            Int32 SupplierId = 8;
            // Invoking the method
            Found = ASupplier.Find(SupplierId);
            // Checking the supplier contact number property
            if (ASupplier.ContactPhone != "01162349876")
            {
                OK = false;
            }
            // Testing to see that the result is correct
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestContactEmailAddressFound()
        {
            // Creating an instance of the class I want to create
            clsSuppliers ASupplier = new clsSuppliers();
            // Creating a Boolean variable to store the result of the search
            Boolean Found = false;
            // Creating a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            // Creating some test data to use with the method
            Int32 SupplierId = 8;
            // Invoking the method
            Found = ASupplier.Find(SupplierId);
            // Checking the supplier contact email property
            if (ASupplier.ContactEmail != "hello@bristolergo.com")
            {
                OK = false;
            }
            // Test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestContractStartDateFound()
        {
            // Creating an instance of the class I want to create
            clsSuppliers ASupplier = new clsSuppliers();
            // Creating a Boolean variable to store the result of the search
            Boolean Found = false;
            // Creating a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            // Creating some test data to use with the method
            Int32 SupplierId = 8;
            // Invoking the method
            Found = ASupplier.Find(SupplierId);
            // Checking the supplier contract start date property
            if (ASupplier.ContractStartDate != Convert.ToDateTime("01/01/2022"))
            {
                OK = false;
            }
            // Testing to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestContractEndDateFound()
        {
            // Creating an instance of the class I want to create
            clsSuppliers ASupplier = new clsSuppliers();
            // Creating a Boolean variable to store the result of the search
            Boolean Found = false;
            // Creating a Boolean variable to store the result of the search
            Boolean OK = true;
            // Creating some test data to use with the method
            Int32 SupplierId = 8;
            // Invoking the method
            Found = ASupplier.Find(SupplierId);
            // Checking the supplier contract end date property
            if (ASupplier.ContractEndDate != Convert.ToDateTime("05/02/2030"))
            {
                OK = false;
            }
            // Testing to see that the result is correct
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestIsActiveFound()
        {
            // Creating an instance of the class I want to create
            clsSuppliers ASupplier = new clsSuppliers();
            // Creating a Boolean variable to store the result of the searc
            Boolean Found = false;
            // Creating a Boolean variable to store the result of the search
            Boolean OK = true;
            //create some test data to use with the method
            Int32 SupplierId = 8;
            // Invoking the method
            Found = ASupplier.Find(SupplierId);
            // Checking the active property
            if (ASupplier.IsActive != false)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            // Creating an instance of the class I want to create
            clsSuppliers ASupplier = new clsSuppliers();
            // String variable to store any error message
            string Error = "";
            // Invoke the method
            Error = ASupplier.Valid(SupplierName, ContactPhone, ContactEmail, ContractStartDate, ContractEndDate);
            // Test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        //Supplier Name Tests
        [TestMethod]
        public void SupplierNameMinLessOne()
        {
            // Creating an instance of the class I want to create
            clsSuppliers ASupplier = new clsSuppliers();
            //string variable to store any error message
            String Error = "";
            // Creating some test data to pass to the method
            string SupplierName = ""; // This should trigger an error
            // Invoking the method
            Error = ASupplier.Valid(SupplierName, ContactPhone, ContactEmail, ContractStartDate, ContractEndDate);
            // Testing to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SupplierNameMin()
        {
            // Creating an instance of the class I want to create
            clsSuppliers ASupplier = new clsSuppliers();
            //string variable to store any error message
            String Error = "";
            // This should pass
            string SupplierName = "k";
            // Invoking the method
            Error = ASupplier.Valid(SupplierName, ContactPhone, ContactEmail, ContractStartDate, ContractEndDate);
            // Testing to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SupplierNameMinPlusOne()
        {
            // Creating an instance of the class I want to create
            clsSuppliers ASupplier = new clsSuppliers();
            //string variable to store any error message
            String Error = "";
            // This should pass
            string SupplierName = "km";
            // Invoking the method
            Error = ASupplier.Valid(SupplierName, ContactPhone, ContactEmail, ContractStartDate, ContractEndDate);
            // Testing to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void SupplierNameMaxLessOne()
        {
            // Creating an instance of the class I want to create
            clsSuppliers ASupplier = new clsSuppliers();
            //string variable to store any error message
            String Error = "";
            // This should pass
            string SupplierName = "";
            SupplierName = SupplierName.PadRight(39, 'd');
            // Invoking the method
            Error = ASupplier.Valid(SupplierName, ContactPhone, ContactEmail, ContractStartDate, ContractEndDate);
            // Testing to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SupplierNameMax()
        {
            // Creating an instance of the class I want to create
            clsSuppliers ASupplier = new clsSuppliers();
            //string variable to store any error message
            String Error = "";
            // This should pass
            string SupplierName = "";
            SupplierName = SupplierName.PadRight(40, 'd');
            // Invoking the method
            Error = ASupplier.Valid(SupplierName, ContactPhone, ContactEmail, ContractStartDate, ContractEndDate);
            // Testing to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SupplierNameMaxPlusOne()
        {
            // Creating an instance of the class I want to create
            clsSuppliers ASupplier = new clsSuppliers();
            //string variable to store any error message
            String Error = "";
            // This should fail
            string SupplierName = "";
            SupplierName = SupplierName.PadRight(41, 'd'); //This should fail
            // Invoking the method
            Error = ASupplier.Valid(SupplierName, ContactPhone, ContactEmail, ContractStartDate, ContractEndDate);
            // Testing to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SupplierNameMid()
        {
            // Creating an instance of the class I want to create
            clsSuppliers ASupplier = new clsSuppliers();
            //string variable to store any error message
            String Error = "";
            // This should pass
            string SupplierName = "";
            SupplierName = SupplierName.PadRight(20, 'd');
            // Invoking the method
            Error = ASupplier.Valid(SupplierName, ContactPhone, ContactEmail, ContractStartDate, ContractEndDate);
            // Testing to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SupplierNameExtremeMax()
        {
            // Creating an instance of the class I want to create
            clsSuppliers ASupplier = new clsSuppliers();
            //string variable to store any error message
            String Error = "";
            // This should fail
            string SupplierName = "";
            SupplierName = SupplierName.PadRight(1500, 'd'); //This should fail
            // Invoking the method
            Error = ASupplier.Valid(SupplierName, ContactPhone, ContactEmail, ContractStartDate, ContractEndDate);
            // Testing to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        //Supplier Contact Phone Number Tests
        [TestMethod]
        public void ContactPhoneMinLessOne()
        {
            // Creating an instance of the class I want to create
            clsSuppliers ASupplier = new clsSuppliers();
            //string variable to store any error message
            String Error = "";
            // This should fail
            string ContactPhone = "";
            // Invoking the method
            Error = ASupplier.Valid(SupplierName, ContactPhone, ContactEmail, ContractStartDate, ContractEndDate);
            // Testing to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ContactPhoneMin()
        {
            // Creating an instance of the class I want to create
            clsSuppliers ASupplier = new clsSuppliers();
            //string variable to store any error message
            String Error = "";
            // This should pass
            string ContactPhone = "0";
            // Invoking the method
            Error = ASupplier.Valid(SupplierName, ContactPhone, ContactEmail, ContractStartDate, ContractEndDate);
            // Testing to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ContactPhoneMinPlusOne()
        {
            // Creating an instance of the class I want to create
            clsSuppliers ASupplier = new clsSuppliers();
            //string variable to store any error message
            String Error = "";
            // This should pass
            string ContactPhone = "03";
            // Invoking the method
            Error = ASupplier.Valid(SupplierName, ContactPhone, ContactEmail, ContractStartDate, ContractEndDate);
            // Testing to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void ContactPhoneMaxLessOne()
        {
            // Creating an instance of the class I want to create
            clsSuppliers ASupplier = new clsSuppliers();
            //string variable to store any error message
            String Error = "";
            // This should pass
            string ContactPhone = "";
            ContactPhone = ContactPhone.PadRight(10, '0');
            // Invoking the method
            Error = ASupplier.Valid(SupplierName, ContactPhone, ContactEmail, ContractStartDate, ContractEndDate);
            // Testing to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ContactPhoneMax()
        {
            // Creating an instance of the class I want to create
            clsSuppliers ASupplier = new clsSuppliers();
            //string variable to store any error message
            String Error = "";
            // This should pass
            string ContactPhone = "";
            ContactPhone = ContactPhone.PadRight(11, '0');
            // Invoking the method
            Error = ASupplier.Valid(SupplierName, ContactPhone, ContactEmail, ContractStartDate, ContractEndDate);
            // Testing to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ContactPhoneMaxPlusOne()
        {
            // Creating an instance of the class I want to create
            clsSuppliers ASupplier = new clsSuppliers();
            //string variable to store any error message
            String Error = "";
            // This should fail
            string ContactPhone = "";
           ContactPhone = ContactPhone.PadRight(12, '0');
            // Invoking the method
            Error = ASupplier.Valid(SupplierName, ContactPhone, ContactEmail, ContractStartDate, ContractEndDate);
            // Testing to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ContactPhoneMid()
        {
            // Creating an instance of the class I want to create
            clsSuppliers ASupplier = new clsSuppliers();
            //string variable to store any error message
            String Error = "";
            // This should pass
            string ContactPhone = "";
            ContactPhone = ContactPhone.PadRight(6, '0');
            // Invoking the method
            Error = ASupplier.Valid(SupplierName, ContactPhone, ContactEmail, ContractStartDate, ContractEndDate);
            // Testing to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ContactPhoneExtremeMax()
        {
            // Creating an instance of the class I want to create
            clsSuppliers ASupplier = new clsSuppliers();
            //string variable to store any error message
            String Error = "";
            // This should fail
            string ContactPhone = "";
            ContactPhone = ContactPhone.PadRight(100, '0');
            // Invoking the method
            Error = ASupplier.Valid(SupplierName, ContactPhone, ContactEmail, ContractStartDate, ContractEndDate);
            // Testing to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        //Supplier Email Address Tests
        [TestMethod]
        public void ContactEmailMinLessOne()
        {
            // Creating an instance of the class I want to create
            clsSuppliers ASupplier = new clsSuppliers();
            //string variable to store any error message
            String Error = "";
            // This should fail
            string ContactEmail = "";
            // Invoking the method
            Error = ASupplier.Valid(SupplierName, ContactPhone, ContactEmail, ContractStartDate, ContractEndDate);
            // Testing to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ContactEmailMin()
        {
            // Creating an instance of the class I want to create
            clsSuppliers ASupplier = new clsSuppliers();
            //string variable to store any error message
            String Error = "";
            // This should pass
            string ContactEmail = "p";
            // Invoking the method
            Error = ASupplier.Valid(SupplierName, ContactPhone, ContactEmail, ContractStartDate, ContractEndDate);
            // Testing to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ContactEmailMinPlusOne()
        {
            // Creating an instance of the class I want to create
            clsSuppliers ASupplier = new clsSuppliers();
            //string variable to store any error message
            String Error = "";
            // This should pass
            string ContactEmail = "pa";
            // Invoking the method
            Error = ASupplier.Valid(SupplierName, ContactPhone, ContactEmail, ContractStartDate, ContractEndDate);
            // Testing to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void ContactEmailMaxLessOne()
        {
            // Creating an instance of the class I want to create
            clsSuppliers ASupplier = new clsSuppliers();
            //string variable to store any error message
            String Error = "";
            // This should pass
            string ContactEmail = "";
            ContactEmail = ContactEmail.PadRight(99, 'p');
            // Invoking the method
            Error = ASupplier.Valid(SupplierName, ContactPhone, ContactEmail, ContractStartDate, ContractEndDate);
            // Testing to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ContactEmailMax()
        {
            // Creating an instance of the class I want to create
            clsSuppliers ASupplier = new clsSuppliers();
            //string variable to store any error message
            String Error = "";
            // This should pass
            string ContactEmail = "";
            ContactEmail = ContactEmail.PadRight(100, 'p');
            // Invoking the method
            Error = ASupplier.Valid(SupplierName, ContactPhone, ContactEmail, ContractStartDate, ContractEndDate);
            // Testing to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ContactEmailMaxPlusOne()
        {
            // Creating an instance of the class I want to create
            clsSuppliers ASupplier = new clsSuppliers();
            //string variable to store any error message
            String Error = "";
            // This should fail
            string ContactEmail = "";
            ContactEmail = ContactEmail.PadRight(101, 'p');
            // Invoking the method
            Error = ASupplier.Valid(SupplierName, ContactPhone, ContactEmail, ContractStartDate, ContractEndDate);
            // Testing to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ContactEmailMid()
        {
            // Creating an instance of the class I want to create
            clsSuppliers ASupplier = new clsSuppliers();
            //string variable to store any error message
            String Error = "";
            // This should pass
            string ContactEmail = "";
            ContactEmail = ContactEmail.PadRight(50, 'p');
            // Invoking the method
            Error = ASupplier.Valid(SupplierName, ContactPhone, ContactEmail, ContractStartDate, ContractEndDate);
            // Testing to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ContactEmailExtremeMax()
        {
            // Creating an instance of the class I want to create
            clsSuppliers ASupplier = new clsSuppliers();
            // String variable to store any error message
            String Error = "";
            // This should fail
            string ContactEmail = "";
            ContactEmail = ContactEmail.PadRight(2500, 'p');
            // Invoking the method
            Error = ASupplier.Valid(SupplierName, ContactPhone, ContactEmail, ContractStartDate, ContractEndDate);
            // Testing to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        // Supplier contract start date tests

        [TestMethod]
        public void ContractStartDateExtremeMin()
        {
            // Creating an instance of the class I want to create
            clsSuppliers ASupplier = new clsSuppliers();
            // String variable to store any error message
            String Error = "";
            // Creating a variable to store the test date data
            DateTime TestDate;
            // Setting the date to today's date
            TestDate = DateTime.Now.Date;
            // Chhanging the date to whatever the date is less 150 years
            TestDate = TestDate.AddYears(-150);
            // Converting the date variable to a string variable
            string ContractStartDate = TestDate.ToString();
            // Invoking the method
            Error = ASupplier.Valid(SupplierName, ContactPhone, ContactEmail, ContractStartDate, ContractEndDate);
            // Testing to see that the result is correct
            Assert.AreEqual(Error, "");
        }



        [TestMethod]
        public void ContractStartDateMinLessOne()
        {
            // Creating an instance of the class I want to create
            clsSuppliers ASupplier = new clsSuppliers();
            // String variable to store any error message
            String Error = "";
            // Creating a variable to store the test date data
            DateTime TestDate;
            // Setting the date to today's date
            TestDate = DateTime.Now.Date;
            // Chhanging the date to whatever the date is minus one day
            TestDate = TestDate.AddDays(-1);
            // Converting the date variable to a string variable
            string ContractStartDate = TestDate.ToString();
            // Invoking the method
            Error = ASupplier.Valid(SupplierName, ContactPhone, ContactEmail, ContractStartDate, ContractEndDate);
            // Testing to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ContractStartDateMin()
        {
            // Creating an instance of the class I want to create
            clsSuppliers ASupplier = new clsSuppliers();
            // String variable to store any error message
            String Error = "";
            // Creating a variable to store the test date data
            DateTime TestDate;
            // Setting the date to today's date
            TestDate = DateTime.Now.Date;
            // Converting the date variable to a string variable
            string ContractStartDate = TestDate.ToString();
            // Invoking the method
            Error = ASupplier.Valid(SupplierName, ContactPhone, ContactEmail, ContractStartDate, ContractEndDate);
            // Testing to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void ContractStartDateMinPlusOne()
        {
            // Creating an instance of the class I want to create
            clsSuppliers ASupplier = new clsSuppliers();
            // String variable to store any error message
            String Error = "";
            // Creating a variable to store the test date data
            DateTime TestDate;
            // Setting the date to today's date
            TestDate = DateTime.Now.Date;
            // Chhanging the date to whatever the date is plus one day
            TestDate = TestDate.AddDays(1);
            // Converting the date variable to a string variable
            string ContractStartDate = TestDate.ToString();
            // Invoking the method
            Error = ASupplier.Valid(SupplierName, ContactPhone, ContactEmail, ContractStartDate, ContractEndDate);
            // Testing to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void ContractStartDateExtremeMax()
        {
            // Creating an instance of the class I want to create
            clsSuppliers ASupplier = new clsSuppliers();
            // String variable to store any error message
            String Error = "";
            // Creating a variable to store the test date data
            DateTime TestDate;
            // Setting the date to today's date
            TestDate = DateTime.Now.Date;
            // Chhanging the date to whatever the date is plus 150 years
            TestDate = TestDate.AddYears(150);
            // Converting the date variable to a string variable
            string ContractStartDate = TestDate.ToString();
            // Invoking the method
            Error = ASupplier.Valid(SupplierName, ContactPhone, ContactEmail, ContractStartDate, ContractEndDate);
            // Testing to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        // Supplier contract end date tests

        [TestMethod]
        public void ContractEndDateExtremeMin()
        {
            // Creating an instance of the class I want to create
            clsSuppliers ASupplier = new clsSuppliers();
            // String variable to store any error message
            String Error = "";
            // Creating a variable to store the test date data
            DateTime TestDate;
            // Setting the date to today's date
            TestDate = DateTime.Now.Date;
            // Chhanging the date to whatever the date is less 150 years
            TestDate = TestDate.AddYears(-150);
            // Converting the date variable to a string variable
            string ContractEndDate = TestDate.ToString();
            // Invoking the method
            Error = ASupplier.Valid(SupplierName, ContactPhone, ContactEmail, ContractStartDate, ContractEndDate);
            // Testing to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }



        [TestMethod]
        public void ContractEndDateMinLessOne()
        {
            // Creating an instance of the class I want to create
            clsSuppliers ASupplier = new clsSuppliers();
            // String variable to store any error message
            String Error = "";
            // Creating a variable to store the test date data
            DateTime TestDate;
            // Setting the date to today's date
            TestDate = DateTime.Now.Date;
            // Chhanging the date to whatever the date is minus one day
            TestDate = TestDate.AddDays(-1);
            // Converting the date variable to a string variable
            string ContractEndDate = TestDate.ToString();
            // Invoking the method
            Error = ASupplier.Valid(SupplierName, ContactPhone, ContactEmail, ContractStartDate, ContractEndDate);
            // Testing to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ContractEndDateMin()
        {
            // Creating an instance of the class I want to create
            clsSuppliers ASupplier = new clsSuppliers();
            // String variable to store any error message
            String Error = "";
            // Creating a variable to store the test date data
            DateTime TestDate;
            // Setting the date to today's date
            TestDate = DateTime.Now.Date;
            // Converting the date variable to a string variable
            string ContractEndDate = TestDate.ToString();
            // Invoking the method
            Error = ASupplier.Valid(SupplierName, ContactPhone, ContactEmail, ContractStartDate, ContractEndDate);
            // Testing to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void ContractEndDateMinPlusOne()
        {
            // Creating an instance of the class I want to create
            clsSuppliers ASupplier = new clsSuppliers();
            // String variable to store any error message
            String Error = "";
            // Creating a variable to store the test date data
            DateTime TestDate;
            // Setting the date to today's date
            TestDate = DateTime.Now.Date;
            // Chhanging the date to whatever the date is plus one day
            TestDate = TestDate.AddDays(1);
            // Converting the date variable to a string variable
            string ContractEndDate = TestDate.ToString();
            // Invoking the method
            Error = ASupplier.Valid(SupplierName, ContactPhone, ContactEmail, ContractStartDate, ContractEndDate);
            // Testing to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void ContractEndDateExtremeMax()
        {
            // Creating an instance of the class I want to create
            clsSuppliers ASupplier = new clsSuppliers();
            // String variable to store any error message
            String Error = "";
            // Creating a variable to store the test date data
            DateTime TestDate;
            // Setting the date to today's date
            TestDate = DateTime.Now.Date;
            // Chhanging the date to whatever the date is plus 150 years
            TestDate = TestDate.AddYears(150);
            // Converting the date variable to a string variable
            string ContractEndDate = TestDate.ToString();
            // Invoking the method
            Error = ASupplier.Valid(SupplierName, ContactPhone, ContactEmail, ContractStartDate, ContractEndDate);
            // Testing to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StatStatisticsGroupedByIsActive()
        {
            // Creating an instance of the class I want to create
            clsSuppliers ASupplier = new clsSuppliers();
            // Invoking the method
            DataTable dT = ASupplier.StatisticsGroupedByIsActive();
            // According to the last executed stored procedure there should be 3 rows of data
            int noOfRecord = 2;
            // Test to see that the result is correct
            Assert.AreEqual(noOfRecord, dT.Rows.Count);
        }

        [TestMethod]
        public void StatStatisticsGroupedByContractStartDate()
        {
            // Creating an instance of the class I want to create
            clsSuppliers ASupplier = new clsSuppliers();
            // Invoking the method
            DataTable dT = ASupplier.StatisticsGroupedContractStartDate();
            // According to the last executed stored procedure there should be 3 rows of data
            int noOfRecord = 3;
            // Test to see that the result is correct
            Assert.AreEqual(noOfRecord, dT.Rows.Count);
        }

    }
}

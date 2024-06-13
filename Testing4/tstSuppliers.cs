using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing4
{
    [TestClass]
    public class tstSuppliers
    {
        /******************INSTANCE OF THE CLASS TEST******************/
        [TestMethod]
        public void InstanceOK()
        {
            // Creating an instance of the class I want to create
            clsSuppliers ASupplier = new clsSuppliers();
            // Testing to see that it actually exists
            Assert.IsNotNull(ASupplier);
        }
    }
}

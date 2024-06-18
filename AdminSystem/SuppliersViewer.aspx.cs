using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //Creating a new instance of clsSupplier
        clsSuppliers ASupplier = new clsSuppliers();
        // Getting the data from the session object
        ASupplier = (clsSuppliers)Session["ASupplier"];
        // Display the Supplier name for this entry
        Response.Write(ASupplier.SupplierName);
        // Display the Supplier Contact Phone

        // Display the Supplier Email

        // Display the Contract Start Date

        // Display the Contract End Date

        // Display whether it's active
    }
}
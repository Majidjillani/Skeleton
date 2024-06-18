using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;
public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    // Variable to store the primary key with high level scope
    Int32 SupplierId;
    protected void Page_Load(object sender, EventArgs e)
    {
        // Get the number of the supplier to be deleted from the session object
        SupplierId = Convert.ToInt32(Session["SupplierId"]);


    }





    protected void btnYes_Click(object sender, EventArgs e)
    {
        // Creating an instance of the class I want to create
        clsSuppliersCollection SupplierBook = new clsSuppliersCollection();
        //find the record to update
        SupplierBook.ThisSupplier.Find(SupplierId);
        //Delete the record
        SupplierBook.Delete();
        //Navigating to the view page
        Response.Redirect("SuppliersList.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        //Navigating to the main page
        Response.Redirect("SuppliersList.aspx");
    }
}
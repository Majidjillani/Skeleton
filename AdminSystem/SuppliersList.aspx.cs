using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // If this is the first time the page is displayed
        if (IsPostBack == false)
        {
            // Update the list box
            DisplaySuppliers();
        }
    }

    void DisplaySuppliers()
    {
        // Creating an instance of the class I want to create
        clsSuppliersCollection Suppliers = new clsSuppliersCollection();
        // Set the data source to list of suppliers in the collection
        lstSuppliersList.DataSource = Suppliers.SuppliersList;
        // Sets the name of the primary key
        lstSuppliersList.DataValueField = "SupplierId";
        // Set the data field to display
        lstSuppliersList.DataTextField = "SupplierName";
        // Binds the data to the list
        lstSuppliersList.DataBind();



    }

   

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        // Store -1 into the session object to indicate this is a new record
        Session["SupplierId"] = -1;
        // Redirect to the data entry page 
        Response.Redirect("SuppliersDataEntry.aspx");
    }



    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //variable to store the primary key value of the record to be edited
        Int32 SupplierId;
        //if a record has been selected from the the list
        if (lstSuppliersList.SelectedIndex != -1)
        {
            //get the primary key value of the rcord to edit
            SupplierId = Convert.ToInt32(lstSuppliersList.SelectedValue);
            //store the data in the session object
            Session["SupplierId"] = SupplierId;
            //redirect to the edit page
            Response.Redirect("SuppliersDataEntry.aspx");
        }
        else //if no record has been selected
        {
            lblError.Text = "Please select a record from the list to edit";
        }
    }


    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //variable to store the primary key value of the record to be edited
        Int32 SupplierId;
        //if a record has been selected from the the list
        if (lstSuppliersList.SelectedIndex != -1)
        {
            //get the primary key value of the rcord to edit
            SupplierId = Convert.ToInt32(lstSuppliersList.SelectedValue);
            //store the data in the session object
            Session["SupplierId"] = SupplierId;
            //redirect to the delete page
            Response.Redirect("SuppliersConfirmDelete.aspx");
        }
        else //if no record has been selected
        {
            lblError.Text = "Please select a record from the list to delete";
        }
    }

    protected void btnApplyFilter_Click(object sender, EventArgs e)
    {
        // Creating an instance of the class I want to create
        clsSuppliersCollection ASupplier = new clsSuppliersCollection();
        // Retrieve the value of the supplier name from the presentation layer
        ASupplier.ReportBySupplierName(txtEnterSupplierName.Text);
        // Set the data source to the list of suppliers in the collection
        lstSuppliersList.DataSource = ASupplier.SuppliersList;
        // Set the name of the primary key
        lstSuppliersList.DataValueField = "SupplierId";
        // Set the name of the field to display
        lstSuppliersList.DataTextField = "SupplierName";
        // Bind the data to the list
        lstSuppliersList.DataBind();
    }

    protected void btnClearFilter_Click(object sender, EventArgs e)
    {
        // Creating an instance of the class I want to create
        clsSuppliersCollection ASupplier = new clsSuppliersCollection();
        // Set an empty string 
        ASupplier.ReportBySupplierName("");
        // Clear any existing filter to tidy up the interface
        txtEnterSupplierName.Text = "";
        // Set the data source to the list of suppliers in the collection
        lstSuppliersList.DataSource = ASupplier.SuppliersList;
        // Set the name of the primary key
        lstSuppliersList.DataValueField = "SupplierId";
        // Set the name of the field to display
        lstSuppliersList.DataTextField = "SupplierName";
        // Bind the data to the list
        lstSuppliersList.DataBind();
    }

    protected void btnStatisticsPage_Click(object sender, EventArgs e)
    {

    }

    protected void lblReturnToMainMenu_Click(object sender, EventArgs e)
    {
        // Redirect the user back to the home page
        Response.Redirect("TeamMainMenu.aspx");
    }
}
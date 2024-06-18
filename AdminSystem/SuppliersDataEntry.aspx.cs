using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;


public partial class _1_DataEntry : System.Web.UI.Page
{
    // Variable to store the primary key with high level scope
    Int32 SupplierId;
    protected void Page_Load(object sender, EventArgs e)
    {
        // Get the number of the supplier to be processed
        SupplierId = Convert.ToInt32(Session["SupplierId"]);
        if (IsPostBack == false)
        {
            // If this is not a new record
            if (SupplierId != -1)
            // Update the current data for the record
            DisplaySupplier();
        }
    }

    void DisplaySupplier()
    {
        // Creating an instance of the class I want to create
        clsSuppliersCollection SupplierBook = new clsSuppliersCollection();
        //find the record to update
        SupplierBook.ThisSupplier.Find(SupplierId);
        //display the data for the record
        txtSupplierID.Text = SupplierBook.ThisSupplier.SupplierId.ToString();
        txtSupplierName.Text = SupplierBook.ThisSupplier.SupplierName.ToString();
        txtContactPhone.Text = SupplierBook.ThisSupplier.ContactPhone.ToString();
        txtContactEmail.Text = SupplierBook.ThisSupplier.ContactEmail.ToString();
        txtContractStartDate.Text = SupplierBook.ThisSupplier.ContractStartDate.ToString();
        txtContractEndDate.Text = SupplierBook.ThisSupplier.ContractEndDate.ToString();
        chkIsActive.Checked = SupplierBook.ThisSupplier.IsActive;
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //Creating a new instance of clsSupplier
        clsSuppliers ASupplier = new clsSuppliers();
        // Capturing the Supplier Name
        string SupplierName = txtSupplierName.Text;
        //Capturing the Contact Phone Number
        string ContactPhone = txtContactPhone.Text;
        //Capturing the Contact Email Address
        string ContactEmail = txtContactEmail.Text;
        //Capturing the Contract Start Date
        string ContractStartDate = txtContractStartDate.Text;
        //Capturing the Contract End Date
        string ContractEndDate = txtContractEndDate.Text;
        //Capturing if the Contract is Active
        string Active = chkIsActive.Text;
        //Variable to store any error messages
        string Error = "";
        //Validate the data
        Error = ASupplier.Valid(SupplierName, ContactPhone, ContactEmail, ContractStartDate, ContractEndDate);
        if (Error == "")
        {
            //Capture the Supplier ID
            ASupplier.SupplierId = SupplierId;
            //Capturing the Supplier Name
            ASupplier.SupplierName = SupplierName;
            //Capturing the Contact Phone Number
            ASupplier.ContactPhone = ContactPhone;
            //Capturing the Contact Email Address
            ASupplier.ContactEmail = ContactEmail;
            //Capturing the Contract Start Date
            ASupplier.ContractStartDate = Convert.ToDateTime(ContractStartDate);
            //Capturing the Contract End Date
            ASupplier.ContractEndDate = Convert.ToDateTime(ContractEndDate);
            //Capturing IsActive
            ASupplier.IsActive = chkIsActive.Checked;
            // Creating an instance of the class I want to create
            clsSuppliersCollection SuppliersList = new clsSuppliersCollection();
            // If this is a new record i.e. SupplierId = -1 then Add data 
            if (SupplierId == -1)
            {
                //Sets the ThisAddress property
                SuppliersList.ThisSupplier = ASupplier;
                //Add the new record
                SuppliersList.Add();
            }
            //Otherwise it must be an update
            else
            {
                //find the record to update
                SuppliersList.ThisSupplier.Find(SupplierId);
                //set the ThisSupplier property
                SuppliersList.ThisSupplier = ASupplier;
                //Update the record
                SuppliersList.Update();
                //Navigating to the view page
                Response.Redirect("SuppliersViewer.aspx");

            }
        }
        else
        {
            // Display the error message
            lblError.Text = Error;
        }

    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        // Redirect the user back to the list page
        Response.Redirect("SuppliersList.aspx");
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        // Creating an instance of the supplier class
        clsSuppliers ASupplier = new clsSuppliers();
        // Creating a variable to store the primary key
        Int32 SupplierId;
        // Creating a variable to store the result of the find operation
        Boolean Found = false;
        // Getting the primary key entered by the user
        SupplierId = Convert.ToInt32(txtSupplierID.Text);
        // Finding the record
        Found = ASupplier.Find(SupplierId);
        // If found 
        if (Found == true)
        {
            //Display the values of the properties in the form
            txtSupplierName.Text = ASupplier.SupplierName;
            txtContactPhone.Text = ASupplier.ContactPhone;
            txtContactEmail.Text = ASupplier.ContactEmail;
            txtContractStartDate.Text = ASupplier.ContractStartDate.ToString();
            txtContractEndDate.Text = ASupplier.ContractEndDate.ToString();
            chkIsActive.Checked = ASupplier.IsActive;
        }
    }

    protected void lblReturnToMainMenu_Click(object sender, EventArgs e)
    {
        // Redirect the user back to the home page
        Response.Redirect("TeamMainMenu.aspx");
    }
}
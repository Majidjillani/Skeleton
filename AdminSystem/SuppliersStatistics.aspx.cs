using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class SuppliersStatistics : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsSuppliers clssuppliers = new clsSuppliers();

        // Retrieve data from the database 
        DataTable dT = clssuppliers.StatisticsGroupedByIsActive();

        // Upload dT into GridView
        GridViewGroupByIsActive.DataSource = dT;
        GridViewGroupByIsActive.DataBind();

        // Change the header of the first column
        GridViewGroupByIsActive.HeaderRow.Cells[0].Text = "Total";

        // Retrieve data from the database
        dT = clssuppliers.StatisticsGroupedContractStartDate();

        // Upload dT into GridView
        GridViewGroupByContractStartDate.DataSource = dT;
        GridViewGroupByContractStartDate.DataBind();

        // Change the header of the first column
        GridViewGroupByContractStartDate.HeaderRow.Cells[0].Text = "Total";
    }

    protected void GridViewGroupByContractStartDate_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}
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
        //create a new instane of the clsProduct
        clsProduct AProduct = new clsProduct();
        //get the data from the session object
        AProduct = (clsProduct)Session["AProduct"];
        //display the company name for this entry
        Response.Write(AProduct.Company);
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    //variable to store the primarykey value of record to be deleted
    Int32 ProductId;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the product to deleted from the session object
        ProductId = Convert.ToInt32(Session["ProductId"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        //create a new instance of the productcollection class
        clsProductCollection Product = new clsProductCollection();
        //find the record to delete
        Product.ThisProduct.Find(ProductId);
        //delete the record
        Product.Delete();
        //redirect back to the main page
        Response.Redirect("ProductList.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        //redirect back to the main page
        Response.Redirect("ProductList.aspx");
    }
}
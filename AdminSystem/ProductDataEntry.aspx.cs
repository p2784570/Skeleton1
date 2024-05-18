using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnDone_Click(object sender, EventArgs e)
    {
       //create a new instane of clsProduct
       clsProduct AProduct = new clsProduct();
        //capture the company
        AProduct.Company = txtCompany.Text;
        //capture the modelname
        AProduct.ModelName = txtModelName.Text;
        //capture the Ram
        AProduct.Ram = txtRam.Text;
        //capture the internalstorage
        AProduct.InternalStorage = txtInternalStorage.Text;
        //capture Display
        AProduct.Display = txtDisplay.Text;
        //capture the camera
        AProduct.Camera = txtCamera.Text;
        //capture the networktype
        AProduct.NetworkType = txtNetworkType.Text;
        //capture the simtype
        AProduct.SimType = txtSimType.Text;
        //capture the price
        AProduct.Price= txtPrice.Text;
        //capture the Quantity
        AProduct.Quantity = Convert.ToInt32(txtQuantity.Text);
        //store the product in the session object
        Session["AProduct"] = AProduct;
        //navigate to the view page
        Response.Redirect("ProductViewer.aspx");

    }
}
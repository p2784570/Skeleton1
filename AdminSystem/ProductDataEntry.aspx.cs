using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    //variable to store the primary key with the page level scope
    Int32 ProductId;

    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the product to be processed
        ProductId = Convert.ToInt32(Session["ProductId"]);
        if (IsPostBack == false)
        {
            //if this is not a new record
            if (ProductId != -1)
            {
                //display the current data for the record
                DisplayProduct();
            }
        }
    }
    public void DisplayProduct()
    {
        //create an instance of the Product
        clsProductCollection Product = new clsProductCollection();
        //find the record to update
        Product.ThisProduct.Find(ProductId);
        //display the data for the record
        txtProductId.Text = Product.ThisProduct.ProductId.ToString();
        txtCompany.Text = Product.ThisProduct.Company.ToString();
        txtModelName.Text = Product.ThisProduct.ModelName.ToString();
        txtRam.Text = Product.ThisProduct.Ram.ToString();
        txtInternalStorage.Text = Product.ThisProduct.InternalStorage.ToString();
        txtDisplay.Text = Product.ThisProduct.Display.ToString();
        txtCamera.Text = Product.ThisProduct.Camera.ToString();
        txtNetworkType.Text = Product.ThisProduct.NetworkType.ToString();
        txtSimType.Text = Product.ThisProduct.SimType.ToString();
        txtPrice.Text = Product.ThisProduct.Price.ToString();
        txtQuantity.Text = Product.ThisProduct.Quantity.ToString();
    }

    protected void btnDone_Click(object sender, EventArgs e)
    {
        //create a new instane of clsProduct
        clsProduct AProduct = new clsProduct();
        //capture the company
        string Company = txtCompany.Text;
        //capture the modelname
        string ModelName = txtModelName.Text;
        //capture the Ram
        string Ram = txtRam.Text;
        //capture the internalstorage
        string InternalStorage = txtInternalStorage.Text;
        //capture Display
        string Display = txtDisplay.Text;
        //capture the camera
        string Camera = txtCamera.Text;
        //capture the networktype
        string NetworkType = txtNetworkType.Text;
        //capture the simtype
        string SimType = txtSimType.Text;
        //capture the price
        string Price = txtPrice.Text;
        //capture the Quantity
        string Quantity = txtQuantity.Text;
        //variable to strore any error messages
        string Error = "";
        //validate the data
        Error = AProduct.Valid(Company, ModelName, Ram, InternalStorage, Display, Camera, NetworkType, SimType, Price, Quantity);
        if (Error == "")
        {
            //capture the company
            AProduct.Company = Company;  //don't miss this bit !!!!! 
            //capture the modelname
            AProduct.ModelName = ModelName;
            //capture the Ram
            AProduct.Ram = Ram;
            //capture the internalstorage
            AProduct.InternalStorage = InternalStorage;
            //capture Display
            AProduct.Display = Display;
            //capture the camera
            AProduct.Camera = Camera;
            //capture the networktype
            AProduct.NetworkType = NetworkType;
            //capture the simtype
            AProduct.SimType = SimType;
            //capture the price
            AProduct.Price = Price;
            //capture the quantity
            AProduct.Quantity = Convert.ToInt32(Quantity);
            //create a new instance of the Product collection
            clsProductCollection ProductList = new clsProductCollection();

            //if this is a new record i.e ProductId = -1 then add the data
            if (ProductId == -1)
            {
                //set thisproduct property
                ProductList.ThisProduct = AProduct;
                //add new record
                ProductList.Add();
            }
            //otherwise it must be update
            else
            {
                //find the record to update
                ProductList.ThisProduct.Find(ProductId);
                //set thisproduct property
                ProductList.ThisProduct = AProduct;
                //update the record
                ProductList.Update();
            }
            //navigate to the viewer page
            Response.Redirect("ProductList.aspx");
        }
        else
        {
            //display the error message
            lblError.Text = Error;
        }

    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the Product Class
        clsProduct AProduct = new clsProduct();
        //create a variable to strore the primary key
        Int32 ProductId;
        //create a variable to strore the result of the find operation
        Boolean Found = false;
        //get the primary key entered by the user
        ProductId = Convert.ToInt32(txtProductId.Text);
        //find the record
        Found = AProduct.Find(ProductId);
        //if found
        if (Found == true)
        {
            //display the values of the properties in the form
            txtCompany.Text = AProduct.Company;
            txtModelName.Text = AProduct.ModelName;
            txtRam.Text = AProduct.Ram;
            txtInternalStorage.Text = AProduct.InternalStorage;
            txtDisplay.Text = AProduct.Display;
            txtCamera.Text = AProduct.Camera;
            txtNetworkType.Text = AProduct.NetworkType;
            txtSimType.Text = AProduct.SimType;
            txtPrice.Text = AProduct.Price;
            txtQuantity.Text = AProduct.Quantity.ToString();
        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        //redirect to the user to the login page
        Response.Redirect("TeamMainMenu.aspx");
    }
}
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
        //if this is the first time the page is displayed
        if (IsPostBack == false)
        {
            //update the list box
            DisplayProducts();
        }
    }
    public void DisplayProducts()
    {
        //create an instance of the Product collection
        clsProductCollection Products = new clsProductCollection();
        //set the data source to list of Products in the collection
        lstProductList.DataSource = Products.ProductList;
        //set the name of the primary key
        lstProductList.DataValueField = "productNo";
        //set the data field to display
        lstProductList.DataTextField = "Company";
        //bind the data to the list
        lstProductList.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into session object to indicate this is a new record
        Session["ProductId"] = -1;
        //redirect to the data entry page
        Response.Redirect("ProductDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //variable to store primarykey value of the record to be edited
        Int32 ProductId;
        //if a record has been selected from the list
        if (lstProductList.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit
            ProductId = Convert.ToInt32(lstProductList.SelectedValue);
            //store the data in the session object
            Session["ProductId"] = ProductId;
            //redirect to edit page
            Response.Redirect("ProductDataEntry.aspx");
        }
        //if no record has been selected
        else
        {
            lblError.Text = "Please select record from the list to edit";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //variable to store the primarykey value of the record to be deleted
        Int32 ProductId;
        //if a record has been selected from the list
        if (lstProductList.SelectedIndex != -1)
        {
            //get the primarykey value of the record delete
            ProductId = Convert.ToInt32(lstProductList.SelectedValue);
            //store the data in the session object
            Session["ProductId"] = ProductId;
            //redirect to delete page
            Response.Redirect("ProductConfirmDelete.aspx");
        }
        //if no record has been selected
        else
        {
            //display an error message
            lblError.Text = "Please select a record from the list to delete";
        }
    }

    protected void btnApplyFilter_Click(object sender, EventArgs e)
    {
        //create an instance of the product object
        clsProductCollection AProduct = new clsProductCollection();
        //retrieve the value of modelname from the presentation layer
        AProduct.ReportByModelName(txtFilter.Text);
        //set the data source to list of products in the collection
        lstProductList.DataSource = AProduct.ProductList;
        //set the name of the primary key
        lstProductList.DataValueField = "ModelName";
        //bind the data to the list
        lstProductList.DataBind();
    }

    protected void btnClearFilter_Click(object sender, EventArgs e)
    {
        //create an instance of the product object
        clsProductCollection AProduct = new clsProductCollection();
        //set an empty string
        AProduct.ReportByModelName("");
        //clear my existing filter to tidy up the interface
        txtFilter.Text = "";
        //set the data source to the list of products in the collection
        lstProductList.DataSource = AProduct.ProductList;
        //set tha name of the primary key
        lstProductList.DataValueField = "ProductId";
        //set the name of the field to display
        lstProductList.DataTextField = "ModelName";
        //bind the data to the list
        lstProductList.DataBind();
    }
}
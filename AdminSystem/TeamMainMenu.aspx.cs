using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class TeamMainMenu : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnCustomers_Click(object sender, EventArgs e)
    {
        //redirect to the user to the login page
        Response.Redirect("Login.aspx");
    }

    protected void btnProducts_Click(object sender, EventArgs e)
    {
        //redirect to the user to the login page
        Response.Redirect("Login.aspx");
    }

    protected void btnSales_Click(object sender, EventArgs e)
    {
        //redirect to the user to the login page
        Response.Redirect("Login.aspx");
    }
}
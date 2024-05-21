using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class UserLogin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    { 

    }
    protected void btnLogin_Click(object sender, EventArgs e)
    {
        string username = txtEmail.Text;
        string password = txtPassword.Text;

        // Call a method to authenticate the user
        bool isAuthenticated = AuthenticateUser(username, password);

        if (isAuthenticated)
        {
            // Redirect to the dashboard or any other page
            Response.Redirect("Dashboard.aspx");
        }
        else
        {
            // Show an error message
            lblMessage.Text = "Invalid username or password.";
        }
    }

    private bool AuthenticateUser(string username, string password)
    {
        // Here, you can implement the logic to authenticate the user
        // For demonstration purpose, let's assume we are using hardcoded values for username and password

        if (username == "admin" && password == "admin123")
        {
            // Authentication successful
            return true;
        }
        else
        {
            // Authentication failed
            return false;
        }
    }
}

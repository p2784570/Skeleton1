using ClassLibrary;
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
        // Optional: You can redirect logged-in users to another page
        if (Session["LoggedInCustomerID"] != null)
        {
            Response.Redirect("~/Welcome.aspx");
        }
    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        // Clear the message label
        lblMessage.Text = "";

        // Retrieve the entered email and password
        string email = txtEmail.Text.Trim();
        string password = txtPassword.Text.Trim();

        // Validate the email and password
        if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
        {
            lblMessage.Text = "Please enter both email and password.";
            return;
        }

        // Create an instance of the customer collection
        ClsCustomersCollection customersCollection = new ClsCustomersCollection();

        // Retrieve the customer by email
        ClsCustomer customer = customersCollection.GetByEmail(email);

        // Check if the customer exists and the password matches
        if (customer != null && customer.Password == password)
        {
            // Redirect to the Welcome page
            Response.Redirect("Homepage.aspx");
        }
        else
        {
            lblMessage.Text = "Invalid email or password.";
        }
    }
}
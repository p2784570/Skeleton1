using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_DataEntry : System.Web.UI.Page
{
    ClsCustomersCollection customersCollection;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            // Check if user is logged in
            if (Session["LoggedInCustomerID"] == null)
            {
                Response.Redirect("~/UserLogin.aspx");
            }
            else
            {
                // Load the customer details
                int customerID = (int)Session["LoggedInCustomerID"];
                LoadCustomerDetails(customerID);
            }
        }
    }

    private void LoadCustomerDetails(int customerID)
    {
        ClsCustomersCollection customersCollection = new ClsCustomersCollection();
        ClsCustomer customer = customersCollection.FindById(customerID);

        if (customer != null)
        {
            txtFirstName.Text = customer.FirstName;
            txtLastName.Text = customer.LastName;
            txtEmail.Text = customer.Email;
            txtPhone.Text = customer.Phone.ToString();
            txtAddress.Text = customer.Address;
            txtCity.Text = customer.City;
            txtState.Text = customer.State;
            txtCountry.Text = customer.Country;
            txtPassword.Text = customer.Password;
        }
        else
        {
            lblMessage.Text = "Customer not found.";
        }
    }

    protected void btnUpdate_Click(object sender, EventArgs e)
    {
        // Retrieve customer ID from session
        int customerID = (int)Session["LoggedInCustomerID"];

        // Create a new customer instance
        ClsCustomer updatedCustomer = new ClsCustomer
        {
            CustomerID = customerID,
            FirstName = txtFirstName.Text.Trim(),
            LastName = txtLastName.Text.Trim(),
            Email = txtEmail.Text.Trim(),
            Phone = string.IsNullOrWhiteSpace(txtPhone.Text) ? (int?)null : Convert.ToInt32(txtPhone.Text),
            Address = txtAddress.Text.Trim(),
            City = txtCity.Text.Trim(),
            State = txtState.Text.Trim(),
            Country = txtCountry.Text.Trim(),
            Password = txtPassword.Text.Trim()
        };

        // Validate customer inputs
        string validationMessage = updatedCustomer.Valid(updatedCustomer.FirstName, updatedCustomer.LastName, updatedCustomer.Email, updatedCustomer.Phone.ToString(), updatedCustomer.Address, updatedCustomer.City, updatedCustomer.State, updatedCustomer.Country, updatedCustomer.Password);
        if (validationMessage != "")
        {
            lblMessage.Text = validationMessage;
            lblMessage.ForeColor = System.Drawing.Color.Red;
            return;
        }

        // Update the customer in the collection
        ClsCustomersCollection customersCollection = new ClsCustomersCollection();
        customersCollection.ThisCustomer = updatedCustomer;
        customersCollection.Update();

        lblMessage.Text = "Customer details updated successfully!";
        lblMessage.ForeColor = System.Drawing.Color.Green;
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        // Retrieve customer ID from session
        int customerID = (int)Session["LoggedInCustomerID"];

        // Delete the customer
        ClsCustomersCollection customersCollection = new ClsCustomersCollection();
        customersCollection.Delete(customerID);

        // Clear the session
        Session["LoggedInCustomerID"] = null;

        // Redirect to login page
        Response.Redirect("~/Login.aspx");
    }
    protected void btnLogout_Click(object sender, EventArgs e)
    {
        // Clear the session
        Session["LoggedInCustomerID"] = null;

        // Redirect to login page
        Response.Redirect("~/Login.aspx");
    }
}
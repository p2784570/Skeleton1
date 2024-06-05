using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Net.NetworkInformation;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class UserRegister : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnRegister_Click(object sender, EventArgs e)
    {
        // Clear the message label
        lblMessage.Text = "";

        // Create a new customer instance
        ClsCustomer newCustomer = new ClsCustomer
        {
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
        string validationMessage = newCustomer.Valid(newCustomer.FirstName, newCustomer.LastName, newCustomer.Email, newCustomer.Phone.ToString(), newCustomer.Address, newCustomer.City, newCustomer.State, newCustomer.Country, newCustomer.Password);
        if (validationMessage != "")
        {
            lblMessage.Text = validationMessage;
            lblMessage.ForeColor = System.Drawing.Color.Red;
            return;
        }

        // Check if the email is already registered
        ClsCustomersCollection customersCollection = new ClsCustomersCollection();
        if (customersCollection.IsEmailRegistered(newCustomer.Email))
        {
            lblMessage.Text = "The email address is already registered.";
            lblMessage.ForeColor = System.Drawing.Color.Red;
            return;
        }

        // Add the new customer to the collection and save to database
        customersCollection.ThisCustomer = newCustomer;
        int customerId = customersCollection.Add();
        if (customerId > 0)
        {
            lblMessage.Text = "Customer registered successfully!";
            lblMessage.ForeColor = System.Drawing.Color.Green;
            ClearForm();
        }
        else
        {
            lblMessage.Text = "Registration failed. Please try again.";
            lblMessage.ForeColor = System.Drawing.Color.Red;
        }
    }

    private void ClearForm()
    {
        txtFirstName.Text = "";
        txtLastName.Text = "";
        txtEmail.Text = "";
        txtPhone.Text = "";
        txtAddress.Text = "";
        txtCity.Text = "";
        txtState.Text = "";
        txtCountry.Text = "";
        txtPassword.Text = "";
    }
}
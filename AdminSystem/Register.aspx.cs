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

        string firstName = txtFirstName.Text;

        string lastName = txtLastName.Text;

        string email = txtEmail.Text;

        string phone = txtPhone.Text;

        string address = txtAddress.Text;

        string city = txtCity.Text;

        string state = txtState.Text;

        string county = txtCounty.Text;

        string password = txtpassword.Text;



        // Call a method to save the user data

        bool registrationSuccessful = RegisterUser(firstName, lastName, email, phone, address, city, state, county, password);



        if (registrationSuccessful)

        {

            // Redirect to the login page with a success message

            Response.Redirect("Login.aspx?registration=success");

        }

        else

        {

            // Show an error message

            lblMessage.Text = "Registration failed. Please try again.";

        }

    }



    private bool RegisterUser(string firstName, string lastName, string email, string phone, string address, string city, string state, string country, string password)

    {

        string connectionString = ConfigurationManager.ConnectionStrings["YourConnectionStringName"].ConnectionString;



        using (SqlConnection con = new SqlConnection(connectionString))

        {

            string query = "INSERT INTO Users (FirstName, LastName, Email, Phone, Address, City, State, Country, Password) VALUES (@FirstName, @LastName, @Email, @Phone, @Address, @City, @State, @Country, @Password)";

            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@FirstName", firstName);

            cmd.Parameters.AddWithValue("@LastName", lastName);

            cmd.Parameters.AddWithValue("@Email", email);

            cmd.Parameters.AddWithValue("@Phone", phone);

            cmd.Parameters.AddWithValue("@Address", address);

            cmd.Parameters.AddWithValue("@City", city);

            cmd.Parameters.AddWithValue("@State", state);

            cmd.Parameters.AddWithValue("@Country", country);

            cmd.Parameters.AddWithValue("@Password", password);



            try

            {

                con.Open();

                int rowsAffected = cmd.ExecuteNonQuery();

                return rowsAffected > 0; // Registration successful if rows were affected

            }

            catch (Exception ex)

            {

                // Handle any exceptions

                // For simplicity, we are not handling exceptions in this example

                return false;

            }

        }

    }

}


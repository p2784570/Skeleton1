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
        if (!IsPostBack)
        {
            // Check if user is logged in
            if (Session["LoggedInCustomerID"] == null)
            {
                Response.Redirect("~/Login.aspx");
            }
        }
    }

    protected void btnSubmitReview_Click(object sender, EventArgs e)
    {
        lblMessage.Text = "";

        // Retrieve the entered review details
        string productID = txtProductID.Text.Trim();
        string rating = txtRating.Text.Trim();
        string comment = txtComment.Text.Trim();

        // Validate the review details
        ClsReview newReview = new ClsReview();
        string validationMessage = newReview.Valid(productID, rating, comment);
        if (validationMessage != "")
        {
            lblMessage.Text = validationMessage;
            lblMessage.ForeColor = System.Drawing.Color.Red;
            return;
        }

        // Create a new review instance
        newReview.ProductID = Convert.ToInt32(productID);
        newReview.CustomerID = (int)Session["LoggedInCustomerID"];
        newReview.Rating = Convert.ToInt32(rating);
        newReview.Comment = comment;
        newReview.ReviewTime = DateTime.Now;

        // Add the new review to the database
        ClsReviewCollection reviewCollection = new ClsReviewCollection();
        reviewCollection.ThisReview = newReview;
        int reviewId = reviewCollection.Add();

        if (reviewId > 0)
        {
            lblMessage.Text = "Review submitted successfully!";
            lblMessage.ForeColor = System.Drawing.Color.Green;
            ClearForm();
        }
        else
        {
            lblMessage.Text = "Failed to submit review. Please try again.";
            lblMessage.ForeColor = System.Drawing.Color.Red;
        }
    }

    private void ClearForm()
    {
        txtProductID.Text = "";
        txtRating.Text = "";
        txtComment.Text = "";
    }

    protected void btnLogout_Click(object sender, EventArgs e)
    {
        // Clear the session
        Session["LoggedInCustomerID"] = null;

        // Redirect to login page
        Response.Redirect("~/Login.aspx");
    }
}
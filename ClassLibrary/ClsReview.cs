using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class ClsReview
    {
        public int ReviewID { get; set; }
        public int ProductID { get; set; }
        public int CustomerID { get; set; }
        public int Rating { get; set; }
        public string Comment { get; set; }
        public DateTime ReviewTime { get; set; }

        public string Valid(string productID, string rating, string comment)
        {
            string error = "";

            int productIdValue;
            if (!int.TryParse(productID, out productIdValue) || productIdValue <= 0)
            {
                error += "The product ID must be a positive integer. ";
            }

            int ratingValue;
            if (!int.TryParse(rating, out ratingValue) || ratingValue < 1 || ratingValue > 5)
            {
                error += "The rating must be a number between 1 and 5. ";
            }

            if (string.IsNullOrEmpty(comment))
            {
                error += "The comment may not be blank. ";
            }

            return error;
        }
    }
}
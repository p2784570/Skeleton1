using System;

namespace ClassLibrary
{
  
    public class Orders
    {
        private int customerID;
        private DateTime orderTime;
        private decimal totalprice;
        private string status;

        public int OrderID { get; set; }

        public int CustomerID
        {
            get { return customerID; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("CustomerID cannot be zero or negative.");
                customerID = value;
            }
        }

        public DateTime OrderTime
        {
            get { return orderTime; }
            set
            {
                if (value == default(DateTime))
                    throw new ArgumentException("OrderTime cannot be default value.");
                orderTime = value;
            }
        }

        public decimal Totalprice
        {
            get { return totalprice; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Totalprice must be a positive value.");
                totalprice = value;
            }
        }

        public string Status
        {
            get { return status; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Status cannot be null or empty.");
                status = value;
            }
        }

        public string Valid(int customerID, DateTime orderTime, decimal totalprice, string status)
        {
            string errorMessage = string.Empty;

            if (customerID <= 0)
            {
                errorMessage += "CustomerID cannot be zero or negative. ";
            }

            if (orderTime == default(DateTime))
            {
                errorMessage += "OrderTime cannot be default value. ";
            }

            if (totalprice <= 0)
            {
                errorMessage += "Totalprice must be a positive value. ";
            }

            if (string.IsNullOrEmpty(status))
            {
                errorMessage += "Status cannot be null or empty. ";
            }

            return errorMessage;
        }

        public bool Find(int orderID)
        {
            // Simulate database lookup
            if (orderID == 1)
            {
                this.OrderID = 1;
                this.CustomerID = 1;
                this.OrderTime = DateTime.Now;
                this.Totalprice = 99.99M;
                this.Status = "Pending";
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

    
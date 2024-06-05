using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class ClsReviewCollection
    {
        private List<ClsReview> mReviewList = new List<ClsReview>();
        private ClsReview mThisReview = new ClsReview();

        public List<ClsReview> ReviewList
        {
            get { return mReviewList; }
            set { mReviewList = value; }
        }

        public int Count
        {
            get { return mReviewList.Count; }
        }

        public ClsReview ThisReview
        {
            get { return mThisReview; }
            set { mThisReview = value; }
        }

        public ClsReviewCollection()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblReview_SelectAll");
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            int Index = 0;
            int RecordCount = DB.Count;
            mReviewList = new List<ClsReview>();
            while (Index < RecordCount)
            {
                ClsReview AReview = new ClsReview();
                AReview.ReviewID = Convert.ToInt32(DB.DataTable.Rows[Index]["ReviewID"]);
                AReview.ProductID = Convert.ToInt32(DB.DataTable.Rows[Index]["ProductID"]);
                AReview.CustomerID = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerID"]);
                AReview.Rating = Convert.ToInt32(DB.DataTable.Rows[Index]["Rating"]);
                AReview.Comment = Convert.ToString(DB.DataTable.Rows[Index]["Comment"]);
                AReview.ReviewTime = Convert.ToDateTime(DB.DataTable.Rows[Index]["ReviewTime"]);
                mReviewList.Add(AReview);
                Index++;
            }
        }

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@ProductID", mThisReview.ProductID);
            DB.AddParameter("@CustomerID", mThisReview.CustomerID);
            DB.AddParameter("@Rating", mThisReview.Rating);
            DB.AddParameter("@Comment", mThisReview.Comment);
            DB.AddParameter("@ReviewTime", mThisReview.ReviewTime);
            DB.Execute("sproc_tblReview_Insert");

            if (DB.Count == 1 && DB.DataTable.Rows[0]["ReviewID"] != DBNull.Value)
            {
                return Convert.ToInt32(DB.DataTable.Rows[0]["ReviewID"]);
            }
            else
            {
                return -1;
            }
        }
    }
}

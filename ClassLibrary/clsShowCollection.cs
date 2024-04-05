using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsShowCollection
    {
        //private data member
        List<clsShow> mShowList = new List<clsShow>();

        public clsShowCollection()
        {
            Int32 Index = 0;
            Int32 RecordCount = 0;
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblShow_SelectAll");
            RecordCount = DB.Count;

            while (Index < RecordCount)
            {
                clsShow AShow = new clsShow();

                AShow.ShowId = Convert.ToInt32(DB.DataTable.Rows[Index]["ShowId"]);
                AShow.Title = Convert.ToString(DB.DataTable.Rows[Index]["Title"]);
                AShow.Seasons = Convert.ToInt32(DB.DataTable.Rows[Index]["Seasons"]);
                AShow.ReleaseDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["ReleaseDate"]);
                AShow.Description = Convert.ToString(DB.DataTable.Rows[Index]["Description"]);
                AShow.Genre = Convert.ToString(DB.DataTable.Rows[Index]["Genre"]);
                AShow.Rating = Convert.ToDouble(DB.DataTable.Rows[Index]["Rating"]);
                AShow.Creators = Convert.ToString(DB.DataTable.Rows[Index]["Creators"]);
                AShow.StarActors = Convert.ToString(DB.DataTable.Rows[Index]["StarActors"]);
                AShow.CoverImage = Convert.ToString(DB.DataTable.Rows[Index]["CoverImage"]);

                mShowList.Add(AShow);
                Index++;
            }
        }

        public List<clsShow> ShowList
        {
            get
            {
                return mShowList;
            }
            set
            {
                mShowList = value;
            }
        }

        public int Count
        {
            get
            {
                return mShowList.Count;
            }
            set
            {
                //do later
            }
        }

        public clsShow ThisShow { get; set; }
    }
}
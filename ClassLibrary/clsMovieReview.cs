using System;

namespace ClassLibrary
{
    public class clsMovieReview
    {
        public clsMovieReview()
        {
        }

        public int MovieReviewId { get; set; }
        public int MovieId { get; set; }
        public int MemberId { get; set; }
        public double Rating { get; set; }
        public string Comment { get; set; }
        public DateTime DatePosted { get; set; }
    }
}
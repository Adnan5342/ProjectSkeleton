using System;

namespace ClassLibrary
{
    public class clsMovie
    {
        public string Title { get; set; }
        public TimeSpan Runtime { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Description { get; set; }
        public string Genre { get; set; }
        public double Rating { get; set; }
        public string Director { get; set; }
        public string Writer { get; set; }
        public string StarActor { get; set; }
    }
}
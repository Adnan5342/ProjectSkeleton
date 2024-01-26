using System;

namespace ClassLibrary
{
    public class clsMovie
    {
        public int MovieId { get; set; }
        public string Title { get; set; }
        public TimeSpan Runtime { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Description { get; set; }
        public string Genre { get; set; }
        public double Rating { get; set; }
        public string Directors { get; set; }
        public string Writers { get; set; }
        public string StarActors { get; set; }
        public string CoverImage { get; set; }
    }
}
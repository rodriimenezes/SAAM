namespace SAAM.Models
{
    public class Album
    {
        private int Id { get; set; }
        private int ReleaseYear { get; set; }
        private string Title { get; set; }
        private string ArtistName { get; set; }
        private string CoverImagePath { get; set; }
        private int RatingCount { get; set; } = 0;
        private double AverageRating { get; set; } = 0.0;

        public Album(int id, int releaseYear, string title, string artistName, string coverImagePath) 
        { 
            Id = id;
            ReleaseYear = releaseYear;
            Title = title;
            ArtistName = artistName;
            CoverImagePath = coverImagePath;
        }

        // TODO: tratamento de erros.
        public void UpdateAverageRating(double newRating)
        {
            RatingCount++;
            AverageRating = (AverageRating + newRating) / RatingCount;
        }
    }
}

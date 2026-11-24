namespace SAAM.Models
{
    public class Track
    {
        private int Id {  get; set; }
        private int AlbumId { get; set; }
        private int TrackNumber { get; set; }
        private int DurationSeconds { get; set; }
        private int RatingCount { get; set; } = 0;
        private double AverageRating { get; set; } = 0.0;
        private string? Title { get; set; }

        public Track(int id, int albumId, int trackNumber, int durationSeconds, string title) 
        {
            Id = id;
            AlbumId = albumId;
            TrackNumber = trackNumber;
            DurationSeconds = durationSeconds;
            Title = title;
        }

        public Track() { }

        // TODO: tratamento de erros.
        public void UpdateAverageRating(double newRating)
        {
            RatingCount++;
            AverageRating = (AverageRating + newRating)/RatingCount;
        }
    }
}

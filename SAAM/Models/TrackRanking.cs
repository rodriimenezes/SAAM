namespace SAAM.Models
{
    public class TrackRanking
    {
        private int Id { get; set; }
        private int UserId { get; set; }
        private int TrackId { get; set; }
        private double Rating { get; set; }
        private DateTime ReviewDate { get; set; } = DateTime.Now;

        public TrackRanking(int id, int userId, int trackId, double rating)
        {
            Id = id;
            UserId = userId;
            TrackId = trackId;
            Rating = rating;
        }

        // TODO: tratar os erros.
        public void UpdateRating(double newRating)
        {
            Rating = newRating;
            ReviewDate = DateTime.Now;
        }
    }
}

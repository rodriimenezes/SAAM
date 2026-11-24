namespace SAAM.Models
{
    public class AlbumReview
    {
        private int Id { get; set; }
        private int UserId { get; set; }
        private int AlbumId { get; set; }
        private double Rating { get; set; }
        private string Description { get; set; } = string.Empty;
        private DateTime ReviewDate { get; set; } = DateTime.Now;

        public AlbumReview(int id, int userId, int albumId, double rating, string? description)
        {
            Id = id;
            UserId = userId;
            AlbumId = albumId;
            Rating = rating;

            if (description != null)
            {
                Description = description;
            }

        }
    }
}

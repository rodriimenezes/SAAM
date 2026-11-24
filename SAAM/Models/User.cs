namespace SAAM.Models
{
    public class User
    {
        private int Id {  get; set; }
        private string Username { get; set; }
        private string DisplayName { get; set; }
        private string Email { get; set; }
        private string ProfilePicturePath { get; set; }
        private string Biography { get; set; }
        private DateTime RegisterDate { get; set; } = DateTime.Now;

        public User(int id, string username, string displayName, string email, string profilePicturePath, string biography)
        {
            Id = id;
            Username = username;
            DisplayName = displayName;
            Email = email;
            ProfilePicturePath = profilePicturePath;
            Biography = biography;
        }

        // TODO: implementar as lógicas
        public void UpdateDisplayName() { }
        public void UpdateBiography() { }
        public void UpdateProfilePicture() { }
    }
}

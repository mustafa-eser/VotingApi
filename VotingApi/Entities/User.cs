namespace VotingApi.Entities
{
    public class User
    {
        public required string userId { get; set; }
        public string fullName { get; set; } = string.Empty;
        public required string email { get; set; }
        public required string password { get; set; }
        public bool isMailVerified { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }
    }
}

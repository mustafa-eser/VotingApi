namespace VotingApi.Entities
{
    public class Bracket
    {
        public required string bracketId { get; set; }
        public string bracketName { get; set; } = string.Empty;
        public required string userId { get; set; }
        public string winnerImageId { get; set; } = string.Empty;
        public string status { get; set; } = "draft";
        public string shareUrlToken { get; set; } = string.Empty;
        public DateTime expirationDate  { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }
    }
}

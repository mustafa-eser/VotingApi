namespace VotingApi.Entities
{
    public class Image
    {
        public required string imageId { get; set; }
        public string imageData { get; set; } = string.Empty;
        public int voteCount { get; set; } = 0;
        public int winnerCount { get; set; } = 0;
        public required string bracketId { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }
    }
}

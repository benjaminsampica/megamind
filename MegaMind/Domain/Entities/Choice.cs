namespace MegaMind.Domain.Entities
{
    public class Choice
    {
        public int Id { get; set; }
        public int StoryId { get; set; }
        public int ConsequenceId { get; set; }
        public string Text { get; set; }

        public Consequence Consequence { get; set; }
        public Story Story { get; set; }
    }
}

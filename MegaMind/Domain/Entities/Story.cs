using System.Collections.Generic;

namespace MegaMind.Domain.Entities
{
    public class Story
    {
        public int Id { get; set; }
        public string Text { get; set; }

        public IEnumerable<Choice> Choices { get; set; }
    }
}

using MegaMind.Domain.Entities;
using System.Collections.Generic;

namespace MegaMind.Persistence.Data
{
    static class SeededStory
    {
        public static IReadOnlyCollection<Story> SeededStories = new List<Story>()
        {
            new Story
            {
                Id = 1,
                Text = "Story 1",
                Choices = SeededChoice.SeededChoices
            },
            new Story
            {
                Id = 2,
                Text = "Story 2",
                Choices = SeededChoice.SeededChoices
            }
        };
    }
}

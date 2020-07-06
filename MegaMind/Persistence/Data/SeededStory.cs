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
                Text = "Management says you're over budget and behind schedule - with months still left to release a working product. Management 'asks' you if you can work overtime in order to meet the deadline since you demanded to write 'tests'. How do you respond?",
                Choices = SeededChoice.StoryOneChoices
            },
            new Story
            {
                Id = 2,
                Text = "Story 2",
                Choices = SeededChoice.StoryTwoChoices
            },
            new Story
            {
                Id = 3,
                Text = "Story 3",
                Choices = SeededChoice.StoryThreeChoices
            },
            new Story
            {
                Id = 4,
                Text = "Story 3",
                Choices = SeededChoice.StoryFourChoices
            }
        };
    }
}

using MegaMind.Domain.Entities;
using System.Collections.Generic;

namespace MegaMind.Persistence.Data
{
    static class SeededChoice
    {
        public static IReadOnlyCollection<Choice> StoryOneChoices = new List<Choice>()
        {
            new Choice
            {
                Id = 1,
                Text = "Agree to work overtime.",
                Consequence = new Consequence
                {
                    Id = 1,
                    Text = "You burn out after the first couple of weeks and find your team actually going slower. The deadline goal strays even further."
                }
            },
            new Choice
            {
                Id = 2,
                Text = "Argue with your boss about the merits of overtime.",
                Consequence = new Consequence
                {
                    Id = 2,
                    Text = "After a few minutes of back and forth, he says something about why 'you aren't running this shop since you're so smart'. After the meeting, he sends an email to your team asking and a few 'heroes' volunteer the team."
                }
            },
            AllStoryChoice("Your boss sends an email to your team as if you said yes. You didn't say no, right? You burn out after the first couple of weeks and find your team actually going slower. The deadline goal strays even further.")
        };

        public static IReadOnlyCollection<Choice> StoryTwoChoices = new List<Choice>()
        {
            new Choice
            {
                Id = 1,
                Text = "",
            },
            new Choice
            {
                Id = 2,
                Text = "",
            }
        };

        public static IReadOnlyCollection<Choice> StoryThreeChoices = new List<Choice>()
        {
            new Choice
            {
                Id = 1,
                Text = "",
            },
            new Choice
            {
                Id = 2,
                Text = "",
            }
        };

        public static IReadOnlyCollection<Choice> StoryFourChoices = new List<Choice>()
        {
            new Choice
            {
                Id = 1,
                Text = "",
            },
            new Choice
            {
                Id = 2,
                Text = "",
            }
        };

        private static Choice AllStoryChoice(string consequenceText)
        {
            return new Choice
            {
                Id = 100,
                Text = "Act like you didn't hear the question and hope they don't ask it again.",
                Consequence = new Consequence
                {
                    Id = 2,
                    Text = consequenceText
                }
            };
        }
    }
}

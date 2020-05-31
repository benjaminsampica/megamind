using MegaMind.Domain.Entities;
using System.Collections.Generic;

namespace MegaMind.Persistence.Data
{
    static class SeededChoice
    {
        public static IReadOnlyCollection<Choice> SeededChoices = new List<Choice>()
        {
            new Choice
            {
                Id = 1,
                Text = "Choice 1"
            },
            new Choice
            {
                Id = 2,
                Text = "Choice 2"
            },
            new Choice
            {
                Id = 3,
                Text = "Choice 3"
            }
        };
    }
}

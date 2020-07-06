using MegaMind.Application.Common.Interfaces;
using MegaMind.Domain.Entities;
using MegaMind.Persistence.Data;
using System.Collections.Generic;

namespace MegaMind.Persistence
{
    public class MegaMindDbContext : IMegaMindDbContext
    {
        public IReadOnlyCollection<Story> Stories { get; set; } = SeededStory.SeededStories;
    }
}

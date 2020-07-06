using MegaMind.Domain.Entities;
using System.Collections.Generic;

namespace MegaMind.Application.Common.Interfaces
{
    public interface IMegaMindDbContext
    {
        IReadOnlyCollection<Story> Stories { get; set; }
    }
}

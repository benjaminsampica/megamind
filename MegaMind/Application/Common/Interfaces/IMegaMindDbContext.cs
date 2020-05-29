using MegaMind.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace MegaMind.Application.Common.Interfaces
{
    public interface IMegaMindDbContext
    {
        DbSet<Choice> Choices { get; set; }
    }
}

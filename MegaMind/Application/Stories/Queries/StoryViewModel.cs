using AutoMapper;
using MegaMind.Application.Common.Mappings;
using MegaMind.Domain.Entities;
using System.Collections.Generic;

namespace MegaMind.Application.Stories.Queries
{
    public class StoryViewModel : IMapFrom<Story>
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public IEnumerable<Choice> Choices { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Story, StoryViewModel>();
        }
    }
}

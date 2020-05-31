using AutoMapper;
using MediatR;
using MegaMind.Application.Common.Interfaces;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MegaMind.Application.Stories.Queries
{
    public class GetStoryQuery : IRequest<StoryViewModel>
    {
        public GetStoryQuery(int id) => Id = id;

        private int Id { get; }

        public class GetCustomersListQueryHandler : IRequestHandler<GetStoryQuery, StoryViewModel>
        {
            private readonly IMegaMindDbContext _context;
            private readonly IMapper _mapper;

            public GetCustomersListQueryHandler(IMegaMindDbContext context, IMapper mapper)
            {
                _context = context;
                _mapper = mapper;
            }

            public async Task<StoryViewModel> Handle(GetStoryQuery request, CancellationToken cancellationToken)
            {
                var story = _mapper.Map<GetStoryDto>(_context.Stories.Single(s => s.Id == request.Id));
                var vm = _mapper.Map<StoryViewModel>(story);

                return vm;
            }
        }
    }
}

using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using MegaMind.Application.Common.Interfaces;
using System.Threading;
using System.Threading.Tasks;

namespace MegaMind.Application.Choices.Queries
{
    public class GetCustomersListQueryHandler : IRequestHandler<GetChoicesListQuery, ChoicesListViewModel>
    {
        private readonly IMegaMindDbContext _context;
        private readonly IMapper _mapper;

        public GetCustomersListQueryHandler(IMegaMindDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<ChoicesListViewModel> Handle(GetChoicesListQuery request, CancellationToken cancellationToken)
        {
            var choices = await _context.Choices
                .ProjectTo<GetChoiceListDto>(_mapper.ConfigurationProvider)
                .ToListAsync(cancellationToken);

            var vm = new ChoicesListViewModel
            {
                Choices = choices
            };

            return vm;
        }
    }
}

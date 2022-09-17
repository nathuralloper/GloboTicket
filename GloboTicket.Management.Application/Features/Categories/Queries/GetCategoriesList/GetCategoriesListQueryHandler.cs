using AutoMapper;
using GloboTicket.Management.Application.Contracts.Persistence;
using GloboTicket.Management.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GloboTicket.Management.Application.Features.Categories.Queries.GetCategoriesList
{
    class GetCategoriesListQueryHandler : IRequestHandler<GetCategoriesListQuery, List<CategoryListVm>>
    {
        private readonly IAsyncRepository<Category> _categoryRepository;
        private readonly IMapper _mapper;
        public GetCategoriesListQueryHandler(IAsyncRepository<Category> categoryRepository,
            IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }
        public async Task<List<CategoryListVm>> Handle(GetCategoriesListQuery request, CancellationToken cancellationToken)
        {
            var allCategories = (await _categoryRepository.ListAllAsync()).OrderBy(x => x.Name);
            return _mapper.Map<List<CategoryListVm>>(allCategories);
        }
    }
}

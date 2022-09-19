using AutoMapper;
using GloboTicket.Management.Application.Contracts.Persistence;
using GloboTicket.Management.Application.Profiles;
using GloboTicket.Management.Application.UnitTests.Mocks;
using GloboTicket.Management.Domain.Entities;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using GloboTicket.Management.Application.Features.Categories.Queries.GetCategoriesList;
using System.Threading;
using Shouldly;

namespace GloboTicket.Management.Application.UnitTests.Categories.Queries
{

    public class GetCategoriesListQueryHandlerTests
    {
        private readonly IMapper _mapper;
        private readonly Mock<IAsyncRepository<Category>> _mockCategoryRepository;

        public GetCategoriesListQueryHandlerTests()
        {
            _mockCategoryRepository = RepositoryMocks.GetCategoryRepository();
            var configurationProvider = new MapperConfiguration(cfg => 
            {
                cfg.AddProfile<MappingProfile>();
            });

            _mapper = configurationProvider.CreateMapper();
        }

        [Fact]
        public async Task GetCategoriesTest()
        {
            var handler = new GetCategoriesListQueryHandler(_mockCategoryRepository.Object, _mapper);

            var result = await handler.Handle(new GetCategoriesListQuery(), CancellationToken.None);

            result.ShouldBeOfType<List<CategoryListVm>>();

            result.Count.ShouldBe(4);
        }
    }
}

using AutoMapper;
using GloboTicket.Management.Application.Features.Categories.Queries.GetCategoriesList;
using GloboTicket.Management.Application.Features.Categories.Queries.GetCategoriesListWithEvents;
using GloboTicket.Management.Application.Features.Events;
using GloboTicket.Management.Application.Features.Events.Commands.CreateEvent;
using GloboTicket.Management.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GloboTicket.Management.Application.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Event, EventListVm>().ReverseMap();
            CreateMap<Event, EventDetailVm>().ReverseMap();
            CreateMap<Category, CategoryDto>();
            CreateMap<Category, CategoryListVm>();
            CreateMap<Category, CategoryEventListVm>();
            CreateMap<Event, CreateEventCommand>().ReverseMap();
        }
    }
}

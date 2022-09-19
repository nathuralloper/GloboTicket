using AutoMapper;
using GloboTicket.Management.Application.Features.Categories.Commands.CreateCategory;
using GloboTicket.Management.Application.Features.Categories.Queries.GetCategoriesList;
using GloboTicket.Management.Application.Features.Categories.Queries.GetCategoriesListWithEvents;
using GloboTicket.Management.Application.Features.Events;
using GloboTicket.Management.Application.Features.Events.Commands.CreateEvent;
using GloboTicket.Management.Application.Features.Events.Commands.UpdateEvent;
using GloboTicket.Management.Application.Features.Events.Queries.GetEventsExport;
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
            CreateMap<Event, CreateEventCommand>().ReverseMap();
            CreateMap<Event, UpdateEventCommand>().ReverseMap();
            CreateMap<Event, EventDetailVm>().ReverseMap();
            CreateMap<Event, CategoryEventDto>().ReverseMap();
            CreateMap<Event, EventExportDto>().ReverseMap();

            CreateMap<Category, CategoryDto>();
            CreateMap<Category, CategoryListVm>();
            CreateMap<Category, CategoryEventListVm>();
            CreateMap<Category, CreateCategoryCommand>();
            CreateMap<Category, CreateCategoryDto>();

        }
    }
}

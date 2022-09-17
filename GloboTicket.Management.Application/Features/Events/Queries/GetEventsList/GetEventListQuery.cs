using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace GloboTicket.Management.Application.Features.Events
{
    public class GetEventListQuery : IRequest<List<EventListVm>>
    {
    }
}

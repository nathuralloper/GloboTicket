using AutoMapper;
using GloboTicket.Management.Application.Contracts.Persistence;
using GloboTicket.Management.Application.Exceptions;
using GloboTicket.Management.Application.Features.Events.Commands.CreateEvent;
using GloboTicket.Management.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GloboTicket.Management.Application.Features.Events.Commands.UpdateEvent
{
    public class UpdateEventCommandHandler : IRequestHandler<UpdateEventCommand>
    {
        private readonly IEventRepository _eventRepository;
        private readonly IMapper _mapper;

        public UpdateEventCommandHandler(IEventRepository eventRepository, IMapper mapper)
        {
            _eventRepository = eventRepository;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(UpdateEventCommand request, CancellationToken cancellationToken)
        {
            var eventToUpdate = await _eventRepository.GetByIdAsync(request.EventId);
            if (eventToUpdate == null)
            {
                throw new NotFoundException(nameof(Event), request.EventId);
            }

            var validator = new UpdateEventCommandValidator();
            var validationResult = await validator.ValidateAsync(request);
            if (validationResult.Errors.Count > 0)
            {
                throw new ValidationException(validationResult);
            }

            _mapper.Map(request, eventToUpdate, typeof(UpdateEventCommand), typeof(Event));
            await _eventRepository.UpdateAsync(eventToUpdate);

            return Unit.Value;

        }
    }
}

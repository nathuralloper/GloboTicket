using GloboTicket.Management.Application.Features.Events.Queries.GetEventsExport;
using System;
using System.Collections.Generic;
using System.Text;

namespace GloboTicket.Management.Application.Contracts.Infrastructure
{
    public interface ICsvExporter
    {
        byte[] ExportEventsToCsv(List<EventExportDto> eventExportDtos);
    }
}

using CsvHelper;
using GloboTicket.Management.Application.Contracts.Infrastructure;
using GloboTicket.Management.Application.Features.Events.Queries.GetEventsExport;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace GloboTicket.Management.Infrastructure.FileExport
{
    public class CsvExporter : ICsvExporter
    {
        public byte[] ExportEventsToCsv(List<EventExportDto> eventExportDtos)
        {
            var memoryStream = new MemoryStream();
            using (var streamWriter = new StreamWriter(memoryStream))
            {
                var csvWriter = new CsvWriter(streamWriter);
                csvWriter.WriteRecord(eventExportDtos);
            }

            return memoryStream.ToArray();
        }
    }
}

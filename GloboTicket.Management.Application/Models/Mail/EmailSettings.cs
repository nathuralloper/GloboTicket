using System;
using System.Collections.Generic;
using System.Text;

namespace GloboTicket.Management.Application.Models.Mail
{
    public class EmailSettings
    {
        public string ApiKey { get; set; }
        public string FromAddress { get; set; }
        public string FromName { get; set; }
    }
}

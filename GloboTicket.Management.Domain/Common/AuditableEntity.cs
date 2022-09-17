using System;
using System.Collections.Generic;
using System.Text;

namespace GloboTicket.Management.Domain.Common
{
    public class AuditableEntity
    {
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string LastModifyBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }
    }
}
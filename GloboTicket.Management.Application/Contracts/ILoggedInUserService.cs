using System;
using System.Collections.Generic;
using System.Text;

namespace GloboTicket.Management.Application.Contracts
{
    public interface ILoggedInUserService
    {
        string UserId { get; }
    }
}

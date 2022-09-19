using System;
using System.Collections.Generic;
using System.Text;

namespace GloboTicket.Management.Application.Models.Authentication
{
    public class AuthenticationRequest
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}

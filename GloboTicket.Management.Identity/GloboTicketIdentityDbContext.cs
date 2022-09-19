using GloboTicket.Management.Identity.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace GloboTicket.Management.Identity
{
    public class GloboTicketIdentityDbContext : IdentityDbContext<ApplicationUser>
    {
        public GloboTicketIdentityDbContext(DbContextOptions<GloboTicketIdentityDbContext> options)
            : base (options)
        {
        }
    }
}

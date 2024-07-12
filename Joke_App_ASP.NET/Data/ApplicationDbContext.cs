using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Joke_App_ASP.NET.Models;

namespace Joke_App_ASP.NET.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Joke_App_ASP.NET.Models.Joke> Joke { get; set; } = default!;
    }
}

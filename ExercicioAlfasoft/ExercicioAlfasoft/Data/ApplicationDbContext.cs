using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ExercicioAlfasoft.Models;

namespace ExercicioAlfasoft.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<ExercicioAlfasoft.Models.Contact> Contact { get; set; } = default!;
    }
}

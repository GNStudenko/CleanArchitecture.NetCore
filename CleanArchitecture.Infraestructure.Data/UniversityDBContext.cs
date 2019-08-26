using CleanArchitecture.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitecture.Infraestructure.Data
{
    public class UniversityDBContext : DbContext
    {
        public UniversityDBContext (DbContextOptions options) : base(options)
        {

        }

        public DbSet<Course> Courses { get; set; }
    }    
}

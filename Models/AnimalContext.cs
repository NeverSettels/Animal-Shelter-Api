  
using Microsoft.EntityFrameworkCore;

namespace Animal-Api.models
{
 public class AnimalContext : DbContext
 {
   public AnimalContext(DbContextOptions<AnimalContext> options)
            : base(options)
        {
        }
    public DbSet<Animal> Animal { get; set; }
 }
}
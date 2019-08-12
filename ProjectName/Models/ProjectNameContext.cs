using Microsoft.EntityFrameworkCore;

namespace ProjectName.Models
{
  public class ProjectNameContext : DbContext
  {
    public virtual DbSet<Class1> Class1Plural { get; set; }
    public DbSet<Class2> Class2Plural { get; set; }
    public DbSet<Class1Class2> Class1Class2 { get; set; }

    public ProjectNameContext(DbContextOptions options) : base(options) { }
  }
}
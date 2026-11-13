using Microsoft.EntityFrameworkCore;

public class WebAPIContext(DbContextOptions<WebAPIContext> options) : DbContext(options)
{
    public DbSet<WebAPI.Models.Curso> Curso { get; set; } = default!;
}

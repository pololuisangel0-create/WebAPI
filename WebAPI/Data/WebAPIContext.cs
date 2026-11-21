using Microsoft.EntityFrameworkCore;
using System.Data.Common;

public class WebAPIContext(DbContextOptions<WebAPIContext> options) : DbContext(options)
{
    public DbSet<WebAPI.Models.Curso> Curso { get; set; } = default!;
    public DbSet<WebAPI.Models.Nivel> Nivel { get; set; } = default!;
}

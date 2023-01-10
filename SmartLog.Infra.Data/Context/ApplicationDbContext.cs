using Microsoft.EntityFrameworkCore;
using SmartLog.Domain.Entities;

namespace SmartLog.Infra.Data.Context;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> opt) : base(opt)
    {
    }

    public DbSet<Log> Log { get; set; }
}
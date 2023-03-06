using Medicine.DataAccess.Interfaces;
using Medicine.Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace Medicine.DataAccess.Sql
{
    public class AppDbContext : AppDbContextReadOnly, IAppDbContext
    {
        public AppDbContext(DbContextOptions options) : base(options) { }

        public Task<int> SaveChagesAsync(CancellationToken cancellationToken = default) => base.SaveChangesAsync(cancellationToken);

    }
}

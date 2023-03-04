using DataAccess.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Sql
{
    public class AppDbContext : AppDbContextReadOnly, IAppDbContext
    {
        public AppDbContext(DbContextOptions<AppDbContextReadOnly> options) : base(options) { }

        public Task<int> SaveChagesAsync(CancellationToken cancellationToken = default) => base.SaveChangesAsync(cancellationToken);    
    }
}

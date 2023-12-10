using Medicine.Infrastructure.Interfcases.DataAccess;
using Microsoft.EntityFrameworkCore;

namespace Medicine.Infrastructure.Implementation.DataAccesPsql
{
    public class AppDbContext : AppDbContextReadOnly, IAppDbContext
    {
        public AppDbContext(DbContextOptions options) : base(options) { }

        public Task<int> SaveChagesAsync(CancellationToken cancellationToken = default) => base.SaveChangesAsync(cancellationToken);

    }
}

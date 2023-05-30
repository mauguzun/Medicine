using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Medicine.DataAccess.Interfaces
{
    public interface IAppDbContext : IAppDbContextReadonly
    {
        public ChangeTracker ChangeTracker { get; }

        Task<int> SaveChagesAsync(CancellationToken cancellationToken = default);
        public int SaveChanges();
    }
}
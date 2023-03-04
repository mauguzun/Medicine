namespace DataAccess.Interfaces
{
    public interface IDbContext : IDbContextReadonly
    {
       Task<int> SaveChagesAsync(CancellationToken cancellationToken = default);
    }
}
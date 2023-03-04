namespace Medicine.DataAccess.Interfaces
{
    public interface IAppDbContext : IAppDbContextReadonly
    {
        Task<int> SaveChagesAsync(CancellationToken cancellationToken = default);
    }
}
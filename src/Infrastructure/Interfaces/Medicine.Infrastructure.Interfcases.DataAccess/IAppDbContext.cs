namespace Medicine.Infrastructure.Interfcases.DataAccess
{
    public interface IAppDbContext : IAppDbContextReadonly
    {
        Task<int> SaveChagesAsync(CancellationToken cancellationToken = default);
        public int SaveChanges();
    }
}
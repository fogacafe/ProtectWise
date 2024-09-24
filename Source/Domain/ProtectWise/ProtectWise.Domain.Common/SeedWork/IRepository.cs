namespace ProtectWise.Domain.Common.SeedWork
{
    public interface IRepository<T,TId> where T : Entity<TId>
    {
        Task<Entity<TId>> FindAsync(TId id);
        Task AddAsync(T entity);
        Task UpdateAsync(T entity);
    }
}

using AutoMapper;
using Medicine.DataAccess.Interfaces;
using Medicine.Entities.Models.Base;
using Microsoft.EntityFrameworkCore;

namespace Medicine.WebApplication.GraphQL.DataLoaders
{

    public interface IResponseLoader<TKey, TEntity, TResponse> : IDataLoader<TKey, TResponse>
        where TKey : notnull
        where TEntity : class, IEntity
        where TResponse : class, IEntity
    {
        public Task<IEnumerable<TResponse>> LoadAsync(Func<TEntity, bool> conditionLambda);

    }

    public class ResponseLoader<TKey, TEntity, TResponse> : IResponseLoader<TKey, TEntity, TResponse>
       where TKey : notnull
       where TEntity : class, IEntity
       where TResponse : class, IEntity
    {

        private readonly IAppDbContextReadonly _dbContext;
        private readonly IMapper _mapper;


        public ResponseLoader(
        IAppDbContextReadonly dbContext,
        IMapper mapper)

        {
            _dbContext = dbContext;
            _mapper = mapper;
        }



        public void Clear()
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<TResponse>> LoadAsync(Func<TEntity, bool> conditionLambda)
        {
            var items = _dbContext.Set<TEntity>().Where(conditionLambda);
            var convertedItems = _mapper.Map<IReadOnlyList<TResponse>>(items);

            return convertedItems;
        }

        public async Task<TResponse> LoadAsync(TKey key, CancellationToken cancellationToken = default)
        {
            var items = await _dbContext.Set<TEntity>().FindAsync(key);
            return _mapper.Map<TResponse>(items);
        }

        public async Task<IReadOnlyList<TResponse>> LoadAsync(IReadOnlyCollection<TKey> keys, CancellationToken cancellationToken = default)
        {
            var items = _dbContext.Set<TEntity>();
            var convertedItems = _mapper.Map<IReadOnlyList<TResponse>>(items);

            return convertedItems;
        }

        public Task<object?> LoadAsync(object key, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyList<object?>> LoadAsync(IReadOnlyCollection<object> keys, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public void Remove(TKey key)
        {
            throw new NotImplementedException();
        }

        public void Remove(object key)
        {
            throw new NotImplementedException();
        }

        public void Set(TKey key, Task<TResponse> value)
        {
            throw new NotImplementedException();
        }

        public void Set(object key, Task<object?> value)
        {
            throw new NotImplementedException();
        }
    }

}


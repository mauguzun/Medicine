using AutoMapper;
using Medicine.DataAccess.Interfaces;
using Medicine.Entities.Models.Base;
using Microsoft.EntityFrameworkCore;

namespace Medicine.WebApplication.GraphQL.DataLoaders
{

    public class DataLoader<TKey, TEntity> : IDataLoader<TKey, TEntity>
        where TKey : notnull
        where TEntity : class, IEntity
    {
        private readonly IAppDbContextReadonly _dbContext;
        private readonly IMapper _mapper;

        public DataLoader(
            IAppDbContextReadonly dbContext,
            IMapper mapper,
            IBatchScheduler batchScheduler,
            DataLoaderOptions? options = null)

        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public Task<TEntity> LoadAsync(TKey key, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public async Task<IReadOnlyList<TEntity>> LoadAsync(IReadOnlyCollection<TKey> keys, CancellationToken cancellationToken = default)
        {
            var items = await _dbContext.Set<Medicine.Entities.Models.Reminder>().ToListAsync();
            return _mapper.Map<IReadOnlyList<TEntity>>(items);

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

        public void Set(TKey key, Task<TEntity> value)
        {
            throw new NotImplementedException();
        }

        public void Set(object key, Task<object?> value)
        {
            throw new NotImplementedException();
        }


        //protected async Task<TRespose> LoadAsync()
        //{
        //    var items = await _dbContext.Set<TEntity>().ToListAsync();
        //    return _mapper.Map<TRespose>(items);
        //}


    }


    public class BatchLoader<TEntity, TRespose> : BatchDataLoader<int, TRespose>

        where TEntity : class, IEntity
    {
        private readonly IAppDbContextReadonly _dbContext;
        private readonly IMapper _mapper;

        public BatchLoader(
            IAppDbContextReadonly dbContext,
            IMapper mapper,
            IBatchScheduler batchScheduler,
            DataLoaderOptions? options = null)
            : base(batchScheduler, options)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }


        // kak  
        protected override async Task<IReadOnlyDictionary<int, TRespose>>
            LoadBatchAsync(IReadOnlyList<int> keys, CancellationToken cancellationToken)
        {
            var items = await _dbContext.Set<TEntity>().Where(t => keys.Contains(t.Id)).ToListAsync();
            return items.ToDictionary(p => p.Id, p => _mapper.Map<TRespose>(p));
        }


        //protected override async Task<TRespose> LoadBatchAsync(int key, CancellationToken cancellationToken)
        //{
        //    var item = await _dbContext.Set<TEntity>().FindAsync(key);
        //    return _mapper.Map<TRespose>(item);
        //}

    }
}


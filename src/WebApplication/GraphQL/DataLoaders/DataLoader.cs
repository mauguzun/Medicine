using AutoMapper;
using AutoMapper.Configuration.Annotations;
using Medicine.DataAccess.Interfaces;
using Medicine.Entities.Models;
using Medicine.Entities.Models.Base;
using Microsoft.EntityFrameworkCore;

namespace Medicine.WebApplication.GraphQL.DataLoaders
{


    public class DataLoader<TEntity, TRespose> : BatchDataLoader<int, TRespose>,
        IDataLoader<int, TRespose>
        where TEntity : class, IEntity
    {
        private readonly IAppDbContextReadonly _dbContext;
        private readonly IMapper _mapper;

        public DataLoader(
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

        protected async Task<TRespose> LoadAsync(int id)
        {
            var items = await _dbContext.Set<TEntity>().FindAsync(id);
            return _mapper.Map<TRespose>(items);
        }

        protected async Task<TRespose> LoadAsync()
        {
            var items = await _dbContext.Set<TEntity>().ToListAsync() ;
            return _mapper.Map<TRespose>(items);
        }



        //protected override async Task<TRespose> LoadBatchAsync(int key, CancellationToken cancellationToken)
        //{
        //    var item = await _dbContext.Set<TEntity>().FindAsync(key);
        //    return _mapper.Map<TRespose>(item);
        //}

    }
}


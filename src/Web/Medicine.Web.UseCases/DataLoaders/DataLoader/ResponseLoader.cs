using AutoMapper;
using Medicine.Application.Interfaces;
using Medicine.Entities.Models;
using Medicine.Entities.Models.Base;
using Medicine.Infrastructure.Interfcases.DataAccess;
using Medicine.Web.UseCases.Responses;
using Microsoft.EntityFrameworkCore;
using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Medicine.Web.UseCases.DataLoaders.BaseDataLoader
{
    public class ResponseLoader<TKey, TEntity, TResponse> : IResponseLoader<TKey, TEntity, TResponse>
       where TKey : notnull
       where TEntity : class, IEntity
       where TResponse : class, IEntity
    {

        private readonly IAppDbContextReadonly _dbContext;
        private readonly IMapper _mapper;

        public ResponseLoader(IAppDbContextReadonly dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public void Clear() 
        {
            throw new NotImplementedException();
        }


        public async Task<IEnumerable<DrugCategoryResponse>> LoadCategoriesByDrugId(int id, CancellationToken ct = default)
        {
            IEnumerable<DrugCategory> items = _dbContext.Drugs
                .Where(x => x.Id == id)
                .Include(x => x.DrugCategories)
                .SelectMany(x => x.DrugCategories);

            var convertedItems =  _mapper.Map<IEnumerable<DrugCategoryResponse>>(items) ;
            return convertedItems;
        }


        public async Task<IEnumerable<TResponse>> LoadByCondition(Func<TEntity, bool> conditionLambda, CancellationToken ct = default)
        {
            var items = _dbContext.Set<TEntity>()?.Where(conditionLambda);
            var convertedItems = _mapper.Map<IEnumerable<TResponse>>(items);

            return convertedItems;
        }


        public async Task<TResponse> LoadAsync(TKey key, CancellationToken cancellationToken = default)
        {
            var items = await _dbContext.Set<TEntity>().FindAsync(key);
            return _mapper.Map<TResponse>(items);
        }

        public async Task<IReadOnlyList<TResponse>> LoadAsync(IReadOnlyCollection<TKey> keys, CancellationToken cancellationToken = default)
        {
            //var items = await _dbContext.Set<TEntity>().ToListAsync();
            var items = await _dbContext.Set<TEntity>().ToListAsync();
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


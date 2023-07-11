﻿using GreenDonut;
using Medicine.Entities.Models.Base;
using Medicine.Web.UseCases.Responses;

namespace Medicine.Web.UseCases.DataLoaders.DataLoader
{
    public interface IResponseLoader<TKey, TEntity, TResponse> : IDataLoader<TKey, TResponse>
        where TKey : notnull
        where TEntity : class, IEntity
        where TResponse : class, IEntity
    {
        public Task<IEnumerable<TResponse>> LoadByCondition(Func<TEntity, bool> conditionLambda, CancellationToken ct = default);
        public Task<IEnumerable<DrugCategoryDto>> LoadCategoriesByDrugId(int ids, CancellationToken ct = default);
    }

}


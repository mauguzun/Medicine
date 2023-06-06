using GreenDonut;
using Medicine.Entities.Models.Base;

namespace Medicine.Web.UseCases.DataLoaders.BaseDataLoader
{
    public interface IResponseLoader<TKey, TEntity, TResponse> : IDataLoader<TKey, TResponse>
        where TKey : notnull
        where TEntity : class, IEntity
        where TResponse : class, IEntity
    {
        public Task<IEnumerable<TResponse>> LoadAsync(Func<TEntity, bool> conditionLambda);

    }

}


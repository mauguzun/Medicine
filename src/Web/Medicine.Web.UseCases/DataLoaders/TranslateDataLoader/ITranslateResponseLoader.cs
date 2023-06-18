using GreenDonut;
using Medicine.Entities.Models.Base;

namespace Medicine.Web.UseCases.DataLoaders.TranslateDataLoader
{
    public interface ITranslateResponseLoader<TKey, TEntity, TResponse> : IDataLoader<TKey, TResponse>
       where TKey : notnull
       where TEntity : class, IEntity
       where TResponse : class, IEntity
    {
        public Task<IEnumerable<TResponse>> LoadByCondition(Func<TEntity, bool> conditionLambda);
    }

}


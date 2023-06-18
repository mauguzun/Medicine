using AutoMapper;
using Medicine.Application.Interfaces;
using Medicine.Entities.Models.Base;
using Medicine.Entities.Models.Base.Interfaces;
using Medicine.Infrastructure.Interfcases.DataAccess;

namespace Medicine.Web.UseCases.DataLoaders.TranslateDataLoader
{
    public class TranslateResponseLoader<TKey, TEntity, TResponse> : ITranslateResponseLoader<TKey, TEntity, TResponse>
       where TKey : notnull
       where TEntity : class, ITransatedEntity
       where TResponse : class, IEntity
    {

        private readonly IAppDbContextReadonly _dbContext;
        private readonly ILanguageService _languageService;
        private readonly IMapper _mapper;

        public TranslateResponseLoader(IAppDbContextReadonly dbContext, ILanguageService languageService, IMapper mapper)
        {
            _dbContext = dbContext;
            _languageService = languageService;
            _mapper = mapper;
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<TResponse>> LoadByCondition(Func<TEntity, bool> conditionLambda)
        {
            var items = _dbContext.Set<TEntity>()?.Where(x => x.Language == _languageService.Language()).Where(conditionLambda);
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


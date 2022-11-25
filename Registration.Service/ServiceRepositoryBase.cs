using Registration.Fasade.Interfaces.Repository;
using Registration.Fasade.Interfaces.Service;

namespace Registration.Service;

public class ServiceRepositoryBase<TModel> : ServiceBase<TModel>, IServiceRepositoryBase<TModel> where TModel : class
{
    protected readonly IRepositoryBase<TModel> _repository;

    public ServiceRepositoryBase(IRepositoryBase<TModel> repository)
    {
        _repository = repository;
    }

    public virtual async Task AddAsync(TModel entity) => await _repository.AddAsync(entity);//

    public virtual async Task<IEnumerable<TModel>> LoadAsync() => await _repository.LoadAsync();//

    public virtual async Task<TModel> GetByIdAsync(object id) => await _repository.GetByIdAsync(id);//

    public virtual async Task UpdateAsync(TModel entity) => await _repository.UpdateAsync(entity);

    public virtual async Task RemoveAsync(TModel entity) => await _repository.RemoveAsync(entity);
}
﻿namespace Registration.Fasade.Interfaces.Repository;

public interface IRepositoryBase<TModel> where TModel : class
{
    Task AddAsync(TModel entity);
    Task<TModel> GetByIdAsync(object id);
    Task<IEnumerable<TModel>> LoadAsync();
    Task RemoveAsync(TModel entity);
    Task UpdateAsync(TModel entity);
}

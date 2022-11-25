using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registration.Fasade.Interfaces.Service;

public interface IServiceRepositoryBase<TModel> : IServiceBase<TModel> where TModel : class
{
    Task AddAsync(TModel entity);
    Task<IEnumerable<TModel>> LoadAsync();
    Task<TModel> GetByIdAsync(object id);
    Task UpdateAsync(TModel entity);
    Task RemoveAsync(TModel entity);
}

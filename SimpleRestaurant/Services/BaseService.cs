using SimpleRestaurant.Models;
using SimpleRestaurant.Abstractions.Services;

namespace SimpleRestaurant.Services;

public abstract class BaseService<T>:IBaseService<T> where T:EntityBase
{
    private readonly IDataProvider<T> _provider;
    public BaseService(IDataProvider<T> provider)
    {
        _provider = provider;
    }
    public void Add(T entity)
    {
        _provider.Add(entity);
    }

    public void Delete(T entity)
    {
        _provider.Delete(entity);
    }

    public List<T> GetById(long id)
    {
        return _provider.GetById(id);
    }
}
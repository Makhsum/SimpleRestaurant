using SimpleRestaurant.Models;

namespace SimpleRestaurant.Abstractions.Services;

public interface IBaseService<T> where  T:EntityBase
{
    void Add(T entity);
    void Delete(T entity);
    List<T> GetById(long id);
}
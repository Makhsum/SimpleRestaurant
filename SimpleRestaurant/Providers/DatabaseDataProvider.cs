using SimpleRestaurant.Abstractions.Services;
using SimpleRestaurant.Models;

namespace SimpleRestaurant.Providers;

public class DatabaseDataProvider<T>:IDataProvider<T> where T : EntityBase 
{
    public List<T> list { get; private set; }
    public void Add(T entity)
    {
        list.Add(entity);
    }

    public void Delete(T entity)
    {
        list.RemoveAt(list.IndexOf(entity));
    }
    

    public List<T> GetById(long id)
    {
        return list.Where(i => i.Id == id).ToList();
    }
    
}


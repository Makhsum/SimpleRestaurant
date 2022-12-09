using SimpleRestaurant.Abstractions.Services;

namespace SimpleRestaurant.Models;

public class Cook:Person,ICook
{
    
    public void Add(ref string[] menu,int portion)
    {
        Obtain(ref menu,portion);
    }
    private void Obtain(ref string[] menu,int portion)
    {
        foreach (var food in menu)
        {
            Console.Write($"Подано {portion} порция {food}" + " ");
        }
    }
    
}
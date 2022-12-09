namespace SimpleRestaurant.Abstractions.Services;

public interface ICook
{
    void Add(ref string[] menu,int portion);
}
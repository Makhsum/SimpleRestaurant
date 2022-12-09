namespace SimpleRestaurant.Models;

public class Food
{
    public string[] Name { get; set; }
    public int[] Price { get; private set; } = {2, 2, 5};
}
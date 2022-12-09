namespace SimpleRestaurant.Models;

public class Check
{
    public DateTime Time { get; set; }
    public string FoodName { get; set; }
    public Waiter Waiter { get; set; }
    public Cook Cook { get; set; }
    public int Price { get; set; }
}
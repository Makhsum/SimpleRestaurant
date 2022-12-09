using SimpleRestaurant.Abstractions.Services;

namespace SimpleRestaurant.Models;

public class Waiter:Person,IWaiter
{
    private Cook shefpowar = new ();
    private static Admin admin = new ();
    private static Food food = new ();
    string[] menu =food.Name = new[] {"Курица", "Мясо", "КартофельФри"};
    
    public void Menu()
    {
          
        Console.WriteLine("Menu:");
        for (int i = 0; i < menu.Length; i++)
        {
            
            Console.WriteLine($"{i+1}){menu[i]} цена {food.Price[i]},\t");
        }
        Console.WriteLine("Желаете что-то заказать да/нет");
        string? command = Console.ReadLine()?.ToLower();
        switch (command)
        {
            
            case null:
            case "": 
                break;
            case"нет":
                break;
            case "да":
                Serve();
                break;
            default:
                Console.WriteLine("да/нет");
                break;
        }
    }

    private  void Serve()
    {
        Console.WriteLine("выберите  кол-во порций и еду");
        string? portion = Console.ReadLine();   
        string? food = Console.ReadLine();
        if (portion == "" || food == "" || food == null || portion == null) return;
        string[] selectedfood = new string [1] {menu[int.Parse(food)-1]};
        shefpowar.Add(ref selectedfood, int.Parse(portion));
    }
    public void Help()
    {
        Console.WriteLine("Команды: Меню, Выход, Заказать, выход");
    }

    public void AdminValidation()
    {
        Console.WriteLine("Введите имя пользователя!");
        string? name = Console.ReadLine();
        Console.WriteLine("Введите пароль!");
        string? pass = Console.ReadLine();
        Validation(name,pass);
    }

    private void Validation(string? name,string? pass)
    {
        if (pass == "root")
        {
            admin = new Admin(ref menu,name);
        }
        else{
        
            for (int i = 3; i >= 0; i--)
            {
                
                pass = Console.ReadLine();
                if (pass == "root")
                {
                    admin = new Admin(ref menu,name);
                }
                else
                {
                    Console.WriteLine($"Неправильно у вас осталось {i} попытки");
                }
            }
            
        }
    }
}
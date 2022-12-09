// using SimpleRestaurant.Models;
//
// Waiter waiter = new();
//
// while (true)
// {
//    
//     string? command = Console.ReadLine()?.ToLower();
//     switch (command)
//     {
//         case "меню":
//             waiter.Menu();
//             break;
//         case "":
//         case null:
//             break;
//         case "выход":
//             Console.WriteLine("Пока");
//             return;
//         case "помощь":
//             waiter.Help();
//             break;
//         case "админ":
//             waiter.AdminValidation();
//             break;
//         default:
//             Console.WriteLine("Не понимаю вашу команду");
//             break;
//     }
// }

Console.WriteLine("HelloWorld");
MultiThreading.MainAction();

public class MultiThreading
{
    public static void Action1()
    {
        for (int i = 0; i <=10; i++)
        {
            Console.WriteLine($"thread1: {i}");
            // if (i == 5)
            // {
            //     Thread.Sleep(5000);
            // }
        }
    }
    public static void Action2()
    {
        for (int i = 0; i <=10; i++)
        {
            Console.WriteLine($"thread2: {i}");
        }
    }

    public static void MainAction()
    {
        var thread1 = new Thread(Action1);
        var thread2 = new Thread(Action2);
        thread1.Start();
        thread2.Start();
    }
}



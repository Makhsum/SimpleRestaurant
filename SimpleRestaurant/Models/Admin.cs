namespace SimpleRestaurant.Models;

public class Admin
{
    public Admin(){}
    

    private bool exit = false;
    public Admin(ref string[] menu,string name)
    {
        Console.WriteLine($"Добрый день {name} желаете что то изменить?");
        while (true)
        {
            if (exit)
            {
                return;
            }
            string? command = Console.ReadLine()?.ToLower();
            switch (command)
            {
            
                case null:
                case "": 
                    break;
                case"нет":
                    break;
                case "да":
                    Change(ref menu);
                    break;
                case "выход":
                    return;
                    
            }
        }
    }

    private  void Change(ref string[] menu) 
    {
        Console.WriteLine($"Список того что вы можете делать: 1)Удалить, 2)Добавить, 3)Изменить блюдо,\n 4)изменить места блюд в меню меню!");

        while (true)
        {
            string? cmd= Console.ReadLine().ToLower();
            switch (cmd)
            {
            
                case null:
                case "": 
                    break;
                case "выход":
                    exit = true;
                    return;
                case"1":
                    for (int i = 0; i < menu.Length; i++)
                    {
                        Console.WriteLine($"{menu[i]} - индекс = {i}");
                    }

                    Console.WriteLine("ыберите по индексу что хотите удалить");
                    int index = int.Parse(Console.ReadLine());
                    remove(ref menu,index);
                    Console.WriteLine($"Готово теперь меню состоит из {menu.Length} блюд");
                    break;
                case "2":
                    Console.WriteLine("Напишите что вы хотите добавить");
                    string? newfood = Console.ReadLine();
                    add(ref menu,newfood);
                    Console.WriteLine("Введите цену");
                    
                    Console.WriteLine($"Готово теперь меню состоит из {menu.Length} блюд");
                    break;
                case "3":
                    for (int i = 0; i < menu.Length; i++)
                    {
                        Console.WriteLine($"{menu[i]} - индекс = {i}");
                    }

                    Console.WriteLine("Выберите по индексу что хотите изменить");
                    int changevalueindex= int.Parse(Console.ReadLine());
                    Console.WriteLine("Напишите что вы хотите изменить");
                    string? chengevalue = Console.ReadLine();
                    change(ref menu,changevalueindex,chengevalue);
                    break;
                case "4":
                    for (int i = 0; i < menu.Length; i++)
                    {
                        Console.WriteLine($"{menu[i]} - индекс = {i}");
                    }

                    Console.WriteLine("Выберите по индексу что хотите изменить");
                    int changevalueofmenuindex1= int.Parse(Console.ReadLine());
                    Console.WriteLine("Выберите второй индекс");
                    int changevalueofmenuindex2= int.Parse(Console.ReadLine());
                    move(ref menu, changevalueofmenuindex1, changevalueofmenuindex2);
                    Console.WriteLine("Готово чтобы показать меню напишите \"показать\"");
                    break;
                case "показать":
                    foreach (var VARIABLE in menu)
                    {
                        Console.WriteLine(VARIABLE); 
                    }
                    break;
                default:
                    Console.WriteLine("только цифры 1 2 3 4");
                    break;
                
            }
        }
      
    }
    
    
    private  void add(ref string[] myarray,string value,int index = 0)
    {
        string[] array = new String[myarray.Length+1];
        array[index] = value;
        for (int i = 0; i < index; i++)
        {
            array[i] = myarray[i];
        }

        for (int i = index; i < myarray.Length; i++)
        {
            array[i+1] = myarray[i];
        }

        myarray = array;
    }
    private void remove(ref string[] myarray, int index)
    {
        string[] array = new string[myarray.Length - 1];
        for (int i = 0; i < index; i++)
        {
            array[i] = myarray[i];
        }

        for (int i = index+1; i < myarray.Length; i++)
        {
            array[i - 1] = myarray[i];
        }

        myarray = array;
    }
    private void move(ref string[] myarray, int index1, int index2)
    {
        string[] newArray = new string[myarray.Length];
        for (int i = 0; i < newArray.Length; i++)
        {
            newArray[i] = myarray[i];
        }
        newArray[index1] = myarray[index2];
        newArray[index2] = myarray[index1];
        myarray = newArray;
    }

    private void change(ref string[] myarray,int index, string value)
    {
        string[] newArray = new string[myarray.Length];
        newArray[index] = value;
        for (int i = 0; i < index; i++)
        {
            newArray[i] = myarray[i];
        }

        for (int i = index+1; i < myarray.Length; i++)
        {
            newArray[i] = myarray[i];
        }

        myarray = newArray;
        
    }
}
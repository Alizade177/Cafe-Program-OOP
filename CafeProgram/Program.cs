using System;

namespace CafeProgram
{
    public class Program
    {
        static void Main(string[] args)
        {

            Menu menu = new Menu();
            menu.MealList.Add(new Meal("yemek1",5.5,false));
            menu.MealList.Add(new Meal("yemek2",8.5,true));

            menu.DrinkList.Add(new Drink("icki1", 2.3, 2));
            menu.DrinkList.Add(new Drink("icki2", 1.3, 1));
            
            menu.StartService();
         
        }
    }
}
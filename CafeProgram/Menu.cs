using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeProgram
{
    public  class Menu
    {
       public Menu()
        {
            MealList = new List<Meal>();
            DrinkList = new List<Drink>();
        }
        public List<Meal> MealList { get; set; }
        public List<Drink> DrinkList { get; set; }
        public double Payment { get; set; } = 0;
        public void StartService() //istifadeci menyunu goerecek ve secimini edecek
        {
        
            while (true)
            {
                Console.WriteLine("1. Yemek \n2. Icki");
                Console.Write("Seciminizi edin:");
                string enter = Console.ReadLine();
                PrintMenu(enter);
                Console.Write("Seciminizi edin:");
                string menuEnter = Console.ReadLine();
                int foodIndex;
                if (int.TryParse(menuEnter, out foodIndex))
                {

                    if (enter == "1")
                        if ((foodIndex - 1) >= 0 && (foodIndex - 1) < this.MealList.Count && this.MealList.Count > 0)
                            this.Payment += this.MealList[foodIndex - 1].Price;
                        else
                            continue;
                    else if (enter == "2")
                        if ((foodIndex - 1) >= 0 && (foodIndex - 1) < this.DrinkList.Count && this.DrinkList.Count > 0)
                            this.Payment += this.DrinkList[foodIndex - 1].Price;
                        else
                            continue;
                }
                else
                {
                    Console.WriteLine("Duzgun deyer daxil edin!");
                    continue;
                }
                    
               Console.WriteLine("Sizin hazir ki tutariniz: " + this.Payment + "\n"); 
                Console.Write("Basqa nese isteyirsiniz? (Y/N) : ");
                enter = Console.ReadLine();
                if (enter.ToUpper() == "N")
                    break;
            }

            Console.WriteLine("Sizin tutariniz: " + this.Payment + "\nBizi secdiyiniz ucun tesekkurler!");
        }

        public void PrintMenu(string menuNumber)
        {
            switch (menuNumber)
            {
                case "1":
                    for(int i = 0; i < MealList.Count; i++)
                    {
                        Console.WriteLine($"{i+1}.{this.MealList[i].Name} - {this.MealList[i].Price}AZN");
                    }
                    break;
                case "2":
                    for(int i = 0; i < DrinkList.Count; i++)
                    {
                        Console.WriteLine($"{i+1}. {this.DrinkList[i].Name} - {this.DrinkList[i].Price}AZN");
                    }
                    break;
                default:
                    Console.WriteLine("Zehmet olmasa duzgun secim edin!");
                        break;
            }


        }


         
    }
}

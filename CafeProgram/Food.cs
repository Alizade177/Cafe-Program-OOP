using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeProgram
{
    public class Food
    {
        public Food(string name, double price)
        {
            this.Name = name;
            this.Price = price;
        }

        public string Name { get; set; }
        public double Price { get; set; }


    }
}

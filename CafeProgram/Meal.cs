using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeProgram
{
    public  class Meal : Food
    {
        public Meal(string name,double price,bool iscold ) : base(name,price)
        {
            this.isCold = iscold;
        }

        public bool isCold { get; set; }    
    }
}

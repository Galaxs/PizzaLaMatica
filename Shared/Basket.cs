using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaLaMatica.Shared
{
    // this will represent the basket of the shopping 
   public class Basket
    {

        public Customer Customer { get; set; } = new Customer();
        public List<int> Orders { get; set; } = new List<int>();
        public bool HasPaid { get; set; } = false;
        public void Add(int pizzaId)
        {
            Orders.Add(pizzaId);
        }
        public void RemoveAt(int pos)
        {
            Orders.RemoveAt(pos);
        }
        
    }
}

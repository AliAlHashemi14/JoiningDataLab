using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoiningDataLab
{
    internal class Order
    {
        public string CustomerName { get; set; }
        public string Item { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }

        public Order(string customerName, string item, decimal price, int quantity)
        {
            CustomerName = customerName;
            Item = item;
            Price = price;
            Quantity = quantity;
        }

        public override string ToString()
        {
            return string.Format("{0,-20} {1,-15} {2,-15} {3,-15}", $"{Item}", $"{Price}", $"{Quantity}", $"{Quantity * Price}");
        }
    }
}

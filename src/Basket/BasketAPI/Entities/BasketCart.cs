using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BasketAPI.Entities
{
    public class BasketCart
    {
        public String Username { get; set; }
        public List<BasketCartItem> Items { get; set; } = new List<BasketCartItem>();

        public BasketCart()
        {
        }

        public BasketCart(string username)
        {
            Username = username;
        }

        public decimal TotalPrice {
            get {
                decimal totalprice;
                foreach (var item in Items)
                {
                    totalprice = item.Price * item.Quantity;
                }
                return 0;
            } 
        }
    }
}

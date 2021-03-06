using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MbmStore.Models
{
    public class OrderItem 
    {

       
        public decimal TotalPrice => Product.Price * Quantity;

        public int OrderItemId { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; }
        public int Quantity { get; set; }
     

        public OrderItem( Product product, int quantity) {

            Quantity = quantity;
            Product = product;
        }

    }
}

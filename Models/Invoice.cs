using MbmStore.Infrastructure;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MbmStore.Models;





namespace MbmStore.Models
{
    public class Invoice 
    {

        private decimal totalPrice { get; set; }

     

        //readonly 
        public decimal TotalPrice
        {
            get
            {
                totalPrice = 0;
                foreach (OrderItem orderItem in Orderitems)
                {
                    totalPrice += orderItem.TotalPrice;
                }

                return totalPrice;

            }
        }



        public List<OrderItem> Orderitems { get; } = new List<OrderItem>();


        public Customer Customer { get; }

      


        public DateTime OrderDate { get; set; }

        public int InvoiceId { get; set; }


        //public int MyProperty { get; set; }


   


        public Invoice() { }


        public Invoice( int invoiceid, DateTime orderdate, Customer customer ) 
        {

           // totalprice = TotalPrice;
            Customer = customer;
            OrderDate = orderdate;
            InvoiceId = invoiceid;
          
        }

        ///method for adding an order item to invoice
        public void AddOrderItem(Product product, int quantity)
        {

            Orderitems.Add(new OrderItem(product, quantity));
        }


 


    }





}


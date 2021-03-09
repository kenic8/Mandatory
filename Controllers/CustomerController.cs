using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MbmStore.Infrastructure;
using MbmStore.Models;
using Microsoft.AspNetCore.Mvc;

namespace MbmStore.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {

            List<Customer> customers = Repository.Customers.ToList();

            ViewBag.Customers = customers;

            ///////Single 

            var costumerTry1 = new Customer("lars", "petersen 14", "ceresbyen", "8000", "aarhus", new DateTime(2000, 5, 1, 8, 30, 52),1);
            var costumerTry2 = new Customer("peter", "petersen 32", "ceresbyen", "8000", "aarhus", new DateTime(1900, 5, 1, 8, 30, 52),2);
            var costumerTry3 = new Customer("kurt", "kurtsen 15", "ceresbyen", "8000", "aarhus", new DateTime(1988, 5, 1, 8, 30, 52),3);

            /// viewbag 

            ViewBag.CostumerTry1 = costumerTry1;
            ViewBag.CostumerTry2 = costumerTry2;
            ViewBag.CostumerTry3 = costumerTry3;




            ////costumer list
            //List<Customer> CustomerList = new List<Customer>();

            //_ = new Customer();

            //Customer Lars = new Customer("lars", "petersen 14", "ceresbyen", "8000", "aarhus", new DateTime(2000, 5, 1, 8, 30, 52));

            //Customer Peter = new Customer("peter", "petersen 32", "ceresbyen", "8000", "aarhus", new DateTime(1900, 5, 1, 8, 30, 52));

            //Customer Kurt = new Customer("kurt", "kurtsen 15", "ceresbyen", "8000", "aarhus", new DateTime(1988, 5, 1, 8, 30, 52));


            ///numbersphone

            //Lars.AddPhone("21311231");
            //Lars.AddPhone("8928301890");
            //Lars.AddPhone("8698092");


            //Peter.AddPhone("21311231");
            //Peter.AddPhone("8928301890");

            //Kurt.AddPhone("21311231");





            //// add to list of costumers
            //CustomerList.Add(Lars);
            //CustomerList.Add(Peter);
            //CustomerList.Add(Kurt);

            ///// viewbag 
            ///// viewbag 

            //ViewBag.Customers = CustomerList;


            //foreach (var customer in CustomerList)
            //{
            //    Random randIterations = new Random();
            //    for (int i = 0; i < randIterations.Next(1, 3); i++)
            //    {
            //        Random randPhoneNumber = new Random();
            //        int PhoneNr = randPhoneNumber.Next(10000000, 99999999);
            //        string PhoneString = PhoneNr.ToString();
            //        customer.AddPhone(PhoneString);



            //    }
            //}

            
            //ViewBag.Customers = CustomerList;


            return View();
        }
    }
}






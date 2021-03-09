using MbmStore.Infrastructure;
using MbmStore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;







namespace MbmStore.Controllers
{
    public class CatalogueController : Controller
    {
      //  private List<Invoice> invoices;

        public IActionResult Index()
        {

            
          //  ViewBag.Products = Repository.Products;  cant sort on typeof return null
           // ViewBag.Invoices = Repository.InVoices;

            List<Invoice> Invoices = Repository.InVoices.ToList();

            List<Book> books = Repository.Books.ToList();

            List<MusicCD> musicCDs = Repository.MusicCDs.ToList();

            List<Movie> movies = Repository.Movies.ToList();

            ViewBag.Movies = movies;
            ViewBag.BookList = books;
            ViewBag.MusicCDList = musicCDs;
            ViewBag.InvoicesList = Invoices;
 

            ///list of invoices for sorting

            List<SelectListItem> customers = new List<SelectListItem>();

            foreach (Invoice Invoice in Repository.InVoices)
            {
                customers.Add(new SelectListItem { Text = Invoice.Customer.FirstName + " " + Invoice.Customer.LastName, Value = Invoice.Customer.CustomerId.ToString() });
                ///remove dubs
                ///
                customers = customers.GroupBy(x => x.Value).Select(y => y.First()).OrderBy(z => z.Text).ToList<SelectListItem>();

            }

          //  ViewBag.Customers = customers;
            return View();

            
        }


        //[HttpPost]
        //public IActionResult Index(int?Customer)
        //{
        //    List<Invoice> Invoices = Repository.InVoices.ToList();

        //    if (Customer != null)
        //    {
        //        // select invoices for a customer with linq
        //        Invoices = Repository.InVoices.Where(r => r.Customer.CustomerId == Customer).ToList(); 
        //    }

        //    ViewBag.Invoices = Invoices;


        //    return View();
        //}


    }

   


}


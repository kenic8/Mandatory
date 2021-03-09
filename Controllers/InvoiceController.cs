using MbmStore.Infrastructure;
using MbmStore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MbmStore.Controllers
{
    public class InvoiceController : Controller
    {
        public IActionResult Index()
        {


            //  ViewBag.Products = Repository.Products;  cant sort on typeof return null
            // ViewBag.Invoices = Repository.InVoices;

            List<Invoice> Invoices = Repository.InVoices.ToList();
       
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

            ViewBag.Customers = customers;
            return View();


        }


        [HttpPost]
        public IActionResult Index(int? Customer)
        {
            List<SelectListItem> customers = new List<SelectListItem>();
            List<Invoice> Invoices = Repository.InVoices.ToList();

            if (Customer != null)
            {
                // select invoices for a customer with linq
                Invoices = Repository.InVoices.Where(r => r.Customer.CustomerId == Customer).ToList();
            }

            ViewBag.InvoicesList = Invoices;


            // generate the dropdown list
            foreach(
             Invoice invoice in Repository.InVoices){ 
                
                SelectListItem selectListItem = new SelectListItem
             {
                 Text = invoice.Customer.FirstName + " " + invoice.Customer.LastName,
                 Value = invoice.Customer.CustomerId.ToString()};

                if (invoice.Customer.CustomerId == Customer) {
                  selectListItem.Selected = true;}

                customers.Add(selectListItem);
            }

            ViewBag.Customers = customers;
            return View("InvoiceSorted");
        }


    }
}


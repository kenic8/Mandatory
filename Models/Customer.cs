using System;
using System.Collections.Generic;


namespace MbmStore.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Zip { get; set; }
        public string City { get; set; }

        public List<string> PhoneNumber { get; } = new List<string>();

        public List<Invoice> InVoices = new List<Invoice>();

        public Invoice Invoice { get; }

        public DateTime BirthDate;
        public DateTime birthDate
        {
            set
            {
                DateTime now = DateTime.Now;
                if (value.Year < now.Year && (now.Year - value.Year) <= 120)
                {
                    BirthDate = value;
                }
                else
                {
                    throw new Exception("Age not accepted");
                }
            }
            get { return BirthDate; }
        }

        public int age
        {
            get
            {
                DateTime now = DateTime.Now;
                int age;
                age = now.Year - birthDate.Year;
                if (now.Month < birthDate.Month || (now.Month == birthDate.Month && now.Day < birthDate.Day))
                {
                    age--;
                }
                return age;
            }
        }

        public Customer() { }



        public Customer(string firstname, string lastname, string address, string zip, string city, DateTime birthdate, int id) 
        {
            FirstName = firstname;
            LastName = lastname;
            Address = address;
            City = city;
            Zip = zip;
            BirthDate = birthdate;
            CustomerId = id;

        }

        public void AddPhone(string phone)
        {

            PhoneNumber.Add(phone);


        }



        public void AddInvoice( Invoice invoice)
        {

            InVoices.Add(invoice);


        }

    }
}

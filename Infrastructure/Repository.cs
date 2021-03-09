using MbmStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MbmStore.Infrastructure
{
    public static class Repository
    {
        ///lists
        public static List<Product> Products = new List<Product>();

        public static List<Invoice> InVoices = new List<Invoice>();

        public static List<Customer> Customers = new List<Customer>();

        //becuase sort on products <type> returns null
        public static List<Book> Books = new List<Book>();
        public static List<MusicCD> MusicCDs = new List<MusicCD>();
        public static List<Movie> Movies = new List<Movie>();
        /// 

        public static DateTime Now { get; } = Now;


        static Repository()
        {

            //books
            Book book1 = new Book("Enrique West", "Handmade", 17, 1999, "Bookends", "812367189", "random1.jpg");
            Book book2 = new Book("Damien Braun", "Grunge", 15, 1992, "Page by Page", "812367189", "random2.jpg");
            Book book3 = new Book("Ellie Osborne", "Sound ", 12, 1994, "Book Barn", "812367189", "random3.jpg");

            ///Cds
            MusicCD musiccd1 = new MusicCD("John", "Beside Oneself With Joy Drive", 19, "Royal Wish", 1993, "Chigao's Vibes", "random4.jpg");
            MusicCD musiccd2 = new MusicCD("Kaia Peacock", "Discover Sky", 20, "First June", 1993, "Grunge Crash", "random5.jpg");
            MusicCD musiccd3 = new MusicCD("Alistair Needham", "Cocktails Gift", 22, "Is This", 1993, "In Chance", "random6.jpg");


            ///Movies
            ///
            Movie Movie1 = new Movie("Jungle Book", 160.50m, "junglebook.jpg", "Mavisatron");
            Movie Movie2 = new Movie("NiceMovie", 99.50m, "gladiator.jpg", "Tegan ");
            Movie Movie3 = new Movie("CoolMovie", 160.50m, "junglebook.jpg", "Tarpals");


            ////
            Products.Add(musiccd1);
            Products.Add(musiccd2);
            Products.Add(musiccd3);

            Products.Add(book1);
            Products.Add(book2);
            Products.Add(book3);


            Products.Add(Movie1);
            Products.Add(Movie2);
            Products.Add(Movie3);



            ////list sorted 
            Books.Add(book1);
            Books.Add(book2);
            Books.Add(book3);


            MusicCDs.Add(musiccd1);
            MusicCDs.Add(musiccd2);
            MusicCDs.Add(musiccd3);


            Movies.Add(Movie1);
            Movies.Add(Movie2);
            Movies.Add(Movie3);

            /////invoices 



            //// customers
            Customer Lars = new Customer("Lars", "Hansen", "ceresbyen", "8000", "aarhus", new DateTime(2000, 5, 1, 8, 30, 52),1);

            Customer Peter = new Customer("Peter", "Nielsen", "ceresbyen", "8000", "aarhus", new DateTime(1900, 5, 1, 8, 30, 52),2);

            Customer Kurt = new Customer("kurt", "Johnson", "ceresbyen", "8000", "aarhus", new DateTime(1988, 5, 1, 8, 30, 52),3);


            ////costumer phones
            ///
            Lars.AddPhone("21311231");
            Lars.AddPhone("8928301890");
            Lars.AddPhone("8698092");
            Peter.AddPhone("21311231");
            Peter.AddPhone("8928301890");
            Kurt.AddPhone("21311231");


            //// 
            Customers.Add(Lars);
            Customers.Add(Kurt);
            Customers.Add(Peter);


            //invoices instance of invoice class



            Invoice invoiceLars = new Invoice(1, Now, Lars);
            Invoice invoicePeter = new Invoice(2, Now, Peter);
            Invoice invoiceKurt = new Invoice(3, Now, Kurt);

            ///add to list of invoices

            InVoices.Add(invoiceLars);
            InVoices.Add(invoiceKurt);
            InVoices.Add(invoicePeter);



            /////call method on invoce with list of orders for the current object ex ( lars, peter) with their assosiated list
            ///

            ///invoice for lars  proucts of index in list products

            invoiceLars.AddOrderItem(Products[0], 1);
            invoiceLars.AddOrderItem(Products[1], 1);
            invoiceLars.AddOrderItem(Products[3], 1);
            invoiceLars.AddOrderItem(Products[7], 1);

            ///invoice for peter

            invoicePeter.AddOrderItem(Products[5], 1);
            invoicePeter.AddOrderItem(Products[4], 1);
            invoicePeter.AddOrderItem(Products[8], 1);


            ///invoice for Kurt

            invoiceKurt.AddOrderItem(Products[3], 1);
            invoiceKurt.AddOrderItem(Products[6], 1);
            invoiceKurt.AddOrderItem(Products[4], 1);









            ///Tracks logic 

            ///cd1
            MusicCD Musiccd1track1 = new MusicCD.Track("Delighted Story", "Christoph  Gluck ", new TimeSpan(0, 2, 33));
            MusicCD Musiccd1track2 = new MusicCD.Track("Enjoy Date", "Giovanni Paisiello", new TimeSpan(0, 1, 23));
            MusicCD Musiccd1track3 = new MusicCD.Track("Forget About", "André ErnestGrétry", new TimeSpan(0, 3, 0));
            MusicCD Musiccd1track4 = new MusicCD.Track("Untroubled By Fall", "Domenico Cima", new TimeSpan(0, 3, 10));
            MusicCD Musiccd1track5 = new MusicCD.Track("Still Need Groove", "Wolfgang  Mozart", new TimeSpan(0, 1, 10));
            MusicCD Musiccd1track6 = new MusicCD.Track("Fake Chance", "Luigi Cherubini ", new TimeSpan(0, 2, 10));

            //cd2

            MusicCD Musiccd2track1 = new MusicCD.Track("Home Of Lines", "Gioachino Rossini ", new TimeSpan(0, 3, 10));
            MusicCD Musiccd2track2 = new MusicCD.Track("Back To Limit", "Gaetano Donizetti ", new TimeSpan(0, 2, 10));
            MusicCD Musiccd2track3 = new MusicCD.Track("Fake Chance", "Jacques Fromental ", new TimeSpan(0, 4, 10));
            MusicCD Musiccd2track4 = new MusicCD.Track("Fresh Loung", "Vincenzo Bellini ", new TimeSpan(0, 7, 10));



            //Cd3


            MusicCD Musiccd3track1 = new MusicCD.Track("Far Off Anthem", "Mikhail Glinka ", new TimeSpan(0, 7, 10));
            MusicCD Musiccd3track2 = new MusicCD.Track("Come Of Lines", "Richard Wagner", new TimeSpan(0, 3, 10));
            MusicCD Musiccd3track3 = new MusicCD.Track("sunday Hour", "Jacques Offenbach ", new TimeSpan(0, 2, 10));



            //tracks list
            List<MusicCD.Track> TrackList1 = new List<MusicCD.Track>();
            List<MusicCD.Track> TrackList2 = new List<MusicCD.Track>();
            List<MusicCD.Track> TrackList3 = new List<MusicCD.Track>();



            ///call tracklist add to list  with ojbects for tracks
           //track list cd 1
            TrackList1.Add((MusicCD.Track)Musiccd1track1);
            TrackList1.Add((MusicCD.Track)Musiccd1track2);
            TrackList1.Add((MusicCD.Track)Musiccd1track3);
            TrackList1.Add((MusicCD.Track)Musiccd1track4);
            TrackList1.Add((MusicCD.Track)Musiccd1track5);
            TrackList1.Add((MusicCD.Track)Musiccd1track6);


            //track list cd 2
            TrackList2.Add((MusicCD.Track)Musiccd2track1);
            TrackList2.Add((MusicCD.Track)Musiccd2track2);
            TrackList2.Add((MusicCD.Track)Musiccd2track3);
            TrackList2.Add((MusicCD.Track)Musiccd2track4);



            //track list cd 3

            TrackList3.Add((MusicCD.Track)Musiccd3track1);
            TrackList3.Add((MusicCD.Track)Musiccd3track2);
            TrackList3.Add((MusicCD.Track)Musiccd3track3);




            //define which cd and tracklist use method to add to object with list as param
            musiccd1.Addtrack(TrackList1);
            musiccd2.Addtrack(TrackList2);
            musiccd3.Addtrack(TrackList3);


            /////totals times 
            musiccd1.GetPlayingTime(TrackList1);
            musiccd2.GetPlayingTime(TrackList2);
            musiccd3.GetPlayingTime(TrackList3);




            /////list for objects  old version

            //List<Book> books = new List<Book>();

            //List<MusicCD> musicCDs = new List<MusicCD>();

            ////List<track> Tracks = new List<track>();


            ////add objects to list

            //books.Add(book1);

            //books.Add(book2);

            //books.Add(book3);
            ////
            //musicCDs.Add(musiccd1);
            //musicCDs.Add(musiccd2);
            //musicCDs.Add(musiccd3);


           

        }

    }
}

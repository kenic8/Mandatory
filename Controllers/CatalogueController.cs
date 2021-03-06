using MbmStore.Infrastructure;
using MbmStore.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;







namespace MbmStore.Controllers
{
    public class CatalogueController : Controller
    {

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








            //instances of objectclass
            //_ = new Product();
            //_ = new Book();
            //_ = new MusicCD();

            // if var t = new MusicCD(); as an instance


            //Create object of class

            //books 
            //Book book1 = new Book("Enrique West", "Handmade", 17, 1999,"Bookends","812367189", "random1.jpg");
            //Book book2 = new Book("Damien Braun", "Grunge", 15, 1992, "Page by Page", "812367189", "random2.jpg");
            //Book book3 = new Book("Ellie Osborne", "Sound ", 12, 1994, "Book Barn", "812367189", "random3.jpg");

            /////Cds
            //MusicCD musiccd1 = new MusicCD("John", "Beside Oneself With Joy Drive", 19, "Royal Wish", 1993, "Chigao's Vibes", "random4.jpg");
            //MusicCD musiccd2 = new MusicCD("Kaia Peacock", "Discover Sky", 20, "First June", 1993, "Grunge Crash", "random5.jpg");
            //MusicCD musiccd3 = new MusicCD("Alistair Needham", "Cocktails Gift", 22, "Is This", 1993, "In Chance", "random6.jpg");


            /////Tracks
            /////cd1
            //MusicCD Musiccd1track1 = new MusicCD.Track("Delighted Story", "Christoph  Gluck ", new TimeSpan(0,2,33));
            //MusicCD Musiccd1track2 = new MusicCD.Track("Enjoy Date", "Giovanni Paisiello", new TimeSpan(0,1,23));
            //MusicCD Musiccd1track3 = new MusicCD.Track("Forget About", "André ErnestGrétry", new TimeSpan(0,3,0));
            //MusicCD Musiccd1track4 = new MusicCD.Track("Untroubled By Fall", "Domenico Cimarosa", new TimeSpan(0,3,10));
            //MusicCD Musiccd1track5 = new MusicCD.Track("Still Need Groove", "Wolfgang  Mozart", new TimeSpan(0, 1, 10));
            //MusicCD Musiccd1track6 = new MusicCD.Track("Fake Chance", "Luigi Cherubini ", new TimeSpan(0, 2, 10));

            ////cd2

            //MusicCD Musiccd2track1 = new MusicCD.Track("Home Of Lines", "Gioachino Rossini ", new TimeSpan(0, 3, 10));
            //MusicCD Musiccd2track2 = new MusicCD.Track("Back To Limit", "Gaetano Donizetti ", new TimeSpan(0, 2, 10));
            //MusicCD Musiccd2track3 = new MusicCD.Track("Fake Chance", "Jacques Fromental ", new TimeSpan(0, 4, 10));
            //MusicCD Musiccd2track4 = new MusicCD.Track("Fresh Loung", "Vincenzo Bellini ", new TimeSpan(0, 7, 10));



            ////Cd3


            //MusicCD Musiccd3track1 = new MusicCD.Track("Far Off Anthem", "Mikhail Glinka ", new TimeSpan(0, 7, 10));
            //MusicCD Musiccd3track2 = new MusicCD.Track("Come Of Lines", "Richard Wagner", new TimeSpan(0, 3, 10));
            //MusicCD Musiccd3track3 = new MusicCD.Track("sunday Hour", "Jacques Offenbach ", new TimeSpan(0, 2, 10));



            //Product product1 = new Product("Book", 22);
            //////list of tracks
            /// if t as instance of method
            //Single string version
            //musiccd1.Addtrack("Delighted Story");
            //musiccd1.Addtrack("Enjoy Date");
            //musiccd1.Addtrack("Forget About Your Shades");
            //musiccd1.Addtrack("Untroubled By Fall");
            //musiccd1.Addtrack("Back To Limit");
            //musiccd1.Addtrack("Heroic Wonders");
            //musiccd2.Addtrack("Still Need Groove");
            //musiccd2.Addtrack("Inventions Of Anthem");
            //musiccd2.Addtrack("Home Of Lines");
            //musiccd2.Addtrack("Fake Chance");
            //musiccd2.Addtrack("Just Relax Call");
            //musiccd2.Addtrack("New Birthday");
            //musiccd2.Addtrack("The Time Has Come Again For February");
            //musiccd3.Addtrack("Sunday Hour");
            //musiccd3.Addtrack("Break Chill");
            //musiccd3.Addtrack("Far Off Anthem");
            //musiccd3.Addtrack("Fresh Lounge");
            //musiccd3.Addtrack("The Celebrated Touch");
            //musiccd3.Addtrack("Bouncy Memories");
            //musiccd3.Addtrack("Calm Whoop");



            // //tracks list
            // List<MusicCD.Track> TrackList1 = new List<MusicCD.Track>();
            // List<MusicCD.Track> TrackList2 = new List<MusicCD.Track>();
            // List<MusicCD.Track> TrackList3 = new List<MusicCD.Track>();



            // ///call tracklist add to list  with ojbects for tracks
            ////track list cd 1
            // TrackList1.Add((MusicCD.Track)Musiccd1track1);
            // TrackList1.Add((MusicCD.Track)Musiccd1track2);
            // TrackList1.Add((MusicCD.Track)Musiccd1track3);
            // TrackList1.Add((MusicCD.Track)Musiccd1track4);
            // TrackList1.Add((MusicCD.Track)Musiccd1track5);
            // TrackList1.Add((MusicCD.Track)Musiccd1track6);


            // //track list cd 2
            // TrackList2.Add((MusicCD.Track)Musiccd2track1);
            // TrackList2.Add((MusicCD.Track)Musiccd2track2);
            // TrackList2.Add((MusicCD.Track)Musiccd2track3);
            // TrackList2.Add((MusicCD.Track)Musiccd2track4);



            // //track list cd 3

            // TrackList3.Add((MusicCD.Track)Musiccd3track1);
            // TrackList3.Add((MusicCD.Track)Musiccd3track2);
            // TrackList3.Add((MusicCD.Track)Musiccd3track3);




            // //define which cd and tracklist use method to add to object with list as param
            // musiccd1.Addtrack(TrackList1);
            // musiccd2.Addtrack(TrackList2);
            // musiccd3.Addtrack(TrackList3);


            // /////totals times 
            // musiccd1.GetPlayingTime(TrackList1);
            // musiccd2.GetPlayingTime(TrackList2);
            // musiccd3.GetPlayingTime(TrackList3);





            // ///list for objects

            // List<Book> books = new List<Book>();

            // List<MusicCD> musicCDs = new List<MusicCD>();

            // //List<track> Tracks = new List<track>();


            // //add objects to list

            // books.Add(book1);

            // books.Add(book2);

            // books.Add(book3);           
            // //
            // musicCDs.Add(musiccd1);
            // musicCDs.Add(musiccd2);
            // musicCDs.Add(musiccd3);

            // /////viewbags
            // //single
            // ViewBag.MusicCd = musiccd1;
            // ViewBag.Book = book1;

            /////list
            //ViewBag.BookList = books;
            //ViewBag.MusicCDList = musicCDs;
            return View();
        }
    }
}


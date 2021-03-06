using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MbmStore.Models
{
    public class Product
    {
        public string Title { get; set; }
        public decimal Price { get; set; }



        public string ImageFileName { get; set; }


        public Product()
        {

        }

        public Product(string title, decimal price, string imageFileName)
        {
            Title = title;
            Price = price;
            ImageFileName = imageFileName;


        }
    }

    public class Book : Product
    {
        public string Author { get; set; }

        public string Publisher { get; set; }

        public short Published { get; set; }

        public string ISBN { get; set; }

        public Book() { }

        public Book(string author, string title, decimal price, short published, string publisher, string isbn, string imageFileName) : base(title, price, imageFileName) ///from super classs
        {
            Author = author;
            Published = published;
            Publisher = publisher;
            ISBN = isbn;
            //_ = title;
            //_ = price;


        }
    }

    public class MusicCD : Product
    {

        //for ccds
        public string Artist { get; set; }
        public string Label { get; set; }

        public string Album { get; set; }
        public short Released { get; set; }





        ///Total for CD
        public TimeSpan Total { get; set; } = new TimeSpan(Minutes, Seconds, Hours);
        public string Composer { get; set; }




        ///list readonly
        public List<Track> Tracks { get; } = new List<Track>();
        public static int Minutes { get; private set; }
        public static int Seconds { get; private set; }
        public static int Hours { get; private set; }


        public MusicCD() { }

        public MusicCD(string artist, string title, decimal price, string label, short released, string album, string imageFileName) : base(title, price, imageFileName)
        {

            Label = label;
            Released = released;
            Artist = artist;
            Album = album;
            //_ = title;
            //_ = price;

        }


        public TimeSpan GetPlayingTime(List<Track> Track)
        {


            foreach (var tracktime in Track)
            {
                Total = Total.Add(tracktime.Length);



            }
            ///retrun new instace of TimeSpan object
            return Total;

        }


        ///method for adding to list of tracks
        public void Addtrack(List<Track> Track)
        {

            Tracks.AddRange(Track);
        }



        public class Track : MusicCD
        {
            ///for tracks  ///for tracks
            public TimeSpan Length { get; set; } = new TimeSpan(Minutes, Seconds, Hours);

            public Track(string title, string composer, TimeSpan length)
            {

                Title = title;
                Length = length;
                Composer = composer;
                // Minutes = minutes;
                //Seconds = seconds;

            }

        }

    }


    public class Movie : Product
    {
        //private static readonly decimal price;

        //// fields
        //private decimal price;
        //// private string imageFileName;

        //// properties
        //public string Title { get; }

        public string Director { get; set; }

        //public string ImageFileName { get; set; }
        ////{
        ////    set { imageFileName = value; }
        ////    get { return imageFileName; }
        ////}

        private new decimal Price
        {
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Price is not accepted");
                }
                else
                {
                    Price = Price;
                }
            }
            get { return Price; }
        }


        // constructors
        public Movie() { }

        //public Movie(string title, decimal price)
        //{
        //    Title = title;
        //    this.price = price;

        //}

        public Movie(string title, decimal price, string imageFileName, string director): base(title, price, imageFileName) 
        {
            Director = director;
         

        }
     }
 }













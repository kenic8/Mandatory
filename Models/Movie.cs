using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MbmStore.Models
{
    public class Movie
    {
        // fields
        private decimal price;
       // private string imageFileName;

        // properties
        public string Title { get;}
        public string Director { get; set; }

        public string ImageFileName { get; set; }
        //{
        //    set { imageFileName = value; }
        //    get { return imageFileName; }
        //}

        public decimal Price
        {
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Price is not accepted");
                }
                else
                {
                    price = value;
                }
            }
            get { return price; }
        }


        // constructors
        public Movie() { }

        public Movie(string title, decimal price)
        {
            Title = title;
            this.price = price;
          
        }

        public Movie(string title, decimal price, string imageFileName, string director)
        {
            Title = title;
            this.price = price;
            ImageFileName = imageFileName;
            Director = director;
        }
    }
}




//Make the following modifications of the code:
//1.Open the Controllers/MovieController.cs file and create two new instances of the Movie
//class with holds information about movies of your own choice.
//2. Open Views/Movie/Index.cshtml and update the View to display the new movies.
//3.Open the Models/Movie.cs class file and change the Title property to be a read-only property
//for public access.
//4.Add a property of type string and with the name Director.
//5. Add director as a new parameter to the second constructor.
//6. When you now select Debug -> Build the website has a compile error, why?
//Backend Programming. Exercises, Spring 2021
//2
//7. Correct this error by calling the constructor inside the controller with an extra argument.
//8. Modify the view to display all data of the new instances of Movie.
//9.Run the application and check that the new information is displayed correctly.
//10.As the final step, you must change the ImageFileName property to an auto-implemented
//property
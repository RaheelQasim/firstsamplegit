using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies
{
    class Movie
    {
        int ID;
        string Name;
        int Duration;

        public int ID1 { get => ID; set => ID = value; }
        public string Name1 { get => Name; set => Name = value; }
        public int Duration1 { get => Duration; set => Duration = value; }

        public void printdetails()
        {
            Console.WriteLine("The ID of the movie is {0}",ID1);
            Console.WriteLine("The name of the movie is {0}",Name1);
            Console.WriteLine("The duration of the movie is {0}",Duration1);
            Console.ReadKey();
        }
    }
}

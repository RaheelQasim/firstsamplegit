using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies
{
    class Program
    {
        static void Main(string[] args)
        {
            moviemanager mm = new moviemanager();
            mm.create();
            mm.printmoviedetails();
            Console.ReadKey();
        }
    }
}

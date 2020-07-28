using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies
{
    class moviemanager
    {
        Movie m1;

        public void create()
        {
            m1 = new Movie();
            m1.ID1 = 1002;
            m1.Name1 = "Batman";
            m1.Duration1 = 100;
        }

        public void printmoviedetails()
        {
            m1.printdetails();
            Console.ReadKey();
        }
    }
}

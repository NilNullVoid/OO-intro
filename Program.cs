using System;
using cars;

namespace oo_proj
{

    class Program
    {
        static void Main(string[] args)
        {
            driver b = new driver("Bob Brown", "4876453214");
            Car a = new Car("Holden", "Commodore", "ABC123", 600, b);
            Console.WriteLine(a.getDetails());
            Console.WriteLine(a.getRange());
            a.travel(50);
            Console.WriteLine(a.getRange());
        }
    }
}

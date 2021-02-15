using SuperHeroe001.Model;
using System;

namespace SuperHeroe001
{
    class Program
    {
        static void Main(string[] args)
        {



            Batman batman = new Batman("Batman", "Dark Stuff");
            Wolverine wolverine = new Wolverine("wolverine", "regenerative power");
            Superman superman = new Superman("superman", "fly");
            Spiderman spiderman = new Spiderman("Spiderman", "throw spider web");

         
            //Encapsulation .....
            Console.WriteLine(wolverine.ToString());
            Console.WriteLine(superman);
            Console.WriteLine(spiderman);
            Console.WriteLine(batman);

        }
    }
}

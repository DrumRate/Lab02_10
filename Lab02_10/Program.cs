using System;

namespace Lab02_10
{
    class Program
    {

        public static void Main(string[] Ships)
        {
            Ship ship1 = new Boat("Titanic", 20.0d, "Cruiser", null);
            Boat ship2 = new Boat("Pobeda", 40.0d, "Liner", null);
            Console.WriteLine(ship1);
            ship1.Move(1, 2);
            Console.WriteLine(ship2);
            ship2.Move(45,26);
            Console.ReadKey();
        }
    }
}

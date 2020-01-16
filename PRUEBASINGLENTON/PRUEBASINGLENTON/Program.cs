using System;

namespace PRUEBASINGLENTON
{
    class Program
    {
        static void Main(string[] args)
        {
            // como se puede observar evitamos estar instanciando varias veces :
            Console.WriteLine(PatronSingleton.Vaso.Agua);

            PatronSingleton.Vaso.Agua = "agua de coco";
            Console.WriteLine(PatronSingleton.Vaso.Agua);

            PatronSingleton.Vaso.Agua = "agua de coco";
            Console.WriteLine(PatronSingleton.Vaso.Agua);

            Console.ReadKey();
        }
    }
}

using System.Collections;

namespace IteratorAndCompositeExercise
{
   
    internal class Program
    {
        static void Main(string[] args)
        {
            DinerMenu dinerMenu = new DinerMenu();
            PancakeHouseMenu pancakeHouseMenu = new PancakeHouseMenu();

            Waitress waitress = new Waitress(dinerMenu, pancakeHouseMenu);

            Console.WriteLine("Welcome to the diner!");
            waitress.printMenu();
        }
    }
}
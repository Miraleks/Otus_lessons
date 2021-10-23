using System;

namespace HomeWork_07_02
{
    class Program
    {
        static void Main(string[] args)
        {
            CatalogOfPlanets catalog = new CatalogOfPlanets();

            (int, int, string) tryPlanet = catalog.GetAPlanet("Земля");
            ResultPrint(tryPlanet, "Земля");
            
            tryPlanet = catalog.GetAPlanet("Лимония");
            ResultPrint(tryPlanet, "Лимония");

            tryPlanet = catalog.GetAPlanet("Марс");
            ResultPrint(tryPlanet, "Марс");

        }

        static public void ResultPrint((int, int, string) result, string name)
        {
            //выводить их название, порядковый номер и длину экватора.
            //Item1 - place
            //Item2 - equator
            //Item3 - error message

            if (result.Item3 != null)
            {
                Console.WriteLine(result.Item3);
            }
            else
            {
                Console.WriteLine($"name: {name}, place from Sun: {result.Item1}, lenght of equator: {result.Item2} ");
            }

        }
    }

  
}

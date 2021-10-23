using System;

namespace HomeWork_07_02
{
    class Program
    {
        static void Main(string[] args)
        {
            CatalogOfPlanets catalog = new CatalogOfPlanets();
            int counterOfOpens = 0;
            CatalogOfPlanets.PlanetValidator lambda1 = (arg1) => 
            {
                counterOfOpens += 1;
                string message = null;
                if (counterOfOpens == 3)
                {
                    message = "Вы спрашиваете слишком часто";
                }
                return message;
            };

            CatalogOfPlanets.PlanetValidator lambda2 = (arg1) =>
            {
                if (arg1 == "Лимония")
                {
                    return "Это запретная планета";
                }

                return null;
            };

            (int, int, string) tryPlanet = catalog.GetAPlanet("Земля", lambda1);
            ResultPrint(tryPlanet, "Земля");
            
            tryPlanet = catalog.GetAPlanet("Лимония", lambda1);
            ResultPrint(tryPlanet, "Лимония");

            tryPlanet = catalog.GetAPlanet("Марс", lambda1);
            ResultPrint(tryPlanet, "Марс");

            Console.WriteLine("----- * -----");

            tryPlanet = catalog.GetAPlanet("Земля", lambda2);
            ResultPrint(tryPlanet, "Земля");

            tryPlanet = catalog.GetAPlanet("Лимония", lambda2);
            ResultPrint(tryPlanet, "Лимония");

            tryPlanet = catalog.GetAPlanet("Марс", lambda2);
            ResultPrint(tryPlanet, "Марс");

        }

        static public void ResultPrint((int, int, string) result, string name)
        {

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

using System;
using System.Collections.Generic;

/*
        Венера (вторая, 38006 км, none)
        Земля (третья, 40010 км, Венера)
        Марс (четвертая, 21286 км, Земля)
        Венера (снова)
*/

namespace HomeWork_07_02
{
    class CatalogOfPlanets
    {
        public delegate string PlanetValidator(string name);

        static Planet venera = new Planet("Венера", 2, 38006, null);
        static Planet earth = new Planet("Земля", 3, 40010, venera);
        static Planet mars = new Planet("Марс", 4, 21286, earth);

        public List<Planet> planets = new List<Planet>() {venera, earth, mars };       
            

        
        /// <summary>
        /// Метод на вход принимает название планеты, а на выходе дает порядковый номер планеты от Солнца 
        /// и длину ее экватора
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public (int place, int equator, string message) GetAPlanet(string name, PlanetValidator planet)
        {
            string message = null;
            message = planet(name);
            if (message == null)
            {
                foreach (Planet item in planets)
                {
                    if (name == item.name)
                    {
                        return (place: item.placeFromSun, equator: item.equatorLenght, message: message);
                    }
                }
                message = "Не удалось найти планету";
            }

            return (place: 0, equator: 0, message: message);
          
        }

    }


}

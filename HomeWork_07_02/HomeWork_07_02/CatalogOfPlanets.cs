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

        static Planet venera = new Planet("Венера", 2, 38006, null);
        static Planet earth = new Planet("Земля", 3, 40010, venera);
        static Planet mars = new Planet("Марс", 4, 21286, earth);

        public List<Planet> planets = new List<Planet>() {venera, earth, mars };       
            

        int counterOfOpens = 0;
        /// <summary>
        /// Метод на вход принимает название планеты, а на выходе дает порядковый номер планеты от Солнца 
        /// и длину ее экватора
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public (int place, int equator, string message) GetAPlanet(string name)
        {
            counterOfOpens += 1;
            string message = null;
            if (counterOfOpens == 3)
            {
                message = "Вы спрашиваете слишком часто";
            }
            foreach (Planet item in planets)
            {               
                if (name == item.name)
                {
                    return (item.placeFromSun, item.equatorLenght, message);
                }
            }

            return (place: 0, equator: 0, message: "Не удалось найти планету");

        }


    }
}

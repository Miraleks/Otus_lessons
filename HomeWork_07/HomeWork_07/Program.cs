using System;

namespace HomeWork_07_01
{
    /*Создать четыре объекта анонимного типа для описания планет Солнечной системы со свойствами:
     * "Название", 
     * "Порядковый номер от Солнца", 
     * "Длина экватора", 
     * "Предыдущая планета" (ссылка на объект - предыдущую планету):
        Венера (вторая, 38006 км, none)
        Земля (третья, 40010 км, Венера)
        Марс (четвертая, 21286 км, Земля)
        Венера (снова)
     
     */
    class Program
    {
        static void Main(string[] args)
        {
            var planet_01 = new
            {
                planetName = "Venera",
                placeNumber = 2,
                planetEquator = 38006,   
                previousPlanet = (object) null,
            };

            var planet_02 = new
            {
                planetName = "Earth",
                placeNumber = 3,
                planetEquator = 40010,
                previousPlanet = planet_01,
            };
            var planet_03 = new
            {
                planetName = "Mars",
                placeNumber = 4,
                planetEquator = 21286,
                previousPlanet = planet_02,
            };
            var planet_04 = new
            {
                planetName = "Venera",
                placeNumber = 2,
                planetEquator = 38006,
                previousPlanet = (object)null,
            };

            Console.WriteLine("First planet: "+ planet_01);
            Console.WriteLine("First planet: "+ planet_02);
            Console.WriteLine("Планета эквивалентна Венере? " + planet_01.Equals(planet_02));
            Console.WriteLine("First planet: "+ planet_03);
            Console.WriteLine("Планета эквивалентна Венере? " + planet_01.Equals(planet_03));
            Console.WriteLine("First planet: " + planet_04);
            Console.WriteLine("Планета эквивалентна Венере? " + planet_01.Equals(planet_04));


        }
    }
}

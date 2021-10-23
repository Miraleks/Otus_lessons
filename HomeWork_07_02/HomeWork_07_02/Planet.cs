using System;


namespace HomeWork_07_02
{
    class Planet
    {
        public string name { get; set; }
        public int placeFromSun { get; set; }
        public int equatorLenght { get; set; }
        public Planet previousPlanet { get; set; }


        public Planet(string name, int placeFromSun, int equatorLenght, Planet previousPlanet)
        {
            this.name = name;
            this.placeFromSun = placeFromSun;
            this.equatorLenght = equatorLenght;
            this.previousPlanet = previousPlanet;
        }
    }
}

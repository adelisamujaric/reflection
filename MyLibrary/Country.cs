using System;

namespace MyLibrary
{
    public class Country
    {
        public string Name { get; set; }
        public int Population { get; set; }

        public Country(string name, int population)
        {
            Name = name;
            Population = population;
        }

        public string GetCountryInfo()
        {
            return "Country " + Name + " has population of " + Population + ".";
        }
    }
}
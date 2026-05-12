using PopulationReportingSystem.Models;
using System.Collections.Generic;

namespace PopulationReportingSystem.Services
{
    public class CountryService
    {
        public List<Country> GetCountries()
        {
            List<Country> countries = new List<Country>();

            countries.Add(new Country
            {
                Name = "Pakistan",
                Capital = "Islamabad",
                Population = 240000000,
                Region = "Asia"
            });

            countries.Add(new Country
            {
                Name = "United Kingdom",
                Capital = "London",
                Population = 67000000,
                Region = "Europe"
            });

            countries.Add(new Country
            {
                Name = "Canada",
                Capital = "Ottawa",
                Population = 39000000,
                Region = "North America"
            });

            return countries;
        }
    }
}
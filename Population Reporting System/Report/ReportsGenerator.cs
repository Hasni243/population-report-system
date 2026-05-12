using PopulationReportingSystem.Models;
using System;
using System.Collections.Generic;

namespace PopulationReportingSystem.Reports
{
    public class ReportGenerator
    {
        public void DisplayReport(List<Country> countries)
        {
            Console.WriteLine("COUNTRY REPORT");
            Console.WriteLine("-------------------------");

            foreach (Country country in countries)
            {
                Console.WriteLine("Name: " + country.Name);
                Console.WriteLine("Capital: " + country.Capital);
                Console.WriteLine("Population: " + country.Population);
                Console.WriteLine("Region: " + country.Region);
                Console.WriteLine("-------------------------");
            }
        }
    }
}
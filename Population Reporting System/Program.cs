using PopulationReportingSystem.Services;
using PopulationReportingSystem.Reports;

CountryService service = new CountryService();

var countries = service.GetCountries();

ReportGenerator report = new ReportGenerator();

report.DisplayReport(countries);

Console.ReadLine();
// See https://aka.ms/new-console-template for more information
using StrategyPatterApp.Strategy;

Console.WriteLine("Hello, World!");

ReportFormat rf = new ReportFormat(new CsvReportFormat());

rf.GenerateReport();

rf = new ReportFormat(new JsonReportFormat());
rf.GenerateReport();

Console.ReadKey();
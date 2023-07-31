namespace StrategyPatterApp.Strategy;

public class CsvReportFormat : IReportFormat
{
    public void GenerateReport()
    {
        System.Console.WriteLine("CsvReportFormat");
    }
}
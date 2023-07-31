namespace StrategyPatterApp.Strategy;

public class JsonReportFormat : IReportFormat
{
    public void GenerateReport()
    {
        System.Console.WriteLine("JsonReportFormat");
    }
}
namespace StrategyPatterApp.Strategy;

public class ReportFormat 
{
    private readonly IReportFormat _reportFormat;
    public ReportFormat(IReportFormat reportFormat)
    {
        _reportFormat = reportFormat;
    }

    public void GenerateReport()
    {
        _reportFormat.GenerateReport();
    }

}
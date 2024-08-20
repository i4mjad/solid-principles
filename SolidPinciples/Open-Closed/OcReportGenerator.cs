namespace SolidPinciples.Open_Closed;




public interface IReportGenerator
{
    string GenerateReport();
}

public class PdfReportGenerator : IReportGenerator
{
    public string GenerateReport()
    {
        return "Generating PDF report...";
    }
}

public class CsvReportGenerator : IReportGenerator
{
    public string GenerateReport()
    {
        return "Generating CSV report...";
    }
}

public class OcReportGenerator(IReportGenerator reportGenerator)
{
    public string GenerateReport()
    {
        return reportGenerator.GenerateReport();
    }
}

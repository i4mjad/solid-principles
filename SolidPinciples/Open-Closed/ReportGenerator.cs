namespace SolidPinciples.Open_Closed;

public class ReportGenerator
{
    public string GenerateReport(string reportType)
    {
        if (reportType == "PDF")
        {
            return "Generating PDF report...";
        }
        else if (reportType == "CSV")
        {
            return "Generating CSV report...";
        }

        return "Invalid report type.";
    }
}
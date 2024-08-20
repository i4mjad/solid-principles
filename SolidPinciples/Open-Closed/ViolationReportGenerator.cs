namespace SolidPinciples.Open_Closed;

public class ViolationReportGenerator
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
        else if (reportType == "XML") // New report type added
        {
            return "Generating XML report...";
        }

        return "Invalid report type.";
    }
}
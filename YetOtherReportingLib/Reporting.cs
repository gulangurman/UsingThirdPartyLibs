using System;

namespace YetOtherReportingLib
{
    public class Reporting
    {
        public CustomReport CreateNewReport(string data)
        {
            return new CustomReport()
            {
                ReportSummary = $"Length is: {data.Length}.\n",
                DateCreated = DateTime.Now
            };
        }
    }
}

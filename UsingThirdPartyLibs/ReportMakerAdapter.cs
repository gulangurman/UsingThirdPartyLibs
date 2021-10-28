using ReportingLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YetOtherReportingLib;

namespace UsingThirdPartyLibs
{
    public class ReportMakerAdapter : IReportMaker
    {
        public ReportMakerAdapter()
        {

        }

        //Change this method only to use another reporting lib
        public Report Create(string data)
        {
            //var maker = new ReportMaker();
            //string intermediateReport = maker.CreateReport(data);
            var maker = new Reporting();
            var returnedReport = maker.CreateNewReport(data); //return type can be anything. no problem for adapter
            string intermediateReport = $"{returnedReport.ReportSummary}\n Date: {returnedReport.DateCreated}";
            return new Report() { Content = intermediateReport };
        }
    }
}

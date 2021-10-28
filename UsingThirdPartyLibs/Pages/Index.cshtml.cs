using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UsingThirdPartyLibs.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        //private readonly IReportMaker _reportMaker;

        public IndexModel(ILogger<IndexModel> logger /* , IReportMaker reportMaker */)
        {
            _logger = logger;
            //_reportMaker = reportMaker;
        }

        public void OnGet()
        {

        }

        public void OnPost([FromServices] IReportMaker reportMaker)
        {
            //Create a report using a 3rd party library
            //Using only abstract types
            IReport report = reportMaker.Create(Request.HttpContext.Session.Id);
            TempData["report"] = report;
        }
    }
}

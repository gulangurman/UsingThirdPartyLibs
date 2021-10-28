using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportingLib
{
    public class ReportMaker
    {
        public string CreateReport(string data)
        {
            return $"REPORT: Data length: {data.Length}";
        }
    }
}

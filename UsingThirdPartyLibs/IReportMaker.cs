using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UsingThirdPartyLibs
{
    public interface IReportMaker
    {
        Report Create(string data);
    }
}

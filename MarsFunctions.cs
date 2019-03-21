using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ExcelDna.Integration;
using System.Threading;

namespace MarsExcel
{
    public static class MarsFunctions
    {
        [ExcelFunction(Description="Get the real-time value of the spot", HelpTopic="Need help?", Category="Mars")]
        public static object GetSpot([ExcelArgument("ISIN code")] string isin)
        {
            ExcelDna.Logging.LogDisplay.WriteLine("Function :{0} {1}", typeof(MarsRtdServer).FullName, isin);
            return XlCall.RTD(typeof(MarsRtdServer).FullName, null, isin);
        }
    }
}

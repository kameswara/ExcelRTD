using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace MarsExcel
{
    [Guid("21667cf3-c011-49b6-a25c-7ec95fa7b60c")]
    [ComVisible(true)]
    public interface IMarsCom
    {
        double GetSpot(string isin);
    }
}

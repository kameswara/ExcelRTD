using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace MarsExcel
{
    [Guid("b02ada99-00ce-4a73-a57c-fba4d66aac99")]
    [ComVisible(true)]
    [ClassInterface(ClassInterfaceType.None)]
    [ComDefaultInterface(typeof(IMarsCom))]
    public class MarsCom : IMarsCom
    {
        public double GetSpot(string isin)
        {
            return 42;
        }
    }
}

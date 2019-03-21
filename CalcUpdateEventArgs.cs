using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MarsExcel
{
    public class CalcUpdateEventArgs : EventArgs
    {
        public double Value { get; private set; }

        public string ISIN { get; private set; }

        public CalcUpdateEventArgs(string isin, double value)
        {
            this.ISIN = isin;
            this.Value = value;
        }
    }
}

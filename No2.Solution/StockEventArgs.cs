using System;

namespace No2.Solution
{
    public class StockEventArgs : EventArgs
    {
        public StockEventArgs(int usd, int euro)
        {
            this.USD = usd;
            this.Euro = euro;
        }

        public int USD { get; set; }
        public int Euro { get; set; }
    }
}

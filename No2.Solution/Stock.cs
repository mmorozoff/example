using System;
using System.Collections.Generic;

namespace No2.Solution
{
    public class Stock
    {
        public event EventHandler<StockEventArgs> StockChanged;

        /// <summary>
        /// Method for event.
        /// </summary>
        /// <param name="eventArgs">Event arguments.</param>
        protected virtual void OnStockChanged(StockEventArgs eventArgs)
            => this.StockChanged(this, eventArgs);

        public void Market()
        {
            Random rnd = new Random();
            int usd = rnd.Next(20, 40);
            int euro = rnd.Next(30, 50);
            this.OnStockChanged(new StockEventArgs(usd, euro));
        }
    }
}

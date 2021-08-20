using System;

namespace No2.Solution
{
    public class Broker
    {
        public string Name { get; set; }

        public Broker(string name)
        {
            this.Name = name;
        }

        public void Register(Stock stock)
        {
            stock.StockChanged += this.StockUpdate;
        }

        public void UnRegister(Stock stock)
        {
            stock.StockChanged -= this.StockUpdate;
        }

        private void StockUpdate(object sender, StockEventArgs eventArgs)
        {
            Console.WriteLine(
                eventArgs.USD > 30
                    ? $"Broker {this.Name} sells dollars; Dollar rate: {eventArgs.USD}"
                    : $"Broker {this.Name} buys dollars; Dollar rate: {eventArgs.USD}");
        }
    }
}

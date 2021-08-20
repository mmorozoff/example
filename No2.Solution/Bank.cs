using System;

namespace No2.Solution
{
    public class Bank
    {
        public string Name { get; set; }

        public Bank(string name)
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
                eventArgs.Euro > 40
                    ? $"Bank {this.Name} sells euros; Euro rate:{eventArgs.Euro}"
                    : $"Bank {this.Name} is buying euros; Euro rate: {eventArgs.Euro}");
        }
    }
}

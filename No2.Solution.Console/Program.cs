namespace No2.Solution.Console
{
    static class Program
    {
        static void Main(string[] args)
        {
            var stock = new Stock();

            var bank = new Bank("Bank");
            var broker = new Broker("Broker");
            bank.Register(stock);
            broker.Register(stock);
            stock.Market();

            System.Console.ReadLine();
        }
    }
}
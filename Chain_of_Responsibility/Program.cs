using System.Transactions;

namespace Chain_of_Responsibility
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IHandler fraudHandler = new LowLevelSupport();
            IHandler complianceHandler = new MiddleLevelSupport();
            IHandler paymentHandler = new HighLevelSupport();
            fraudHandler.SetNext(complianceHandler).SetNext(paymentHandler);

            fraudHandler.Handle("Подержка:Сайт не работает.");

            Console.WriteLine("\nНажмите любую клавишу для выхода..."); 
            fraudHandler.Handle("Подержка:1.");

            Console.WriteLine("\nНажмите любую клавишу для выхода..."); 
            fraudHandler.Handle("Подержка:2");

            Console.WriteLine("\nНажмите любую клавишу для выхода...");

            Console.ReadKey();
        }

    }
}

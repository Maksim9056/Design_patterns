namespace Adapter
{
    internal class Program
    {
    
        static void Main(string[] args)
        {
            // У нас есть старый класс
            PaymentGateway oldPrinter = new PaymentGateway();

            // Создаём адаптер
            IPaymentService adapter = new Adapter(oldPrinter);

            // Клиент работает с IMessageSender
            Client client = new Client(adapter);

            client.DoWorkPay(10);
            client.DoWorkRefund(15);


            Console.ReadLine();
        }
    }
}

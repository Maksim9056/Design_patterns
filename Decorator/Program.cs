namespace Decorator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Базовый компонент
            IDataSource notifier = new FileDataSource();

            // Оборачиваем его в декоратор SMS
            notifier = new EncryptionDecorator(notifier);

            // Оборачиваем ещё и в Push-декоратор
            notifier = new CompressionDecorator(notifier);

            notifier.ReadData();

            notifier.WriteData("Hello");
            Console.ReadLine();
        }
    }
}

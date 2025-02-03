namespace Proxy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IImage image = new ImageProxy("Hamster.png");

            Console.WriteLine("Первый вызов Display:");
            image.Display();

            Console.WriteLine("\nВторой вызов Display:");
            image.Display();
            Console.ReadLine();
        }
    }
}

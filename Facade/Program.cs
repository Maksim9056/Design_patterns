namespace Facade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GameFacade game = new GameFacade();

            game.StyleFight("Гоблин", "Огненный шар", 50);

            Console.ReadKey();
        }
    }
}

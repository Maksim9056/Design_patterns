namespace Bridge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IRenderer rasterRenderer = new RasterRenderer();
            IRenderer vectorRenderer = new VectorRenderer();

            Shape circle1 = new Circle(rasterRenderer, 10, 10, 5);
            Shape square1 = new Square(vectorRenderer, 20, 20, 10);

            circle1.Draw(); 
            square1.Draw(); 
            Console.ReadLine();
        }
    }
}

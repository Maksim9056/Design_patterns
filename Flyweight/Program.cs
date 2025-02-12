namespace Flyweight
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double longitude = 37.61;
            double latitude = 55.74;

            FactoryPage houseFactory = new FactoryPage();
            for (int i = 0; i < 5; i++)
            {
                Document panelHouse = houseFactory.GetDocument("Panel");
                if (panelHouse != null)
                    panelHouse.Create(longitude, latitude);
                longitude += 0.1;
                latitude += 0.1;
            }

            for (int i = 0; i < 5; i++)
            {
                Document brickHouse = houseFactory.GetDocument("Brick");
                if (brickHouse != null)
                    brickHouse.Create(longitude, latitude);
                longitude += 0.1;
                latitude += 0.1;
            }

            foreach (var document in  houseFactory.Document)
            {
                Console.WriteLine($"Ключ :{document.Key} Значение:{document.Value}");
            }
            Console.ReadKey();
        }
    }
}

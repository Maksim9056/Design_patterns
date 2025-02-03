namespace Composite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Листовые объекты
            IFileSystemItem line1 = new File("File.txt",100);
            IFileSystemItem line2 = new File("File.mp4", 2000);
            IFileSystemItem rect1 = new File("File.mp3", 10);

            var composite = new Directory("Images");
            composite.Add(line1);
            composite.Add(rect1);

            var composite2 = new Directory("Root");
            composite2.Add(line2);

            composite.Add(composite2);

            composite.PrintInfo();
            Console.ReadLine();
        }
    }
}

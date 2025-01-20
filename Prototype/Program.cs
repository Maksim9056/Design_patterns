namespace Prototype
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle originalCircle = new Circle(
                nameShape : "Circle",
                X: 10,
                Y: 100,
                Z: 20,
                W: 15,
                equipment: new EnduranceShape { Endurance = "Gold" }
            );

            Console.WriteLine("=== Оригинал Circle ===");
            Console.WriteLine(originalCircle);

            Circle clonedCircle = (Circle)originalCircle.Clone();
            clonedCircle.NameShape = "clonedKnight";
            clonedCircle.Equipment.Endurance = "Golden ";

            Console.WriteLine("\n=== Клон Circle ===");
            Console.WriteLine(clonedCircle);

            Console.WriteLine("\n=== Проверяем оригинал после изменения клона ===");
            Console.WriteLine(originalCircle);


            Rectangle originalRectangle = new Rectangle(
                nameShape :"Rectangle",
                X: 101,
                Y: 1010,
                Z: 210,
                W: 115,
                equipment: new EnduranceShape { Endurance = "Gold" }
            );

            Rectangle clonedRectangle = (Rectangle)originalRectangle.Clone();
            clonedRectangle.NameShape = "clonedRectangle";
            clonedRectangle.Equipment.Endurance = "BRONZE";

            Console.WriteLine("\n=== Оригинал Rectangle ===");
            Console.WriteLine(originalRectangle);
            Console.WriteLine("\n=== Клон Rectangle ===");
            Console.WriteLine(clonedRectangle);

                WordDocument wordDocument = new WordDocument(
                названиеДокумента: "Word Document",
                автор:"Maksim Bobretsov",
                дата: DateTime.Now,
                тип_Документов: "WordDocument"


                );

            WordDocument clonedwordDocument = (WordDocument)wordDocument.Clone();

            Console.WriteLine("\n=== Оригинал WordDocument ===");
            Console.WriteLine(wordDocument);
            Console.WriteLine("\n=== Клон WordDocument ===");
            Console.WriteLine(clonedwordDocument);


            PdfDocument pdfDocument = new PdfDocument(
             названиеДокумента: "PdfDocument Document",
             автор: "Maksim Bobretsov",
             дата: DateTime.Now,
             тип_Документов: "PdfDocument"
             );
            PdfDocument clonedpdfDocument = (PdfDocument)pdfDocument.Clone();


            Console.WriteLine("\n=== Оригинал PdfDocument ===");
            Console.WriteLine(pdfDocument);
            Console.WriteLine("\n=== Клон PdfDocument ===");
            Console.WriteLine(clonedpdfDocument);




            Console.WriteLine("\nНажмите любую клавишу для выхода...");


            Console.ReadKey();

        }
    }
}

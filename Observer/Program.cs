namespace Observer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Создаём чат
            Product Product = new Product();

            // Создаём несколько клиентов (наблюдателей)
            Customer alice = new Customer("Alice");
            Supplier bob = new Supplier("Bob");
            Customer eve = new Customer("Eve");

            // Подписываем их на чат
            Product.Attach(alice);
            Product.Attach(bob);
            Product.Attach(eve);

            Console.WriteLine("Alice отправляет сообщение в чат: \"Hello, everyone!\"");
            Product.PublishMessage("Покупатели: товар есть");

            Console.WriteLine();

            //Console.WriteLine(");
            Product.PublishMessage("Bob товар заканчивается");

            Product.PublishMessage("Покупатели: исчезает товар со склада");

            Console.WriteLine("\nНажмите любую клавишу для выхода...");
            Console.ReadKey();

        }
    }
}

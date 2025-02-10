namespace Strategy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list =  [1,2,3,];
            ISortStrategy BubbleSortStrategy = new BubbleSortStrategy();
            SorterContext SorterContext = new SorterContext(BubbleSortStrategy);

            SorterContext.ExecuteSort(list);
          

            Console.WriteLine();

            // Решили сменить на PayPal
            ISortStrategy QuickSortStrategy = new QuickSortStrategy();
            SorterContext.Strategy_new(QuickSortStrategy);
            SorterContext.ExecuteSort(list);
       

            Console.WriteLine();

            // Допустим, наличные
            ISortStrategy MergeSortStrategy = new MergeSortStrategy();
            SorterContext.Strategy_new(MergeSortStrategy);
            SorterContext.ExecuteSort(list);
       

            Console.WriteLine("\nНажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}

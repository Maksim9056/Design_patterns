using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class QuickSortStrategy : ISortStrategy
    {
        public QuickSortStrategy()
        {


        }

        public List<int> Sort(List<int> data)
        {
            data.Sort();
            Console.WriteLine("QuickSortStrategy");

            return data.ToList();
        }
    }
}

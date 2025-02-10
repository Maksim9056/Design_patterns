using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class BubbleSortStrategy  : ISortStrategy
    {
        public BubbleSortStrategy()
        {


        }

        public List<int> Sort(List<int> data)
        {
            data.Sort();
            Console.WriteLine("BubbleSortStrategy");
            return data.ToList();
        }
    }

}

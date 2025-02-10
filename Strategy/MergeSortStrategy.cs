using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class MergeSortStrategy : ISortStrategy
    {
        public MergeSortStrategy() 
        {
            
        
        }

        public List<int> Sort(List<int> data)
        {
            Console.WriteLine("MergeSortStrategy");

            data.Sort();
            return data.ToList();
        }
    }
}

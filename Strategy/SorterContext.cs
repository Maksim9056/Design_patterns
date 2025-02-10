using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class SorterContext
    {
        public  ISortStrategy Strategy;
        public SorterContext(ISortStrategy strategy) 
        {
            Strategy = strategy;
        }
        public void Strategy_new(ISortStrategy newStrategy)
        {
            Strategy = newStrategy;
        }

        public void  ExecuteSort(List<int> data)
        {
          var Sort =   Strategy.Sort(data);
            foreach (var item in Sort)
            {
                Console.WriteLine(item);
            }
        }
    }
}

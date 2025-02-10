using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_Responsibility
{
    public class HighLevelSupport :IHandler
    {
        private IHandler _nextHandler;
        public IHandler SetNext(IHandler next)
        {

           return   _nextHandler = next;
        }
        public void Handle(string request)
        {
            _nextHandler?.Handle(request);
            Console.WriteLine($"HighLevelSupport {request}");
            //return true;
        }

     
    }
}

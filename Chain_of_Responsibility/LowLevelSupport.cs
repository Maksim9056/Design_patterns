using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_Responsibility
{
    public class LowLevelSupport : IHandler
    {
        private IHandler _nextHandler;
        public void Handle(string request)
        {
            Console.WriteLine($"LowLevelSupport {request}");
            _nextHandler?.Handle(request);

            //return false;
        }

        public IHandler SetNext(IHandler next)
        {

          return   _nextHandler = next;
        }
    }
}

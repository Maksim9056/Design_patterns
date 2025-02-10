using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_Responsibility
{
    public class MiddleLevelSupport : IHandler
    {
        private IHandler _nextHandler;
        public void Handle(string request)
        {

            _nextHandler?.Handle(request);
            Console.WriteLine($"MiddleLevelSupport {request}");

            //return true;
        }

        public IHandler SetNext(IHandler next)
        {

            _nextHandler = next;
            return _nextHandler;
        }
    }
}

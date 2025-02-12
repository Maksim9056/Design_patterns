using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    public class FactoryPage
    {
        public Dictionary<string,Document> Document = new Dictionary<string,Document>();
        public FactoryPage() 
        {

            Document.Add("TextDocument", new TextDocument());

        }

        public Document GetDocument(string key)
        {
            if (Document.ContainsKey(key))
                return Document[key];
            else
                return null;
        }
    }
}

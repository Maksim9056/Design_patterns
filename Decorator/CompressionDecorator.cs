using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class CompressionDecorator : DataSourceDecorator
    {
        public CompressionDecorator(IDataSource wrappee) : base(wrappee) { }

        public void ReadData()
        {
            _wrappee.ReadData();
        }

        public void WriteData(string data)
        {
            _wrappee.WriteData(data);

        }
    }
}

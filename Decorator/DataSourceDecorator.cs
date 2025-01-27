using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public abstract class DataSourceDecorator : IDataSource
    {
        protected readonly IDataSource _wrappee;

        protected DataSourceDecorator(IDataSource wrappee)
        {
            _wrappee = wrappee;
        }

        public virtual void ReadData()
        {
            _wrappee.ReadData();

        }

        public virtual  void WriteData(string data)
        {
            _wrappee.WriteData(data);

        }
    }
}

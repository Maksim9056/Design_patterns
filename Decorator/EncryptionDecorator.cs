using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class EncryptionDecorator : DataSourceDecorator
    {
        public EncryptionDecorator(IDataSource wrappee) : base(wrappee) { }


        public override void ReadData()
        {
            _wrappee.ReadData();
            Console.WriteLine("Чтение");
        }

        public override void WriteData(string data)
        {
            _wrappee.WriteData(data);
            Console.WriteLine("Запись");
        }
    }
}

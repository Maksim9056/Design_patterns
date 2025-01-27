using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class FileDataSource : IDataSource
    {

        public readonly string _File;
        public void ReadData()
        {
            File.ReadAllBytes(_File);
        }

        public void WriteData(string data)
        {
            File.WriteAllText(_File, data);
        }
    }
}

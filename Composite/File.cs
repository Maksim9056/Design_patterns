using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public class File : IFileSystemItem
    {
        public string Name { get; }
        public long Size { get; }

        public File(string name, long size)
        {
            Name = name;
            Size = size;
        }

        public void PrintInfo(string indent = "")
        {
            Console.WriteLine($"{indent}File: {Name} ({Size} bytes)");

        }

        long IFileSystemItem.GetSize() => Size;
    }
}

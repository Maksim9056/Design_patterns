using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Composite
{
    internal class Directory : IFileSystemItem
    {

        public string Name { get; }

        private readonly List<IFileSystemItem> _children = new List<IFileSystemItem>();

        public long GetSize()
        {
            long totalSize = 0;
            foreach (var item in _children)
            {
                totalSize += item.GetSize();
            }
            return totalSize;
        }

        public void Add(IFileSystemItem graphic)
        {
            _children.Add(graphic);
        }


        public Directory(string name)
        {
            Name = name;
        }

        public void PrintInfo(string indent = "")
        {
            foreach (var item in _children)
            {
                item.PrintInfo(indent+"");

            }
        }
    }
}

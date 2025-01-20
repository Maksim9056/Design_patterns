using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class User
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public long Age { get; set; }
        public string Email { get; set; }

        public override string ToString()
        {
            return $"UserName: {UserName}, Password: {Password}, RAM: {Age}, Email: {Email}";
        }
    }
}

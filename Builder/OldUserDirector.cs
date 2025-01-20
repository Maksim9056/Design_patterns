using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class OldUserDirector
    {

        public User Build(IUser builder)
        {
            builder.SetUserName();
            builder.SetPassword();
            builder.SetEmail();
            builder.SetAge();
            return builder.User();
        }
    }
}

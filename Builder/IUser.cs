using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Builder
{
    public interface IUser
    {
        void SetUserName();
        void SetPassword();
        void SetAge();
        void SetEmail();
        User User();


    }
}
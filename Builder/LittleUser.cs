using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class LittleUser : IUser
    {
        private User User = new User();

        public void SetAge() => User.Age = 8;


        public void SetEmail() => User.Email = "max@mail.ru";

        public void SetPassword() => User.Password = "1";

        public void SetUserName() => User.UserName = "Bogdan";

        User IUser.User() => User;
    }
}

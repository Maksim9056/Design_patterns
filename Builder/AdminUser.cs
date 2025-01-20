using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class AdminUser : IUser
    {
        private User _User = new User();

        public  void SetAge() => _User.Age = 19;


        public void SetEmail() => _User.Email = "user@mail.ru";

        public void SetPassword() => _User.Password = "password";

        public void SetUserName() => _User.UserName = "Maksim";

        User IUser.User() => _User;
    }
}

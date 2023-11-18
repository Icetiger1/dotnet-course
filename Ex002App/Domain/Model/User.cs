using System;
namespace Model
{
    class User
    {
        public string Login{get; set; }
        public string Password{private get; set; }

        public User(string login)
        {
            Password = Guid.NewGuid().ToString().Substring(0,8);
            this.Login = login;
        }
    }
}
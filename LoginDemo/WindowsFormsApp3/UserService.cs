using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    public class UserService
    {
        private IUserStore _store;
        public UserService(IUserStore store)
        {
            _store = store;
        }

        public User Register(string name, string username, string password)
        {
            var user = new User()
            {
                Name = name,
                Password = password,
                Username = username
            };

            _store.AddUser(user);

            return user;
        }


        public bool Check(string username, string password)
        {
            var user = _store.GetUsers()
                .Where(x => x.Username == username && x.Password == password)
                .FirstOrDefault();

            return user != null;
        }

    }
}

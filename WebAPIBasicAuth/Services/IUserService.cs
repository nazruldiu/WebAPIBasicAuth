using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPIBasicAuth.Entities;

namespace WebAPIBasicAuth.Services
{
    public interface IUserService
    {
        Task<User> Authenticate(string username, string password);
    }

    public class UserService : IUserService
    {
        private List<User> userList = new List<User>
        {
            new User{Id = 1, Username="admin", Password="123456"},
            new User{Id = 2, Username="user", Password="123456"}
        };

        public Task<User> Authenticate(string username, string password)
        {
            var user = Task.Run(()=> userList.SingleOrDefault(x => x.Username == username && x.Password == password));
            return user;
        }
    }
}

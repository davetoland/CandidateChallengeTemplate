using System;
using System.Collections.Generic;

namespace CodingChallengeApiTemplate.Services
{
    public interface IUserAccountService
    {
        IEnumerable<UserAccount> GetUsers();
        UserAccount GetUserById(long id);
        void CreateUser(UserAccount user);
        void UpdateUser(UserAccount user);
    }

    public class UserAccountService : IUserAccountService
    {
        private List<UserAccount> UserAccounts { get; set; } = new List<UserAccount>
        {
            new UserAccount
            {
                Id = 0,
                FirstName = "John",
                LastName = "Doe",
                Email = "john.@doe.com",
                Avatar = "user.png"
            },
            new UserAccount
            {
                Id = 1,
                FirstName = "Jane",
                LastName = "Doe",
                Email = "jane.@doe.com",
                Avatar = "user.png"
            },
        };

        public IEnumerable<UserAccount> GetUsers()
        {
            throw new NotImplementedException();
        }

        public UserAccount GetUserById(long id)
        {
            throw new NotImplementedException();
        }

        public void CreateUser(UserAccount user)
        {
            throw new NotImplementedException();
        }

        public void UpdateUser(UserAccount user)
        {
            throw new NotImplementedException();
        }
    }
}

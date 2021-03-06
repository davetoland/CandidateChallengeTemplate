using System;

namespace CodingChallengeApiTemplate
{
    public class UserAccount
    {
        public long Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email  { get; set; }

        public string Avatar { get; set; }

        public string PasswordHash { get; set; }

        public string PasswordSalt { get; set; }

        public DateTime CreatedOn { get; set; }
    }
}

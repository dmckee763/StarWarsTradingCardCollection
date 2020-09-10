using System;
using System.Collections.Generic;

namespace StarWarsTradingCardCollectionAPI.Models
{
    public partial class User
    {
        public User()
        {
            UserCard = new HashSet<UserCard>();
        }

        public int UserId { get; set; }
        public string EmailAddress { get; set; }
        public byte[] Password { get; set; }

        public virtual ICollection<UserCard> UserCard { get; set; }
    }
}

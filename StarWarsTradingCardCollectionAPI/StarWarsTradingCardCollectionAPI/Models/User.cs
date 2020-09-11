using System;
using System.Collections.Generic;

namespace StarWarsTradingCardCollectionAPI.Models
{
    public partial class User
    {
        public Guid UserId { get; set; }
        public string EmailAddress { get; set; }
        public byte[] Password { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace StarWarsTradingCardCollectionAPI.Models
{
    public partial class UserCard
    {
        public int UserId { get; set; }
        public int CardId { get; set; }

        public virtual Card Card { get; set; }
        public virtual User User { get; set; }
    }
}

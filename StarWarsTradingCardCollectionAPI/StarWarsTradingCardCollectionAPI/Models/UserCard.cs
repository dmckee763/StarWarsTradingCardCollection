using System;
using System.Collections.Generic;

namespace StarWarsTradingCardCollectionAPI.Models
{
    public partial class UserCard
    {
        public Guid? UserId { get; set; }
        public Guid? CardId { get; set; }

        public virtual Card Card { get; set; }
        public virtual User User { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace StarWarsTradingCardCollectionAPI.Models
{
    public partial class Card
    {
        public Card()
        {
            UserCard = new HashSet<UserCard>();
        }

        public int CardId { get; set; }
        public string CardNo { get; set; }
        public string CardName { get; set; }
        public int SeriesId { get; set; }

        public virtual Series Series { get; set; }
        public virtual ICollection<UserCard> UserCard { get; set; }
    }
}
